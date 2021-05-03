Imports System
Imports System.Web
Imports System.Web.Mvc
Imports System.Linq
Imports System.Configuration
Imports estarseguros20.capacomuncliente

Public Class CustomAuthorizeAttribute
    Inherits AuthorizeAttribute

#Region "variables"

#End Region

    Protected Overrides Function AuthorizeCore(httpContext As HttpContextBase) As Boolean
        If Not httpContext.Request.IsAuthenticated Then
            Return False
        End If

        Dim httpcliente As New basehttpcliente
        Dim vi_segmanusu As Object = httpcliente.gethttpobject("vi_segmanusu/selvi_segmanusuxnomusu?xnombreusuario=" & httpContext.User.Identity.Name)
        Dim vi_segusuperf As Object = httpcliente.gethttpobject("vi_segusuperf/selvi_segusuperfxappyusu?idsegmanapp=" & ConfigurationManager.AppSettings("idsegmanapp") & "&idsegmanusu=" & vi_segmanusu.idsegmanusu)
        Dim approles As String() = Split(vi_segusuperf.idsegmanperf, ",")
        Dim roles_autorizados As String() = Split(Me.Roles, ",")

        If roles_autorizados.Count > 0 Then
            If roles_autorizados.Count = 1 And roles_autorizados(0) = "" Then
                Return True
            End If

            For i As Integer = 0 To roles_autorizados.Count - 1
                If approles.Contains(roles_autorizados(i), StringComparer.OrdinalIgnoreCase) Then
                    Return True
                End If
            Next i
        Else
            If roles_autorizados.Count = 0 Then
                Return True
            End If
        End If
        Return False
    End Function

End Class
