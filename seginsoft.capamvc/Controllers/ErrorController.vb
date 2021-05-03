
Namespace aicweb.capamvc
    Public Class ErrorController
        Inherits System.Web.Mvc.Controller

        '
        ' GET: /Error

        <AllowAnonymous()>
        Public Function ErrorGenerico(exception As Exception) As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "Error inesperado", .xmensaje = exception.Message})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp400() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "400 - Petición errónea"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp401() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "401 - Acceso no autorizado"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp403() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "403 - Petición prohibida"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp404(exception As Exception) As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "404 - La página no se encontró", .xmensaje = "La página a la que usted está intentando acceder no se encuentra."})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp405() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "405 - El método no esta permitido"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp406() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "406 - La petición no se acepta"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp407() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "407 - Autenticación de proxy requerida"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp408() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "408 - Tiempo de espera agotado para la petición"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp410() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "410 - Error en petición"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp500(exception As Exception) As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "500 - Error interno del servidor", .xmensaje = exception.Message})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp501() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "501 - Error de implementación"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp502() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "502 - Gateway erróneo"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp503() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "503 - Servicio no disponible"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp504() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "504 - Tiempo de espera agotado para el Gateway"})
        End Function

        <AllowAnonymous()>
        Public Function ErrorHttp505() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "505 - Versión de http no soportada"})
        End Function

        '-----------------------------------------------------------------------------------------------------------------

        <AllowAnonymous()>
        Public Function ErrorHttp5000() As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "5000 - Acceso no autorizado", .xmensaje = "Usted no tiene un acceso habilitado a la página que está solicitando."})
        End Function

        '<AllowAnonymous()>
        'Public Function ErrorFaultGenerico(exception As FaultException) As ActionResult
        '    Return View("Error", New ErrorModel() With {.xtitulo = "5001 - Error en servicio", .xmensaje = exception.Message})
        'End Function

        <AllowAnonymous()>
        Public Function ErrorDividerByZero(exception As DivideByZeroException) As ActionResult
            Return View("Error", New ErrorModel() With {.xtitulo = "5001 - División entre cero", .xmensaje = exception.Message})
        End Function

    End Class
End Namespace