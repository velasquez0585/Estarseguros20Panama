Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsajusanexmobragrup

		Private p_idaipinsajusanex As Decimal
		Private p_idaipinsenc As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_ncantinsajusanexmobr As Int32
		Private p_nreginsajusanexmobr As Int32

		Public Property idaipinsajusanex() As Decimal
			Get
				Return Me.p_idaipinsajusanex
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajusanex = Value
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

		Public Property ncantinsajusanexmobr() As Int32
			Get
				Return Me.p_ncantinsajusanexmobr
			End Get
			Set(ByVal Value As Int32)
				Me.p_ncantinsajusanexmobr = Value
			End Set
		End Property

		Public Property nreginsajusanexmobr() As Int32
			Get
				Return Me.p_nreginsajusanexmobr
			End Get
			Set(ByVal Value As Int32)
				Me.p_nreginsajusanexmobr = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsajusanexmobragruppaglist

	Private p_pagvi_aipinsajusanexmobragrup As paginacion
	Private p_vi_aipinsajusanexmobragrup As vi_aipinsajusanexmobragrup

	Public Property pagvi_aipinsajusanexmobragrup() As paginacion
	Get
	Return Me.p_pagvi_aipinsajusanexmobragrup
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajusanexmobragrup = Value
	End Set
	End Property

	Public Property vi_aipinsajusanexmobragrup() As vi_aipinsajusanexmobragrup
	Get
	Return Me.p_vi_aipinsajusanexmobragrup
	End Get
	Set(ByVal Value As vi_aipinsajusanexmobragrup)
	Me.p_vi_aipinsajusanexmobragrup = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsajusanexmobragruppaglist

	Private p_pagvi_aipinsajusanexmobragrup As paginacion
	Private p_lista_vi_aipinsajusanexmobragrup As  List(Of vi_aipinsajusanexmobragrup)

	Public Property pagvi_aipinsajusanexmobragrup() As paginacion
	Get
	Return Me.p_pagvi_aipinsajusanexmobragrup
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajusanexmobragrup = Value
	End Set
	End Property

	Public Property lista_vi_aipinsajusanexmobragrup() As List(Of vi_aipinsajusanexmobragrup)
	Get
	Return Me.p_lista_vi_aipinsajusanexmobragrup
	End Get
	Set(ByVal Value As List(Of vi_aipinsajusanexmobragrup))
	Me.p_lista_vi_aipinsajusanexmobragrup = Value
	End Set
	End Property
	End Class

End Namespace
