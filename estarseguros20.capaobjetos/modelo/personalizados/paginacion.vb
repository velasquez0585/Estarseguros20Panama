
Namespace modelo.personalizados

    Public Class paginacion

        Private p_npagactual As Integer
        Private p_npagtamano As Integer
        Private p_npagcantidad As Integer
        Private p_xcamposord As String
        Private p_idirord As String

        Public Property npagactual() As Integer
            Get
                Return Me.p_npagactual
            End Get
            Set(ByVal Value As Integer)
                Me.p_npagactual = Value
            End Set
        End Property

        Public Property npagtamano() As Integer
            Get
                Return Me.p_npagtamano
            End Get
            Set(ByVal Value As Integer)
                Me.p_npagtamano = Value
            End Set
        End Property

        Public Property npagcantidad() As Integer
            Get
                Return Me.p_npagcantidad
            End Get
            Set(ByVal Value As Integer)
                Me.p_npagcantidad = Value
            End Set
        End Property

        Public Property xcamposord() As String
            Get
                Return Me.p_xcamposord
            End Get
            Set(ByVal Value As String)
                Me.p_xcamposord = Value
            End Set
        End Property

        Public Property idirord() As String
            Get
                Return Me.p_idirord
            End Get
            Set(ByVal Value As String)
                Me.p_idirord = Value
            End Set
        End Property

    End Class
End Namespace
