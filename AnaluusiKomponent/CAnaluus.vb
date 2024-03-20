Public Class CAnaluus
    Implements IAnaluus

    Public Property kcalPaev As Integer Implements IAnaluus.kcalPaev
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property kcalHommik As Integer Implements IAnaluus.kcalHommik
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property kcalLouna As Integer Implements IAnaluus.kcalLouna
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property kcalVahepala As Integer Implements IAnaluus.kcalVahepala
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property kcalOhtu As Integer Implements IAnaluus.kcalOhtu
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Function paevaneKcal() As Integer Implements IAnaluus.paevaneKcal
        Return kcalHommik + kcalLouna + kcalVahepala + kcalOhtu
    End Function
End Class
