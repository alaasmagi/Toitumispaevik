﻿Public Interface IAnaluus
    Function PariKaloriUlejaak(tarbitudKcal As Integer, kcalLimiit As Integer) As Integer
    Function PariKcalPaveaHetkest(kuupaev As Integer, kasutaja_id As Integer, toidukord As Integer) As Integer
    Function PariValueMap(keyStr As String, ByVal valueMap As Dictionary(Of String, Integer)) As Integer
    Sub LisaValueMap(newKeyStr As String, newValue As Integer, ByVal valueMap As Dictionary(Of String, Integer))
    Function PaevaneKcal() As Integer
    Function KclParingAndmebaasist(kasutajaId As Integer, kuupaev As Integer, toidukord As Integer) As Double()
    Function ToidukordKokku(ByRef KcalLoend() As Double) As Double
    Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer
    Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime
    Function KaaluParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal graafikuPikkus As Integer) As Double()
    Function RetseptiToiduaineToitevaartuseArvutus(ByVal toitevaartus100gKohta As Integer, ByVal kogus As Integer) As Integer
    Function KaaluLisamine(ByVal kasutaja_id As Integer, ByVal uus_kaal As Double) As Double
    Function PaevaseAndmereaParing(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer) As Integer
    Function TuhjaPaevaseAndmereaSisestus(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer) As Integer
End Interface
