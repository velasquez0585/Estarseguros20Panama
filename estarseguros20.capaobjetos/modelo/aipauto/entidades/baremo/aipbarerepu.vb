Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace aipauto.modelo.dbestarseguros20.entidades.baremo

	Public Class aipbarerepu

		Private p_idaipbarerepu As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_faplibarerepu As DateTime
		Private p_iorigbarerepu As String
		Private p_mcostbarerepu As Decimal
		Private p_xdescbarerepu As String
		Private p_iestatbarerepu As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipmanrepu As aipmanrepu
        Private p_aipinsajusanexrepu As List(Of aipinsajusanexrepu)
        Private p_aipinsajussinrepu As List(Of aipinsajussinrepu)
        Private p_aipinslimsinrepu As List(Of aipinslimsinrepu)
        Private p_aipinslimsusrepu As List(Of aipinslimsusrepu)
        'Private p_aipinssinrepu As List(Of aipinssinrepu)


		Public Property idaipbarerepu() As Decimal
			Get
				Return Me.p_idaipbarerepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipbarerepu = Value
			End Set
		End Property

		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
			End Set
		End Property

		Public Property faplibarerepu() As DateTime
			Get
				Return Me.p_faplibarerepu
			End Get
			Set(ByVal Value As DateTime)
				Me.p_faplibarerepu = Value
			End Set
		End Property

		Public Property iorigbarerepu() As String
			Get
				Return Me.p_iorigbarerepu
			End Get
			Set(ByVal Value As String)
				Me.p_iorigbarerepu = Value
			End Set
		End Property

		Public Property mcostbarerepu() As Decimal
			Get
				Return Me.p_mcostbarerepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mcostbarerepu = Value
			End Set
		End Property

		Public Property xdescbarerepu() As String
			Get
				Return Me.p_xdescbarerepu
			End Get
			Set(ByVal Value As String)
				Me.p_xdescbarerepu = Value
			End Set
		End Property

		Public Property iestatbarerepu() As String
			Get
				Return Me.p_iestatbarerepu
			End Get
			Set(ByVal Value As String)
				Me.p_iestatbarerepu = Value
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
        Public Property aipmanrepu() As aipmanrepu
            Get
                Return Me.p_aipmanrepu
            End Get
            Set(ByVal Value As aipmanrepu)
                Me.p_aipmanrepu = Value
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

        Public Property aipinsajussinrepu() As List(Of aipinsajussinrepu)
            Get
                Return Me.p_aipinsajussinrepu
            End Get
            Set(ByVal Value As List(Of aipinsajussinrepu))
                Me.p_aipinsajussinrepu = Value
            End Set
        End Property

        Public Property aipinslimsinrepu() As List(Of aipinslimsinrepu)
            Get
                Return Me.p_aipinslimsinrepu
            End Get
            Set(ByVal Value As List(Of aipinslimsinrepu))
                Me.p_aipinslimsinrepu = Value
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

        'Public Property aipinssinrepu() As List(Of aipinssinrepu)
        '    Get
        '        Return Me.p_aipinssinrepu
        '    End Get
        '    Set(ByVal Value As List(Of aipinssinrepu))
        '        Me.p_aipinssinrepu = Value
        '    End Set
        'End Property

	End Class
	
	Public Class petiaipbarerepupaglist

	Private p_pagaipbarerepu As paginacion
	Private p_aipbarerepu As aipbarerepu

	Public Property pagaipbarerepu() As paginacion
	Get
	Return Me.p_pagaipbarerepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipbarerepu = Value
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
	
	Public Class respaipbarerepupaglist

	Private p_pagaipbarerepu As paginacion
	Private p_lista_aipbarerepu As  List(Of aipbarerepu)

	Public Property pagaipbarerepu() As paginacion
	Get
	Return Me.p_pagaipbarerepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipbarerepu = Value
	End Set
	End Property

	Public Property lista_aipbarerepu() As List(Of aipbarerepu)
	Get
	Return Me.p_lista_aipbarerepu
	End Get
	Set(ByVal Value As List(Of aipbarerepu))
	Me.p_lista_aipbarerepu = Value
	End Set
	End Property
	End Class

End Namespace
