Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.baremo

	Public Class vi_aipbaremobr

		Private p_idaipbaremobr As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_faplibaremobr As DateTime
		Private p_itipobaremobr As String
		Private p_itamapiezbaremobr As String
		Private p_imaterpiezbaremobr As String
		Private p_mcostbaremobr As Decimal
		Private p_xdescbaremobr As String

		Public Property idaipbaremobr() As Decimal
			Get
				Return Me.p_idaipbaremobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipbaremobr = Value
			End Set
		End Property

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
			End Set
		End Property

		Public Property xnommanrepu() As String
			Get
				Return Me.p_xnommanrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanrepu = Value
			End Set
		End Property

		Public Property faplibaremobr() As DateTime
			Get
				Return Me.p_faplibaremobr
			End Get
			Set(ByVal Value As DateTime)
				Me.p_faplibaremobr = Value
			End Set
		End Property

		Public Property itipobaremobr() As String
			Get
				Return Me.p_itipobaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_itipobaremobr = Value
			End Set
		End Property

		Public Property itamapiezbaremobr() As String
			Get
				Return Me.p_itamapiezbaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_itamapiezbaremobr = Value
			End Set
		End Property

		Public Property imaterpiezbaremobr() As String
			Get
				Return Me.p_imaterpiezbaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_imaterpiezbaremobr = Value
			End Set
		End Property

		Public Property mcostbaremobr() As Decimal
			Get
				Return Me.p_mcostbaremobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mcostbaremobr = Value
			End Set
		End Property

		Public Property xdescbaremobr() As String
			Get
				Return Me.p_xdescbaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescbaremobr = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipbaremobrpaglist

	Private p_pagvi_aipbaremobr As paginacion
	Private p_vi_aipbaremobr As vi_aipbaremobr

	Public Property pagvi_aipbaremobr() As paginacion
	Get
	Return Me.p_pagvi_aipbaremobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipbaremobr = Value
	End Set
	End Property

	Public Property vi_aipbaremobr() As vi_aipbaremobr
	Get
	Return Me.p_vi_aipbaremobr
	End Get
	Set(ByVal Value As vi_aipbaremobr)
	Me.p_vi_aipbaremobr = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipbaremobrpaglist

	Private p_pagvi_aipbaremobr As paginacion
	Private p_lista_vi_aipbaremobr As  List(Of vi_aipbaremobr)

	Public Property pagvi_aipbaremobr() As paginacion
	Get
	Return Me.p_pagvi_aipbaremobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipbaremobr = Value
	End Set
	End Property

	Public Property lista_vi_aipbaremobr() As List(Of vi_aipbaremobr)
	Get
	Return Me.p_lista_vi_aipbaremobr
	End Get
	Set(ByVal Value As List(Of vi_aipbaremobr))
	Me.p_lista_vi_aipbaremobr = Value
	End Set
	End Property
	End Class

End Namespace
