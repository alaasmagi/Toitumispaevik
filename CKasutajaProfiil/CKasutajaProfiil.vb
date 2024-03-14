Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO
Public Class CKasutajaProfiil
    Public Function LooKonto(ByVal kasutajanimi As String, ByVal salasona As String, ByVal eesnimi As String,
                                 ByVal taaste_id As Integer, ByVal taaste_vastus As String, ByVal pikkus As Integer,
                                 ByVal kaal As Integer, ByVal sugu As Boolean, ByVal vanus As Integer) As Integer

        Dim kasutaja_id As Integer = GenereeriId()
        Dim olek As Integer
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO user_data (user_id, username, password, firstname, recovery_question_id,
                recovery_answer, height, weight, sex, age) VALUES (@kasutaja_id, @kasutajanimi, @salasona, @eesnimi, @taaste_id,
                @taaste_vastus, @pikkus, @kaal, @sugu, @vanus)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.Parameters.AddWithValue("@kasutajanimi", kasutajanimi)
                cmd.Parameters.AddWithValue("@salasona", salasona)
                cmd.Parameters.AddWithValue("@eesnimi", eesnimi)
                cmd.Parameters.AddWithValue("@taaste_id", taaste_id)
                cmd.Parameters.AddWithValue("@taaste_vastus", taaste_vastus)
                cmd.Parameters.AddWithValue("@pikkus", pikkus)
                cmd.Parameters.AddWithValue("@kaal", kaal)
                If sugu = True Then
                    cmd.Parameters.AddWithValue("@sugu", 1)
                Else
                    cmd.Parameters.AddWithValue("@sugu", 0)
                End If
                cmd.Parameters.AddWithValue("@vanus", vanus)
                olek = cmd.ExecuteNonQuery()
            End Using
        End Using
        Return olek
    End Function

    Public Function KontrolliKontoOlemasolu(ByVal kasutajanimi As String) As Boolean

        Dim olek As Integer
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()

            Dim sql As String = "SELECT COUNT(*) FROM user_data WHERE username = @kasutajanimi"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutajanimi", kasutajanimi)

                ' Execute the query to get the count of usernames that match the provided usernameToCheck
                olek = Convert.ToInt32(cmd.ExecuteScalar())

            End Using
        End Using
        If olek > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function TurvaKusimuseLeidmine(ByVal kasutajanimi As String)

        Dim kusimuse_id As Integer
        Dim kusimus As String = ""
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()

            Dim sql As String = "SELECT recovery_question_id FROM user_data WHERE username = @kasutajanimi"
            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@kasutajanimi", kasutajanimi)

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
    Private Function GenereeriId() As Integer
        Dim random As New Random()
        Dim genereeritudId As Integer = random.Next(1002, 10000)

        Return genereeritudId
    End Function

End Class

