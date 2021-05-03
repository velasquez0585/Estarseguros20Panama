Imports System.Net.Http

Public Class CustomMultipartFormDataStreamProvider
    Inherits MultipartFormDataStreamProvider
    Public Sub New(path As String)
        MyBase.New(path)
    End Sub

    Public Overrides Function GetLocalFileName(headers As System.Net.Http.Headers.HttpContentHeaders) As String
        Dim name = If(Not String.IsNullOrWhiteSpace(headers.ContentDisposition.FileName), headers.ContentDisposition.FileName, "NoName")
        Return name.Replace("""", String.Empty)
        'this is here because Chrome submits files in quotation marks which get treated as part of the filename and get escaped
    End Function
End Class