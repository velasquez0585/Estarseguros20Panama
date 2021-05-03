Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace seginsoft.modelo.dbestarseguros20.vistas.seguridad

    Public Class vi_combosegmanorg

        Private p_idsegmanorg As Decimal
        Private p_idcomunmanempr As Decimal
        Private p_xrazonsocial As String
        Private p_xnombrecomercial As String

        Public Property idsegmanorg() As Decimal
            Get
                Return Me.p_idsegmanorg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanorg = Value
            End Set
        End Property

        Public Property idcomunmanempr() As Decimal
            Get
                Return Me.p_idcomunmanempr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanempr = Value
            End Set
        End Property


        Public Property xrazonsocial() As String
            Get
                Return Me.p_xrazonsocial
            End Get
            Set(ByVal Value As String)
                Me.p_xrazonsocial = Value
            End Set
        End Property

        Public Property xnombrecomercial() As String
            Get
                Return Me.p_xnombrecomercial
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecomercial = Value
            End Set
        End Property

    End Class

    Public Class petivi_combosegmanorgpaglist

        Private p_pagvi_combosegmanorg As paginacion
        Private p_vi_combosegmanorg As vi_combosegmanorg

        Public Property pagvi_combosegmanorg() As paginacion
            Get
                Return Me.p_pagvi_combosegmanorg
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_combosegmanorg = Value
            End Set
        End Property

        Public Property vi_combosegmanorg() As vi_combosegmanorg
            Get
                Return Me.p_vi_combosegmanorg
            End Get
            Set(ByVal Value As vi_combosegmanorg)
                Me.p_vi_combosegmanorg = Value
            End Set
        End Property
    End Class

    Public Class respvi_segmanorgpaglist

        Private p_pagvi_combosegmanorg As paginacion
        Private p_lista_vi_combosegmanorg As List(Of vi_combosegmanorg)

        Public Property pagvi_segmanorg() As paginacion
            Get
                Return Me.p_pagvi_combosegmanorg
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_combosegmanorg = Value
            End Set
        End Property

        Public Property lista_vi_combosegmanorg() As List(Of vi_combosegmanorg)
            Get
                Return Me.p_lista_vi_combosegmanorg
            End Get
            Set(ByVal Value As List(Of vi_combosegmanorg))
                Me.p_lista_vi_combosegmanorg = Value
            End Set
        End Property
    End Class

End Namespace
