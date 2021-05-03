Imports estarseguros20.capaobjetos.modelo.personalizados

Namespace comun.modelo.dbestarseguros20.entidades.mantenimiento

    Public Class comunmanpers

        Private p_idcomunmanpers As Decimal
        Private p_xcedula As String
        Private p_xnombres As String
        Private p_xapellidos As String
        Private p_xnombrecompleto As String
        Private p_fnacimiento As DateTime
        Private p_xsexo As String
        Private p_xnacionalidad As String
        Private p_xestatura As String
        Private p_xmedestatura As String
        Private p_xpeso As String
        Private p_xmedpeso As String

        Public Property idcomunmanpers() As Decimal
            Get
                Return Me.p_idcomunmanpers
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpers = Value
            End Set
        End Property

        Public Property xcedula() As String
            Get
                Return Me.p_xcedula
            End Get
            Set(ByVal Value As String)
                Me.p_xcedula = Value
            End Set
        End Property

        Public Property xnombres() As String
            Get
                Return Me.p_xnombres
            End Get
            Set(ByVal Value As String)
                Me.p_xnombres = Value
            End Set
        End Property

        Public Property xapellidos() As String
            Get
                Return Me.p_xapellidos
            End Get
            Set(ByVal Value As String)
                Me.p_xapellidos = Value
            End Set
        End Property

        Public Property xnombrecompleto() As String
            Get
                Return Me.p_xnombrecompleto
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecompleto = Value
            End Set
        End Property

        Public Property fnacimiento() As DateTime
            Get
                Return Me.p_fnacimiento
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fnacimiento = Value
            End Set
        End Property

        Public Property xsexo() As String
            Get
                Return Me.p_xsexo
            End Get
            Set(ByVal Value As String)
                Me.p_xsexo = Value
            End Set
        End Property

        Public Property xnacionalidad() As String
            Get
                Return Me.p_xnacionalidad
            End Get
            Set(ByVal Value As String)
                Me.p_xnacionalidad = Value
            End Set
        End Property

        Public Property xestatura() As String
            Get
                Return Me.p_xestatura
            End Get
            Set(ByVal Value As String)
                Me.p_xestatura = Value
            End Set
        End Property

        Public Property xmedestatura() As String
            Get
                Return Me.p_xmedestatura
            End Get
            Set(ByVal Value As String)
                Me.p_xmedestatura = Value
            End Set
        End Property

        Public Property xpeso() As String
            Get
                Return Me.p_xpeso
            End Get
            Set(ByVal Value As String)
                Me.p_xpeso = Value
            End Set
        End Property

        Public Property xmedpeso() As String
            Get
                Return Me.p_xmedpeso
            End Get
            Set(ByVal Value As String)
                Me.p_xmedpeso = Value
            End Set
        End Property

    End Class
End Namespace
