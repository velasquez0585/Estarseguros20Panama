Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinslimsusmobr

        Private p_idaipinslimsusmobr As Decimal
        Private p_idaipinslimsus As Decimal
        Private p_idaipbaremobr As Decimal
        Private p_ncantinslimsusmobr As Int16
        Private p_nprecfininslimsusmobr As Decimal
        Private p_xdescinslimsusmobr As String
        Private p_iestatinslimsusmobr As String
        Private p_idseglogreg As Decimal


        'relaciones
        Private p_aipinslimsus As aipinslimsus
        Private p_aipbaremobr As aipbaremobr

        Public Property idaipinslimsusmobr() As Decimal
            Get
                Return Me.p_idaipinslimsusmobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinslimsusmobr = Value
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

        Public Property idaipbaremobr() As Decimal
            Get
                Return Me.p_idaipbaremobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipbaremobr = Value
            End Set
        End Property

        Public Property ncantinslimsusmobr() As Int16
            Get
                Return Me.p_ncantinslimsusmobr
            End Get
            Set(ByVal Value As Int16)
                Me.p_ncantinslimsusmobr = Value
            End Set
        End Property

        Public Property nprecfininslimsusmobr() As Decimal
            Get
                Return Me.p_nprecfininslimsusmobr
            End Get
            Set(ByVal Value As Decimal)
                Me.p_nprecfininslimsusmobr = Value
            End Set
        End Property

        Public Property xdescinslimsusmobr() As String
            Get
                Return Me.p_xdescinslimsusmobr
            End Get
            Set(ByVal Value As String)
                Me.p_xdescinslimsusmobr = Value
            End Set
        End Property

        Public Property iestatinslimsusmobr() As String
            Get
                Return Me.p_iestatinslimsusmobr
            End Get
            Set(ByVal Value As String)
                Me.p_iestatinslimsusmobr = Value
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
        Public Property aipbaremobr() As aipbaremobr
            Get
                Return Me.p_aipbaremobr
            End Get
            Set(ByVal Value As aipbaremobr)
                Me.p_aipbaremobr = Value
            End Set
        End Property

    End Class

    Public Class petiaipinslimsusmobrpaglist

        Private p_pagaipinslimsusmobr As paginacion
        Private p_aipinslimsusmobr As aipinslimsusmobr

        Public Property pagaipinslimsusmobr() As paginacion
            Get
                Return Me.p_pagaipinslimsusmobr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsusmobr = Value
            End Set
        End Property

        Public Property aipinslimsusmobr() As aipinslimsusmobr
            Get
                Return Me.p_aipinslimsusmobr
            End Get
            Set(ByVal Value As aipinslimsusmobr)
                Me.p_aipinslimsusmobr = Value
            End Set
        End Property
    End Class

    Public Class respaipinslimsusmobrpaglist

        Private p_pagaipinslimsusmobr As paginacion
        Private p_lista_aipinslimsusmobr As List(Of aipinslimsusmobr)

        Public Property pagaipinslimsusmobr() As paginacion
            Get
                Return Me.p_pagaipinslimsusmobr
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinslimsusmobr = Value
            End Set
        End Property

        Public Property lista_aipinslimsusmobr() As List(Of aipinslimsusmobr)
            Get
                Return Me.p_lista_aipinslimsusmobr
            End Get
            Set(ByVal Value As List(Of aipinslimsusmobr))
                Me.p_lista_aipinslimsusmobr = Value
            End Set
        End Property
    End Class

End Namespace
