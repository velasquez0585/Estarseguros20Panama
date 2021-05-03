Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsrestssm

		Private p_idaipinsrestssm As Decimal
		Private p_idaipinsrest As Decimal
		Private p_idaipmanvehssm As Decimal
		Private p_iexisinsrestssm As Int32
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsrest As aipinsrest
        Private p_aipmanvehssm As aipmanvehssm


		Public Property idaipinsrestssm() As Decimal
			Get
				Return Me.p_idaipinsrestssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrestssm = Value
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

		Public Property idaipmanvehssm() As Decimal
			Get
				Return Me.p_idaipmanvehssm
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehssm = Value
			End Set
		End Property

		Public Property iexisinsrestssm() As Int32
			Get
				Return Me.p_iexisinsrestssm
			End Get
			Set(ByVal Value As Int32)
				Me.p_iexisinsrestssm = Value
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
        Public Property aipinsrest() As aipinsrest
            Get
                Return Me.p_aipinsrest
            End Get
            Set(ByVal Value As aipinsrest)
                Me.p_aipinsrest = Value
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
	
	Public Class petiaipinsrestssmpaglist

	Private p_pagaipinsrestssm As paginacion
	Private p_aipinsrestssm As aipinsrestssm

	Public Property pagaipinsrestssm() As paginacion
	Get
	Return Me.p_pagaipinsrestssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrestssm = Value
	End Set
	End Property

	Public Property aipinsrestssm() As aipinsrestssm
	Get
	Return Me.p_aipinsrestssm
	End Get
	Set(ByVal Value As aipinsrestssm)
	Me.p_aipinsrestssm = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsrestssmpaglist

	Private p_pagaipinsrestssm As paginacion
	Private p_lista_aipinsrestssm As  List(Of aipinsrestssm)

	Public Property pagaipinsrestssm() As paginacion
	Get
	Return Me.p_pagaipinsrestssm
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrestssm = Value
	End Set
	End Property

	Public Property lista_aipinsrestssm() As List(Of aipinsrestssm)
	Get
	Return Me.p_lista_aipinsrestssm
	End Get
	Set(ByVal Value As List(Of aipinsrestssm))
	Me.p_lista_aipinsrestssm = Value
	End Set
	End Property
	End Class

End Namespace
