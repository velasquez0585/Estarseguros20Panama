Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Dynamic
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbbrofinza.entidades.seguridad

Public Class MantenimientoController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Mantenimiento

#Region "Vista"
    <CustomAuthorize()>
    <HttpGet()>
    Function ManUsuario(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManUsuario")
        Else
            Return View("ManUsuario")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function ManPerfiles(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManPerfiles")
        Else
            Return View("ManPerfiles")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function ManAplicaciones(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_ManAplicaciones")
        Else
            Return View("ManAplicaciones")
        End If
    End Function

#End Region

#Region "Seleccion"

    '<CustomAuthorize()>
    '<HttpPost()>
    'Function ObtenerUsuarios(petivi_segmanusupaglist As petivi_segmanusupaglist) As ActionResult
    '    Dim httpcliente As New basehttpcliente
    '    Dim respvi_segmanusupaglist As String = httpcliente.posthttpobj("vi_segmanusu/selvi_segmanusuxwheredinamicopag/", petivi_segmanusupaglist)
    '    Return Content(respvi_segmanusupaglist, "application/json")
    'End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerUsuarioPorId(idsegmanusu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As String = httpcliente.posthttpparam("vi_segmanusu/selvi_segmanusuxidpost/?idsegmanusu=" & idsegmanusu)
        Return Content(vi_segmanusu, "application/json")
    End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerPerfilPorId(idsegmanperf As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim segmanperf As String = httpcliente.posthttpparam("segmanperf/selsegmanperfxid/?idsegmanperf=" & idsegmanperf)
        Return Content(segmanperf, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerPerfilesPorUsuyApp(idsegmanusu As Integer, idsegmanapp As Integer) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segusuperf As String = httpcliente.gethttpstring("vi_segusuperf/selvi_segusuperfxappyusu/?idsegmanusu=" & idsegmanusu & "&idsegmanapp=" & idsegmanapp)
        Return Content(vi_segusuperf, "application/json")

    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerPerfiles(petisegmanperfpaglist As petisegmanperfpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respsegmanperfpaglist As String = httpcliente.posthttpobj("segmanperf/selsegmanperfxwheredinamicopag/", petisegmanperfpaglist)
        Return Content(respsegmanperfpaglist, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerListaPerfiles() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_segmanperf As String = httpcliente.posthttpparam("segmanperf/selsegmanperf/")
        Return Content(lista_segmanperf, "application/json")
    End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerPerfilesPorApp(idsegmanapp As Integer) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_segappperf As String = httpcliente.posthttpparam("vi_segappperf/selvi_segappperfxapp/?idsegmanapp=" & idsegmanapp)
        Return Content(lista_vi_segappperf, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerPerfilesPorAppCheck(idsegmanapp As Integer) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_segmanperf As String = httpcliente.posthttpparam("Seguridad/ObtenerPerfilesXAppCheck/?idsegmanapp=" & idsegmanapp)
        Return Content(lista_segmanperf, "application/json")
    End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerPerfilesPorAppPag(petivi_segappperfpaglist As petivi_segappperfpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_segappperfpaglist As String = httpcliente.posthttpobj("vi_segappperf/selvi_segappperfxwheredinamicopag/", petivi_segappperfpaglist)
        Return Content(respvi_segappperfpaglist, "application/json")
    End Function


    '<CustomAuthorize()>
    '<HttpPost()>
    'Function ObtenerConfAppProg(petivi_segappprogpaglist As petivi_segappprogpaglist) As ActionResult
    '    Dim httpcliente As New basehttpcliente
    '    Dim respvi_segappprogpaglist As String = httpcliente.posthttpobj("vi_segappprog/selvi_segappprogxwheredinamicopag/", petivi_segappprogpaglist)
    '    Return Content(respvi_segappprogpaglist, "application/json")
    'End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerConfAppProgPorId(idsegappprog As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segappprog As String = httpcliente.gethttpstring("vi_segappprog/selvi_segappprogxid/?idsegappprog=" & idsegappprog)
        Return Content(vi_segappprog, "application/json")
    End Function




    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerOrganizaciones() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunmanempr As String = httpcliente.posthttpparam("comunmanempr/selcomunmanempr/")
        Return Content(lista_comunmanempr, "application/json")

    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerAplicaionesPorPerfil(idsegmanperf As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_segappperf As String = httpcliente.posthttpparam("vi_segappperf/selvi_segappperfxperf/?idsegmanperf=" & idsegmanperf)
        Return Content(lista_vi_segappperf, "application/json")
    End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerConfAppProgPorAplicacion(idsegmanapp As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_segappprog As String = httpcliente.gethttpstring("vi_segappprog/selvi_segappprogxapp/?idsegmanapp=" & idsegmanapp)
        Return Content(lista_vi_segappprog, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerConfAppProgPorAplicacionCheck(idsegmanperf As Decimal, idsegmanapp As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_segappprog_check As String = httpcliente.posthttpparam("Seguridad/ObtenerViAppProgxAppCheck/?idsegmanperf=" & idsegmanperf & "&idsegmanapp=" & idsegmanapp)
        Return Content(lista_vi_segappprog_check, "application/json")
    End Function

    'Seleccion de combos

    <CustomAuthorize()>
   <HttpPost()>
    Function ObtenerComboAplicaciones() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_segmanapp As String = httpcliente.gethttpstring("segmanapp/selsegmanapp/")
        Return Content(lista_segmanapp, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboModulo() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_segmanmod As String = httpcliente.posthttpparam("segmanmod/selsegmanmod/")
        Return Content(lista_segmanmod, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboSubModulo() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_segmansubmod As String = httpcliente.posthttpparam("segmansubmod/selsegmansubmod/")
        Return Content(lista_segmansubmod, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboPrograma() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_segmanprog As String = httpcliente.posthttpparam("segmanprog/selsegmanprog/")
        Return Content(lista_segmanprog, "application/json")
    End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboDepartamentos() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_segmandep As String = httpcliente.posthttpparam("segmandep/selsegmandep/")
        Return Content(lista_segmandep, "application/json")

    End Function

#End Region


#Region "Agregar"

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarUsuario(vi_segmanusu As vi_segmanusu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("seguridad/AgregarUsu/", vi_segmanusu)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarPerfil(segmanperf As segmanperf) As ActionResult
        Dim httpcliente As New basehttpcliente
        segmanperf.xnombreperf = segmanperf.xnombreperf.ToUpper
        segmanperf.xabrevperf = segmanperf.xabrevperf.ToUpper
        Dim respopera As String = httpcliente.posthttpobj("segmanperf/inssegmanperf/", segmanperf)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function GuardarPerfilPorAplicacion(idsegmanusu As Integer, idsegmanapp As Integer, idsegmanperf As Integer) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("seguridad/Guardar_Perfil_Aplicacion/?idsegmanusu=" & idsegmanusu & "&idsegmanapp=" & idsegmanapp & "&idsegmanperf=" & idsegmanperf)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarPerfilesPorApp(idsegmanapp As Integer, idsegmanperf As Integer) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("seguridad/InsertarPerfilAplicacion/?idsegmanapp=" & idsegmanapp & "&idsegmanperf=" & idsegmanperf)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarPerfilesPorApp1(segappperf As segappperf) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segappperf/inssegappperf/", segappperf)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarAplicacion(segmanapp As segmanapp, organizaciones As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        segmanapp.fimplementacion = DateTime.Now
        Dim respopera As String = httpcliente.posthttpobj("segmanapp/inssegmanapp/", segmanapp)
        Dim idsegmanapp As Integer = 0
        Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(respopera)

        Dim respopera1 As String = ""

        If objeto.irespuesta = "1" Then
            Dim lista_org As String() = organizaciones.Split(",")
            For Each org As Decimal In lista_org
                Dim segorgapp As New segorgapp
                segorgapp.idsegmanorg = org
                segorgapp.idseglogreg = 0
                segorgapp.idsegmanapp = objeto.id

                respopera1 = httpcliente.posthttpobj("segorgapp/inssegorgapp/", segorgapp)
            Next
        End If


        Return Content(respopera, "application/json")


    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarModulo(segmanmod As segmanmod) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segmanmod/inssegmanmod/", segmanmod)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarSubModulo(segmansubmod As segmansubmod) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segmansubmod/inssegmansubmod/", segmansubmod)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarPrograma(segmanprog As segmanprog) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segmanprog/inssegmanprog/", segmanprog)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarConfiguracionPrograma(vi_segappprog As vi_segappprog) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segappprog/inssegappprog/", vi_segappprog)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarTipoAcceso(idsegmanperf As Decimal, idsegappprog As Decimal, tipo_acceso As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("Seguridad/InsertarTipoAcceso/?idsegmanperf=" & idsegmanperf & "&idsegappprog= " & idsegappprog & "&tipo_acceso=" & tipo_acceso)
        Return Content(respopera, "application/json")
    End Function


#End Region

#Region "Modificar"

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarUsuario(vi_segmanusu As vi_segmanusu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("seguridad/ModificarUsu/", vi_segmanusu)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarPerfil(segmanperf As segmanperf) As ActionResult
        Dim httpcliente As New basehttpcliente
        segmanperf.xnombreperf = segmanperf.xnombreperf.ToUpper
        segmanperf.xabrevperf = segmanperf.xabrevperf.ToUpper
        Dim respopera As String = httpcliente.posthttpobj("segmanperf/modsegmanperf/", segmanperf)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarConfiguracionPrograma(segappprog As segappprog) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segappprog/modsegappprog/", segappprog)
        Return Content(respopera, "application/json")
    End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarAplicacion(segmanapp As segmanapp, organizaciones As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        segmanapp.fimplementacion = DateTime.Now
        Dim respopera As String = httpcliente.posthttpobj("segmanapp/modsegmanapp/", segmanapp)

        'Dim lista_org As String() = organizaciones.Split(",")
        'For Each org As Decimal In lista_org
        '    Dim segorgapp As New segorgapp
        '    segorgapp.idsegmanorg = org
        '    segorgapp.idseglogreg = 0
        '    respopera = httpcliente.posthttpobj("segorgapp/modsegorgapp/", segorgapp)
        'Next
        Return Content(respopera, "application/json")


    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarModulo(segmanmod As segmanmod) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segmanmod/modsegmanmod/", segmanmod)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarSubModulo(segmansubmod As segmansubmod) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segmansubmod/modsegmansubmod/", segmansubmod)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarPrograma(segmanprog As segmanprog) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("segmanprog/modsegmanprog/", segmanprog)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarTipoAcceso(idsegaccperf As Decimal, tipo_acceso As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("Seguridad/ModificarTipoAcceso/?idsegaccperf=" & idsegaccperf & "&tipo_acceso=" & tipo_acceso)
        Return Content(respopera, "application/json")
    End Function

#End Region

#Region "Eliminar"

    <CustomAuthorize()>
    <HttpPost()>
    Function EliminarPerfilesPorApp(idsegappperf As Integer) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("segappperf/elisegappperf/?idsegappperf=" & idsegappperf)
        Return Content(respopera, "application/json")
    End Function

#End Region


End Class