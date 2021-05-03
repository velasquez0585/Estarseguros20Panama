Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsrestsse

		Private p_idaipinsrestsse As Decimal
		Private p_idaipinsrest As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipmanvehsse As Decimal
		Private p_xnommanvehsse As String
		Private p_iexisinsrestsse As Boolean
		Private p_idseglogreg As Decimal

		Public Property idaipinsrestsse() As Decimal
			Get
				Return Me.p_idaipinsrestsse
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrestsse = Value
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

		Public Property idaipmanvehsse() As Decimal
			Get
				Return Me.p_idaipmanvehsse
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehsse = Value
			End Set
		End Property

		Public Property xnommanvehsse() As String
			Get
				Return Me.p_xnommanvehsse
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehsse = Value
			End Set
		End Property

		Public Property iexisinsrestsse() As Boolean
			Get
				Return Me.p_iexisinsrestsse
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iexisinsrestsse = Value
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
	
	Public Class petivi_aipinsrestssepaglist

	Private p_pagvi_aipinsrestsse As paginacion
	Private p_vi_aipinsrestsse As vi_aipinsrestsse

	Public Property pagvi_aipinsrestsse() As paginacion
	Get
	Return Me.p_pagvi_aipinsrestsse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrestsse = Value
	End Set
	End Property

	Public Property vi_aipinsrestsse() As vi_aipinsrestsse
	Get
	Return Me.p_vi_aipinsrestsse
	End Get
	Set(ByVal Value As vi_aipinsrestsse)
	Me.p_vi_aipinsrestsse = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsrestssepaglist

	Private p_pagvi_aipinsrestsse As paginacion
	Private p_lista_vi_aipinsrestsse As  List(Of vi_aipinsrestsse)

	Public Property pagvi_aipinsrestsse() As paginacion
	Get
	Return Me.p_pagvi_aipinsrestsse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrestsse = Value
	End Set
	End Property

	Public Property lista_vi_aipinsrestsse() As List(Of vi_aipinsrestsse)
	Get
	Return Me.p_lista_vi_aipinsrestsse
	End Get
	Set(ByVal Value As List(Of vi_aipinsrestsse))
	Me.p_lista_vi_aipinsrestsse = Value
	End Set
	End Property
	End Class

End Namespace
