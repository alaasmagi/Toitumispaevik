Imports System.IO
Imports System.Data.SQLite
Public Class CTreeningud
    Implements ITreeningud
    Public Function LisaTreening(treeninguNimi As String, energiakulu As Double) As Integer Implements ITreeningud.LisaTreening
        Throw New NotImplementedException()
    End Function

    Public Function GenereeriId() As Integer Implements ITreeningud.GenereeriId
        Dim random As New Random()
        Dim genereeritudId As Integer = random.Next(250, 500)

        Return genereeritudId
    End Function

    Public Function KiirlisamiseTreeninguNimed() As List(Of String) Implements ITreeningud.KiirlisamiseTreeninguNimed
        Dim treeninguteNimed As New List(Of String)()
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
               (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"
        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()
            For index = 0 To 250
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

    Public Function TreeninguNimiEksisteerib(treeninguNimi As String) As Integer Implements ITreeningud.TreeninguNimiEksisteerib
        Throw New NotImplementedException()
    End Function

    Public Function TreeninguEnergiakuluParing(toiduaine_id As Integer, otsitav_suurus As String) As Integer Implements ITreeningud.TreeninguEnergiakuluParing
        Throw New NotImplementedException()
    End Function

    Public Function KasutajaTreeninguLisamine(kasutaja_id As String, kuupaev As Integer, treeningu_id As Integer, kestus As Integer) As Integer Implements ITreeningud.KasutajaTreeninguLisamine
        Throw New NotImplementedException()
    End Function
End Class
