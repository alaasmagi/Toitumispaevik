
' Kaloripäeviku projekt "Janar"
' Kasutajaprofiili komponendi liides
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Public Interface IKasutajaProfiil
    Function LooKonto(ByVal kasutajanimi As String, ByVal salasona As String, ByVal eesnimi As String,
                                 ByVal taasteId As Integer, ByVal taasteVastus As String, ByVal pikkus As Integer,
                                 ByVal kaal As Integer, ByVal sugu As Boolean, ByVal vanus As Integer) As Integer
    Function KontrolliKontoOlemasolu(ByVal kasutajanimi As String) As Integer
    Function TurvaKusimuseLeidmine(ByVal kasutajaId As Integer) As String
    Function SisseLogimine(ByVal kasutajaId As Integer, ByVal salasona As String) As Integer
    Function GenereeriId() As Integer
    Function ArvutaHash(ByVal sisend As String) As String
    Function UheAndmevaljaParingKasutajaTabelist(ByVal kasutajaId As Integer, ByVal andmevali As String) As String
    Function Krupteerimine(ByVal sisend As String) As String
    Function Dekrupteerimine(ByVal sisend As String) As String
    Function UheIntegerAndmeValjaParingKasutajaTabelist(ByVal kasutajaId As Integer, ByVal andmevali As String) As Integer
    Function TurvaKusimused() As List(Of String)
    Sub IntegerAndmeValjaSisestusKasutajaTabelisse(ByVal kasutajaId As Integer, ByVal uusVaartus As Integer, ByVal andmevali As String)
    Sub VahetaSalasona(ByVal kasutajaId As String, ByVal uusSalasona As String)

End Interface
