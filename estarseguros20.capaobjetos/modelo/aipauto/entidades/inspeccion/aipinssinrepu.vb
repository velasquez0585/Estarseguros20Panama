Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento

Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinssinrepu

        Private p_idaipinssinrepu As Decimal
        Private p_idaipinssin As Decimal
        Private p_idaipmanrepu As Decimal
        Private p_ncantinssinrepu As Int16
        Private p_iorigrepuinssinrepu As String
        Private p_nprecfininssinrepu As Decimal
        Private p_xdescinssinrepu As String
        Private p_iestatinssinrepu As String
        Private p_idseglogreg As Decimal


        'relaciones
        Private p_aipinssin As aipinssin
        Private p_aipmanrepu As aipmanrepu


        Public Property idaipinssinrepu() As Decimal
            Get
                Return Me.p_idaipinssinrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssinrepu = Value
            End Set
        End Property

        Public Property idaipinssin() As Decimal
            Get
                Return Me.p_idaipinssin
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssin = Value
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

        Public Property ncantinssinrepu() As Int16
            Get
                Return Me.p_ncantinssinrepu
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinssinrepu = Value
            End Set
        End Property

        Public Property iorigrepuinssinrepu() As String
            Get
                Return Me.p_iorigrepuinssinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iorigrepuinssinrepu = Value
            End Set
        End Property



        Public Property nprecfininssinrepu() As Decimal
            Get
                Return Me.p_nprecfininssinrepu
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininssinrepu = Value
            End Set
        End Property

        Public Property xdescinssinrepu() As String
            Get
                Return Me.p_xdescinssinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinssinrepu = Value
            End Set
        End Property

        Public Property iestatinssinrepu() As String
            Get
                Return Me.p_iestatinssinrepu
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinssinrepu = Value
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
        Public Property aipinssin() As aipinssin
            Get
                Return Me.p_aipinssin
            End Get
            Set(ByVal Value As aipinssin)
                Me.p_aipinssin = Value
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

    Public Class petiaipinssinrepupaglist

        Private p_pagaipinssinrepu As paginacion
        Private p_aipinssinrepu As aipinssinrepu

        Public Property pagaipinssinrepu() As paginacion
            Get
                Return Me.p_pagaipinssinrepu
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssinrepu = Value
            End Set
        End Property

        Public Property aipinssinrepu() As aipinssinrepu
            Get
                Return Me.p_aipinssinrepu
            End Get
            Set(ByVal Value As aipinssinrepu)
                Me.p_aipinssinrepu = Value
            End Set
        End Property
    End Class

    Public Class respaipinssinrepupaglist

        Private p_pagaipinssinrepu As paginacion
        Private p_lista_aipinssinrepu As List(Of aipinssinrepu)

        Public Property pagaipinssinrepu() As paginacion
            Get
                Return Me.p_pagaipinssinrepu
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssinrepu = Value
            End Set
        End Property

        Public Property lista_aipinssinrepu() As List(Of aipinssinrepu)
            Get
                Return Me.p_lista_aipinssinrepu
            End Get
            Set(ByVal Value As List(Of aipinssinrepu))
                Me.p_lista_aipinssinrepu = Value
            End Set
        End Property
    End Class

End Namespace
