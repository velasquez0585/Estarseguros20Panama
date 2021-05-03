Imports System.Net.Http
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Net

Public Class ApiKeyHandler
    Inherits DelegatingHandler

    Private p_serialapi As String
    Public Property serialapi() As String
        Get
            Return p_serialapi
        End Get
        Set(value As String)
            p_serialapi = value
        End Set
    End Property

    Public Sub New(serialapi As String)
        Me.serialapi = serialapi
    End Sub

    Protected Overrides Function SendAsync(request As HttpRequestMessage, cancellationToken As CancellationToken) As Task(Of HttpResponseMessage)
        If Not ValidateKey(request) Then
            Dim response = New HttpResponseMessage(HttpStatusCode.Forbidden)
            Dim tsc = New TaskCompletionSource(Of HttpResponseMessage)()
            tsc.SetResult(response)
            Return tsc.Task
        End If
        Return MyBase.SendAsync(request, cancellationToken)
    End Function

    Private Function ValidateKey(message As HttpRequestMessage) As Boolean
        'Dim pais As String = message.Headers.GetValues("pais").FirstOrDefault
        'If pais = "venezuela" Then
        '    Return False
        'End If

        Dim query = message.RequestUri.ParseQueryString()
        Dim _serialapi As String = query("serialapi")
        Return (_serialapi = serialapi)
    End Function
End Class
