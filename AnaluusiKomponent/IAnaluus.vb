﻿Public Interface IAnaluus
    Function paevaneKcal(kcalHommik, kcalLouna, kcalOhtu, kcalVahepala) As Integer
    Function KclParingAndmebaasist(kasutajaId As Integer, kuupaev As Integer, toidukord As Integer) As Double()
    Function ToidukordKokku(ByRef KcalLoend() As Double) As Double
    Function KuupaevIntegeriks(ByVal sisendKuupaev As DateTime) As Integer
    Function IntegerKuupaevaks(ByVal sisendInteger As Integer) As DateTime
    Function KaaluParingAndmebaasist(ByVal kasutaja_id As Integer, ByVal kuupaev As Integer) As Double()
End Interface
