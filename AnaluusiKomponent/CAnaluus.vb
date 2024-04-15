﻿Imports System.Data.SQLite
Imports System.IO
Public Class CAnaluus

    Implements IAnaluus

    Private valueMap As New Dictionary(Of String, Integer)()
    Private hommik
    Private louna
    Private ohtu
    Private vahepala

    Public Function PariKaloriUlejaak(tarbitudKcal As Integer, KcalLimiit As Integer) As Integer Implements IAnaluus.PariKaloriUlejaak
        If tarbitudKcal > KcalLimiit Then
            Return 0
        Else
            Return KcalLimiit - tarbitudKcal
        End If
        Return 0
    End Function

    Public Function PariKcalPaveaHetkest(kuupaev As Integer, kasutaja_id As Integer, toidukord As Integer) As Integer Implements IAnaluus.PariKcalPaveaHetkest
        Select Case toidukord
            Case 0
                hommik = ToidukordKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return hommik
            Case 1
                louna = ToidukordKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return louna
            Case 2
                vahepala = ToidukordKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return vahepala
            Case 3
                ohtu = ToidukordKokku(KclParingAndmebaasist(kasutaja_id, kuupaev, toidukord))
                Return ohtu
        End Select
        Return 0
    End Function

    Public Function PariValueMap(keyStr As String) As Integer Implements IAnaluus.PariValueMap
        If valueMap.ContainsKey(keyStr) Then
            Return valueMap(keyStr)
        End If
        Return 0
    End Function

    Public Sub LisaValueMap(newKeyStr As String, newValue As Integer) Implements IAnaluus.LisaToValueMap
        If Not valueMap.ContainsKey(newKeyStr) Then
            valueMap.Add(newKeyStr, newValue)
        End If
    End Sub

    Public Function PaevaneKcal() As Integer Implements IAnaluus.PaevaneKcal
        Return hommik + louna + vahepala + ohtu
    End Function

    Private Function KclParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal toidukord As Integer) As Double() Implements IAnaluus.KclParingAndmebaasist
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

    Public Function KaaluParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal graafikuPikkus As Integer) As Double() Implements IAnaluus.KaaluParingAndmebaasist
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
    (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim paring As String = "SELECT daily_weight FROM user_daily_data WHERE user_id = @kasutaja_id AND date BETWEEN @startDate AND @endDate ORDER BY date DESC;"
        Dim doubleValues As New List(Of Double)

        Using connection As New SQLiteConnection(tabeli_asukoht)
            Using command As New SQLiteCommand(paring, connection)
                command.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Dim startDate As Integer = kuupaev - graafikuPikkus
                Dim endDate As Integer = kuupaev
                command.Parameters.AddWithValue("@startDate", startDate)
                command.Parameters.AddWithValue("@endDate", endDate)

                connection.Open()

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        doubleValues.Add(reader.GetDouble(0))
                    End While
                End Using

            End Using
        End Using
        Return doubleValues.ToArray()
    End Function
    Public Function KaaluLisamine(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal uus_kaal As Double, ByVal tarbitudKcal As Integer,
                                  ByVal kulutatudKcal As Integer, ByVal kcalBalanss As Integer, ByVal totalCHyd As Integer, ByVal suhkur As Integer,
                                  ByVal valk As Integer, ByVal rasv As Integer) As Double Implements IAnaluus.KaaluLisamine
        Dim tabeli_asukoht As String = $"Data Source={Path.Combine(Path.GetFullPath(Path.Combine _
        (AppDomain.CurrentDomain.BaseDirectory, "..\..\..\")), "Data", "database.db")};Version=3;"

        Dim kasutaja_olemas As Boolean = False

        Using connection As New SQLiteConnection(tabeli_asukoht)
            connection.Open()

            Dim checkUserSql As String = $"SELECT COUNT(*) FROM user_daily_data WHERE user_id = @kasutaja_id;"
            Using cmdCheckUser As New SQLiteCommand(checkUserSql, connection)
                cmdCheckUser.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                Dim kasutaja_olemas_tulemus As Integer = CInt(cmdCheckUser.ExecuteScalar())
                If kasutaja_olemas_tulemus > 0 Then
                    kasutaja_olemas = True
                End If
            End Using

            If kasutaja_olemas Then
                Dim updateDataSql As String = $"UPDATE user_daily_data SET daily_weight = @kaal WHERE user_id = @kasutaja_id;"
                Using cmdUpdateData As New SQLiteCommand(updateDataSql, connection)
                    cmdUpdateData.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                    cmdUpdateData.Parameters.AddWithValue("@kaal", uus_kaal)
                    cmdUpdateData.ExecuteNonQuery()
                End Using
            Else
                Dim insertDataSql As String = $"INSERT INTO user_daily_data (user_id, data, daily_weight, energy_intake, energy_consumption, energy_balance, _
                    total_c_hydrates, total_sugar, total_protein, total_lipid) _
                    VALUES (@kasutaja_id, @kuupaev, @uus_kaal, @tarbitudKcal, @kulutatudKcal, @kcalBalanss, @totalCHyd, @suhkur, @valk, @rasv);"
                Using cmdInsertData As New SQLiteCommand(insertDataSql, connection)
                    cmdInsertData.Parameters.AddWithValue("@kasutaja_id", kasutaja_id)
                    cmdInsertData.Parameters.AddWithValue("@data", kuupaev)
                    cmdInsertData.Parameters.AddWithValue("@kaal", uus_kaal)
                    cmdInsertData.Parameters.AddWithValue("@tarbitudKcal", tarbitudKcal)
                    cmdInsertData.Parameters.AddWithValue("@kulutatudKcal", kulutatudKcal)
                    cmdInsertData.Parameters.AddWithValue("@kcalBalanss", kcalBalanss)
                    cmdInsertData.Parameters.AddWithValue("@totalCHyd", totalCHyd)
                    cmdInsertData.Parameters.AddWithValue("@suhkur", suhkur)
                    cmdInsertData.Parameters.AddWithValue("@valk", valk)
                    cmdInsertData.Parameters.AddWithValue("@rasv", rasv)

                    cmdInsertData.ExecuteNonQuery()
                End Using
            End If
        End Using

        Return uus_kaal
    End Function

    Private Function ToidukordKokku(ByRef KcalLoend As Double()) As Double Implements IAnaluus.ToidukordKokku
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

    Public Function RetseptiToiduaineToitevaartuseArvutus(ByVal toitevaartus100gKohta As Integer, ByVal kogus As Integer) As Integer Implements IAnaluus.RetseptiToiduaineToitevaartuseArvutus
        Return (toitevaartus100gKohta / 100) * kogus
    End Function
End Class
