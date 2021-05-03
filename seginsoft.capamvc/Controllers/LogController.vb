Imports estarseguros20.capacomuncliente
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.trazabilidad
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports Newtonsoft.Json
Imports System.Net.Http

Public Class LogController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Log

    '<CustomAuthorize()>
    <HttpGet()>
    Function log(esvistaparcial As Boolean) As ActionResult
        If esvistaparcial Then
            Return PartialView("_Log")
        Else
            Return View("Log")
        End If
    End Function

    '<CustomAuthorize()>
    '<HttpPost()>
    'Function ObtenerLogErrores(petiseglogerrpaglist As petiseglogerrpaglist) As ActionResult
    '    Dim httpcliente As New basehttpcliente
    '    Dim respseglogerrpaglist As String = httpcliente.posthttpobj("seglogerr/selseglogerrxwheredinamicopag/", petiseglogerrpaglist)
    '    Return Content(respseglogerrpaglist, "application/json")


    '    'Dim respseglogerrpaglist As New respseglogerrpaglist
    '    'Dim lista_seglogerr As New List(Of seglogerr)
    '    'Dim petiseglogerrpaglist As New petiseglogerrpaglist
    '    ''petiseglogerrpaglist.pagseglogerr.npagactual = 1


    '    'lista_seglogerr.Add(New seglogerr)
    '    'lista_seglogerr(0).idseglogerr = 1
    '    'lista_seglogerr(0).flogerr = "05/02/2014"
    '    'lista_seglogerr(0).xdatoslogerr = "APLICACION=ISOSIGMA;USUARIO=MARITZA PIAMONTE"
    '    'lista_seglogerr(0).xexmessage = "PRUEBA"
    '    'lista_seglogerr(0).xexsource = "System.Web"

    '    'lista_seglogerr.Add(New seglogerr)
    '    'lista_seglogerr(1).idseglogerr = 2
    '    'lista_seglogerr(1).flogerr = "05/02/2014"
    '    'lista_seglogerr(1).xdatoslogerr = "APLICACION=ISOSIGMA;USUARIO=MARITZA PIAMONTE"
    '    'lista_seglogerr(1).xexmessage = "PRUEBA"
    '    'lista_seglogerr(1).xexsource = "System.Web"

    '    'lista_seglogerr.Add(New seglogerr)
    '    'lista_seglogerr(2).idseglogerr = 3
    '    'lista_seglogerr(2).flogerr = "05/02/2014"
    '    'lista_seglogerr(2).xdatoslogerr = "APLICACION=ISOSIGMA;USUARIO=MARITZA PIAMONTE"
    '    'lista_seglogerr(2).xexmessage = "PRUEBA"
    '    'lista_seglogerr(2).xexsource = "System.Web"

    '    'lista_seglogerr.Add(New seglogerr)
    '    'lista_seglogerr(3).idseglogerr = 4
    '    'lista_seglogerr(3).flogerr = "05/02/2014"
    '    'lista_seglogerr(3).xdatoslogerr = "APLICACION=SEGINSOFT;USUARIO=DARWIN PEREZ"
    '    'lista_seglogerr(3).xexmessage = "PRUEBA"
    '    'lista_seglogerr(3).xexsource = "System.Web"

    '    'lista_seglogerr.Add(New seglogerr)
    '    'lista_seglogerr(4).idseglogerr = 5
    '    'lista_seglogerr(4).flogerr = "05/02/2014"
    '    'lista_seglogerr(4).xdatoslogerr = "APLICACION=SEGINSOFT;USUARIO=DARWIN PEREZ"
    '    'lista_seglogerr(4).xexmessage = "PRUEBA"
    '    'lista_seglogerr(4).xexsource = "System.Web"

    '    'lista_seglogerr.Add(New seglogerr)
    '    'lista_seglogerr(5).idseglogerr = 6
    '    'lista_seglogerr(5).flogerr = "05/02/2014"
    '    'lista_seglogerr(5).xdatoslogerr = "APLICACION=SEGINSOFT;USUARIO=DARWIN PEREZ"
    '    'lista_seglogerr(5).xexmessage = "PRUEBA"
    '    'lista_seglogerr(5).xexsource = "System.Web"

    '    'lista_seglogerr.Add(New seglogerr)
    '    'lista_seglogerr(6).idseglogerr = 7
    '    'lista_seglogerr(6).flogerr = "05/02/2014"
    '    'lista_seglogerr(6).xdatoslogerr = "APLICACION=SEGINSOFT;USUARIO=DARWIN PEREZ"
    '    'lista_seglogerr(6).xexmessage = "PRUEBA"
    '    'lista_seglogerr(6).xexsource = "System.Web"

    '    'respseglogerrpaglist.lista_seglogerr = lista_seglogerr

    '    ''respseglogerrpaglist.pagseglogerr = New paginacion With {.npagcantidad = 2, .npagtamano = 2, .npagactual = petiseglogerrpaglist.pagseglogerr.npagactual}

    '    'Dim respseglogerrpaglist_json As String = JsonConvert.SerializeObject(respseglogerrpaglist)

    '    'Return Content(respseglogerrpaglist_json, "application/json")
    'End Function

    '<CustomAuthorize()>
    '<HttpPost()>
    'Function ObtenerLogEventos(petiseglogevepaglist As petiseglogevepaglist) As ActionResult
    '    Dim httpcliente As New basehttpcliente
    '    Dim respseglogevepaglist As String = httpcliente.posthttpobj("seglogeve/selseglogevexwheredinamicopag/", petiseglogevepaglist)
    '    Return Content(respseglogevepaglist, "application/json")

    '    'Dim respseglogevepaglist As New respseglogevepaglist
    '    'Dim lista_seglogeve As New List(Of seglogeve)
    '    'Dim petiseglogevepaglist As New petiseglogevepaglist
    '    ''petiseglogerrpaglist.pagseglogerr.npagactual = 1


    '    'lista_seglogeve.Add(New seglogeve)
    '    'lista_seglogeve(0).idseglogeve = 1
    '    'lista_seglogeve(0).flogeve = "05/02/2014"
    '    'lista_seglogeve(0).xdatoslogeve = "Pruebas Eventos"


    '    'lista_seglogeve.Add(New seglogeve)
    '    'lista_seglogeve(1).idseglogeve = 2
    '    'lista_seglogeve(1).flogeve = "05/02/2014"
    '    'lista_seglogeve(1).xdatoslogeve = "Pruebas Eve"

    '    'lista_seglogeve.Add(New seglogeve)
    '    'lista_seglogeve(2).idseglogeve = 3
    '    'lista_seglogeve(2).flogeve = "05/02/2014"
    '    'lista_seglogeve(2).xdatoslogeve = "Pruebas Eve2"

    '    'lista_seglogeve.Add(New seglogeve)
    '    'lista_seglogeve(3).idseglogeve = 4
    '    'lista_seglogeve(3).flogeve = "05/02/2014"
    '    'lista_seglogeve(3).xdatoslogeve = "Pruebas Eve3"


    '    'lista_seglogeve.Add(New seglogeve)
    '    'lista_seglogeve(4).idseglogeve = 5
    '    'lista_seglogeve(4).flogeve = "05/02/2014"
    '    'lista_seglogeve(4).xdatoslogeve = "Pruebas Eve4"

    '    'lista_seglogeve.Add(New seglogeve)
    '    'lista_seglogeve(5).idseglogeve = 6
    '    'lista_seglogeve(5).flogeve = "05/02/2014"
    '    'lista_seglogeve(5).xdatoslogeve = "Pruebas Eve5"

    '    'lista_seglogeve.Add(New seglogeve)
    '    'lista_seglogeve(6).idseglogeve = 7
    '    'lista_seglogeve(6).flogeve = "05/02/2014"
    '    'lista_seglogeve(6).xdatoslogeve = "Pruebas Eve6"


    '    'respseglogevepaglist.lista_seglogeve = lista_seglogeve

    '    ''respseglogerrpaglist.pagseglogerr = New paginacion With {.npagcantidad = 2, .npagtamano = 2, .npagactual = petiseglogerrpaglist.pagseglogerr.npagactual}

    '    'Dim respseglogevepaglist_json As String = JsonConvert.SerializeObject(respseglogevepaglist)

    '    'Return Content(respseglogevepaglist_json, "application/json")
    'End Function

    '<CustomAuthorize()>
    '<HttpPost()>
    'Function ObtenerLogRegistros(petiseglogregpaglist As petiseglogregpaglist) As ActionResult
    '    Dim httpcliente As New basehttpcliente
    '    Dim respseglogregpaglist As String = httpcliente.posthttpobj("seglogreg/selseglogregxwheredinamicopag/", petiseglogregpaglist)
    '    Return Content(respseglogregpaglist, "application/json")

    '    'Dim respseglogregpaglist As New respseglogregpaglist
    '    'Dim lista_seglogreg As New List(Of seglogreg)
    '    'Dim petiseglogregpaglist As New petiseglogregpaglist
    '    ''petiseglogerrpaglist.pagseglogerr.npagactual = 1


    '    'lista_seglogreg.Add(New seglogreg)
    '    'lista_seglogreg(0).idseglogreg = 1
    '    'lista_seglogreg(0).xdescripcionreg = "REGISTRO DE ERROR"
    '    'lista_seglogreg(0).istatusreg = "OPERATIVO"
    '    'lista_seglogreg(0).fregistro = "05/02/2014"

    '    'lista_seglogreg.Add(New seglogreg)
    '    'lista_seglogreg(1).idseglogreg = 2
    '    'lista_seglogreg(1).xdescripcionreg = "05/02/2014"
    '    'lista_seglogreg(1).istatusreg = "APLICACION=ISOSIGMA;USUARIO=MARITZA PIAMONTE"
    '    'lista_seglogreg(1).fregistro = "PRUEBA"


    '    'lista_seglogreg.Add(New seglogreg)
    '    'lista_seglogreg(2).idseglogreg = 3
    '    'lista_seglogreg(2).xdescripcionreg = "05/02/2014"
    '    'lista_seglogreg(2).istatusreg = "APLICACION=ISOSIGMA;USUARIO=MARITZA PIAMONTE"
    '    'lista_seglogreg(2).fregistro = "PRUEBA"


    '    'lista_seglogreg.Add(New seglogreg)
    '    'lista_seglogreg(3).idseglogreg = 4
    '    'lista_seglogreg(3).xdescripcionreg = "05/02/2014"
    '    'lista_seglogreg(3).istatusreg = "APLICACION=SEGINSOFT;USUARIO=DARWIN PEREZ"
    '    'lista_seglogreg(3).fregistro = "PRUEBA"


    '    'lista_seglogreg.Add(New seglogreg)
    '    'lista_seglogreg(4).idseglogreg = 5
    '    'lista_seglogreg(4).xdescripcionreg = "05/02/2014"
    '    'lista_seglogreg(4).istatusreg = "APLICACION=SEGINSOFT;USUARIO=DARWIN PEREZ"
    '    'lista_seglogreg(4).fregistro = "PRUEBA"

    '    'respseglogregpaglist.lista_seglogreg = lista_seglogreg

    '    ''respseglogerrpaglist.pagseglogerr = New paginacion With {.npagcantidad = 2, .npagtamano = 2, .npagactual = petiseglogerrpaglist.pagseglogerr.npagactual}

    '    'Dim respseglogregpaglist_json As String = JsonConvert.SerializeObject(respseglogregpaglist)

    '    'Return Content(respseglogregpaglist_json, "application/json")
    'End Function



End Class