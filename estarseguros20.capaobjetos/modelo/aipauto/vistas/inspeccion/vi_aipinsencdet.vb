Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinsencdet

		Private p_idsegmanusucreaactivperi As Decimal
		Private p_xnombrecompletocrea As String
		Private p_idaipactivperi As Decimal
		Private p_fejecactivperi As DateTime
		Private p_xtituactivperi As String
		Private p_ialcanactivperi As String
		Private p_iestatactivperi As String
		Private p_ffinejecactivperi As DateTime
		Private p_idsegmanusu As Decimal
		Private p_xnombreusuario As String
		Private p_xnombrecompletoperito As String
		Private p_xcedpropinsenc As String
		Private p_xcidaseactivperi As String
		Private p_xplacaactivperi As String
		Private p_xsermotactivperi As String
		Private p_xsercarractivperi As String
		Private p_xnumpolinsenc As String
		Private p_xnumsininsenc As String
		Private p_xtelfmovilactivperi As String
		Private p_xdescactivperi As String

		Public Property idsegmanusucreaactivperi() As Decimal
			Get
				Return Me.p_idsegmanusucreaactivperi
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusucreaactivperi = Value
			End Set
		End Property

		Public Property xnombrecompletocrea() As String
			Get
				Return Me.p_xnombrecompletocrea
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompletocrea = Value
			End Set
		End Property

		Public Property idaipactivperi() As Decimal
			Get
				Return Me.p_idaipactivperi
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipactivperi = Value
			End Set
		End Property

		Public Property fejecactivperi() As DateTime
			Get
				Return Me.p_fejecactivperi
			End Get
			Set(ByVal Value As DateTime)
				Me.p_fejecactivperi = Value
			End Set
		End Property

		Public Property xtituactivperi() As String
			Get
				Return Me.p_xtituactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xtituactivperi = Value
			End Set
		End Property

		Public Property ialcanactivperi() As String
			Get
				Return Me.p_ialcanactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_ialcanactivperi = Value
			End Set
		End Property

		Public Property iestatactivperi() As String
			Get
				Return Me.p_iestatactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_iestatactivperi = Value
			End Set
		End Property

		Public Property ffinejecactivperi() As DateTime
			Get
				Return Me.p_ffinejecactivperi
			End Get
			Set(ByVal Value As DateTime)
				Me.p_ffinejecactivperi = Value
			End Set
		End Property

		Public Property idsegmanusu() As Decimal
			Get
				Return Me.p_idsegmanusu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idsegmanusu = Value
			End Set
		End Property

		Public Property xnombreusuario() As String
			Get
				Return Me.p_xnombreusuario
			End Get
			Set(ByVal Value As String)
				Me.p_xnombreusuario = Value
			End Set
		End Property

		Public Property xnombrecompletoperito() As String
			Get
				Return Me.p_xnombrecompletoperito
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompletoperito = Value
			End Set
		End Property

		Public Property xcedpropinsenc() As String
			Get
				Return Me.p_xcedpropinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xcedpropinsenc = Value
			End Set
		End Property

		Public Property xcidaseactivperi() As String
			Get
				Return Me.p_xcidaseactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xcidaseactivperi = Value
			End Set
		End Property

		Public Property xplacaactivperi() As String
			Get
				Return Me.p_xplacaactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xplacaactivperi = Value
			End Set
		End Property

		Public Property xsermotactivperi() As String
			Get
				Return Me.p_xsermotactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xsermotactivperi = Value
			End Set
		End Property

		Public Property xsercarractivperi() As String
			Get
				Return Me.p_xsercarractivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xsercarractivperi = Value
			End Set
		End Property

		Public Property xnumpolinsenc() As String
			Get
				Return Me.p_xnumpolinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xnumpolinsenc = Value
			End Set
		End Property

		Public Property xnumsininsenc() As String
			Get
				Return Me.p_xnumsininsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xnumsininsenc = Value
			End Set
		End Property

		Public Property xtelfmovilactivperi() As String
			Get
				Return Me.p_xtelfmovilactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xtelfmovilactivperi = Value
			End Set
		End Property

		Public Property xdescactivperi() As String
			Get
				Return Me.p_xdescactivperi
			End Get
			Set(ByVal Value As String)
				Me.p_xdescactivperi = Value
			End Set
		End Property

	End Class
	
	Public Class petivi_aipinsencdetpaglist

	Private p_pagvi_aipinsencdet As paginacion
	Private p_vi_aipinsencdet As vi_aipinsencdet

	Public Property pagvi_aipinsencdet() As paginacion
	Get
	Return Me.p_pagvi_aipinsencdet
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsencdet = Value
	End Set
	End Property

	Public Property vi_aipinsencdet() As vi_aipinsencdet
	Get
	Return Me.p_vi_aipinsencdet
	End Get
	Set(ByVal Value As vi_aipinsencdet)
	Me.p_vi_aipinsencdet = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinsencdetpaglist

	Private p_pagvi_aipinsencdet As paginacion
	Private p_lista_vi_aipinsencdet As  List(Of vi_aipinsencdet)

	Public Property pagvi_aipinsencdet() As paginacion
	Get
	Return Me.p_pagvi_aipinsencdet
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinsencdet = Value
	End Set
	End Property

	Public Property lista_vi_aipinsencdet() As List(Of vi_aipinsencdet)
	Get
	Return Me.p_lista_vi_aipinsencdet
	End Get
	Set(ByVal Value As List(Of vi_aipinsencdet))
	Me.p_lista_vi_aipinsencdet = Value
	End Set
	End Property
	End Class

End Namespace
