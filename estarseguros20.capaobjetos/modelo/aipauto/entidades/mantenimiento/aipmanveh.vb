Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanveh

		Private p_idaipmanveh As Decimal
		Private p_idaipmanvehmar As Decimal
		Private p_idaipmanvehmod As Decimal
		Private p_idaipmanvehver As Decimal
		Private p_itipotransmanveh As String
		Private p_itipomanveh As String
		Private p_iclasemanveh As String
		Private p_icolormanveh As String
		Private p_xplacamanveh As String
		Private p_xsercarrmanveh As String
		Private p_xsermotmanveh As String
		Private p_itraccmanveh As String
		Private p_iimpmanveh As Boolean
		Private p_ncilinmanveh As Int16
		Private p_xcargmanveh As String
        Private p_xcapmanveh As String
        Private p_naniomanveh As Int16
		Private p_xdescmanveh As String
		Private p_iestatmanveh As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipmanvehmar As aipmanvehmar
        Private p_aipmanvehmod As aipmanvehmod
        Private p_aipmanvehver As aipmanvehver
        Private p_aipinsajusanex As List(Of aipinsajusanex)
        Private p_aipinsajussin As List(Of aipinsajussin)
        Private p_aipinslimsin As List(Of aipinslimsin)
        Private p_aipinslimsus As List(Of aipinslimsus)
        Private p_aipinsrest As List(Of aipinsrest)
        Private p_aipinssus As List(Of aipinssus)
        Private p_aipinssin As List(Of aipinssin)

        Public Property idaipmanveh() As Decimal
            Get
                Return Me.p_idaipmanveh
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmanveh = Value
            End Set
        End Property

		Public Property idaipmanvehmar() As Decimal
			Get
				Return Me.p_idaipmanvehmar
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmar = Value
			End Set
		End Property

		Public Property idaipmanvehmod() As Decimal
			Get
				Return Me.p_idaipmanvehmod
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehmod = Value
			End Set
		End Property

		Public Property idaipmanvehver() As Decimal
			Get
				Return Me.p_idaipmanvehver
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanvehver = Value
			End Set
		End Property

		Public Property itipotransmanveh() As String
			Get
				Return Me.p_itipotransmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_itipotransmanveh = Value
			End Set
		End Property

		Public Property itipomanveh() As String
			Get
				Return Me.p_itipomanveh
			End Get
			Set(ByVal Value As String)
				Me.p_itipomanveh = Value
			End Set
		End Property

		Public Property iclasemanveh() As String
			Get
				Return Me.p_iclasemanveh
			End Get
			Set(ByVal Value As String)
				Me.p_iclasemanveh = Value
			End Set
		End Property

		Public Property icolormanveh() As String
			Get
				Return Me.p_icolormanveh
			End Get
			Set(ByVal Value As String)
				Me.p_icolormanveh = Value
			End Set
		End Property

		Public Property xplacamanveh() As String
			Get
				Return Me.p_xplacamanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xplacamanveh = Value
			End Set
		End Property

		Public Property xsercarrmanveh() As String
			Get
				Return Me.p_xsercarrmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xsercarrmanveh = Value
			End Set
		End Property

		Public Property xsermotmanveh() As String
			Get
				Return Me.p_xsermotmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xsermotmanveh = Value
			End Set
		End Property

		Public Property itraccmanveh() As String
			Get
				Return Me.p_itraccmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_itraccmanveh = Value
			End Set
		End Property

		Public Property iimpmanveh() As Boolean
			Get
				Return Me.p_iimpmanveh
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iimpmanveh = Value
			End Set
		End Property

		Public Property ncilinmanveh() As Int16
			Get
				Return Me.p_ncilinmanveh
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncilinmanveh = Value
			End Set
		End Property

		Public Property xcargmanveh() As String
			Get
				Return Me.p_xcargmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xcargmanveh = Value
			End Set
		End Property

		Public Property xcapmanveh() As String
			Get
				Return Me.p_xcapmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xcapmanveh = Value
			End Set
        End Property

        Public Property naniomanveh() As Int16
            Get
                Return Me.p_naniomanveh
            End Get
            Set(ByVal Value As Int16)
                Me.p_naniomanveh = Value
            End Set
        End Property

		Public Property xdescmanveh() As String
			Get
				Return Me.p_xdescmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanveh = Value
			End Set
		End Property

		Public Property iestatmanveh() As String
			Get
				Return Me.p_iestatmanveh
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanveh = Value
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
        Public Property aipmanvehmar() As aipmanvehmar
            Get
                Return Me.p_aipmanvehmar
            End Get
            Set(ByVal Value As aipmanvehmar)
                Me.p_aipmanvehmar = Value
            End Set
        End Property

        Public Property aipmanvehmod() As aipmanvehmod
            Get
                Return Me.p_aipmanvehmod
            End Get
            Set(ByVal Value As aipmanvehmod)
                Me.p_aipmanvehmod = Value
            End Set
        End Property

        Public Property aipmanvehver() As aipmanvehver
            Get
                Return Me.p_aipmanvehver
            End Get
            Set(ByVal Value As aipmanvehver)
                Me.p_aipmanvehver = Value
            End Set
        End Property

        Public Property aipinsajusanex() As List(Of aipinsajusanex)
            Get
                Return Me.p_aipinsajusanex
            End Get
            Set(ByVal Value As List(Of aipinsajusanex))
                Me.p_aipinsajusanex = Value
            End Set
        End Property

        Public Property aipinsajussin() As List(Of aipinsajussin)
            Get
                Return Me.p_aipinsajussin
            End Get
            Set(ByVal Value As List(Of aipinsajussin))
                Me.p_aipinsajussin = Value
            End Set
        End Property

        Public Property aipinslimsin() As List(Of aipinslimsin)
            Get
                Return Me.p_aipinslimsin
            End Get
            Set(ByVal Value As List(Of aipinslimsin))
                Me.p_aipinslimsin = Value
            End Set
        End Property

        Public Property aipinslimsus() As List(Of aipinslimsus)
            Get
                Return Me.p_aipinslimsus
            End Get
            Set(ByVal Value As List(Of aipinslimsus))
                Me.p_aipinslimsus = Value
            End Set
        End Property

        Public Property aipinsrest() As List(Of aipinsrest)
            Get
                Return Me.p_aipinsrest
            End Get
            Set(ByVal Value As List(Of aipinsrest))
                Me.p_aipinsrest = Value
            End Set
        End Property

        Public Property aipinssin() As List(Of aipinssin)
            Get
                Return Me.p_aipinssin
            End Get
            Set(ByVal Value As List(Of aipinssin))
                Me.p_aipinssin = Value
            End Set
        End Property


        Public Property aipinssus() As List(Of aipinssus)
            Get
                Return Me.p_aipinssus
            End Get
            Set(ByVal Value As List(Of aipinssus))
                Me.p_aipinssus = Value
            End Set
        End Property
	End Class
	
	Public Class petiaipmanvehpaglist

	Private p_pagaipmanveh As paginacion
	Private p_aipmanveh As aipmanveh

	Public Property pagaipmanveh() As paginacion
	Get
	Return Me.p_pagaipmanveh
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanveh = Value
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
	End Class
	
	Public Class respaipmanvehpaglist

	Private p_pagaipmanveh As paginacion
	Private p_lista_aipmanveh As  List(Of aipmanveh)

	Public Property pagaipmanveh() As paginacion
	Get
	Return Me.p_pagaipmanveh
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanveh = Value
	End Set
	End Property

	Public Property lista_aipmanveh() As List(Of aipmanveh)
	Get
	Return Me.p_lista_aipmanveh
	End Get
	Set(ByVal Value As List(Of aipmanveh))
	Me.p_lista_aipmanveh = Value
	End Set
	End Property
	End Class

End Namespace
