Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.baremo

	Public Class vi_aipbarerepu

		Private p_idaipbarerepu As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_faplibarerepu As DateTime
		Private p_iorigbarerepu As String
		Private p_mcostbarerepu As Decimal

		Public Property idaipbarerepu() As Decimal
			Get
				Return Me.p_idaipbarerepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipbarerepu = Value
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

		Public Property faplibarerepu() As DateTime
			Get
				Return Me.p_faplibarerepu
			End Get
			Set(ByVal Value As DateTime)
				Me.p_faplibarerepu = Value
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

		Public Property mcostbarerepu() As Decimal
			Get
				Return Me.p_mcostbarerepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mcostbarerepu = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipbarerepupaglist

	Private p_pagvi_aipbarerepu As paginacion
	Private p_vi_aipbarerepu As vi_aipbarerepu

	Public Property pagvi_aipbarerepu() As paginacion
	Get
	Return Me.p_pagvi_aipbarerepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipbarerepu = Value
	End Set
	End Property

	Public Property vi_aipbarerepu() As vi_aipbarerepu
	Get
	Return Me.p_vi_aipbarerepu
	End Get
	Set(ByVal Value As vi_aipbarerepu)
	Me.p_vi_aipbarerepu = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipbarerepupaglist

	Private p_pagvi_aipbarerepu As paginacion
	Private p_lista_vi_aipbarerepu As  List(Of vi_aipbarerepu)

	Public Property pagvi_aipbarerepu() As paginacion
	Get
	Return Me.p_pagvi_aipbarerepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipbarerepu = Value
	End Set
	End Property

	Public Property lista_vi_aipbarerepu() As List(Of vi_aipbarerepu)
	Get
	Return Me.p_lista_vi_aipbarerepu
	End Get
	Set(ByVal Value As List(Of vi_aipbarerepu))
	Me.p_lista_vi_aipbarerepu = Value
	End Set
	End Property
	End Class

End Namespace
