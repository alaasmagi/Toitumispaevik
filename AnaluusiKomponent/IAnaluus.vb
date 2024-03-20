Public Interface IAnaluus

    'Property kcalHommik As Integer
    'Property kcalLouna As Integer
    'Property kcalVahepala As Integer
    'Property kcalOhtu As Integer
    Function paevaneKcal(kcalHommik, kcalLouna, kcalOhtu, kcalVahepala) As Integer

    Function KclParingAndmebaasist(kasutajaId As Integer, kuupaev As Integer, toidukord As String) As Integer()

    Function ToidukordKokku(ByRef KcalLoend() As Integer) As Integer
End Interface
