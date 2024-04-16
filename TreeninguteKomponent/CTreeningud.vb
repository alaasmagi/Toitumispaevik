Imports System.IO
Imports System.Data.SQLite
Public Class CTreeningud
    Implements ITreeningud
    Public Function LisaTreening(treeninguNimi As String, energiakulu As Double) As Integer Implements ITreeningud.LisaTreening
        Dim treeningu_id As Integer = GenereeriId()

        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO training_data (training_id, training_name, consumption)
          VALUES (@treeningu_id, @treeninguNimi, @energiakulu)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@treeningu_id", treeningu_id)
                cmd.Parameters.AddWithValue("@treeninguNimi", treeninguNimi)
                cmd.Parameters.AddWithValue("@energiakulu", energiakulu)

                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return treeningu_id
    End Function

    Public Function GenereeriId() As Integer Implements ITreeningud.GenereeriId
        Dim random As New Random()
        Dim genereeritudId As Integer = random.Next(4006, 4500)

        Return genereeritudId
    End Function

    Public Function KiirlisamiseTreeninguNimed() As List(Of String) Implements ITreeningud.KiirlisamiseTreeninguNimed
        Dim treeninguteNimed As New List(Of String)()
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
               (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            For index = 4000 To 4500
                Dim selectSql As String = "SELECT training_name FROM training_data WHERE training_id = @id"

                Using cmd As New SQLiteCommand(selectSql, connection)
                    cmd.Parameters.AddWithValue("@id", index)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            treeninguteNimed.Add(reader("training_name"))
                        End While
                    End Using
                End Using
            Next
        End Using
        Return treeninguteNimed
    End Function

    Public Function TreeninguNimiEksisteerib(ByVal treeninguNimi As String) As Integer Implements ITreeningud.TreeninguNimiEksisteerib
        Dim treeningu_id As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = "SELECT training_id FROM training_data WHERE training_name = @treeninguNimi"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@treeninguNimi", treeninguNimi)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    treeningu_id = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return treeningu_id
    End Function

    Public Function TreeninguEnergiakuluParing(treeningu_id As Integer, otsitav_suurus As String) As Integer Implements ITreeningud.TreeninguEnergiakuluParing
        Dim tulemus As Integer
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim selectSql As String = $"SELECT {otsitav_suurus} FROM training_data WHERE training_id = @treeningu_id"
            Using cmd As New SQLiteCommand(selectSql, connection)
                cmd.Parameters.AddWithValue("@treeningu_id", treeningu_id)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    tulemus = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return tulemus
    End Function

    Public Function KasutajaTreeninguLisamine(kasutaja_id As String, kuupaev As Integer, treeningu_id As Integer, kestus As Integer) As Integer Implements ITreeningud.KasutajaTreeninguLisamine
        Dim energiakulu = kestus * (TreeninguEnergiakuluParing(treeningu_id, "consumption") / 60)

        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim insertDataSql As String = "INSERT INTO user_training_history (user_id, date, training_id, total_consumption, duration)
          VALUES (@kasutaja_id, @kuupaev, @treeningu_id, @energiakulu, @kestus)"
            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                cmd.Parameters.AddWithValue("@kuupaev", kuupaev)
                cmd.Parameters.AddWithValue("@treeningu_id", treeningu_id)
                cmd.Parameters.AddWithValue("@energiakulu", energiakulu)
                cmd.Parameters.AddWithValue("@kestus", kestus)
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Return treeningu_id
    End Function

    Public Function KustutaTreening(treeningu_id As Integer) As Integer Implements ITreeningud.KustutaTreening
        Dim tulemus As Integer = 0
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            Dim deleteSql As String = $"DELETE FROM training_data WHERE training_id = @treeningu_id"
            Using cmd As New SQLiteCommand(deleteSql, connection)
                cmd.Parameters.AddWithValue("@treeningu_id", treeningu_id)
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    tulemus = 1
                End If
            End Using
        End Using
        Return tulemus
    End Function

End Class
