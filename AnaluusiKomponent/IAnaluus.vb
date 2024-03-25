Public Interface IAnaluus
    Function paevaneKcal(kcalHommik, kcalLouna, kcalOhtu, kcalVahepala) As Integer
    Function KclParingAndmebaasist(kasutajaId As Integer, kuupaev As Integer, toidukord As Integer) As Integer()
    Function ToidukordKokku(ByRef KcalLoend() As Integer) As Integer
    Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer
    Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime
End Interface
