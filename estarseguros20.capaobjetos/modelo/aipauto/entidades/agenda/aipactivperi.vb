Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion

Namespace aipauto.modelo.dbestarseguros20.entidades.agenda

    Public Class aipactivperi

        Private p_idaipactivperi As Decimal

        Private p_idcomunmancont As Decimal
        Private p_idcomunmanpais As Decimal
        Private p_idcomunmanestado As Decimal
        Private p_idcomunmanlocalid As Decimal
        Private p_fejecactivperi As DateTime
        Private p_ffinejecactivperi As DateTime
        Private p_xdireccionactivperi As String
        Private p_xtelfmovilactivperi As String
        Private p_xnomcliactivperi As String
        Private p_xcorreoelectronicoactivperi As String
        Private p_xtituactivperi As String
        Private p_xdescactivperi As String
        Private p_ialcanactivperi As String
        Private p_iestatactivperi As String
        Private p_idsegmanusucrea As Decimal
        Private p_fcrearegactivperi As DateTime
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinsenc As List(Of aipinsenc) 'nuevo

        Public Property idaipactivperi() As Decimal
            Get
                Return Me.p_idaipactivperi
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipactivperi = Value
            End Set
        End Property

        Public Property idcomunmancont() As Decimal
            Get
                Return Me.p_idcomunmancont
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmancont = Value
            End Set
        End Property

        Public Property idcomunmanpais() As Decimal
            Get
                Return Me.p_idcomunmanpais
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanpais = Value
            End Set
        End Property

        Public Property idcomunmanestado() As Decimal
            Get
                Return Me.p_idcomunmanestado
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanestado = Value
            End Set
        End Property

        Public Property idcomunmanlocalid() As Decimal
            Get
                Return Me.p_idcomunmanlocalid
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idcomunmanlocalid = Value
            End Set
        End Property

        Public Property fejecactivperi() As DateTime
            Get
                Return Me.p_fejecactivperi
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fejecactivperi = Value
            End Set
        End Property

        Public Property ffinejecactivperi() As DateTime
            Get
                Return Me.p_ffinejecactivperi
            End Get
            Set(ByVal Value As DateTime)
                Me.p_ffinejecactivperi = Value
            End Set
        End Property

        Public Property xdireccionactivperi() As String
            Get
                Return Me.p_xdireccionactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xdireccionactivperi = Value
            End Set
        End Property

        Public Property xtelfmovilactivperi() As String
            Get
                Return Me.p_xtelfmovilactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xtelfmovilactivperi = Value
            End Set
        End Property

        Public Property xnomcliactivperi() As String
            Get
                Return Me.p_xnomcliactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xnomcliactivperi = Value
            End Set
        End Property


        Public Property xcorreoelectronicoactivperi() As String
            Get
                Return Me.p_xcorreoelectronicoactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xcorreoelectronicoactivperi = Value
            End Set
        End Property

        Public Property xtituactivperi() As String
            Get
                Return Me.p_xtituactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xtituactivperi = Value
            End Set
        End Property

        Public Property xdescactivperi() As String
            Get
                Return Me.p_xdescactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xdescactivperi = Value
            End Set
        End Property

        Public Property ialcanactivperi() As String
            Get
                Return Me.p_ialcanactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_ialcanactivperi = Value
            End Set
        End Property

        Public Property iestatactivperi() As String
            Get
                Return Me.p_iestatactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_iestatactivperi = Value
            End Set
        End Property

        Public Property idsegmanusucrea() As Decimal
            Get
                Return Me.p_idsegmanusucrea
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idsegmanusucrea = Value
            End Set
        End Property

        Public Property fcrearegactivperi() As DateTime
            Get
                Return Me.p_fcrearegactivperi
            End Get
            Set(ByVal Value As DateTime)
                Me.p_fcrearegactivperi = Value
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

        Public Property aipinsenc() As List(Of aipinsenc)
            Get
                Return Me.p_aipinsenc
            End Get
            Set(ByVal Value As List(Of aipinsenc))
                Me.p_aipinsenc = Value
            End Set
        End Property
    End Class

    Public Class petiaipactivperipaglist

        Private p_pagaipactivperi As paginacion
        Private p_aipactivperi As aipactivperi

        Public Property pagaipactivperi() As paginacion
            Get
                Return Me.p_pagaipactivperi
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipactivperi = Value
            End Set
        End Property

        Public Property aipactivperi() As aipactivperi
            Get
                Return Me.p_aipactivperi
            End Get
            Set(ByVal Value As aipactivperi)
                Me.p_aipactivperi = Value
            End Set
        End Property
    End Class

    Public Class respaipactivperipaglist

        Private p_pagaipactivperi As paginacion
        Private p_lista_aipactivperi As List(Of aipactivperi)

        Public Property pagaipactivperi() As paginacion
            Get
                Return Me.p_pagaipactivperi
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipactivperi = Value
            End Set
        End Property

        Public Property lista_aipactivperi() As List(Of aipactivperi)
            Get
                Return Me.p_lista_aipactivperi
            End Get
            Set(ByVal Value As List(Of aipactivperi))
                Me.p_lista_aipactivperi = Value
            End Set
        End Property
    End Class

End Namespace
