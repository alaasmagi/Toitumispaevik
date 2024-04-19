Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class CToidudJaRetseptid
    Implements IToidudjaRetseptid

    Public Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                   ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer Implements IToidudjaRetseptid.LisaToiduaine

        Dim toiduaine_id As Integer = GenereeriId(1)

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
        Dim retsepti_id As Integer = GenereeriId(0)
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

    Private Function GenereeriId(ByVal toiduaineFlag As Integer) As Integer Implements IToidudjaRetseptid.GenereeriId
        Dim random As New Random()
        Dim genereeritudId As Integer
        If toiduaineFlag = 1 Then
            genereeritudId = random.Next(2006, 2500)
        Else
            genereeritudId = random.Next(3000, 4000)
        End If

        Return genereeritudId
    End Function

    Public Function KiirlisamiseToiduaineNimed(ByVal mukbangFlag As Integer) As List(Of String) Implements IToidudjaRetseptid.KiirlisamiseToiduaineNimed
        Dim toiduaineteNimed As New List(Of String)()
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
               (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String
            If mukbangFlag = 1 Then
                selectSql = "SELECT food_name FROM food_data ORDER BY energy DESC"
            Else
                selectSql = "SELECT food_name FROM food_data"
            End If
            Using cmd As New SQLiteCommand(selectSql, connection)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        toiduaineteNimed.Add(reader("food_name"))
                    End While
                End Using
            End Using
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


    Public Function ToiteVaartuseParing(ByVal toidu_id As Integer, ByVal otsitav_suurus As String, ByVal retseptFlag As Integer) As Integer Implements IToidudjaRetseptid.ToiteVaartuseParing
        Dim tulemus As Integer
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()

            Dim selectSql As String
            If retseptFlag = 0 Then
                selectSql = $"SELECT {otsitav_suurus} FROM food_data WHERE food_id = @toidu_id"
            Else
                selectSql = $"SELECT {otsitav_suurus} FROM recipe_data WHERE recipe_id = @toidu_id"
            End If

            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@toidu_id", toidu_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    tulemus = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return tulemus
    End Function

    Public Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutaja_id As String, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toidu_id As Integer, ByVal kogus As Integer) As Integer Implements IToidudjaRetseptid.KasutajaToiduaineVõiRetseptiLisamine

        Dim retseptFlag As Integer

        If toidu_id > 3000 Then
            retseptFlag = 1
        Else
            retseptFlag = 0
        End If

        Dim kalorid As Double = 0.01 * kogus * ToiteVaartuseParing(toidu_id, "energy", retseptFlag)
        Dim susivesikud As Double = 0.01 * kogus * ToiteVaartuseParing(toidu_id, "c_hydrates", retseptFlag)
        Dim suhkur As Double = 0.01 * kogus * ToiteVaartuseParing(toidu_id, "sugar", retseptFlag)
        Dim valgud As Double = 0.01 * kogus * ToiteVaartuseParing(toidu_id, "protein", retseptFlag)
        Dim rasvad As Double = 0.01 * kogus * ToiteVaartuseParing(toidu_id, "lipid", retseptFlag)

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
                cmd.Parameters.AddWithValue("@toiduaine_id", toidu_id)
                cmd.Parameters.AddWithValue("@kogus", kogus)
                cmd.Parameters.AddWithValue("@kalorid", kalorid)
                cmd.Parameters.AddWithValue("@susivesikud", susivesikud)
                cmd.Parameters.AddWithValue("@suhkur", suhkur)
                cmd.Parameters.AddWithValue("@valgud", valgud)
                cmd.Parameters.AddWithValue("@rasvad", rasvad)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return toidu_id
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

    Public Function KiirlisamiseRetseptideNimed(ByVal mukbangFlag As Integer) As List(Of String) Implements IToidudjaRetseptid.KiirlisamiseRetseptideNimed
        Dim retseptideNimed As New List(Of String)()
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
               (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String
            If mukbangFlag = 1 Then
                selectSql = "SELECT recipe_name FROM recipe_data ORDER BY energy DESC"
            Else
                selectSql = "SELECT recipe_name FROM recipe_data"
            End If
            Using cmd As New SQLiteCommand(selectSql, connection)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        retseptideNimed.Add(reader("recipe_name"))
                    End While
                End Using
            End Using
        End Using
        Return retseptideNimed
    End Function

    Public Function ToiduaineVoiRetseptiKustutamine(ByVal toiduaine_retsepti_id As Integer, ByVal toiduaineFlag As Integer) As Integer Implements IToidudjaRetseptid.ToiduaineVoiRetseptiKustutamine

        Dim tulemus As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
         (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim deleteSql As String

            If toiduaineFlag = 1 Then
                deleteSql = $"DELETE FROM food_data WHERE food_id = @toiduaine_retsepti_id"
            Else
                deleteSql = $"DELETE FROM recipe_data WHERE recipe_id = @toiduaine_retsepti_id"
            End If
            Using cmd As New SQLiteCommand(deleteSql, connection)
                cmd.Parameters.AddWithValue("@toiduaine_retsepti_id", toiduaine_retsepti_id)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    tulemus = 1
                End If
            End Using
        End Using
        Return tulemus
    End Function

    Public Function ToiduaineVoiRetseptiNimi(ByVal toiduaineVoiRetseptiId As Integer, ByVal retseptFlag As Integer) As String Implements IToidudjaRetseptid.ToiduaineVoiRetseptiNimi
        Dim toiduaineVoiRetseptiNimetus As String = ""
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String
            If retseptFlag = 1 Then
                selectSql = "SELECT recipe_name FROM recipe_data WHERE recipe_id = @toiduaineVoiRetseptiId"
            Else
                selectSql = "SELECT food_name FROM food_data WHERE food_id = @toiduaineVoiRetseptiId"
            End If

            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@toiduaineVoiRetseptiId", toiduaineVoiRetseptiId)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    toiduaineVoiRetseptiNimetus = Convert.ToString(result)
                End If
            End Using
        End Using
        Return toiduaineVoiRetseptiNimetus
    End Function

End Class
