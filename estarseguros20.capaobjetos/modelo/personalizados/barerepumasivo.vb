Namespace modelo.personalizados

    Public Class barerepumasivo

        Private p_idaipbarerepu As Decimal
        Private p_xconcepto As String
        Private p_xvalorcodigo As String


        Public Property idaipbarerepu() As Decimal
            Get
                Return Me.p_idaipbarerepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipbarerepu = Value
            End Set
        End Property

        Public Property xconcepto() As String
            Get
                Return Me.p_xconcepto
            End Get
            Set(ByVal Value As String)
                Me.p_xconcepto = Value
            End Set
        End Property

        Public Property xvalorcodigo() As String
            Get
                Return Me.p_xvalorcodigo
            End Get
            Set(ByVal Value As String)
                Me.p_xvalorcodigo = Value
            End Set
        End Property

    End Class
End Namespace
