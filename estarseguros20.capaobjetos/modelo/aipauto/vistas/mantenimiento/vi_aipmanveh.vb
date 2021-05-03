Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.mantenimiento

	Public Class vi_aipmanveh

		Private p_idaipmanveh As Decimal
		Private p_idaipmanvehmar As Decimal
		Private p_xnommanvehmar As String
		Private p_idaipmanvehmod As Decimal
		Private p_xnommanvehmod As String
		Private p_idaipmanvehver As Decimal
		Private p_xnommanvehver As String
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
		Private p_xdescmanveh As String
		Private p_iestatmanveh As String
        Private p_idseglogreg As Decimal
        Private p_naniomanvehver As Int16
        Private p_naniomanveh As Int16

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

		Public Property xnommanvehmar() As String
			Get
				Return Me.p_xnommanvehmar
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmar = Value
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

		Public Property xnommanvehmod() As String
			Get
				Return Me.p_xnommanvehmod
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehmod = Value
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

		Public Property xnommanvehver() As String
			Get
				Return Me.p_xnommanvehver
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanvehver = Value
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


        Public Property naniomanvehver() As Int16
            Get
                Return Me.p_naniomanvehver
            End Get
            Set(ByVal Value As Int16)
                Me.p_naniomanvehver = Value
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
	End Class
	
	Public Class petivi_aipmanvehpaglist

	Private p_pagvi_aipmanveh As paginacion
	Private p_vi_aipmanveh As vi_aipmanveh

	Public Property pagvi_aipmanveh() As paginacion
	Get
	Return Me.p_pagvi_aipmanveh
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanveh = Value
	End Set
	End Property

	Public Property vi_aipmanveh() As vi_aipmanveh
	Get
	Return Me.p_vi_aipmanveh
	End Get
	Set(ByVal Value As vi_aipmanveh)
	Me.p_vi_aipmanveh = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipmanvehpaglist

	Private p_pagvi_aipmanveh As paginacion
	Private p_lista_vi_aipmanveh As  List(Of vi_aipmanveh)

	Public Property pagvi_aipmanveh() As paginacion
	Get
	Return Me.p_pagvi_aipmanveh
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipmanveh = Value
	End Set
	End Property

	Public Property lista_vi_aipmanveh() As List(Of vi_aipmanveh)
	Get
	Return Me.p_lista_vi_aipmanveh
	End Get
	Set(ByVal Value As List(Of vi_aipmanveh))
	Me.p_lista_vi_aipmanveh = Value
	End Set
	End Property
	End Class

End Namespace
