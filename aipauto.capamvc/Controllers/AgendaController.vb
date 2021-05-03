Imports Newtonsoft.Json
Imports System.Net.Http
Imports estarseguros20.capacomuncliente
Imports aipauto.capamvc.aicweb.capamvc
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.agenda
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.agenda
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion

Public Class AgendaController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Agenda
    <CustomAuthorize()>
    <HttpGet()>
    Function Agenda(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_Agenda")
        Else
            Return View("Agenda")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function _Agenda() As ActionResult
        Return PartialView()
    End Function

#Region "Consultas"

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboPeritos() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/selvi_segusudetperf2combo/")
        Return Content(lista_vi_segusudetperf2, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboPeritosPorOrg(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/selvi_segusudetperf2comboPorOrg/?idsegmanorg=" & idsegmanorg)
        Return Content(lista_vi_segusudetperf2, "application/json")
    End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboPeritosPorUsuario() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        Dim idsegmanusuaudit = vi_segmanusu.idsegmanusu


        Dim lista_vi_segusudetperf2 As String = httpcliente.posthttpparam("Actividad/ObtenerComboPeritos/?idsegmanusuaudit=" & idsegmanusuaudit)
        Return Content(lista_vi_segusudetperf2, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboPeritosPorUsuarioYOrg(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        Dim idsegmanusuaudit = vi_segmanusu.idsegmanusu

        Dim lista_vi_segusudetperf2 As String = httpcliente.posthttpparam("Actividad/ObtenerComboPeritosPorOrg/?idsegmanusuaudit=" & idsegmanusuaudit & "&idsegmanorg=" & idsegmanorg)
        Return Content(lista_vi_segusudetperf2, "application/json")
    End Function





    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerContadorEventos(mes As String, anio As String, idsegmanusuperit As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        'Dim usuarioejec = vi_segmanusu.idsegmanusu
        Dim lista_eventos As String = httpcliente.posthttpparam("Actividad/ObtenerContadorEventos/?idsegmanusuperit=" & idsegmanusuperit & "&mes=" & mes & "&anio=" & anio)
        Return Content(lista_eventos, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function Obtener_Eventos(start As String, ends As String, ialcanactivperi As String, idsegmanusuperit As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        'Dim usuarioejec = vi_segmanusu.idsegmanusu
        Dim lista_eventos As String
        'lista_eventos = httpcliente.posthttpparam("vi_aipactivperidet/selvi_aipactivperidetxidsegmanusuejecstart/?start=" & start & "&ialcanactivperi=" & ialcanactivperi & "&idsegmanusuperit=" & idsegmanusuperit)

        lista_eventos = httpcliente.posthttpparam("vi_aipinsenc/ObtenerPorPeritoAlcanceYFechaInicio/?start=" & start & "&ialcanactivperi=" & ialcanactivperi & "&idsegmanusuperit=" & idsegmanusuperit)


        Return Content(lista_eventos, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerUsuarioConectado() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        Dim usuario = vi_segmanusu.xnombrecompleto
        Return Json(usuario, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function Obtener_Actividades(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        'petivi_aipactivperipaglist.vi_aipactivperi.idsegmanusucreaactivperi = vi_segmanusu.idsegmanusu

        'se coloca para buscar todos los eventos de todo el dia hasta la ultima hora
        petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi = petivi_aipinsencpaglist.vi_aipinsenc.ffinejecactivperi.AddDays(1)

        Dim respvi_aipactivperipaglist As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencxwheredinamicopag/", petivi_aipinsencpaglist)
        Return Content(respvi_aipactivperipaglist, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerActporId(idaipactivperi As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipactivperi As String = httpcliente.posthttpparam("vi_aipactivperi/selvi_aipactivperixid?idaipactivperi=" & idaipactivperi)
        Return Content(aipactivperi, "application/json")
    End Function


   
#End Region

#Region "Seleccion"
    <CustomAuthorize()>
    <HttpPost()>
    Function ObtenerComboComunconfvalor(xconcepto As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_combocomunconfvalor As String = httpcliente.posthttpparam("comunconfvalor/selcomunconfvalorxconcepto/?xconcepto=" & xconcepto)
        Return Content(lista_combocomunconfvalor, "application/json")
    End Function

#End Region

#Region "Agregar"
    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarAct(aipactivperi As aipactivperi) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        'aipactivperi.idsegmanusucreaactivperi = vi_segmanusu.idsegmanusu
        'If (aipactivperi.idsegmanusu = 0) Then
        '    aipactivperi.idsegmanusu = vi_segmanusu.idsegmanusu
        'End If
        Dim respopera As String = httpcliente.posthttpobj("Actividad/InsertarAipactivperi/", aipactivperi)
        Return Content(respopera, "application/json")
    End Function

    <CustomAuthorize()>
    <HttpPost()>
    Function AgregarInspeccionActividad(vi_aipinsenc As vi_aipinsenc) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)

        If (vi_segmanusu IsNot Nothing) Then
            vi_aipinsenc.idsegmanusucrea = vi_segmanusu.idsegmanusu
        End If

        vi_aipinsenc.iorigeninsenc = "WEB"
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionActividad/", vi_aipinsenc)
        Return Content(respopera, "application/json")
    End Function
#End Region

#Region "Eliminar"

    <CustomAuthorize()>
    <HttpPost()>
    Function EliminarPeritajePorId(idaipinsenc As Decimal) As ActionResult

        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
        Dim idsegmanusucrea = vi_segmanusu.idsegmanusu

        Dim respopera1 As New respopera


        Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")

        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/EliminarInspeccionActividad?idaipinsenc=" & idaipinsenc & "&idsegmanusu=" & idsegmanusucrea & "&idsegmanapp=" & idsegmanapp)
        Return Content(respopera, "application/json")
    End Function

#End Region

#Region "Modificar"
    '<CustomAuthorize()>
    '<HttpPost()>
    'Function ModificarActividar(aipactivperi As aipactivperi) As ActionResult
    '    Dim httpcliente As New basehttpcliente
    '    Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
    '    'aipactivperi.idsegmanusucreaactivperi = vi_segmanusu.idsegmanusu
    '    aipactivperi.iestatactivperi = "PENDIENTE"
    '    Dim idsegmanusucrea = vi_segmanusu.idsegmanusu
    '    Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
    '    Dim permisos As String = httpcliente.posthttpparam("Actividad/VerificarPermisos?idaipactivperi=" & aipactivperi.idaipactivperi & "&idsegmanusucrea=" & idsegmanusucrea & "&idsegmanapp=" & idsegmanapp)
    '    Dim permisos1 As Boolean = JsonConvert.DeserializeObject(Of Boolean)(permisos)
    '    If permisos1 Then
    '        Dim respopera As String = httpcliente.posthttpobj("aipactivperi/modaipactivperi/", aipactivperi)
    '        Return Content(respopera, "application/json")
    '    Else
    '        Dim respopera As New respopera
    '        respopera.id = 0
    '        respopera.xmsjusuario = "Usted no tiene permisos para modificar este evento"
    '        respopera.xmsjtecnico = "Este usuario no es administrador ni creador de vuelo"
    '        Dim respopera1 As String = JsonConvert.SerializeObject(respopera)
    '        Return Content(respopera1, "application/json")
    '    End If

    'End Function


    <CustomAuthorize()>
    <HttpPost()>
    Function ModificarInspeccionYActividad(vi_aipinsenc As vi_aipinsenc) As ActionResult

        Try

            Dim httpcliente As New basehttpcliente
            Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
            'aipactivperi.idsegmanusucreaactivperi = vi_segmanusu.idsegmanusu

            Dim respopera1 As New respopera
            Dim _respopera2 As String

            'vi_aipinsenc.iestatactivperi = "PENDIENTE"
            Dim idsegmanusucrea = vi_segmanusu.idsegmanusu
            Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            Dim respopera As String = httpcliente.posthttpparam("Actividad/VerificarPermisos?idaipinsenc=" & vi_aipinsenc.idaipinsenc & "&idsegmanusucrea=" & idsegmanusucrea & "&idsegmanapp=" & idsegmanapp)
            respopera1 = JsonConvert.DeserializeObject(Of respopera)(respopera)
            If respopera1 IsNot Nothing Then

                If (respopera1.irespuesta = "1") Then
                    Dim _respopera As String = httpcliente.posthttpobj("Inspeccion/ModificarInspeccionActividad/", vi_aipinsenc)
                    Return Content(_respopera, "application/json")
                Else

                    respopera1 = New respopera

                    respopera1.irespuesta = "0"
                    respopera1.xmsjusuario = "Usted no tiene permisos para modificar esta actividad"
                    _respopera2 = JsonConvert.SerializeObject(respopera1)
                    Return Content(_respopera2, "application/json")
                End If
            Else
                respopera1 = New respopera

                respopera1.id = 0
                respopera1.xmsjusuario = "Usted no tiene permisos para modificar esta actividad"
                respopera1.xmsjtecnico = "Usted no tiene permisos para modificar esta actividad"
                _respopera2 = JsonConvert.SerializeObject(respopera1)
                Return Content(_respopera2, "application/json")
            End If

        Catch ex As Exception
            Dim respopera1 As New respopera
            respopera1.id = 0
            respopera1.xmsjusuario = "Ha ocurrido un error verificando los permisos de usuario"
            respopera1.xmsjtecnico = "Ha ocurrido un error verificando los permisos de usuario"
            Dim _respopera2 As String = JsonConvert.SerializeObject(respopera1)
            Return Content(_respopera2, "application/json")
        End Try

    End Function
#End Region
End Class