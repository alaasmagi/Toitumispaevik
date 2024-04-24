Imports System.Data.SQLite
Imports System.IO
Public Class CAnaluus

    'Kasutab IAnaluusi
    Implements IAnaluus

    'Loome muutujad hommik, louna, ohtu ja vahepala, et kasutada neid väärtusi päevase kaloraaši leidmiseks
    Private hommik As Double
    Private louna As Double
    Private ohtu As Double
    Private vahepala As Double

    Public Function PaevaseAndmereaParing(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal otsitavSuurus As String) As Integer Implements IAnaluus.PaevaseAndmereaParing
        Dim paevasedAndmed As Integer = -1
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = $"SELECT {otsitavSuurus} FROM user_daily_data WHERE user_id = @kasutaja_id AND date = @kuupaev"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.Parameters.AddWithValue("@kuupaev", kuupaev)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    paevasedAndmed = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return paevasedAndmed
    End Function

    Public Function TuhjaPaevaseAndmereaSisestus(ByVal kasutaja_id As Integer, ByVal kaal As Integer, ByVal kuupaev As Integer) As Integer Implements IAnaluus.TuhjaPaevaseAndmereaSisestus
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
       (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = "INSERT INTO user_daily_data (user_id, date, daily_weight, energy_intake, energy_consumption, energy_balance) 
                                        VALUES (@kasutaja_id, @kuupaev, 0, 0, 0, 0)"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return kasutaja_id
    End Function

    'Kalori ülejäägi päring
    Public Function PariKaloriUlejaak(tarbitudKcal As Integer, KcalLimiit As Integer) As Integer Implements IAnaluus.PariKaloriUlejaak
        'Juhul kui tarbitud on rohkem, kui kalori limiit, tagastatakse null
        If tarbitudKcal > KcalLimiit Then
            Return 0
        Else
            'Igal muul jhul tagstatakse kalorilimiit - tarbitud kalorid, ehk kalorite ülejääk.
            Return KcalLimiit - tarbitudKcal
        End If
        Return 0
    End Function

    'Funktsioon mille kaudu saab läbi interface'i küsida antud päeva ajas tarbitud kaloreid. Toidukorrad on andmebaasis märgitud numbritega 0-3
    Public Function PariKcalPaveaHetkest(kuupaev As Integer, kasutaja_id As Integer, toidukord As Integer) As Integer Implements IAnaluus.PariKcalPaveaHetkest
        'vastavalt toidukorrale, mis antud on viiakse läbi protsess, kus kutsutakse esile andmebaasi päring tarbitud kaloritele ja tagastatakse see väärtus
        Select Case toidukord
            Case 0
                hommik = MassiiviLiikmedKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return hommik
            Case 1
                louna = MassiiviLiikmedKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return louna
            Case 2
                vahepala = MassiiviLiikmedKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return vahepala
            Case 3
                ohtu = MassiiviLiikmedKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return ohtu
        End Select
        Return 0
    End Function

    'Võtab kaasa antud dictionary ja võtme stringi, mille järgi tagastatakse stringile vastav väärtus.
    Public Function PariValueMap(keyStr As String, ByVal valueMap As Dictionary(Of String, Integer)) As Integer Implements IAnaluus.PariValueMap
        If valueMap.ContainsKey(keyStr) Then
            Return valueMap(keyStr)
        End If
        Return 0
    End Function

    'Lisab valueamp dictionary'sse väärtused, mis numbriliselt vastavad sringidele 7 päeva, 1 kuu jne.
    Public Sub LisaValueMap(newKeyStr As String, newValue As Integer, ByVal valueMap As Dictionary(Of String, Integer)) Implements IAnaluus.LisaValueMap
        If Not valueMap.ContainsKey(newKeyStr) Then
            valueMap.Add(newKeyStr, newValue)
        End If
    End Sub

    Public Function PaevaneKcal(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer) As Integer Implements IAnaluus.PaevaneKcal
        Dim soodudKalorid As Integer = hommik + louna + vahepala + ohtu

        Dim treeninguKalorid As Double() = PaevasedTreeningud(kasutaja_id, kuupaev, "total_consumption")
        Dim treeninguKaloridKokku As Integer = 0
        For index = 0 To treeninguKalorid.Count - 1
            treeninguKaloridKokku = treeninguKaloridKokku + treeninguKalorid(index)
        Next
        Dim kaloriteVahe As Integer = soodudKalorid - treeninguKaloridKokku
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version= 3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim updateDataSql As String = $"UPDATE user_daily_data SET energy_intake = @kaloridKokku, energy_consumption = @treeninguKaloridKokku,
                                            energy_balance = @kaloriteVahe WHERE user_id = @kasutaja_id And Date = @kuupaev;"
            Using cmdUpdateData As New SQLiteCommand(updateDataSql, connection)
                cmdUpdateData.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmdUpdateData.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmdUpdateData.Parameters.AddWithValue("@kaloridKokku", soodudKalorid)
                cmdUpdateData.Parameters.AddWithValue("@treeninguKaloridKokku", treeninguKaloridKokku)
                cmdUpdateData.Parameters.AddWithValue("@kaloriteVahe", kaloriteVahe)
                cmdUpdateData.ExecuteNonQuery()
            End Using
        End Using

        Return soodudKalorid
    End Function

    'Kalori koguse pärimine andmebaasist päevakorra kohta.
    Private Function KclParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal toidukord As Integer) As Double() Implements IAnaluus.KclParingAndmebaasist
        'määran andmebaasi asukoha
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        'määran andmebaasi päringu
        Dim paring As String = "Select energy_intake FROM user_food_history WHERE user_id = @kasutaja_id And Date = @kuupaev And time_of_meal = @toidukord;"
        'uus array väärtuste salvestamiseks
        Dim doubleValues As New List(Of Double)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                command.Parameters.AddWithValue("@kuupaev", kuupaev)
                command.Parameters.AddWithValue("@toidukord", toidukord)

                'avan suhtluskanali andmebaasiga
                connection.Open()

                'loen andmebaasist kuni antud kriteeriumitega on andmed otsas.
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        For i As Double = 0 To reader.FieldCount - 1
                            doubleValues.Add(reader.GetDouble(i))
                        Next
                    End While
                End Using

            End Using
        End Using

        'tagastan täidetud array
        Return doubleValues.ToArray()

    End Function

    'Kasutaja kaalu olekute päring teatud ajavahemikus andmebaasist. Sama teema pmst mis KcalParingAndmebaasist.
    Public Function KaaluParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal graafikuPikkus As Integer) As Double() Implements IAnaluus.KaaluParingAndmebaasist
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
    (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = "Select daily_weight FROM user_daily_data WHERE user_id = @kasutaja_id And Date BETWEEN @startDate And @endDate ORDER BY Date ASC;"
        Dim doubleValues As New List(Of Double)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Dim startDate As Integer = kuupaev - graafikuPikkus
                Dim endDate As Integer = kuupaev
                command.Parameters.AddWithValue("@startDate", startDate)
                command.Parameters.AddWithValue("@endDate", endDate)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        doubleValues.Add(reader.GetDouble(0))
                    End While
                End Using

            End Using
        End Using
        Return doubleValues.ToArray()
    End Function

    Public Function KaaluLisamine(ByVal kasutaja_id As Integer, ByVal uus_kaal As Double) As Double Implements IAnaluus.KaaluLisamine
        Dim kuupaev As Integer = KuupaevIntegeriks(Date.Now.Date)
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim updateDataSql As String = $"UPDATE user_daily_data Set daily_weight = @kaal WHERE user_id = @kasutaja_id And Date = @kuupaev;"
            Using cmdUpdateData As New SQLiteCommand(updateDataSql, connection)
                cmdUpdateData.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmdUpdateData.Parameters.AddWithValue("@kaal", uus_kaal)
                cmdUpdateData.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmdUpdateData.ExecuteNonQuery()
            End Using
        End Using
        Return uus_kaal
    End Function

    'Kaalu kuupäeva päring andmebaasist käib käsikäes kaalu päringuga andmebaasist ja massiivid järjestatakse üksteisega vastavusse.
    'KaaluParingAndmebaasist saadud massiivi esimene liige on kõige vanem andmepunkt kaalu lahtris ja KaaluDateParingAndmebaasist saadud massiivi
    'esimene liige on sellele kaalule vastav kuupäev.
    Public Function KaaluDateParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal graafikuPikkus As Integer) As Integer() Implements IAnaluus.KaaluDateParingAndmebaasist
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
    (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = "Select Date FROM user_daily_data WHERE user_id = @kasutaja_id And Date BETWEEN @startDate And @endDate ORDER BY Date ASC;"
        Dim intValues As New List(Of Integer)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Dim startDate As Integer = kuupaev - graafikuPikkus
                Dim endDate As Integer = kuupaev
                command.Parameters.AddWithValue("@startDate", startDate)
                command.Parameters.AddWithValue("@endDate", endDate)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        intValues.Add(reader.GetDouble(0))
                    End While
                End Using

            End Using
        End Using
        Return intValues.ToArray()
    End Function

    'Võtab arvude massiivi ja liidab selle liikmed omavahel. tagastab saadud tulemuse
    Private Function MassiiviLiikmedKokku(ByRef KcalLoend As Double()) As Double Implements IAnaluus.MassiivLiikmedKokku
        Dim koguvaartus As Double = 0

        For i As Integer = 0 To KcalLoend.Length - 1
            koguvaartus += KcalLoend(i)
        Next
        Return koguvaartus
    End Function

    'Teisendab kuupäeva numbriks unix aja suhtes
    Public Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer Implements IAnaluus.KuupaevIntegeriks
        Dim unixAeg As New DateTime(1970, 1, 1)
        Return (sisendKuupaev - unixAeg).Days
    End Function

    'teisendab numbri tagasi kuupäeva formaati unix aja suhtes
    Public Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime Implements IAnaluus.IntegerKuupaevaks
        Dim unixAeg As New DateTime(1970, 1, 1)
        Return (unixAeg.AddDays(sisendInteger))
    End Function


    Public Function RetseptiToiduaineToitevaartuseArvutus(ByVal toitevaartus100gKohta As Integer, ByVal kogus As Integer) As Integer Implements IAnaluus.RetseptiToiduaineToitevaartuseArvutus
        Return (toitevaartus100gKohta / 100) * kogus
    End Function


    Public Function DBParingBMR(ByVal kasutaja_id As Integer, ByVal sugu As Integer, ByVal vanus As Integer, ByVal kaal As Double, ByVal kaaluEesmark As Double, ByVal pikkus As Integer,
                                ByVal kuupaev As Integer) As Integer Implements IAnaluus.DBParingBMR
        Dim kcal_limiit As Integer = 0
        Dim kulutatudKcal As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Dim paring As String = "Select AVG(total_consumption) As average_total_consumption
                                        FROM user_training_history
                                        WHERE user_id = @kasutaja_id AND date >= date('now', '-7 days');"

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using cmd As New SQLiteCommand(paring, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                connection.Open()
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    kulutatudKcal = Convert.ToInt32(result)
                End If
            End Using
            ' Kaalu tõstmine (u 0,5 kg nädalas)
            If (kaal < kaaluEesmark) Then
                If sugu = 0 Then
                    kcal_limiit = 10 * kaal + 6.25 * pikkus - 5 * vanus + 5 + kulutatudKcal + 500
                Else
                    kcal_limiit = 10 * kaal + 6.25 * pikkus - 5 * vanus - 161 + kulutatudKcal + 500
                End If
                ' Kaalu langetamine (u 0,5 kg nädalas)
            ElseIf (kaal > kaaluEesmark) Then
                If sugu = 0 Then
                    kcal_limiit = 10 * kaal + 6.25 * pikkus - 5 * vanus + 5 + kulutatudKcal - 500
                Else
                    kcal_limiit = 10 * kaal + 6.25 * pikkus - 5 * vanus - 161 + kulutatudKcal - 500
                End If
                ' Kaalu hoidmine
            Else
                If sugu = 0 Then
                    kcal_limiit = 10 * kaal + 6.25 * pikkus - 5 * vanus + 5 + kulutatudKcal
                Else
                    kcal_limiit = 10 * kaal + 6.25 * pikkus - 5 * vanus - 161 + kulutatudKcal
                End If
            End If

            Dim updateDataSql As String = $"UPDATE user_data SET calorie_limit = @kcal_limiit WHERE user_id = @kasutaja_id;"
            Using cmdUpdateData As New SQLiteCommand(updateDataSql, connection)
                cmdUpdateData.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmdUpdateData.Parameters.AddWithValue("@kcal_limiit", kcal_limiit)
                cmdUpdateData.ExecuteNonQuery()
            End Using
        End Using

        Return kcal_limiit
    End Function

    'Andmebaasist päritakse kindla makroaine kogus teatud kuupäeval. töötab nagu teisedki päringu funktsioonid
    Private Function MakroaineParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal makroaine As String) As Double() Implements IAnaluus.MakroaineParingAndmebaasist
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = "SELECT " & makroaine & " FROM user_food_history WHERE user_id = @kasutaja_id AND date = @kuupaev"
        Dim doubleValues As New List(Of Double)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                command.Parameters.AddWithValue("@kuupaev", kuupaev)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        For i As Double = 0 To reader.FieldCount - 1
                            doubleValues.Add(reader.GetDouble(i))
                        Next
                    End While
                End Using

            End Using
        End Using
        Return doubleValues.ToArray()

    End Function

    'kasutatakse kaasa antud makro ainet, et kutsuda esile antud makroaine koguse päring ja tagastada saadud tulemus.
    Public Function PariMakroaineKogus(kuupaev As Integer, kasutaja_id As Integer, makroaine As String) As Integer Implements IAnaluus.PariMakroaineKogus
        Select Case makroaine
            Case "total_c_hydrates"
                Return MassiiviLiikmedKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

            Case "total_sugar"
                Return MassiiviLiikmedKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

            Case "total_protein"
                Return MassiiviLiikmedKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

            Case "total_lipid"
                Return MassiiviLiikmedKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

        End Select
        Return 0
    End Function
    Public Function PaevasedTreeningud(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal otsitavSuurus As String) As Double() Implements IAnaluus.PaevasedTreeningud
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = $"SELECT {otsitavSuurus} FROM user_training_history WHERE user_id = @kasutaja_id AND date = @kuupaev"
        Dim doubleValues As New List(Of Double)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                command.Parameters.AddWithValue("@kuupaev", kuupaev)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        For i As Double = 0 To reader.FieldCount - 1
                            doubleValues.Add(reader.GetDouble(i))
                        Next
                    End While
                End Using
            End Using
        End Using
        Return doubleValues.ToArray()
    End Function
    Public Function PaevasedToidud(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal otsitavSuurus As String) As Double() Implements IAnaluus.PaevasedToidud
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = $"SELECT {otsitavSuurus} FROM user_food_history WHERE user_id = @kasutaja_id AND date = @kuupaev"
        Dim doubleValues As New List(Of Double)
        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                command.Parameters.AddWithValue("@kuupaev", kuupaev)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        For i As Double = 0 To reader.FieldCount - 1
                            doubleValues.Add(reader.GetDouble(i))
                        Next
                    End While
                End Using
            End Using
        End Using
        Return doubleValues.ToArray()
    End Function
End Class
