Imports Newtonsoft.Json
Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Net.Http.Headers
Imports System.Net.Http.Formatting
Imports System.Dynamic
Imports System.Configuration
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion

Public Class basehttpcliente

#Region "comentarios"
    '"application/json" Es el tipo de contenido que se recibira luego de la peticion
    '"http://localhost:9909/api/" Esta url es un ejemplo de la estructura de direccion de una asp.net web api
    '"querystring" Este parametro debe tener este formato: "controlador?nombreparametro1=valorparametro1&nombreparametro2=valorparametro2"
#End Region

#Region "variables"
    Dim httpcliente As HttpClient
    Dim httprequestmessage As HttpRequestMessage
    'Dim cadenaapi As String = "&serialapi=darjo3000"
    Dim cadenaapi As String = ""
    Dim xnombrepais As String = ""
#End Region

    Public Sub New()
        httpcliente = New HttpClient()
        'AMBIENTE LOCAL IDE
        httpcliente.BaseAddress = New Uri("http://localhost:34188/api/")

        'AMBIENTE DESARROLLO
        'httpcliente.BaseAddress = New Uri("http://localhost:8090/aipauto.estarseguros.capawebapi/api/")
        'httpcliente.BaseAddress = New Uri("http://webapisitfx.estarseguros.com/estarseguros20.capawebapi_Desa/api/")

        'Panama
        'httpcliente.BaseAddress = New Uri("http://localhost:8078/estarseguros20.capawebapi.Panama/api/")

        'Panama Prod
        ' httpcliente.BaseAddress = New Uri("http://10.141.128.243:8082/estarseguros20.capawebapi.Panama/api/")
        

        'AMBIENTE PRODUCCION
        'httpcliente.BaseAddress = New Uri("http://localhost:8081/estarseguros20.capawebapi/api/") 'estar seguros
        'httpcliente.BaseAddress = New Uri("http://webapisitfx.estarseguros.com/estarseguros20.capawebapi/api/")

        httpcliente.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

        xnombrepais = "venezuela"
        'httprequestmessage = New HttpRequestMessage
        'httprequestmessage.Headers.Add("xnombrepais", "venezuela")
    End Sub

    'httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring)
    'Dim httprespuesta As HttpResponseMessage = httpcliente.GetAsync(querystring).Result

    Public Function gethttpstring(querystring As String) As Object
        'httprequestmessage.Method = HttpMethod.Get
        'httprequestmessage.RequestUri = New Uri(httpcliente.BaseAddress.AbsoluteUri & querystring & cadenaapi)
        httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim resultado As String = httprespuesta.Content.ReadAsStringAsync.Result
            Return resultado
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return objeto.message
        End If
        Return ""
    End Function

    Public Function gethttpobject(querystring As String) As Object
        'httprequestmessage.Method = HttpMethod.Get
        'httprequestmessage.RequestUri = New System.Uri(httpcliente.BaseAddress.AbsoluteUri & querystring & cadenaapi)
        httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            Return objeto
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return objeto
        End If
        Return Nothing
    End Function
    Public Function gethttplistdownload(querystring As String) As Object
        'httprequestmessage.Method = HttpMethod.Get
        'httprequestmessage.RequestUri = New System.Uri(httpcliente.BaseAddress.AbsoluteUri & querystring & cadenaapi)
        httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As List(Of DownloadFilesResult) = JsonConvert.DeserializeObject(Of List(Of DownloadFilesResult))(jsonstring)
            Return objeto
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return objeto
        End If
        Return Nothing
    End Function

    Public Function gethttplistArch(querystring As String) As Object
        'httprequestmessage.Method = HttpMethod.Get
        'httprequestmessage.RequestUri = New System.Uri(httpcliente.BaseAddress.AbsoluteUri & querystring & cadenaapi)
        httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As List(Of vi_aipinsarch) = JsonConvert.DeserializeObject(Of List(Of vi_aipinsarch))(jsonstring)
            Return objeto
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return objeto
        End If
        Return Nothing
    End Function

    Public Function gethttpArch(querystring As String) As Object
        'httprequestmessage.Method = HttpMethod.Get
        'httprequestmessage.RequestUri = New System.Uri(httpcliente.BaseAddress.AbsoluteUri & querystring & cadenaapi)
        httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As vi_aipinsarch = JsonConvert.DeserializeObject(Of vi_aipinsarch)(jsonstring)
            Return objeto
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return objeto
        End If
        Return Nothing
    End Function

    Public Function gethttpdfr(querystring As String) As Object
        'httprequestmessage.Method = HttpMethod.Get
        'httprequestmessage.RequestUri = New System.Uri(httpcliente.BaseAddress.AbsoluteUri & querystring & cadenaapi)
        httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As DownloadFilesResult = JsonConvert.DeserializeObject(Of DownloadFilesResult)(jsonstring)
            Return objeto
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return objeto
        End If
        Return Nothing
    End Function

    Public Function gethttpobjectlist(querystring As String) As Object
        'httprequestmessage.Method = HttpMethod.Get
        'httprequestmessage.RequestUri = New System.Uri(httpcliente.BaseAddress.AbsoluteUri & querystring & cadenaapi)
        httprequestmessage = New HttpRequestMessage(HttpMethod.Get, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim lista_objetos As Object = JsonConvert.DeserializeObject(Of IEnumerable(Of ExpandoObject))(jsonstring)
            Return lista_objetos
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return objeto
        End If
        Return Nothing
    End Function

    Public Function posthttpparam(querystring As String) As String
        httprequestmessage = New HttpRequestMessage(HttpMethod.Post, querystring & cadenaapi)
        httprequestmessage.Headers.Add("xnombrepais", xnombrepais)
        Dim httprespuesta As HttpResponseMessage = httpcliente.SendAsync(httprequestmessage).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            'Dim lista_objetos As Object = JsonConvert.DeserializeObject(Of IEnumerable(Of ExpandoObject))(jsonstring)
            'Return lista_objetos
            Return jsonstring
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            'Dim objeto As Object = JsonConvert.DeserializeObject(Of ExpandoObject)(jsonstring)
            'Throw New Exception(objeto.message)
            Return jsonstring
        End If
        Return Nothing
    End Function

    Public Function posthttpobj(dirurlbase As String, objeto As Object) As String
        Dim httprespuesta As HttpResponseMessage = httpcliente.PostAsJsonAsync(dirurlbase, objeto).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Return jsonstring
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Return jsonstring
        End If
        Return Nothing
    End Function

    Public Function posthttp(dirurlbase As String, objeto As Object) As String
        Dim httprespuesta As HttpResponseMessage = httpcliente.PostAsync(dirurlbase, objeto).Result
        If httprespuesta.IsSuccessStatusCode Then
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Return jsonstring
        Else
            Dim jsonstring As String = httprespuesta.Content.ReadAsStringAsync.Result
            Return jsonstring
        End If
        Return Nothing
    End Function

End Class
