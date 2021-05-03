Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.baremo

	Public Class vi_comboaipbaremobrtama

		Private p_idaipmanrepu As Decimal
		Private p_itamapiezbaremobr As String

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
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

	End Class
	
	Public Class petivi_comboaipbaremobrtamapaglist

	Private p_pagvi_comboaipbaremobrtama As paginacion
	Private p_vi_comboaipbaremobrtama As vi_comboaipbaremobrtama

	Public Property pagvi_comboaipbaremobrtama() As paginacion
	Get
	Return Me.p_pagvi_comboaipbaremobrtama
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbaremobrtama = Value
	End Set
	End Property

	Public Property vi_comboaipbaremobrtama() As vi_comboaipbaremobrtama
	Get
	Return Me.p_vi_comboaipbaremobrtama
	End Get
	Set(ByVal Value As vi_comboaipbaremobrtama)
	Me.p_vi_comboaipbaremobrtama = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_comboaipbaremobrtamapaglist

	Private p_pagvi_comboaipbaremobrtama As paginacion
	Private p_lista_vi_comboaipbaremobrtama As  List(Of vi_comboaipbaremobrtama)

	Public Property pagvi_comboaipbaremobrtama() As paginacion
	Get
	Return Me.p_pagvi_comboaipbaremobrtama
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbaremobrtama = Value
	End Set
	End Property

	Public Property lista_vi_comboaipbaremobrtama() As List(Of vi_comboaipbaremobrtama)
	Get
	Return Me.p_lista_vi_comboaipbaremobrtama
	End Get
	Set(ByVal Value As List(Of vi_comboaipbaremobrtama))
	Me.p_lista_vi_comboaipbaremobrtama = Value
	End Set
	End Property
	End Class

End Namespace
