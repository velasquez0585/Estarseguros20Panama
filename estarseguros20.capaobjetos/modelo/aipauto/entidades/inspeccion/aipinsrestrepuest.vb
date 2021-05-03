Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

	Public Class aipinsrestrepuest

        Private p_idaipinsrestrepuest As Decimal
        Private p_idaipinsrest As Decimal
        Private p_idaipmanrepu As Decimal
        Private p_xnominsrestrepuest As String
        Private p_iexisinsrestrepuest As Boolean
        Private p_ibueinsrestrepuest As Boolean
        Private p_ireginsrestrepuest As Boolean
        Private p_imalinsrestrepuest As Boolean
        Private p_iestinsrestrepuest As String
        Private p_xdescinsrestrepuest As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsrest As aipinsrest
        Private p_aipmanrepu As aipmanrepu

        Public Property idaipinsrestrepuest() As Decimal
            Get
                Return Me.p_idaipinsrestrepuest
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsrestrepuest = Value
            End Set
        End Property

        Public Property idaipinsrest() As Decimal
            Get
                Return Me.p_idaipinsrest
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsrest = Value
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

        Public Property xnominsrestrepuest() As String
            Get
                Return Me.p_xnominsrestrepuest
            End Get
            Set(ByVal Value As String)
                Me.p_xnominsrestrepuest = Value
            End Set
        End Property

        Public Property iexisinsrestrepuest() As Boolean
            Get
                Return Me.p_iexisinsrestrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_iexisinsrestrepuest = Value
            End Set
        End Property

        Public Property ibueinsrestrepuest() As Boolean
            Get
                Return Me.p_ibueinsrestrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ibueinsrestrepuest = Value
            End Set
        End Property

        Public Property ireginsrestrepuest() As Boolean
            Get
                Return Me.p_ireginsrestrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_ireginsrestrepuest = Value
            End Set
        End Property

        Public Property imalinsrestrepuest() As Boolean
            Get
                Return Me.p_imalinsrestrepuest
            End Get
            Set(ByVal Value As Boolean)
                Me.p_imalinsrestrepuest = Value
            End Set
        End Property

        Public Property iestinsrestrepuest() As String
            Get
                Return Me.p_iestinsrestrepuest
            End Get
            Set(ByVal Value As String)
                Me.p_iestinsrestrepuest = Value
            End Set
        End Property

        Public Property xdescinsrestrepuest() As String
            Get
                Return Me.p_xdescinsrestrepuest
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinsrestrepuest = Value
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
        Public Property aipinsrest() As aipinsrest
            Get
                Return Me.p_aipinsrest
            End Get
            Set(ByVal Value As aipinsrest)
                Me.p_aipinsrest = Value
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
	
	Public Class petiaipinsrestrepuestpaglist

	Private p_pagaipinsrestrepuest As paginacion
	Private p_aipinsrestrepuest As aipinsrestrepuest

	Public Property pagaipinsrestrepuest() As paginacion
	Get
	Return Me.p_pagaipinsrestrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrestrepuest = Value
	End Set
	End Property

	Public Property aipinsrestrepuest() As aipinsrestrepuest
	Get
	Return Me.p_aipinsrestrepuest
	End Get
	Set(ByVal Value As aipinsrestrepuest)
	Me.p_aipinsrestrepuest = Value
	End Set
	End Property
	End Class
	
	Public Class respaipinsrestrepuestpaglist

	Private p_pagaipinsrestrepuest As paginacion
	Private p_lista_aipinsrestrepuest As  List(Of aipinsrestrepuest)

	Public Property pagaipinsrestrepuest() As paginacion
	Get
	Return Me.p_pagaipinsrestrepuest
	End Get
	Set(ByVal Value As paginacion)
	Me.p_pagaipinsrestrepuest = Value
	End Set
	End Property

	Public Property lista_aipinsrestrepuest() As List(Of aipinsrestrepuest)
	Get
	Return Me.p_lista_aipinsrestrepuest
	End Get
	Set(ByVal Value As List(Of aipinsrestrepuest))
	Me.p_lista_aipinsrestrepuest = Value
	End Set
	End Property
	End Class

End Namespace
