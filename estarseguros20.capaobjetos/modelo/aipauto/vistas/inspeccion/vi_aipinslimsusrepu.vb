Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinslimsusrepu

		Private p_idaipinslimsusrepu As Decimal
		Private p_idaipinslimsus As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipbarerepu As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_faplibarerepu As DateTime
		Private p_iorigbarerepu As String
		Private p_mcostbarerepu As Decimal
		Private p_ncantinslimsusrepu As Int16
		Private p_nprecfininslimsusrepu As Decimal
		Private p_xdescinslimsusrepu As String
		Private p_iestatinslimsusrepu As String
		Private p_idseglogreg As Decimal

		Public Property idaipinslimsusrepu() As Decimal
			Get
				Return Me.p_idaipinslimsusrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsusrepu = Value
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

		Public Property ncantinslimsusrepu() As Int16
			Get
				Return Me.p_ncantinslimsusrepu
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinslimsusrepu = Value
			End Set
		End Property

		Public Property nprecfininslimsusrepu() As Decimal
			Get
				Return Me.p_nprecfininslimsusrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininslimsusrepu = Value
			End Set
		End Property

		Public Property xdescinslimsusrepu() As String
			Get
				Return Me.p_xdescinslimsusrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinslimsusrepu = Value
			End Set
		End Property

		Public Property iestatinslimsusrepu() As String
			Get
				Return Me.p_iestatinslimsusrepu
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinslimsusrepu = Value
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
	
	Public Class petivi_aipinslimsusrepupaglist

	Private p_pagvi_aipinslimsusrepu As paginacion
	Private p_vi_aipinslimsusrepu As vi_aipinslimsusrepu

	Public Property pagvi_aipinslimsusrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsusrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsusrepu = Value
	End Set
	End Property

	Public Property vi_aipinslimsusrepu() As vi_aipinslimsusrepu
	Get
	Return Me.p_vi_aipinslimsusrepu
	End Get
	Set(ByVal Value As vi_aipinslimsusrepu)
	Me.p_vi_aipinslimsusrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinslimsusrepupaglist

	Private p_pagvi_aipinslimsusrepu As paginacion
	Private p_lista_vi_aipinslimsusrepu As  List(Of vi_aipinslimsusrepu)

	Public Property pagvi_aipinslimsusrepu() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsusrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsusrepu = Value
	End Set
	End Property

	Public Property lista_vi_aipinslimsusrepu() As List(Of vi_aipinslimsusrepu)
	Get
	Return Me.p_lista_vi_aipinslimsusrepu
	End Get
	Set(ByVal Value As List(Of vi_aipinslimsusrepu))
	Me.p_lista_vi_aipinslimsusrepu = Value
	End Set
	End Property
	End Class

End Namespace
