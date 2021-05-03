Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanvehsse

		Private p_idaipmanvehsse As Decimal
        Private p_xnommanvehsse As String
        Private p_nordenmanvehsse As Short
		Private p_xdescmanvehsse As String
		Private p_iestatmanvehsse As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsrestsse As List(Of aipinsrestsse)
        Private p_aipinssussse As List(Of aipinssussse)

		Public Property idaipmanvehsse() As Decimal
			Get
				Return Me.p_idaipmanvehsse
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehsse = Value
			End Set
		End Property

		Public Property xnommanvehsse() As String
			Get
				Return Me.p_xnommanvehsse
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehsse = Value
			End Set
        End Property

        Public Property nordenmanvehsse() As Short
            Get
                Return Me.p_nordenmanvehsse
            End Get
            Set(ByVal Value As Short)
                Me.p_nordenmanvehsse = Value
            End Set
        End Property


		Public Property xdescmanvehsse() As String
			Get
				Return Me.p_xdescmanvehsse
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehsse = Value
			End Set
		End Property

		Public Property iestatmanvehsse() As String
			Get
				Return Me.p_iestatmanvehsse
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehsse = Value
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

        Public Property aipinsrestsse() As List(Of aipinsrestsse)
            Get
                Return Me.p_aipinsrestsse
            End Get
            Set(ByVal Value As List(Of aipinsrestsse))
                Me.p_aipinsrestsse = Value
            End Set
        End Property

        Public Property aipinssussse() As List(Of aipinssussse)
            Get
                Return Me.p_aipinssussse
            End Get
            Set(ByVal Value As List(Of aipinssussse))
                Me.p_aipinssussse = Value
            End Set
        End Property
	End Class
	
	Public Class petiaipmanvehssepaglist

	Private p_pagaipmanvehsse As paginacion
	Private p_aipmanvehsse As aipmanvehsse

	Public Property pagaipmanvehsse() As paginacion
	Get
	Return Me.p_pagaipmanvehsse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehsse = Value
	End Set
	End Property

	Public Property aipmanvehsse() As aipmanvehsse
	Get
	Return Me.p_aipmanvehsse
	End Get
	Set(ByVal Value As aipmanvehsse)
	Me.p_aipmanvehsse = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmanvehssepaglist

	Private p_pagaipmanvehsse As paginacion
	Private p_lista_aipmanvehsse As  List(Of aipmanvehsse)

	Public Property pagaipmanvehsse() As paginacion
	Get
	Return Me.p_pagaipmanvehsse
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehsse = Value
	End Set
	End Property

	Public Property lista_aipmanvehsse() As List(Of aipmanvehsse)
	Get
	Return Me.p_lista_aipmanvehsse
	End Get
	Set(ByVal Value As List(Of aipmanvehsse))
	Me.p_lista_aipmanvehsse = Value
	End Set
	End Property
	End Class

End Namespace
