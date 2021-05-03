Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad

Namespace seginsoft.vistas.controlador
    Public Class vi_segappprogController
        Inherits ApiController

        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selvi_segappprogxid(idsegappprog As Decimal) As vi_segappprog
            Dim vi_segappprog As vi_segappprog = (From p In _db.vi_segappprog
                                                  Where p.idsegappprog = idsegappprog
                                                  Select p).SingleOrDefault
            Return vi_segappprog
        End Function

        <HttpGet()> _
        Public Function selvi_segappprog() As List(Of vi_segappprog)
            Dim lista_vi_segappprog As List(Of vi_segappprog) = (From p In _db.vi_segappprog
                                                                 Select p).ToList
            Return lista_vi_segappprog
        End Function

        <HttpGet()> _
        Public Function selvi_segappprogxapp(idsegmanapp As Decimal) As List(Of vi_segappprog)
            Dim lista_vi_segappprog As List(Of vi_segappprog) = (From p In _db.vi_segappprog
                                                                 Where p.idsegmanapp = idsegmanapp
                                                                 Order By p.idsegmanapp, p.idsegmanmod, p.idsegmansubmod, p.idsegmanprog
                                                                 Select p).ToList
            Return lista_vi_segappprog
        End Function

        <HttpGet()> _
        Public Function selvi_segappprogxmod(idsegmanapp As Decimal, idsegmanmod As Decimal) As List(Of vi_segappprog)
            Dim lista_vi_segappprog As List(Of vi_segappprog) = (From p In _db.vi_segappprog
                                                                 Where p.idsegmanapp = idsegmanapp _
                                                                 And p.idsegmanmod = idsegmanmod
                                                                 Order By p.idsegmanapp, p.idsegmanmod, p.idsegmansubmod, p.idsegmanprog
                                                                 Select p).ToList
            Return lista_vi_segappprog
        End Function

        <HttpGet()> _
        Public Function selvi_segappprogxsubmod(idsegmanapp As Decimal, idsegmanmod As Decimal, idsegmansubmod As Decimal) As List(Of vi_segappprog)
            Dim lista_vi_segappprog As List(Of vi_segappprog) = (From p In _db.vi_segappprog
                                                                 Where p.idsegmanapp = idsegmanapp _
                                                                 And p.idsegmanmod = idsegmanmod _
                                                                 And p.idsegmansubmod = idsegmansubmod
                                                                 Order By p.idsegmanapp, p.idsegmanmod, p.idsegmansubmod, p.idsegmanprog
                                                                 Select p).ToList
            Return lista_vi_segappprog
        End Function
    End Class
End Namespace

