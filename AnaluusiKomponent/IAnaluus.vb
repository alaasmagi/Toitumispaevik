
' Kaloripäeviku projekt "Janar"
' Analüüsi komponendi liides
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Imports System.IO

Public Interface IAnaluus
    Function PariKaloriUlejaak(tarbitudKcal As Integer, kcalLimiit As Integer) As Integer
    Function PariKcalPaveaHetkest(kuupaev As Integer, kasutajaId As Integer, toidukord As Integer) As Integer
    Function PariValueMap(keyStr As String, ByVal valueMap As Dictionary(Of String, Integer)) As Integer
    Sub LisaValueMap(newKeyStr As String, newValue As Integer, ByVal valueMap As Dictionary(Of String, Integer))
    Function PaevaneKcal(ByVal kasutajaId As Integer, ByVal kuupaev As Integer) As Integer
    Function KclParingAndmebaasist(kasutajaId As Integer, kuupaev As Integer, toidukord As Integer) As Double()
    Function KaloridKokku(ByRef kcalLoend() As Double) As Double
    Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer
    Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime
    Function KaaluParingAndmebaasist(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal graafikuPikkus As Integer) As Double()
    Function RetseptiToiduaineToitevaartuseArvutus(ByVal toitevaartus100gKohta As Integer, ByVal kogus As Integer) As Integer
    Function DBParingBMR(ByVal kasutajaId As Integer, ByVal sugu As Integer, ByVal vanus As Integer, ByVal kaal As Double,
                         ByVal kaaluEesmark As Double, ByVal pikkus As Integer, ByVal kuupaev As Integer) As Integer
    Function KaaluLisamine(ByVal kasutajaId As Integer, ByVal uusKaal As Double) As Double
    Function PaevaseAndmereaParing(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal otsitavSuurus As String) As Integer
    Function TuhjaPaevaseAndmereaSisestus(ByVal kasutajaId As Integer, ByVal kaal As Integer, ByVal kuupaev As Integer) As Integer
    Function KaaluDateParingAndmebaasist(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal graafikuPikkus As Integer) As Integer()
    Function MakroaineParingAndmebaasist(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal makroaine As String) As Double()
    Function PariMakroaineKogus(kuupaev As Integer, kasutajaId As Integer, makroaine As String) As Integer
    Function PaevasedTreeningud(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal otsitavSuurus As String) As Double()
    Function PaevasedToidud(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal otsitavSuurus As String) As Double()
End Interface


