Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class CToidudJaRetseptid

    Public Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                   ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer

        'Toiduaine nime olemas olu kontroll
        If ToiduAineNimiEksisteerib(toiduainenimi) Then
            Console.WriteLine("Sama nimega toit juba eksisteerib.")
            Return -1
        End If

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

    Public Function ToiduAineNimiEksisteerib(ByVal foodName As String) As Integer
        Dim toiduaine_id As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = "SELECT food_id FROM food_data WHERE food_name = @foodName"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@foodName", foodName)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    toiduaine_id = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return toiduaine_id
    End Function




End Class
