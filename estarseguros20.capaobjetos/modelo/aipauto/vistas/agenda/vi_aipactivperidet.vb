Imports estarseguros20.capaobjetos.modelo.personalizados
Namespace aipauto.modelo.dbestarseguros20.vistas.agenda

    Public Class vi_aipactivperidet

        
        Private p_idaipactivperi As Decimal
        Private p_fejecactivperi As DateTime
        Private p_xtituactivperi As String
        Private p_ialcanactivperi As String
        Private p_iestatactivperi As String
        Private p_ffinejecactivperi As DateTime
        
        Private p_xtelfmovilactivperi As String


        Public Property idaipactivperi() As Decimal
            Get
                Return Me.p_idaipactivperi
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipactivperi = Value
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

        Public Property xtituactivperi() As String
            Get
                Return Me.p_xtituactivperi
            End Get
            Set(ByVal Value As String)
                Me.p_xtituactivperi = Value
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

        Public Property ffinejecactivperi() As DateTime
            Get
                Return Me.p_ffinejecactivperi
            End Get
            Set(ByVal Value As DateTime)
                Me.p_ffinejecactivperi = Value
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



    End Class

    Public Class petivi_aipactivperidetpaglist

        Private p_pagvi_aipactivperidet As paginacion
        Private p_vi_aipactivperidet As vi_aipactivperidet

        Public Property pagvi_aipactivperidet() As paginacion
            Get
                Return Me.p_pagvi_aipactivperidet
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipactivperidet = Value
            End Set
        End Property

        Public Property vi_aipactivperidet() As vi_aipactivperidet
            Get
                Return Me.p_vi_aipactivperidet
            End Get
            Set(ByVal Value As vi_aipactivperidet)
                Me.p_vi_aipactivperidet = Value
            End Set
        End Property
    End Class

    Public Class respvi_aipactivperidetpaglist

        Private p_pagvi_aipactivperidet As paginacion
        Private p_lista_vi_aipactivperidet As List(Of vi_aipactivperidet)

        Public Property pagvi_aipactivperidet() As paginacion
            Get
                Return Me.p_pagvi_aipactivperidet
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagvi_aipactivperidet = Value
            End Set
        End Property

        Public Property lista_vi_aipactivperidet() As List(Of vi_aipactivperidet)
            Get
                Return Me.p_lista_vi_aipactivperidet
            End Get
            Set(ByVal Value As List(Of vi_aipactivperidet))
                Me.p_lista_vi_aipactivperidet = Value
            End Set
        End Property
    End Class

End Namespace
