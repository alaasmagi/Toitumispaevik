﻿Public Interface IToidudjaRetseptid
    Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                  ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer
    Function GenereeriId(ByVal toiduaineFlag As Integer) As Integer
    Function KiirlisamiseToiduaineNimed(ByVal mukbangFlag As Integer) As List(Of String)
    Function ToiduAineNimiEksisteerib(ByVal foodName As String) As Integer
    Function RetseptiNimiEksisteerib(ByVal retsepti_nimi As String) As Integer
    Function ToiteVaartuseParing(ByVal toiduaine_id As Integer, ByVal otsitav_suurus As String, ByVal retseptFlag As Integer) As Integer
    Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutaja_id As String, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toiduaine_id As Integer, ByVal kogus As Integer) As Integer
    Function LisaRetsept(ByVal retsepti_nimi As String, ByVal retsepti_kcal As Integer, ByVal retsepti_susivesikud As Integer, ByVal retsepti_suhkur As Integer,
                                ByVal retsepti_valgud As Integer, ByVal retsepti_lipiidid As Integer) As Integer
    Function KiirlisamiseRetseptideNimed(ByVal mukbangFlag As Integer) As List(Of String)
    Function LisaRetseptiKoostisosadeTabelisse(ByVal retsepti_id As Integer, ByVal toiduaine_id As Integer, ByVal kogus As Integer) As Integer
    Function ToiduaineVoiRetseptiKustutamine(ByVal toiduaine_retsepti_id As Integer, ByVal toiduaineFlag As Integer) As Integer
    Function ToiduaineVoiRetseptiNimi(ByVal toiduaineVoiRetseptiId As Integer, ByVal retseptFlag As Integer) As String
End Interface
