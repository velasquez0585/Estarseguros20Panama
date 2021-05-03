'Imports System.Net.Http.Headers
'Imports System.Security.Principal
'Imports System.Threading

'Public Class BasicAuthHttpModule
'    Implements IHttpModule

'    Private Const Realm As String = "My Realm"

'    Public Sub Init(context As HttpApplication) Implements IHttpModule.Init
'        ' Register event handlers
'        AddHandler context.AuthenticateRequest, AddressOf OnApplicationAuthenticateRequest
'        AddHandler context.EndRequest, AddressOf OnApplicationEndRequest
'    End Sub

'    Private Shared Sub SetPrincipal(principal As IPrincipal)
'        Thread.CurrentPrincipal = principal
'        If HttpContext.Current IsNot Nothing Then
'            HttpContext.Current.User = principal
'        End If
'    End Sub

'    ' TODO: Here is where you would validate the username and password.
'    Private Shared Function CheckPassword(username As String, password As String) As Boolean
'        If username = "www.brofinza.com" And password = "segurosbrofinza" Then
'            Return True
'        Else
'            Return False
'        End If
'    End Function

'    Private Shared Function AuthenticateUser(credentials As String) As Boolean
'        Dim validated As Boolean = False
'        Try
'            Dim encoding__1 = Encoding.GetEncoding("iso-8859-1")
'            credentials = encoding__1.GetString(Convert.FromBase64String(credentials))

'            Dim separator As Integer = credentials.IndexOf(":"c)
'            Dim name As String = credentials.Substring(0, separator)
'            Dim password As String = credentials.Substring(separator + 1)

'            validated = CheckPassword(name, password)
'            If validated Then
'                Dim identity = New GenericIdentity(name)
'                SetPrincipal(New GenericPrincipal(identity, Nothing))
'            End If
'        Catch generatedExceptionName As FormatException
'            ' Credentials were not formatted correctly.

'            validated = False
'        End Try
'        Return validated
'    End Function

'    Private Shared Sub OnApplicationAuthenticateRequest(sender As Object, e As EventArgs)
'        Dim request = HttpContext.Current.Request
'        Dim authHeader = request.Headers("Authorization")
'        If authHeader IsNot Nothing Then
'            Dim authHeaderVal = AuthenticationHeaderValue.Parse(authHeader)

'            ' RFC 2617 sec 1.2, "scheme" name is case-insensitive
'            If authHeaderVal.Scheme.Equals("basic", StringComparison.OrdinalIgnoreCase) AndAlso authHeaderVal.Parameter IsNot Nothing Then
'                AuthenticateUser(authHeaderVal.Parameter)
'            End If
'        End If
'    End Sub

'    ' If the request was unauthorized, add the WWW-Authenticate header 
'    ' to the response.
'    Private Shared Sub OnApplicationEndRequest(sender As Object, e As EventArgs)
'        Dim response = HttpContext.Current.Response
'        If response.StatusCode = 401 Then
'            response.Headers.Add("WWW-Authenticate", String.Format("Basic realm=""{0}""", Realm))
'        End If
'    End Sub

'    Public Sub Dispose() Implements IHttpModule.Dispose

'    End Sub

'End Class

