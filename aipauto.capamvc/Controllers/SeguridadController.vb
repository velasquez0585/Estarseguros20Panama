Imports System.Configuration
Imports estarseguros20.capacomuncliente
Imports funciones.lib

Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports Newtonsoft.Json

Namespace aicweb.capamvc
    Public Class SeguridadController
        Inherits BaseController

#Region "variables"

#End Region


#Region "vistas"
        ' GET: /Seguridad
        <AllowAnonymous()>
        <HttpGet()>
        Function IniciarSesion(esvistaparcial As Boolean) As ActionResult
            If Not Request.IsAuthenticated Then
                If esvistaparcial Then
                    Return PartialView("_IniciarSesion")
                Else
                    Return View("IniciarSesion")
                End If
            Else
                Return RedirectToAction("ErrorHttp5000", "Error")
            End If
        End Function

        <CustomAuthorize()>
        <HttpGet()>
        Function SegUsuarios(esvistaparcial As Boolean) As ActionResult
            If esvistaparcial Then
                Return PartialView("_SegUsuarios")
            Else
                Return View("SegUsuarios")
            End If
        End Function

        <CustomAuthorize()>
        <HttpGet()>
        Function SegPeritos(esvistaparcial As Boolean) As ActionResult
            If esvistaparcial Then
                Return PartialView("_SegPeritos")
            Else
                Return View("SegPeritos")
            End If
        End Function
#End Region

#Region "sesion"
        'ByVal returnUrl As String
        <AllowAnonymous()> _
        <HttpPost()> _
        Public Function IniciarSesion(ByVal IniciarSesionModel As IniciarSesionModel) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim respopera As String = httpcliente.gethttpstring("seguridad/iniciar_sesion_bloqueo?xnombreusuario=" & _
                                                                   IniciarSesionModel.xnombreusuario & "&xcontrasena=" & _
                                                                   IniciarSesionModel.xcontrasena)

            Dim _respopera As respopera = JsonConvert.DeserializeObject(Of respopera)(respopera)

            If (_respopera IsNot Nothing) Then

                If _respopera.irespuesta = "1" Then
                    Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & IniciarSesionModel.xnombreusuario)

                    If (vi_segmanusu.ibloqueado = False) Then

                        Session("idsegmanusu") = vi_segmanusu.idsegmanusu
                        Session("idcomunmanpais") = vi_segmanusu.idcomunmanpais
                        Session("xcultura") = vi_segmanusu.xcultura
                        Dim vi_segusuperf As Object = httpcliente.gethttpobject("vi_segusuperf/selvi_segusuperfxappyusu?idsegmanapp=" & ConfigurationManager.AppSettings("idsegmanapp") & "&idsegmanusu=" & vi_segmanusu.idsegmanusu)
                        Session("idsegmanperf") = vi_segusuperf.idsegmanperf

                        FormsAuthentication.SetAuthCookie(IniciarSesionModel.xnombreusuario, True)

                        IniciarSesionModel.xnombreusuario = ""
                        IniciarSesionModel.xcontrasena = ""
                        IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Ok", .xmensaje = "Su sesión se ha iniciado satisfactoriamente."}

                    Else
                        IniciarSesionModel.xcontrasena = ""
                        IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "Su usuario se encuentra inactivo para iniciar sessión."}
                    End If


                    Return Json(IniciarSesionModel)
                Else
                    IniciarSesionModel.xcontrasena = ""
                    IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = _respopera.xmsjusuario}
                    Return Json(IniciarSesionModel)
                End If

            Else
                IniciarSesionModel.xnombreusuario = ""
                IniciarSesionModel.xcontrasena = ""
                IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "Ha ocurrido un error al intentar validar sus credenciales."}
                Return Json(IniciarSesionModel)

            End If

        End Function

        <CustomAuthorize()>
        <HttpGet()>
        Public Function CerrarSesion() As ActionResult
            Session("xcultura") = ""
            FormsAuthentication.SignOut()
            Return RedirectToAction("Index", "Home")
        End Function

        <CustomAuthorize()>
        <HttpGet()>
        Function CambiarContrasena(esvistaparcial As Boolean) As ActionResult
            If esvistaparcial Then
                Return PartialView("_CambiarContrasena")
            Else
                Return View("CambiarContrasena")
            End If
        End Function

        <CustomAuthorize()> _
        <HttpPost()> _
        Public Function CambiarContrasena(ByVal CambiarContrasenaModel As CambiarContrasenaModel) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim cambio As String = httpcliente.gethttpstring("seguridad/cambiar_contrasena?xnombreusuario=" & _
                                                              HttpContext.User.Identity.Name & "&xcontrasena_actual=" & _
                                                              CambiarContrasenaModel.xcontrasena_actual & "&xcontrasena_nueva=" & _
                                                              CambiarContrasenaModel.xcontrasena_nueva & "&xcontrasena_confirmacion=" & _
                                                              CambiarContrasenaModel.xcontrasena_confirmacion)

            If Convert.ToBoolean(cambio) Then
                CambiarContrasenaModel.xcontrasena_actual = ""
                CambiarContrasenaModel.xcontrasena_nueva = ""
                CambiarContrasenaModel.xcontrasena_confirmacion = ""
                CambiarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Ok", .xmensaje = "Se cambio su contraseña satisfactoriamente y ya esta activa."}
                Return Json(CambiarContrasenaModel)
            Else
                CambiarContrasenaModel.xcontrasena_actual = ""
                CambiarContrasenaModel.xcontrasena_nueva = ""
                CambiarContrasenaModel.xcontrasena_confirmacion = ""
                CambiarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "La contraseña actual es incorrecta o la nueva contraseña es invalida."}
                Return Json(CambiarContrasenaModel)
            End If

        End Function

        <AllowAnonymous()>
        <HttpGet()>
        Function RecuperarContrasena(esvistaparcial As Boolean) As ActionResult
            If esvistaparcial Then
                Return PartialView("_RecuperarContrasena")
            Else
                Return View("RecuperarContrasena")
            End If
        End Function

        <AllowAnonymous()>
        <HttpPost()>
        Function RecuperarContrasena(RecuperarContrasenaModel As RecuperarContrasenaModel) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim recupero As String = httpcliente.gethttpstring("seguridad/recuperar_contrasena?xnombreusuario=" & RecuperarContrasenaModel.xcorreo)
            If Convert.ToBoolean(recupero) Then
                RecuperarContrasenaModel.xcorreo = ""
                RecuperarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Ok", .xmensaje = "Su contraseña se recuperó satisfactoriamente y ha sido enviada a su correo."}
                Return Json(RecuperarContrasenaModel)
            Else
                RecuperarContrasenaModel.xcorreo = ""
                RecuperarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "No se pudo recuperar su contraseña. Notifique el error al administrador del sistema."}
                Return Json(RecuperarContrasenaModel)
            End If

        End Function

        '<CustomAuthorize(Roles:="1,2,3")>

        <CustomAuthorize()>
        <HttpGet()>
        Function DatosUsuario() As ActionResult
            Return View()
        End Function
#End Region


#Region "seleccion"
        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerPerfilesPorAplicacion() As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            Dim lista_vi_segappperf As String = httpcliente.posthttpparam("vi_segappperf/selvi_segappperfxidsegmanapp/?idsegmanapp=" & idsegmanapp)
            Return Content(lista_vi_segappperf, "application/json")
        End Function

        <CustomAuthorize()>
       <HttpPost()>
        Function ObtenerPerfilesPorAplicacionMenosPeritos() As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            Dim lista_vi_segappperf As String = httpcliente.posthttpparam("vi_segappperf/selvi_segappperfxidsegmanappMenosPeritos/?idsegmanapp=" & idsegmanapp)
            Return Content(lista_vi_segappperf, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerComboOrganizacion() As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim lista_comunmanempr As String = httpcliente.posthttpparam("vi_combosegmanorg/selvi_combosegmanorgsel/")
            Return Content(lista_comunmanempr, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerComboDepartamento() As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim lista_segmandep As String = httpcliente.posthttpparam("segmandep/selsegmandep/")
            Return Content(lista_segmandep, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerComboCargo() As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim lista_segmancarg As String = httpcliente.posthttpparam("segmancarg/selsegmancarg/")
            Return Content(lista_segmancarg, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerComboUsuariosPorAccion(itipoaccion As String) As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
            Dim vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/ObtenerComboPorAccionYTipoUsuario?itipoaccion=" & itipoaccion & "&idsegmanusu=" & idsegmanusu)
            Return Content(vi_segusudetperf2, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerComboUsuariosPorAccionYSuc(idsegmanorg As Decimal, itipoaccion As String) As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
            Dim vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/ObtenerComboPorAccionOrgYTipoUsuario?idsegmanorg=" & idsegmanorg & "&itipoaccion=" & itipoaccion & "&idsegmanusu=" & idsegmanusu)
            Return Content(vi_segusudetperf2, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerComboPorAccionOrgTipoPeritYTipoUsuario(idsegmanorg As Decimal, itipoaccion As String, itipoperit As String) As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim idsegmanusu As Decimal = System.Web.HttpContext.Current.Session("idsegmanusu")
            Dim vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/ObtenerComboPorAccionOrgTipoPeritYTipoUsuario?idsegmanorg=" & idsegmanorg & "&itipoaccion=" & itipoaccion & "&itipoperit=" & itipoperit & "&idsegmanusu=" & idsegmanusu)
            Return Content(vi_segusudetperf2, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerCboSucursalYPrincipal() As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim lista_vi_combosegmanorg As String = httpcliente.posthttpparam("seguridad/ObtenerCboSucursalYPrincipal/")
            Return Content(lista_vi_combosegmanorg, "application/json")
        End Function





#End Region

#Region "consultas"
        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerPorWhereDinamicoPagViUsudetperf(petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp = idsegmanapp
            Dim respvi_segusudetperf2paglist As String = httpcliente.posthttpobj("vi_segusudetperf2/selvi_segusudetperf2xwheredinamicopag2/", petivi_segusudetperf2paglist)
            Return Content(respvi_segusudetperf2paglist, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerPorIdViUsu(idsegmanusu As Decimal) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim vi_segmanusu As String = httpcliente.posthttpparam("vi_segmanusu/selvi_segmanusuxid?&idsegmanusu=" & idsegmanusu)
            Return Content(vi_segmanusu, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerUsuarioEnSession() As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/selvi_segusudetperf2PorNombreUsuario?xnombreusuario=" & HttpContext.User.Identity.Name)
            'Dim _vi_segusudetperf2 As vi_segusudetperf2 = JsonConvert.DeserializeObject(Of vi_segusudetperf2)(vi_segusudetperf2)

            Return Content(vi_segusudetperf2, "application/json")
        End Function


        <CustomAuthorize()>
       <HttpPost()>
        Function ObtenerIdUsuarioEnSession() As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
            Dim idsegmanusu = vi_segmanusu.idsegmanusu
            Return Json(idsegmanusu, "application/json")
        End Function


        <CustomAuthorize()>
        <HttpPost()>
        Function Obtenervi_segusudetperf2PorIdsegmanusu(idsegmanusu As Decimal) As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/selvi_segusudetperf2xid?idsegmanapp=" & idsegmanapp & "&idsegmanusu=" & idsegmanusu)

            Return Content(vi_segusudetperf2, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerUsuariosPorTipo(itipoaccion As String, petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As ActionResult
            Dim httpcliente As New basehttpcliente

            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")

            Dim vi_segusudetperf2 As String = httpcliente.posthttpobj("vi_segusudetperf2/selvi_segusudetperf2xwheredinamicopagYTipoUsuario?itipoaccion=" & itipoaccion, petivi_segusudetperf2paglist)
            'Dim _vi_segusudetperf2 As vi_segusudetperf2 = JsonConvert.DeserializeObject(Of vi_segusudetperf2)(vi_segusudetperf2)

            Return Content(vi_segusudetperf2, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerUsuariosPorTipoMenosBloq(itipoaccion As String, petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As ActionResult
            Dim httpcliente As New basehttpcliente

            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")

            Dim vi_segusudetperf2 As String = httpcliente.posthttpobj("vi_segusudetperf2/selvi_segusudetperf2xwheredinamicopagYTipoUsuarioMenosBloq?itipoaccion=" & itipoaccion, petivi_segusudetperf2paglist)
            'Dim _vi_segusudetperf2 As vi_segusudetperf2 = JsonConvert.DeserializeObject(Of vi_segusudetperf2)(vi_segusudetperf2)

            Return Content(vi_segusudetperf2, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerPeritosExternos(petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As ActionResult
            Dim httpcliente As New basehttpcliente

            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf = ConfigurationManager.AppSettings("peritoext")


            Dim vi_segusudetperf2 As String = httpcliente.posthttpobj("vi_segusudetperf2/selvi_segusudetperf2xwheredinamicopag", petivi_segusudetperf2paglist)
            'Dim _vi_segusudetperf2 As vi_segusudetperf2 = JsonConvert.DeserializeObject(Of vi_segusudetperf2)(vi_segusudetperf2)

            Return Content(vi_segusudetperf2, "application/json")
        End Function


        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerPeritosInternos(petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As ActionResult
            Dim httpcliente As New basehttpcliente

            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf = ConfigurationManager.AppSettings("peritoint")


            Dim vi_segusudetperf2 As String = httpcliente.posthttpobj("vi_segusudetperf2/selvi_segusudetperf2xwheredinamicopag", petivi_segusudetperf2paglist)
            'Dim _vi_segusudetperf2 As vi_segusudetperf2 = JsonConvert.DeserializeObject(Of vi_segusudetperf2)(vi_segusudetperf2)

            Return Content(vi_segusudetperf2, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerPeritosPorWhereDinamico(idsegmanorg As Decimal, itipoaccion As String) As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim vi_segusudetperf2 As String = httpcliente.posthttpparam("vi_segusudetperf2/selvi_segusudetperf2peritoswheredinamico?idsegmanorg=" & idsegmanorg & "&itipoaccion=" & itipoaccion)
            'Dim _vi_segusudetperf2 As vi_segusudetperf2 = JsonConvert.DeserializeObject(Of vi_segusudetperf2)(vi_segusudetperf2)

            Return Content(vi_segusudetperf2, "application/json")
        End Function





        <CustomAuthorize()>
        <HttpPost()>
        Function ObtenerAuditores(petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As ActionResult
            Dim httpcliente As New basehttpcliente

            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf = ConfigurationManager.AppSettings("auditor")


            Dim vi_segusudetperf2 As String = httpcliente.posthttpobj("vi_segusudetperf2/selvi_segusudetperf2xwheredinamicopag", petivi_segusudetperf2paglist)
            'Dim _vi_segusudetperf2 As vi_segusudetperf2 = JsonConvert.DeserializeObject(Of vi_segusudetperf2)(vi_segusudetperf2)

            Return Content(vi_segusudetperf2, "application/json")
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
        Function AgregarUsuarioPerito(vi_segmanusu As vi_segmanusu) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/AgregarUsuPerito/", vi_segmanusu)
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
        Function ModificarUsuarioPerito(vi_segmanusu As vi_segmanusu) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim respopera As String = httpcliente.posthttpobj("Mantenimiento/ModificarUsuPerito/", vi_segmanusu)
            Return Content(respopera, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function AsignarPerfil(idsegmanusu As Decimal, idsegmanperf As Decimal) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            Dim respopera As String = httpcliente.posthttpparam("seguridad/Guardar_Perfil_Aplicacion?&idsegmanusu=" & idsegmanusu & "&idsegmanapp=" & idsegmanapp & "&idsegmanperf=" & idsegmanperf)
            Return Content(respopera, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ModificarUsuariosLista(itipoaccion As String, lista_vi_segusudetperf2 As List(Of vi_segusudetperf2)) As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
            Dim idsegmanusu = vi_segmanusu.idsegmanusu


            Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            Dim respopera As String = httpcliente.posthttpobj("seguridad/ModificarusuarioPorTipoAccionMasivo?idsegmanusu=" & idsegmanusu & "&itipoaccion=" & itipoaccion, lista_vi_segusudetperf2)
            Return Content(respopera, "application/json")
        End Function

        <CustomAuthorize()>
        <HttpPost()>
        Function ModificarUsuariosLista2(itipoaccion As String, xfinisusmanusuconf As String, xffinsusmanusuconf As String, lista_vi_segusudetperf2 As List(Of vi_segusudetperf2)) As ActionResult
            Dim httpcliente As New basehttpcliente

            Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
            Dim idsegmanusu = vi_segmanusu.idsegmanusu


            Dim idsegmanapp = ConfigurationManager.AppSettings("idsegmanapp")
            Dim respopera As String = httpcliente.posthttpobj("seguridad/ModificarusuarioPorTipoAccionMasivo2?idsegmanusu=" & idsegmanusu & "&itipoaccion=" & itipoaccion & "&xfinisusmanusuconf=" & xfinisusmanusuconf & "&xffinsusmanusuconf=" & xffinsusmanusuconf, lista_vi_segusudetperf2)
            Return Content(respopera, "application/json")
        End Function




#End Region

    End Class
End Namespace