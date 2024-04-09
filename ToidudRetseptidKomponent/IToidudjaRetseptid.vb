Public Interface IToidudjaRetseptid
    Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                  ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer
    Function GenereeriId() As Integer
    Function KiirlisamiseToiduaineNimed() As List(Of String)
    Function ToiduAineNimiEksisteerib(ByVal foodName As String) As Integer
    Function RetseptiNimiEksisteerib(ByVal retsepti_nimi As String) As Integer
    Function ToiteVaartuseParing(ByVal toiduaine_id As Integer, ByVal otsitav_suurus As String) As Integer
    Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutaja_id As String, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toiduaine_id As Integer, ByVal kogus As Integer) As Integer
    Function LisaRetsept(ByVal retsepti_nimi As String, ByVal retsepti_kcal As Integer, ByVal retsepti_susivesikud As Integer, ByVal retsepti_suhkur As Integer,
                                ByVal retsepti_valgud As Integer, ByVal retsepti_lipiidid As Integer) As Integer
    Function KiirlisamiseRetseptideNimed() As List(Of String)
    Function LisaRetseptiKoostisosadeTabelisse(ByVal retsepti_id As Integer, ByVal toiduaine_id As Integer, ByVal kogus As Integer) As Integer
End Interface
