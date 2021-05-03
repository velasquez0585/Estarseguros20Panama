Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsajussin

		Private p_idaipinsajussin As Decimal
		Private p_idaipinsenc As Decimal
		Private p_isininsajussin As Boolean
		Private p_irecupinsajussin As Boolean
		Private p_itercinsajussin As Boolean
		Private p_xnomaseginsajussin As String
		Private p_idaipmanveh As Decimal
		Private p_xsucuinsajussin As String
		Private p_nkiloinsajussin As Int32
		Private p_xdescinsajussin As String
		Private p_iestatinsajussin As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As aipinsenc
        Private p_aipmanveh As aipmanveh
        Private p_aipinsajussinmobr As List(Of aipinsajussinmobr)
        Private p_aipinsajussinrepu As List(Of aipinsajussinrepu)

		Public Property idaipinsajussin() As Decimal
			Get
				Return Me.p_idaipinsajussin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussin = Value
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

		Public Property isininsajussin() As Boolean
			Get
				Return Me.p_isininsajussin
			End Get
			Set(ByVal Value As Boolean)
				Me.p_isininsajussin = Value
			End Set
		End Property

		Public Property irecupinsajussin() As Boolean
			Get
				Return Me.p_irecupinsajussin
			End Get
			Set(ByVal Value As Boolean)
				Me.p_irecupinsajussin = Value
			End Set
		End Property

		Public Property itercinsajussin() As Boolean
			Get
				Return Me.p_itercinsajussin
			End Get
			Set(ByVal Value As Boolean)
				Me.p_itercinsajussin = Value
			End Set
		End Property

		Public Property xnomaseginsajussin() As String
			Get
				Return Me.p_xnomaseginsajussin
			End Get
			Set(ByVal Value As String)
				Me.p_xnomaseginsajussin = Value
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

		Public Property xsucuinsajussin() As String
			Get
				Return Me.p_xsucuinsajussin
			End Get
			Set(ByVal Value As String)
				Me.p_xsucuinsajussin = Value
			End Set
		End Property

		Public Property nkiloinsajussin() As Int32
			Get
				Return Me.p_nkiloinsajussin
			End Get
			Set(ByVal Value As Int32)
				Me.p_nkiloinsajussin = Value
			End Set
		End Property

		Public Property xdescinsajussin() As String
			Get
				Return Me.p_xdescinsajussin
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsajussin = Value
			End Set
		End Property

		Public Property iestatinsajussin() As String
			Get
				Return Me.p_iestatinsajussin
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsajussin = Value
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

        Public Property aipinsajussinmobr() As List(Of aipinsajussinmobr)
            Get
                Return Me.p_aipinsajussinmobr
            End Get
            Set(ByVal Value As List(Of aipinsajussinmobr))
                Me.p_aipinsajussinmobr = Value
            End Set
        End Property

        Public Property aipinsajussinrepu() As List(Of aipinsajussinrepu)
            Get
                Return Me.p_aipinsajussinrepu
            End Get
            Set(ByVal Value As List(Of aipinsajussinrepu))
                Me.p_aipinsajussinrepu = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipinsajussinpaglist

	Private p_pagaipinsajussin As paginacion
	Private p_aipinsajussin As aipinsajussin

	Public Property pagaipinsajussin() As paginacion
	Get
	Return Me.p_pagaipinsajussin
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajussin = Value
	End Set
	End Property

	Public Property aipinsajussin() As aipinsajussin
	Get
	Return Me.p_aipinsajussin
	End Get
	Set(ByVal Value As aipinsajussin)
	Me.p_aipinsajussin = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsajussinpaglist

	Private p_pagaipinsajussin As paginacion
	Private p_lista_aipinsajussin As  List(Of aipinsajussin)

	Public Property pagaipinsajussin() As paginacion
	Get
	Return Me.p_pagaipinsajussin
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajussin = Value
	End Set
	End Property

	Public Property lista_aipinsajussin() As List(Of aipinsajussin)
	Get
	Return Me.p_lista_aipinsajussin
	End Get
	Set(ByVal Value As List(Of aipinsajussin))
	Me.p_lista_aipinsajussin = Value
	End Set
	End Property
	End Class

End Namespace
