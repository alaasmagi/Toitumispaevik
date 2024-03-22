Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class CToidudJaRetseptid
    Implements IToidudjaRetseptid

    Public Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                   ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer Implements IToidudjaRetseptid.LisaToiduaine

        Dim toiduaine_id As Integer = GenereeriId()

        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO food_data (food_id, food_name, energy, c_hydrates, sugar, protein, lipid)
          VALUES (@toiduaine_id, @toiduainenimi, @energia, @susivesikud, @suhkrud, @valgud, @rasvad)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaine_id)
                cmd.Parameters.AddWithValue("@toiduainenimi", toiduainenimi)
                cmd.Parameters.AddWithValue("@energia", energia)
                cmd.Parameters.AddWithValue("@susivesikud", susivesikud)
                cmd.Parameters.AddWithValue("@suhkrud", suhkrud)
                cmd.Parameters.AddWithValue("@valgud", valgud)
                cmd.Parameters.AddWithValue("@rasvad", rasvad)

                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return toiduaine_id
    End Function

    Private Function GenereeriId() As Integer Implements IToidudjaRetseptid.GenereeriId
        Dim random As New Random()
        Dim genereeritudId As Integer = random.Next(0, 250)

        Return genereeritudId
    End Function

    Public Function KiirlisamiseToiduaineNimed() As List(Of String) Implements IToidudjaRetseptid.KiirlisamiseToiduaineNimed
        Dim toiduaineteNimed As New List(Of String)()
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
               (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            For index = 0 To 250
                Dim selectSql As String = "SELECT food_name FROM food_data WHERE food_id = @id"

                Using cmd As New SQLiteCommand(selectSql, connection)
                    cmd.Parameters.AddWithValue("@id", index)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            toiduaineteNimed.Add(reader("food_name"))
                        End While
                    End Using
                End Using
            Next
        End Using
        Return toiduaineteNimed
    End Function

    Public Function ToiduAineNimiEksisteerib(ByVal toiduaineNimi As String) As Integer Implements IToidudjaRetseptid.ToiduAineNimiEksisteerib
        Dim toiduaine_id As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = "SELECT food_id FROM food_data WHERE food_name = @foodName"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@foodName", toiduaineNimi)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    toiduaine_id = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return toiduaine_id
    End Function

    Public Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutaja_id As String, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toiduaine_retsept_id As Integer, ByVal kogus As Integer) As Integer

    End Function

End Class
