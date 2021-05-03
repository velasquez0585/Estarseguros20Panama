Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsdistperit

		Private p_idsegmanusuperit As Decimal
		Private p_xnombrecompletoperit As String
		Private p_idsegmanorgperit As Decimal
		Private p_xnombrecomercialperit As String
		Private p_ncantinsperit As Int32

		Public Property idsegmanusuperit() As Decimal
			Get
				Return Me.p_idsegmanusuperit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusuperit = Value
			End Set
		End Property

		Public Property xnombrecompletoperit() As String
			Get
				Return Me.p_xnombrecompletoperit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompletoperit = Value
			End Set
		End Property

		Public Property idsegmanorgperit() As Decimal
			Get
				Return Me.p_idsegmanorgperit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanorgperit = Value
			End Set
		End Property

		Public Property xnombrecomercialperit() As String
			Get
				Return Me.p_xnombrecomercialperit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecomercialperit = Value
			End Set
		End Property

		Public Property ncantinsperit() As Int32
			Get
				Return Me.p_ncantinsperit
			End Get
			Set(ByVal Value As Int32)
				Me.p_ncantinsperit = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsdistperitpaglist

	Private p_pagvi_aipinsdistperit As paginacion
	Private p_vi_aipinsdistperit As vi_aipinsdistperit

	Public Property pagvi_aipinsdistperit() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistperit
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistperit = Value
	End Set
	End Property

	Public Property vi_aipinsdistperit() As vi_aipinsdistperit
	Get
	Return Me.p_vi_aipinsdistperit
	End Get
	Set(ByVal Value As vi_aipinsdistperit)
	Me.p_vi_aipinsdistperit = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsdistperitpaglist

	Private p_pagvi_aipinsdistperit As paginacion
	Private p_lista_vi_aipinsdistperit As  List(Of vi_aipinsdistperit)

	Public Property pagvi_aipinsdistperit() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistperit
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistperit = Value
	End Set
	End Property

	Public Property lista_vi_aipinsdistperit() As List(Of vi_aipinsdistperit)
	Get
	Return Me.p_lista_vi_aipinsdistperit
	End Get
	Set(ByVal Value As List(Of vi_aipinsdistperit))
	Me.p_lista_vi_aipinsdistperit = Value
	End Set
	End Property
	End Class

End Namespace
