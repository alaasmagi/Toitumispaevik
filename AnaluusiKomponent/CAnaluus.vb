Imports System.Data.SQLite
Imports System.IO
Public Class CAnaluus

    Implements IAnaluus

    Private hommik
    Private louna
    Private ohtu
    Private vahepala

    ' Taaskasutatav funktsioon andmete pärimiseks tabelist user_daily_data, tagastatakse päritud andmed
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

    ' Juhul kui kasutaja jätab mingil päeval sisestused vahele, lisatakse tabelisse user_daily_data numbrilistesse kohtadesse 0
    Public Function TuhjaPaevaseAndmereaSisestus(ByVal kasutaja_id As Integer, ByVal kaal As Integer, ByVal kuupaev As Integer) As Integer Implements IAnaluus.TuhjaPaevaseAndmereaSisestus
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
       (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = "INSERT INTO user_daily_data (user_id, date, daily_weight, energy_intake, energy_consumption, energy_balance) 
                                        VALUES (@kasutaja_id, @kuupaev, @kaal, 0, 0, 0)"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.Parameters.AddWithValue("@kaal", kaal)
                cmd.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return kasutaja_id
    End Function

    ' Arvutatakse kasutaja päevane kaloraaži ülejääk, tagastatakse saadud ülejääk
    Public Function PariKaloriUlejaak(tarbitudKcal As Integer, KcalLimiit As Integer) As Integer Implements IAnaluus.PariKaloriUlejaak
        If tarbitudKcal > KcalLimiit Then
            Return 0
        Else
            Return KcalLimiit - tarbitudKcal
        End If
        Return 0
    End Function

    ' Toidukorra kaloraži arvutus päeva kohta kasutades funktsiooni KclParingAndmebaasist, tagastatakse toidukorra kaloraaž
    Public Function PariKcalPaveaHetkest(kuupaev As Integer, kasutaja_id As Integer, toidukord As Integer) As Integer Implements IAnaluus.PariKcalPaveaHetkest
        Select Case toidukord
            Case 0
                hommik = KaloridKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return hommik
            Case 1
                louna = KaloridKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return louna
            Case 2
                vahepala = KaloridKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return vahepala
            Case 3
                ohtu = KaloridKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return ohtu
        End Select
        Return 0
    End Function

    Public Function PariValueMap(keyStr As String, ByVal valueMap As Dictionary(Of String, Integer)) As Integer Implements IAnaluus.PariValueMap
        If valueMap.ContainsKey(keyStr) Then
            Return valueMap(keyStr)
        End If
        Return 0
    End Function

    Public Sub LisaValueMap(newKeyStr As String, newValue As Integer, ByVal valueMap As Dictionary(Of String, Integer)) Implements IAnaluus.LisaValueMap
        If Not valueMap.ContainsKey(newKeyStr) Then
            valueMap.Add(newKeyStr, newValue)
        End If
    End Sub

    ' Päevase kaloraaži arvutamine ja user_daily_data tabeli uuendamisega 
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

    ' Pärib toidukorra kaloraaži tabelist user_food_history, tagastab listi 
    Private Function KclParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal toidukord As Integer) As Double() Implements IAnaluus.KclParingAndmebaasist
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = "Select energy_intake FROM user_food_history WHERE user_id = @kasutaja_id And Date = @kuupaev And time_of_meal = @toidukord;"
        Dim doubleValues As New List(Of Double)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                command.Parameters.AddWithValue("@kuupaev", kuupaev)
                command.Parameters.AddWithValue("@toidukord", toidukord)

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

    ' Päevase kaalu lisamine ja kaalu uuendamine, tagastab uue kaalu 
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

    ' Kuupäeva päring tabelist User_daily_data, tagastab listi (vajalik kaalu graafiku kuvamiseks)
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

    Private Function KaloridKokku(ByRef KcalLoend As Double()) As Double Implements IAnaluus.KaloridKokku
        Dim koguvaartus As Double = 0

        For i As Integer = 0 To KcalLoend.Length - 1
            koguvaartus += KcalLoend(i)
        Next
        Return koguvaartus
    End Function

    ' Kuupäeva formaat teisendatakse int'ks ja tagastatakse see
    Public Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer Implements IAnaluus.KuupaevIntegeriks
        Dim unixAeg As New DateTime(1970, 1, 1)
        Return (sisendKuupaev - unixAeg).Days
    End Function

    ' Int teisendatakse kuupäeva formaati ja tagastatakse see
    Public Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime Implements IAnaluus.IntegerKuupaevaks
        Dim unixAeg As New DateTime(1970, 1, 1)
        Return (unixAeg.AddDays(sisendInteger))
    End Function

    ' Retsepti või üksiku toiduaine toiteväärtuse arvutus vastavalt kasutaja sisestusele ja selle tagastus 
    Public Function RetseptiToiduaineToitevaartuseArvutus(ByVal toitevaartus100gKohta As Integer, ByVal kogus As Integer) As Integer Implements IAnaluus.RetseptiToiduaineToitevaartuseArvutus
        Return (toitevaartus100gKohta / 100) * kogus
    End Function

    ' Päring tabelist user_training_history BMR-i arvutamiseks
    ' Arvutab BMR-i ja tagastab väärtuse
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

    ' Makrotoitaine päring tabelist user_food_history, tagastatakse list
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

    ' Makrotoitaine koguse saamine kasutades funktsiooni MakroaineParingAndmebaasist, tagastatakse mkaroaine kogus
    Public Function PariMakroaineKogus(kuupaev As Integer, kasutaja_id As Integer, makroaine As String) As Integer Implements IAnaluus.PariMakroaineKogus
        Select Case makroaine
            Case "total_c_hydrates"
                Return KaloridKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

            Case "total_sugar"
                Return KaloridKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

            Case "total_protein"
                Return KaloridKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

            Case "total_lipid"
                Return KaloridKokku(MakroaineParingAndmebaasist(kasutaja_id, kuupaev, makroaine))

        End Select
        Return 0
    End Function

    ' Päeva jooksul tehtud treeningute päring tabelist user_training_history, tagastatakse list
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

    ' Päeva jooksul tarbitud toitude päring tabelist user_food_history, tagastatakse list
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
