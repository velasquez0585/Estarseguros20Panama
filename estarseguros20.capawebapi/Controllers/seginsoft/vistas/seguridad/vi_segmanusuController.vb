Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad

Namespace seginsoft.vistas.controlador
    Public Class vi_segmanusuController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpGet()> _
        <HttpPost()> _
        Public Function selvi_segmanusuxid(idsegmanusu As Decimal) As vi_segmanusu
            Dim vi_segmanusu As vi_segmanusu = (From p In _db.vi_segmanusu
                                                Where p.idsegmanusu = idsegmanusu
                                                Select p).SingleOrDefault
            Return vi_segmanusu
        End Function

        <HttpGet()> _
        Public Function selvi_segmanusu() As List(Of vi_segmanusu)
            Dim lista_vi_segmanusu As List(Of vi_segmanusu) = (From p In _db.vi_segmanusu
                                                               Select p).ToList
            Return lista_vi_segmanusu
        End Function

        <HttpGet()> _
        Public Function selvi_segmanusuxnomusu(xnombreusuario As String) As vi_segmanusu
            Dim vi_segmanusu As vi_segmanusu = (From p In _db.vi_segmanusu
                                                    Where p.xnombreusuario = xnombreusuario
                                                    Select p).SingleOrDefault
            Return vi_segmanusu



        End Function

        <HttpGet()> _
        Public Function selvi_segmanusuxnomypass(xnombreusuario As String, xcontrasena As String) As vi_segmanusu

            Dim vi_segmanusu As vi_segmanusu = (From p In _db.vi_segmanusu
                                                Where p.xnombreusuario = xnombreusuario _
                                                And p.xcontrasena = xcontrasena
                                                Select p).SingleOrDefault
            Return vi_segmanusu

        End Function

        <HttpGet()> _
        Public Function selvi_segmanusuxdep(idsegmandep As Decimal) As List(Of vi_segmanusu)
            Dim lista_vi_segmanusu As List(Of vi_segmanusu) = (From p In _db.vi_segmanusu
                                                               Where p.idsegmandep = idsegmandep
                                                               Select p).ToList
            Return lista_vi_segmanusu
        End Function

        <HttpGet()> _
        Public Function selvi_segmanusuxorgydep(idsegmanorg As Decimal, idsegmandep As Decimal) As List(Of vi_segmanusu)
            Dim lista_vi_segmanusu As List(Of vi_segmanusu) = (From p In _db.vi_segmanusu
                                                               Where p.idsegmanorg = idsegmanorg _
                                                               And p.idsegmandep = idsegmandep
                                                               Select p).ToList
            Return lista_vi_segmanusu
        End Function

    End Class
End Namespace

