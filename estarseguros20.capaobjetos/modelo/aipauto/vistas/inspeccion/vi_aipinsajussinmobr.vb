Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsajussinmobr

		Private p_idaipinsajussinmobr As Decimal
		Private p_idaipinsajussin As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipbaremobr As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_faplibaremobr As DateTime
		Private p_itipobaremobr As String
		Private p_itamapiezbaremobr As String
		Private p_imaterpiezbaremobr As String
		Private p_mcostbaremobr As Decimal
		Private p_xdescbaremobr As String
		Private p_ncantinsajussinmobr As Int16
		Private p_nprecfininsajussinmobr As Decimal
		Private p_xdescinsajussinmobr As String
		Private p_iestatinsajussinmobr As String
		Private p_idseglogreg As Decimal

		Public Property idaipinsajussinmobr() As Decimal
			Get
				Return Me.p_idaipinsajussinmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussinmobr = Value
			End Set
		End Property

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

		Public Property itipoinsenc() As String
			Get
				Return Me.p_itipoinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_itipoinsenc = Value
			End Set
		End Property

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

		Public Property ncantinsajussinmobr() As Int16
			Get
				Return Me.p_ncantinsajussinmobr
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinsajussinmobr = Value
			End Set
		End Property

		Public Property nprecfininsajussinmobr() As Decimal
			Get
				Return Me.p_nprecfininsajussinmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininsajussinmobr = Value
			End Set
		End Property

		Public Property xdescinsajussinmobr() As String
			Get
				Return Me.p_xdescinsajussinmobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsajussinmobr = Value
			End Set
		End Property

		Public Property iestatinsajussinmobr() As String
			Get
				Return Me.p_iestatinsajussinmobr
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsajussinmobr = Value
			End Set
		End Property

		Public Property idseglogreg() As Decimal
			Get
				Return Me.p_idseglogreg
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idseglogreg = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsajussinmobrpaglist

	Private p_pagvi_aipinsajussinmobr As paginacion
	Private p_vi_aipinsajussinmobr As vi_aipinsajussinmobr

	Public Property pagvi_aipinsajussinmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinsajussinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajussinmobr = Value
	End Set
	End Property

	Public Property vi_aipinsajussinmobr() As vi_aipinsajussinmobr
	Get
	Return Me.p_vi_aipinsajussinmobr
	End Get
	Set(ByVal Value As vi_aipinsajussinmobr)
	Me.p_vi_aipinsajussinmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsajussinmobrpaglist

	Private p_pagvi_aipinsajussinmobr As paginacion
	Private p_lista_vi_aipinsajussinmobr As  List(Of vi_aipinsajussinmobr)

	Public Property pagvi_aipinsajussinmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinsajussinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajussinmobr = Value
	End Set
	End Property

	Public Property lista_vi_aipinsajussinmobr() As List(Of vi_aipinsajussinmobr)
	Get
	Return Me.p_lista_vi_aipinsajussinmobr
	End Get
	Set(ByVal Value As List(Of vi_aipinsajussinmobr))
	Me.p_lista_vi_aipinsajussinmobr = Value
	End Set
	End Property
	End Class

End Namespace
