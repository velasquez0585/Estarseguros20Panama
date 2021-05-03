Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Namespace aipauto.modelo.dbestarseguros20.entidades.baremo

	Public Class aipbaremobr

		Private p_idaipbaremobr As Decimal
		Private p_idaipmanrepu As Decimal
		Private p_faplibaremobr As DateTime
		Private p_itipobaremobr As String
		Private p_itamapiezbaremobr As String
		Private p_imaterpiezbaremobr As String
		Private p_mcostbaremobr As Decimal
		Private p_xdescbaremobr As String
		Private p_iestatbaremobr As String
		Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipmanrepu As aipmanrepu
        Private p_aipinsajusanexmobr As List(Of aipinsajusanexmobr)
        Private p_aipinsajussinmobr As List(Of aipinsajussinmobr)
        Private p_aipinslimsinmobr As List(Of aipinslimsinmobr)
        Private p_aipinslimsusmobr As List(Of aipinslimsusmobr)
        'Private p_aipinssinmobr As List(Of aipinssinmobr)




		Public Property idaipbaremobr() As Decimal
			Get
				Return Me.p_idaipbaremobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_idaipbaremobr = Value
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

		Public Property faplibaremobr() As DateTime
			Get
				Return Me.p_faplibaremobr
			End Get
			Set(ByVal Value As DateTime)
				Me.p_faplibaremobr = Value
			End Set
		End Property

		Public Property itipobaremobr() As String
			Get
				Return Me.p_itipobaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_itipobaremobr = Value
			End Set
		End Property

		Public Property itamapiezbaremobr() As String
			Get
				Return Me.p_itamapiezbaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_itamapiezbaremobr = Value
			End Set
		End Property

		Public Property imaterpiezbaremobr() As String
			Get
				Return Me.p_imaterpiezbaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_imaterpiezbaremobr = Value
			End Set
		End Property

		Public Property mcostbaremobr() As Decimal
			Get
				Return Me.p_mcostbaremobr
			End Get
			Set(ByVal Value As Decimal)
				Me.p_mcostbaremobr = Value
			End Set
		End Property

		Public Property xdescbaremobr() As String
			Get
				Return Me.p_xdescbaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_xdescbaremobr = Value
			End Set
		End Property

		Public Property iestatbaremobr() As String
			Get
				Return Me.p_iestatbaremobr
			End Get
			Set(ByVal Value As String)
				Me.p_iestatbaremobr = Value
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

        Public Property aipinsajusanexmobr() As List(Of aipinsajusanexmobr)
            Get
                Return Me.p_aipinsajusanexmobr
            End Get
            Set(ByVal Value As List(Of aipinsajusanexmobr))
                Me.p_aipinsajusanexmobr = Value
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

        Public Property aipinslimsinmobr() As List(Of aipinslimsinmobr)
            Get
                Return Me.p_aipinslimsinmobr
            End Get
            Set(ByVal Value As List(Of aipinslimsinmobr))
                Me.p_aipinslimsinmobr = Value
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

        'Public Property aipinssinmobr() As List(Of aipinssinmobr)
        '    Get
        '        Return Me.p_aipinssinmobr
        '    End Get
        '    Set(ByVal Value As List(Of aipinssinmobr))
        '        Me.p_aipinssinmobr = Value
        '    End Set
        'End Property

	End Class
	
	Public Class petiaipbaremobrpaglist

	Private p_pagaipbaremobr As paginacion
	Private p_aipbaremobr As aipbaremobr

	Public Property pagaipbaremobr() As paginacion
	Get
	Return Me.p_pagaipbaremobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipbaremobr = Value
	End Set
	End Property

	Public Property aipbaremobr() As aipbaremobr
	Get
	Return Me.p_aipbaremobr
	End Get
	Set(ByVal Value As aipbaremobr)
	Me.p_aipbaremobr = Value
	End Set
	End Property
	End Class
	
	Public Class respaipbaremobrpaglist

	Private p_pagaipbaremobr As paginacion
	Private p_lista_aipbaremobr As  List(Of aipbaremobr)

	Public Property pagaipbaremobr() As paginacion
	Get
	Return Me.p_pagaipbaremobr
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipbaremobr = Value
	End Set
	End Property

	Public Property lista_aipbaremobr() As List(Of aipbaremobr)
	Get
	Return Me.p_lista_aipbaremobr
	End Get
	Set(ByVal Value As List(Of aipbaremobr))
	Me.p_lista_aipbaremobr = Value
	End Set
	End Property
	End Class

End Namespace
