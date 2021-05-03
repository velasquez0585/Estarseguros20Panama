Imports System.Threading

Public Class PartialViewEngine
    Inherits RazorViewEngine

    Private Shared NewPartialViewFormats As String() = {"~/Views/{1}/Partials/{0}.vbhtml", "~/Views/Shared/Partials/{0}.vbhtml"}

    Public Sub New()
        MyBase.PartialViewLocationFormats = MyBase.PartialViewLocationFormats.Union(NewPartialViewFormats).ToArray()
    End Sub

    'Public Overrides Function FindView(controllerContext As ControllerContext, viewName As String, masterName As String, useCache As Boolean) As ViewEngineResult
    '    Dim controllerName = DirectCast(controllerContext.RouteData.Values("controller"), String)
    '    Dim format = "~/Views/{0}/{1}.{2}.vbhtml"
    '    'Dim lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName
    '    Dim culture = Thread.CurrentThread.CurrentUICulture.Name
    '    If VirtualPathProvider.FileExists(String.Format(format, controllerName, viewName, culture)) Then
    '        Return MyBase.FindView(controllerContext, viewName & "." & Convert.ToString(culture), masterName, useCache)
    '    End If
    '    Return MyBase.FindView(controllerContext, viewName, masterName, useCache)
    'End Function
End Class
