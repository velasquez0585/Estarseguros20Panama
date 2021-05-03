Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.baremo

	Public Class vi_comboaipbaremobrmater

		Private p_idaipmanrepu As Decimal
		Private p_imaterpiezbaremobr As String

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
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

	End Class
	
	Public Class petivi_comboaipbaremobrmaterpaglist

	Private p_pagvi_comboaipbaremobrmater As paginacion
	Private p_vi_comboaipbaremobrmater As vi_comboaipbaremobrmater

	Public Property pagvi_comboaipbaremobrmater() As paginacion
	Get
	Return Me.p_pagvi_comboaipbaremobrmater
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbaremobrmater = Value
	End Set
	End Property

	Public Property vi_comboaipbaremobrmater() As vi_comboaipbaremobrmater
	Get
	Return Me.p_vi_comboaipbaremobrmater
	End Get
	Set(ByVal Value As vi_comboaipbaremobrmater)
	Me.p_vi_comboaipbaremobrmater = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_comboaipbaremobrmaterpaglist

	Private p_pagvi_comboaipbaremobrmater As paginacion
	Private p_lista_vi_comboaipbaremobrmater As  List(Of vi_comboaipbaremobrmater)

	Public Property pagvi_comboaipbaremobrmater() As paginacion
	Get
	Return Me.p_pagvi_comboaipbaremobrmater
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbaremobrmater = Value
	End Set
	End Property

	Public Property lista_vi_comboaipbaremobrmater() As List(Of vi_comboaipbaremobrmater)
	Get
	Return Me.p_lista_vi_comboaipbaremobrmater
	End Get
	Set(ByVal Value As List(Of vi_comboaipbaremobrmater))
	Me.p_lista_vi_comboaipbaremobrmater = Value
	End Set
	End Property
	End Class

End Namespace
