Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Class WebApiConfig
    Public Shared Sub Register(ByVal config As HttpConfiguration)

        'Dim cors = New EnableCorsAttribute("*", "*", "*")
        'config.EnableCors(cors)

        'configuramos la ruta de las api's web
        config.Routes.MapHttpRoute( _
            name:="DefaultApi", _
            routeTemplate:="api/{controller}/{action}/{id}", _
            defaults:=New With {.id = RouteParameter.Optional} _
        )

        'configuramos al formato json para que no dé problemas con referencias circulares
        Dim json = config.Formatters.JsonFormatter
        json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects

        'removemos el formato xml ya que por ahora utilizaremos puro json
        config.Formatters.Remove(config.Formatters.XmlFormatter)

        'config.MessageHandlers.Add(New ApiKeyHandler("darjo3000"))
    End Sub
End Class