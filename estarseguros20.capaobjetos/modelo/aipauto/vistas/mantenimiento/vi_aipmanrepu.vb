Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.mantenimiento

	Public Class vi_aipmanrepu

		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_ipartextdelmanrepu As Boolean
		Private p_ipartextmedmanrepu As Boolean
		Private p_ipartexttrasmanrepu As Boolean
		Private p_ipartintmanrepu As Boolean
		Private p_iposdermanrepu As Boolean
		Private p_iposizqmanrepu As Boolean
        Private p_iposfronmanrepu As Boolean
        Private p_nordenmanrepu As Short
		Private p_xdescmanrepu As String
		Private p_iestatmanrepu As String
		Private p_idseglogreg As Decimal

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
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

		Public Property ipartextdelmanrepu() As Boolean
			Get
				Return Me.p_ipartextdelmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartextdelmanrepu = Value
			End Set
		End Property

		Public Property ipartextmedmanrepu() As Boolean
			Get
				Return Me.p_ipartextmedmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartextmedmanrepu = Value
			End Set
		End Property

		Public Property ipartexttrasmanrepu() As Boolean
			Get
				Return Me.p_ipartexttrasmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartexttrasmanrepu = Value
			End Set
		End Property

		Public Property ipartintmanrepu() As Boolean
			Get
				Return Me.p_ipartintmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartintmanrepu = Value
			End Set
		End Property

		Public Property iposdermanrepu() As Boolean
			Get
				Return Me.p_iposdermanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iposdermanrepu = Value
			End Set
		End Property

		Public Property iposizqmanrepu() As Boolean
			Get
				Return Me.p_iposizqmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iposizqmanrepu = Value
			End Set
		End Property

		Public Property iposfronmanrepu() As Boolean
			Get
				Return Me.p_iposfronmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iposfronmanrepu = Value
			End Set
        End Property

        Public Property nordenmanrepu() As Short
            Get
                Return Me.p_nordenmanrepu
            End Get
            Set(ByVal Value As Short)
                Me.p_nordenmanrepu = Value
            End Set
        End Property

		Public Property xdescmanrepu() As String
			Get
				Return Me.p_xdescmanrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanrepu = Value
			End Set
		End Property

		Public Property iestatmanrepu() As String
			Get
				Return Me.p_iestatmanrepu
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanrepu = Value
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
	
	Public Class petivi_aipmanrepupaglist

	Private p_pagvi_aipmanrepu As paginacion
	Private p_vi_aipmanrepu As vi_aipmanrepu

	Public Property pagvi_aipmanrepu() As paginacion
	Get
	Return Me.p_pagvi_aipmanrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanrepu = Value
	End Set
	End Property

	Public Property vi_aipmanrepu() As vi_aipmanrepu
	Get
	Return Me.p_vi_aipmanrepu
	End Get
	Set(ByVal Value As vi_aipmanrepu)
	Me.p_vi_aipmanrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipmanrepupaglist

	Private p_pagvi_aipmanrepu As paginacion
	Private p_lista_vi_aipmanrepu As  List(Of vi_aipmanrepu)

	Public Property pagvi_aipmanrepu() As paginacion
	Get
	Return Me.p_pagvi_aipmanrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanrepu = Value
	End Set
	End Property

	Public Property lista_vi_aipmanrepu() As List(Of vi_aipmanrepu)
	Get
	Return Me.p_lista_vi_aipmanrepu
	End Get
	Set(ByVal Value As List(Of vi_aipmanrepu))
	Me.p_lista_vi_aipmanrepu = Value
	End Set
	End Property
	End Class

End Namespace
