Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento

Public Class ComunController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Comun

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerValores(xconcepto As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunconfvalor As String = httpcliente.posthttpparam("comunconfvalor/selcomunconfvalorxconcepto/?xconcepto=" & xconcepto)
        Return Content(lista_comunconfvalor, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerEstadosPorPais(idcomunmanpais As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanestado As String = httpcliente.posthttpparam("comunmanestado/selcomunmanestadoxpais/?idcomunmanpais=" & idcomunmanpais)
        Return Content(lista_comunmanestado, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerLocalidadesPorEstado(idcomunmanestado As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanlocalid As String = httpcliente.posthttpparam("comunmanlocalid/selcomunmanlocalidxestado/?idcomunmanestado=" & idcomunmanestado)
        Return Content(lista_comunmanlocalid, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboContinente() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmancont As String = httpcliente.posthttpparam("comunmancont/selcomunmancont/")
        Return Content(lista_comunmancont, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboPais(idcomunmancont As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanpais As String = httpcliente.posthttpparam("comunmanpais/selcomunmanpaisxidcont/?idcomunmancont=" & idcomunmancont)
        Return Content(lista_comunmanpais, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboEstado(idcomunmanpais As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanestado As String = httpcliente.posthttpparam("comunmanestado/selcomunmanestadoxidpais/?idcomunmanpais=" & idcomunmanpais)
        Return Content(lista_comunmanestado, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboLocalidad(idcomunmanestado As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanlocalid As String = httpcliente.posthttpparam("comunmanlocalid/selcomunmanlocalidxidestado/?idcomunmanestado=" & idcomunmanestado)
        Return Content(lista_comunmanlocalid, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboOrganizacion() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_combosegmanorg As String = httpcliente.posthttpparam("vi_combosegmanorg/selvi_combosegmanorg/")
        Return Content(lista_vi_combosegmanorg, "application/json")
    End Function

End Class