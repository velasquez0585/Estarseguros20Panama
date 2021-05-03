' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
' visit http://go.microsoft.com/?LinkId=9394802
Imports System.Web.Http
Imports System.Web.Optimization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        AuthConfig.RegisterAuth()
        ViewEngines.Engines.Add(New PartialViewEngine)
    End Sub

    Protected Sub Application_Error()
        Dim exception = Server.GetLastError()
        Dim http_exception = TryCast(exception, HttpException)
        Dim httprespexc = TryCast(exception, HttpResponseException)
        Response.Clear()
        Server.ClearError()
        Dim route_data = New RouteData()
        route_data.Values("controller") = "Error"
        route_data.Values("action") = "ErrorHttp500"
        route_data.Values("exception") = exception
        Response.StatusCode = 500

        If TypeOf exception Is DivideByZeroException Then
            route_data.Values("action") = "ErrorDividerByZero"
        End If

        'If TypeOf exception Is FaultException Then
        '    route_data.Values("action") = "ErrorFaultGenerico"
        'End If

        If http_exception IsNot Nothing Then
            Response.StatusCode = http_exception.GetHttpCode()
            Select Case Response.StatusCode
                Case 400
                    route_data.Values("action") = "ErrorHttp400"
                    Exit Select
                Case 401
                    route_data.Values("action") = "ErrorHttp401"
                    Exit Select
                Case 403
                    route_data.Values("action") = "ErrorHttp403"
                    Exit Select
                Case 404
                    route_data.Values("action") = "ErrorHttp404"
                    Exit Select
                Case 405
                    route_data.Values("action") = "ErrorHttp405"
                    Exit Select
                Case 406
                    route_data.Values("action") = "ErrorHttp406"
                    Exit Select
                Case 407
                    route_data.Values("action") = "ErrorHttp407"
                    Exit Select
                Case 408
                    route_data.Values("action") = "ErrorHttp408"
                    Exit Select
                Case 410
                    route_data.Values("action") = "ErrorHttp410"
                    Exit Select
                Case 500
                    route_data.Values("action") = "ErrorHttp500"
                    Exit Select
                Case 501
                    route_data.Values("action") = "ErrorHttp501"
                    Exit Select
                Case 502
                    route_data.Values("action") = "ErrorHttp502"
                    Exit Select
                Case 503
                    route_data.Values("action") = "ErrorHttp503"
                    Exit Select
                Case 504
                    route_data.Values("action") = "ErrorHttp504"
                    Exit Select
                Case 505
                    route_data.Values("action") = "ErrorHttp505"
                    Exit Select
            End Select
        End If

        If httprespexc IsNot Nothing Then
            Response.StatusCode = httprespexc.Response.StatusCode
            Select Case Response.StatusCode
                Case 400
                    route_data.Values("action") = "ErrorHttp400"
                    Exit Select
                Case 401
                    route_data.Values("action") = "ErrorHttp401"
                    Exit Select
                Case 403
                    route_data.Values("action") = "ErrorHttp403"
                    Exit Select
                Case 404
                    route_data.Values("action") = "ErrorHttp404"
                    Exit Select
                Case 405
                    route_data.Values("action") = "ErrorHttp405"
                    Exit Select
                Case 406
                    route_data.Values("action") = "ErrorHttp406"
                    Exit Select
                Case 407
                    route_data.Values("action") = "ErrorHttp407"
                    Exit Select
                Case 408
                    route_data.Values("action") = "ErrorHttp408"
                    Exit Select
                Case 410
                    route_data.Values("action") = "ErrorHttp410"
                    Exit Select
                Case 500
                    route_data.Values("action") = "ErrorHttp500"
                    Exit Select
                Case 501
                    route_data.Values("action") = "ErrorHttp501"
                    Exit Select
                Case 502
                    route_data.Values("action") = "ErrorHttp502"
                    Exit Select
                Case 503
                    route_data.Values("action") = "ErrorHttp503"
                    Exit Select
                Case 504
                    route_data.Values("action") = "ErrorHttp504"
                    Exit Select
                Case 505
                    route_data.Values("action") = "ErrorHttp505"
                    Exit Select
            End Select
        End If

        Dim error_controller As IController = New aicweb.capamvc.ErrorController()
        Dim rc = New RequestContext(New HttpContextWrapper(Context), route_data)
        error_controller.Execute(rc)
    End Sub
End Class
