Imports System.Threading

Public Class LocalizedViewResult
    Inherits ViewResult

    Private _defaultCulture As String

    Public Sub New(defaultCulture As String)
        _defaultCulture = defaultCulture
    End Sub

    Public Overrides Sub ExecuteResult(context As ControllerContext)
        Dim currentCulture As String = Thread.CurrentThread.CurrentCulture.Name

        If String.IsNullOrWhiteSpace(ViewName) Then
            ViewName = context.RouteData.GetRequiredString("action")
        End If

        Dim viewResult = ViewEngines.Engines.FindView(context, Convert.ToString(Me.ViewName) & "." & currentCulture, Nothing)

        If viewResult.View Is Nothing Then
            'ViewName += "." & _defaultCulture
        Else
            ViewName += "." & currentCulture
        End If

        MyBase.ExecuteResult(context)
    End Sub
End Class