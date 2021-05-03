Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsajusanex

		Private p_idaipinsajusanex As Decimal
		Private p_idaipinsenc As Decimal
		Private p_isininsajusanex As Boolean
		Private p_irecupinsajusanex As Boolean
		Private p_itercinsajusanex As Boolean
		Private p_xnomaseginsajusanex As String
		Private p_idaipmanveh As Decimal
		Private p_xsucuinsajusanex As String
		Private p_nkiloinsajusanex As Int32
		Private p_xdescinsajusanex As String
		Private p_iestatinsajusanex As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As aipinsenc
        Private p_aipmanveh As aipmanveh
        Private p_aipinsajusanexmobr As List(Of aipinsajusanexmobr)
        Private p_aipinsajusanexrepu As List(Of aipinsajusanexrepu)

		Public Property idaipinsajusanex() As Decimal
			Get
				Return Me.p_idaipinsajusanex
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajusanex = Value
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

		Public Property isininsajusanex() As Boolean
			Get
				Return Me.p_isininsajusanex
			End Get
			Set(ByVal Value As Boolean)
				Me.p_isininsajusanex = Value
			End Set
		End Property

		Public Property irecupinsajusanex() As Boolean
			Get
				Return Me.p_irecupinsajusanex
			End Get
			Set(ByVal Value As Boolean)
				Me.p_irecupinsajusanex = Value
			End Set
		End Property

		Public Property itercinsajusanex() As Boolean
			Get
				Return Me.p_itercinsajusanex
			End Get
			Set(ByVal Value As Boolean)
				Me.p_itercinsajusanex = Value
			End Set
		End Property

		Public Property xnomaseginsajusanex() As String
			Get
				Return Me.p_xnomaseginsajusanex
			End Get
			Set(ByVal Value As String)
				Me.p_xnomaseginsajusanex = Value
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

		Public Property xsucuinsajusanex() As String
			Get
				Return Me.p_xsucuinsajusanex
			End Get
			Set(ByVal Value As String)
				Me.p_xsucuinsajusanex = Value
			End Set
		End Property

		Public Property nkiloinsajusanex() As Int32
			Get
				Return Me.p_nkiloinsajusanex
			End Get
			Set(ByVal Value As Int32)
				Me.p_nkiloinsajusanex = Value
			End Set
		End Property

		Public Property xdescinsajusanex() As String
			Get
				Return Me.p_xdescinsajusanex
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsajusanex = Value
			End Set
		End Property

		Public Property iestatinsajusanex() As String
			Get
				Return Me.p_iestatinsajusanex
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsajusanex = Value
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

        Public Property aipinsajusanexmobr() As List(Of aipinsajusanexmobr)
            Get
                Return Me.p_aipinsajusanexmobr
            End Get
            Set(ByVal Value As List(Of aipinsajusanexmobr))
                Me.p_aipinsajusanexmobr = Value
            End Set
        End Property

        Public Property aipinsajusanexrepu() As List(Of aipinsajusanexrepu)
            Get
                Return Me.p_aipinsajusanexrepu
            End Get
            Set(ByVal Value As List(Of aipinsajusanexrepu))
                Me.p_aipinsajusanexrepu = Value
            End Set
        End Property
    End Class
	
	Public Class petiaipinsajusanexpaglist

	Private p_pagaipinsajusanex As paginacion
	Private p_aipinsajusanex As aipinsajusanex

	Public Property pagaipinsajusanex() As paginacion
	Get
	Return Me.p_pagaipinsajusanex
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajusanex = Value
	End Set
	End Property

	Public Property aipinsajusanex() As aipinsajusanex
	Get
	Return Me.p_aipinsajusanex
	End Get
	Set(ByVal Value As aipinsajusanex)
	Me.p_aipinsajusanex = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsajusanexpaglist

	Private p_pagaipinsajusanex As paginacion
	Private p_lista_aipinsajusanex As  List(Of aipinsajusanex)

	Public Property pagaipinsajusanex() As paginacion
	Get
	Return Me.p_pagaipinsajusanex
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajusanex = Value
	End Set
	End Property

	Public Property lista_aipinsajusanex() As List(Of aipinsajusanex)
	Get
	Return Me.p_lista_aipinsajusanex
	End Get
	Set(ByVal Value As List(Of aipinsajusanex))
	Me.p_lista_aipinsajusanex = Value
	End Set
	End Property
	End Class

End Namespace
