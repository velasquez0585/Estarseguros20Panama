Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace seginsoft.modelo.dbestarseguros20.vistas.seguridad

    Public Class vi_segappperf

        Private p_idsegappperf As Decimal
        Private p_idsegmanapp As Decimal
        Private p_xnombrecorto As String
        Private p_idsegmanperf As Decimal
        Private p_xabrevperf As String
        Private p_xnombreperf As String
        Private p_nnivelperf As Int32
        Private p_idseglogreg As Decimal

        Public Property idsegappperf() As Decimal
            Get
                Return Me.p_idsegappperf
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegappperf = Value
            End Set
        End Property

        Public Property idsegmanapp() As Decimal
            Get
                Return Me.p_idsegmanapp
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanapp = Value
            End Set
        End Property

        Public Property xnombrecorto() As String
            Get
                Return Me.p_xnombrecorto
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecorto = Value
            End Set
        End Property

        Public Property idsegmanperf() As Decimal
            Get
                Return Me.p_idsegmanperf
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanperf = Value
            End Set
        End Property

        Public Property xabrevperf() As String
            Get
                Return Me.p_xabrevperf
            End Get
            Set(ByVal Value As String)
                Me.p_xabrevperf = Value
            End Set
        End Property

        Public Property xnombreperf() As String
            Get
                Return Me.p_xnombreperf
            End Get
            Set(ByVal Value As String)
                Me.p_xnombreperf = Value
            End Set
        End Property

        Public Property nnivelperf() As Int32
            Get
                Return Me.p_nnivelperf
            End Get
            Set(ByVal Value As Int32)
                Me.p_nnivelperf = Value
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

    Public Class petivi_segappperfpaglist

        Private p_pagvi_segappperf As paginacion
        Private p_vi_segappperf As vi_segappperf

        Public Property pagvi_segappperf() As paginacion
            Get
                Return Me.p_pagvi_segappperf
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_segappperf = Value
            End Set
        End Property

        Public Property vi_segappperf() As vi_segappperf
            Get
                Return Me.p_vi_segappperf
            End Get
            Set(ByVal Value As vi_segappperf)
                Me.p_vi_segappperf = Value
            End Set
        End Property
    End Class

    Public Class respvi_segappperfpaglist

        Private p_pagvi_segappperf As paginacion
        Private p_lista_vi_segappperf As List(Of vi_segappperf)

        Public Property pagvi_segappperf() As paginacion
            Get
                Return Me.p_pagvi_segappperf
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_segappperf = Value
            End Set
        End Property

        Public Property lista_vi_segappperf() As List(Of vi_segappperf)
            Get
                Return Me.p_lista_vi_segappperf
            End Get
            Set(ByVal Value As List(Of vi_segappperf))
                Me.p_lista_vi_segappperf = Value
            End Set
        End Property
    End Class

End Namespace
