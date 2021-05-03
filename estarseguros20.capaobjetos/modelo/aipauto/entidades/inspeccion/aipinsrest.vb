Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsrest

		Private p_idaipinsrest As Decimal
		Private p_idaipinsenc As Decimal
		Private p_idaipmanveh As Decimal
		Private p_xsucuinsrest As String
		Private p_nkiloinsrest As Int32
		Private p_idcomunmanestado As Decimal
		Private p_idcomunmanlocalid As Decimal
		Private p_xdirinsrest As String
		Private p_msumaseginsrest As Decimal
		Private p_msumaseg75insrest As Decimal
		Private p_mvalinminsrest As Decimal
		Private p_mdanoinsrest As Decimal
		Private p_mavalinsrest As Decimal
		Private p_xnomtalinsrest As String
		Private p_xnomperinsrest As String
		Private p_xnomjefperinsrest As String
		Private p_xdescinsrest As String
		Private p_iestatinsrest As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As aipinsenc
        Private p_aipmanveh As aipmanveh
        Private p_aipinsrestrepuest As List(Of aipinsrestrepuest)
        Private p_aipinsrestsse As List(Of aipinsrestsse)
        Private p_aipinsrestssm As List(Of aipinsrestssm)


		Public Property idaipinsrest() As Decimal
			Get
				Return Me.p_idaipinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsrest = Value
			End Set
		End Property

		Public Property idaipinsenc() As Decimal
			Get
				Return Me.p_idaipinsenc
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsenc = Value
			End Set
		End Property

		Public Property idaipmanveh() As Decimal
			Get
				Return Me.p_idaipmanveh
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanveh = Value
			End Set
		End Property

		Public Property xsucuinsrest() As String
			Get
				Return Me.p_xsucuinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xsucuinsrest = Value
			End Set
		End Property

		Public Property nkiloinsrest() As Int32
			Get
				Return Me.p_nkiloinsrest
			End Get
			Set(ByVal Value As Int32)
				Me.p_nkiloinsrest = Value
			End Set
		End Property

		Public Property idcomunmanestado() As Decimal
			Get
				Return Me.p_idcomunmanestado
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idcomunmanestado = Value
			End Set
		End Property

		Public Property idcomunmanlocalid() As Decimal
			Get
				Return Me.p_idcomunmanlocalid
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idcomunmanlocalid = Value
			End Set
		End Property

		Public Property xdirinsrest() As String
			Get
				Return Me.p_xdirinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xdirinsrest = Value
			End Set
		End Property

		Public Property msumaseginsrest() As Decimal
			Get
				Return Me.p_msumaseginsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_msumaseginsrest = Value
			End Set
		End Property

		Public Property msumaseg75insrest() As Decimal
			Get
				Return Me.p_msumaseg75insrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_msumaseg75insrest = Value
			End Set
		End Property

		Public Property mvalinminsrest() As Decimal
			Get
				Return Me.p_mvalinminsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mvalinminsrest = Value
			End Set
		End Property

		Public Property mdanoinsrest() As Decimal
			Get
				Return Me.p_mdanoinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mdanoinsrest = Value
			End Set
		End Property

		Public Property mavalinsrest() As Decimal
			Get
				Return Me.p_mavalinsrest
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mavalinsrest = Value
			End Set
		End Property

		Public Property xnomtalinsrest() As String
			Get
				Return Me.p_xnomtalinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xnomtalinsrest = Value
			End Set
		End Property

		Public Property xnomperinsrest() As String
			Get
				Return Me.p_xnomperinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xnomperinsrest = Value
			End Set
		End Property

		Public Property xnomjefperinsrest() As String
			Get
				Return Me.p_xnomjefperinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xnomjefperinsrest = Value
			End Set
		End Property

		Public Property xdescinsrest() As String
			Get
				Return Me.p_xdescinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsrest = Value
			End Set
		End Property

		Public Property iestatinsrest() As String
			Get
				Return Me.p_iestatinsrest
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsrest = Value
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

        Public Property aipinsenc() As aipinsenc
            Get
                Return Me.p_aipinsenc
            End Get
            Set(ByVal Value As aipinsenc)
                Me.p_aipinsenc = Value
            End Set
        End Property
        Public Property aipmanveh() As aipmanveh
            Get
                Return Me.p_aipmanveh
            End Get
            Set(ByVal Value As aipmanveh)
                Me.p_aipmanveh = Value
            End Set
        End Property

        Public Property aipinsrestrepuest() As List(Of aipinsrestrepuest)
            Get
                Return Me.p_aipinsrestrepuest
            End Get
            Set(ByVal Value As List(Of aipinsrestrepuest))
                Me.p_aipinsrestrepuest = Value
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

        Public Property aipinsrestssm() As List(Of aipinsrestssm)
            Get
                Return Me.p_aipinsrestssm
            End Get
            Set(ByVal Value As List(Of aipinsrestssm))
                Me.p_aipinsrestssm = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipinsrestpaglist

	Private p_pagaipinsrest As paginacion
	Private p_aipinsrest As aipinsrest

	Public Property pagaipinsrest() As paginacion
	Get
	Return Me.p_pagaipinsrest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrest = Value
	End Set
	End Property

	Public Property aipinsrest() As aipinsrest
	Get
	Return Me.p_aipinsrest
	End Get
	Set(ByVal Value As aipinsrest)
	Me.p_aipinsrest = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsrestpaglist

	Private p_pagaipinsrest As paginacion
	Private p_lista_aipinsrest As  List(Of aipinsrest)

	Public Property pagaipinsrest() As paginacion
	Get
	Return Me.p_pagaipinsrest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrest = Value
	End Set
	End Property

	Public Property lista_aipinsrest() As List(Of aipinsrest)
	Get
	Return Me.p_lista_aipinsrest
	End Get
	Set(ByVal Value As List(Of aipinsrest))
	Me.p_lista_aipinsrest = Value
	End Set
	End Property
	End Class

End Namespace
