Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace comun.modelo.dbestarseguros20.entidades.mantenimiento

    Public Class comunmanpais

        Private p_idcomunmanpais As Decimal
        Private p_idcomunmancont As Decimal
        Private p_xnombrepais As String
        Private p_xlenguajeabrev As String
        Private p_xlenguaje As String
        Private p_xnombrepaisabrev As String
        Private p_xcultura As String
        Private p_xlatitud As String
        Private p_xlongitud As String
        Private p_idseglogreg As Decimal

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

        Public Property xnombrepais() As String
            Get
                Return Me.p_xnombrepais
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrepais = Value
            End Set
        End Property

        Public Property xlenguajeabrev() As String
            Get
                Return Me.p_xlenguajeabrev
            End Get
            Set(ByVal Value As String)
                Me.p_xlenguajeabrev = Value
            End Set
        End Property

        Public Property xlenguaje() As String
            Get
                Return Me.p_xlenguaje
            End Get
            Set(ByVal Value As String)
                Me.p_xlenguaje = Value
            End Set
        End Property

        Public Property xnombrepaisabrev() As String
            Get
                Return Me.p_xnombrepaisabrev
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrepaisabrev = Value
            End Set
        End Property

        Public Property xcultura() As String
            Get
                Return Me.p_xcultura
            End Get
            Set(ByVal Value As String)
                Me.p_xcultura = Value
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
