Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.log

	Public Class vi_aiplogeve

		Private p_idaiplogeve As Decimal
		Private p_xnomlogeve As String
		Private p_idsegmanusu As Decimal
		Private p_idcomunmanpers As Decimal
		Private p_xcedula As String
		Private p_xnombres As String
		Private p_xapellidos As String
		Private p_xnombrecompleto As String
		Private p_fcrealogeve As DateTime
		Private p_iamblogeve As String
		Private p_idseglogreg As Decimal

		Public Property idaiplogeve() As Decimal
			Get
				Return Me.p_idaiplogeve
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaiplogeve = Value
			End Set
		End Property

		Public Property xnomlogeve() As String
			Get
				Return Me.p_xnomlogeve
			End Get
			Set(ByVal Value As String)
				Me.p_xnomlogeve = Value
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

		Public Property idcomunmanpers() As Decimal
			Get
				Return Me.p_idcomunmanpers
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idcomunmanpers = Value
			End Set
		End Property

		Public Property xcedula() As String
			Get
				Return Me.p_xcedula
			End Get
			Set(ByVal Value As String)
				Me.p_xcedula = Value
			End Set
		End Property

		Public Property xnombres() As String
			Get
				Return Me.p_xnombres
			End Get
			Set(ByVal Value As String)
				Me.p_xnombres = Value
			End Set
		End Property

		Public Property xapellidos() As String
			Get
				Return Me.p_xapellidos
			End Get
			Set(ByVal Value As String)
				Me.p_xapellidos = Value
			End Set
		End Property

		Public Property xnombrecompleto() As String
			Get
				Return Me.p_xnombrecompleto
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompleto = Value
			End Set
		End Property

		Public Property fcrealogeve() As DateTime
			Get
				Return Me.p_fcrealogeve
			End Get
			Set(ByVal Value As DateTime)
				Me.p_fcrealogeve = Value
			End Set
		End Property

		Public Property iamblogeve() As String
			Get
				Return Me.p_iamblogeve
			End Get
			Set(ByVal Value As String)
				Me.p_iamblogeve = Value
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
	
	Public Class petivi_aiplogevepaglist

	Private p_pagvi_aiplogeve As paginacion
	Private p_vi_aiplogeve As vi_aiplogeve

	Public Property pagvi_aiplogeve() As paginacion
	Get
	Return Me.p_pagvi_aiplogeve
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aiplogeve = Value
	End Set
	End Property

	Public Property vi_aiplogeve() As vi_aiplogeve
	Get
	Return Me.p_vi_aiplogeve
	End Get
	Set(ByVal Value As vi_aiplogeve)
	Me.p_vi_aiplogeve = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aiplogevepaglist

	Private p_pagvi_aiplogeve As paginacion
	Private p_lista_vi_aiplogeve As  List(Of vi_aiplogeve)

	Public Property pagvi_aiplogeve() As paginacion
	Get
	Return Me.p_pagvi_aiplogeve
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aiplogeve = Value
	End Set
	End Property

	Public Property lista_vi_aiplogeve() As List(Of vi_aiplogeve)
	Get
	Return Me.p_lista_vi_aiplogeve
	End Get
	Set(ByVal Value As List(Of vi_aiplogeve))
	Me.p_lista_vi_aiplogeve = Value
	End Set
	End Property
	End Class

End Namespace
