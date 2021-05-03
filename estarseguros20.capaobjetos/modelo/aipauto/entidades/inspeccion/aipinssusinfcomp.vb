Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento

Namespace aipauto.modelo.dbestarseguros20.entidades.inspeccion

    Public Class aipinssusinfcomp

        Private p_idaipinssusinfcomp As Decimal
        Private p_idaipinssus As Decimal
        Private p_idaipmaninfcomp As Decimal
        Private p_iexisinssusinfcomp As Int32
        Private p_idseglogreg As Decimal

        'relaciones
        Private p_aipinssus As aipinssus
        Private p_aipmaninfcomp As aipmaninfcomp


        Public Property idaipinssusinfcomp() As Decimal
            Get
                Return Me.p_idaipinssusinfcomp
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssusinfcomp = Value
            End Set
        End Property

        Public Property idaipinssus() As Decimal
            Get
                Return Me.p_idaipinssus
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipinssus = Value
            End Set
        End Property

        Public Property idaipmaninfcomp() As Decimal
            Get
                Return Me.p_idaipmaninfcomp
            End Get
            Set(ByVal Value As Decimal)
                Me.p_idaipmaninfcomp = Value
            End Set
        End Property

        Public Property iexisinssusinfcomp() As Int32
            Get
                Return Me.p_iexisinssusinfcomp
            End Get
            Set(ByVal Value As Int32)
                Me.p_iexisinssusinfcomp = Value
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


        ''relaciones
        Public Property aipinssus() As aipinssus
            Get
                Return Me.p_aipinssus
            End Get
            Set(ByVal Value As aipinssus)
                Me.p_aipinssus = Value
            End Set
        End Property

        Public Property aipmaninfcomp() As aipmaninfcomp
            Get
                Return Me.p_aipmaninfcomp
            End Get
            Set(ByVal Value As aipmaninfcomp)
                Me.p_aipmaninfcomp = Value
            End Set
        End Property



    End Class

    Public Class petiaipinssusinfcomppaglist

        Private p_pagaipinssusinfcomp As paginacion
        Private p_aipinssusinfcomp As aipinssusinfcomp

        Public Property pagaipinssusinfcomp() As paginacion
            Get
                Return Me.p_pagaipinssusinfcomp
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssusinfcomp = Value
            End Set
        End Property

        Public Property aipinssusinfcomp() As aipinssusinfcomp
            Get
                Return Me.p_aipinssusinfcomp
            End Get
            Set(ByVal Value As aipinssusinfcomp)
                Me.p_aipinssusinfcomp = Value
            End Set
        End Property
    End Class

    Public Class respaipinssusinfcomppaglist

        Private p_pagaipinssusinfcomp As paginacion
        Private p_lista_aipinssusinfcomp As List(Of aipinssusinfcomp)

        Public Property pagaipinssusinfcomp() As paginacion
            Get
                Return Me.p_pagaipinssusinfcomp
            End Get
            Set(ByVal Value As paginacion)
                Me.p_pagaipinssusinfcomp = Value
            End Set
        End Property

        Public Property lista_aipinssusinfcomp() As List(Of aipinssusinfcomp)
            Get
                Return Me.p_lista_aipinssusinfcomp
            End Get
            Set(ByVal Value As List(Of aipinssusinfcomp))
                Me.p_lista_aipinssusinfcomp = Value
            End Set
        End Property
    End Class

End Namespace
