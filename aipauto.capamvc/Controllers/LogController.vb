Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.log
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.log

Public Class LogController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Log
#Region "Vistas"

    <AllowAnonymous()>
  <HttpGet()>
    Function LogEve(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_LogEve")
        Else
            Return View("LogEve")
        End If
    End Function



#End Region

#Region "Cargas"

    <AllowAnonymous()>
  <HttpPost()>
    Function ObtenerLogEventos(fdesde As String, fhasta As String, petivi_aiplogevepaglist As petivi_aiplogevepaglist) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aiplogevepaglist As String = httpcliente.posthttpobj("vi_aiplogeve/selvi_aiplogevexwheredinamicopag2/?fdesde=" & fdesde & "&fhasta=" & fhasta, petivi_aiplogevepaglist)
        Return Content(respvi_aiplogevepaglist, "application/json")
    End Function



#End Region

End Class