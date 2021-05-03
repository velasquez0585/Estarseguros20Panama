Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinslimsinrepu

		Private p_idaipinslimsinrepu As Decimal
		Private p_idaipinslimsin As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipbarerepu As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_faplibarerepu As DateTime
		Private p_iorigbarerepu As String
		Private p_mcostbarerepu As Decimal
		Private p_ncantinslimsinrepu As Int16
		Private p_nprecfininslimsinrepu As Decimal
		Private p_xdescinslimsinrepu As String
		Private p_iestatinslimsinrepu As String
		Private p_idseglogreg As Decimal

		Public Property idaipinslimsinrepu() As Decimal
			Get
				Return Me.p_idaipinslimsinrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsinrepu = Value
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

		Public Property ncantinslimsinrepu() As Int16
			Get
				Return Me.p_ncantinslimsinrepu
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinslimsinrepu = Value
			End Set
		End Property

		Public Property nprecfininslimsinrepu() As Decimal
			Get
				Return Me.p_nprecfininslimsinrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininslimsinrepu = Value
			End Set
		End Property

		Public Property xdescinslimsinrepu() As String
			Get
				Return Me.p_xdescinslimsinrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinslimsinrepu = Value
			End Set
		End Property

		Public Property iestatinslimsinrepu() As String
			Get
				Return Me.p_iestatinslimsinrepu
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinslimsinrepu = Value
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
	
	Public Class petivi_aipinslimsinrepupaglist

	Private p_pagvi_aipinslimsinrepu As paginacion
	Private p_vi_aipinslimsinrepu As vi_aipinslimsinrepu

	Public Property pagvi_aipinslimsinrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsinrepu = Value
	End Set
	End Property

	Public Property vi_aipinslimsinrepu() As vi_aipinslimsinrepu
	Get
	Return Me.p_vi_aipinslimsinrepu
	End Get
	Set(ByVal Value As vi_aipinslimsinrepu)
	Me.p_vi_aipinslimsinrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinslimsinrepupaglist

	Private p_pagvi_aipinslimsinrepu As paginacion
	Private p_lista_vi_aipinslimsinrepu As  List(Of vi_aipinslimsinrepu)

	Public Property pagvi_aipinslimsinrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsinrepu = Value
	End Set
	End Property

	Public Property lista_vi_aipinslimsinrepu() As List(Of vi_aipinslimsinrepu)
	Get
	Return Me.p_lista_vi_aipinslimsinrepu
	End Get
	Set(ByVal Value As List(Of vi_aipinslimsinrepu))
	Me.p_lista_vi_aipinslimsinrepu = Value
	End Set
	End Property
	End Class

End Namespace
