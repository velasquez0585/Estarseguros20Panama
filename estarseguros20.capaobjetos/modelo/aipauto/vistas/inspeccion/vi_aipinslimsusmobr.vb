Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinslimsusmobr

		Private p_idaipinslimsusmobr As Decimal
		Private p_idaipinslimsus As Decimal
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
		Private p_ncantinslimsusmobr As Int16
		Private p_nprecfininslimsusmobr As Decimal
		Private p_xdescinslimsusmobr As String
		Private p_iestatinslimsusmobr As String
		Private p_idseglogreg As Decimal

		Public Property idaipinslimsusmobr() As Decimal
			Get
				Return Me.p_idaipinslimsusmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsusmobr = Value
			End Set
		End Property

		Public Property idaipinslimsus() As Decimal
			Get
				Return Me.p_idaipinslimsus
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsus = Value
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

		Public Property ncantinslimsusmobr() As Int16
			Get
				Return Me.p_ncantinslimsusmobr
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinslimsusmobr = Value
			End Set
		End Property

		Public Property nprecfininslimsusmobr() As Decimal
			Get
				Return Me.p_nprecfininslimsusmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininslimsusmobr = Value
			End Set
		End Property

		Public Property xdescinslimsusmobr() As String
			Get
				Return Me.p_xdescinslimsusmobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinslimsusmobr = Value
			End Set
		End Property

		Public Property iestatinslimsusmobr() As String
			Get
				Return Me.p_iestatinslimsusmobr
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinslimsusmobr = Value
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
	
	Public Class petivi_aipinslimsusmobrpaglist

	Private p_pagvi_aipinslimsusmobr As paginacion
	Private p_vi_aipinslimsusmobr As vi_aipinslimsusmobr

	Public Property pagvi_aipinslimsusmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsusmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsusmobr = Value
	End Set
	End Property

	Public Property vi_aipinslimsusmobr() As vi_aipinslimsusmobr
	Get
	Return Me.p_vi_aipinslimsusmobr
	End Get
	Set(ByVal Value As vi_aipinslimsusmobr)
	Me.p_vi_aipinslimsusmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinslimsusmobrpaglist

	Private p_pagvi_aipinslimsusmobr As paginacion
	Private p_lista_vi_aipinslimsusmobr As  List(Of vi_aipinslimsusmobr)

	Public Property pagvi_aipinslimsusmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsusmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsusmobr = Value
	End Set
	End Property

	Public Property lista_vi_aipinslimsusmobr() As List(Of vi_aipinslimsusmobr)
	Get
	Return Me.p_lista_vi_aipinslimsusmobr
	End Get
	Set(ByVal Value As List(Of vi_aipinslimsusmobr))
	Me.p_lista_vi_aipinslimsusmobr = Value
	End Set
	End Property
	End Class

End Namespace
