Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssussse

		Private p_idaipinssussse As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipmanvehsse As Decimal
		Private p_xnommanvehsse As String
		Private p_iexisinssussse As Int32
		Private p_idseglogreg As Decimal

		Public Property idaipinssussse() As Decimal
			Get
				Return Me.p_idaipinssussse
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssussse = Value
			End Set
		End Property

		Public Property idaipinssus() As Decimal
			Get
				Return Me.p_idaipinssus
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssus = Value
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

		Public Property iexisinssussse() As Int32
			Get
				Return Me.p_iexisinssussse
			End Get
			Set(ByVal Value As Int32)
				Me.p_iexisinssussse = Value
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
	
	Public Class petivi_aipinssusssepaglist

	Private p_pagvi_aipinssussse As paginacion
	Private p_vi_aipinssussse As vi_aipinssussse

	Public Property pagvi_aipinssussse() As paginacion
	Get
	Return Me.p_pagvi_aipinssussse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssussse = Value
	End Set
	End Property

	Public Property vi_aipinssussse() As vi_aipinssussse
	Get
	Return Me.p_vi_aipinssussse
	End Get
	Set(ByVal Value As vi_aipinssussse)
	Me.p_vi_aipinssussse = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssusssepaglist

	Private p_pagvi_aipinssussse As paginacion
	Private p_lista_vi_aipinssussse As  List(Of vi_aipinssussse)

	Public Property pagvi_aipinssussse() As paginacion
	Get
	Return Me.p_pagvi_aipinssussse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssussse = Value
	End Set
	End Property

	Public Property lista_vi_aipinssussse() As List(Of vi_aipinssussse)
	Get
	Return Me.p_lista_vi_aipinssussse
	End Get
	Set(ByVal Value As List(Of vi_aipinssussse))
	Me.p_lista_vi_aipinssussse = Value
	End Set
	End Property
	End Class

End Namespace
