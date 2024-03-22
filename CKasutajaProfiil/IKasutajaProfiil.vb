Public Interface IKasutajaProfiil
    Function LooKonto(ByVal kasutajanimi As String, ByVal salasona As String, ByVal eesnimi As String,
                                 ByVal taaste_id As Integer, ByVal taaste_vastus As String, ByVal pikkus As Integer,
                                 ByVal kaal As Integer, ByVal sugu As Boolean, ByVal vanus As Integer) As Integer
    Function KontrolliKontoOlemasolu(ByVal kasutajanimi As String) As Integer
    Function TurvaKusimuseLeidmine(ByVal kasutaja_id As Integer) As String
    Function SisseLogimine(ByVal kasutaja_id As Integer, ByVal salasona As String) As Integer
    Function GenereeriId() As Integer
    Function ArvutaHash(ByVal sisend As String) As String
    Function UheAndmevaljaParingKasutajaTabelist(ByVal kasutaja_id As String, ByVal andmevali As String) As String
    Function Krupteerimine(ByVal sisend As String) As String
    Function Dekrupteerimine(ByVal sisend As String) As String
    Function UheIntegerAndmeValjaParingKasutajaTabelist(ByVal kasutaja_id As Integer, ByVal andmevali As String) As Integer
    Function TurvaKusimused() As List(Of String)
    Sub IntegerAndmeValjaSisestusKasutajaTabelisse(ByVal kasutaja_id As Integer, ByVal uus_vaartus As Integer, ByVal andmevali As String)
    Sub VahetaSalasona(ByVal kasutaja_id As String, ByVal uus_salasona As String)

End Interface
