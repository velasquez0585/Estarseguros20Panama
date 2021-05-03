Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace comun.modelo.dbestarseguros20.entidades.mantenimiento

    Public Class comunmanlocalid

        Private p_idcomunmanlocalid As Decimal
        Private p_idcomunmanestado As Decimal
        Private p_idcomunmanpais As Decimal
        Private p_idcomunmancont As Decimal
        Private p_xnombrelocalid As String
        Private p_xlatitud As String
        Private p_xlongitud As String
        Private p_idseglogreg As Decimal


        Public Property idcomunmanlocalid() As Decimal
            Get
                Return Me.p_idcomunmanlocalid
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanlocalid = Value
            End Set
        End Property

        Public Property idcomunmanestado() As Decimal
            Get
                Return Me.p_idcomunmanestado
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanestado = Value
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

        Public Property idcomunmancont() As Decimal
            Get
                Return Me.p_idcomunmancont
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmancont = Value
            End Set
        End Property

        Public Property xnombrelocalid() As String
            Get
                Return Me.p_xnombrelocalid
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrelocalid = Value
            End Set
        End Property

        Public Property xlatitud() As String
            Get
                Return Me.p_xlatitud
            End Get
            Set(ByVal Value As String)
                Me.p_xlatitud = Value
            End Set
        End Property

        Public Property xlongitud() As String
            Get
                Return Me.p_xlongitud
            End Get
            Set(ByVal Value As String)
                Me.p_xlongitud = Value
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
