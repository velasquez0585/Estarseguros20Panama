Imports System.Globalization
Imports System.Threading

Public Class SetCultureAttribute
    Inherits FilterAttribute
    Implements IActionFilter

    Public Sub OnActionExecuted(filterContext As System.Web.Mvc.ActionExecutedContext) Implements System.Web.Mvc.IActionFilter.OnActionExecuted

    End Sub

    Public Sub OnActionExecuting(filterContext As System.Web.Mvc.ActionExecutingContext) Implements System.Web.Mvc.IActionFilter.OnActionExecuting
        Dim cultura As String = Convert.ToString(filterContext.HttpContext.Session("xcultura"))
        If cultura Is Nothing Or cultura = "" Then
            cultura = "es-VE"
        End If
        Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(cultura)
        Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(cultura)
    End Sub
End Class
