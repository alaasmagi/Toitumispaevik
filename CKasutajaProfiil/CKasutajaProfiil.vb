Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class CKasutajaProfiil
    Implements IKasutajaProfiil
    Public Function LooKonto(ByVal kasutajanimi As String, ByVal salasona As String, ByVal eesnimi As String,
                                 ByVal taaste_id As Integer, ByVal taaste_vastus As String, ByVal pikkus As Integer,
                                 ByVal kaal As Integer, ByVal sugu As Boolean, ByVal vanus As Integer) As Integer Implements IKasutajaProfiil.LooKonto

        Dim kasutaja_id As Integer = GenereeriId()
        Dim salasona_hash As String = ArvutaHash(salasona)
        Dim taaste_vastus_hash As String = ArvutaHash(taaste_vastus)
        Dim eesnimi_krupt As String = Krupteerimine(eesnimi)
        Dim kasutajanimi_krupt As String = Krupteerimine(kasutajanimi)

        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO user_data (user_id, username, password, firstname, recovery_question_id,
                recovery_answer, height, weight, sex, age, calorie_limit, weight_goal) VALUES (@kasutaja_id, @kasutajanimi_krupt, @salasona_hash, @eesnimi_krupt, @taaste_id,
                @taaste_vastus_hash, @pikkus, @kaal, @sugu, @vanus, 0, 0)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.Parameters.AddWithValue("@kasutajanimi_krupt", kasutajanimi_krupt)
                cmd.Parameters.AddWithValue("@salasona_hash", salasona_hash)
                cmd.Parameters.AddWithValue("@eesnimi_krupt", eesnimi_krupt)
                cmd.Parameters.AddWithValue("@taaste_id", taaste_id)
                cmd.Parameters.AddWithValue("@taaste_vastus_hash", taaste_vastus_hash)
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
        Return kasutaja_id
    End Function

    Public Function KontrolliKontoOlemasolu(ByVal kasutajanimi As String) As Integer Implements IKasutajaProfiil.KontrolliKontoOlemasolu
        Dim kasutaja_id As Integer = 0
        Dim kasutajanimi_krupt As String = Krupteerimine(kasutajanimi)
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()

            Dim sql As String = "SELECT user_id FROM user_data WHERE username = @kasutajanimi_krupt"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutajanimi_krupt", kasutajanimi_krupt)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    kasutaja_id = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return kasutaja_id
    End Function

    Public Function TurvaKusimuseLeidmine(ByVal kasutaja_id As Integer) As String Implements IKasutajaProfiil.TurvaKusimuseLeidmine

        Dim kusimuse_id As Integer
        Dim kusimus As String = ""

        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim sql As String = $"SELECT recovery_question_id FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        kusimuse_id = reader("recovery_question_id")
                    End While
                End Using
            End Using

            sql = "SELECT recovery_question FROM recovery_questions WHERE recovery_question_id = @kusimuse_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kusimuse_id", kusimuse_id)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        kusimus = reader("recovery_question")
                    End While
                End Using
            End Using
        End Using
        Return kusimus
    End Function

    Public Function SisseLogimine(ByVal kasutaja_id As Integer, ByVal salasona As String) As Integer Implements IKasutajaProfiil.SisseLogimine

        Dim salasona_hash As String = ArvutaHash(salasona)
        Dim tabeli_salasona_hash As String = ""
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
       (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim sql As String = "SELECT password FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        tabeli_salasona_hash = reader("password")
                    End While
                End Using
            End Using
        End Using

        If tabeli_salasona_hash = salasona_hash Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Function GenereeriId() As Integer Implements IKasutajaProfiil.GenereeriId
        Dim random As New Random()
        Dim genereeritudId As Integer = random.Next(1002, 1200)

        Return genereeritudId
    End Function

    Public Function ArvutaHash(ByVal sisend As String) As String Implements IKasutajaProfiil.ArvutaHash
        Dim sha256 As SHA256 = SHA256.Create()
        Dim baitide_massiiv As Byte() = Encoding.UTF8.GetBytes(sisend)
        Dim hashi_baidid As Byte() = sha256.ComputeHash(baitide_massiiv)
        Dim builder As New StringBuilder()

        For Each b As Byte In hashi_baidid
            builder.Append(b.ToString("x2"))
        Next

        Return builder.ToString()
    End Function
    Public Function UheAndmevaljaParingKasutajaTabelist(ByVal kasutaja_id As String, ByVal andmevali As String) As String Implements IKasutajaProfiil.UheAndmevaljaParingKasutajaTabelist
        Dim tagastus As String = ""
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim sql As String = $"SELECT {andmevali} FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        tagastus = reader(andmevali).ToString()
                    End While
                End Using
            End Using
        End Using
        Return tagastus
    End Function
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

    Public Function UheIntegerAndmeValjaParingKasutajaTabelist(ByVal kasutaja_id As Integer, ByVal andmevali As String) As Integer Implements IKasutajaProfiil.UheIntegerAndmeValjaParingKasutajaTabelist
        Dim tagastus As Integer
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim sql As String = $"SELECT {andmevali} FROM user_data WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        tagastus = Integer.Parse(reader(andmevali).ToString())
                    End While
                End Using
            End Using
        End Using
        Return tagastus
    End Function

    Public Sub IntegerAndmeValjaSisestusKasutajaTabelisse(ByVal kasutaja_id As Integer, ByVal uus_vaartus As Integer, ByVal andmevali As String) Implements IKasutajaProfiil.IntegerAndmeValjaSisestusKasutajaTabelisse
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim sql As String = $"UPDATE user_data SET {andmevali} = @sisend WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@sisend", uus_vaartus)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub VahetaSalasona(ByVal kasutaja_id As String, ByVal uus_salasona As String) Implements IKasutajaProfiil.VahetaSalasona
        Dim sisend = ArvutaHash(uus_salasona)
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim sql As String = "UPDATE user_data SET password = @sisend WHERE user_id = @kasutaja_id"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@sisend", sisend)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function TurvaKusimused() As List(Of String) Implements IKasutajaProfiil.TurvaKusimused
        Dim kusimused As New List(Of String)()
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            For index = 0 To 10
                Dim selectSql As String = "SELECT recovery_question FROM recovery_questions WHERE recovery_question_id = @id"

                Using cmd As New SQLiteCommand(selectSql, connection)
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

