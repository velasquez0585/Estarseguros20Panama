Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad


Namespace seginsoft.vistas.controlador
    Public Class vi_segusuperfController
        Inherits ApiController

        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selvi_segusuperfxid(idsegusuperf As Decimal) As vi_segusuperf
            Dim vi_segusuperf As vi_segusuperf = (From p In _db.vi_segusuperf
                                                  Where p.idsegusuperf = idsegusuperf
                                                  Select p).SingleOrDefault
            Return vi_segusuperf
        End Function

        <HttpGet()> _
        Public Function selvi_segusuperf() As List(Of vi_segusuperf)
            Dim lista_vi_segusuperf As List(Of vi_segusuperf) = (From p In _db.vi_segusuperf
                                                                 Select p).ToList
            Return lista_vi_segusuperf
        End Function

        <HttpGet()> _
        Public Function selvi_segusuperfxappyusu(idsegmanapp As Decimal, idsegmanusu As Decimal) As vi_segusuperf
            Dim vi_segusuperf As vi_segusuperf = (From p In _db.vi_segusuperf
                                                  Where p.idsegmanapp = idsegmanapp _
                                                  And p.idsegmanusu = idsegmanusu
                                                  Select p).SingleOrDefault
            Return vi_segusuperf
        End Function
    End Class
End Namespace

