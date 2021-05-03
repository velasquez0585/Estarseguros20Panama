Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsajusanexmobr

		Private p_idaipinsajusanexmobr As Decimal
		Private p_idaipinsajusanex As Decimal
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
		Private p_ncantinsajusanexmobr As Int16
		Private p_nprecfininsajusanexmobr As Decimal
		Private p_xdescinsajusanexmobr As String
		Private p_iestatinsajusanexmobr As String
		Private p_idseglogreg As Decimal

		Public Property idaipinsajusanexmobr() As Decimal
			Get
				Return Me.p_idaipinsajusanexmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajusanexmobr = Value
			End Set
		End Property

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

		Public Property ncantinsajusanexmobr() As Int16
			Get
				Return Me.p_ncantinsajusanexmobr
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinsajusanexmobr = Value
			End Set
		End Property

		Public Property nprecfininsajusanexmobr() As Decimal
			Get
				Return Me.p_nprecfininsajusanexmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininsajusanexmobr = Value
			End Set
		End Property

		Public Property xdescinsajusanexmobr() As String
			Get
				Return Me.p_xdescinsajusanexmobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsajusanexmobr = Value
			End Set
		End Property

		Public Property iestatinsajusanexmobr() As String
			Get
				Return Me.p_iestatinsajusanexmobr
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsajusanexmobr = Value
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
	
	Public Class petivi_aipinsajusanexmobrpaglist

	Private p_pagvi_aipinsajusanexmobr As paginacion
	Private p_vi_aipinsajusanexmobr As vi_aipinsajusanexmobr

	Public Property pagvi_aipinsajusanexmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinsajusanexmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajusanexmobr = Value
	End Set
	End Property

	Public Property vi_aipinsajusanexmobr() As vi_aipinsajusanexmobr
	Get
	Return Me.p_vi_aipinsajusanexmobr
	End Get
	Set(ByVal Value As vi_aipinsajusanexmobr)
	Me.p_vi_aipinsajusanexmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsajusanexmobrpaglist

	Private p_pagvi_aipinsajusanexmobr As paginacion
	Private p_lista_vi_aipinsajusanexmobr As  List(Of vi_aipinsajusanexmobr)

	Public Property pagvi_aipinsajusanexmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinsajusanexmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsajusanexmobr = Value
	End Set
	End Property

	Public Property lista_vi_aipinsajusanexmobr() As List(Of vi_aipinsajusanexmobr)
	Get
	Return Me.p_lista_vi_aipinsajusanexmobr
	End Get
	Set(ByVal Value As List(Of vi_aipinsajusanexmobr))
	Me.p_lista_vi_aipinsajusanexmobr = Value
	End Set
	End Property
	End Class

End Namespace
