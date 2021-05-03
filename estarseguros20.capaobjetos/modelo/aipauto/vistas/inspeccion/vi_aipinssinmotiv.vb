Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssinmotiv

		Private p_idaipinssinmotiv As Decimal
		Private p_idaipinssin As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipinsmotiv As Decimal
		Private p_xnominsmotiv As String
		Private p_itipoinsmotiv As String
		Private p_iestatinsmotiv As String
		Private p_itilinssinmotiv As Boolean
		Private p_idseglogreg As Decimal

		Public Property idaipinssinmotiv() As Decimal
			Get
				Return Me.p_idaipinssinmotiv
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssinmotiv = Value
			End Set
		End Property

		Public Property idaipinssin() As Decimal
			Get
				Return Me.p_idaipinssin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssin = Value
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

		Public Property itipoinsmotiv() As String
			Get
				Return Me.p_itipoinsmotiv
			End Get
			Set(ByVal Value As String)
				Me.p_itipoinsmotiv = Value
			End Set
		End Property

		Public Property iestatinsmotiv() As String
			Get
				Return Me.p_iestatinsmotiv
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsmotiv = Value
			End Set
		End Property

		Public Property itilinssinmotiv() As Boolean
			Get
				Return Me.p_itilinssinmotiv
			End Get
			Set(ByVal Value As Boolean)
				Me.p_itilinssinmotiv = Value
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
	
	Public Class petivi_aipinssinmotivpaglist

	Private p_pagvi_aipinssinmotiv As paginacion
	Private p_vi_aipinssinmotiv As vi_aipinssinmotiv

	Public Property pagvi_aipinssinmotiv() As paginacion
	Get
	Return Me.p_pagvi_aipinssinmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssinmotiv = Value
	End Set
	End Property

	Public Property vi_aipinssinmotiv() As vi_aipinssinmotiv
	Get
	Return Me.p_vi_aipinssinmotiv
	End Get
	Set(ByVal Value As vi_aipinssinmotiv)
	Me.p_vi_aipinssinmotiv = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssinmotivpaglist

	Private p_pagvi_aipinssinmotiv As paginacion
	Private p_lista_vi_aipinssinmotiv As  List(Of vi_aipinssinmotiv)

	Public Property pagvi_aipinssinmotiv() As paginacion
	Get
	Return Me.p_pagvi_aipinssinmotiv
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssinmotiv = Value
	End Set
	End Property

	Public Property lista_vi_aipinssinmotiv() As List(Of vi_aipinssinmotiv)
	Get
	Return Me.p_lista_vi_aipinssinmotiv
	End Get
	Set(ByVal Value As List(Of vi_aipinssinmotiv))
	Me.p_lista_vi_aipinssinmotiv = Value
	End Set
	End Property
	End Class

End Namespace
