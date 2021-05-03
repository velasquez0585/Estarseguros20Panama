Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinssusmotiv

        Private p_idaipinssusmotiv As Decimal
        Private p_idaipinssus As Decimal
        Private p_idaipinsmotiv As Decimal
        Private p_itilinssusmotiv As Boolean
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssus As aipinssus
        Private p_aipinsmotiv As aipinsmotiv


        Public Property idaipinssusmotiv() As Decimal
            Get
                Return Me.p_idaipinssusmotiv
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssusmotiv = Value
            End Set
        End Property

        Public Property idaipinssus() As Decimal
            Get
                Return Me.p_idaipinssus
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssus = Value
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

        Public Property itilinssusmotiv() As Boolean
            Get
                Return Me.p_itilinssusmotiv
            End Get
            Set(ByVal Value As Boolean)
                Me.p_itilinssusmotiv = Value
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
        Public Property aipinssus() As aipinssus
            Get
                Return Me.p_aipinssus
            End Get
            Set(ByVal Value As aipinssus)
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


	End Class
	
	Public Class petiaipinssusmotivpaglist

	Private p_pagaipinssusmotiv As paginacion
	Private p_aipinssusmotiv As aipinssusmotiv

	Public Property pagaipinssusmotiv() As paginacion
	Get
	Return Me.p_pagaipinssusmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusmotiv = Value
	End Set
	End Property

	Public Property aipinssusmotiv() As aipinssusmotiv
	Get
	Return Me.p_aipinssusmotiv
	End Get
	Set(ByVal Value As aipinssusmotiv)
	Me.p_aipinssusmotiv = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinssusmotivpaglist

	Private p_pagaipinssusmotiv As paginacion
	Private p_lista_aipinssusmotiv As  List(Of aipinssusmotiv)

	Public Property pagaipinssusmotiv() As paginacion
	Get
	Return Me.p_pagaipinssusmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinssusmotiv = Value
	End Set
	End Property

	Public Property lista_aipinssusmotiv() As List(Of aipinssusmotiv)
	Get
	Return Me.p_lista_aipinssusmotiv
	End Get
	Set(ByVal Value As List(Of aipinssusmotiv))
	Me.p_lista_aipinssusmotiv = Value
	End Set
	End Property
	End Class

End Namespace
