Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsrestssm

		Private p_idaipinsrestssm As Decimal
		Private p_idaipinsrest As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipmanvehssm As Decimal
		Private p_xnommanvehssm As String
		Private p_iexisinsrestssm As Int32
		Private p_idseglogreg As Decimal

		Public Property idaipinsrestssm() As Decimal
			Get
				Return Me.p_idaipinsrestssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrestssm = Value
			End Set
		End Property

		Public Property idaipinsrest() As Decimal
			Get
				Return Me.p_idaipinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrest = Value
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

		Public Property idaipmanvehssm() As Decimal
			Get
				Return Me.p_idaipmanvehssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehssm = Value
			End Set
		End Property

		Public Property xnommanvehssm() As String
			Get
				Return Me.p_xnommanvehssm
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehssm = Value
			End Set
		End Property

		Public Property iexisinsrestssm() As Int32
			Get
				Return Me.p_iexisinsrestssm
			End Get
			Set(ByVal Value As Int32)
				Me.p_iexisinsrestssm = Value
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
	
	Public Class petivi_aipinsrestssmpaglist

	Private p_pagvi_aipinsrestssm As paginacion
	Private p_vi_aipinsrestssm As vi_aipinsrestssm

	Public Property pagvi_aipinsrestssm() As paginacion
	Get
	Return Me.p_pagvi_aipinsrestssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrestssm = Value
	End Set
	End Property

	Public Property vi_aipinsrestssm() As vi_aipinsrestssm
	Get
	Return Me.p_vi_aipinsrestssm
	End Get
	Set(ByVal Value As vi_aipinsrestssm)
	Me.p_vi_aipinsrestssm = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsrestssmpaglist

	Private p_pagvi_aipinsrestssm As paginacion
	Private p_lista_vi_aipinsrestssm As  List(Of vi_aipinsrestssm)

	Public Property pagvi_aipinsrestssm() As paginacion
	Get
	Return Me.p_pagvi_aipinsrestssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrestssm = Value
	End Set
	End Property

	Public Property lista_vi_aipinsrestssm() As List(Of vi_aipinsrestssm)
	Get
	Return Me.p_lista_vi_aipinsrestssm
	End Get
	Set(ByVal Value As List(Of vi_aipinsrestssm))
	Me.p_lista_vi_aipinsrestssm = Value
	End Set
	End Property
	End Class

End Namespace
