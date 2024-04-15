Imports System.IO

Public Interface IAnaluus
    Function PariKaloriUlejaak(tarbitudKcal As Integer, kcalLimiit As Integer) As Integer
    Function PariKcalPaveaHetkest(kuupaev As Integer, kasutaja_id As Integer, toidukord As Integer) As Integer
    Function PariValueMap(keyStr As String) As Integer
    Sub LisaToValueMap(newKeyStr As String, newValue As Integer)
    Function PaevaneKcal() As Integer
    Function KclParingAndmebaasist(kasutajaId As Integer, kuupaev As Integer, toidukord As Integer) As Double()
    Function ToidukordKokku(ByRef KcalLoend() As Double) As Double
    Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer
    Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime
    Function KaaluParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal graafikuPikkus As Integer) As Double()
    Function RetseptiToiduaineToitevaartuseArvutus(ByVal toitevaartus100gKohta As Integer, ByVal kogus As Integer) As Integer
    Function KaaluLisamine(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer, ByVal uus_kaal As Double, ByVal tarbitudKcal As Integer,
                                  ByVal kulutatudKcal As Integer, ByVal kcalBalanss As Integer, ByVal totalCHyd As Integer, ByVal suhkur As Integer,
                                  ByVal valk As Integer, ByVal rasv As Integer) As Double
    Public Function DBParingBMR(ByVal kasutaja_id As Integer, ByVal sugu As Integer,
                                ByVal kaal As Double, ByVal pikkus As Integer, ByVal vanus As Integer,
                                ByVal kcal_limiit As Integer) As Integer
End Interface
