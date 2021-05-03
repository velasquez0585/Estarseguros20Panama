Namespace modelo.personalizados
    Public Class aipinstotalpers
        Private p_ninstotalperspend As Integer
        Private p_ninstotalpersasig As Integer

        Public Property ninstotalperspend() As Integer
            Get
                Return Me.p_ninstotalperspend
            End Get
            Set(ByVal Value As Integer)
                Me.p_ninstotalperspend = Value
            End Set
        End Property

        Public Property ninstotalpersasig() As Integer
            Get
                Return Me.p_ninstotalpersasig
            End Get
            Set(ByVal Value As Integer)
                Me.p_ninstotalpersasig = Value
            End Set
        End Property

    End Class
End Namespace