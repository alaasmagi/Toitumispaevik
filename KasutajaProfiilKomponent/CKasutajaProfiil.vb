
' Kaloripäeviku projekt "Janar"
' Kasutajaprofiili komponent
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class CKasutajaProfiil
    Implements IKasutajaProfiil

    ' Andmebaasi asukoha määramine
    Dim tabeliAsukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"


    ' Funktsioon kasutajakonto loomiseks
    Public Function LooKonto(ByVal kasutajanimi As String, ByVal salasona As String, ByVal eesnimi As String,
                                 ByVal taasteId As Integer, ByVal taasteVastus As String, ByVal pikkus As Integer,
                                 ByVal kaal As Integer, ByVal sugu As Boolean, ByVal vanus As Integer) As Integer Implements IKasutajaProfiil.LooKonto

        Dim kasutajaId As Integer = GenereeriId()
        Dim salasonaHash As String = ArvutaHash(salasona)
        Dim taasteVastusHash As String = ArvutaHash(taasteVastus)
        Dim eesnimiKrupt As String = Krupteerimine(eesnimi)
        Dim kasutajanimiKrupt As String = Krupteerimine(kasutajanimi)

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlSisestus As String = "INSERT INTO user_data (user_id, username, password, firstname, recovery_question_id,
                recovery_answer, height, weight, sex, age, calorie_limit, weight_goal) VALUES (@kasutaja_id, @kasutajanimi_krupt, @salasona_hash, @eesnimi_krupt, @taaste_id,
                @taaste_vastus_hash, @pikkus, @kaal, @sugu, @vanus, 0, @kaal)"
            Using cmd As New SQLiteCommand(sqlSisestus, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                cmd.Parameters.AddWithValue("@kasutajanimi_krupt", kasutajanimiKrupt)
                cmd.Parameters.AddWithValue("@salasona_hash", salasonaHash)
                cmd.Parameters.AddWithValue("@eesnimi_krupt", eesnimiKrupt)
                cmd.Parameters.AddWithValue("@taaste_id", taasteId)
                cmd.Parameters.AddWithValue("@taaste_vastus_hash", taasteVastusHash)
                cmd.Parameters.AddWithValue("@pikkus", pikkus)
                cmd.Parameters.AddWithValue("@kaal", kaal)
                If sugu = True Then
                    cmd.Parameters.AddWithValue("@sugu", 1)
                Else
                    cmd.Parameters.AddWithValue("@sugu", 0)
                End If
                cmd.Parameters.AddWithValue("@vanus", vanus)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return kasutajaId
    End Function


    ' Funktsioon kontrollimaks kasutajakonto olemasolu enne uue kasutajakonto loomist
    ' Kasutatakse ka kasutajakonto identifikaatori(id) leidmiseks nime järgi
    Public Function KontrolliKontoOlemasolu(ByVal kasutajanimi As String) As Integer Implements IKasutajaProfiil.KontrolliKontoOlemasolu
        Dim kasutajaId As Integer = 0
        Dim kasutajanimiKrupt As String = Krupteerimine(kasutajanimi)

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = "SELECT user_id FROM user_data WHERE username = @kasutajanimi_krupt"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@kasutajanimi_krupt", kasutajanimiKrupt)
                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    kasutajaId = Convert.ToInt32(tulem)
                End If
            End Using
        End Using
        Return kasutajaId
    End Function


    ' Funktsioon leidmaks kasutajakontoga seotud turvaküsimust
    Public Function TurvaKusimuseLeidmine(ByVal kasutajaId As Integer) As String Implements IKasutajaProfiil.TurvaKusimuseLeidmine
        Dim kusimuseId As Integer
        Dim kusimus As String = ""

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = $"SELECT recovery_question_id FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        kusimuseId = reader("recovery_question_id")
                    End While
                End Using
            End Using

            sqlParing = "SELECT recovery_question FROM recovery_questions WHERE recovery_question_id = @kusimuse_id"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@kusimuse_id", kusimuseId)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        kusimus = reader("recovery_question")
                    End While
                End Using
            End Using
        End Using
        Return kusimus
    End Function


    ' Funktsioon kasutajakontosse sisselogimiseks
    Public Function SisseLogimine(ByVal kasutajaId As Integer, ByVal salasona As String) As Integer Implements IKasutajaProfiil.SisseLogimine
        Dim salasonaHash As String = ArvutaHash(salasona)
        Dim tabeliSalasonaHash As String = ""

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = "SELECT password FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        tabeliSalasonaHash = reader("password")
                    End While
                End Using
            End Using
        End Using

        If tabeliSalasonaHash = salasonaHash Then
            Return 1
        Else
            Return 0
        End If
    End Function


    ' Funktsioon uue lisatava kasutajakonto identifikaatori(id) juhuslikuks genereerimiseks vahemiks 1002-1200
    Private Function GenereeriId() As Integer Implements IKasutajaProfiil.GenereeriId
        Dim juhuslikNr As New Random()
        Dim genereeritudId As Integer = juhuslikNr.Next(1002, 1200)
        Return genereeritudId
    End Function


    ' Funktsioon hash-i arvutamiseks
    Public Function ArvutaHash(ByVal sisend As String) As String Implements IKasutajaProfiil.ArvutaHash
        Dim sha256 As SHA256 = SHA256.Create()
        Dim baitideMassiiv As Byte() = Encoding.UTF8.GetBytes(sisend)
        Dim hashiBaidid As Byte() = sha256.ComputeHash(baitideMassiiv)
        Dim builder As New StringBuilder()

        For Each b As Byte In hashiBaidid
            builder.Append(b.ToString("x2"))
        Next
        Return builder.ToString()
    End Function


    ' Funktsioon kasutajaprofiili tabelist ühe andmevälja pärimiseks
    Public Function UheAndmevaljaParingKasutajaTabelist(ByVal kasutajaId As String, ByVal andmevali As String) As String Implements IKasutajaProfiil.UheAndmevaljaParingKasutajaTabelist
        Dim tagastus As String = ""

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = $"SELECT {andmevali} FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        tagastus = reader(andmevali).ToString()
                    End While
                End Using
            End Using
        End Using
        Return tagastus
    End Function


    ' Funktsioon kasutaja eesnime ja kasutajanime krüpteerimiseks
    Public Function Krupteerimine(ByVal sisend As String) As String Implements IKasutajaProfiil.Krupteerimine
        Dim valjund As New StringBuilder()

        For Each taht As Char In sisend
            If taht = "z"c Then
                valjund.Append("a")
            ElseIf taht = "Z"c Then
                valjund.Append("A")
            ElseIf Char.IsLetter(taht) Then
                valjund.Append(ChrW(AscW(taht) + 1))
            Else
                valjund.Append(taht)
            End If
        Next
        Return valjund.ToString()
    End Function


    ' Funktsioon kasutaja eesnime ja kasutajanime dekrüpteerimiseks
    Public Function Dekrupteerimine(ByVal sisend As String) As String Implements IKasutajaProfiil.Dekrupteerimine
        Dim valjund As New StringBuilder()

        For Each taht As Char In sisend
            If taht = "a"c Then
                valjund.Append("z")
            ElseIf taht = "A"c Then
                valjund.Append("Z")
            ElseIf Char.IsLetter(taht) Then
                valjund.Append(ChrW(AscW(taht) - 1))
            Else
                valjund.Append(taht)
            End If
        Next
        Return valjund.ToString()
    End Function



    ' Funktsioon kasutajaprofiili tabelist ühe integer tüüpi andmevälja pärimiseks
    Public Function UheIntegerAndmeValjaParingKasutajaTabelist(ByVal kasutajaId As Integer, ByVal andmevali As String) As Integer Implements IKasutajaProfiil.UheIntegerAndmeValjaParingKasutajaTabelist
        Dim tagastus As Integer
        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = $"SELECT {andmevali} FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        tagastus = Integer.Parse(reader(andmevali).ToString())
                    End While
                End Using
            End Using
        End Using
        Return tagastus
    End Function


    ' Funktsioon ühe integer andmevälja uuendamiseks kasutajaprofiili tabelis
    Public Sub IntegerAndmeValjaSisestusKasutajaTabelisse(ByVal kasutajaId As Integer, ByVal uusVaartus As Integer, ByVal andmevali As String) Implements IKasutajaProfiil.IntegerAndmeValjaSisestusKasutajaTabelisse
        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlUuendus As String = $"UPDATE user_data SET {andmevali} = @sisend WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sqlUuendus, connection)
                cmd.Parameters.AddWithValue("@sisend", uusVaartus)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    ' Funktsioon kasutaja salasõna vahetamiseks
    Public Sub VahetaSalasona(ByVal kasutajaId As String, ByVal uusSalasona As String) Implements IKasutajaProfiil.VahetaSalasona
        Dim sisend = ArvutaHash(uusSalasona)

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlUuendus As String = "UPDATE user_data SET password = @sisend WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sqlUuendus, connection)
                cmd.Parameters.AddWithValue("@sisend", sisend)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    ' Funktsioon kõikide turvaküsimuste kuvamiseks kasutajaliideses
    Public Function TurvaKusimused() As List(Of String) Implements IKasutajaProfiil.TurvaKusimused
        Dim kusimused As New List(Of String)()

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            For index = 0 To 10
                Dim sqlParing As String = "SELECT recovery_question FROM recovery_questions WHERE recovery_question_id = @id"
                Using cmd As New SQLiteCommand(sqlParing, connection)
                    cmd.Parameters.AddWithValue("@id", index)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            kusimused.Add(reader("recovery_question"))
                        End While
                    End Using
                End Using
            Next
        End Using
        Return kusimused
    End Function
End Class

