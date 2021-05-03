Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace aipauto.modelo.dbestarseguros20.entidades.mantenimiento

	Public Class aipmanrepu

		Private p_idaipmanrepu As Decimal
		Private p_xnommanrepu As String
		Private p_ipartextdelmanrepu As Boolean
		Private p_ipartextmedmanrepu As Boolean
		Private p_ipartexttrasmanrepu As Boolean
		Private p_ipartintmanrepu As Boolean
		Private p_iposdermanrepu As Boolean
		Private p_iposizqmanrepu As Boolean
        Private p_iposfronmanrepu As Boolean
        Private p_nordenmanrepu As Short
		Private p_xdescmanrepu As String
		Private p_iestatmanrepu As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipbaremobr As List(Of aipbaremobr)
        Private p_aipbarerepu As List(Of aipbarerepu)
        Private p_aipinsrestrepuest As List(Of aipinsrestrepuest)
        Private p_aipinssusrepuest As List(Of aipinssusrepuest)
        Private p_aipinssinrepu As List(Of aipinssinrepu)
        Private p_aipinssinmobr As List(Of aipinssinmobr)


		Public Property idaipmanrepu() As Decimal
			Get
				Return Me.p_idaipmanrepu
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipmanrepu = Value
			End Set
		End Property

		Public Property xnommanrepu() As String
			Get
				Return Me.p_xnommanrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xnommanrepu = Value
			End Set
		End Property

		Public Property ipartextdelmanrepu() As Boolean
			Get
				Return Me.p_ipartextdelmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartextdelmanrepu = Value
			End Set
		End Property

		Public Property ipartextmedmanrepu() As Boolean
			Get
				Return Me.p_ipartextmedmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartextmedmanrepu = Value
			End Set
		End Property

		Public Property ipartexttrasmanrepu() As Boolean
			Get
				Return Me.p_ipartexttrasmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartexttrasmanrepu = Value
			End Set
		End Property

		Public Property ipartintmanrepu() As Boolean
			Get
				Return Me.p_ipartintmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_ipartintmanrepu = Value
			End Set
		End Property

		Public Property iposdermanrepu() As Boolean
			Get
				Return Me.p_iposdermanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iposdermanrepu = Value
			End Set
		End Property

		Public Property iposizqmanrepu() As Boolean
			Get
				Return Me.p_iposizqmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iposizqmanrepu = Value
			End Set
		End Property

		Public Property iposfronmanrepu() As Boolean
			Get
				Return Me.p_iposfronmanrepu
			End Get
			Set(ByVal Value As Boolean)
				Me.p_iposfronmanrepu = Value
			End Set
        End Property

        Public Property nordenmanrepu() As Short
            Get
                Return Me.p_nordenmanrepu
            End Get
            Set(ByVal Value As Short)
                Me.p_nordenmanrepu = Value
            End Set
        End Property

		Public Property xdescmanrepu() As String
			Get
				Return Me.p_xdescmanrepu
			End Get
			Set(ByVal Value As String)
				Me.p_xdescmanrepu = Value
			End Set
		End Property

		Public Property iestatmanrepu() As String
			Get
				Return Me.p_iestatmanrepu
			End Get
			Set(ByVal Value As String)
				Me.p_iestatmanrepu = Value
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
        Public Property aipbaremobr() As List(Of aipbaremobr)
            Get
                Return Me.p_aipbaremobr
            End Get
            Set(ByVal Value As List(Of aipbaremobr))
                Me.p_aipbaremobr = Value
            End Set
        End Property

        Public Property aipbarerepu() As List(Of aipbarerepu)
            Get
                Return Me.p_aipbarerepu
            End Get
            Set(ByVal Value As List(Of aipbarerepu))
                Me.p_aipbarerepu = Value
            End Set
        End Property

        Public Property aipinsrestrepuest() As List(Of aipinsrestrepuest)
            Get
                Return Me.p_aipinsrestrepuest
            End Get
            Set(ByVal Value As List(Of aipinsrestrepuest))
                Me.p_aipinsrestrepuest = Value
            End Set
        End Property

        Public Property aipinssusrepuest() As List(Of aipinssusrepuest)
            Get
                Return Me.p_aipinssusrepuest
            End Get
            Set(ByVal Value As List(Of aipinssusrepuest))
                Me.p_aipinssusrepuest = Value
            End Set
        End Property

        Public Property aipinssinrepu() As List(Of aipinssinrepu)
            Get
                Return Me.p_aipinssinrepu
            End Get
            Set(ByVal Value As List(Of aipinssinrepu))
                Me.p_aipinssinrepu = Value
            End Set
        End Property

        Public Property aipinssinmobr() As List(Of aipinssinmobr)
            Get
                Return Me.p_aipinssinmobr
            End Get
            Set(ByVal Value As List(Of aipinssinmobr))
                Me.p_aipinssinmobr = Value
            End Set
        End Property



	End Class
	
	Public Class petiaipmanrepupaglist

	Private p_pagaipmanrepu As paginacion
	Private p_aipmanrepu As aipmanrepu

	Public Property pagaipmanrepu() As paginacion
	Get
	Return Me.p_pagaipmanrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanrepu = Value
	End Set
	End Property

	Public Property aipmanrepu() As aipmanrepu
	Get
	Return Me.p_aipmanrepu
	End Get
	Set(ByVal Value As aipmanrepu)
	Me.p_aipmanrepu = Value
	End Set
	End Property
	End Class
	
	Public Class respaipmanrepupaglist

	Private p_pagaipmanrepu As paginacion
	Private p_lista_aipmanrepu As  List(Of aipmanrepu)

	Public Property pagaipmanrepu() As paginacion
	Get
	Return Me.p_pagaipmanrepu
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipmanrepu = Value
	End Set
	End Property

	Public Property lista_aipmanrepu() As List(Of aipmanrepu)
	Get
	Return Me.p_lista_aipmanrepu
	End Get
	Set(ByVal Value As List(Of aipmanrepu))
	Me.p_lista_aipmanrepu = Value
	End Set
	End Property
	End Class

End Namespace
