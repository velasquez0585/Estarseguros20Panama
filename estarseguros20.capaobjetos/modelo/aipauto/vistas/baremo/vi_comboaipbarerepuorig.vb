Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.baremo

	Public Class vi_comboaipbarerepuorig

		Private p_idaipmanrepu As Decimal
		Private p_iorigbarerepu As String

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
			End Set
		End Property

		Public Property iorigbarerepu() As String
			Get
				Return Me.p_iorigbarerepu
			End Get
			Set(ByVal Value As String)
				Me.p_iorigbarerepu = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_comboaipbarerepuorigpaglist

	Private p_pagvi_comboaipbarerepuorig As paginacion
	Private p_vi_comboaipbarerepuorig As vi_comboaipbarerepuorig

	Public Property pagvi_comboaipbarerepuorig() As paginacion
	Get
	Return Me.p_pagvi_comboaipbarerepuorig
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbarerepuorig = Value
	End Set
	End Property

	Public Property vi_comboaipbarerepuorig() As vi_comboaipbarerepuorig
	Get
	Return Me.p_vi_comboaipbarerepuorig
	End Get
	Set(ByVal Value As vi_comboaipbarerepuorig)
	Me.p_vi_comboaipbarerepuorig = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_comboaipbarerepuorigpaglist

	Private p_pagvi_comboaipbarerepuorig As paginacion
	Private p_lista_vi_comboaipbarerepuorig As  List(Of vi_comboaipbarerepuorig)

	Public Property pagvi_comboaipbarerepuorig() As paginacion
	Get
	Return Me.p_pagvi_comboaipbarerepuorig
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_comboaipbarerepuorig = Value
	End Set
	End Property

	Public Property lista_vi_comboaipbarerepuorig() As List(Of vi_comboaipbarerepuorig)
	Get
	Return Me.p_lista_vi_comboaipbarerepuorig
	End Get
	Set(ByVal Value As List(Of vi_comboaipbarerepuorig))
	Me.p_lista_vi_comboaipbarerepuorig = Value
	End Set
	End Property
	End Class

End Namespace
