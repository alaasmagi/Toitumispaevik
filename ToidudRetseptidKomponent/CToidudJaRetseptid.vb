Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class CToidudJaRetseptid

    Public Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                   ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer

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

    Private Function GenereeriId() As Integer
        Dim random As New Random()
        Dim genereeritudId As Integer = random.Next(1002, 10000)

        Return genereeritudId
    End Function

End Class

