Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.usuario
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmandisp

		Private p_idaipmandisp As Decimal
		Private p_xcodimmandisp As String
		Private p_xfabmandisp As String
		Private p_xmodmandisp As String
		Private p_itipomandisp As String
		Private p_xdescmandisp As String
		Private p_iestatmandisp As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipusudisp As List(Of aipusudisp)

		Public Property idaipmandisp() As Decimal
			Get
				Return Me.p_idaipmandisp
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmandisp = Value
			End Set
		End Property

		Public Property xcodimmandisp() As String
			Get
				Return Me.p_xcodimmandisp
			End Get
			Set(ByVal Value As String)
				Me.p_xcodimmandisp = Value
			End Set
		End Property

		Public Property xfabmandisp() As String
			Get
				Return Me.p_xfabmandisp
			End Get
			Set(ByVal Value As String)
				Me.p_xfabmandisp = Value
			End Set
		End Property

		Public Property xmodmandisp() As String
			Get
				Return Me.p_xmodmandisp
			End Get
			Set(ByVal Value As String)
				Me.p_xmodmandisp = Value
			End Set
		End Property

		Public Property itipomandisp() As String
			Get
				Return Me.p_itipomandisp
			End Get
			Set(ByVal Value As String)
				Me.p_itipomandisp = Value
			End Set
		End Property

		Public Property xdescmandisp() As String
			Get
				Return Me.p_xdescmandisp
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmandisp = Value
			End Set
		End Property

		Public Property iestatmandisp() As String
			Get
				Return Me.p_iestatmandisp
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmandisp = Value
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

        'relaciones
        Public Property aipusudisp() As List(Of aipusudisp)
            Get
                Return Me.p_aipusudisp
            End Get
            Set(ByVal Value As List(Of aipusudisp))
                Me.p_aipusudisp = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipmandisppaglist

	Private p_pagaipmandisp As paginacion
	Private p_aipmandisp As aipmandisp

	Public Property pagaipmandisp() As paginacion
	Get
	Return Me.p_pagaipmandisp
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmandisp = Value
	End Set
	End Property

	Public Property aipmandisp() As aipmandisp
	Get
	Return Me.p_aipmandisp
	End Get
	Set(ByVal Value As aipmandisp)
	Me.p_aipmandisp = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmandisppaglist

	Private p_pagaipmandisp As paginacion
	Private p_lista_aipmandisp As  List(Of aipmandisp)

	Public Property pagaipmandisp() As paginacion
	Get
	Return Me.p_pagaipmandisp
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmandisp = Value
	End Set
	End Property

	Public Property lista_aipmandisp() As List(Of aipmandisp)
	Get
	Return Me.p_lista_aipmandisp
	End Get
	Set(ByVal Value As List(Of aipmandisp))
	Me.p_lista_aipmandisp = Value
	End Set
	End Property
	End Class

End Namespace
