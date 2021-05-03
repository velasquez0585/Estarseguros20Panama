Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad

Namespace seginsoft.vistas.controlador
    Public Class vi_segaccperfController
        Inherits ApiController

        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selvi_segaccperfxid(idsegaccperf As Decimal) As vi_segaccperf
            Dim vi_segaccperf As vi_segaccperf = (From p In _db.vi_segaccperf
                                                  Where p.idsegaccperf = idsegaccperf
                                                  Select p).SingleOrDefault
            Return vi_segaccperf
        End Function

        <HttpGet()> _
        Public Function selvi_segaccperf() As List(Of vi_segaccperf)
            Dim lista_vi_segaccperf As List(Of vi_segaccperf) = (From p In _db.vi_segaccperf
                                                                 Select p).ToList
            Return lista_vi_segaccperf
        End Function

        <HttpGet()> _
        Public Function selvi_segaccperfxperfyprog(idsegmanperf As Decimal, idsegappprog As Decimal) As vi_segaccperf
            Dim vi_segaccperf As vi_segaccperf = (From p In _db.vi_segaccperf
                                                  Where p.idsegmanperf = idsegmanperf _
                                                  And p.idsegappprog = idsegappprog
                                                  Select p).SingleOrDefault
            Return vi_segaccperf
        End Function

        <HttpGet()> _
        Public Function selvi_segaccperfxappyperf(idsegmanapp As Decimal, idsegmanperf As Decimal) As List(Of vi_segaccperf)
            Dim lista_vi_segaccperf As List(Of vi_segaccperf) = (From p In _db.vi_segaccperf
                                                                 Where p.idsegmanapp = idsegmanapp _
                                                                 And p.idsegmanperf = idsegmanperf
                                                                 Order By p.idsegaccperf Ascending
                                                                 Select p).ToList
            Return lista_vi_segaccperf
        End Function

        <HttpGet()> _
        Public Function selvi_segaccperfxappyperfytipoacc(idsegmanapp As Decimal, idsegmanperf As Decimal, itipoaccperf As String) As List(Of vi_segaccperf)
            Dim lista_vi_segaccperf As List(Of vi_segaccperf) = (From p In _db.vi_segaccperf
                                                                 Where p.idsegmanapp = idsegmanapp _
                                                                 And p.idsegmanperf = idsegmanperf _
                                                                 And p.itipoaccperf = itipoaccperf
                                                                 Order By p.idsegmanapp, p.idsegmanmod, p.idsegmansubmod, p.idsegmanprog Ascending
                                                                 Select p).ToList
            Return lista_vi_segaccperf
        End Function
    End Class
End Namespace

