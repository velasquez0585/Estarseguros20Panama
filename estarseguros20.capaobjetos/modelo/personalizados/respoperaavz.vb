Namespace modelo.personalizados

    Public Class respoperaavz

        Private p_irespuesta As String
        Private p_xhtmlalertas As String
        Private p_xhtmlerrores As String
        Private p_xmsjusuario As String
        Private p_xmsjtecnico As String
        Private p_id As Decimal

        Public Property irespuesta() As String
            Get
                Return Me.p_irespuesta
            End Get
            Set(ByVal Value As String)
                Me.p_irespuesta = Value
            End Set
        End Property

        Public Property xhtmlalertas() As String
            Get
                Return Me.p_xhtmlalertas
            End Get
            Set(ByVal Value As String)
                Me.p_xhtmlalertas = Value
            End Set
        End Property

        Public Property xhtmlerrores() As String
            Get
                Return Me.p_xhtmlerrores
            End Get
            Set(ByVal Value As String)
                Me.p_xhtmlerrores = Value
            End Set
        End Property

        Public Property xmsjusuario() As String
            Get
                Return Me.p_xmsjusuario
            End Get
            Set(ByVal Value As String)
                Me.p_xmsjusuario = Value
            End Set
        End Property

        Public Property xmsjtecnico() As String
            Get
                Return Me.p_xmsjtecnico
            End Get
            Set(ByVal Value As String)
                Me.p_xmsjtecnico = Value
            End Set
        End Property

        Public Property id() As Decimal
            Get
                Return Me.p_id
            End Get
            Set(ByVal Value As Decimal)
                Me.p_id = Value
            End Set
        End Property
    End Class
End Namespace
