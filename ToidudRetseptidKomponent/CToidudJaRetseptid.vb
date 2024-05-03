
' Kaloripäeviku projekt "Janar"
' Toitude ja retseptide komponent
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class CToidudJaRetseptid
    Implements IToidudjaRetseptid

    ' Andmebaasi asukoha määramine
    Dim tabeliAsukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"


    ' Lisab uue toiduaine andmebaasi tabelisse food_data, sisestades selle nime, energiasisalduse, valkude, süsivesikute, rasvade ja suhkrute kogused ning tagastab unikaalse võtme toiduaine_id.
    Public Function LisaToiduaine(ByVal toiduaineNimi As String, ByVal energia As Double, ByVal valgud As Double,
                                   ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer Implements IToidudjaRetseptid.LisaToiduaine
        Dim toiduaineId As Integer = GenereeriId(1)

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlSisestus As String = "INSERT INTO food_data (food_id, food_name, energy, c_hydrates, sugar, protein, lipid)
            VALUES (@toiduaine_id, @toiduainenimi, @energia, @susivesikud, @suhkrud, @valgud, @rasvad)"
            Using cmd As New SQLiteCommand(sqlSisestus, connection)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaineId)
                cmd.Parameters.AddWithValue("@toiduainenimi", toiduaineNimi)
                cmd.Parameters.AddWithValue("@energia", energia)
                cmd.Parameters.AddWithValue("@susivesikud", susivesikud)
                cmd.Parameters.AddWithValue("@suhkrud", suhkrud)
                cmd.Parameters.AddWithValue("@valgud", valgud)
                cmd.Parameters.AddWithValue("@rasvad", rasvad)

                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return toiduaineId
    End Function


    ' Lisab uue retsepti andmebaasi tabelisse recipe_data, sisestades selle nime, energiasisalduse, valkude, süsivesikute, rasvade ja suhkrute kogused ning tagastab unikaalse võtme retsepti_id.
    Public Function LisaRetsept(ByVal retseptiNimi As String, ByVal retseptiKcal As Integer, ByVal retseptiSusivesikud As Integer, ByVal retseptiSuhkur As Integer,
                                ByVal retseptiValgud As Integer, ByVal retseptiLipiidid As Integer) As Integer Implements IToidudjaRetseptid.LisaRetsept
        Dim retseptiId As Integer = GenereeriId(0)

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlSisestus As String = "INSERT INTO recipe_data (recipe_id, recipe_name, energy, c_hydrates, sugar, protein, lipid) VALUES (@retsepti_id, @retsepti_nimi, @energia, @susivesikud, 
                                            @suhkur, @valgud, @lipiidid)"
            Using cmd As New SQLiteCommand(sqlSisestus, connection)
                cmd.Parameters.AddWithValue("@retsepti_id", retseptiId)
                cmd.Parameters.AddWithValue("@retsepti_nimi", retseptiNimi)
                cmd.Parameters.AddWithValue("@energia", retseptiKcal)
                cmd.Parameters.AddWithValue("@susivesikud", retseptiSusivesikud)
                cmd.Parameters.AddWithValue("@suhkur", retseptiSuhkur)
                cmd.Parameters.AddWithValue("@valgud", retseptiValgud)
                cmd.Parameters.AddWithValue("@lipiidid", retseptiLipiidid)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return retseptiId
    End Function


    'Genereerib unikaalsed võtmed
    Private Function GenereeriId(ByVal toiduaineFlag As Integer) As Integer Implements IToidudjaRetseptid.GenereeriId
        Dim juhuslikNr As New Random()
        Dim genereeritudId As Integer
        If toiduaineFlag = 1 Then
            genereeritudId = juhuslikNr.Next(2006, 2500)
        Else
            genereeritudId = juhuslikNr.Next(3000, 4000)
        End If
        Return genereeritudId
    End Function


    'Toiduaine kiirlisamine pealehelt, kui valitud on mukbang filter, siis sorteeritakse kõrgema sisaldusega toidud eelisjärjekorras
    Public Function KiirlisamiseToiduaineNimed(ByVal mukbangFlag As Integer) As List(Of String) Implements IToidudjaRetseptid.KiirlisamiseToiduaineNimed
        Dim toiduaineteNimed As New List(Of String)()

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String
            If mukbangFlag = 1 Then
                sqlParing = "SELECT food_name FROM food_data ORDER BY energy DESC"
            Else
                sqlParing = "SELECT food_name FROM food_data"
            End If
            Using cmd As New SQLiteCommand(sqlParing, connection)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        toiduaineteNimed.Add(reader("food_name"))
                    End While
                End Using
            End Using
        End Using
        Return toiduaineteNimed
    End Function


    'Juba andmebaasis olemasoleva toiduaine nime kontroll
    Public Function ToiduAineNimiEksisteerib(ByVal toiduaineNimi As String) As Integer Implements IToidudjaRetseptid.ToiduAineNimiEksisteerib
        Dim toiduaineId As Integer = 0

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = "SELECT food_id FROM food_data WHERE food_name = @toiduaine_nimi"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@toiduaine_nimi", toiduaineNimi)
                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    toiduaineId = Convert.ToInt32(tulem)
                End If
            End Using
        End Using
        Return toiduaineId
    End Function


    'Juba andmebaasis olemasoleva retsepti nime kontroll
    Public Function RetseptiNimiEksisteerib(ByVal retseptiNimi As String) As Integer Implements IToidudjaRetseptid.RetseptiNimiEksisteerib
        Dim retseptiId As Integer = 0

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = "SELECT recipe_id FROM recipe_data WHERE recipe_name = @retsepti_nimi"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@retsepti_nimi", retseptiNimi)
                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    retseptiId = Convert.ToInt32(tulem)
                End If
            End Using
        End Using
        Return retseptiId
    End Function


    'Toiduaine või retsepti toiteväärtuse(ntks energia, valgud jne) päring
    Public Function ToiteVaartuseParing(ByVal toiduId As Integer, ByVal otsitavSuurus As String, ByVal retseptFlag As Integer) As Integer Implements IToidudjaRetseptid.ToiteVaartuseParing
        Dim tulemus As Integer

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String
            If retseptFlag = 0 Then
                sqlParing = $"SELECT {otsitavSuurus} FROM food_data WHERE food_id = @toidu_id"
            Else
                sqlParing = $"SELECT {otsitavSuurus} FROM recipe_data WHERE recipe_id = @toidu_id"
            End If

            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@toidu_id", toiduId)
                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    tulemus = Convert.ToInt32(tulem)
                End If
            End Using
        End Using
        Return tulemus
    End Function


    'Kasutaja tarbitud toiduaine või retsepti andmebaasi tabelisse user_food_history lisamine
    Public Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toiduId As Integer, ByVal kogus As Integer) As Integer Implements IToidudjaRetseptid.KasutajaToiduaineVõiRetseptiLisamine
        Dim retseptFlag As Integer

        If toiduId > 3000 Then
            retseptFlag = 1
        Else
            retseptFlag = 0
        End If

        Dim kalorid As Double = 0.01 * kogus * ToiteVaartuseParing(toiduId, "energy", retseptFlag)
        Dim susivesikud As Double = 0.01 * kogus * ToiteVaartuseParing(toiduId, "c_hydrates", retseptFlag)
        Dim suhkur As Double = 0.01 * kogus * ToiteVaartuseParing(toiduId, "sugar", retseptFlag)
        Dim valgud As Double = 0.01 * kogus * ToiteVaartuseParing(toiduId, "protein", retseptFlag)
        Dim rasvad As Double = 0.01 * kogus * ToiteVaartuseParing(toiduId, "lipid", retseptFlag)

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlSisestus As String = "INSERT INTO user_food_history (user_id, date, time_of_meal, food_id, amount, energy_intake, total_c_hydrates, total_sugar, total_protein, total_lipid)
                                        VALUES (@kasutaja_id, @kuupaev, @toidukord, @toiduaine_id, @kogus, @kalorid, @susivesikud, @suhkur, @valgud, @rasvad)"
            Using cmd As New SQLiteCommand(sqlSisestus, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                cmd.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmd.Parameters.AddWithValue("@toidukord", toidukord)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduId)
                cmd.Parameters.AddWithValue("@kogus", kogus)
                cmd.Parameters.AddWithValue("@kalorid", kalorid)
                cmd.Parameters.AddWithValue("@susivesikud", susivesikud)
                cmd.Parameters.AddWithValue("@suhkur", suhkur)
                cmd.Parameters.AddWithValue("@valgud", valgud)
                cmd.Parameters.AddWithValue("@rasvad", rasvad)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return toiduId
    End Function


    'Retsepti lisamine andmebaasi tabelisse recipe_ingredients, lisades retsepti_id, toiduaine_id ja ka koguse
    Public Function LisaRetseptiKoostisosadeTabelisse(ByVal retseptiId As Integer, ByVal toiduaineId As Integer, ByVal kogus As Integer) As Integer Implements IToidudjaRetseptid.LisaRetseptiKoostisosadeTabelisse
        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlSisestus As String = "INSERT INTO recipe_ingredients (recipe_id, food_id, amount) VALUES (@retsepti_id, @toiduaine_id, @kogus)"
            Using cmd As New SQLiteCommand(sqlSisestus, connection)
                cmd.Parameters.AddWithValue("@retsepti_id", retseptiId)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaineId)
                cmd.Parameters.AddWithValue("@kogus", kogus)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return retseptiId
    End Function


    'Retsepti kiirlisamine pealehelt, kui valitud on mukbang filter, siis sorteeritakse kõrgema sisaldusega retseptid eelisjärjekorras
    Public Function KiirlisamiseRetseptideNimed(ByVal mukbangFlag As Integer) As List(Of String) Implements IToidudjaRetseptid.KiirlisamiseRetseptideNimed
        Dim retseptideNimed As New List(Of String)()

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String
            If mukbangFlag = 1 Then
                sqlParing = "SELECT recipe_name FROM recipe_data ORDER BY energy DESC"
            Else
                sqlParing = "SELECT recipe_name FROM recipe_data"
            End If
            Using cmd As New SQLiteCommand(sqlParing, connection)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        retseptideNimed.Add(reader("recipe_name"))
                    End While
                End Using
            End Using
        End Using
        Return retseptideNimed
    End Function


    'Lisatud toiduaine või retsepti kustutamine andmebaasist
    Public Function ToiduaineVoiRetseptiKustutamine(ByVal toiduaineRetseptiId As Integer, ByVal toiduaineFlag As Integer) As Integer Implements IToidudjaRetseptid.ToiduaineVoiRetseptiKustutamine
        Dim tulemus As Integer = 0

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlEemaldus As String
            If toiduaineFlag = 1 Then
                sqlEemaldus = $"DELETE FROM food_data WHERE food_id = @toiduaine_retsepti_id"
            Else
                sqlEemaldus = $"DELETE FROM recipe_data WHERE recipe_id = @toiduaine_retsepti_id"
            End If
            Using cmd As New SQLiteCommand(sqlEemaldus, connection)
                cmd.Parameters.AddWithValue("@toiduaine_retsepti_id", toiduaineRetseptiId)
                Dim muudetudRead As Integer = cmd.ExecuteNonQuery()
                If muudetudRead > 0 Then
                    tulemus = 1
                End If
            End Using
        End Using
        Return tulemus
    End Function


    ' Toiduaine või retsepti nime olemasolu kontroll
    Public Function ToiduaineVoiRetseptiNimi(ByVal toiduaineVoiRetseptiId As Integer, ByVal retseptFlag As Integer) As String Implements IToidudjaRetseptid.ToiduaineVoiRetseptiNimi
        Dim toiduaineVoiRetseptiNimetus As String = ""

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String
            If retseptFlag = 1 Then
                sqlParing = "SELECT recipe_name FROM recipe_data WHERE recipe_id = @toiduaineVoiRetseptiId"
            Else
                sqlParing = "SELECT food_name FROM food_data WHERE food_id = @toiduaineVoiRetseptiId"
            End If
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@toiduaineVoiRetseptiId", toiduaineVoiRetseptiId)

                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    toiduaineVoiRetseptiNimetus = Convert.ToString(tulem)
                End If
            End Using
        End Using
        Return toiduaineVoiRetseptiNimetus
    End Function
End Class
