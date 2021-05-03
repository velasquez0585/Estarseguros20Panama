Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion

Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

    Public Class aipmaninfcomp

        Private p_idaipmaninfcomp As Decimal
        Private p_xnommaninfcomp As String
        Private p_nordenmaninfcomp As Short
        Private p_xdescmaninfcomp As String
        Private p_iestatmaninfcomp As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssusinfcomp As List(Of aipinssusinfcomp)

        Public Property idaipmaninfcomp() As Decimal
            Get
                Return Me.p_idaipmaninfcomp
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmaninfcomp = Value
            End Set
        End Property

        Public Property xnommaninfcomp() As String
            Get
                Return Me.p_xnommaninfcomp
            End Get
            Set(ByVal Value As String)
                Me.p_xnommaninfcomp = Value
            End Set
        End Property

        Public Property nordenmaninfcomp() As Short
            Get
                Return Me.p_nordenmaninfcomp
            End Get
            Set(ByVal Value As Short)
                Me.p_nordenmaninfcomp = Value
            End Set
        End Property

        Public Property xdescmaninfcomp() As String
            Get
                Return Me.p_xdescmaninfcomp
            End Get
            Set(ByVal Value As String)
                Me.p_xdescmaninfcomp = Value
            End Set
        End Property

        Public Property iestatmaninfcomp() As String
            Get
                Return Me.p_iestatmaninfcomp
            End Get
            Set(ByVal Value As String)
                Me.p_iestatmaninfcomp = Value
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


        'relaciones
        Public Property aipinssusinfcomp() As List(Of aipinssusinfcomp)
            Get
                Return Me.p_aipinssusinfcomp
            End Get
            Set(ByVal Value As List(Of aipinssusinfcomp))
                Me.p_aipinssusinfcomp = Value
            End Set
        End Property


    End Class

    Public Class petiaipmaninfcomppaglist

        Private p_pagaipmaninfcomp As paginacion
        Private p_aipmaninfcomp As aipmaninfcomp

        Public Property pagaipmaninfcomp() As paginacion
            Get
                Return Me.p_pagaipmaninfcomp
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipmaninfcomp = Value
            End Set
        End Property

        Public Property aipmaninfcomp() As aipmaninfcomp
            Get
                Return Me.p_aipmaninfcomp
            End Get
            Set(ByVal Value As aipmaninfcomp)
                Me.p_aipmaninfcomp = Value
            End Set
        End Property
    End Class

    Public Class respaipmaninfcomppaglist

        Private p_pagaipmaninfcomp As paginacion
        Private p_lista_aipmaninfcomp As List(Of aipmaninfcomp)

        Public Property pagaipmaninfcomp() As paginacion
            Get
                Return Me.p_pagaipmaninfcomp
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipmaninfcomp = Value
            End Set
        End Property

        Public Property lista_aipmaninfcomp() As List(Of aipmaninfcomp)
            Get
                Return Me.p_lista_aipmaninfcomp
            End Get
            Set(ByVal Value As List(Of aipmaninfcomp))
                Me.p_lista_aipmaninfcomp = Value
            End Set
        End Property
    End Class

End Namespace
