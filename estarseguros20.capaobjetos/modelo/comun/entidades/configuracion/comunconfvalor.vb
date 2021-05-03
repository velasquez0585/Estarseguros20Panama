Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace comun.modelo.dbestarseguros20.entidades.configuracion

    Public Class comunconfvalor

        Private p_idcomunconfvalor As Decimal
        Private p_xconcepto As String
        Private p_xvalorcodigo As String
        Private p_xvalordescripcion As String
        Private p_istatusvalor As String
        Private p_idseglogreg As Decimal

        Public Property idcomunconfvalor() As Decimal
            Get
                Return Me.p_idcomunconfvalor
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunconfvalor = Value
            End Set
        End Property

        Public Property xconcepto() As String
            Get
                Return Me.p_xconcepto
            End Get
            Set(ByVal Value As String)
                Me.p_xconcepto = Value
            End Set
        End Property

        Public Property xvalorcodigo() As String
            Get
                Return Me.p_xvalorcodigo
            End Get
            Set(ByVal Value As String)
                Me.p_xvalorcodigo = Value
            End Set
        End Property

        Public Property xvalordescripcion() As String
            Get
                Return Me.p_xvalordescripcion
            End Get
            Set(ByVal Value As String)
                Me.p_xvalordescripcion = Value
            End Set
        End Property

        Public Property istatusvalor() As String
            Get
                Return Me.p_istatusvalor
            End Get
            Set(ByVal Value As String)
                Me.p_istatusvalor = Value
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
