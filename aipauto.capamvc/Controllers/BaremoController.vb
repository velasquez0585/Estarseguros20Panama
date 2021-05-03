Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.baremo
Imports estarseguros20.capaobjetos.modelo.personalizados


Public Class BaremoController
    Inherits System.Web.Mvc.Controller

#Region "Vistas"

    <AllowAnonymous()>
  <HttpGet()>
    Function Bare(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_Bare")
        Else
            Return View("Bare")
        End If
    End Function



#End Region
#Region "Cargas"

    <AllowAnonymous()>
  <HttpPost()>
    Function VerUltimoBaremoMobr() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipbaremobr As String = httpcliente.posthttpparam("Baremo/VerUltimoBaremoMobr/")
        Return Content(lista_vi_aipbaremobr, "application/json")
    End Function
    <AllowAnonymous()>
    <HttpPost()>
    Function VerUltimoBaremoMobrPag(paginacion As paginacion) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipbaremobrpaglist As String = httpcliente.posthttpobj("Baremo/VerUltimoBaremoMobrPag/", paginacion)
        Return Content(respvi_aipbaremobrpaglist, "application/json")
    End Function


    <AllowAnonymous()>
  <HttpPost()>
    Function ObtenerBaremoMobrPorFechaAplica(faplibaremobr As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipbaremobr As String = httpcliente.posthttpparam("vi_aipbaremobr/selvi_aipbaremobrxfapli/faplibaremobr?" & faplibaremobr)
        Return Content(lista_vi_aipbaremobr, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function VerUltimoBaremoRepu() As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipbarerepu As String = httpcliente.posthttpparam("Baremo/VerUltimoBaremoRepu/")
        Return Content(lista_vi_aipbarerepu, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function VerUltimoBaremoRepuPag(paginacion As paginacion) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respvi_aipbarerepupaglist As String = httpcliente.posthttpobj("Baremo/VerUltimoBaremoRepuPag/", paginacion)
        Return Content(respvi_aipbarerepupaglist, "application/json")
    End Function

   

    <AllowAnonymous()>
  <HttpPost()>
    Function ObtenerBaremoRepuPorFechaAplica(faplibarerepu As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipbarerepu As String = httpcliente.posthttpparam("vi_aipbarerepu/selvi_aipbarerepuxfapli/?faplibareRepu=" & faplibarerepu)
        Return Content(lista_vi_aipbareRepu, "application/json")
    End Function

    <AllowAnonymous()>
 <HttpPost()>
    Function ObtenerOrigenBareRepu(idaipmanrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_comboaipbarerepuorig As String = httpcliente.posthttpparam("Baremo/ObtenerOrigenBareRepu/?idaipmanrepu=" & idaipmanrepu)
        Return Content(lista_vi_comboaipbarerepuorig, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerTamaBareMobr(idaipmanrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_comboaipbaremobrtama As String = httpcliente.posthttpparam("Baremo/ObtenerTamaBareMobr/?idaipmanrepu=" & idaipmanrepu)
        Return Content(lista_vi_comboaipbaremobrtama, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerMaterBareMobr(idaipmanrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_comboaipbaremobrmater As String = httpcliente.posthttpparam("Baremo/ObtenerMaterBareMobr?idaipmanrepu=" & idaipmanrepu)
        Return Content(lista_vi_comboaipbaremobrmater, "application/json")
    End Function
    <AllowAnonymous()>
 <HttpPost()>
    Function ObtenerMobrBareMobr(idaipmanrepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_comboaipbaremobrmobr As String = httpcliente.posthttpparam("Baremo/ObtenerMobrBareMobr?idaipmanrepu=" & idaipmanrepu)
        Return Content(lista_vi_comboaipbaremobrmobr, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerCostoBareRepu(idaipmanrepu As Decimal, iorigbarerepu As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim mcostbarerepu As String = httpcliente.posthttpparam("Baremo/ObtenerCostoBareRepu?idaipmanrepu=" & idaipmanrepu & "&iorigbarerepu=" & iorigbarerepu)
        Return Content(mcostbarerepu, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerCostoBareMobr(idaipmanrepu As Decimal, itamapiezbaremobr As String, imaterpiezbaremobr As String, itipobaremobr As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim mcostbaremobr As String = httpcliente.posthttpparam("Baremo/ObtenerCostoBareMobr?idaipmanrepu=" & idaipmanrepu & "&itamapiezbaremobr=" & itamapiezbaremobr & "&imaterpiezbaremobr=" & imaterpiezbaremobr & "&itipobaremobr=" & itipobaremobr)
        Return Content(mcostbaremobr, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerIdBareRepu(idaipmanrepu As Decimal, iorigbarerepu As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim mcostbarerepu As String = httpcliente.posthttpparam("Baremo/ObtenerIdBareRepu?idaipmanrepu=" & idaipmanrepu & "&iorigbarerepu=" & iorigbarerepu)
        Return Content(mcostbarerepu, "application/json")
    End Function
    <AllowAnonymous()>
<HttpPost()>
    Function ObtenerIdBareMobr(idaipmanrepu As Decimal, itamapiezbaremobr As String, imaterpiezbaremobr As String, itipobaremobr As String) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim mcostbaremobr As String = httpcliente.posthttpparam("Baremo/ObtenerIdBareMobr?idaipmanrepu=" & idaipmanrepu & "&itamapiezbaremobr=" & itamapiezbaremobr & "&imaterpiezbaremobr=" & imaterpiezbaremobr & "&itipobaremobr=" & itipobaremobr)
        Return Content(mcostbaremobr, "application/json")
    End Function
#End Region
#Region "Seleccion ID"
    '  <AllowAnonymous()>
    '<HttpPost()>
    '  Function ObtenerRepuestoPorId(idaicmanrepu As Decimal) As ActionResult
    '      Dim httpcliente As New basehttpcliente
    '      Dim aicmanrepu As String = httpcliente.posthttpparam("aipmanrepu/selaipmanrepuxid/?idaicmanrepu=" & idaicmanrepu)
    '      Return Content(aicmanrepu, "application/json")
    '  End Function


     
#End Region

#Region "Agregar"
    <AllowAnonymous()>
<HttpPost()>
    Function CrearBaremoMobrPred(faplibaremobr As String) As ActionResult
        Dim fdesdef As Date = Date.ParseExact(faplibaremobr, "dd/MM/yyyy",
               System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipbaremobr As String = httpcliente.posthttpparam("Baremo/CrearBaremoMobrPred/?faplibaremobr=" & fdesdef.ToString("yyyy/MM/dd"))
        Return Content(lista_vi_aipbaremobr, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function CrearBaremoMobr(lista_baremobrmasivo As List(Of baremobrmasivo)) As ActionResult
      
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Baremo/CrearBaremoMobr/", lista_baremobrmasivo)
        Return Content(respopera, "application/json")
    End Function

    <AllowAnonymous()>
<HttpPost()>
    Function CrearBaremoRepuPred(faplibarerepu As String) As ActionResult
        Dim fdesdef As Date = Date.ParseExact(faplibarerepu, "dd/MM/yyyy",
             System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim httpcliente As New basehttpcliente
        Dim lista_vi_aipbarerepu As String = httpcliente.posthttpparam("Baremo/CrearBaremoRepuPred/?faplibarerepu=" & fdesdef.ToString("yyyy/MM/dd"))
        Return Content(lista_vi_aipbarerepu, "application/json")
    End Function

    <AllowAnonymous()>
    <HttpPost()>
    Function CrearBaremoRepu(lista_barerepumasivo As List(Of barerepumasivo)) As ActionResult
        
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Baremo/CrearBaremoRepu/", lista_barerepumasivo)
        Return Content(respopera, "application/json")
    End Function



#End Region

#Region "Modificar"
    <AllowAnonymous()>
    <HttpPost()>
    Function ActualizarBaremoMobrMasivo(lista_vi_aipbaremobr As List(Of vi_aipbaremobr)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Baremo/ActualizarBaremoMobrMasivo/", lista_vi_aipbaremobr)
        Return Content(respopera, "application/json")
    End Function

    <AllowAnonymous()>
   <HttpPost()>
    Function ActualizarBaremoRepuMasivo(lista_vi_aipbarerepu As List(Of vi_aipbarerepu)) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpobj("Baremo/ActualizarBaremoRepuMasivo/", lista_vi_aipbarerepu)
        Return Content(respopera, "application/json")
    End Function

#End Region

#Region "Eliminar"
    <AllowAnonymous()>
    <HttpPost()>
    Function EliminarBaremoMobr(idaipbaremobr As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipbaremobr/eliaipbaremobr/?idaipbaremobr=" & idaipbaremobr)
        Return Content(respopera, "application/json")
    End Function
    <AllowAnonymous()>
  <HttpPost()>
    Function EliminarBaremoRepu(idaipbarerepu As Decimal) As ActionResult
        Dim httpcliente As New basehttpcliente
        Dim respopera As String = httpcliente.posthttpparam("aipbarerepu/eliaipbarerepu/?idaipbarerepu=" & idaipbarerepu)
        Return Content(respopera, "application/json")
    End Function
#End Region
End Class