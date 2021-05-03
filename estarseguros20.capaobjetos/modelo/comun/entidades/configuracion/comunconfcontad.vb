Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace comun.modelo.dbestarseguros20.entidades.configuracion

    Public Class comunconfcontad

        Private p_idcomunconfcontad As Decimal
        Private p_idcomunmanpais As Decimal
        Private p_xnombrecontad As String
        Private p_nsecuencia As Decimal
        Private p_nincremento As Int32
        Private p_ninicio As Decimal
        Private p_istatuscontad As String
        Private p_idseglogreg As Decimal

        Public Property idcomunconfcontad() As Decimal
            Get
                Return Me.p_idcomunconfcontad
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunconfcontad = Value
            End Set
        End Property

        Public Property idcomunmanpais() As Decimal
            Get
                Return Me.p_idcomunmanpais
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpais = Value
            End Set
        End Property

        Public Property xnombrecontad() As String
            Get
                Return Me.p_xnombrecontad
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecontad = Value
            End Set
        End Property

        Public Property nsecuencia() As Decimal
            Get
                Return Me.p_nsecuencia
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nsecuencia = Value
            End Set
        End Property

        Public Property nincremento() As Int32
            Get
                Return Me.p_nincremento
            End Get
            Set(ByVal Value As Int32)
                Me.p_nincremento = Value
            End Set
        End Property

        Public Property ninicio() As Decimal
            Get
                Return Me.p_ninicio
            End Get
            Set(ByVal Value As Decimal)
                Me.p_ninicio = Value
            End Set
        End Property

        Public Property istatuscontad() As String
            Get
                Return Me.p_istatuscontad
            End Get
            Set(ByVal Value As String)
                Me.p_istatuscontad = Value
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
