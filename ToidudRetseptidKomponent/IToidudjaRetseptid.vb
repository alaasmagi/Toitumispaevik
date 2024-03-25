﻿Public Interface IToidudjaRetseptid
    Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                  ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer
    Function GenereeriId() As Integer
    Function KiirlisamiseToiduaineNimed() As List(Of String)
    Function ToiduAineNimiEksisteerib(ByVal foodName As String) As Integer
    Function ToiteVaartuseParing(ByVal toiduaine_id As Integer, ByVal otsitav_suurus As String) As Integer
    Function KasutajaToiduaineVõiRetseptiLisamine(ByVal kasutaja_id As String, ByVal kuupaev As Integer, ByVal toidukord As Integer, ByVal toiduaine_id As Integer, ByVal kogus As Integer) As Integer
End Interface
