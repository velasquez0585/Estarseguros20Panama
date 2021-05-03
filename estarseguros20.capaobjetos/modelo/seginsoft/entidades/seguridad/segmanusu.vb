
Namespace seginsoft.modelo.dbestarseguros20.entidades.seguridad

    Public Class segmanusu

        Private p_idsegmanusu As Decimal
        Private p_idcomunmanpers As Decimal
        Private p_idcomunmancom As Decimal
        Private p_idcomunmandir As Decimal
        Private p_idsegmanorg As Decimal
        Private p_idsegmandep As Decimal
        Private p_idsegmancarg As Decimal
        Private p_xnombreusuario As String
        Private p_xcontrasena As String
        Private p_fcreacion As DateTime
        Private p_ibloqueado As Boolean
        Private p_fultbloqueo As DateTime
        Private p_fultiniciosesion As DateTime
        Private p_fultcambpass As DateTime
        Private p_fultrecuppass As DateTime
        Private p_fultpassintfallido As DateTime
        Private p_npassintfallido As Int64
        Private p_npassintfallidoacum As Int64
        Private p_idseglogreg As Decimal


        Public Property idsegmanusu() As Decimal
            Get
                Return Me.p_idsegmanusu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusu = Value
            End Set
        End Property


        Public Property idcomunmanpers() As Decimal
            Get
                Return Me.p_idcomunmanpers
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpers = Value
            End Set
        End Property


        Public Property idcomunmancom() As Decimal
            Get
                Return Me.p_idcomunmancom
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmancom = Value
            End Set
        End Property


        Public Property idcomunmandir() As Decimal
            Get
                Return Me.p_idcomunmandir
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmandir = Value
            End Set
        End Property


        Public Property idsegmanorg() As Decimal
            Get
                Return Me.p_idsegmanorg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorg = Value
            End Set
        End Property


        Public Property idsegmandep() As Decimal
            Get
                Return Me.p_idsegmandep
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmandep = Value
            End Set
        End Property


        Public Property idsegmancarg() As Decimal
            Get
                Return Me.p_idsegmancarg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmancarg = Value
            End Set
        End Property


        Public Property xnombreusuario() As String
            Get
                Return Me.p_xnombreusuario
            End Get
            Set(ByVal Value As String)
                Me.p_xnombreusuario = Value
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


        Public Property fcreacion() As DateTime
            Get
                Return Me.p_fcreacion
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcreacion = Value
            End Set
        End Property


        Public Property ibloqueado() As Boolean
            Get
                Return Me.p_ibloqueado
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ibloqueado = Value
            End Set
        End Property


        Public Property fultbloqueo() As DateTime
            Get
                Return Me.p_fultbloqueo
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultbloqueo = Value
            End Set
        End Property


        Public Property fultiniciosesion() As DateTime
            Get
                Return Me.p_fultiniciosesion
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultiniciosesion = Value
            End Set
        End Property


        Public Property fultcambpass() As DateTime
            Get
                Return Me.p_fultcambpass
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultcambpass = Value
            End Set
        End Property


        Public Property fultrecuppass() As DateTime
            Get
                Return Me.p_fultrecuppass
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultrecuppass = Value
            End Set
        End Property


        Public Property fultpassintfallido() As DateTime
            Get
                Return Me.p_fultpassintfallido
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultpassintfallido = Value
            End Set
        End Property


        Public Property npassintfallido() As Int64
            Get
                Return Me.p_npassintfallido
            End Get
            Set(ByVal Value As Int64)
                Me.p_npassintfallido = Value
            End Set
        End Property


        Public Property npassintfallidoacum() As Int64
            Get
                Return Me.p_npassintfallidoacum
            End Get
            Set(ByVal Value As Int64)
                Me.p_npassintfallidoacum = Value
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
