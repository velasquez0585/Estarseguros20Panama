Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.mantenimiento

	Public Class vi_aipmanvehmod

		Private p_idaipmanvehmod As Decimal
		Private p_idaipmanvehmar As Decimal
		Private p_xnommanvehmar As String
		Private p_xnommanvehmod As String
		Private p_xdescmanvehmod As String
		Private p_iestatmanvehmod As String
		Private p_iestatmanvehmar As String

		Public Property idaipmanvehmod() As Decimal
			Get
				Return Me.p_idaipmanvehmod
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmod = Value
			End Set
		End Property

		Public Property idaipmanvehmar() As Decimal
			Get
				Return Me.p_idaipmanvehmar
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmar = Value
			End Set
		End Property

		Public Property xnommanvehmar() As String
			Get
				Return Me.p_xnommanvehmar
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmar = Value
			End Set
		End Property

		Public Property xnommanvehmod() As String
			Get
				Return Me.p_xnommanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmod = Value
			End Set
		End Property

		Public Property xdescmanvehmod() As String
			Get
				Return Me.p_xdescmanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehmod = Value
			End Set
		End Property

		Public Property iestatmanvehmod() As String
			Get
				Return Me.p_iestatmanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehmod = Value
			End Set
		End Property

		Public Property iestatmanvehmar() As String
			Get
				Return Me.p_iestatmanvehmar
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehmar = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipmanvehmodpaglist

	Private p_pagvi_aipmanvehmod As paginacion
	Private p_vi_aipmanvehmod As vi_aipmanvehmod

	Public Property pagvi_aipmanvehmod() As paginacion
	Get
	Return Me.p_pagvi_aipmanvehmod
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanvehmod = Value
	End Set
	End Property

	Public Property vi_aipmanvehmod() As vi_aipmanvehmod
	Get
	Return Me.p_vi_aipmanvehmod
	End Get
	Set(ByVal Value As vi_aipmanvehmod)
	Me.p_vi_aipmanvehmod = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipmanvehmodpaglist

	Private p_pagvi_aipmanvehmod As paginacion
	Private p_lista_vi_aipmanvehmod As  List(Of vi_aipmanvehmod)

	Public Property pagvi_aipmanvehmod() As paginacion
	Get
	Return Me.p_pagvi_aipmanvehmod
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanvehmod = Value
	End Set
	End Property

	Public Property lista_vi_aipmanvehmod() As List(Of vi_aipmanvehmod)
	Get
	Return Me.p_lista_vi_aipmanvehmod
	End Get
	Set(ByVal Value As List(Of vi_aipmanvehmod))
	Me.p_lista_vi_aipmanvehmod = Value
	End Set
	End Property
	End Class

End Namespace
