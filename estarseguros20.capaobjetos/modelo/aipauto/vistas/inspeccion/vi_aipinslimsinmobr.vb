Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinslimsinmobr

		Private p_idaipinslimsinmobr As Decimal
		Private p_idaipinslimsin As Decimal
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
		Private p_ncantinslimsinmobr As Int16
		Private p_nprecfininslimsinmobr As Decimal
		Private p_xdescinslimsinmobr As String
		Private p_iestatinslimsinmobr As String
		Private p_idseglogreg As Decimal

		Public Property idaipinslimsinmobr() As Decimal
			Get
				Return Me.p_idaipinslimsinmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsinmobr = Value
			End Set
		End Property

		Public Property idaipinslimsin() As Decimal
			Get
				Return Me.p_idaipinslimsin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsin = Value
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

		Public Property ncantinslimsinmobr() As Int16
			Get
				Return Me.p_ncantinslimsinmobr
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinslimsinmobr = Value
			End Set
		End Property

		Public Property nprecfininslimsinmobr() As Decimal
			Get
				Return Me.p_nprecfininslimsinmobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininslimsinmobr = Value
			End Set
		End Property

		Public Property xdescinslimsinmobr() As String
			Get
				Return Me.p_xdescinslimsinmobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinslimsinmobr = Value
			End Set
		End Property

		Public Property iestatinslimsinmobr() As String
			Get
				Return Me.p_iestatinslimsinmobr
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinslimsinmobr = Value
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
	
	Public Class petivi_aipinslimsinmobrpaglist

	Private p_pagvi_aipinslimsinmobr As paginacion
	Private p_vi_aipinslimsinmobr As vi_aipinslimsinmobr

	Public Property pagvi_aipinslimsinmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsinmobr = Value
	End Set
	End Property

	Public Property vi_aipinslimsinmobr() As vi_aipinslimsinmobr
	Get
	Return Me.p_vi_aipinslimsinmobr
	End Get
	Set(ByVal Value As vi_aipinslimsinmobr)
	Me.p_vi_aipinslimsinmobr = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinslimsinmobrpaglist

	Private p_pagvi_aipinslimsinmobr As paginacion
	Private p_lista_vi_aipinslimsinmobr As  List(Of vi_aipinslimsinmobr)

	Public Property pagvi_aipinslimsinmobr() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsinmobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsinmobr = Value
	End Set
	End Property

	Public Property lista_vi_aipinslimsinmobr() As List(Of vi_aipinslimsinmobr)
	Get
	Return Me.p_lista_vi_aipinslimsinmobr
	End Get
	Set(ByVal Value As List(Of vi_aipinslimsinmobr))
	Me.p_lista_vi_aipinslimsinmobr = Value
	End Set
	End Property
	End Class

End Namespace
