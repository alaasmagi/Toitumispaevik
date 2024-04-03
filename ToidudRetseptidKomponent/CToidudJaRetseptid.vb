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

    Public Function LisaRetsept(ByVal retsepti_nimi As String, ByVal retsepti_kcal As Integer, ByVal retsepti_susivesikud As Integer, ByVal retsepti_suhkur As Integer,
                                ByVal retsepti_valgud As Integer, ByVal retsepti_lipiidid As Integer) As Integer Implements IToidudjaRetseptid.LisaRetsept
        Dim retsepti_id As Integer = GenereeriId()
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO recipe_data (recipe_id, recipe_name, energy, c_hydrates, sugar, proteins, lipids) VALUES (@retsepti_id, @retsepti_nimi, @energia, @susivesikud, 
                                            @suhkur, @valgud, @lipiidid)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@retsepti_id", retsepti_id)
                cmd.Parameters.AddWithValue("@retsepti_nimi", retsepti_nimi)
                cmd.Parameters.AddWithValue("@energia", retsepti_kcal)
                cmd.Parameters.AddWithValue("@susivesikud", retsepti_susivesikud)
                cmd.Parameters.AddWithValue("@suhkur", retsepti_suhkur)
                cmd.Parameters.AddWithValue("@valgud", retsepti_valgud)
                cmd.Parameters.AddWithValue("@lipiidid", retsepti_lipiidid)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return retsepti_id
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

    Public Function ToiduAineNimiEksisteerib(ByVal toiduaine_nimi As String) As Integer Implements IToidudjaRetseptid.ToiduAineNimiEksisteerib
        Dim toiduaine_id As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = "SELECT food_id FROM food_data WHERE food_name = @toiduaine_nimi"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@toiduaine_nimi", toiduaine_nimi)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    toiduaine_id = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return toiduaine_id
    End Function

    Public Function RetseptiNimiEksisteerib(ByVal retsepti_nimi As String) As Integer Implements IToidudjaRetseptid.RetseptiNimiEksisteerib
        Dim retsepti_id As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
    (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = "SELECT recipe_id FROM recipe_data WHERE recipe_name = @retsepti_nimi"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@retsepti_nimi", retsepti_nimi)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    retsepti_id = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return retsepti_id
    End Function


    Public Function ToiteVaartuseParing(ByVal toiduaine_id As Integer, ByVal otsitav_suurus As String) As Integer Implements IToidudjaRetseptid.ToiteVaartuseParing
        Dim tulemus As Integer
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = $"SELECT {otsitav_suurus} FROM food_data WHERE food_id = @toiduaine_id"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaine_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    tulemus = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return tulemus
    End Function

    Public Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutaja_id As String, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toiduaine_id As Integer, ByVal kogus As Integer) As Integer Implements IToidudjaRetseptid.KasutajaToiduaineVõiRetseptiLisamine
        Dim kalorid = 0.1 * kogus * ToiteVaartuseParing(toiduaine_id, "energy")
        Dim susivesikud = 0.1 * kogus * ToiteVaartuseParing(toiduaine_id, "c_hydrates")
        Dim suhkur = 0.1 * kogus * ToiteVaartuseParing(toiduaine_id, "sugar")
        Dim valgud = 0.1 * kogus * ToiteVaartuseParing(toiduaine_id, "protein")
        Dim rasvad = 0.1 * kogus * ToiteVaartuseParing(toiduaine_id, "lipid")



        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO user_food_history (user_id, date, time_of_meal, food_id, amount, energy_intake, total_c_hydrates, total_sugar, total_protein, total_lipid)
          VALUES (@kasutaja_id, @kuupaev, @toidukord, @toiduaine_id, @kogus, @kalorid, @susivesikud, @suhkur, @valgud, @rasvad)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmd.Parameters.AddWithValue("@toidukord", toidukord)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaine_id)
                cmd.Parameters.AddWithValue("@kogus", kogus)
                cmd.Parameters.AddWithValue("@kalorid", 0.01 * kogus * ToiteVaartuseParing(toiduaine_id, "energy"))
                cmd.Parameters.AddWithValue("@susivesikud", 0.01 * kogus * ToiteVaartuseParing(toiduaine_id, "c_hydrates"))
                cmd.Parameters.AddWithValue("@suhkur", 0.01 * kogus * ToiteVaartuseParing(toiduaine_id, "sugar"))
                cmd.Parameters.AddWithValue("@valgud", 0.01 * kogus * ToiteVaartuseParing(toiduaine_id, "protein"))
                cmd.Parameters.AddWithValue("@rasvad", 0.01 * kogus * ToiteVaartuseParing(toiduaine_id, "lipid"))
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return toiduaine_id
    End Function

    Public Function LisaRetseptiKoostisosadeTabelisse(ByVal retsepti_id As Integer, ByVal toiduaine_id As Integer, ByVal kogus As Integer) As Integer Implements IToidudjaRetseptid.LisaRetseptiKoostisosadeTabelisse
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO recipe_ingredients (recipe_id, food_id, amount) VALUES (@retsepti_id, @toiduaine_id, @kogus)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@retsepti_id", retsepti_id)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaine_id)
                cmd.Parameters.AddWithValue("@kogus", kogus)

                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return retsepti_id
    End Function
End Class
