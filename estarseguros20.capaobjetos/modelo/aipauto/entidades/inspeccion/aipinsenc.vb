Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.agenda

Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinsenc

        Private p_idaipinsenc As Decimal

        Private p_idaipactivperi As Decimal ''inicio nuevos
        Private p_idaipinsintext As Decimal
        Private p_itipoinsenc As String
        Private p_idaipinsmotiv As Decimal
        Private p_itipoperitinsenc As String
        Private p_iorigeninsenc As String
        Private p_idsegmanusuperit As Decimal
        Private p_idsegmanusuaudit As Decimal ''fin nuevos

        Private p_xcedpropinsenc As String
        Private p_xcedsidoinsenc As String
        Private p_xplacinsenc As String
        Private p_xsermotinsenc As String
        Private p_xsercarrinsenc As String
        Private p_xnumpolinsenc As String
        Private p_xnumsininsenc As String
        Private p_xllavinsenc As String
        Private p_xnomprodinsenc As String
        Private p_xnomprodtorinsenc As String
        Private p_xnomramopolizinsenc As String
        Private p_xnomsucinsinsenc As String
        Private p_xnuminspinsenc As String ''numero de inspeccion (nuevo por agregar en la base de datos)
        Private p_fcreainsenc As DateTime
        Private p_fprocinsenc As DateTime
        Private p_faudinsenc As DateTime
        Private p_fultrechinsenc As DateTime
        Private p_irechinsenc As Boolean
        Private p_xmotcrechinsenc As String
        Private p_fcancinsenc As DateTime
        Private p_facepinsenc As DateTime
        Private p_xdescinsenc As String
        Private p_icerrarinsenc As Boolean
        Private p_iestatinsenc As String
        Private p_idseglogreg As Decimal
        Private p_nanexoinsenc As Int16


        'relaciones
        Private p_aipactivperi As aipactivperi 'nuevo
        Private p_aipinsajusanex As List(Of aipinsajusanex)
        Private p_aipinsajussin As List(Of aipinsajussin)
        Private p_aipinsfoto As List(Of aipinsfoto)
        Private p_aipinslimsin As List(Of aipinslimsin)
        Private p_aipinslimsus As List(Of aipinslimsus)
        Private p_aipinsrest As List(Of aipinsrest)
        Private p_aipinssus As List(Of aipinssus)
        Private p_aipinssin As List(Of aipinssin)
        Private p_aipinsmotiv As aipinsmotiv
        Private p_aipinsarch As List(Of aipinsarch)




        Public Property idaipinsenc() As Decimal
            Get
                Return Me.p_idaipinsenc
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsenc = Value
            End Set
        End Property

        Public Property idaipactivperi() As Decimal
            Get
                Return Me.p_idaipactivperi
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipactivperi = Value
            End Set
        End Property

        Public Property idaipinsintext() As Decimal
            Get
                Return Me.p_idaipinsintext
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsintext = Value
            End Set
        End Property

        Public Property itipoinsenc() As String
            Get
                Return Me.p_itipoinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_itipoinsenc = Value
            End Set
        End Property

        Public Property idaipinsmotiv() As Decimal
            Get
                Return Me.p_idaipinsmotiv
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsmotiv = Value
            End Set
        End Property


        Public Property itipoperitinsenc() As String
            Get
                Return Me.p_itipoperitinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_itipoperitinsenc = Value
            End Set
        End Property

        Public Property iorigeninsenc() As String
            Get
                Return Me.p_iorigeninsenc
            End Get
            Set(ByVal Value As String)
                Me.p_iorigeninsenc = Value
            End Set
        End Property

        Public Property idsegmanusuperit() As Decimal
            Get
                Return Me.p_idsegmanusuperit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusuperit = Value
            End Set
        End Property

        Public Property idsegmanusuaudit() As Decimal
            Get
                Return Me.p_idsegmanusuaudit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusuaudit = Value
            End Set
        End Property

        Public Property xcedpropinsenc() As String
            Get
                Return Me.p_xcedpropinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xcedpropinsenc = Value
            End Set
        End Property

        Public Property xcedsidoinsenc() As String
            Get
                Return Me.p_xcedsidoinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xcedsidoinsenc = Value
            End Set
        End Property

        Public Property xplacinsenc() As String
            Get
                Return Me.p_xplacinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xplacinsenc = Value
            End Set
        End Property

        Public Property xsermotinsenc() As String
            Get
                Return Me.p_xsermotinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xsermotinsenc = Value
            End Set
        End Property

        Public Property xsercarrinsenc() As String
            Get
                Return Me.p_xsercarrinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xsercarrinsenc = Value
            End Set
        End Property

        Public Property xnumpolinsenc() As String
            Get
                Return Me.p_xnumpolinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnumpolinsenc = Value
            End Set
        End Property

        Public Property xnumsininsenc() As String
            Get
                Return Me.p_xnumsininsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnumsininsenc = Value
            End Set
        End Property

        Public Property xllavinsenc() As String
            Get
                Return Me.p_xllavinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xllavinsenc = Value
            End Set
        End Property


        Public Property xnomprodinsenc() As String
            Get
                Return Me.p_xnomprodinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomprodinsenc = Value
            End Set
        End Property

        Public Property xnomprodtorinsenc() As String
            Get
                Return Me.p_xnomprodtorinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomprodtorinsenc = Value
            End Set
        End Property

        Public Property xnomramopolizinsenc() As String
            Get
                Return Me.p_xnomramopolizinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomramopolizinsenc = Value
            End Set
        End Property

        Public Property xnomsucinsinsenc() As String
            Get
                Return Me.p_xnomsucinsinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnomsucinsinsenc = Value
            End Set
        End Property

        Public Property xnuminspinsenc() As String
            Get
                Return Me.p_xnuminspinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xnuminspinsenc = Value
            End Set
        End Property


        Public Property fcreainsenc() As DateTime
            Get
                Return Me.p_fcreainsenc
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcreainsenc = Value
            End Set
        End Property

        Public Property fprocinsenc() As DateTime
            Get
                Return Me.p_fprocinsenc
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fprocinsenc = Value
            End Set
        End Property

        Public Property faudinsenc() As DateTime
            Get
                Return Me.p_faudinsenc
            End Get
            Set(ByVal Value As DateTime)
                Me.p_faudinsenc = Value
            End Set
        End Property

        Public Property fultrechinsenc() As DateTime
            Get
                Return Me.p_fultrechinsenc
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fultrechinsenc = Value
            End Set
        End Property


        Public Property irechinsenc() As Boolean
            Get
                Return Me.p_irechinsenc
            End Get
            Set(ByVal Value As Boolean)
                Me.p_irechinsenc = Value
            End Set
        End Property

        Public Property xmotcrechinsenc() As String
            Get
                Return Me.p_xmotcrechinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xmotcrechinsenc = Value
            End Set
        End Property

        Public Property fcancinsenc() As DateTime
            Get
                Return Me.p_fcancinsenc
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcancinsenc = Value
            End Set
        End Property

        Public Property facepinsenc() As DateTime
            Get
                Return Me.p_facepinsenc
            End Get
            Set(ByVal Value As DateTime)
                Me.p_facepinsenc = Value
            End Set
        End Property

        Public Property xdescinsenc() As String
            Get
                Return Me.p_xdescinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinsenc = Value
            End Set
        End Property

        Public Property icerrarinsenc() As Boolean
            Get
                Return Me.p_icerrarinsenc
            End Get
            Set(ByVal Value As Boolean)
                Me.p_icerrarinsenc = Value
            End Set
        End Property



        Public Property iestatinsenc() As String
            Get
                Return Me.p_iestatinsenc
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinsenc = Value
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


        Public Property nanexoinsenc() As Int16
            Get
                Return Me.p_nanexoinsenc
            End Get
            Set(ByVal Value As Int16)
                Me.p_nanexoinsenc = Value
            End Set
        End Property

        'relaciones

        Public Property aipactivperi() As aipactivperi
            Get
                Return Me.p_aipactivperi
            End Get
            Set(ByVal Value As aipactivperi)
                Me.p_aipactivperi = Value
            End Set
        End Property


        Public Property aipinsajusanex() As List(Of aipinsajusanex)
            Get
                Return Me.p_aipinsajusanex
            End Get
            Set(ByVal Value As List(Of aipinsajusanex))
                Me.p_aipinsajusanex = Value
            End Set
        End Property

        Public Property aipinsajussin() As List(Of aipinsajussin)
            Get
                Return Me.p_aipinsajussin
            End Get
            Set(ByVal Value As List(Of aipinsajussin))
                Me.p_aipinsajussin = Value
            End Set
        End Property

        Public Property aipinsfoto() As List(Of aipinsfoto)
            Get
                Return Me.p_aipinsfoto
            End Get
            Set(ByVal Value As List(Of aipinsfoto))
                Me.p_aipinsfoto = Value
            End Set
        End Property

        Public Property aipinslimsin() As List(Of aipinslimsin)
            Get
                Return Me.p_aipinslimsin
            End Get
            Set(ByVal Value As List(Of aipinslimsin))
                Me.p_aipinslimsin = Value
            End Set
        End Property

        Public Property aipinslimsus() As List(Of aipinslimsus)
            Get
                Return Me.p_aipinslimsus
            End Get
            Set(ByVal Value As List(Of aipinslimsus))
                Me.p_aipinslimsus = Value
            End Set
        End Property

        Public Property aipinsrest() As List(Of aipinsrest)
            Get
                Return Me.p_aipinsrest
            End Get
            Set(ByVal Value As List(Of aipinsrest))
                Me.p_aipinsrest = Value
            End Set
        End Property

        Public Property aipinssin() As List(Of aipinssin)
            Get
                Return Me.p_aipinssin
            End Get
            Set(ByVal Value As List(Of aipinssin))
                Me.p_aipinssin = Value
            End Set
        End Property

        Public Property aipinssus() As List(Of aipinssus)
            Get
                Return Me.p_aipinssus
            End Get
            Set(ByVal Value As List(Of aipinssus))
                Me.p_aipinssus = Value
            End Set
        End Property

        Public Property aipinsmotiv() As aipinsmotiv
            Get
                Return Me.p_aipinsmotiv
            End Get
            Set(ByVal Value As aipinsmotiv)
                Me.p_aipinsmotiv = Value
            End Set
        End Property

        Public Property aipinsarch() As List(Of aipinsarch)
            Get
                Return Me.p_aipinsarch
            End Get
            Set(ByVal Value As List(Of aipinsarch))
                Me.p_aipinsarch = Value
            End Set
        End Property

    End Class

    Public Class petiaipinsencpaglist

        Private p_pagaipinsenc As paginacion
        Private p_aipinsenc As aipinsenc

        Public Property pagaipinsenc() As paginacion
            Get
                Return Me.p_pagaipinsenc
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinsenc = Value
            End Set
        End Property

        Public Property aipinsenc() As aipinsenc
            Get
                Return Me.p_aipinsenc
            End Get
            Set(ByVal Value As aipinsenc)
                Me.p_aipinsenc = Value
            End Set
        End Property
    End Class

    Public Class respaipinsencpaglist

        Private p_pagaipinsenc As paginacion
        Private p_lista_aipinsenc As List(Of aipinsenc)

        Public Property pagaipinsenc() As paginacion
            Get
                Return Me.p_pagaipinsenc
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinsenc = Value
            End Set
        End Property

        Public Property lista_aipinsenc() As List(Of aipinsenc)
            Get
                Return Me.p_lista_aipinsenc
            End Get
            Set(ByVal Value As List(Of aipinsenc))
                Me.p_lista_aipinsenc = Value
            End Set
        End Property
    End Class

End Namespace
