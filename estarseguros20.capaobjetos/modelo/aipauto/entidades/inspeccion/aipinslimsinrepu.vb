Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinslimsinrepu

		Private p_idaipinslimsinrepu As Decimal
		Private p_idaipinslimsin As Decimal
		Private p_idaipbarerepu As Decimal
		Private p_ncantinslimsinrepu As Int16
		Private p_nprecfininslimsinrepu As Decimal
		Private p_xdescinslimsinrepu As String
		Private p_iestatinslimsinrepu As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinslimsin As aipinslimsin
        Private p_aipbarerepu As aipbarerepu

		Public Property idaipinslimsinrepu() As Decimal
			Get
				Return Me.p_idaipinslimsinrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsinrepu = Value
			End Set
		End Property

		Public Property idaipinslimsin() As Decimal
			Get
				Return Me.p_idaipinslimsin
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipinslimsin = Value
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

		Public Property ncantinslimsinrepu() As Int16
			Get
				Return Me.p_ncantinslimsinrepu
			End Get
			Set(ByVal Value As Int16)
				Me.p_ncantinslimsinrepu = Value
			End Set
		End Property

		Public Property nprecfininslimsinrepu() As Decimal
			Get
				Return Me.p_nprecfininslimsinrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_nprecfininslimsinrepu = Value
			End Set
		End Property

		Public Property xdescinslimsinrepu() As String
			Get
				Return Me.p_xdescinslimsinrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xdescinslimsinrepu = Value
			End Set
		End Property

		Public Property iestatinslimsinrepu() As String
			Get
				Return Me.p_iestatinslimsinrepu
			End Get
			Set(ByVal Value As String)
				Me.p_iestatinslimsinrepu = Value
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
        Public Property aipinslimsin() As aipinslimsin
            Get
                Return Me.p_aipinslimsin
            End Get
            Set(ByVal Value As aipinslimsin)
                Me.p_aipinslimsin = Value
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
	
	Public Class petiaipinslimsinrepupaglist

	Private p_pagaipinslimsinrepu As paginacion
	Private p_aipinslimsinrepu As aipinslimsinrepu

	Public Property pagaipinslimsinrepu() As paginacion
	Get
	Return Me.p_pagaipinslimsinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinslimsinrepu = Value
	End Set
	End Property

	Public Property aipinslimsinrepu() As aipinslimsinrepu
	Get
	Return Me.p_aipinslimsinrepu
	End Get
	Set(ByVal Value As aipinslimsinrepu)
	Me.p_aipinslimsinrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinslimsinrepupaglist

	Private p_pagaipinslimsinrepu As paginacion
	Private p_lista_aipinslimsinrepu As  List(Of aipinslimsinrepu)

	Public Property pagaipinslimsinrepu() As paginacion
	Get
	Return Me.p_pagaipinslimsinrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinslimsinrepu = Value
	End Set
	End Property

	Public Property lista_aipinslimsinrepu() As List(Of aipinslimsinrepu)
	Get
	Return Me.p_lista_aipinslimsinrepu
	End Get
	Set(ByVal Value As List(Of aipinslimsinrepu))
	Me.p_lista_aipinslimsinrepu = Value
	End Set
	End Property
	End Class

End Namespace
