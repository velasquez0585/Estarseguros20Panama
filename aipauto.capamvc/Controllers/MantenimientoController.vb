Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.log
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.mantenimiento
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento

Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad

Public Class MantenimientoController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Mantenimiento

#Region "Vistas"

    <AllowAnonymous()>
  <HttpGet()>
    Function ManRepu(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManRepu")
        Else
            Return View("ManRepu")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function ManPeritos(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManPeritos")
        Else
            Return View("ManPeritos")
        End If
    End Function

    <CustomAuthorize()>
<HttpGet()>
    Function ManMarca(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManMarca")
        Else
            Return View("ManMarca")
        End If
    End Function

    <CustomAuthorize()>
<HttpGet()>
    Function ManModelo(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManModelo")
        Else
            Return View("ManModelo")
        End If
    End Function

    <CustomAuthorize()>
<HttpGet()>
    Function ManVersion(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManVersion")
        Else
            Return View("ManVersion")
        End If
    End Function

    <CustomAuthorize()>
<HttpGet()>
    Function __ManVersionNuevo1() As ActionResult

        Return PartialView("__ManVersionNuevo1")

    End Function

    <CustomAuthorize()>
<HttpGet()>
    Function ManSucursal(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManSucursal")
        Else
            Return View("ManSucursal")
        End If
    End Function


    <CustomAuthorize()>
    <HttpGet()>
    Function ManActivarUsu(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManActivarUsu")
        Else
            Return View("ManActivarUsu")
        End If
    End Function

    

#End Region

#Region "Seleccion"
#Region "combos"
    <AllowAnonymous()>
  <HttpPost()>
    Function ObtenercombomanTrata() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_comboacvmantrata As String = httpcliente.posthttpparam("vi_comboacvmantrata/selvi_comboacvmantrata/")
        Return Content(lista_vi_comboacvmantrata, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerComboMarcas() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmar As String = httpcliente.posthttpparam("aipmanvehmar/selcomboaipmanvehmar/")
        Return Content(lista_aipmanvehmar, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerComboModelos() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmod As String = httpcliente.posthttpparam("aipmanvehmod/selcomboaipmanvehmod/")
        Return Content(lista_aipmanvehmod, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerComboModelosPorMarca(idaipmanvehmar As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmod As String = httpcliente.posthttpparam("aipmanvehmod/selcomboaipmanvehmodxidaipmanvehmar/?idaipmanvehmar=" & idaipmanvehmar)
        Return Content(lista_aipmanvehmod, "application/json")
    End Function


#End Region
#Region "Cargas"

    <AllowAnonymous()>
  <HttpPost()>
    Function ObtenerRepuestos(petivi_aipmanrepupaglist As petivi_aipmanrepupaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipmanrepupaglist As String = httpcliente.posthttpobj("vi_aipmanrepu/selvi_aipmanrepuxwheredinamicopag/", petivi_aipmanrepupaglist)
        Return Content(respvi_aipmanrepupaglist, "application/json")
    End Function
   
  

    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerRepuestosActivos() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipmanrepupaglist As String = httpcliente.posthttpparam("aipmanrepu/selaipmanrepuactivos/")
        Return Content(respvi_aipmanrepupaglist, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerRepuestosActivosBaremo() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipmanrepupaglist As String = httpcliente.posthttpparam("aipmanrepu/selaipmanrepuactivosbaremo/")
        Return Content(respvi_aipmanrepupaglist, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerMarcasActivas() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmar As String = httpcliente.posthttpparam("aipmanvehmar/selaipmanvehmaractivas/")
        Return Content(lista_aipmanvehmar, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerPorWhereDinamicoPagAipmanvehmar(petiaipmanvehmarpaglist As petiaipmanvehmarpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmar As String = httpcliente.posthttpobj("aipmanvehmar/selaipmanvehmarxwheredinamicopag/", petiaipmanvehmarpaglist)
        Return Content(lista_aipmanvehmar, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerPorWhereDinamicoPagAipmanvehmod(petiaipmanvehmodpaglist As petiaipmanvehmodpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmod As String = httpcliente.posthttpobj("aipmanvehmod/selaipmanvehmodxwheredinamicopag/", petiaipmanvehmodpaglist)
        Return Content(lista_aipmanvehmod, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerPorWhereDinamicoPagvi_aipmanvehmod(petivi_aipmanvehmodpaglist As petivi_aipmanvehmodpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipmanvehmodpaglist As String = httpcliente.posthttpobj("vi_aipmanvehmod/selvi_aipmanvehmodxwheredinamicopag/", petivi_aipmanvehmodpaglist)
        Return Content(respvi_aipmanvehmodpaglist, "application/json")
    End Function


    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerPorWhereDinamicoPagvi_aipmanvehver(petivi_aipmanvehverpaglist As petivi_aipmanvehverpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipmanvehverpaglist As String = httpcliente.posthttpobj("vi_aipmanvehver/selvi_aipmanvehverxwheredinamicopag/", petivi_aipmanvehverpaglist)
        Return Content(respvi_aipmanvehverpaglist, "application/json")
    End Function







#End Region
#Region "Seleccion ID"
    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerRepuestoPorId(idaipmanrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipmanrepu As String = httpcliente.posthttpparam("aipmanrepu/selaipmanrepuxid/?idaipmanrepu=" & idaipmanrepu)
        Return Content(aipmanrepu, "application/json")
    End Function
    
    <AllowAnonymous()>
 <HttpPost()>
    Function ObtenerModelosActivosPorMarca(idaipmanvehmar As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehver As String = httpcliente.posthttpparam("aipmanvehmod/selaipmanvehmodactivosxidmarca/?idaipmanvehmar=" & idaipmanvehmar)
        Return Content(lista_aipmanvehver, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerVersionesActivasPorModelo(idaipmanvehmod As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmod As String = httpcliente.posthttpparam("aipmanvehver/selaipmanvehveractivasxidmodelo/?idaipmanvehmod=" & idaipmanvehmod)
        Return Content(lista_aipmanvehmod, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerVersionPorId(idaipmanvehver As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipmanvehver As String = httpcliente.posthttpparam("aipmanvehver/selaipmanvehverxid/?idaipmanvehver=" & idaipmanvehver)
        Return Content(aipmanvehver, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerVehiculoPorId(idaipmanveh As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipmanveh As String = httpcliente.posthttpparam("vi_aipmanveh/selvi_aipmanvehxid/?idaipmanveh=" & idaipmanveh)
        Return Content(aipmanveh, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerCodigoImei(idsegmanusu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim xcodimmandisp As String = httpcliente.posthttpparam("vi_aipusudisp/selxcodimmandispxidsegmanusu/?idsegmanusu=" & idsegmanusu)
        Return Content(xcodimmandisp, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerPorIdMarca(idaipmanvehmar As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipmanvehmar As String = httpcliente.posthttpparam("aipmanvehmar/selaipmanvehmarxid/?idaipmanvehmar=" & idaipmanvehmar)
        Return Content(lista_aipmanvehmar, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerPorIdModelo(idaipmanvehmod As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipmanvehmod As String = httpcliente.posthttpparam("aipmanvehmod/selaipmanvehmodxid/?idaipmanvehmod=" & idaipmanvehmod)
        Return Content(aipmanvehmod, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerViaipmanvehverPorIdVersiones(idaipmanvehver As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipmanvehver As String = httpcliente.posthttpparam("vi_aipmanvehver/selvi_aipmanvehverxid/?idaipmanvehver=" & idaipmanvehver)
        Return Content(aipmanvehver, "application/json")
    End Function







#End Region 
#End Region
#Region "Agregar"


    <AllowAnonymous()>
    <HttpPost()>
    Function AgregarRepuesto(aipmanrepu As aipmanrepu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/AgregarRepuestoAlUltimoBaremo/", aipmanrepu)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function AgregarUsuarioPerito(xcodimmandisp As String, itipoperito As String, vi_segmanusu As vi_segmanusu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/AgregarUsuPerito/?xcodimmandisp=" & xcodimmandisp & "&itipoperito=" & itipoperito, vi_segmanusu)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function AgregarUsuarioPorPerfil(xcodimmandisp As String, idsegmanperf As Decimal, vi_segmanusu As vi_segmanusu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/AgregarUsuarioPorPerfil/?xcodimmandisp=" & xcodimmandisp & "&idsegmanperf=" & idsegmanperf, vi_segmanusu)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function ModificarUsuarioPorPerfil(xcodimmandisp As String, idsegmanperf As Decimal, vi_segmanusu As vi_segmanusu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/ModificarUsuarioPorPerfil/?xcodimmandisp=" & xcodimmandisp & "&idsegmanperf=" & idsegmanperf, vi_segmanusu)
        Return Content(respopera, "application/json")
    End Function



    <CustomAuthorize()>
<HttpPost()>
    Function AgregarMarcas(aipmanvehmar As aipmanvehmar) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipmanvehmar/insaipmanvehmar/", aipmanvehmar)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function AgregarModelo(aipmanvehmod As aipmanvehmod) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipmanvehmod/insaipmanvehmod/", aipmanvehmod)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function AgregarVersion(aipmanvehver As aipmanvehver) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipmanvehver/insaipmanvehver/", aipmanvehver)
        Return Content(respopera, "application/json")
    End Function


#End Region

#Region "Modificar"
    <AllowAnonymous()>
    <HttpPost()>
    Function ModificarRepuesto(aipmanrepu As aipmanrepu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipmanrepu/modaipmanrepu/", aipmanrepu)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarUsuarioPerito(xcodimmandisp As String, itipoperito As String, vi_segmanusu As vi_segmanusu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/ModificarUsuPerito/?xcodimmandisp=" & xcodimmandisp & "&itipoperito=" & itipoperito, vi_segmanusu)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function ModificarMarcas(aipmanvehmar As aipmanvehmar) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipmanvehmar/modaipmanvehmar/", aipmanvehmar)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function ModificarModelo(aipmanvehmod As aipmanvehmod) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipmanvehmod/modaipmanvehmod/", aipmanvehmod)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
<HttpPost()>
    Function ModificarVersion(aipmanvehver As aipmanvehver) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipmanvehver/modaipmanvehver/", aipmanvehver)
        Return Content(respopera, "application/json")
    End Function



#End Region

#Region "Eliminar"

#End Region

End Class