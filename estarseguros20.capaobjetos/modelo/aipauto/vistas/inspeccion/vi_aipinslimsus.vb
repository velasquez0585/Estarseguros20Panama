Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.inspeccion

	Public Class vi_aipinslimsus

        Private p_idaipinslimsus As Decimal
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

	End Class
	
	Public Class petivi_aipinslimsuspaglist

	Private p_pagvi_aipinslimsus As paginacion
	Private p_vi_aipinslimsus As vi_aipinslimsus

	Public Property pagvi_aipinslimsus() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsus
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsus = Value
	End Set
	End Property

	Public Property vi_aipinslimsus() As vi_aipinslimsus
	Get
	Return Me.p_vi_aipinslimsus
	End Get
	Set(ByVal Value As vi_aipinslimsus)
	Me.p_vi_aipinslimsus = Value
	End Set
	End Property
	End Class
	
	Public Class respvi_aipinslimsuspaglist

	Private p_pagvi_aipinslimsus As paginacion
	Private p_lista_vi_aipinslimsus As  List(Of vi_aipinslimsus)

	Public Property pagvi_aipinslimsus() As paginacion
	Get
	Return Me.p_pagvi_aipinslimsus
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagvi_aipinslimsus = Value
	End Set
	End Property

	Public Property lista_vi_aipinslimsus() As List(Of vi_aipinslimsus)
	Get
	Return Me.p_lista_vi_aipinslimsus
	End Get
	Set(ByVal Value As List(Of vi_aipinslimsus))
	Me.p_lista_vi_aipinslimsus = Value
	End Set
	End Property
	End Class

End Namespace
