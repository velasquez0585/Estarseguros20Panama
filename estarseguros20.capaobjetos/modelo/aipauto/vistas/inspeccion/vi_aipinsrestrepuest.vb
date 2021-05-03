Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsrestrepuest

		Private p_idaipinsrestrepuest As Decimal
		Private p_idaipinsrest As Decimal
		Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
		Private p_idaipmanrepu As Decimal
		Private p_Expr1 As Decimal
		Private p_xnommanrepu As String
		Private p_xnominsrestrepuest As String
		Private p_iexisinsrestrepuest As Boolean
		Private p_ibueinsrestrepuest As Boolean
		Private p_ireginsrestrepuest As Boolean
		Private p_imalinsrestrepuest As Boolean
		Private p_iestinsrestrepuest As String
		Private p_xdescinsrestrepuest As String
		Private p_idseglogreg As Decimal

		Public Property idaipinsrestrepuest() As Decimal
			Get
				Return Me.p_idaipinsrestrepuest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrestrepuest = Value
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

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
			End Set
		End Property

		Public Property Expr1() As Decimal
			Get
				Return Me.p_Expr1
			End Get
			Set(ByVal Value As Decimal)
				Me.p_Expr1 = Value
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

		Public Property xnominsrestrepuest() As String
			Get
				Return Me.p_xnominsrestrepuest
			End Get
			Set(ByVal Value As String)
				Me.p_xnominsrestrepuest = Value
			End Set
		End Property

		Public Property iexisinsrestrepuest() As Boolean
			Get
				Return Me.p_iexisinsrestrepuest
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iexisinsrestrepuest = Value
			End Set
		End Property

		Public Property ibueinsrestrepuest() As Boolean
			Get
				Return Me.p_ibueinsrestrepuest
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ibueinsrestrepuest = Value
			End Set
		End Property

		Public Property ireginsrestrepuest() As Boolean
			Get
				Return Me.p_ireginsrestrepuest
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ireginsrestrepuest = Value
			End Set
		End Property

		Public Property imalinsrestrepuest() As Boolean
			Get
				Return Me.p_imalinsrestrepuest
			End Get
			Set(ByVal Value As Boolean)
				Me.p_imalinsrestrepuest = Value
			End Set
		End Property

		Public Property iestinsrestrepuest() As String
			Get
				Return Me.p_iestinsrestrepuest
			End Get
			Set(ByVal Value As String)
				Me.p_iestinsrestrepuest = Value
			End Set
		End Property

		Public Property xdescinsrestrepuest() As String
			Get
				Return Me.p_xdescinsrestrepuest
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsrestrepuest = Value
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
	
	Public Class petivi_aipinsrestrepuestpaglist

	Private p_pagvi_aipinsrestrepuest As paginacion
	Private p_vi_aipinsrestrepuest As vi_aipinsrestrepuest

	Public Property pagvi_aipinsrestrepuest() As paginacion
	Get
	Return Me.p_pagvi_aipinsrestrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrestrepuest = Value
	End Set
	End Property

	Public Property vi_aipinsrestrepuest() As vi_aipinsrestrepuest
	Get
	Return Me.p_vi_aipinsrestrepuest
	End Get
	Set(ByVal Value As vi_aipinsrestrepuest)
	Me.p_vi_aipinsrestrepuest = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsrestrepuestpaglist

	Private p_pagvi_aipinsrestrepuest As paginacion
	Private p_lista_vi_aipinsrestrepuest As  List(Of vi_aipinsrestrepuest)

	Public Property pagvi_aipinsrestrepuest() As paginacion
	Get
	Return Me.p_pagvi_aipinsrestrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsrestrepuest = Value
	End Set
	End Property

	Public Property lista_vi_aipinsrestrepuest() As List(Of vi_aipinsrestrepuest)
	Get
	Return Me.p_lista_vi_aipinsrestrepuest
	End Get
	Set(ByVal Value As List(Of vi_aipinsrestrepuest))
	Me.p_lista_vi_aipinsrestrepuest = Value
	End Set
	End Property
	End Class

End Namespace
