Public Interface IToiduaine
    Function LisaToiduaine(ByVal nimetus As String, ByVal kalorid As Double, ByVal valgud As Double,
                           ByVal süsivesikud As Double, ByVal rasvad As Double) As Integer
    Function LeiaToiduaineNimetus(ByVal toiduaine_id As Integer) As String

End Interface
