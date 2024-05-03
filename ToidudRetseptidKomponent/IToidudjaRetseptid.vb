
' Kaloripäeviku projekt "Janar"
' Toitude ja retseptide komponendi liides
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Public Interface IToidudjaRetseptid
    Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                  ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer
    Function GenereeriId(ByVal toiduaineFlag As Integer) As Integer
    Function KiirlisamiseToiduaineNimed(ByVal mukbangFlag As Integer) As List(Of String)
    Function ToiduAineNimiEksisteerib(ByVal toiduaineNimi As String) As Integer
    Function RetseptiNimiEksisteerib(ByVal retseptiNimi As String) As Integer
    Function ToiteVaartuseParing(ByVal toiduaineId As Integer, ByVal otsitavSuurus As String, ByVal retseptFlag As Integer) As Integer
    Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutajaId As Integer, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toiduaineId As Integer, ByVal kogus As Integer) As Integer
    Function LisaRetsept(ByVal retseptiNimi As String, ByVal retseptiKcal As Integer, ByVal retseptiSusivesikud As Integer, ByVal retseptiSuhkur As Integer,
                                ByVal retseptiValgud As Integer, ByVal retseptiLipiidid As Integer) As Integer
    Function KiirlisamiseRetseptideNimed(ByVal mukbangFlag As Integer) As List(Of String)
    Function LisaRetseptiKoostisosadeTabelisse(ByVal retseptiId As Integer, ByVal toiduaineId As Integer, ByVal kogus As Integer) As Integer
    Function ToiduaineVoiRetseptiKustutamine(ByVal toiduaineRetseptiId As Integer, ByVal toiduaineFlag As Integer) As Integer
    Function ToiduaineVoiRetseptiNimi(ByVal toiduaineVoiRetseptiId As Integer, ByVal retseptFlag As Integer) As String
End Interface
