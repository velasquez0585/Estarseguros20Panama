Namespace aicweb.capamvc

    <SetCulture()>
    Public Class BaseController
        Inherits System.Web.Mvc.Controller

        Public Function LocalizedView(Optional viewName As String = Nothing, Optional model As Object = Nothing, _
                                      Optional master As String = Nothing, Optional defaultLang As String = "") As LocalizedViewResult
            If model IsNot Nothing Then
                ViewData.Model = model
            End If

            Return New LocalizedViewResult(defaultLang) With { _
             .ViewName = viewName, _
             .MasterName = master, _
             .ViewData = ViewData, _
             .TempData = TempData _
            }
        End Function

        Public Function LocalizedPartialView(Optional viewName As String = Nothing, Optional model As Object = Nothing, _
                                      Optional master As String = Nothing, Optional defaultLang As String = "") As LocalizedPartialViewResult
            If model IsNot Nothing Then
                ViewData.Model = model
            End If

            Return New LocalizedPartialViewResult(defaultLang) With { _
             .ViewName = viewName, _
             .ViewData = ViewData, _
             .TempData = TempData _
            }
        End Function

    End Class
End Namespace