Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinslimsusrepu

        Private p_idaipinslimsusrepu As Decimal
        Private p_idaipinslimsus As Decimal
        Private p_idaipbarerepu As Decimal
        Private p_ncantinslimsusrepu As Int16
        Private p_nprecfininslimsusrepu As Decimal
        Private p_xdescinslimsusrepu As String
        Private p_iestatinslimsusrepu As String
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinslimsus As aipinslimsus
        Private p_aipbarerepu As aipbarerepu

        Public Property idaipinslimsusrepu() As Decimal
            Get
                Return Me.p_idaipinslimsusrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinslimsusrepu = Value
            End Set
        End Property

        Public Property idaipinslimsus() As Decimal
            Get
                Return Me.p_idaipinslimsus
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinslimsus = Value
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

        Public Property ncantinslimsusrepu() As Int16
            Get
                Return Me.p_ncantinslimsusrepu
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinslimsusrepu = Value
            End Set
        End Property

        Public Property nprecfininslimsusrepu() As Decimal
            Get
                Return Me.p_nprecfininslimsusrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininslimsusrepu = Value
            End Set
        End Property

        Public Property xdescinslimsusrepu() As String
            Get
                Return Me.p_xdescinslimsusrepu
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinslimsusrepu = Value
            End Set
        End Property

        Public Property iestatinslimsusrepu() As String
            Get
                Return Me.p_iestatinslimsusrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinslimsusrepu = Value
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
        Public Property aipinslimsus() As aipinslimsus
            Get
                Return Me.p_aipinslimsus
            End Get
            Set(ByVal Value As aipinslimsus)
                Me.p_aipinslimsus = Value
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

    Public Class petiaipinslimsusrepupaglist

        Private p_pagaipinslimsusrepu As paginacion
        Private p_aipinslimsusrepu As aipinslimsusrepu

        Public Property pagaipinslimsusrepu() As paginacion
            Get
                Return Me.p_pagaipinslimsusrepu
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsusrepu = Value
            End Set
        End Property

        Public Property aipinslimsusrepu() As aipinslimsusrepu
            Get
                Return Me.p_aipinslimsusrepu
            End Get
            Set(ByVal Value As aipinslimsusrepu)
                Me.p_aipinslimsusrepu = Value
            End Set
        End Property
    End Class

    Public Class respaipinslimsusrepupaglist

        Private p_pagaipinslimsusrepu As paginacion
        Private p_lista_aipinslimsusrepu As List(Of aipinslimsusrepu)

        Public Property pagaipinslimsusrepu() As paginacion
            Get
                Return Me.p_pagaipinslimsusrepu
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsusrepu = Value
            End Set
        End Property

        Public Property lista_aipinslimsusrepu() As List(Of aipinslimsusrepu)
            Get
                Return Me.p_lista_aipinslimsusrepu
            End Get
            Set(ByVal Value As List(Of aipinslimsusrepu))
                Me.p_lista_aipinslimsusrepu = Value
            End Set
        End Property
    End Class

End Namespace
