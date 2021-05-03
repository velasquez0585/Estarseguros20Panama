Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports estarseguros20.capaobjetos
Imports System.IO
Imports Newtonsoft.Json


Public Class InspeccionController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Inspeccion

#Region "Vistas"
    <Authorize()>
 <HttpPost()>
    Function InspeccionFoto() As ActionResult
        Return PartialView("__InsFotoModal1")

    End Function

    <Authorize()>
<HttpPost()>
    Function InspeccionVideos() As ActionResult
        Return PartialView("__InsVideosBuscar1")
    End Function

    <Authorize()>
  <HttpGet()>
    Function InspeccionProcesar(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsProc")
        Else
            Return View("InsProc")
        End If
    End Function

    <Authorize()>
    <HttpGet()>
    Function InsAudit(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsAudit")
        Else
            Return View("InsAudit")
        End If
    End Function

    <Authorize()>
    <HttpGet()>
    Function InsConsAudit(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsConsAudit")
        Else
            Return View("InsConsAudit")
        End If
    End Function

    <Authorize()>
    <HttpGet()>
    Function InsConsPto(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsConsPto")
        Else
            Return View("InsConsPto")
        End If
    End Function

    <Authorize()>
       <HttpGet()>
    Function InsSus(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsSus")
        Else
            Return View("InsSus")
        End If
    End Function

    <Authorize()>
   <HttpGet()>
    Function InsRest(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsSus")
        Else
            Return View("InsSus")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsAdminActiAudMasiva(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsAdminActiAudMasiva")
        Else
            Return View("InsAdminActiAudMasiva")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsAdminActiPeritMasiva(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsAdminActiPeritMasiva")
        Else
            Return View("InsAdminActiPeritMasiva")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsAdminActividades(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsAdminActividades")
        Else
            Return View("InsAdminActividades")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsConsCasosPorPerit(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsConsCasosPorPerit")
        Else
            Return View("InsConsCasosPorPerit")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsConsCasosPorAudit(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsConsCasosPorAudit")
        Else
            Return View("InsConsCasosPorAudit")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsIntermediacion(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsInterm")
        Else
            Return View("InsInterm")
        End If
    End Function

    <AllowAnonymous()>
    <HttpGet()>
    Function InspeccionVideos(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsVideos")
        Else
            Return View("InsVideos")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsPreCargaInterm(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsPreCargaInterm")
        Else
            Return View("InsPreCargaInterm")
        End If
    End Function


    <CustomAuthorize()>
    <HttpGet()>
    Function InsPreCarg(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsPreCarg")
        Else
            Return View("InsPreCarg")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InspeccionConsultaAdmin(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsConsAdmin")
        Else
            Return View("InsConsAdmin")
        End If
    End Function

    <CustomAuthorize()>
    <HttpGet()>
    Function InsConsAnexPerit(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_InsConsAnexPerit")
        Else
            Return View("InsConsAnexPerit")
        End If
    End Function


#End Region
#Region "cargas"

    <Authorize()>
 <HttpPost()>
    Function ObtenerInspeccionesPorProcesar(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As ActionResult

        'se asigna el id para que solo busque las insopecciones de su usuari
        petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit = System.Web.HttpContext.Current.Session("idsegmanusu")



        Dim httpcliente As New basehttpcliente
        Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencxprocpag/", petivi_aipinsencpaglist)
        Return Content(respvi_aipinsencpaglist, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionesPorProcesarPorPerito(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As ActionResult
        petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc = "POR PROCESAR"
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencxwheredinamicopag/", petivi_aipinsencpaglist)
        Return Content(respvi_aipinsencpaglist, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionesPorProcesarPorAuditor(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As ActionResult
        petivi_aipinsencpaglist.vi_aipinsenc.iestatinsenc = "POR AUDITAR"
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencxwheredinamicopag/", petivi_aipinsencpaglist)
        Return Content(respvi_aipinsencpaglist, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionesPorAuditar(petivi_aipinsencpaglist As petivi_aipinsencpaglist) As ActionResult
        petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim httpcliente As New basehttpcliente
        'Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencxauditpag/", petivi_aipinsencpaglist)
        Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("Inspeccion/ObtenerInspeccionesXauditar/", petivi_aipinsencpaglist)
        Return Content(respvi_aipinsencpaglist, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ObtenerInspecciones(petivi_aipinsencpaglist As petivi_aipinsencpaglist, Optional idsegmanusu As Decimal = 0) As ActionResult
        petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuperit = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencxwheredinamicopag/", petivi_aipinsencpaglist)
        Return Content(respvi_aipinsencpaglist, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionMenosProcedentes(petivi_aipinsencpaglist As petivi_aipinsencpaglist, Optional idsegmanusu As Decimal = 0) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("vi_aipinsenc/ObtenerInspeccionMenosProcedentes/", petivi_aipinsencpaglist)
        Return Content(respvi_aipinsencpaglist, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionesAuditor(petivi_aipinsencpaglist As petivi_aipinsencpaglist, Optional idsegmanusu As Decimal = 0) As ActionResult
        Dim httpcliente As New basehttpcliente
        petivi_aipinsencpaglist.vi_aipinsenc.idsegmanusuaudit = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respvi_aipinsencpaglist As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencconsultapag/", petivi_aipinsencpaglist)
        Return Content(respvi_aipinsencpaglist, "application/json")
    End Function


    <Authorize()>
 <HttpPost()>
    Function ObtenerInspeccionSuscripcionPorIdInsEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinssus As String = httpcliente.posthttpparam("vi_aipinssus/selvi_aipinssusxidinsenc?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinssus, "application/json")
    End Function


    <Authorize()>
   <HttpPost()>
   <FileDownload()>
    Function ObtenerInspeccionFotoPorInspeccionEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim listaResult As New List(Of datosfoto)
        Dim ListDownloadFilesResult As List(Of DownloadFilesResult) = httpcliente.gethttplistdownload("Inspeccion/ObtenerInspeccionFotoPorInspeccionEnc/?idaipinsenc=" & idaipinsenc)
        For Each DownloadFilesResult As DownloadFilesResult In ListDownloadFilesResult
            If DownloadFilesResult.Name.ToString <> String.Empty Then
                System.IO.File.WriteAllBytes(Server.MapPath("~/publico/imagenes/imagenes_movil/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
                listaResult.Add(New datosfoto)
                Dim i = listaResult.Count
                listaResult.Item(i - 1).ruta = "/publico/imagenes/imagenes_movil/" & DownloadFilesResult.Name.ToString
                listaResult.Item(i - 1).nombre = DownloadFilesResult.Name.ToString
                'listaResult.Add("/publico/imagenes/" & DownloadFilesResult.Name.ToString)
            End If
        Next
        Dim jSearializer As New System.Web.Script.Serialization.JavaScriptSerializer()

        Return Content(jSearializer.Serialize(listaResult), "application/json")
    End Function

    <Authorize()>
  <HttpPost()>
  <FileDownload()>
    Function girarImagen(idaipinsenc As Decimal, xnomarchinsfoto As String, grados As Decimal, contador As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim datosfoto As New datosfoto
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/girarImagen/?idaipinsenc=" & idaipinsenc & "&xnomarchinsfoto=" & xnomarchinsfoto & "&grados=" & grados)
        Dim xextinsfoto = ".jpg"

        If Not DownloadFilesResult Is Nothing Then


            If DownloadFilesResult.Name.ToString <> String.Empty Then

                Dim nomb_arch_ant As String = DownloadFilesResult.Name.Replace(".jpg", "(" & (contador - 1).ToString & ")") & xextinsfoto

                If System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch_ant)) Then
                    System.IO.File.Delete(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch_ant))
                End If


                Dim nomb_arch As String = DownloadFilesResult.Name.Replace(".jpg", "(" & contador.ToString & ")") & xextinsfoto
                'se verifica si la imagen existe para eliminarla y crearla nuevamente
                If System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch)) Then
                    System.IO.File.Delete(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch))
                End If

                System.IO.File.WriteAllBytes(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch), DownloadFilesResult.ArchivoByte)
                datosfoto.ruta = "/publico/imagenes/imagenes_movil/zoom/" & nomb_arch
                datosfoto.nombre = nomb_arch

            Else

                datosfoto.ruta = "/publico/imagenes/img_no_disponible.jpg"
                datosfoto.nombre = "img_no_disponible.jpg"
            End If

        Else
            datosfoto.ruta = "/publico/imagenes/img_no_disponible.jpg"
            datosfoto.nombre = "img_no_disponible.jpg"
        End If

        Dim jSearializer As New System.Web.Script.Serialization.JavaScriptSerializer()

        Return Content(jSearializer.Serialize(datosfoto), "application/json")
    End Function

    <Authorize()>
  <HttpPost()>
  <FileDownload()>
    Function ObtenerInspeccionFotoPorInspeccionEncyXNombFoto(idaipinsenc As Decimal, xnomarchinsfoto As String, contador As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim datosfoto As New datosfoto
        Dim xextinsfoto = ".jpg"

        If System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto)) Then
            System.IO.File.Delete(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto))
        End If

        If Not System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto)) Then

            Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ObtenerInspeccionFotoPorEncyNombFoto/?idaipinsenc=" & idaipinsenc & "&xnomarchinsfoto=" & xnomarchinsfoto)

            If Not DownloadFilesResult Is Nothing Then


                If DownloadFilesResult.Name.ToString <> String.Empty Then

                    Dim nomb_arch_ant As String = DownloadFilesResult.Name.Replace(".jpg", "(" & (contador - 1).ToString & ")") & xextinsfoto
                    If System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch_ant)) Then
                        System.IO.File.Delete(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch_ant))
                    End If


                    Dim nomb_arch As String = DownloadFilesResult.Name.Replace(".jpg", "(" & contador.ToString & ")") & xextinsfoto

                    System.IO.File.WriteAllBytes(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch), DownloadFilesResult.ArchivoByte)

                    datosfoto.ruta = "/publico/imagenes/imagenes_movil/zoom/" & nomb_arch
                    datosfoto.nombre = nomb_arch

                Else

                    datosfoto.ruta = "/publico/imagenes/img_no_disponible.jpg"
                    datosfoto.nombre = "img_no_disponible.jpg"
                End If

            Else
                datosfoto.ruta = "/publico/imagenes/img_no_disponible.jpg"
                datosfoto.nombre = "img_no_disponible.jpg"
            End If

        Else

            datosfoto.ruta = "/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto
            datosfoto.nombre = xnomarchinsfoto

        End If

        Dim jSearializer As New System.Web.Script.Serialization.JavaScriptSerializer()

        Return Content(jSearializer.Serialize(datosfoto), "application/json")
    End Function




    <Authorize()>
 <HttpPost()>
    Function ObtenerInspeccionFotoPorPos(idaipinsenc As Decimal, nsecinsfoto As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As String = httpcliente.posthttpparam("Inspeccion/ObtenerInspeccionFotoPorPos?idaipinsenc=" & idaipinsenc & "&nsecinsfoto=" & nsecinsfoto)
        Return Content(DownloadFilesResult, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function EliminarFotoInspeccion(idaipinsenc As Decimal, xnomarchinsfoto As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")

        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/EliminarFotoInspeccion2?idaipinsenc=" & idaipinsenc & "&xnomarchinsfoto=" & xnomarchinsfoto & "&idsegmanusu=" & idsegmanusu)
        Return Content(respopera, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function ObtenerArchivosPorEncYTipo(idaipinsenc As Decimal, itipoinsarch As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsarch As String = httpcliente.posthttpparam("Inspeccion/ObtenerInspeccionArchivoPorInsEncYTipo?idaipinsenc=" & idaipinsenc & "&itipoinsarch=" & itipoinsarch)
        Return Content(lista_vi_aipinsarch, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function EliminarArchivoPorid(idaipinsarch As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/EliminarArchivoPoridArch?idaipinsarch=" & idaipinsarch)
        Return Content(respopera, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function GetObtenerArchivosPorEncYTipo(idaipinsenc As Decimal, itipoinsarch As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsarch As List(Of vi_aipinsarch) = httpcliente.gethttplistArch("Inspeccion/ObtenerInspeccionArchivoPorInsEncYTipo?idaipinsenc=" & idaipinsenc & "&itipoinsarch=" & itipoinsarch)
        Dim idaipinsarch As Int64 = 0
        Dim xrutabase As String = Server.MapPath("~/publico/audio/")
        If (lista_vi_aipinsarch.Count > 0) Then
            For Each vi_aipinsarch As vi_aipinsarch In lista_vi_aipinsarch
                ''se recorren para ir verificando si el archivo existe
                idaipinsarch = vi_aipinsarch.idaipinsarch
                If (Not System.IO.File.Exists(xrutabase & vi_aipinsarch.xnominsarch)) Then
                    Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ObtenerArchivoAipinsarchPorid/?idaipinsarch=" & idaipinsarch)
                    If (DownloadFilesResult IsNot Nothing) Then
                        System.IO.File.WriteAllBytes(xrutabase & vi_aipinsarch.xnominsarch, DownloadFilesResult.ArchivoByte)
                    End If
                End If

                vi_aipinsarch.xurlinsarch = xrutabase & vi_aipinsarch.xnominsarch

            Next
        End If

        Dim lista As String = JsonConvert.SerializeObject(lista_vi_aipinsarch)
        Return Content(lista, "application/json")
    End Function




    'ObtenerInspeccionArchivoPorid

    'ObtenerArchivoAipinsarchPorid

    'ObtenerInspecionAudioPorEnc

    <Authorize()>
 <HttpPost()>
 <FileDownload()>
    Function ObtenerArchivoProId(idaipinsenc As Decimal, xnomarchinsfoto As String, contador As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim datosfoto As New datosfoto
        Dim xextinsfoto = ".jpg"

        If System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto)) Then
            System.IO.File.Delete(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto))
        End If

        If Not System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto)) Then

            Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ObtenerInspeccionFotoPorEncyNombFoto/?idaipinsenc=" & idaipinsenc & "&xnomarchinsfoto=" & xnomarchinsfoto)

            If Not DownloadFilesResult Is Nothing Then


                If DownloadFilesResult.Name.ToString <> String.Empty Then

                    Dim nomb_arch_ant As String = DownloadFilesResult.Name.Replace(".jpg", "(" & (contador - 1).ToString & ")") & xextinsfoto
                    If System.IO.File.Exists(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch_ant)) Then
                        System.IO.File.Delete(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch_ant))
                    End If


                    Dim nomb_arch As String = DownloadFilesResult.Name.Replace(".jpg", "(" & contador.ToString & ")") & xextinsfoto

                    System.IO.File.WriteAllBytes(Server.MapPath("~/publico/imagenes/imagenes_movil/zoom/" & nomb_arch), DownloadFilesResult.ArchivoByte)

                    datosfoto.ruta = "/publico/imagenes/imagenes_movil/zoom/" & nomb_arch
                    datosfoto.nombre = nomb_arch

                Else

                    datosfoto.ruta = "/publico/imagenes/img_no_disponible.jpg"
                    datosfoto.nombre = "img_no_disponible.jpg"
                End If

            Else
                datosfoto.ruta = "/publico/imagenes/img_no_disponible.jpg"
                datosfoto.nombre = "img_no_disponible.jpg"
            End If

        Else

            datosfoto.ruta = "/publico/imagenes/imagenes_movil/zoom/" & xnomarchinsfoto
            datosfoto.nombre = xnomarchinsfoto

        End If

        Dim jSearializer As New System.Web.Script.Serialization.JavaScriptSerializer()

        Return Content(jSearializer.Serialize(datosfoto), "application/json")
    End Function



    <Authorize()>
<HttpPost()>
    Function ObtenerMotivosInspeccionSusActivos(idaipinssus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinssusmotiv As String = httpcliente.posthttpparam("Inspeccion/ObtenerMotivosInspeccionSusActivos?idaipinssus=" & idaipinssus)
        Return Content(lista_vi_aipinssusmotiv, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerRepuestosSuscripcionEstadGen(idaipinssus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipinssusrepuest As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosSuscripcionEstadGen?idaipinssus=" & idaipinssus)
        Return Content(lista_aipinssusrepuest, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerRepuestosSuscripcionEstadGenPorColum(idaipinssus As Decimal, numColum As Integer) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipinssusrepuest As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosSuscripcionEstadGenPorColum?idaipinssus=" & idaipinssus & "&numColum=" & numColum)
        Return Content(lista_aipinssusrepuest, "application/json")
    End Function

    <Authorize()>
 <HttpPost()>
    Function ObtenerSuscripcionAccVeh(idaipinssus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipinssusacc As String = httpcliente.posthttpparam("Inspeccion/ObtenerSuscripcionAccVeh?idaipinssus=" & idaipinssus)
        Return Content(lista_aipinssusacc, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerSuscripcionSseVeh(idaipinssus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipinssussse As String = httpcliente.posthttpparam("Inspeccion/ObtenerSuscripcionSseVeh?idaipinssus=" & idaipinssus)
        Return Content(lista_aipinssussse, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerSuscripcionSsmVeh(idaipinssus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipinssusssm As String = httpcliente.posthttpparam("Inspeccion/ObtenerSuscripcionSsmVeh?idaipinssus=" & idaipinssus)
        Return Content(lista_aipinssusssm, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionRestosPorIdInsEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinsrest As String = httpcliente.posthttpparam("vi_aipinsrest/selvi_aipinsrestxidinsenc?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinsrest, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerSseRestos(idaipinsrest As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsrestsse As String = httpcliente.posthttpparam("Inspeccion/ObtenerSseRestos?idaipinsrest=" & idaipinsrest)
        Return Content(lista_vi_aipinsrestsse, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ObtenerSsmRestos(idaipinsrest As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsrestssm As String = httpcliente.posthttpparam("Inspeccion/ObtenerSsmRestos?idaipinsrest=" & idaipinsrest)
        Return Content(lista_vi_aipinsrestssm, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ObtenerRepuestosRestosEstado(idaipinsrest As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsrestrepuest As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosRestosEstado?idaipinsrest=" & idaipinsrest)
        Return Content(lista_vi_aipinsrestrepuest, "application/json")
    End Function

    <Authorize()>
    <HttpPost()>
    Function ObtenerInspeccionesProcesarXidaipinsencandxnomarchinsfoto(idaipinsenc As Decimal, xnomarchinsfoto As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinsfoto As String = httpcliente.posthttpparam("vi_aipinsfoto/selvi_aipinsfotoxididaipinsencandxnomarchinsfoto?idaipinsenc=" & idaipinsenc & "&xnomarchinsfoto=" & xnomarchinsfoto)
        Return Content(vi_aipinsfoto, "application/json")
    End Function

    'Obtener la inspeccion por id de encabezado
    <CustomAuthorize()>
   <HttpPost()>
    Function ObtenerInspeccionPorId(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinsenc As String = httpcliente.posthttpparam("vi_aipinsenc/selvi_aipinsencxid?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinsenc, "application/json")
    End Function


    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerInspeccionesPorTipo(itipoaccion As String, petivi_aipinsencpaglist As petivi_aipinsencpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim vi_aipinsenc As String = httpcliente.posthttpobj("vi_aipinsenc/selvi_aipinsencxwheredinamicopagYTipoAccion?itipoaccion=" & itipoaccion, petivi_aipinsencpaglist)

        Return Content(vi_aipinsenc, "application/json")
    End Function

    ''*******************************************************************************
    ''*******************************************************************************
    'obtener perito distribucion detalle 

    ''peritos Internos
    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerPeritosInternos(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinsdistperitdet As String = httpcliente.posthttpparam("vi_aipinsdistperitdet/selvi_aipinsdistperitdetxperitosinternos?idsegmanorg=" & idsegmanorg)

        Return Content(lista_vi_aipinsdistperitdet, "application/json")
    End Function

    ''peritos Internos y Lider Sucursal
    <CustomAuthorize()>
       <HttpPost()>
    Function ObtenerPeritosInternosYLiderSuc(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinsdistperitdet As String = httpcliente.posthttpparam("vi_aipinsdistperitdet/selvi_aipinsdistperitdetxperitosinternosylidersuc?idsegmanorg=" & idsegmanorg)

        Return Content(lista_vi_aipinsdistperitdet, "application/json")
    End Function

    ''peritos Externos
    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerPeritosExternos(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinsdistperitdet As String = httpcliente.posthttpparam("vi_aipinsdistperitdet/selvi_aipinsdistperitdetxperitosexternos?idsegmanorg=" & idsegmanorg)

        Return Content(lista_vi_aipinsdistperitdet, "application/json")
    End Function

    ''peritos Externos y Lider Suc
    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerPeritosExternosYLiderSuc(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinsdistperitdet As String = httpcliente.posthttpparam("vi_aipinsdistperitdet/selvi_aipinsdistperitdetxperitosexternosylidersuc?idsegmanorg=" & idsegmanorg)

        Return Content(lista_vi_aipinsdistperitdet, "application/json")
    End Function

    'fin perito distribucion detalle 
    ''*******************************************************************************
    ''*******************************************************************************


    ''*******************************************************************************
    ''*******************************************************************************
    'Inicio Auditor distribucion detalle 

    ''Auditor y Lideres
    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerAuditoresYLideresPorSuc(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinsdistauditdet As String = httpcliente.posthttpparam("vi_aipinsdistauditdet/selvi_aipinsdistauditdetauditoresylideres?idsegmanorg=" & idsegmanorg)

        Return Content(lista_vi_aipinsdistauditdet, "application/json")
    End Function



    ''Auditores y lideres Sucursal
    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerAuditoresYLideresSucPorSuc(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinsdistauditdet As String = httpcliente.posthttpparam("vi_aipinsdistauditdet/selvi_aipinsdistauditdetauditoresyliderSuc?idsegmanorg=" & idsegmanorg)

        Return Content(lista_vi_aipinsdistauditdet, "application/json")
    End Function


    ''Auditores
    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerAuditoresPorSuc(idsegmanorg As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinsdistauditdet As String = httpcliente.posthttpparam("vi_aipinsdistauditdet/selvi_aipinsdistauditdetauditores?idsegmanorg=" & idsegmanorg)

        Return Content(lista_vi_aipinsdistauditdet, "application/json")
    End Function

    'fin Auditor distribucion detalle 
    ''*******************************************************************************
    ''*******************************************************************************

    <CustomAuthorize()>
        <HttpPost()>
    Function ObtenerSuscripcionInfComplementaria(idaipinssus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente

        Dim lista_vi_aipinssusinfcomp As String = httpcliente.posthttpparam("Inspeccion/ObtenerSuscripcionInfComplementaria?idaipinssus=" & idaipinssus)

        Return Content(lista_vi_aipinssusinfcomp, "application/json")
    End Function



    <CustomAuthorize()>
    <HttpPost()>
    Function SubirFotoInspeccion(idaipinsenc As Decimal) As ActionResult
        Dim respopera As String = ""
        Dim httpcliente As New basehttpcliente
        For Each archivo As String In Request.Files
            Dim hpf As HttpPostedFileBase = TryCast(Request.Files(archivo), HttpPostedFileBase)
            Dim savedFileName As String = Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(hpf.FileName))

            Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")

            Dim UploadFilesResult As New UploadFilesResult
            UploadFilesResult.Type = Path.GetExtension(savedFileName)
            hpf.SaveAs(savedFileName)
            UploadFilesResult.ArchivoByte = System.IO.File.ReadAllBytes(Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(hpf.FileName)))
            'UploadFilesResult.obj_byte = System.IO.File.ReadAllBytes(savedFileName)
            UploadFilesResult.Name = hpf.FileName
            UploadFilesResult.Length = hpf.ContentLength
            respopera = httpcliente.posthttpobj("Inspeccion/SubirArchivoInspeccion/?idaipinsenc=" & idaipinsenc & "&idsegmanusu=" & idsegmanusu, UploadFilesResult)

            If System.IO.File.Exists(Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(hpf.FileName))) Then
                System.IO.File.Delete(Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(hpf.FileName)))
            End If
        Next
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionesIntermediacion(petivi_intermediacionpaglist As petivi_intermediacionpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_intermediacionpaglist As String = httpcliente.posthttpobj("Inspeccion/ObtenerInspeccionesIntermediacion/", petivi_intermediacionpaglist)
        Return Content(respvi_intermediacionpaglist, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerInpeccionesIntermediacionPendiente(petivi_intermediacionpaglist As petivi_intermediacionpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_intermediacionpaglist As String = httpcliente.posthttpobj("Inspeccion/ObtenerInpeccionesIntermediacionPendiente/", petivi_intermediacionpaglist)
        Return Content(respvi_intermediacionpaglist, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerInpeccionesIntermediacionAsignada(petivi_intermediacionpaglist As petivi_intermediacionpaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_intermediacionpaglist As String = httpcliente.posthttpobj("Inspeccion/ObtenerInpeccionesIntermediacionAsignada/", petivi_intermediacionpaglist)
        Return Content(respvi_intermediacionpaglist, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerPlacasIntermediacionPendiente() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_comunconfvalor As String = httpcliente.posthttpparam("Inspeccion/ObtenerPlacasIntermediacionPendiente/")
        Return Content(lista_comunconfvalor, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerTotalInspecionesIntermediacion() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipinstotalpers As String = httpcliente.posthttpparam("Inspeccion/TotalInspeccionesIntermediacion/")
        Return Content(aipinstotalpers, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function ObtenerVideosPorIdEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_datosfoto As String = httpcliente.posthttpparam("Inspeccion/ObtenerVideosPorIdEnc/?idaipinsenc=" & idaipinsenc)
        Return Content(lista_datosfoto, "application/json")
    End Function



#Region "LIMPIEZA SUSCRIPCION"
    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionLimpiezaSuscripcionPorIdInsEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinslimsus As String = httpcliente.posthttpparam("vi_aipinslimsus/selvi_aipinslimsusxidinsenc?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinslimsus, "application/json")
    End Function
    <Authorize()>
    <HttpPost()>
    Function AgregarRepuestoLimpiezaSuscripcion(aipinslimsusrepu As aipinslimsusrepu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipinslimsusrepu/insaipinslimsusrepu/", aipinslimsusrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarRepuestoLimpiezaSuscripcion(idaipinslimsusrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinslimsusrepu/eliaipinslimsusrepu?idaipinslimsusrepu=" & idaipinslimsusrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarRepuestosLimpiezaSuscripcion(lista_aipinslimsusrepu As List(Of vi_aipinslimsusrepu)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarRepuestosLimpiezaSuscripcion/", lista_aipinslimsusrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
   <HttpPost()>
    Function AgregarMobrLimpiezaSuscripcion(idaipmanrepu As Decimal, itipobaremobr As String, itamapiezbaremobr As String, imaterpiezbaremobr As String, aipinslimsusmobr As aipinslimsusmobr) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim respopera As String = httpcliente.posthttpobj("aipinslimsusmobr/insaipinslimsusmobr/", aipinslimsusmobr)
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AgregarMobrLimpiezaSuscripcion/?idaipmanrepu=" & idaipmanrepu & "&itipobaremobr=" & itipobaremobr & "&itamapiezbaremobr=" & itamapiezbaremobr & "&imaterpiezbaremobr=" & imaterpiezbaremobr, aipinslimsusmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarMobrLimpiezaSuscripcion(idaipinslimsusmobr As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinslimsusmobr/eliaipinslimsusmobr?idaipinslimsusmobr=" & idaipinslimsusmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarMobrsLimpiezaSuscripcion(lista_aipinslimsusmobr As List(Of vi_aipinslimsusmobr)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarRepuestosLimpiezaSuscripcion/", lista_aipinslimsusmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function GuardarInspeccionLimpiezaSuscripcion(vi_aipinslimsus As vi_aipinslimsus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionLimpiezaSuscripcion/", vi_aipinslimsus)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ProcesarInspeccionLimpiezaSuscripcion(vi_aipinslimsus As vi_aipinslimsus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ProcesarInspeccionLimpiezaSuscripcion/", vi_aipinslimsus)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function RechazarInspeccionLimpiezaSuscripcion(vi_aipinslimsus As vi_aipinslimsus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/RechazarInspeccionLimpiezaSuscripcion/", vi_aipinslimsus)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function CancelarInspeccionLimpiezaSuscripcion(vi_aipinslimsus As vi_aipinslimsus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/CancelarInspeccionLimpiezaSuscripcion/", vi_aipinslimsus)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function AceptarInspeccionLimpiezaSuscripcion(vi_aipinslimsus As vi_aipinslimsus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AceptarInspeccionLimpiezaSuscripcion/", vi_aipinslimsus)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
  <HttpGet()>
  <FileDownload()>
    Function ImprimirInspeccionLimpiezaSuscripcion(idaipinslimsus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ImprimirInspeccionLimpiezaSuscripcion/?idaipinslimsus=" & idaipinslimsus)
        System.IO.File.WriteAllBytes(Server.MapPath("~/App_Data/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
        Return File("~/App_Data/" & DownloadFilesResult.Name.ToString, System.Net.Mime.MediaTypeNames.Application.Octet, DownloadFilesResult.Name.ToString)
    End Function
    <Authorize()>
  <HttpPost()>
    Function ObtenerRepuestosLimpiezaSuscripcion(idaipinslimsus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinslimsusrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosLimpiezaSuscripcion?idaipinslimsus=" & idaipinslimsus)
        Return Content(lista_vi_aipinslimsusrepu, "application/json")
    End Function
    <Authorize()>
   <HttpPost()>
    Function ObtenerMobrLimpiezaSuscripcion(idaipinslimsus As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinslimsusmobr As String = httpcliente.posthttpparam("Inspeccion/ObtenerMobrLimpiezaSuscripcion?idaipinslimsus=" & idaipinslimsus)
        Return Content(lista_vi_aipinslimsusmobr, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function ObtenerLogEvePorEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aiplogeve As String = httpcliente.posthttpparam("Inspeccion/ObtenerLogEvePorEnc?idaipinsenc=" & idaipinsenc)
        Return Content(lista_aiplogeve, "application/json")
    End Function


#End Region

#End Region

#Region "operaciones"
    <Authorize()>
<HttpPost()>
    Function AprobarInspeccionPorAuditar(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/AprobarInspeccionPorAuditar?idaipinsenc=" & idaipinsenc)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function AprobarTodasInspeccionesPorAuditar() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/AprobarTodasInspeccionesPorAuditarPorAudit/?idsegmanusuaudit=" & idsegmanusu)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function GuardarInspeccionSuscripcion(vi_aipinssus As vi_aipinssus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionSuscripcion/", vi_aipinssus)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ProcesarInspeccionSuscripcion(vi_aipinssus As vi_aipinssus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ProcesarInspeccionSuscripcion/", vi_aipinssus)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function RechazarInspeccionSuscripcion(vi_aipinssus As vi_aipinssus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/RechazarInspeccionSuscripcion/", vi_aipinssus)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function CancelarInspeccionSuscripcion(vi_aipinssus As vi_aipinssus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/CancelarInspeccionSuscripcion/", vi_aipinssus)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function AceptarInspeccionSuscripcion(vi_aipinssus As vi_aipinssus) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AceptarInspeccionSuscripcion/", vi_aipinssus)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
    <HttpGet()>
    <FileDownload()>
    Function ImprimirInspeccionSuscripcion(idaipinssus As Decimal, iimprifoto As Boolean) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ImprimirInspeccionSuscripcionNuevo/?idaipinssus=" & idaipinssus & "&iimprifoto=" & iimprifoto)
        System.IO.File.WriteAllBytes(Server.MapPath("~/App_Data/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
        Return File("~/App_Data/" & DownloadFilesResult.Name.ToString, System.Net.Mime.MediaTypeNames.Application.Octet, DownloadFilesResult.Name.ToString)
    End Function

    <Authorize()>
<HttpPost()>
    Function GuardarInspeccionRestos(vi_aipinsrest As vi_aipinsrest) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionRestos/", vi_aipinsrest)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ProcesarInspeccionRestos(vi_aipinsrest As vi_aipinsrest) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ProcesarInspeccionRestos/", vi_aipinsrest)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function RechazarInspeccionRestos(vi_aipinsrest As vi_aipinsrest) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/RechazarInspeccionRestos/", vi_aipinsrest)
        Return Content(respopera, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function CancelarInspeccionRestos(vi_aipinsrest As vi_aipinsrest) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/CancelarInspeccionRestos/", vi_aipinsrest)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function AceptarInspeccionRestos(vi_aipinsrest As vi_aipinsrest) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AceptarInspeccionRestos/", vi_aipinsrest)
        Return Content(respopera, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpGet()>
    <FileDownload()>
    Function ImprimirInspeccionRestos(idaipinsrest As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ImprimirInspeccionRestos/?idaipinsrest=" & idaipinsrest)
        System.IO.File.WriteAllBytes(Server.MapPath("~/App_Data/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
        Return File("~/App_Data/" & DownloadFilesResult.Name.ToString, System.Net.Mime.MediaTypeNames.Application.Octet, DownloadFilesResult.Name.ToString)


    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarMantVehiculo(aipmanveh As aipmanveh) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/ActualizarMantVehiculo/", aipmanveh)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ActualizarMantVehiculoYLog(idaipinsenc As Decimal, aipmanveh As aipmanveh) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/ActualizarMantVehiculoYLog/?idaipinsenc=" & idaipinsenc & "&idsegmanusu=" & idsegmanusu, aipmanveh)
        Return Content(respopera, "application/json")
    End Function



    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionRestSsm(lista_aipinsrestssm As List(Of vi_aipinsrestssm)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionRestSsm/", lista_aipinsrestssm)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionRestSse(lista_aipinsrestsse As List(Of vi_aipinsrestsse)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionRestSse/", lista_aipinsrestsse)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionRestRepuEstadGen(lista_aipinsrestrepuest As List(Of vi_aipinsrestrepuest)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionRestRepuEstadGen/", lista_aipinsrestrepuest)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionSusMotivos(lista_aipinssusmotiv As List(Of vi_aipinssusmotiv)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionSusMotivos/", lista_aipinssusmotiv)
        Return Content(respopera, "application/json")
    End Function '

    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionSusRepuEstadGen(lista_aipinssusrepuest As List(Of vi_aipinssusrepuest)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionSusRepuEstadGen/", lista_aipinssusrepuest)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionSusAcc(lista_aipinssusacc As List(Of vi_aipinssusacc)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionSusAcc/", lista_aipinssusacc)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionInfoComplementaria(lista_vi_aipinssusinfcomp As List(Of vi_aipinssusinfcomp)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionInfoComplementaria/", lista_vi_aipinssusinfcomp)
        Return Content(respopera, "application/json")
    End Function



    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionSusSsm(lista_aipinssusssm As List(Of vi_aipinssusssm)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionSusSsm/", lista_aipinssusssm)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionSusSse(lista_aipinssussse As List(Of vi_aipinssussse)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionSusSse/", lista_aipinssussse)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ModificarPeritoInspeccion(vi_aipinsenc As vi_aipinsenc) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ModificarPeritoInspeccion/", vi_aipinsenc)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ModificarAuditorInspeccion(vi_aipinsenc As vi_aipinsenc) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ModificarAuditorInspeccion/", vi_aipinsenc)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
    <HttpPost()>
    Function ModificarAuditorMasivo(idsegmanusuaudit As Decimal, lista_vi_aipinsenc As List(Of vi_aipinsenc)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ModificarAuditorMasivo/?idsegmanusuaudit=" & idsegmanusuaudit & "&idsegmanusu=" & idsegmanusu, lista_vi_aipinsenc)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
 <HttpPost()>
    Function ModificarAuditorInspeccionTodo(idsegmanusuaudit As Decimal, lista_vi_aipinsenc As List(Of vi_aipinsenc)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ModificarAuditorInspeccionTodo/?idsegmanusuaudit=" & idsegmanusuaudit & "&idsegmanusu=" & idsegmanusu, lista_vi_aipinsenc)
        Return Content(respopera, "application/json")
    End Function



    <Authorize()>
    <HttpPost()>
    Function ModificarPeritoMasivo(idsegmanusuperit As Decimal, lista_vi_aipinsenc As List(Of vi_aipinsenc)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ModificarPeritoMasivo/?idsegmanusuperit=" & idsegmanusuperit & "&idsegmanusu=" & idsegmanusu, lista_vi_aipinsenc)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
    <HttpPost()>
    Function ModificarPeritoInspeccionTodo(idsegmanusuperit As Decimal, lista_vi_aipinsenc As List(Of vi_aipinsenc)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ModificarPeritoInspeccionTodo/?idsegmanusuperit=" & idsegmanusuperit & "&idsegmanusu=" & idsegmanusu, lista_vi_aipinsenc)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
    <HttpPost()>
    Function ObtenerComboMotivosActivosPorTipoIns(itipoinsmotiv As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim lista_aipinsmotiv As String = httpcliente.posthttpparam("aipinsmotiv/selaipinsmotivactivosportipo/?itipoinsmotiv=" & itipoinsmotiv)
        Return Content(lista_aipinsmotiv, "application/json")
    End Function

    <Authorize()>
    <HttpPost()>
    Function ModificarInspeccionEstatusYTipoAccion(idaipinsenc As Decimal, iestatinsenc As String, itipoaccion As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        ''Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/ModificarInspeccionEstatusYTipoAccion/?idaipinsenc=" & idaipinsenc & "&iestatinsenc=" & iestatinsenc & "&itipoaccion=" & itipoaccion)
        Return Content(respopera, "application/json")
    End Function


    <Authorize()>
    <HttpPost()>
    Function ObtenerInsCasosPeritPorProcesar(petivi_aipinsperitagruppaglist As petivi_aipinsperitagruppaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        ''Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpobj("vi_aipinsperitagrup/selvi_aipinsperitagrupxwheredinamicopag/", petivi_aipinsperitagruppaglist)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function ObtenerInsCasosAuditPorAuditar(petivi_aipinsauditagruppaglist As petivi_aipinsauditagruppaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        ''Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpobj("vi_aipinsauditagrup/selvi_aipinsauditagrupxwheredinamicopag/", petivi_aipinsauditagruppaglist)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function ObtenerDatosInspeccionRector(idaipinsintext As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinsenc As String = httpcliente.posthttpparam("Inspeccion/ObtenerDatosInspeccionRector/?idaipinsintext=" & idaipinsintext)
        Return Content(vi_aipinsenc, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function ExisteInspeccionPorAgendar(idintermediacion As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/ExisteInspeccionPorAgendar/?idintermediacion=" & idintermediacion)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function ObtenerIdManRepuestoInternoPorIdExterno(idrepuext As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idaipmanrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerIdManRepuestoInternoPorIdExterno/?idrepuext=" & idrepuext)
        Return Content(idaipmanrepu, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function ObtenerIdExternoPorIdManRepuestoInterno(idaipmanrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idaiprepuext As String = httpcliente.posthttpparam("Inspeccion/ObtenerIdExternoPorIdManRepuestoInterno/?idaipmanrepu=" & idaipmanrepu)
        Return Content(idaiprepuext, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function ObtenerRepuestoPorIdExterno(idrepuext As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim aipmanrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestoPorIdExterno/?idrepuext=" & idrepuext)
        Return Content(aipmanrepu, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function GuardarSiniestroSuscripcion(persaipinssinicotiz As persaipinssinicotiz) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarSiniestroSuscripcion/", persaipinssinicotiz)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function GuardarSiniestro(persaipinssini As persaipinssini) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarSiniestro/", persaipinssini)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function EliminarInspeccion(idaipinsenc As Decimal) As ActionResult
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/EliminarInspeccionPorEnc/?idaipinsenc=" & idaipinsenc & "&idsegmanusu=" & idsegmanusu)
        Return Content(respopera, "application/json")
    End Function

#End Region

#Region "SINIESTRO"

    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionSiniestroPorIdInsEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinssin As String = httpcliente.posthttpparam("vi_aipinssin/selvi_aipinssinxidinsenc?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinssin, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function ObtenerRepuestosSiniestro(idaipinssin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinslimsinrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosSiniestro?idaipinssin=" & idaipinssin)
        Return Content(lista_vi_aipinslimsinrepu, "application/json")
    End Function

    <Authorize()>
  <HttpPost()>
    Function ObtenerMobrSiniestro(idaipinssin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinssinmobr As String = httpcliente.posthttpparam("Inspeccion/ObtenerMobrSiniestro?idaipinssin=" & idaipinssin)
        Return Content(lista_vi_aipinssinmobr, "application/json")
    End Function

    <Authorize()>
    <HttpPost()>
    Function AgregarRepuestoSiniestro(aipinssinrepu As aipinssinrepu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarRepuestoConBaremo/", aipinssinrepu)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
   <HttpPost()>
    Function AgregarMobrSiniestro(aipinssinmobr As aipinssinmobr) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim respopera As String = httpcliente.posthttpobj("aipinslimsinmobr/insaipinslimsinmobr/", aipinslimsinmobr)
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarManoObraConBaremo/", aipinssinmobr)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function EliminarRepuestoSiniestro(idaipinssinrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinssinrepu/eliaipinssinrepu?idaipinssinrepu=" & idaipinssinrepu)
        Return Content(respopera, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function EliminarMobrSiniestro(idaipinssinmobr As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinssinmobr/eliaipinssinmobr?idaipinssinmobr=" & idaipinssinmobr)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ActualizarRepuestosSiniestro(lista_aipinssinrepu As List(Of vi_aipinssinrepu)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarRepuestosSiniestro/", lista_aipinssinrepu)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ActualizarManoObraSiniestro(lista_vi_aipinssinmobr As List(Of vi_aipinssinmobr)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarManoObraSiniestro/", lista_vi_aipinssinmobr)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function GuardarInspeccionSiniestro(vi_aipinssin As vi_aipinssin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionSiniestro/", vi_aipinssin)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ProcesarInspeccionSiniestro(vi_aipinssin As vi_aipinssin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ProcesarInspeccionSiniestro/", vi_aipinssin)
        Return Content(respopera, "application/json")
    End Function


    <Authorize()>
 <HttpGet()>
 <FileDownload()>
    Function ImprimirInspeccionSiniestro(idaipinssin As Decimal, iimprifoto As Boolean) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ImprimirInspeccionSiniestro/?idaipinssin=" & idaipinssin & "&iimprifoto=" & iimprifoto)
        System.IO.File.WriteAllBytes(Server.MapPath("~/App_Data/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
        Return File("~/App_Data/" & DownloadFilesResult.Name.ToString, System.Net.Mime.MediaTypeNames.Application.Octet, DownloadFilesResult.Name.ToString)
    End Function



    <Authorize()>
<HttpPost()>
    Function RechazarInspeccionSiniestro(vi_aipinssin As vi_aipinssin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/RechazarInspeccionSiniestro/", vi_aipinssin)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function CancelarInspeccionSiniestro(vi_aipinssin As vi_aipinssin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/CancelarInspeccionSiniestro/", vi_aipinssin)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function AceptarInspeccionSiniestro(vi_aipinssin As vi_aipinssin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AceptarInspeccionSiniestro/", vi_aipinssin)
        Return Content(respopera, "application/json")
    End Function


    <Authorize()>
<HttpPost()>
    Function ObtenerMotivosInspeccionSinActivos(idaipinssin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinssinmotiv As String = httpcliente.posthttpparam("Inspeccion/ObtenerMotivosInspeccionSinActivos?idaipinssin=" & idaipinssin)
        Return Content(lista_vi_aipinssinmotiv, "application/json")
    End Function



    <Authorize()>
<HttpPost()>
    Function ActualizarInspeccionSinMotivos(lista_vi_aipinssinmotiv As List(Of vi_aipinssinmotiv)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarInspeccionSinMotivos/", lista_vi_aipinssinmotiv)
        Return Content(respopera, "application/json")
    End Function '

    <Authorize()>
<HttpPost()>
    Function TotalPrecioManoObraSinistroPorIdSin(idaipinssin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim nprecfininssinmobr As String = httpcliente.posthttpparam("Inspeccion/TotalPrecioManoObraSinistroPorIdSin?idaipinssin=" & idaipinssin)
        Return Content(nprecfininssinmobr, "application/json")
    End Function '

    <Authorize()>
<HttpPost()>
    Function TotalCantidadManoObraSinistroPorIdSin(idaipinssin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim ncantinssinmobr As String = httpcliente.posthttpparam("Inspeccion/TotalCantidadManoObraSinistroPorIdSin?idaipinssin=" & idaipinssin)
        Return Content(ncantinssinmobr, "application/json")
    End Function '

    <Authorize()>
<HttpPost()>
    Function TotalPrecioRepuestoSinistroPorIdSin(idaipinssin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim nprecfininssinrepu As String = httpcliente.posthttpparam("Inspeccion/TotalPrecioRepuestoSinistroPorIdSin?idaipinssin=" & idaipinssin)
        Return Content(nprecfininssinrepu, "application/json")
    End Function '

    <Authorize()>
<HttpPost()>
    Function TotalCantidadRepuestoSinistroPorIdSin(idaipinssin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim ncantinssinrepu As String = httpcliente.posthttpparam("Inspeccion/TotalCantidadRepuestoSinistroPorIdSin?idaipinssin=" & idaipinssin)
        Return Content(ncantinssinrepu, "application/json")
    End Function '


    <Authorize()>
<HttpPost()>
    Function ObtenerBaremoManoDeObra(idaipinsenc As Decimal, idaipmanrepu As Decimal, itidainssinmobr As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/ObtenerBaremoManoDeObra?idsegmanusu=" & idsegmanusu & "&idaipinsenc=" & idaipinsenc & "&idaipmanrepu=" & idaipmanrepu & "&itidainssinmobr=" & itidainssinmobr)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function Sp_ObtenerDatosDeclaracion(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim peraipdatosdeclara As String = httpcliente.posthttpparam("Inspeccion/Sp_ObtenerDatosDeclaracion?idsegmanusu=" & idsegmanusu & "&idaipinsenc=" & idaipinsenc)
        Return Content(peraipdatosdeclara, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerMotivosInspeccionPorSiniestro(itipoinsmotiv As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_aipinsmotiv As String = httpcliente.posthttpparam("aipinsmotiv/selaipinsmotivactivosportipo2?itipoinsmotiv=" & itipoinsmotiv)
        Return Content(lista_aipinsmotiv, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function CrearInspeccionPorAnexo(idaipinsencAnt As Decimal, idsegmanorgperit As Decimal, idaipinsmotiv As Decimal, idsegmanusuperit As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/CrearInspeccionPorAnexo?idsegmanusu=" & idsegmanusu & "&idaipinsencAnt=" & idaipinsencAnt & "&idsegmanorgperit=" & idsegmanorgperit & "&idaipinsmotiv=" & idaipinsmotiv & "&idsegmanusuperit=" & idsegmanusuperit)
        Return Content(respopera, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function VerificarSiEsUltimaInspeccionDelSiniestro(idaipinsencComparar As Decimal, xnumsininsenc As String) As ActionResult
        Dim httpcliente As New basehttpcliente        
        Dim respopera As String = httpcliente.posthttpparam("Inspeccion/VerificarSiEsUltimaInspeccionDelSiniestro?idaipinsencComparar=" & idaipinsencComparar & "&xnumsininsenc=" & xnumsininsenc)
        Return Content(respopera, "application/json")
    End Function


#End Region



#Region "LIMPIEZA SINIESTRO"
    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionLimpiezaSiniestroPorIdInsEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinslimsin As String = httpcliente.posthttpparam("vi_aipinslimsin/selvi_aipinslimsinxidinsenc?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinslimsin, "application/json")
    End Function

    <Authorize()>
    <HttpPost()>
    Function AgregarRepuestoLimpiezaSiniestro(aipinslimsinrepu As aipinslimsinrepu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipinslimsinrepu/insaipinslimsinrepu/", aipinslimsinrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarRepuestoLimpiezaSiniestro(idaipinslimsinrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinslimsinrepu/eliaipinslimsinrepu?idaipinslimsinrepu=" & idaipinslimsinrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarRepuestosLimpiezaSiniestro(lista_aipinslimsinrepu As List(Of vi_aipinslimsinrepu)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarRepuestosLimpiezaSiniestro/", lista_aipinslimsinrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
   <HttpPost()>
    Function AgregarMobrLimpiezaSiniestro(idaipmanrepu As Decimal, itipobaremobr As String, itamapiezbaremobr As String, imaterpiezbaremobr As String, aipinslimsinmobr As aipinslimsinmobr) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim respopera As String = httpcliente.posthttpobj("aipinslimsinmobr/insaipinslimsinmobr/", aipinslimsinmobr)
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AgregarMobrLimpiezaSiniestro/?idaipmanrepu=" & idaipmanrepu & "&itipobaremobr=" & itipobaremobr & "&itamapiezbaremobr=" & itamapiezbaremobr & "&imaterpiezbaremobr=" & imaterpiezbaremobr, aipinslimsinmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarMobrLimpiezaSiniestro(idaipinslimsinmobr As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinslimsinmobr/eliaipinslimsinmobr?idaipinslimsinmobr=" & idaipinslimsinmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarMobrsLimpiezaSiniestro(lista_vi_aipinslimsinmobr As List(Of vi_aipinslimsinmobr)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarMobrsLimpiezaSiniestro/", lista_vi_aipinslimsinmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function GuardarInspeccionLimpiezaSiniestro(vi_aipinslimsin As vi_aipinslimsin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionLimpiezaSiniestro/", vi_aipinslimsin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ProcesarInspeccionLimpiezaSiniestro(vi_aipinslimsin As vi_aipinslimsin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ProcesarInspeccionLimpiezaSiniestro/", vi_aipinslimsin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function RechazarInspeccionLimpiezaSiniestro(vi_aipinslimsin As vi_aipinslimsin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/RechazarInspeccionLimpiezaSiniestro/", vi_aipinslimsin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function CancelarInspeccionLimpiezaSiniestro(vi_aipinslimsin As vi_aipinslimsin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/CancelarInspeccionLimpiezaSiniestro/", vi_aipinslimsin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function AceptarInspeccionLimpiezaSiniestro(vi_aipinslimsin As vi_aipinslimsin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AceptarInspeccionLimpiezaSiniestro/", vi_aipinslimsin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
 <HttpGet()>
 <FileDownload()>
    Function ImprimirInspeccionLimpiezaSiniestro(idaipinslimsin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ImprimirInspeccionLimpiezaSiniestro/?idaipinslimsin=" & idaipinslimsin)
        System.IO.File.WriteAllBytes(Server.MapPath("~/App_Data/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
        Return File("~/App_Data/" & DownloadFilesResult.Name.ToString, System.Net.Mime.MediaTypeNames.Application.Octet, DownloadFilesResult.Name.ToString)

    End Function

    <Authorize()>
 <HttpPost()>
    Function ObtenerRepuestosLimpiezaSiniestro(idaipinslimsin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinslimsinrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosLimpiezaSiniestro?idaipinslimsin=" & idaipinslimsin)
        Return Content(lista_vi_aipinslimsinrepu, "application/json")
    End Function
    <Authorize()>
   <HttpPost()>
    Function ObtenerMobrLimpiezaSiniestro(idaipinslimsin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinslimsinmobr As String = httpcliente.posthttpparam("Inspeccion/ObtenerMobrLimpiezaSiniestro?idaipinslimsin=" & idaipinslimsin)
        Return Content(lista_vi_aipinslimsinmobr, "application/json")
    End Function

    <Authorize()>
<HttpPost()>
    Function ObtenerListaDetallesSiniestro(idsegmanorgperit As Decimal, xnumsininsenc As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipextsintagenda As String = httpcliente.posthttpparam("Inspeccion/ObtenerListaDetallesSiniestro/?idsegmanorgperit=" & idsegmanorgperit & "&xnumsininsenc=" & xnumsininsenc)
        Return Content(lista_vi_aipextsintagenda, "application/json")
    End Function


#End Region
#Region "AJUSTE SINIESTRO"
    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionAjusteSiniestroPorIdInsEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinsajussin As String = httpcliente.posthttpparam("vi_aipinsajussin/selvi_aipinsajussinxidinsenc?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinsajussin, "application/json")
    End Function
    <Authorize()>
    <HttpPost()>
    Function AgregarRepuestoAjusteSiniestro(aipinsajussinrepu As aipinsajussinrepu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipinsajussinrepu/insaipinsajussinrepu/", aipinsajussinrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarRepuestoAjusteSiniestro(idaipinsajussinrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinsajussinrepu/eliaipinsajussinrepu?idaipinsajussinrepu=" & idaipinsajussinrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarRepuestosAjusteSiniestro(lista_aipinsajussinrepu As List(Of vi_aipinsajussinrepu)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarRepuestosAjusteSiniestro/", lista_aipinsajussinrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
   <HttpPost()>
    Function AgregarMobrAjusteSiniestro(idaipmanrepu As Decimal, itipobaremobr As String, itamapiezbaremobr As String, imaterpiezbaremobr As String, aipinsajussinmobr As aipinsajussinmobr) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim respopera As String = httpcliente.posthttpobj("aipinsajussinmobr/insaipinsajussinmobr/", aipinsajussinmobr)
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AgregarMobrAjusteSiniestro/?idaipmanrepu=" & idaipmanrepu & "&itipobaremobr=" & itipobaremobr & "&itamapiezbaremobr=" & itamapiezbaremobr & "&imaterpiezbaremobr=" & imaterpiezbaremobr, aipinsajussinmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarMobrAjusteSiniestro(idaipinsajussinmobr As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinsajussinmobr/eliaipinsajussinmobr?idaipinsajussinmobr=" & idaipinsajussinmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarMobrsAjusteSiniestro(lista_aipinsajussinmobr As List(Of vi_aipinsajussinmobr)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarMobrsAjusteSiniestro/", lista_aipinsajussinmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function GuardarInspeccionAjusteSiniestro(vi_aipinsajussin As vi_aipinsajussin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionAjusteSiniestro/", vi_aipinsajussin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ProcesarInspeccionAjusteSiniestro(vi_aipinsajussin As vi_aipinsajussin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ProcesarInspeccionAjusteSiniestro/", vi_aipinsajussin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function RechazarInspeccionAjusteSiniestro(vi_aipinsajussin As vi_aipinsajussin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/RechazarInspeccionAjusteSiniestro/", vi_aipinsajussin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function CancelarInspeccionAjusteSiniestro(vi_aipinsajussin As vi_aipinsajussin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/CancelarInspeccionAjusteSiniestro/", vi_aipinsajussin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function AceptarInspeccionAjusteSiniestro(vi_aipinsajussin As vi_aipinsajussin) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AceptarInspeccionAjusteSiniestro/", vi_aipinsajussin)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
  <HttpGet()>
  <FileDownload()>
    Function ImprimirInspeccionAjusteSiniestro(idaipinsajussin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ImprimirInspeccionAjusteSiniestro/?idaipinsajussin=" & idaipinsajussin)
        System.IO.File.WriteAllBytes(Server.MapPath("~/App_Data/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
        Return File("~/App_Data/" & DownloadFilesResult.Name.ToString, System.Net.Mime.MediaTypeNames.Application.Octet, DownloadFilesResult.Name.ToString)

    End Function
    <Authorize()>
    <HttpPost()>
    Function ObtenerRepuestosAjusteSiniestro(idaipinsajussin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsajussinrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosAjusteSiniestro?idaipinsajussin=" & idaipinsajussin)
        Return Content(lista_vi_aipinsajussinrepu, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ObtenerMobrAjusteSiniestro(idaipinsajussin As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsajusanexrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerMobrAjusteSiniestro?idaipinsajussin=" & idaipinsajussin)
        Return Content(lista_vi_aipinsajusanexrepu, "application/json")
    End Function
#End Region
#Region "AJUSTE ANEXO"
    <Authorize()>
<HttpPost()>
    Function ObtenerInspeccionAjusteAnexoPorIdInsEnc(idaipinsenc As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim vi_aipinsajusanex As String = httpcliente.posthttpparam("vi_aipinsajusanex/selvi_aipinsajusanexxidinsenc?idaipinsenc=" & idaipinsenc)
        Return Content(vi_aipinsajusanex, "application/json")
    End Function
    <Authorize()>
    <HttpPost()>
    Function AgregarRepuestoAjusteAnexo(aipinsajusanexrepu As aipinsajusanexrepu) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("aipinsajusanexrepu/insaipinsajusanexrepu/", aipinsajusanexrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarRepuestoAjusteAnexo(idaipinsajusanexrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinsajusanexrepu/eliaipinsajusanexrepu?idaipinsajusanexrepu=" & idaipinsajusanexrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarRepuestosAjusteAnexo(lista_aipinsajusanexrepu As List(Of vi_aipinsajusanexrepu)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarRepuestosAjusteAnexo/", lista_aipinsajusanexrepu)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
   <HttpPost()>
    Function AgregarMobrAjusteAnexo(idaipmanrepu As Decimal, itipobaremobr As String, itamapiezbaremobr As String, imaterpiezbaremobr As String, aipinsajusanexmobr As aipinsajusanexmobr) As ActionResult
        Dim httpcliente As New basehttpcliente
        'Dim respopera As String = httpcliente.posthttpobj("aipinsajusanexmobr/insaipinsajusanexmobr/", aipinsajusanexmobr)
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AgregarMobrAjusteAnexo/?idaipmanrepu=" & idaipmanrepu & "&itipobaremobr=" & itipobaremobr & "&itamapiezbaremobr=" & itamapiezbaremobr & "&imaterpiezbaremobr=" & imaterpiezbaremobr, aipinsajusanexmobr)
        'httpcliente.posthttpparam("Actividad/EliminarRagactenc?idragactenc=" & idragactenc & "&idsegmanusucrea=" & idsegmanusucrea & "&idsegmanapp=" & idsegmanapp)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function EliminarMobrAjusteAnexo(idaipinsajusanexmobr As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipinsajusanexmobr/eliaipinsajusanexmobr?idaipinsajusanexmobr=" & idaipinsajusanexmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ActualizarMobrsAjusteAnexo(lista_aipinsajusanexmobr As List(Of vi_aipinsajusanexmobr)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ActualizarMobrsAjusteAnexo/", lista_aipinsajusanexmobr)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function GuardarInspeccionAjusteAnexo(vi_aipinsajusanex As vi_aipinsajusanex) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/GuardarInspeccionAjusteAnexo/", vi_aipinsajusanex)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ProcesarInspeccionAjusteAnexo(vi_aipinsajusanex As vi_aipinsajusanex) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/ProcesarInspeccionAjusteAnexo/", vi_aipinsajusanex)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function RechazarInspeccionAjusteAnexo(vi_aipinsajusanex As vi_aipinsajusanex) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/RechazarInspeccionAjusteAnexo/", vi_aipinsajusanex)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function CancelarInspeccionAjusteAnexo(vi_aipinsajusanex As vi_aipinsajusanex) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/CancelarInspeccionAjusteAnexo/", vi_aipinsajusanex)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function AceptarInspeccionAjusteAnexo(vi_aipinsajusanex As vi_aipinsajusanex) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Inspeccion/AceptarInspeccionAjusteAnexo/", vi_aipinsajusanex)
        Return Content(respopera, "application/json")
    End Function
    <Authorize()>
  <HttpGet()>
  <FileDownload()>
    Function ImprimirInspeccionAjusteAnexo(idaipinsajusanex As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim DownloadFilesResult As DownloadFilesResult = httpcliente.gethttpdfr("Inspeccion/ImprimirInspeccionAjusteAnexo/?idaipinsajusanex=" & idaipinsajusanex)
        System.IO.File.WriteAllBytes(Server.MapPath("~/App_Data/" & DownloadFilesResult.Name.ToString), DownloadFilesResult.ArchivoByte)
        Return File("~/App_Data/" & DownloadFilesResult.Name.ToString, System.Net.Mime.MediaTypeNames.Application.Octet, DownloadFilesResult.Name.ToString)

    End Function
    <Authorize()>
    <HttpPost()>
    Function ObtenerMobrAjusteAnexo(idaipinsajusanex As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsajussinrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerMobrAjusteAnexo?idaipinsajusanex=" & idaipinsajusanex)
        Return Content(lista_vi_aipinsajussinrepu, "application/json")
    End Function
    <Authorize()>
<HttpPost()>
    Function ObtenerRepuestosAjusteAnexo(idaipinsajusanex As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipinsajusanexrepu As String = httpcliente.posthttpparam("Inspeccion/ObtenerRepuestosAjusteAnexo?idaipinsajusanex=" & idaipinsajusanex)
        Return Content(lista_vi_aipinsajusanexrepu, "application/json")
    End Function
#End Region





End Class