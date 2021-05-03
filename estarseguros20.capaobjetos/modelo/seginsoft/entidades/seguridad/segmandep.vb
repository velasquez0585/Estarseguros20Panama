Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace seginsoft.modelo.dbestarseguros20.entidades.seguridad

    Public Class segmandep

        Private p_idsegmandep As Decimal
        Private p_xnombredep As String
        Private p_idseglogreg As Decimal

        Public Property idsegmandep() As Decimal
            Get
                Return Me.p_idsegmandep
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmandep = Value
            End Set
        End Property

        Public Property xnombredep() As String
            Get
                Return Me.p_xnombredep
            End Get
            Set(ByVal Value As String)
                Me.p_xnombredep = Value
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

    Public Class petisegmandeppaglist

        Private p_pagsegmandep As paginacion
        Private p_segmandep As segmandep

        Public Property pagsegmandep() As paginacion
            Get
                Return Me.p_pagsegmandep
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagsegmandep = Value
            End Set
        End Property

        Public Property segmandep() As segmandep
            Get
                Return Me.p_segmandep
            End Get
            Set(ByVal Value As segmandep)
                Me.p_segmandep = Value
            End Set
        End Property
    End Class

    Public Class respsegmandeppaglist

        Private p_pagsegmandep As paginacion
        Private p_lista_segmandep As List(Of segmandep)

        Public Property pagsegmandep() As paginacion
            Get
                Return Me.p_pagsegmandep
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagsegmandep = Value
            End Set
        End Property

        Public Property lista_segmandep() As List(Of segmandep)
            Get
                Return Me.p_lista_segmandep
            End Get
            Set(ByVal Value As List(Of segmandep))
                Me.p_lista_segmandep = Value
            End Set
        End Property
    End Class

End Namespace
