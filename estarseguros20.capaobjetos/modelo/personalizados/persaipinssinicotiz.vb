Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

    Public Class persaipinssinicotiz

        Private p_idsegmanorg As Decimal
        Private p_idsegmanusuperit As Decimal
        Private p_idcomunmanestado As Decimal
        Private p_idcomunmanlocalid As Decimal
        Private p_itipoinsinssinicotiz As String
        Private p_xnacioninssinicotiz As String
        Private p_xcedpropinssinicotiz As String
        Private p_finicioinssinicotiz As DateTime
        Private p_itipoinssinicotiz As String
        Private p_xplacainssinicotiz As String
        Private p_ffininssinicotiz As DateTime
        Private p_icausainssinicotiz As String
        Private p_focurrinssinicotiz As DateTime
        Private p_fdeclarinssinicotiz As DateTime
        Private p_fnotifinssinicotiz As DateTime
        Private p_xnuminssinicotiz As String
        Private p_xdireccioninssinicotiz As String
        Private p_xdescinssinicotiz As String


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

        Public Property itipoinsinssinicotiz() As String
            Get
                Return Me.p_itipoinsinssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinsinssinicotiz = Value
            End Set
        End Property

        Public Property xnacioninssinicotiz() As String
            Get
                Return Me.p_xnacioninssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_xnacioninssinicotiz = Value
            End Set
        End Property


        Public Property xcedpropinssinicotiz() As String
            Get
                Return Me.p_xcedpropinssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_xcedpropinssinicotiz = Value
            End Set
        End Property

        Public Property finicioinssinicotiz() As DateTime
            Get
                Return Me.p_finicioinssinicotiz
            End Get
            Set(ByVal Value As DateTime)
                Me.p_finicioinssinicotiz = Value
            End Set
        End Property

        Public Property itipoinssinicotiz() As String
            Get
                Return Me.p_itipoinssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinssinicotiz = Value
            End Set
        End Property

        Public Property xplacainssinicotiz() As String
            Get
                Return Me.p_xplacainssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_xplacainssinicotiz = Value
            End Set
        End Property

        Public Property ffininssinicotiz() As DateTime
            Get
                Return Me.p_ffininssinicotiz
            End Get
            Set(ByVal Value As DateTime)
                Me.p_ffininssinicotiz = Value
            End Set
        End Property

        Public Property icausainssinicotiz() As String
            Get
                Return Me.p_icausainssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_icausainssinicotiz = Value
            End Set
        End Property

        Public Property focurrinssinicotiz() As DateTime
            Get
                Return Me.p_focurrinssinicotiz
            End Get
            Set(ByVal Value As DateTime)
                Me.p_focurrinssinicotiz = Value
            End Set
        End Property

        Public Property fdeclarinssinicotiz() As DateTime
            Get
                Return Me.p_fdeclarinssinicotiz
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fdeclarinssinicotiz = Value
            End Set
        End Property

        Public Property fnotifinssinicotiz() As DateTime
            Get
                Return Me.p_fnotifinssinicotiz
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fnotifinssinicotiz = Value
            End Set
        End Property

        Public Property xnuminssinicotiz() As String
            Get
                Return Me.p_xnuminssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_xnuminssinicotiz = Value
            End Set
        End Property

        Public Property xdireccioninssinicotiz() As String
            Get
                Return Me.p_xdireccioninssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_xdireccioninssinicotiz = Value
            End Set
        End Property

        Public Property xdescinssinicotiz() As String
            Get
                Return Me.p_xdescinssinicotiz
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinssinicotiz = Value
            End Set
        End Property

    End Class


End Namespace
