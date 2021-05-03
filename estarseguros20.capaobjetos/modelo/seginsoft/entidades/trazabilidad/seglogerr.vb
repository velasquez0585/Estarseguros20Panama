Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace seginsoft.modelo.dbestarseguros20.entidades.trazabilidad

    Public Class seglogerr

        Private p_idseglogerr As Decimal
        Private p_xdatoslogerr As String
        Private p_flogerr As DateTime
        Private p_xexhelplink As String
        Private p_xexinnerexception As String
        Private p_xexmessage As String
        Private p_xexsource As String
        Private p_xextargetsite As String
        Private p_xexstacktrace As String
        Private p_idseglogreg As Decimal

        Public Property idseglogerr() As Decimal
            Get
                Return Me.p_idseglogerr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idseglogerr = Value
            End Set
        End Property

        Public Property xdatoslogerr() As String
            Get
                Return Me.p_xdatoslogerr
            End Get
            Set(ByVal Value As String)
                Me.p_xdatoslogerr = Value
            End Set
        End Property

        Public Property flogerr() As DateTime
            Get
                Return Me.p_flogerr
            End Get
            Set(ByVal Value As DateTime)
                Me.p_flogerr = Value
            End Set
        End Property

        Public Property xexhelplink() As String
            Get
                Return Me.p_xexhelplink
            End Get
            Set(ByVal Value As String)
                Me.p_xexhelplink = Value
            End Set
        End Property

        Public Property xexinnerexception() As String
            Get
                Return Me.p_xexinnerexception
            End Get
            Set(ByVal Value As String)
                Me.p_xexinnerexception = Value
            End Set
        End Property

        Public Property xexmessage() As String
            Get
                Return Me.p_xexmessage
            End Get
            Set(ByVal Value As String)
                Me.p_xexmessage = Value
            End Set
        End Property

        Public Property xexsource() As String
            Get
                Return Me.p_xexsource
            End Get
            Set(ByVal Value As String)
                Me.p_xexsource = Value
            End Set
        End Property

        Public Property xextargetsite() As String
            Get
                Return Me.p_xextargetsite
            End Get
            Set(ByVal Value As String)
                Me.p_xextargetsite = Value
            End Set
        End Property

        Public Property xexstacktrace() As String
            Get
                Return Me.p_xexstacktrace
            End Get
            Set(ByVal Value As String)
                Me.p_xexstacktrace = Value
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

    Public Class petiseglogerrpaglist

        Private p_pagseglogerr As paginacion
        Private p_seglogerr As seglogerr

        Public Property pagseglogerr() As paginacion
            Get
                Return Me.p_pagseglogerr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagseglogerr = Value
            End Set
        End Property

        Public Property seglogerr() As seglogerr
            Get
                Return Me.p_seglogerr
            End Get
            Set(ByVal Value As seglogerr)
                Me.p_seglogerr = Value
            End Set
        End Property
    End Class

    Public Class respseglogerrpaglist

        Private p_pagseglogerr As paginacion
        Private p_lista_seglogerr As List(Of seglogerr)

        Public Property pagseglogerr() As paginacion
            Get
                Return Me.p_pagseglogerr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagseglogerr = Value
            End Set
        End Property

        Public Property lista_seglogerr() As List(Of seglogerr)
            Get
                Return Me.p_lista_seglogerr
            End Get
            Set(ByVal Value As List(Of seglogerr))
                Me.p_lista_seglogerr = Value
            End Set
        End Property
    End Class

End Namespace
