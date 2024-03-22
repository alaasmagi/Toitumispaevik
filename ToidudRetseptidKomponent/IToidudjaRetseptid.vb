﻿Public Interface IToidudjaRetseptid
    Function LisaToiduaine(ByVal toiduainenimi As String, ByVal energia As Double, ByVal valgud As Double,
                                  ByVal susivesikud As Double, ByVal rasvad As Double, ByVal suhkrud As Double) As Integer
    Function GenereeriId() As Integer
    Function KiirlisamiseToiduaineNimed() As List(Of String)
    Function ToiduAineNimiEksisteerib(ByVal foodName As String) As Integer
End Interface
