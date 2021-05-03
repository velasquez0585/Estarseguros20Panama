Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Web
Imports System.Web.Http
Imports System.Text
Imports System.Threading.Tasks

Public Class UploadController
    Inherits ApiController
    Public Async Function PostFile() As Task(Of HttpResponseMessage)
        ' Check if the request contains multipart/form-data.
        If Not Request.Content.IsMimeMultipartContent() Then
            Throw New HttpResponseException(HttpStatusCode.UnsupportedMediaType)
        End If

        Dim root As String = HttpContext.Current.Server.MapPath("~/App_Data")
        Dim provider = New CustomMultipartFormDataStreamProvider(root)

        Try
            Dim sb As New StringBuilder()
            ' Holds the response body
            ' Read the form data and return an async task.
            Await Request.Content.ReadAsMultipartAsync(provider)
            Dim nombreArchivo As String
            Dim usuario As String = provider.FormData.Get("userName")
            Dim lat As String = convertToDegree(provider.FormData.Get("LAT"))
            Dim lot As String = convertToDegree(provider.FormData.Get("LONG"))
            For Each file As MultipartFileData In provider.FileData
                nombreArchivo = (file.Headers.ContentDisposition.FileName) 
            Next

            Return New HttpResponseMessage() With { _
                 .Content = New StringContent(sb.ToString()) _
            }
        Catch e As System.Exception
            Return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e)
        End Try
    End Function

    Private Function convertToDegree(ByVal stringDMS As String) As Double

        Dim result As Double = 0
        Dim DMS() As String = Split(stringDMS, ",")
        Dim stringD() As String = Split(DMS(0), "/")

        Dim D0 As Double = Double.Parse(stringD(0))
        Dim D1 As Double = Double.Parse(stringD(1))
        Dim FloatD As Double = D0 / D1

        Dim stringM() As String = Split(DMS(1), "/")
        Dim M0 As Double = Double.Parse(stringM(1))
        Dim M1 As Double = Double.Parse(stringM(1))
        Dim FloatM As Double = M0 / M1

        Dim stringS() As String = Split(DMS(2), "/")
        Dim S0 As Double = Double.Parse(stringS(1))
        Dim S1 As Double = Double.Parse(stringS(1))
        Dim FloatS As Double = S0 / S1


        result = FloatD + (FloatM / 60) + (FloatS / 3600)

        Return result


    End Function

    Public Function Post(<FromUri> filename As String) As HttpResponseMessage
        Dim task = Me.Request.Content.ReadAsStreamAsync()
        task.Wait()
        Dim requestStream As Stream = task.Result

        Try
            Dim fileStream As Stream = File.Create(HttpContext.Current.Server.MapPath("~/App_Data/" & filename))
            requestStream.CopyTo(fileStream)
            fileStream.Close()
            requestStream.Close()
        Catch generatedExceptionName As IOException

        End Try

        Dim response As New HttpResponseMessage()
        response.StatusCode = HttpStatusCode.Created
        Return response
    End Function
End Class