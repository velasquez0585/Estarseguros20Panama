Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssusssm

		Private p_idaipinssusssm As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipmanvehssm As Decimal
		Private p_xnommanvehssm As String
		Private p_iexisinssusssm As Boolean
		Private p_idseglogreg As Decimal

		Public Property idaipinssusssm() As Decimal
			Get
				Return Me.p_idaipinssusssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssusssm = Value
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

		Public Property iexisinssusssm() As Boolean
			Get
				Return Me.p_iexisinssusssm
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iexisinssusssm = Value
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
	
	Public Class petivi_aipinssusssmpaglist

	Private p_pagvi_aipinssusssm As paginacion
	Private p_vi_aipinssusssm As vi_aipinssusssm

	Public Property pagvi_aipinssusssm() As paginacion
	Get
	Return Me.p_pagvi_aipinssusssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusssm = Value
	End Set
	End Property

	Public Property vi_aipinssusssm() As vi_aipinssusssm
	Get
	Return Me.p_vi_aipinssusssm
	End Get
	Set(ByVal Value As vi_aipinssusssm)
	Me.p_vi_aipinssusssm = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssusssmpaglist

	Private p_pagvi_aipinssusssm As paginacion
	Private p_lista_vi_aipinssusssm As  List(Of vi_aipinssusssm)

	Public Property pagvi_aipinssusssm() As paginacion
	Get
	Return Me.p_pagvi_aipinssusssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusssm = Value
	End Set
	End Property

	Public Property lista_vi_aipinssusssm() As List(Of vi_aipinssusssm)
	Get
	Return Me.p_lista_vi_aipinssusssm
	End Get
	Set(ByVal Value As List(Of vi_aipinssusssm))
	Me.p_lista_vi_aipinssusssm = Value
	End Set
	End Property
	End Class

End Namespace
