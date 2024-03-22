Imports System.Data.SQLite
Imports System.IO
Public Class CAnaluus
    Implements IAnaluus

    'Public Property kcalHommik As Integer Implements IAnaluus.kcalHommik
    'Get
    'Throw New NotImplementedException()
    'End Get
    'Set(value As Integer)
    'Throw New NotImplementedException()
    'End Set
    'End Property

    'Public Property kcalLouna As Integer Implements IAnaluus.kcalLouna
    'Get
    'Throw New NotImplementedException()
    'End Get
    'Set(value As Integer)
    'Throw New NotImplementedException()
    'End Set
    'End Property

    'Public Property kcalVahepala As Integer Implements IAnaluus.kcalVahepala
    'Get
    'Throw New NotImplementedException()
    'End Get
    'Set(value As Integer)
    'Throw New NotImplementedException()
    'End Set
    'End Property

    'Public Property kcalOhtu As Integer Implements IAnaluus.kcalOhtu
    'Get
    'Throw New NotImplementedException()
    'End Get
    'Set(value As Integer)
    'Throw New NotImplementedException()
    'End Set
    'End Property
    'ajutine!!!!!!!!!!!
    'Dim kuupaev As Integer = 100
    'Dim kasutaja_id As Integer = 

    '    Dim kcalHommik As Integer = ToidukordKokku(KclParingAndmebaasist(kasutajaId, kuupaev, ))
    '   Dim kcalHommik As Integer = ToidukordKokku()
    '  Dim kcalHommik As Integer = ToidukordKokku()
    ' Dim kcalHommik As Integer = ToidukordKokku()

    Public Function paevaneKcal(kcalHommik, kcalLouna, kcalOhtu, kcalVahepala) As Integer Implements IAnaluus.paevaneKcal
        Return kcalHommik + kcalLouna + kcalVahepala + kcalOhtu
    End Function

    Public Function KclParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal toidukord As String) As Integer() Implements IAnaluus.KclParingAndmebaasist
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = "SELECT energy_intake FROM user_food_history WHERE user_id = @kasutaja_id AND time = @kuupaev AND time_of_meal = @toidukord;"
        Dim integerValues As New List(Of Integer)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                command.Parameters.AddWithValue("@kuupaev", kuupaev)
                command.Parameters.AddWithValue("@toidukord", toidukord)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        For i As Integer = 0 To reader.FieldCount - 1
                            integerValues.Add(reader.GetInt32(i))
                        Next
                    End While
                End Using

            End Using
        End Using
        Return integerValues.ToArray()

    End Function

    Public Function ToidukordKokku(ByRef KcalLoend As Integer()) As Integer Implements IAnaluus.ToidukordKokku
        Dim koguvaartus As Integer = 0

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

End Class
