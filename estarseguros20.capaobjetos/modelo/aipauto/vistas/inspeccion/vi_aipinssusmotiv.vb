Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssusmotiv

		Private p_idaipinssusmotiv As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipinsmotiv As Decimal
		Private p_xnominsmotiv As String
		Private p_itilinssusmotiv As Boolean
		Private p_idseglogreg As Decimal

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

		Public Property idaipinsenc() As Decimal
			Get
				Return Me.p_idaipinsenc
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsenc = Value
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

		Public Property xnominsmotiv() As String
			Get
				Return Me.p_xnominsmotiv
			End Get
			Set(ByVal Value As String)
				Me.p_xnominsmotiv = Value
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

	End Class
	
	Public Class petivi_aipinssusmotivpaglist

	Private p_pagvi_aipinssusmotiv As paginacion
	Private p_vi_aipinssusmotiv As vi_aipinssusmotiv

	Public Property pagvi_aipinssusmotiv() As paginacion
	Get
	Return Me.p_pagvi_aipinssusmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusmotiv = Value
	End Set
	End Property

	Public Property vi_aipinssusmotiv() As vi_aipinssusmotiv
	Get
	Return Me.p_vi_aipinssusmotiv
	End Get
	Set(ByVal Value As vi_aipinssusmotiv)
	Me.p_vi_aipinssusmotiv = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssusmotivpaglist

	Private p_pagvi_aipinssusmotiv As paginacion
	Private p_lista_vi_aipinssusmotiv As  List(Of vi_aipinssusmotiv)

	Public Property pagvi_aipinssusmotiv() As paginacion
	Get
	Return Me.p_pagvi_aipinssusmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusmotiv = Value
	End Set
	End Property

	Public Property lista_vi_aipinssusmotiv() As List(Of vi_aipinssusmotiv)
	Get
	Return Me.p_lista_vi_aipinssusmotiv
	End Get
	Set(ByVal Value As List(Of vi_aipinssusmotiv))
	Me.p_lista_vi_aipinssusmotiv = Value
	End Set
	End Property
	End Class

End Namespace
