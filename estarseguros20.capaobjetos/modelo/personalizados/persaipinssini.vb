Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

    Public Class persaipinssini

        Private p_idsegmanorg As Decimal
        Private p_idsegmanusuperit As Decimal
        Private p_idcomunmanestado As Decimal
        Private p_idcomunmanlocalid As Decimal
        Private p_itipoinsinssini As String
        Private p_xnacioninssini As String
        Private p_xcedpropinssini As String
        Private p_finicioinssini As DateTime
        Private p_itipoinssini As String
        Private p_xplacainssini As String
        Private p_ffininssini As DateTime
        Private p_icausainssini As String
        Private p_focurrinssini As DateTime
        Private p_fdeclarinssini As DateTime
        Private p_fnotifinssini As DateTime
        Private p_xnuminssini As String
        Private p_xdireccioninssini As String
        Private p_xdescinssini As String


        'campos que no estan en la tabla de base de datos
        Private p_check As Boolean



        Public Property idsegmanorg() As Decimal
            Get
                Return Me.p_idsegmanorg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorg = Value
            End Set
        End Property


        Public Property idsegmanusuperit() As Decimal
            Get
                Return Me.p_idsegmanusuperit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusuperit = Value
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

        Public Property idcomunmanlocalid() As Decimal
            Get
                Return Me.p_idcomunmanlocalid
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanlocalid = Value
            End Set
        End Property

        Public Property itipoinsinssini() As String
            Get
                Return Me.p_itipoinsinssini
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinsinssini = Value
            End Set
        End Property

        Public Property xnacioninssini() As String
            Get
                Return Me.p_xnacioninssini
            End Get
            Set(ByVal Value As String)
                Me.p_xnacioninssini = Value
            End Set
        End Property


        Public Property xcedpropinssini() As String
            Get
                Return Me.p_xcedpropinssini
            End Get
            Set(ByVal Value As String)
                Me.p_xcedpropinssini = Value
            End Set
        End Property

        Public Property finicioinssini() As DateTime
            Get
                Return Me.p_finicioinssini
            End Get
            Set(ByVal Value As DateTime)
                Me.p_finicioinssini = Value
            End Set
        End Property

        Public Property itipoinssini() As String
            Get
                Return Me.p_itipoinssini
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinssini = Value
            End Set
        End Property

        Public Property xplacainssini() As String
            Get
                Return Me.p_xplacainssini
            End Get
            Set(ByVal Value As String)
                Me.p_xplacainssini = Value
            End Set
        End Property

        Public Property ffininssini() As DateTime
            Get
                Return Me.p_ffininssini
            End Get
            Set(ByVal Value As DateTime)
                Me.p_ffininssini = Value
            End Set
        End Property

        Public Property icausainssini() As String
            Get
                Return Me.p_icausainssini
            End Get
            Set(ByVal Value As String)
                Me.p_icausainssini = Value
            End Set
        End Property

        Public Property focurrinssini() As DateTime
            Get
                Return Me.p_focurrinssini
            End Get
            Set(ByVal Value As DateTime)
                Me.p_focurrinssini = Value
            End Set
        End Property

        Public Property fdeclarinssini() As DateTime
            Get
                Return Me.p_fdeclarinssini
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fdeclarinssini = Value
            End Set
        End Property

        Public Property fnotifinssini() As DateTime
            Get
                Return Me.p_fnotifinssini
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fnotifinssini = Value
            End Set
        End Property

        Public Property xnuminssini() As String
            Get
                Return Me.p_xnuminssini
            End Get
            Set(ByVal Value As String)
                Me.p_xnuminssini = Value
            End Set
        End Property

        Public Property xdireccioninssini() As String
            Get
                Return Me.p_xdireccioninssini
            End Get
            Set(ByVal Value As String)
                Me.p_xdireccioninssini = Value
            End Set
        End Property

        Public Property xdescinssini() As String
            Get
                Return Me.p_xdescinssini
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinssini = Value
            End Set
        End Property

    End Class


End Namespace
