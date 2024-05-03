
' Kaloripäeviku projekt "Janar"
' Treeningute komponent
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Imports System.IO
Imports System.Data.SQLite
Public Class CTreeningud
    Implements ITreeningud

    ' Andmebaasi asukoha määramine
    Dim tabeliAsukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"


    ' Funktsioon treeningu lisamiseks treeningute andmebaasi
    Public Function LisaTreening(treeninguNimi As String, energiaKulu As Double) As Integer Implements ITreeningud.LisaTreening
        Dim treeninguId As Integer = GenereeriId()

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlSisestus As String = "INSERT INTO training_data (training_id, training_name, consumption)
          VALUES (@treeningu_id, @treeninguNimi, @energiakulu)"
            Using cmd As New SQLiteCommand(sqlSisestus, connection)
                cmd.Parameters.AddWithValue("@treeningu_id", treeninguId)
                cmd.Parameters.AddWithValue("@treeninguNimi", treeninguNimi)
                cmd.Parameters.AddWithValue("@energiakulu", energiaKulu)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return treeninguId
    End Function


    ' Funktsioon uue lisatava treeningu võtme juhuslikuks genereerimiseks vahemikus 4006-4500
    Private Function GenereeriId() As Integer Implements ITreeningud.GenereeriId
        Dim juhuslikNr As New Random()
        Dim genereeritudId As Integer = juhuslikNr.Next(4006, 4500)
        Return genereeritudId
    End Function


    ' Funktsioon kõikide treeningute väljastuseks treeeningute andmebaasist kasutajaliidesesse
    Public Function KiirlisamiseTreeninguNimed() As List(Of String) Implements ITreeningud.KiirlisamiseTreeninguNimed
        Dim treeninguteNimed As New List(Of String)()

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = "SELECT training_name FROM training_data"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        treeninguteNimed.Add(reader("training_name"))
                    End While
                End Using
            End Using
        End Using
        Return treeninguteNimed
    End Function


    ' Funktsioon kontrollimaks, et enne uue treeningu treeningute andmebaasi lisamist samanimelisi treeninguid andmebaasis pole.
    ' Lisaks kasutatakse seda funktsiooni treeningu võtme leidmiseks treeningu nime kaudu
    Public Function TreeninguNimiEksisteerib(ByVal treeninguNimi As String) As Integer Implements ITreeningud.TreeninguNimiEksisteerib
        Dim treeningu_id As Integer = 0

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = "SELECT training_id FROM training_data WHERE training_name = @treeninguNimi"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@treeninguNimi", treeninguNimi)
                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    treeningu_id = Convert.ToInt32(tulem)
                End If
            End Using
        End Using
        Return treeningu_id
    End Function


    ' Funktsioon treeningu energiakulu leidmiseks treeningute andmebaasist
    Public Function TreeninguEnergiakuluParing(ByVal treeninguId As Integer) As Integer Implements ITreeningud.TreeninguEnergiakuluParing
        Dim tulemus As Integer

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = $"SELECT consumption FROM training_data WHERE training_id = @treeningu_id"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@treeningu_id", treeninguId)
                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    tulemus = Convert.ToInt32(tulem)
                End If
            End Using
        End Using
        Return tulemus
    End Function


    ' Funktsioon treeningsessiooni lisamiseks kasutaja treeningu ajaloo tabelisse
    Public Function KasutajaTreeninguLisamine(ByVal kasutajaId As String, ByVal kuupaev As Integer, ByVal treeninguId As Integer, ByVal kestus As Integer) As Integer Implements ITreeningud.KasutajaTreeninguLisamine
        Dim energiakulu = Math.Round(kestus * (TreeninguEnergiakuluParing(treeninguId) / 60), 1)

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlSisestus As String = "INSERT INTO user_training_history (user_id, date, training_id, total_consumption, duration)
          VALUES (@kasutaja_id, @kuupaev, @treeningu_id, @energiakulu, @kestus)"
            Using cmd As New SQLiteCommand(sqlSisestus, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutajaId)
                cmd.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmd.Parameters.AddWithValue("@treeningu_id", treeninguId)
                cmd.Parameters.AddWithValue("@energiakulu", energiakulu)
                cmd.Parameters.AddWithValue("@kestus", kestus)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return treeninguId
    End Function


    ' Funktsioon treeningu kustutamiseks treeningute andmebaasist
    Public Function KustutaTreening(ByVal treeninguId As Integer) As Integer Implements ITreeningud.KustutaTreening
        Dim tulemus As Integer = 0

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlEemaldus As String = $"DELETE FROM training_data WHERE training_id = @treeningu_id"
            Using cmd As New SQLiteCommand(sqlEemaldus, connection)
                cmd.Parameters.AddWithValue("@treeningu_id", treeninguId)
                Dim muudetudRead As Integer = cmd.ExecuteNonQuery()
                If muudetudRead > 0 Then
                    tulemus = 1
                End If
            End Using
        End Using
        Return tulemus
    End Function


    ' Funktsioon treeningu nime leidmiseks läbi treeningu võtme
    Public Function TreeninguNimeLeidmine(ByVal treeninguId As Integer) As String Implements ITreeningud.TreeninguNimeLeidmine
        Dim treeninguNimi As String = ""

        Using connection As New SQLiteConnection(tabeliAsukoht)
            connection.Open()
            Dim sqlParing As String = "SELECT training_name FROM training_data WHERE training_id = @treeningu_id"
            Using cmd As New SQLiteCommand(sqlParing, connection)
                cmd.Parameters.AddWithValue("@treeningu_id", treeninguId)
                Dim tulem As Object = cmd.ExecuteScalar()
                If tulem IsNot Nothing AndAlso Not DBNull.Value.Equals(tulem) Then
                    treeninguNimi = Convert.ToString(tulem)
                End If
            End Using
        End Using
        Return treeninguNimi
    End Function
End Class
