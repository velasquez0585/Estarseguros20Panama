Namespace modelo.personalizados

    Public Class baremobrmasivo

        Private p_idaipbaremobr As Decimal
        Private p_xconcepto As String
        Private p_xvalorcodigo As String


        Public Property idaipbaremobr() As Decimal
            Get
                Return Me.p_idaipbaremobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipbaremobr = Value
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
