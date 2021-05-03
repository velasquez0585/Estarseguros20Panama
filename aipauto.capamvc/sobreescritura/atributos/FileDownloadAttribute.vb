Imports System.Web
Imports System.Web.Mvc

<AttributeUsage(AttributeTargets.Class Or AttributeTargets.Method, Inherited:=True, AllowMultiple:=False)> _
Public Class FileDownloadAttribute
    Inherits ActionFilterAttribute
    Public Sub New(Optional cookieName__1 As String = "fileDownload", Optional cookiePath__2 As String = "/")
        CookieName = cookieName__1
        CookiePath = cookiePath__2
    End Sub

    Public Property CookieName() As String
        Get
            Return m_CookieName
        End Get
        Set(value As String)
            m_CookieName = value
        End Set
    End Property
    Private m_CookieName As String

    Public Property CookiePath() As String
        Get
            Return m_CookiePath
        End Get
        Set(value As String)
            m_CookiePath = value
        End Set
    End Property
    Private m_CookiePath As String

    ''' <summary>
    ''' If the current response is a FileResult (an MVC base class for files) then write a
    ''' cookie to inform jquery.fileDownload that a successful file download has occured
    ''' </summary>
    ''' <param name="filterContext"></param>
    Private Sub CheckAndHandleFileResult(filterContext As ActionExecutedContext)
        Dim httpContext = filterContext.HttpContext
        Dim response = httpContext.Response

        If TypeOf filterContext.Result Is FileResult Then
            'jquery.fileDownload uses this cookie to determine that a file download has completed successfully
            response.AppendCookie(New HttpCookie(CookieName, "true") With {.Path = CookiePath})
            'ensure that the cookie is removed in case someone did a file download without using jquery.fileDownload
        ElseIf httpContext.Request.Cookies(CookieName) IsNot Nothing Then
            response.AppendCookie(New HttpCookie(CookieName, "true") With {.Expires = DateTime.Now.AddYears(-1), .Path = CookiePath })
        End If
    End Sub

    Public Overrides Sub OnActionExecuted(filterContext As ActionExecutedContext)
        CheckAndHandleFileResult(filterContext)

        MyBase.OnActionExecuted(filterContext)
    End Sub
End Class