Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinslimsus

		Private p_idaipinslimsus As Decimal
        Private p_idaipinsenc As Decimal
		Private p_nfactinslimsus As Decimal
		Private p_irepuinslimsus As Boolean
		Private p_imobrinslimsus As Boolean
		Private p_xnomaseginslimsus As String
		Private p_idaipmanveh As Decimal
		Private p_xsucuinslimsus As String
		Private p_nkiloinslimsus As Int32
		Private p_xdescinslimsus As String
		Private p_iestatinslimsus As String
        Private p_idseglogreg As Decimal

        'relaciones        
        Private p_aipinsenc As aipinsenc
        Private p_aipmanveh As aipmanveh
        Private p_aipinslimsusmobr As List(Of aipinslimsusmobr)
        Private p_aipinslimsusrepu As List(Of aipinslimsusrepu)

		Public Property idaipinslimsus() As Decimal
			Get
				Return Me.p_idaipinslimsus
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsus = Value
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

		Public Property nfactinslimsus() As Decimal
			Get
				Return Me.p_nfactinslimsus
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nfactinslimsus = Value
			End Set
		End Property

		Public Property irepuinslimsus() As Boolean
			Get
				Return Me.p_irepuinslimsus
			End Get
			Set(ByVal Value As Boolean)
				Me.p_irepuinslimsus = Value
			End Set
		End Property

		Public Property imobrinslimsus() As Boolean
			Get
				Return Me.p_imobrinslimsus
			End Get
			Set(ByVal Value As Boolean)
				Me.p_imobrinslimsus = Value
			End Set
		End Property

		Public Property xnomaseginslimsus() As String
			Get
				Return Me.p_xnomaseginslimsus
			End Get
			Set(ByVal Value As String)
				Me.p_xnomaseginslimsus = Value
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

		Public Property xsucuinslimsus() As String
			Get
				Return Me.p_xsucuinslimsus
			End Get
			Set(ByVal Value As String)
				Me.p_xsucuinslimsus = Value
			End Set
		End Property

		Public Property nkiloinslimsus() As Int32
			Get
				Return Me.p_nkiloinslimsus
			End Get
			Set(ByVal Value As Int32)
				Me.p_nkiloinslimsus = Value
			End Set
		End Property

		Public Property xdescinslimsus() As String
			Get
				Return Me.p_xdescinslimsus
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinslimsus = Value
			End Set
		End Property

		Public Property iestatinslimsus() As String
			Get
				Return Me.p_iestatinslimsus
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinslimsus = Value
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
        Public Property aipinslimsusmobr() As List(Of aipinslimsusmobr)
            Get
                Return Me.p_aipinslimsusmobr
            End Get
            Set(ByVal Value As List(Of aipinslimsusmobr))
                Me.p_aipinslimsusmobr = Value
            End Set
        End Property
        Public Property aipinslimsusrepu() As List(Of aipinslimsusrepu)
            Get
                Return Me.p_aipinslimsusrepu
            End Get
            Set(ByVal Value As List(Of aipinslimsusrepu))
                Me.p_aipinslimsusrepu = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipinslimsuspaglist

	Private p_pagaipinslimsus As paginacion
	Private p_aipinslimsus As aipinslimsus

	Public Property pagaipinslimsus() As paginacion
	Get
	Return Me.p_pagaipinslimsus
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinslimsus = Value
	End Set
	End Property

	Public Property aipinslimsus() As aipinslimsus
	Get
	Return Me.p_aipinslimsus
	End Get
	Set(ByVal Value As aipinslimsus)
	Me.p_aipinslimsus = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinslimsuspaglist

	Private p_pagaipinslimsus As paginacion
	Private p_lista_aipinslimsus As  List(Of aipinslimsus)

	Public Property pagaipinslimsus() As paginacion
	Get
	Return Me.p_pagaipinslimsus
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinslimsus = Value
	End Set
	End Property

	Public Property lista_aipinslimsus() As List(Of aipinslimsus)
	Get
	Return Me.p_lista_aipinslimsus
	End Get
	Set(ByVal Value As List(Of aipinslimsus))
	Me.p_lista_aipinslimsus = Value
	End Set
	End Property
	End Class

End Namespace
