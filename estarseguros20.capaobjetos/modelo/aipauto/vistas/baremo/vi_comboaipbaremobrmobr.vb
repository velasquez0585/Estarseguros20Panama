Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.baremo

	Public Class vi_comboaipbaremobrmobr

		Private p_idaipmanrepu As Decimal
		Private p_itipobaremobr As String

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
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

	End Class
	
	Public Class petivi_comboaipbaremobrmobrpaglist

	Private p_pagvi_comboaipbaremobrmobr As paginacion
	Private p_vi_comboaipbaremobrmobr As vi_comboaipbaremobrmobr

	Public Property pagvi_comboaipbaremobrmobr() As paginacion
	Get
	Return Me.p_pagvi_comboaipbaremobrmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbaremobrmobr = Value
	End Set
	End Property

	Public Property vi_comboaipbaremobrmobr() As vi_comboaipbaremobrmobr
	Get
	Return Me.p_vi_comboaipbaremobrmobr
	End Get
	Set(ByVal Value As vi_comboaipbaremobrmobr)
	Me.p_vi_comboaipbaremobrmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_comboaipbaremobrmobrpaglist

	Private p_pagvi_comboaipbaremobrmobr As paginacion
	Private p_lista_vi_comboaipbaremobrmobr As  List(Of vi_comboaipbaremobrmobr)

	Public Property pagvi_comboaipbaremobrmobr() As paginacion
	Get
	Return Me.p_pagvi_comboaipbaremobrmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbaremobrmobr = Value
	End Set
	End Property

	Public Property lista_vi_comboaipbaremobrmobr() As List(Of vi_comboaipbaremobrmobr)
	Get
	Return Me.p_lista_vi_comboaipbaremobrmobr
	End Get
	Set(ByVal Value As List(Of vi_comboaipbaremobrmobr))
	Me.p_lista_vi_comboaipbaremobrmobr = Value
	End Set
	End Property
	End Class

End Namespace
