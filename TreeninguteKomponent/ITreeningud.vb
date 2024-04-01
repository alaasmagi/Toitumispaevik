Public Interface ITreeningud
    Function LisaTreening(ByVal treeninguNimi As String, ByVal energiakulu As Double) As Integer
    Function GenereeriId() As Integer
    Function KiirlisamiseTreeninguNimed() As List(Of String)
    Function TreeninguNimiEksisteerib(ByVal treeninguNimi As String) As Integer
    Function TreeninguEnergiakuluParing(ByVal toiduaine_id As Integer, ByVal otsitav_suurus As String) As Integer
    Function KasutajaTreeninguLisamine(ByVal kasutaja_id As String, ByVal kuupaev As Integer, ByVal treeningu_id As Integer, ByVal kestus As Integer) As Integer

End Interface
