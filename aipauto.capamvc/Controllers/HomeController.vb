Imports System.Configuration
Imports estarseguros20.capacomuncliente

Namespace aicweb.capamvc
    Public Class HomeController
        Inherits BaseController

#Region "Variables"
        Dim apporg As String = ConfigurationManager.AppSettings("xnombreapp") & ConfigurationManager.AppSettings("xnombreorg")
#End Region

        ' GET: /Home

        <AllowAnonymous()>
        <HttpGet()>
        Function Index() As ActionResult
            'Dim texto As String = culturas.lib.My.Resources.cultura.formato_de_correo_invalido
            Return View()
        End Function

        <AllowAnonymous()>
        <HttpGet()>
        Function Info() As ActionResult
            Return View()
        End Function

        <AllowAnonymous()>
        <HttpGet()>
        Function Contactanos() As ActionResult
            Dim httpcliente As New basehttpcliente
            httpcliente.gethttpstring("Inspeccion/EnviarFotosSistemaSir2")
            Return View()
        End Function

        <AllowAnonymous()> _
        <HttpGet()>
        Function MenuAnonimos() As ActionResult
            Return Content(obtener_menu_anonimos())
        End Function

        <CustomAuthorize()> _
        <HttpGet()>
        Function MenuAutenticado() As ActionResult
            Return Content(obtener_menu_autenticado())
        End Function

        Private Function obtener_menu_anonimos() As String

            Dim mnuinisesion As String = apporg & "/Seguridad/IniciarSesion?esvistaparcial=false"
            Dim mnurecuppass As String = apporg & "/Seguridad/RecuperarContrasena?esvistaparcial=false"

            Dim sbmenu As New StringBuilder("<ul id='menuprincipal'>")
            'sbmenu.Append("<li><a href='/Home/Index'>Inicio</a></li>")
            'sbmenu.Append("<li><a href='/Home/Info'>Info</a></li>")

            sbmenu.Append("<li><a href='" & mnuinisesion & "'>Iniciar sesión</a></li>")
            sbmenu.Append("<li><a href='" & mnurecuppass & "'>¿Olvidó su contraseña?</a></li>")

            'sbmenu.Append("<ul>")
            'sbmenu.Append("<li><a href='/Home/Index'>Inicio2</a></li>")
            'sbmenu.Append("<li><a href='/Home/Index'>Inicio3</a></li>")
            'sbmenu.Append("</ul>")
            'sbmenu.Append("</li>") 
            sbmenu.Append("</ul>")
            Return sbmenu.ToString
        End Function

        Private Function obtener_menu_autenticado() As String
            Dim modulo As String = ""
            Dim submodulo As String = ""
            Dim sbmenu As New StringBuilder("<ul id='menuprincipal'>")
            Dim httpcliente As New basehttpcliente

            Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & HttpContext.User.Identity.Name)
            Session("idsegmanusu") = vi_segmanusu.idsegmanusu
            Session("idcomunmanpais") = vi_segmanusu.idcomunmanpais
            Session("xcultura") = vi_segmanusu.xcultura
            Dim vi_segusuperf As Object = httpcliente.gethttpobject("vi_segusuperf/selvi_segusuperfxappyusu?idsegmanapp=" & ConfigurationManager.AppSettings("idsegmanapp") & "&idsegmanusu=" & vi_segmanusu.idsegmanusu)
            Session("idsegmanperf") = vi_segusuperf.idsegmanperf

            Dim lista_vi_segaccperf As Object = httpcliente.gethttpobjectlist("vi_segaccperf/selvi_segaccperfxappyperfytipoacc?idsegmanapp=" & ConfigurationManager.AppSettings("idsegmanapp") & "&idsegmanperf=" & Session("idsegmanperf") & "&itipoaccperf=ACCESO TOTAL")
            If lista_vi_segaccperf.Count > 0 Then
                For m As Integer = 0 To lista_vi_segaccperf.Count - 1
                    If modulo <> lista_vi_segaccperf(m).xnombrecortomod Then
                        sbmenu.Append("<li><a href='#'>" & lista_vi_segaccperf(m).xnombrecortomod & "</a>")
                        modulo = lista_vi_segaccperf(m).xnombrecortomod
                        sbmenu.Append("<ul>")
                        For s As Integer = 0 To lista_vi_segaccperf.Count - 1
                            If submodulo <> lista_vi_segaccperf(s).xnombrecortosubmod Then
                                If modulo = lista_vi_segaccperf(s).xnombrecortomod Then
                                    sbmenu.Append("<li><a href='#'>" & lista_vi_segaccperf(s).xnombrecortosubmod & "</a>")
                                    submodulo = lista_vi_segaccperf(s).xnombrecortosubmod
                                    sbmenu.Append("<ul>")
                                    For p As Integer = 0 To lista_vi_segaccperf.Count - 1
                                        If submodulo = lista_vi_segaccperf(p).xnombrecortosubmod Then
                                            lista_vi_segaccperf(p).xdirurl = apporg & lista_vi_segaccperf(p).xdirurl
                                            sbmenu.Append("<li><a href='" & lista_vi_segaccperf(p).xdirurl & "'>" & lista_vi_segaccperf(p).xnombrecortoprog & "</a></li>")
                                        End If
                                    Next p
                                    sbmenu.Append("</ul>")
                                    sbmenu.Append("</li>")
                                End If
                            End If
                        Next s
                        sbmenu.Append("</ul>")
                        sbmenu.Append("</li>")
                    End If
                Next m
            End If
            sbmenu.Append("</ul>")
            Dim v As String = sbmenu.ToString
            Return sbmenu.ToString
        End Function

    End Class
End Namespace