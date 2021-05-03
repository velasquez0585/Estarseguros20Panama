Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanvehssm

		Private p_idaipmanvehssm As Decimal
        Private p_xnommanvehssm As String
        Private p_nordenmanvehssm As Short
		Private p_xdescmanvehssm As String
		Private p_iestatmanvehssm As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsrestssm As List(Of aipinsrestssm)
        Private p_aipinssusssm As List(Of aipinssusssm)

		Public Property idaipmanvehssm() As Decimal
			Get
				Return Me.p_idaipmanvehssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehssm = Value
			End Set
		End Property

		Public Property xnommanvehssm() As String
			Get
				Return Me.p_xnommanvehssm
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehssm = Value
			End Set
        End Property

        Public Property nordenmanvehssm() As Short
            Get
                Return Me.p_nordenmanvehssm
            End Get
            Set(ByVal Value As Short)
                Me.p_nordenmanvehssm = Value
            End Set
        End Property


		Public Property xdescmanvehssm() As String
			Get
				Return Me.p_xdescmanvehssm
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanvehssm = Value
			End Set
		End Property

		Public Property iestatmanvehssm() As String
			Get
				Return Me.p_iestatmanvehssm
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanvehssm = Value
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
        Public Property aipinsrestssm() As List(Of aipinsrestssm)
            Get
                Return Me.p_aipinsrestssm
            End Get
            Set(ByVal Value As List(Of aipinsrestssm))
                Me.p_aipinsrestssm = Value
            End Set
        End Property

        Public Property aipinssusssm() As List(Of aipinssusssm)
            Get
                Return Me.p_aipinssusssm
            End Get
            Set(ByVal Value As List(Of aipinssusssm))
                Me.p_aipinssusssm = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipmanvehssmpaglist

	Private p_pagaipmanvehssm As paginacion
	Private p_aipmanvehssm As aipmanvehssm

	Public Property pagaipmanvehssm() As paginacion
	Get
	Return Me.p_pagaipmanvehssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehssm = Value
	End Set
	End Property

	Public Property aipmanvehssm() As aipmanvehssm
	Get
	Return Me.p_aipmanvehssm
	End Get
	Set(ByVal Value As aipmanvehssm)
	Me.p_aipmanvehssm = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmanvehssmpaglist

	Private p_pagaipmanvehssm As paginacion
	Private p_lista_aipmanvehssm As  List(Of aipmanvehssm)

	Public Property pagaipmanvehssm() As paginacion
	Get
	Return Me.p_pagaipmanvehssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanvehssm = Value
	End Set
	End Property

	Public Property lista_aipmanvehssm() As List(Of aipmanvehssm)
	Get
	Return Me.p_lista_aipmanvehssm
	End Get
	Set(ByVal Value As List(Of aipmanvehssm))
	Me.p_lista_aipmanvehssm = Value
	End Set
	End Property
	End Class

End Namespace
