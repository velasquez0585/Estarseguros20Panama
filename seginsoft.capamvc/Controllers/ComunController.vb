Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports Newtonsoft.Json
Imports System.Net.Http

Public Class ComunController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Comun

    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerValores(xconcepto As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunconfvalor As String = httpcliente.posthttpparam("comunconfvalor/selcomunconfvalorxconcepto/?xconcepto=" & xconcepto)
        'Dim listacomunconfvalor As New List(Of comunconfvalor)
        'If xconcepto = "SEXO" Then

        '    listacomunconfvalor.Add(New comunconfvalor)
        '    listacomunconfvalor(0).idcomunconfvalor = 0
        '    listacomunconfvalor(0).xconcepto = ""
        '    listacomunconfvalor(0).xvalorcodigo = "SELECCIONE..."
        '    listacomunconfvalor(0).xvalordescripcion = "SELECCIONE..."

        '    listacomunconfvalor.Add(New comunconfvalor)
        '    listacomunconfvalor(1).idcomunconfvalor = 1
        '    listacomunconfvalor(1).xconcepto = "SEXO"
        '    listacomunconfvalor(1).xvalorcodigo = "FEMENINO"
        '    listacomunconfvalor(1).xvalordescripcion = "FEMENINO"

        '    listacomunconfvalor.Add(New comunconfvalor)
        '    listacomunconfvalor(2).idcomunconfvalor = 1
        '    listacomunconfvalor(2).xconcepto = "SEXO"
        '    listacomunconfvalor(2).xvalorcodigo = "MASCULINO"
        '    listacomunconfvalor(2).xvalordescripcion = "MASCULINO"

        'Else
        '    If xconcepto = "NACIONALIDAD" Then

        '        listacomunconfvalor.Add(New comunconfvalor)
        '        listacomunconfvalor(0).idcomunconfvalor = 0
        '        listacomunconfvalor(0).xconcepto = "NACIONALIDAD"
        '        listacomunconfvalor(0).xvalorcodigo = "SELECCIONE..."
        '        listacomunconfvalor(0).xvalordescripcion = "SELECCIONE..."

        '        listacomunconfvalor.Add(New comunconfvalor)
        '        listacomunconfvalor(1).idcomunconfvalor = 1
        '        listacomunconfvalor(1).xconcepto = "NACIONALIDAD"
        '        listacomunconfvalor(1).xvalorcodigo = "LOCAL"
        '        listacomunconfvalor(1).xvalordescripcion = "LOCAL"

        '        listacomunconfvalor.Add(New comunconfvalor)
        '        listacomunconfvalor(2).idcomunconfvalor = 2
        '        listacomunconfvalor(2).xconcepto = "NACIONALIDAD"
        '        listacomunconfvalor(2).xvalorcodigo = "EXTRANJERO"
        '        listacomunconfvalor(2).xvalordescripcion = "EXTRANJERO"

        '    End If
        'End If

        'Dim listacomunconfvalor1 As String = JsonConvert.SerializeObject(listacomunconfvalor)

        Return Content(lista_comunconfvalor, "application/json")
    End Function


    <HttpPost()>
    Function ObtenerContienentes() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmancontinente As String = httpcliente.posthttpparam("comunmancont/selcomunmancont")

        'Dim lista_comunmancontinente As New List(Of comunmancont)

        'lista_comunmancontinente.Add(New comunmancont)
        'lista_comunmancontinente(0).idcomunmancont = 1
        'lista_comunmancontinente(0).xnombrecont = "AMERICA"
        'lista_comunmancontinente(0).xlongitud = ""
        'lista_comunmancontinente(0).xlatitud = ""

        'lista_comunmancontinente.Add(New comunmancont)
        'lista_comunmancontinente(1).idcomunmancont = 2
        'lista_comunmancontinente(1).xnombrecont = "EUROPA"
        'lista_comunmancontinente(1).xlongitud = ""
        'lista_comunmancontinente(1).xlatitud = ""

        'Dim lista_comunmancontinente1 As String = JsonConvert.SerializeObject(lista_comunmancontinente)

        Return Content(lista_comunmancontinente, "application/json")
    End Function

    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerPaisesPorContienente(idcomunmancont As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanpais As String = httpcliente.posthttpparam("comunmanpais/selcomunmanpaisxcont?idcomunmancont=" & idcomunmancont)

        'Dim lista_comunmanpais As New List(Of comunmanpais)
        'If idcomunmancont = 1 Then

        '    lista_comunmanpais.Add(New comunmanpais)
        '    lista_comunmanpais(0).idcomunmanpais = 0
        '    lista_comunmanpais(0).idcomunmancont = 0
        '    lista_comunmanpais(0).xnombrepais = "SELECCIONE..."
        '    lista_comunmanpais(0).xlongitud = ""
        '    lista_comunmanpais(0).xlatitud = ""

        '    lista_comunmanpais.Add(New comunmanpais)
        '    lista_comunmanpais(1).idcomunmanpais = 1
        '    lista_comunmanpais(1).idcomunmancont = 1
        '    lista_comunmanpais(1).xnombrepais = "VENEZUELA"
        '    lista_comunmanpais(1).xlongitud = ""
        '    lista_comunmanpais(1).xlatitud = ""

        '    lista_comunmanpais.Add(New comunmanpais)
        '    lista_comunmanpais(2).idcomunmanpais = 2
        '    lista_comunmanpais(2).idcomunmancont = 1
        '    lista_comunmanpais(2).xnombrepais = "CHILE"
        '    lista_comunmanpais(2).xlongitud = ""
        '    lista_comunmanpais(2).xlatitud = ""
        'Else
        '    If idcomunmancont = 2 Then

        '        lista_comunmanpais.Add(New comunmanpais)
        '        lista_comunmanpais(0).idcomunmanpais = 0
        '        lista_comunmanpais(0).idcomunmancont = 0
        '        lista_comunmanpais(0).xnombrepais = "SELECCIONE..."
        '        lista_comunmanpais(0).xlongitud = ""
        '        lista_comunmanpais(0).xlatitud = ""

        '        lista_comunmanpais.Add(New comunmanpais)
        '        lista_comunmanpais(1).idcomunmanpais = 3
        '        lista_comunmanpais(1).idcomunmancont = 1
        '        lista_comunmanpais(1).xnombrepais = "ITALIA"
        '        lista_comunmanpais(1).xlongitud = ""
        '        lista_comunmanpais(1).xlatitud = ""
        '    End If
        'End If




        'Dim lista_comunmanpais1 As String = JsonConvert.SerializeObject(lista_comunmanpais)


        Return Content(lista_comunmanpais, "application/json")
    End Function

    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerEstadosPorPais(idcomunmanpais As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanestado As String = httpcliente.posthttpparam("comunmanestado/selcomunmanestadoxpais/?idcomunmanpais=" & idcomunmanpais)

        'Dim lista_comunmanestado As New List(Of comunmanestado)

        'If idcomunmanpais = 1 Then

        '    lista_comunmanestado.Add(New comunmanestado)
        '    lista_comunmanestado(0).idcomunmanpais = 0
        '    lista_comunmanestado(0).idcomunmancont = 0
        '    lista_comunmanestado(0).xnombreestado = "SELECCIONE..."
        '    lista_comunmanestado(0).xlongitud = ""
        '    lista_comunmanestado(0).xlatitud = ""

        '    lista_comunmanestado.Add(New comunmanestado)
        '    lista_comunmanestado(1).idcomunmanestado = 20
        '    lista_comunmanestado(1).idcomunmanpais = 1
        '    lista_comunmanestado(1).idcomunmancont = 1
        '    lista_comunmanestado(1).xnombreestado = "DISTRITO CAPITAL"
        '    lista_comunmanestado(1).xlongitud = ""
        '    lista_comunmanestado(1).xlatitud = ""

        '    lista_comunmanestado.Add(New comunmanestado)
        '    lista_comunmanestado(2).idcomunmanestado = 1
        '    lista_comunmanestado(2).idcomunmanpais = 1
        '    lista_comunmanestado(2).idcomunmancont = 1
        '    lista_comunmanestado(2).xnombreestado = "MIRANDA"
        '    lista_comunmanestado(2).xlongitud = ""
        '    lista_comunmanestado(2).xlatitud = ""

        '    lista_comunmanestado.Add(New comunmanestado)
        '    lista_comunmanestado(3).idcomunmanestado = 3
        '    lista_comunmanestado(3).idcomunmanpais = 1
        '    lista_comunmanestado(3).idcomunmancont = 1
        '    lista_comunmanestado(3).xnombreestado = "ARAGUA"
        '    lista_comunmanestado(3).xlongitud = ""
        '    lista_comunmanestado(3).xlatitud = ""

        '    lista_comunmanestado.Add(New comunmanestado)
        '    lista_comunmanestado(4).idcomunmanestado = 15
        '    lista_comunmanestado(4).idcomunmanpais = 1
        '    lista_comunmanestado(4).idcomunmancont = 1
        '    lista_comunmanestado(4).xnombreestado = "SUCRE"
        '    lista_comunmanestado(4).xlongitud = ""
        '    lista_comunmanestado(4).xlatitud = ""

        'Else
        '    If idcomunmanpais = 3 Then
        '        lista_comunmanestado.Add(New comunmanestado)
        '        lista_comunmanestado(0).idcomunmanestado = 0
        '        lista_comunmanestado(0).idcomunmanpais = 0
        '        lista_comunmanestado(0).idcomunmancont = 0
        '        lista_comunmanestado(0).xnombreestado = "SELECCIONE..."
        '        lista_comunmanestado(0).xlongitud = ""
        '        lista_comunmanestado(0).xlatitud = ""

        '        lista_comunmanestado.Add(New comunmanestado)
        '        lista_comunmanestado(1).idcomunmanestado = 5
        '        lista_comunmanestado(1).idcomunmanpais = 1
        '        lista_comunmanestado(1).idcomunmancont = 1
        '        lista_comunmanestado(1).xnombreestado = "ROMA"
        '        lista_comunmanestado(1).xlongitud = ""
        '        lista_comunmanestado(1).xlatitud = ""
        '    End If
        'End If

        'Dim lista_comunmanestado1 As String = JsonConvert.SerializeObject(lista_comunmanestado)


        Return Content(lista_comunmanestado, "application/json")

        'Return Content(lista_comunmanestado, "application/json")
    End Function

    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerLocalidadesPorEstado(idcomunmancont As Decimal, idcomunmanpais As Decimal, idcomunmanestado As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanlocalid As String = httpcliente.posthttpparam("comunmanlocalid/selcomunmanlocalidxestado/?idcomunmanestado=" & idcomunmanestado)

        'Dim lista_comunmanlocalid As New List(Of comunmanlocalid)

        'If idcomunmanestado = 20 Then

        '    lista_comunmanlocalid.Add(New comunmanlocalid)
        '    lista_comunmanlocalid(0).idcomunmanlocalid = 1
        '    lista_comunmanlocalid(0).idcomunmanestado = 1
        '    lista_comunmanlocalid(0).idcomunmanpais = 1
        '    lista_comunmanlocalid(0).idcomunmancont = 1
        '    lista_comunmanlocalid(0).xnombrelocalid = "El PARAISO"
        '    lista_comunmanlocalid(0).xlongitud = ""
        '    lista_comunmanlocalid(0).xlatitud = ""

        '    lista_comunmanlocalid.Add(New comunmanlocalid)
        '    lista_comunmanlocalid(1).idcomunmanlocalid = 2
        '    lista_comunmanlocalid(1).idcomunmanestado = 1
        '    lista_comunmanlocalid(1).idcomunmanpais = 1
        '    lista_comunmanlocalid(1).idcomunmancont = 1
        '    lista_comunmanlocalid(1).xnombrelocalid = "SAN MARTIN"
        '    lista_comunmanlocalid(1).xlongitud = ""
        '    lista_comunmanlocalid(1).xlatitud = ""

        'Else
        '    If idcomunmanestado = 1 Then

        '        lista_comunmanlocalid.Add(New comunmanlocalid)
        '        lista_comunmanlocalid(2).idcomunmanlocalid = 3
        '        lista_comunmanlocalid(2).idcomunmanestado = 2
        '        lista_comunmanlocalid(2).idcomunmanpais = 1
        '        lista_comunmanlocalid(2).idcomunmancont = 1
        '        lista_comunmanlocalid(2).xnombrelocalid = "LA CASTELLANA"
        '        lista_comunmanlocalid(2).xlongitud = ""
        '        lista_comunmanlocalid(2).xlatitud = ""

        '        lista_comunmanlocalid.Add(New comunmanlocalid)
        '        lista_comunmanlocalid(3).idcomunmanlocalid = 4
        '        lista_comunmanlocalid(3).idcomunmanestado = 2
        '        lista_comunmanlocalid(3).idcomunmanpais = 1
        '        lista_comunmanlocalid(3).idcomunmancont = 1
        '        lista_comunmanlocalid(3).xnombrelocalid = "ALTAMIRA"
        '        lista_comunmanlocalid(3).xlongitud = ""
        '        lista_comunmanlocalid(3).xlatitud = ""
        '    Else
        '        If idcomunmanestado = 3 Then

        '            lista_comunmanlocalid.Add(New comunmanlocalid)
        '            lista_comunmanlocalid(2).idcomunmanlocalid = 3
        '            lista_comunmanlocalid(2).idcomunmanestado = 3
        '            lista_comunmanlocalid(2).idcomunmanpais = 1
        '            lista_comunmanlocalid(2).idcomunmancont = 1
        '            lista_comunmanlocalid(2).xnombrelocalid = "CENTRO"
        '            lista_comunmanlocalid(2).xlongitud = ""
        '            lista_comunmanlocalid(2).xlatitud = ""

        '            If idcomunmanestado = 15 Then

        '                lista_comunmanlocalid.Add(New comunmanlocalid)
        '                lista_comunmanlocalid(2).idcomunmanlocalid = 3
        '                lista_comunmanlocalid(2).idcomunmanestado = 4
        '                lista_comunmanlocalid(2).idcomunmanpais = 1
        '                lista_comunmanlocalid(2).idcomunmancont = 1
        '                lista_comunmanlocalid(2).xnombrelocalid = "CENTRO SUCRE"
        '                lista_comunmanlocalid(2).xlongitud = ""
        '                lista_comunmanlocalid(2).xlatitud = ""
        '            End If
        '        End If
        '    End If
        'End If

        'Dim lista_comunmanlocalid1 As String = JsonConvert.SerializeObject(lista_comunmanlocalid)


        Return Content(lista_comunmanlocalid, "application/json")


        'Return Content(lista_comunmanlocalid, "application/json")
    End Function
    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboPais() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_combopais As String = httpcliente.posthttpparam("comunmanpais/selcomunmanpais/")
        Return Content(lista_combopais, "application/json")
    End Function
    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboEstado() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comboestado As String = httpcliente.posthttpparam("comunmanestado/selcomunmanestado/")
        Return Content(lista_comboestado, "application/json")
    End Function
    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboLocalidad() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_combolocalidad As String = httpcliente.posthttpparam("comunmanlocalid/selcomunmanlocalid/")
        Return Content(lista_combolocalidad, "application/json")
    End Function
    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboComercial() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comboorganizacion As String = httpcliente.posthttpparam("comunmanempr/selcomunmanempr/")
        Return Content(lista_comboorganizacion, "application/json")
    End Function
    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboNombreDep() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_combodep As String = httpcliente.posthttpparam("segmandep/selsegmandep/")
        Return Content(lista_combodep, "application/json")
    End Function
    '<CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboNombreCarg() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_combocarg As String = httpcliente.posthttpparam("segmancarg/selsegmancarg/")
        Return Content(lista_combocarg, "application/json")
    End Function

End Class