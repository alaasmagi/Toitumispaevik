Imports System.Data.SQLite
Imports System.IO
Public Class CAnaluus
    Implements IAnaluus
    Public Function paevaneKcal(kcalHommik, kcalLouna, kcalOhtu, kcalVahepala) As Integer Implements IAnaluus.paevaneKcal
        Return kcalHommik + kcalLouna + kcalVahepala + kcalOhtu
    End Function

    Public Function KclParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal toidukord As Integer) As Double() Implements IAnaluus.KclParingAndmebaasist
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = "SELECT energy_intake FROM user_food_history WHERE user_id = @kasutaja_id AND date = @kuupaev AND time_of_meal = @toidukord;"
        Dim doubleValues As New List(Of Double)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                command.Parameters.AddWithValue("@kuupaev", kuupaev)
                command.Parameters.AddWithValue("@toidukord", toidukord)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        For i As Double = 0 To reader.FieldCount - 1
                            doubleValues.Add(reader.GetDouble(i))
                        Next
                    End While
                End Using

            End Using
        End Using
        Return doubleValues.ToArray()

    End Function

    Public Function ToidukordKokku(ByRef KcalLoend As Double()) As Double Implements IAnaluus.ToidukordKokku
        Dim koguvaartus As Double = 0

        For i As Integer = 0 To KcalLoend.Length - 1
            koguvaartus += KcalLoend(i)
        Next
        Return koguvaartus
    End Function

    Public Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer Implements IAnaluus.KuupaevIntegeriks
        Dim unixAeg As New DateTime(1970, 1, 1)
        Return (sisendKuupaev - unixAeg).Days
    End Function

    Public Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime Implements IAnaluus.IntegerKuupaevaks
        Dim unixAeg As New DateTime(1970, 1, 1)
        Return (unixAeg.AddDays(sisendInteger))
    End Function

    ' muuda
    Public Function KaaluLisamine(kasutaja_id As String, kuupaev As Integer, treeningu_id As Integer, kestus As Integer) As Integer Implements ITreeningud.KasutajaTreeninguLisamine
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
End Class
