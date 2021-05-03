Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

    'esta vista se creo basado en la tabla de estar seguros SINT_AGENDA para poder utilizarla sin problemas
    Public Class vi_aipextsintagenda

        Private p_idrow As Decimal
        Private p_idsegmanorg As Decimal
        Private p_idaipextseucur As Decimal
        Private p_xnomusuextsintagenda As String
        Private p_fmovextsintagenda As DateTime
        Private p_nnumsiniextsintagenda As Int32
        Private p_fmovhorextsintagenda As DateTime
        Private p_xdescripextsintagenda As String

        Public Property idrow() As Decimal
            Get
                Return Me.p_idrow
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idrow = Value
            End Set
        End Property

        Public Property idsegmanorg() As Decimal
            Get
                Return Me.p_idsegmanorg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorg = Value
            End Set
        End Property

        Public Property idaipextseucur() As Decimal
            Get
                Return Me.p_idaipextseucur
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipextseucur = Value
            End Set
        End Property

        Public Property xnomusuextsintagenda() As String
            Get
                Return Me.p_xnomusuextsintagenda
            End Get
            Set(ByVal Value As String)
                Me.p_xnomusuextsintagenda = Value
            End Set
        End Property

        Public Property fmovextsintagenda() As DateTime
            Get
                Return Me.p_fmovextsintagenda
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fmovextsintagenda = Value
            End Set
        End Property

        Public Property nnumsiniextsintagenda() As Int32
            Get
                Return Me.p_nnumsiniextsintagenda
            End Get
            Set(ByVal Value As Int32)
                Me.p_nnumsiniextsintagenda = Value
            End Set
        End Property

        Public Property fmovhorextsintagenda() As DateTime
            Get
                Return Me.p_fmovhorextsintagenda
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fmovhorextsintagenda = Value
            End Set
        End Property

        Public Property xdescripextsintagenda() As String
            Get
                Return Me.p_xdescripextsintagenda
            End Get
            Set(ByVal Value As String)
                Me.p_xdescripextsintagenda = Value
            End Set
        End Property
    End Class

    Public Class petivi_aipextsintagendapaglist

        Private p_pagvi_aipextsintagenda As paginacion
        Private p_vi_aipextsintagenda As vi_aipextsintagenda

        Public Property pagvi_aipextsintagenda() As paginacion
            Get
                Return Me.p_pagvi_aipextsintagenda
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipextsintagenda = Value
            End Set
        End Property

        Public Property vi_aipextsintagenda() As vi_aipextsintagenda
            Get
                Return Me.p_vi_aipextsintagenda
            End Get
            Set(ByVal Value As vi_aipextsintagenda)
                Me.p_vi_aipextsintagenda = Value
            End Set
        End Property
    End Class

    Public Class respvi_aipextsintagendapaglist

        Private p_pagvi_aipextsintagenda As paginacion
        Private p_lista_vi_aipextsintagenda As List(Of vi_aipextsintagenda)

        Public Property pagvi_aipextsintagenda() As paginacion
            Get
                Return Me.p_pagvi_aipextsintagenda
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipextsintagenda = Value
            End Set
        End Property

        Public Property lista_vi_aipextsintagenda() As List(Of vi_aipextsintagenda)
            Get
                Return Me.p_lista_vi_aipextsintagenda
            End Get
            Set(ByVal Value As List(Of vi_aipextsintagenda))
                Me.p_lista_vi_aipextsintagenda = Value
            End Set
        End Property
    End Class

End Namespace
