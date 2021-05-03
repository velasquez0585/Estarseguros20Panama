Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinsajusanexrepu

        Private p_idaipinsajusanexrepu As Decimal
        Private p_idaipinsajusanex As Decimal
        Private p_idaipbarerepu As Decimal
        Private p_ncantinsajusanexrepu As Int16
        Private p_nprecfininsajusanexrepu As Decimal
        Private p_xdescinsajusanexrepu As String
        Private p_iestatinsajusanexrepu As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsajusanex As aipinsajusanex
        Private p_aipbarerepu As aipbarerepu


        Public Property idaipinsajusanexrepu() As Decimal
            Get
                Return Me.p_idaipinsajusanexrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsajusanexrepu = Value
            End Set
        End Property

        Public Property idaipinsajusanex() As Decimal
            Get
                Return Me.p_idaipinsajusanex
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinsajusanex = Value
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

        Public Property ncantinsajusanexrepu() As Int16
            Get
                Return Me.p_ncantinsajusanexrepu
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinsajusanexrepu = Value
            End Set
        End Property

        Public Property nprecfininsajusanexrepu() As Decimal
            Get
                Return Me.p_nprecfininsajusanexrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininsajusanexrepu = Value
            End Set
        End Property

        Public Property xdescinsajusanexrepu() As String
            Get
                Return Me.p_xdescinsajusanexrepu
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinsajusanexrepu = Value
            End Set
        End Property

        Public Property iestatinsajusanexrepu() As String
            Get
                Return Me.p_iestatinsajusanexrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinsajusanexrepu = Value
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
        Public Property aipinsajusanex() As aipinsajusanex
            Get
                Return Me.p_aipinsajusanex
            End Get
            Set(ByVal Value As aipinsajusanex)
                Me.p_aipinsajusanex = Value
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

    Public Class petiaipinsajusanexrepupaglist

        Private p_pagaipinsajusanexrepu As paginacion
        Private p_aipinsajusanexrepu As aipinsajusanexrepu

        Public Property pagaipinsajusanexrepu() As paginacion
            Get
                Return Me.p_pagaipinsajusanexrepu
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinsajusanexrepu = Value
            End Set
        End Property

        Public Property aipinsajusanexrepu() As aipinsajusanexrepu
            Get
                Return Me.p_aipinsajusanexrepu
            End Get
            Set(ByVal Value As aipinsajusanexrepu)
                Me.p_aipinsajusanexrepu = Value
            End Set
        End Property
    End Class

    Public Class respaipinsajusanexrepupaglist

        Private p_pagaipinsajusanexrepu As paginacion
        Private p_lista_aipinsajusanexrepu As List(Of aipinsajusanexrepu)

        Public Property pagaipinsajusanexrepu() As paginacion
            Get
                Return Me.p_pagaipinsajusanexrepu
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinsajusanexrepu = Value
            End Set
        End Property

        Public Property lista_aipinsajusanexrepu() As List(Of aipinsajusanexrepu)
            Get
                Return Me.p_lista_aipinsajusanexrepu
            End Get
            Set(ByVal Value As List(Of aipinsajusanexrepu))
                Me.p_lista_aipinsajusanexrepu = Value
            End Set
        End Property
    End Class

End Namespace
