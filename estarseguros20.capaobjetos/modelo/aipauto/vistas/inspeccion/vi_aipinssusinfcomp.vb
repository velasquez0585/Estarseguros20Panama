Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinssusinfcomp

		Private p_idaipinssusinfcomp As Decimal
		Private p_idaipinssus As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipmaninfcomp As Decimal
		Private p_xnommaninfcomp As String
		Private p_nordenmaninfcomp As Int16
		Private p_iexisinssusinfcomp As Int32
		Private p_idseglogreg As Decimal

		Public Property idaipinssusinfcomp() As Decimal
			Get
				Return Me.p_idaipinssusinfcomp
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinssusinfcomp = Value
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

		Public Property idaipmaninfcomp() As Decimal
			Get
				Return Me.p_idaipmaninfcomp
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmaninfcomp = Value
			End Set
		End Property

		Public Property xnommaninfcomp() As String
			Get
				Return Me.p_xnommaninfcomp
			End Get
			Set(ByVal Value As String)
				Me.p_xnommaninfcomp = Value
			End Set
		End Property

		Public Property nordenmaninfcomp() As Int16
			Get
				Return Me.p_nordenmaninfcomp
			End Get
			Set(ByVal Value As Int16)
				Me.p_nordenmaninfcomp = Value
			End Set
		End Property

		Public Property iexisinssusinfcomp() As Int32
			Get
				Return Me.p_iexisinssusinfcomp
			End Get
			Set(ByVal Value As Int32)
				Me.p_iexisinssusinfcomp = Value
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
	
	Public Class petivi_aipinssusinfcomppaglist

	Private p_pagvi_aipinssusinfcomp As paginacion
	Private p_vi_aipinssusinfcomp As vi_aipinssusinfcomp

	Public Property pagvi_aipinssusinfcomp() As paginacion
	Get
	Return Me.p_pagvi_aipinssusinfcomp
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusinfcomp = Value
	End Set
	End Property

	Public Property vi_aipinssusinfcomp() As vi_aipinssusinfcomp
	Get
	Return Me.p_vi_aipinssusinfcomp
	End Get
	Set(ByVal Value As vi_aipinssusinfcomp)
	Me.p_vi_aipinssusinfcomp = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinssusinfcomppaglist

	Private p_pagvi_aipinssusinfcomp As paginacion
	Private p_lista_vi_aipinssusinfcomp As  List(Of vi_aipinssusinfcomp)

	Public Property pagvi_aipinssusinfcomp() As paginacion
	Get
	Return Me.p_pagvi_aipinssusinfcomp
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinssusinfcomp = Value
	End Set
	End Property

	Public Property lista_vi_aipinssusinfcomp() As List(Of vi_aipinssusinfcomp)
	Get
	Return Me.p_lista_vi_aipinssusinfcomp
	End Get
	Set(ByVal Value As List(Of vi_aipinssusinfcomp))
	Me.p_lista_vi_aipinssusinfcomp = Value
	End Set
	End Property
	End Class

End Namespace
