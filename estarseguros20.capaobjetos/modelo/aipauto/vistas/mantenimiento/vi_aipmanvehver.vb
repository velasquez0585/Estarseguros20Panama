Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.mantenimiento

	Public Class vi_aipmanvehver

		Private p_idaipmanvehver As Decimal
		Private p_idaipmanvehmar As Decimal
		Private p_xnommanvehmar As String
		Private p_idaipmanvehmod As Decimal
		Private p_xnommanvehmod As String
		Private p_xnommanvehver As String
		Private p_naniomanvehver As Int16
		Private p_xdescmanvehver As String
		Private p_iestatmanvehmar As String
		Private p_iestatmanvehmod As String
		Private p_iestatmanvehver As String

		Public Property idaipmanvehver() As Decimal
			Get
				Return Me.p_idaipmanvehver
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehver = Value
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

		Public Property idaipmanvehmod() As Decimal
			Get
				Return Me.p_idaipmanvehmod
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmod = Value
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

		Public Property xnommanvehver() As String
			Get
				Return Me.p_xnommanvehver
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehver = Value
			End Set
		End Property

		Public Property naniomanvehver() As Int16
			Get
				Return Me.p_naniomanvehver
			End Get
			Set(ByVal Value As Int16)
				Me.p_naniomanvehver = Value
			End Set
		End Property

		Public Property xdescmanvehver() As String
			Get
				Return Me.p_xdescmanvehver
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehver = Value
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

		Public Property iestatmanvehmod() As String
			Get
				Return Me.p_iestatmanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehmod = Value
			End Set
		End Property

		Public Property iestatmanvehver() As String
			Get
				Return Me.p_iestatmanvehver
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehver = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipmanvehverpaglist

	Private p_pagvi_aipmanvehver As paginacion
	Private p_vi_aipmanvehver As vi_aipmanvehver

	Public Property pagvi_aipmanvehver() As paginacion
	Get
	Return Me.p_pagvi_aipmanvehver
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanvehver = Value
	End Set
	End Property

	Public Property vi_aipmanvehver() As vi_aipmanvehver
	Get
	Return Me.p_vi_aipmanvehver
	End Get
	Set(ByVal Value As vi_aipmanvehver)
	Me.p_vi_aipmanvehver = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipmanvehverpaglist

	Private p_pagvi_aipmanvehver As paginacion
	Private p_lista_vi_aipmanvehver As  List(Of vi_aipmanvehver)

	Public Property pagvi_aipmanvehver() As paginacion
	Get
	Return Me.p_pagvi_aipmanvehver
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanvehver = Value
	End Set
	End Property

	Public Property lista_vi_aipmanvehver() As List(Of vi_aipmanvehver)
	Get
	Return Me.p_lista_vi_aipmanvehver
	End Get
	Set(ByVal Value As List(Of vi_aipmanvehver))
	Me.p_lista_vi_aipmanvehver = Value
	End Set
	End Property
	End Class

End Namespace
