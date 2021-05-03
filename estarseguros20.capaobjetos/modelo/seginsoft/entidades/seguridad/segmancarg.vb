Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace seginsoft.modelo.dbestarseguros20.entidades.seguridad

    Public Class segmancarg

        Private p_idsegmancarg As Decimal
        Private p_xnombrecarg As String
        Private p_nprioridad As Int16
        Private p_idseglogreg As Decimal

        Public Property idsegmancarg() As Decimal
            Get
                Return Me.p_idsegmancarg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmancarg = Value
            End Set
        End Property

        Public Property xnombrecarg() As String
            Get
                Return Me.p_xnombrecarg
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecarg = Value
            End Set
        End Property

        Public Property nprioridad() As Int16
            Get
                Return Me.p_nprioridad
            End Get
            Set(ByVal Value As Int16)
                Me.p_nprioridad = Value
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

    Public Class petisegmancargpaglist

        Private p_pagsegmancarg As paginacion
        Private p_segmancarg As segmancarg

        Public Property pagsegmancarg() As paginacion
            Get
                Return Me.p_pagsegmancarg
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagsegmancarg = Value
            End Set
        End Property

        Public Property segmancarg() As segmancarg
            Get
                Return Me.p_segmancarg
            End Get
            Set(ByVal Value As segmancarg)
                Me.p_segmancarg = Value
            End Set
        End Property
    End Class

    Public Class respsegmancargpaglist

        Private p_pagsegmancarg As paginacion
        Private p_lista_segmancarg As List(Of segmancarg)

        Public Property pagsegmancarg() As paginacion
            Get
                Return Me.p_pagsegmancarg
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagsegmancarg = Value
            End Set
        End Property

        Public Property lista_segmancarg() As List(Of segmancarg)
            Get
                Return Me.p_lista_segmancarg
            End Get
            Set(ByVal Value As List(Of segmancarg))
                Me.p_lista_segmancarg = Value
            End Set
        End Property
    End Class

End Namespace
