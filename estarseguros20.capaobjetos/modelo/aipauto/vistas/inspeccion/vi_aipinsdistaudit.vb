Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsdistaudit

		Private p_idsegmanusuaudit As Decimal
		Private p_xnombrecompletoaudit As String
		Private p_idsegmanorgaudit As Decimal
		Private p_xnombrecomercialaudit As String
		Private p_ncantinsperit As Int32

		Public Property idsegmanusuaudit() As Decimal
			Get
				Return Me.p_idsegmanusuaudit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusuaudit = Value
			End Set
		End Property

		Public Property xnombrecompletoaudit() As String
			Get
				Return Me.p_xnombrecompletoaudit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompletoaudit = Value
			End Set
		End Property

		Public Property idsegmanorgaudit() As Decimal
			Get
				Return Me.p_idsegmanorgaudit
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanorgaudit = Value
			End Set
		End Property

		Public Property xnombrecomercialaudit() As String
			Get
				Return Me.p_xnombrecomercialaudit
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecomercialaudit = Value
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
	
	Public Class petivi_aipinsdistauditpaglist

	Private p_pagvi_aipinsdistaudit As paginacion
	Private p_vi_aipinsdistaudit As vi_aipinsdistaudit

	Public Property pagvi_aipinsdistaudit() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistaudit
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistaudit = Value
	End Set
	End Property

	Public Property vi_aipinsdistaudit() As vi_aipinsdistaudit
	Get
	Return Me.p_vi_aipinsdistaudit
	End Get
	Set(ByVal Value As vi_aipinsdistaudit)
	Me.p_vi_aipinsdistaudit = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsdistauditpaglist

	Private p_pagvi_aipinsdistaudit As paginacion
	Private p_lista_vi_aipinsdistaudit As  List(Of vi_aipinsdistaudit)

	Public Property pagvi_aipinsdistaudit() As paginacion
	Get
	Return Me.p_pagvi_aipinsdistaudit
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsdistaudit = Value
	End Set
	End Property

	Public Property lista_vi_aipinsdistaudit() As List(Of vi_aipinsdistaudit)
	Get
	Return Me.p_lista_vi_aipinsdistaudit
	End Get
	Set(ByVal Value As List(Of vi_aipinsdistaudit))
	Me.p_lista_vi_aipinsdistaudit = Value
	End Set
	End Property
	End Class

End Namespace
