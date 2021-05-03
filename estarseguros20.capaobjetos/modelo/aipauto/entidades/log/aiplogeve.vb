Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.entidades.log

	Public Class aiplogeve

		Private p_idaiplogeve As Decimal
		Private p_xnomlogeve As String
		Private p_idsegmanusu As Decimal
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
	
	Public Class petiaiplogevepaglist

	Private p_pagaiplogeve As paginacion
	Private p_aiplogeve As aiplogeve

	Public Property pagaiplogeve() As paginacion
	Get
	Return Me.p_pagaiplogeve
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaiplogeve = Value
	End Set
	End Property

	Public Property aiplogeve() As aiplogeve
	Get
	Return Me.p_aiplogeve
	End Get
	Set(ByVal Value As aiplogeve)
	Me.p_aiplogeve = Value
	End Set
	End Property
	End Class
	
	Public Class respaiplogevepaglist

	Private p_pagaiplogeve As paginacion
	Private p_lista_aiplogeve As  List(Of aiplogeve)

	Public Property pagaiplogeve() As paginacion
	Get
	Return Me.p_pagaiplogeve
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaiplogeve = Value
	End Set
	End Property

	Public Property lista_aiplogeve() As List(Of aiplogeve)
	Get
	Return Me.p_lista_aiplogeve
	End Get
	Set(ByVal Value As List(Of aiplogeve))
	Me.p_lista_aiplogeve = Value
	End Set
	End Property
	End Class

End Namespace
