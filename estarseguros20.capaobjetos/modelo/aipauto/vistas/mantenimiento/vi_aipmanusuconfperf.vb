Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.mantenimiento

    Public Class vi_aipmanusuconfperf

        Private p_idaipmanusuconf As Decimal
        Private p_idsegmanusu As Decimal
        Private p_idcomunmanpers As Decimal
        Private p_idsegmanorg As Decimal
        Private p_idsegmandep As Decimal
        Private p_idsegmancarg As Decimal
        Private p_xnombreusuario As String
        Private p_idsegusuperf As Decimal
        Private p_idsegappperf As Decimal
        Private p_idsegmanperf As Decimal
        Private p_xabrevperf As String
        Private p_xnombreperf As String
        Private p_nnivelperf As Int32
        Private p_xnombredep As String
        Private p_xnombrecarg As String
        Private p_idsegmanapp As Decimal
        Private p_xnombrecorto As String
        Private p_xnombrelargo As String
        Private p_xcedula As String
        Private p_xnombrecompleto As String
        Private p_ibloqueado As Boolean
        Private p_finisusmanusuconf As DateTime
        Private p_ffinsusmanusuconf As DateTime
        Private p_iestatmanusuconf As String
        Private p_fcreamanusuconf As DateTime
        Private p_fmodmanusuconf As DateTime
        Private p_idseglogreg As Decimal


        Private p_check As Boolean

        Public Property idaipmanusuconf() As Decimal
            Get
                Return Me.p_idaipmanusuconf
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmanusuconf = Value
            End Set
        End Property

        Public Property idsegmanusu() As Decimal
            Get
                Return Me.p_idsegmanusu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusu = Value
            End Set
        End Property

        Public Property idcomunmanpers() As Decimal
            Get
                Return Me.p_idcomunmanpers
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpers = Value
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

        Public Property idsegmandep() As Decimal
            Get
                Return Me.p_idsegmandep
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmandep = Value
            End Set
        End Property

        Public Property idsegmancarg() As Decimal
            Get
                Return Me.p_idsegmancarg
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmancarg = Value
            End Set
        End Property

        Public Property xnombreusuario() As String
            Get
                Return Me.p_xnombreusuario
            End Get
            Set(ByVal Value As String)
                Me.p_xnombreusuario = Value
            End Set
        End Property

        Public Property idsegusuperf() As Decimal
            Get
                Return Me.p_idsegusuperf
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegusuperf = Value
            End Set
        End Property

        Public Property idsegappperf() As Decimal
            Get
                Return Me.p_idsegappperf
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegappperf = Value
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

        Public Property xnombredep() As String
            Get
                Return Me.p_xnombredep
            End Get
            Set(ByVal Value As String)
                Me.p_xnombredep = Value
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

        Public Property xnombrelargo() As String
            Get
                Return Me.p_xnombrelargo
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrelargo = Value
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

        Public Property xnombrecompleto() As String
            Get
                Return Me.p_xnombrecompleto
            End Get
            Set(ByVal Value As String)
                Me.p_xnombrecompleto = Value
            End Set
        End Property

        Public Property ibloqueado() As Boolean
            Get
                Return Me.p_ibloqueado
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ibloqueado = Value
            End Set
        End Property

        Public Property finisusmanusuconf() As DateTime
            Get
                Return Me.p_finisusmanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_finisusmanusuconf = Value
            End Set
        End Property

        Public Property ffinsusmanusuconf() As DateTime
            Get
                Return Me.p_ffinsusmanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_ffinsusmanusuconf = Value
            End Set
        End Property

        Public Property iestatmanusuconf() As String
            Get
                Return Me.p_iestatmanusuconf
            End Get
            Set(ByVal Value As String)
                Me.p_iestatmanusuconf = Value
            End Set
        End Property

        Public Property fcreamanusuconf() As DateTime
            Get
                Return Me.p_fcreamanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcreamanusuconf = Value
            End Set
        End Property

        Public Property fmodmanusuconf() As DateTime
            Get
                Return Me.p_fmodmanusuconf
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fmodmanusuconf = Value
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


        Public Property check() As Boolean
            Get
                Return Me.p_check
            End Get
            Set(ByVal Value As Boolean)
                Me.p_check = Value
            End Set
        End Property



    End Class

    Public Class petivi_aipmanusuconfperfpaglist

        Private p_pagvi_aipmanusuconfperf As paginacion
        Private p_vi_aipmanusuconfperf As vi_aipmanusuconfperf

        Public Property pagvi_aipmanusuconfperf() As paginacion
            Get
                Return Me.p_pagvi_aipmanusuconfperf
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipmanusuconfperf = Value
            End Set
        End Property

        Public Property vi_aipmanusuconfperf() As vi_aipmanusuconfperf
            Get
                Return Me.p_vi_aipmanusuconfperf
            End Get
            Set(ByVal Value As vi_aipmanusuconfperf)
                Me.p_vi_aipmanusuconfperf = Value
            End Set
        End Property
    End Class

    Public Class respvi_aipmanusuconfperfpaglist

        Private p_pagvi_aipmanusuconfperf As paginacion
        Private p_lista_vi_aipmanusuconfperf As List(Of vi_aipmanusuconfperf)

        Public Property pagvi_aipmanusuconfperf() As paginacion
            Get
                Return Me.p_pagvi_aipmanusuconfperf
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipmanusuconfperf = Value
            End Set
        End Property

        Public Property lista_vi_aipmanusuconfperf() As List(Of vi_aipmanusuconfperf)
            Get
                Return Me.p_lista_vi_aipmanusuconfperf
            End Get
            Set(ByVal Value As List(Of vi_aipmanusuconfperf))
                Me.p_lista_vi_aipmanusuconfperf = Value
            End Set
        End Property
    End Class

End Namespace
