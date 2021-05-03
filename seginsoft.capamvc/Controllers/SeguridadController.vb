Imports System.Configuration
Imports estarseguros20.capacomuncliente
Imports funciones.lib

Namespace aicweb.capamvc
    Public Class SeguridadController
        Inherits seginsoft.capamvc.BaseController


#Region "variables"

#End Region

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

        'ByVal returnUrl As String
        <AllowAnonymous()> _
        <HttpPost()> _
        Public Function IniciarSesion(ByVal IniciarSesionModel As IniciarSesionModel) As ActionResult
            Dim httpcliente As New basehttpcliente
            Dim autenticado As String = httpcliente.gethttpstring("seguridad/iniciar_sesion?xnombreusuario=" & _
                                                                   IniciarSesionModel.xnombreusuario & "&xcontrasena=" & _
                                                                   IniciarSesionModel.xcontrasena)

            If tipodatos.esbooleano(autenticado) Then
                If Convert.ToBoolean(autenticado) Then
                    Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & IniciarSesionModel.xnombreusuario)

                    If vi_segmanusu IsNot Nothing Then
                        Session("idsegmanusu") = vi_segmanusu.idsegmanusu
                        Session("idcomunmanpais") = vi_segmanusu.idcomunmanpais
                        Session("xcultura") = vi_segmanusu.xcultura
                        Dim vi_segusuperf As Object = httpcliente.gethttpobject("vi_segusuperf/selvi_segusuperfxappyusu?idsegmanapp=" & ConfigurationManager.AppSettings("idsegmanapp") & "&idsegmanusu=" & vi_segmanusu.idsegmanusu)
                        If vi_segusuperf IsNot Nothing Then
                            Session("idsegmanperf") = vi_segusuperf.idsegmanperf
                        Else

                            IniciarSesionModel.xcontrasena = ""
                            IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "No posee perfil asignado para esta aplicación, Comuniquese con sistemas."}
                            Return Json(IniciarSesionModel)
                        End If
                    End If

                    FormsAuthentication.SetAuthCookie(IniciarSesionModel.xnombreusuario, True)

                    IniciarSesionModel.xnombreusuario = ""
                    IniciarSesionModel.xcontrasena = ""
                    IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Ok", .xmensaje = "Su sesión se ha iniciado satisfactoriamente."}
                    Return Json(IniciarSesionModel)
                Else
                    IniciarSesionModel.xcontrasena = ""
                    IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "Sus credenciales de usuario son incorrectas."}
                    Return Json(IniciarSesionModel)
                End If
            Else
                IniciarSesionModel.xcontrasena = ""
                IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = autenticado}
                Return Json(IniciarSesionModel)
            End If

            'If tipodatos.esbooleano(autenticado) Then
            '    If Convert.ToBoolean(autenticado) Then
            '        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & IniciarSesionModel.xnombreusuario)

            '        If vi_segmanusu IsNot Nothing Then
            '            Session("idsegmanusu") = vi_segmanusu.idsegmanusu
            '            Session("idcomunmanpais") = vi_segmanusu.idcomunmanpais
            '            Session("xcultura") = vi_segmanusu.xcultura
            '            Dim vi_segusuperf As Object = httpcliente.gethttpobject("vi_segusuperf/selvi_segusuperfxappyusu?idsegmanapp=" & ConfigurationManager.AppSettings("idsegmanapp") & "&idsegmanusu=" & vi_segmanusu.idsegmanusu)

            '            If vi_segusuperf IsNot Nothing Then
            '                Session("idsegmanperf") = vi_segusuperf.idsegmanperf
            '                FormsAuthentication.SetAuthCookie(IniciarSesionModel.xnombreusuario, True)
            '                IniciarSesionModel.xnombreusuario = ""
            '                IniciarSesionModel.xcontrasena = ""
            '                IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Ok", .xmensaje = "Su sesión se ha iniciado satisfactoriamente."}
            '            End If
            '        End If
            '        IniciarSesionModel.xcontrasena = ""
            '        IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = autenticado}
            '        Return Json(IniciarSesionModel)
            '    Else
            '        IniciarSesionModel.xcontrasena = ""
            '        IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "Sus credenciales de usuario son incorrectas."}
            '        Return Json(IniciarSesionModel)
            '    End If
            'Else
            '    IniciarSesionModel.xcontrasena = ""
            '    IniciarSesionModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = autenticado}
            '    Return Json(IniciarSesionModel)
            'End If
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
            If tipodatos.esbooleano(cambio) Then
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
            Else
                CambiarContrasenaModel.xcontrasena_actual = ""
                CambiarContrasenaModel.xcontrasena_nueva = ""
                CambiarContrasenaModel.xcontrasena_confirmacion = ""
                CambiarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = cambio}
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
            If tipodatos.esbooleano(recupero) Then
                If Convert.ToBoolean(recupero) Then
                    RecuperarContrasenaModel.xcorreo = ""
                    RecuperarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Ok", .xmensaje = "Su contraseña se recuperó satisfactoriamente y ha sido enviada a su correo."}
                    Return Json(RecuperarContrasenaModel)
                Else
                    RecuperarContrasenaModel.xcorreo = ""
                    RecuperarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = "No se pudo recuperar su contraseña. Notifique el error al administrador del sistema."}
                    Return Json(RecuperarContrasenaModel)
                End If
            Else
                RecuperarContrasenaModel.xcorreo = ""
                RecuperarContrasenaModel.infomodel = New InfoModel With {.xtitulo = "Error", .xmensaje = recupero}
                Return Json(RecuperarContrasenaModel)
            End If
        End Function

        '<CustomAuthorize(Roles:="1,2,3")>

        <CustomAuthorize()>
        <HttpGet()>
        Function DatosUsuario() As ActionResult
            Return View()
        End Function

    End Class
End Namespace