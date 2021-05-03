Imports brofinza.capaobjetos.modelo.personalizados
Imports brofinza.capaobjetos.seginsoft.modelo.dbbrofinza.vistas.seguridad

Public Class segmanperf

    Private p_idsegmanperf As Integer
    Private p_xabrevperf As String
    Private p_xnombreperf As String
    Private p_nnivelperf As Integer
    Private p_idseglogreg As Decimal
    Private p_idsegmandep As Integer

    Public Property idsegmanperf() As Integer
        Get
            Return Me.p_idsegmanperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanperf = Value
        End Set
    End Property

    Public Property xabrevperf() As String
        Get
            Return Me.p_xabrevperf
        End Get
        Set(ByVal Value As String)
            Me.p_xabrevperf = Value
        End Set
    End Property

    Public Property xnombreperf() As String
        Get
            Return Me.p_xnombreperf
        End Get
        Set(ByVal Value As String)
            Me.p_xnombreperf = Value
        End Set
    End Property

    Public Property nnivelperf() As Integer
        Get
            Return Me.p_nnivelperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_nnivelperf = Value
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

    Public Property idsegmandep() As Integer
        Get
            Return Me.p_idsegmandep
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmandep = Value
        End Set
    End Property


End Class

Public Class resp_segmanperflist
    Private p_lista_segmanperf_check As String()
    Private p_lista_segmanperf As List(Of segmanperf)

    Public Property lista_segmanperf_check() As String()
        Get
            Return Me.p_lista_segmanperf_check
        End Get
        Set(ByVal Value As String())
            Me.p_lista_segmanperf_check = Value
        End Set
    End Property

    Public Property lista_segmanperf() As List(Of segmanperf)
        Get
            Return Me.p_lista_segmanperf
        End Get
        Set(ByVal Value As List(Of segmanperf))
            Me.p_lista_segmanperf = Value
        End Set
    End Property

End Class





Public Class petivi_segmanusupaglist
    Private p_pagvi_segmanusu As paginacion
    Private p_vi_segmanusu As vi_segmanusu

    Public Property pagvi_segmanusu() As paginacion
        Get
            Return Me.p_pagvi_segmanusu
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segmanusu = Value
        End Set
    End Property

    Public Property vi_segmanusu() As vi_segmanusu
        Get
            Return Me.p_vi_segmanusu
        End Get
        Set(ByVal Value As vi_segmanusu)
            Me.p_vi_segmanusu = Value
        End Set
    End Property

End Class

Public Class respvi_segmanusupaglist

    Private p_pagvi_segmanusu As paginacion
    Private p_lista_vi_segmanusu As List(Of vi_segmanusu)
    ''
    Public Property pagvi_segmanusu() As paginacion
        Get
            Return Me.p_pagvi_segmanusu
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segmanusu = Value
        End Set
    End Property

    Public Property lista_vi_segmanusu() As List(Of vi_segmanusu)
        Get
            Return Me.p_lista_vi_segmanusu
        End Get
        Set(ByVal Value As List(Of vi_segmanusu))
            Me.p_lista_vi_segmanusu = Value
        End Set
    End Property
End Class

Public Class peti_segmanperfpaglist
    Private p_pag_segmanperf As paginacion
    Private p_segmanperf As segmanperf

    Public Property pag_segmanperf() As paginacion
        Get
            Return Me.p_pag_segmanperf
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pag_segmanperf = Value
        End Set
    End Property

    Public Property segmanperf() As segmanperf
        Get
            Return Me.p_segmanperf
        End Get
        Set(ByVal Value As segmanperf)
            Me.p_segmanperf = Value
        End Set
    End Property

End Class

Public Class resp_segmanperfpaglist

    Private p_pag_segmanperf As paginacion
    Private p_lista_segmanperf As List(Of segmanperf)
    ''
    Public Property pag_segmanperf() As paginacion
        Get
            Return Me.p_pag_segmanperf
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pag_segmanperf = Value
        End Set
    End Property

    Public Property lista_segmanperf() As List(Of segmanperf)
        Get
            Return Me.p_lista_segmanperf
        End Get
        Set(ByVal Value As List(Of segmanperf))
            Me.p_lista_segmanperf = Value
        End Set
    End Property
End Class

Public Class segappperf

    Private p_idsegappperf As Integer
    Private p_idsegmanapp As Integer
    Private p_idsegmanperf As Integer
    Private p_idseglogreg As Decimal

    Public Property idsegappperf() As Integer
        Get
            Return Me.p_idsegappperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegappperf = Value
        End Set
    End Property

    Public Property idsegmanapp() As Integer
        Get
            Return Me.p_idsegmanapp
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanapp = Value
        End Set
    End Property

    Public Property idsegmanperf() As Integer
        Get
            Return Me.p_idsegmanperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanperf = Value
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

End Class


Public Class vi_segappperf

    Private p_idsegappperf As Integer
    Private p_idsegmanapp As Integer
    Private p_idsegmanperf As Integer
    Private p_xnombrecorto As String
    Private p_xabrevperf As String
    Private p_xnombreperf As String
    Private p_nnivelperf As Integer
    Private p_idseglogreg As Decimal

    Public Property idsegappperf() As Integer
        Get
            Return Me.p_idsegappperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegappperf = Value
        End Set
    End Property

    Public Property idsegmanapp() As Integer
        Get
            Return Me.p_idsegmanapp
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanapp = Value
        End Set
    End Property

    Public Property idsegmanperf() As Integer
        Get
            Return Me.p_idsegmanperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanperf = Value
        End Set
    End Property

    Public Property xnombrecorto() As String
        Get
            Return Me.p_xnombrecorto
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecorto = Value
        End Set
    End Property

    Public Property xabrevperf() As String
        Get
            Return Me.p_xabrevperf
        End Get
        Set(ByVal Value As String)
            Me.p_xabrevperf = Value
        End Set
    End Property

    Public Property xnombreperf() As String
        Get
            Return Me.p_xnombreperf
        End Get
        Set(ByVal Value As String)
            Me.p_xnombreperf = Value
        End Set
    End Property

    Public Property nnivelperf() As Integer
        Get
            Return Me.p_nnivelperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_nnivelperf = Value
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

End Class

Public Class petivi_segappperfpaglist
    Private p_pagvi_segappperf As paginacion
    Private p_vi_segappperf As vi_segappperf

    Public Property pagvi_segappperf() As paginacion
        Get
            Return Me.p_pagvi_segappperf
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segappperf = Value
        End Set
    End Property

    Public Property vi_segappperf() As vi_segappperf
        Get
            Return Me.p_vi_segappperf
        End Get
        Set(ByVal Value As vi_segappperf)
            Me.p_vi_segappperf = Value
        End Set
    End Property

End Class

Public Class respvi_segappperfpaglist

    Private p_pagvi_segappperf As paginacion
    Private p_lista_vi_segappperf As List(Of vi_segappperf)
    ''
    Public Property pagvi_segappperf() As paginacion
        Get
            Return Me.p_pagvi_segappperf
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segappperf = Value
        End Set
    End Property

    Public Property lista_vi_segappperf() As List(Of vi_segappperf)
        Get
            Return Me.p_lista_vi_segappperf
        End Get
        Set(ByVal Value As List(Of vi_segappperf))
            Me.p_lista_vi_segappperf = Value
        End Set
    End Property
End Class

Public Class segmanapp

    Private p_idsegmanapp As Integer
    Private p_xnombrecorto As String
    Private p_xnombrelargo As String
    Private p_xso As String
    Private p_xdesatec As String
    Private p_fimplementacion As Date
    Private p_xobjetivo As String
    Private p_idsegmanorg As String

    Public Property idsegmanapp() As Integer
        Get
            Return Me.p_idsegmanapp
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanapp = Value
        End Set
    End Property

    Public Property xnombrecorto() As String
        Get
            Return Me.p_xnombrecorto
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecorto = Value
        End Set
    End Property

    Public Property xnombrelargo() As String
        Get
            Return Me.p_xnombrelargo
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrelargo = Value
        End Set
    End Property

    Public Property xso() As String
        Get
            Return Me.p_xso
        End Get
        Set(ByVal Value As String)
            Me.p_xso = Value
        End Set
    End Property

    Public Property xdesatec() As String
        Get
            Return Me.p_xdesatec
        End Get
        Set(ByVal Value As String)
            Me.p_xdesatec = Value
        End Set
    End Property

    Public Property fimplementacion() As Date
        Get
            Return Me.p_fimplementacion
        End Get
        Set(ByVal Value As Date)
            Me.p_fimplementacion = Value
        End Set
    End Property

    Public Property xobjetivo() As String
        Get
            Return Me.p_xobjetivo
        End Get
        Set(ByVal Value As String)
            Me.p_xobjetivo = Value
        End Set
    End Property

    Public Property idsegmanorg() As String
        Get
            Return Me.p_idsegmanorg
        End Get
        Set(ByVal Value As String)
            Me.p_idsegmanorg = Value
        End Set
    End Property

End Class

Public Class segmanmod

    Private p_idsegmanmod As Integer
    Private p_xnombrecorto As String
    Private p_xnombrelargo As String
    Private p_fimplementacion As Date
    Private p_xobjetivo As String

    Public Property idsegmanmod() As Integer
        Get
            Return Me.p_idsegmanmod
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanmod = Value
        End Set
    End Property

    Public Property xnombrecorto() As String
        Get
            Return Me.p_xnombrecorto
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecorto = Value
        End Set
    End Property

    Public Property xnombrelargo() As String
        Get
            Return Me.p_xnombrelargo
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrelargo = Value
        End Set
    End Property

    Public Property fimplementacion() As Date
        Get
            Return Me.p_fimplementacion
        End Get
        Set(ByVal Value As Date)
            Me.p_fimplementacion = Value
        End Set
    End Property

    Public Property xobjetivo() As String
        Get
            Return Me.p_xobjetivo
        End Get
        Set(ByVal Value As String)
            Me.p_xobjetivo = Value
        End Set
    End Property

End Class

Public Class segmansubmod

    Private p_idsegmansubmod As Integer
    Private p_xnombrecorto As String
    Private p_xnombrelargo As String
    Private p_fimplementacion As Date
    Private p_xobjetivo As String

    Public Property idsegmansubmod() As Integer
        Get
            Return Me.p_idsegmansubmod
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmansubmod = Value
        End Set
    End Property

    Public Property xnombrecorto() As String
        Get
            Return Me.p_xnombrecorto
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecorto = Value
        End Set
    End Property

    Public Property xnombrelargo() As String
        Get
            Return Me.p_xnombrelargo
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrelargo = Value
        End Set
    End Property

    Public Property fimplementacion() As Date
        Get
            Return Me.p_fimplementacion
        End Get
        Set(ByVal Value As Date)
            Me.p_fimplementacion = Value
        End Set
    End Property

    Public Property xobjetivo() As String
        Get
            Return Me.p_xobjetivo
        End Get
        Set(ByVal Value As String)
            Me.p_xobjetivo = Value
        End Set
    End Property

End Class

Public Class segmanprog

    Private p_idsegmanprog As Integer
    Private p_xnombrecorto As String
    Private p_xnombrelargo As String
    Private p_fimplementacion As Date
    Private p_xobjetivo As String

    Public Property idsegmanprog() As Integer
        Get
            Return Me.p_idsegmanprog
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanprog = Value
        End Set
    End Property

    Public Property xnombrecorto() As String
        Get
            Return Me.p_xnombrecorto
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecorto = Value
        End Set
    End Property

    Public Property xnombrelargo() As String
        Get
            Return Me.p_xnombrelargo
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrelargo = Value
        End Set
    End Property

    Public Property fimplementacion() As Date
        Get
            Return Me.p_fimplementacion
        End Get
        Set(ByVal Value As Date)
            Me.p_fimplementacion = Value
        End Set
    End Property

    Public Property xobjetivo() As String
        Get
            Return Me.p_xobjetivo
        End Get
        Set(ByVal Value As String)
            Me.p_xobjetivo = Value
        End Set
    End Property

End Class

Public Class segappprog

    Private p_idsegappprog As Integer
    Private p_idsegmanapp As Integer
    Private p_idsegmanmod As Integer
    Private p_idsegmansubmod As Integer
    Private p_idsegmanprog As Integer
    Private p_xdirurl As String

    Public Property idsegappprog() As Integer
        Get
            Return Me.p_idsegappprog
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegappprog = Value
        End Set
    End Property

    Public Property idsegmanapp() As Integer
        Get
            Return Me.p_idsegmanapp
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanapp = Value
        End Set
    End Property

    Public Property idsegmanmod() As Integer
        Get
            Return Me.p_idsegmanmod
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanmod = Value
        End Set
    End Property

    Public Property idsegmansubmod() As Integer
        Get
            Return Me.p_idsegmansubmod
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmansubmod = Value
        End Set
    End Property

    Public Property idsegmanprog() As Integer
        Get
            Return Me.p_idsegmanprog
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanprog = Value
        End Set
    End Property

    Public Property xdirurl() As String
        Get
            Return Me.p_xdirurl
        End Get
        Set(ByVal Value As String)
            Me.p_xdirurl = Value
        End Set
    End Property

End Class

Public Class vi_segusuperf

    Private p_idsegusuperf As Integer
    Private p_idsegmanusu As Integer
    Private p_xnombreusuario As String
    Private p_idsegappperf As Integer
    Private p_idsegmanapp As Integer
    Private p_xnombrecorto As String
    Private p_idsegmanperf As Integer
    Private p_xabrevperf As String
    Private p_xnombreperf As String
    Private p_nnivelperf As Integer
    Private p_idseglogreg As Integer
    Private p_xcedula As String
    Private p_xnombres As String
    Private p_xapellidos As String
    Private p_idsegmanorg As Integer
    Private p_xnombrecomercial As String
    Private p_idsegmandep As Integer
    Private p_xnombredep As String
    Private p_idsegmancarg As Integer
    Private p_xnombrecarg As String

    Public Property idsegusuperf() As Integer
        Get
            Return Me.p_idsegusuperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegusuperf = Value
        End Set
    End Property

    Public Property idsegmanusu() As Integer
        Get
            Return Me.p_idsegmanusu
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanusu = Value
        End Set
    End Property

    Public Property xnombreusuario() As String
        Get
            Return Me.p_xnombreusuario
        End Get
        Set(ByVal Value As String)
            Me.p_xnombreusuario = Value
        End Set
    End Property

    Public Property idsegappperf() As Integer
        Get
            Return Me.p_idsegappperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegappperf = Value
        End Set
    End Property

    Public Property idsegmanapp() As Integer
        Get
            Return Me.p_idsegmanapp
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanapp = Value
        End Set
    End Property

    Public Property xnombrecorto() As String
        Get
            Return Me.p_xnombrecorto
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecorto = Value
        End Set
    End Property

    Public Property idsegmanperf() As Integer
        Get
            Return Me.p_idsegmanperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanperf = Value
        End Set
    End Property

    Public Property xabrevperf() As String
        Get
            Return Me.p_xabrevperf
        End Get
        Set(ByVal Value As String)
            Me.p_xabrevperf = Value
        End Set
    End Property

    Public Property xnombreperf() As String
        Get
            Return Me.p_xnombreperf
        End Get
        Set(ByVal Value As String)
            Me.p_xnombreperf = Value
        End Set
    End Property

    Public Property nnivelperf() As Integer
        Get
            Return Me.p_nnivelperf
        End Get
        Set(ByVal Value As Integer)
            Me.p_nnivelperf = Value
        End Set
    End Property

    Public Property idseglogreg() As Integer
        Get
            Return Me.p_idseglogreg
        End Get
        Set(ByVal Value As Integer)
            Me.p_idseglogreg = Value
        End Set
    End Property

    Public Property xcedula() As String
        Get
            Return Me.p_xcedula
        End Get
        Set(ByVal Value As String)
            Me.p_xcedula = Value
        End Set
    End Property

    Public Property xnombres() As String
        Get
            Return Me.p_xnombres
        End Get
        Set(ByVal Value As String)
            Me.p_xnombres = Value
        End Set
    End Property

    Public Property xapellidos() As String
        Get
            Return Me.p_xapellidos
        End Get
        Set(ByVal Value As String)
            Me.p_xapellidos = Value
        End Set
    End Property

    Public Property idsegmanorg() As Integer
        Get
            Return Me.p_idsegmanorg
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmanorg = Value
        End Set
    End Property

    Public Property xnombrecomercial() As String
        Get
            Return Me.p_xnombrecomercial
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecomercial = Value
        End Set
    End Property

    Public Property idsegmandep() As Integer
        Get
            Return Me.p_idsegmandep
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmandep = Value
        End Set
    End Property

    Public Property xnombredep() As String
        Get
            Return Me.p_xnombredep
        End Get
        Set(ByVal Value As String)
            Me.p_xnombredep = Value
        End Set
    End Property

    Public Property idsegmancarg() As Integer
        Get
            Return Me.p_idsegmancarg
        End Get
        Set(ByVal Value As Integer)
            Me.p_idsegmancarg = Value
        End Set
    End Property

    Public Property xnombrecarg() As String
        Get
            Return Me.p_xnombrecarg
        End Get
        Set(ByVal Value As String)
            Me.p_xnombrecarg = Value
        End Set
    End Property

End Class

Public Class petivi_segusuperfpaglist
    Private p_pagvi_segusuperf As paginacion
    Private p_vi_segusuperf As vi_segusuperf

    Public Property pagvi_segusuperf() As paginacion
        Get
            Return Me.p_pagvi_segusuperf
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segusuperf = Value
        End Set
    End Property

    Public Property vi_segusuperf() As vi_segusuperf
        Get
            Return Me.p_vi_segusuperf
        End Get
        Set(ByVal Value As vi_segusuperf)
            Me.p_vi_segusuperf = Value
        End Set
    End Property

End Class

Public Class respvi_segusuperfpaglist

    Private p_pagvi_segusuperf As paginacion
    Private p_lista_vi_segusuperf As List(Of vi_segusuperf)
    ''
    Public Property pagvi_segusuperf() As paginacion
        Get
            Return Me.p_pagvi_segusuperf
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segusuperf = Value
        End Set
    End Property

    Public Property lista_vi_segusuperf() As List(Of vi_segusuperf)
        Get
            Return Me.p_lista_vi_segusuperf
        End Get
        Set(ByVal Value As List(Of vi_segusuperf))
            Me.p_lista_vi_segusuperf = Value
        End Set
    End Property
End Class

Public Class petivi_segappprogpaglist
    Private p_pagvi_segappprog As paginacion
    Private p_vi_segappprog As vi_segappprog

    Public Property pagvi_segappprog() As paginacion
        Get
            Return Me.p_pagvi_segappprog
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segappprog = Value
        End Set
    End Property

    Public Property vi_segappprog() As vi_segappprog
        Get
            Return Me.p_vi_segappprog
        End Get
        Set(ByVal Value As vi_segappprog)
            Me.p_vi_segappprog = Value
        End Set
    End Property

End Class

Public Class respvi_segappprogpaglist

    Private p_pagvi_segappprog As paginacion
    Private p_lista_vi_segappprog As List(Of vi_segappprog)

    Public Property pagvi_segappprog() As paginacion
        Get
            Return Me.p_pagvi_segappprog
        End Get
        Set(ByVal Value As paginacion)
            Me.p_pagvi_segappprog = Value
        End Set
    End Property

    Public Property lista_vi_segappprog() As List(Of vi_segappprog)
        Get
            Return Me.p_lista_vi_segappprog
        End Get
        Set(ByVal Value As List(Of vi_segappprog))
            Me.p_lista_vi_segappprog = Value
        End Set
    End Property
End Class

