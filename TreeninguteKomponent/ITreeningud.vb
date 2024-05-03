
' Kaloripäeviku projekt "Janar"
' Treeningute komponendi liides
'
' Autorid:
'           Aleksander Laasmägi
'           Kristofer Mäeots
'           Carmen Raun
'           Eeva-Maria Tšernova
'
' 2024, TalTech

Public Interface ITreeningud
    Function LisaTreening(ByVal treeninguNimi As String, ByVal energiaKulu As Double) As Integer
    Function GenereeriId() As Integer
    Function KiirlisamiseTreeninguNimed() As List(Of String)
    Function TreeninguNimiEksisteerib(ByVal treeninguNimi As String) As Integer
    Function TreeninguEnergiakuluParing(ByVal treeninguId As Integer) As Integer
    Function KasutajaTreeninguLisamine(ByVal kasutajaId As String, ByVal kuupaev As Integer, ByVal treeninguId As Integer, ByVal kestus As Integer) As Integer
    Function KustutaTreening(ByVal treeninguId As Integer) As Integer
    Function TreeninguNimeLeidmine(ByVal treeninguId As Integer) As String
End Interface
