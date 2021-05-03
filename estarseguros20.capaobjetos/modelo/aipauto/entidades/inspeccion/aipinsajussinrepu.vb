Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsajussinrepu

		Private p_idaipinsajussinrepu As Decimal
		Private p_idaipinsajussin As Decimal
		Private p_idaipbarerepu As Decimal
		Private p_ncantinsajussinrepu As Int16
		Private p_nprecfininsajussinrepu As Decimal
		Private p_xdescinsajussinrepu As String
		Private p_iestatinsajussinrepu As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsajussin As aipinsajussin
        Private p_aipbarerepu As aipbarerepu


		Public Property idaipinsajussinrepu() As Decimal
			Get
				Return Me.p_idaipinsajussinrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussinrepu = Value
			End Set
		End Property

		Public Property idaipinsajussin() As Decimal
			Get
				Return Me.p_idaipinsajussin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinsajussin = Value
			End Set
		End Property

		Public Property idaipbarerepu() As Decimal
			Get
				Return Me.p_idaipbarerepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipbarerepu = Value
			End Set
		End Property

		Public Property ncantinsajussinrepu() As Int16
			Get
				Return Me.p_ncantinsajussinrepu
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinsajussinrepu = Value
			End Set
		End Property

		Public Property nprecfininsajussinrepu() As Decimal
			Get
				Return Me.p_nprecfininsajussinrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininsajussinrepu = Value
			End Set
		End Property

		Public Property xdescinsajussinrepu() As String
			Get
				Return Me.p_xdescinsajussinrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinsajussinrepu = Value
			End Set
		End Property

		Public Property iestatinsajussinrepu() As String
			Get
				Return Me.p_iestatinsajussinrepu
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinsajussinrepu = Value
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
        Public Property aipinsajussin() As aipinsajussin
            Get
                Return Me.p_aipinsajussin
            End Get
            Set(ByVal Value As aipinsajussin)
                Me.p_aipinsajussin = Value
            End Set
        End Property

        Public Property aipbarerepu() As aipbarerepu
            Get
                Return Me.p_aipbarerepu
            End Get
            Set(ByVal Value As aipbarerepu)
                Me.p_aipbarerepu = Value
            End Set
        End Property

	End Class
	
	Public Class petiaipinsajussinrepupaglist

	Private p_pagaipinsajussinrepu As paginacion
	Private p_aipinsajussinrepu As aipinsajussinrepu

	Public Property pagaipinsajussinrepu() As paginacion
	Get
	Return Me.p_pagaipinsajussinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajussinrepu = Value
	End Set
	End Property

	Public Property aipinsajussinrepu() As aipinsajussinrepu
	Get
	Return Me.p_aipinsajussinrepu
	End Get
	Set(ByVal Value As aipinsajussinrepu)
	Me.p_aipinsajussinrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsajussinrepupaglist

	Private p_pagaipinsajussinrepu As paginacion
	Private p_lista_aipinsajussinrepu As  List(Of aipinsajussinrepu)

	Public Property pagaipinsajussinrepu() As paginacion
	Get
	Return Me.p_pagaipinsajussinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsajussinrepu = Value
	End Set
	End Property

	Public Property lista_aipinsajussinrepu() As List(Of aipinsajussinrepu)
	Get
	Return Me.p_lista_aipinsajussinrepu
	End Get
	Set(ByVal Value As List(Of aipinsajussinrepu))
	Me.p_lista_aipinsajussinrepu = Value
	End Set
	End Property
	End Class

End Namespace
