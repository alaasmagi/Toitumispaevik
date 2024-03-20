Imports System.Data.SQLite
Imports System.IO

Public Class CToiduaine

    Public Function LisaToiduaine(ByVal nimetus As String, ByVal kalorid As Double, ByVal valgud As Double,
                                   ByVal süsivesikud As Double, ByVal rasvad As Double) As Integer

        Dim toiduaine_id As Integer = GenereeriId()
        Dim olek As Integer


        Dim connectionString As String = "Data Source=toiduained.db;Version=3;"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' SQL käsk, et toidud sisestada koos makroainetega
            Dim insertDataSql As String = "INSERT INTO toiduained (toiduaine_id, nimetus, kalorid, valgud, süsivesikud, rasvad) " &
                                          "VALUES (@toiduaine_id, @nimetus, @kalorid, @valgud, @süsivesikud, @rasvad)"

            Using cmd As New SQLiteCommand(insertDataSql, connection)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaine_id)
                cmd.Parameters.AddWithValue("@nimetus", nimetus)
                cmd.Parameters.AddWithValue("@kalorid", kalorid)
                cmd.Parameters.AddWithValue("@valgud", valgud)
                cmd.Parameters.AddWithValue("@süsivesikud", süsivesikud)
                cmd.Parameters.AddWithValue("@rasvad", rasvad)


                olek = cmd.ExecuteNonQuery()
            End Using
        End Using

        Return olek
    End Function

    Public Function LeiaToiduaineNimetus(ByVal toiduaine_id As Integer) As String
        Dim nimetus As String = ""
        Dim connectionString As String = "Data Source=toiduained.db;Version=3;"

        Using connection As New SQLiteConnection(connectionString)
            connection.Open()


            Dim sql As String = "SELECT nimetus FROM toiduained WHERE toiduaine_id = @toiduaine_id"

            Using cmd As New SQLiteCommand(sql, connection)
                cmd.Parameters.AddWithValue("@toiduaine_id", toiduaine_id)

                ' Andmebaasis info lugemine, põhinedes otsitaval sõnal
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        nimetus = reader("nimetus").ToString()
                    End While
                End Using
            End Using
        End Using

        Return nimetus
    End Function


    Private Function GenereeriId() As Integer
        Dim random As New Random()
        Return random.Next(1002, 10000)
    End Function
End Class
