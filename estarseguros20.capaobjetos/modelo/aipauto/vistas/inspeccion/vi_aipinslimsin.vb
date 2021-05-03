Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinslimsin

        Private p_idaipinslimsin As Decimal
        Private p_idaipinsenc As Decimal
		Private p_itipoinsenc As String
        Private p_idsegmanusuperit As Decimal
		Private p_xcedula As String
		Private p_xnombres As String
		Private p_xapellidos As String
		Private p_xnombrecompleto As String
		Private p_xcedpropinsenc As String
		Private p_xcedsidoinsenc As String
		Private p_xplacinsenc As String
		Private p_xsermotinsenc As String
		Private p_xsercarrinsenc As String
		Private p_xnumpolinsenc As String
		Private p_xnumsininsenc As String
		Private p_nfactinslimsin As Decimal
		Private p_irepuinslimsin As Boolean
		Private p_imobrinslimsin As Boolean
		Private p_xnomaseginslimsin As String
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
		Private p_xsucuinslimsin As String
		Private p_nkiloinslimsin As Int32
		Private p_xdescinslimsin As String
		Private p_iestatinslimsin As String
		Private p_idseglogreg As Decimal

		Public Property idaipinslimsin() As Decimal
			Get
				Return Me.p_idaipinslimsin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsin = Value
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

		Public Property itipoinsenc() As String
			Get
				Return Me.p_itipoinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_itipoinsenc = Value
			End Set
		End Property

        Public Property idsegmanusuperit() As Decimal
            Get
                Return Me.p_idsegmanusuperit
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusuperit = Value
            End Set
        End Property

		Public Property xcedula() As String
			Get
				Return Me.p_xcedula
			End Get
			Set(ByVal Value As String)
				Me.p_xcedula = Value
			End Set
		End Property

		Public Property xnombres() As String
			Get
				Return Me.p_xnombres
			End Get
			Set(ByVal Value As String)
				Me.p_xnombres = Value
			End Set
		End Property

		Public Property xapellidos() As String
			Get
				Return Me.p_xapellidos
			End Get
			Set(ByVal Value As String)
				Me.p_xapellidos = Value
			End Set
		End Property

		Public Property xnombrecompleto() As String
			Get
				Return Me.p_xnombrecompleto
			End Get
			Set(ByVal Value As String)
				Me.p_xnombrecompleto = Value
			End Set
		End Property

		Public Property xcedpropinsenc() As String
			Get
				Return Me.p_xcedpropinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xcedpropinsenc = Value
			End Set
		End Property

		Public Property xcedsidoinsenc() As String
			Get
				Return Me.p_xcedsidoinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xcedsidoinsenc = Value
			End Set
		End Property

		Public Property xplacinsenc() As String
			Get
				Return Me.p_xplacinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xplacinsenc = Value
			End Set
		End Property

		Public Property xsermotinsenc() As String
			Get
				Return Me.p_xsermotinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xsermotinsenc = Value
			End Set
		End Property

		Public Property xsercarrinsenc() As String
			Get
				Return Me.p_xsercarrinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xsercarrinsenc = Value
			End Set
		End Property

		Public Property xnumpolinsenc() As String
			Get
				Return Me.p_xnumpolinsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xnumpolinsenc = Value
			End Set
		End Property

		Public Property xnumsininsenc() As String
			Get
				Return Me.p_xnumsininsenc
			End Get
			Set(ByVal Value As String)
				Me.p_xnumsininsenc = Value
			End Set
		End Property

		Public Property nfactinslimsin() As Decimal
			Get
				Return Me.p_nfactinslimsin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nfactinslimsin = Value
			End Set
		End Property

		Public Property irepuinslimsin() As Boolean
			Get
				Return Me.p_irepuinslimsin
			End Get
			Set(ByVal Value As Boolean)
				Me.p_irepuinslimsin = Value
			End Set
		End Property

		Public Property imobrinslimsin() As Boolean
			Get
				Return Me.p_imobrinslimsin
			End Get
			Set(ByVal Value As Boolean)
				Me.p_imobrinslimsin = Value
			End Set
		End Property

		Public Property xnomaseginslimsin() As String
			Get
				Return Me.p_xnomaseginslimsin
			End Get
			Set(ByVal Value As String)
				Me.p_xnomaseginslimsin = Value
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

		Public Property xsucuinslimsin() As String
			Get
				Return Me.p_xsucuinslimsin
			End Get
			Set(ByVal Value As String)
				Me.p_xsucuinslimsin = Value
			End Set
		End Property

		Public Property nkiloinslimsin() As Int32
			Get
				Return Me.p_nkiloinslimsin
			End Get
			Set(ByVal Value As Int32)
				Me.p_nkiloinslimsin = Value
			End Set
		End Property

		Public Property xdescinslimsin() As String
			Get
				Return Me.p_xdescinslimsin
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinslimsin = Value
			End Set
		End Property

		Public Property iestatinslimsin() As String
			Get
				Return Me.p_iestatinslimsin
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinslimsin = Value
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
	
	Public Class petivi_aipinslimsinpaglist

	Private p_pagvi_aipinslimsin As paginacion
	Private p_vi_aipinslimsin As vi_aipinslimsin

	Public Property pagvi_aipinslimsin() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsin
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsin = Value
	End Set
	End Property

	Public Property vi_aipinslimsin() As vi_aipinslimsin
	Get
	Return Me.p_vi_aipinslimsin
	End Get
	Set(ByVal Value As vi_aipinslimsin)
	Me.p_vi_aipinslimsin = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinslimsinpaglist

	Private p_pagvi_aipinslimsin As paginacion
	Private p_lista_vi_aipinslimsin As  List(Of vi_aipinslimsin)

	Public Property pagvi_aipinslimsin() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsin
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsin = Value
	End Set
	End Property

	Public Property lista_vi_aipinslimsin() As List(Of vi_aipinslimsin)
	Get
	Return Me.p_lista_vi_aipinslimsin
	End Get
	Set(ByVal Value As List(Of vi_aipinslimsin))
	Me.p_lista_vi_aipinslimsin = Value
	End Set
	End Property
	End Class

End Namespace
