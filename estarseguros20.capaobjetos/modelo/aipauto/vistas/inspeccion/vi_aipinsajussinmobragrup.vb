Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsajussinmobragrup

		Private p_idaipinsajussin As Decimal
		Private p_idaipinsenc As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_ncantinsajussinmobr As Int32
		Private p_nreginsajussinmobr As Int32

		Public Property idaipinsajussin() As Decimal
			Get
				Return Me.p_idaipinsajussin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussin = Value
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

		Public Property ncantinsajussinmobr() As Int32
			Get
				Return Me.p_ncantinsajussinmobr
			End Get
			Set(ByVal Value As Int32)
				Me.p_ncantinsajussinmobr = Value
			End Set
		End Property

		Public Property nreginsajussinmobr() As Int32
			Get
				Return Me.p_nreginsajussinmobr
			End Get
			Set(ByVal Value As Int32)
				Me.p_nreginsajussinmobr = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsajussinmobragruppaglist

	Private p_pagvi_aipinsajussinmobragrup As paginacion
	Private p_vi_aipinsajussinmobragrup As vi_aipinsajussinmobragrup

	Public Property pagvi_aipinsajussinmobragrup() As paginacion
	Get
	Return Me.p_pagvi_aipinsajussinmobragrup
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajussinmobragrup = Value
	End Set
	End Property

	Public Property vi_aipinsajussinmobragrup() As vi_aipinsajussinmobragrup
	Get
	Return Me.p_vi_aipinsajussinmobragrup
	End Get
	Set(ByVal Value As vi_aipinsajussinmobragrup)
	Me.p_vi_aipinsajussinmobragrup = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsajussinmobragruppaglist

	Private p_pagvi_aipinsajussinmobragrup As paginacion
	Private p_lista_vi_aipinsajussinmobragrup As  List(Of vi_aipinsajussinmobragrup)

	Public Property pagvi_aipinsajussinmobragrup() As paginacion
	Get
	Return Me.p_pagvi_aipinsajussinmobragrup
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajussinmobragrup = Value
	End Set
	End Property

	Public Property lista_vi_aipinsajussinmobragrup() As List(Of vi_aipinsajussinmobragrup)
	Get
	Return Me.p_lista_vi_aipinsajussinmobragrup
	End Get
	Set(ByVal Value As List(Of vi_aipinsajussinmobragrup))
	Me.p_lista_vi_aipinsajussinmobragrup = Value
	End Set
	End Property
	End Class

End Namespace
