Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace comun.modelo.dbestarseguros20.entidades.mantenimiento

    Public Class comunmancont

        Private p_idcomunmancont As Decimal
        Private p_xnombrecont As String
        Private p_xlatitud As String
        Private p_xlongitud As String
        Private p_idseglogreg As Decimal

        Public Property idcomunmancont() As Decimal
            Get
                Return Me.p_idcomunmancont
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmancont = Value
            End Set
        End Property

        Public Property xnombrecont() As String
            Get
                Return Me.p_xnombrecont
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecont = Value
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
