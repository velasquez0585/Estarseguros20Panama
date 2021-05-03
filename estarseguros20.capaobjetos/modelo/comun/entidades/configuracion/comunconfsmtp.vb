Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace comun.modelo.dbestarseguros20.entidades.configuracion

    Public Class comunconfsmtp

        Private p_idcomunconfsmtp As Decimal
        Private p_xhost As String
        Private p_npuerto As Int64
        Private p_xcuenta As String
        Private p_xcontrasena As String
        Private p_issl As Boolean
        Private p_xdescripsmtp As String
        Private p_idseglogreg As Decimal

        Public Property idcomunconfsmtp() As Decimal
            Get
                Return Me.p_idcomunconfsmtp
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunconfsmtp = Value
            End Set
        End Property

        Public Property xhost() As String
            Get
                Return Me.p_xhost
            End Get
            Set(ByVal Value As String)
                Me.p_xhost = Value
            End Set
        End Property

        Public Property npuerto() As Int64
            Get
                Return Me.p_npuerto
            End Get
            Set(ByVal Value As Int64)
                Me.p_npuerto = Value
            End Set
        End Property

        Public Property xcuenta() As String
            Get
                Return Me.p_xcuenta
            End Get
            Set(ByVal Value As String)
                Me.p_xcuenta = Value
            End Set
        End Property

        Public Property xcontrasena() As String
            Get
                Return Me.p_xcontrasena
            End Get
            Set(ByVal Value As String)
                Me.p_xcontrasena = Value
            End Set
        End Property

        Public Property issl() As Boolean
            Get
                Return Me.p_issl
            End Get
            Set(ByVal Value As Boolean)
                Me.p_issl = Value
            End Set
        End Property

        Public Property xdescripsmtp() As String
            Get
                Return Me.p_xdescripsmtp
            End Get
            Set(ByVal Value As String)
                Me.p_xdescripsmtp = Value
            End Set
        End Property

        Public Property idseglogreg() As Decimal
            Get
                Return Me.p_idseglogreg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idseglogreg = Value
            End Set
        End Property

    End Class
End Namespace
