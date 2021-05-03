Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
    Public Class vi_aipextsintagendaController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipextsintagendaIdsegmanorgSini(idsegmanorgperit As Decimal, xnumsininsenc As String) As List(Of vi_aipextsintagenda)
            'idsegmanorgperit = 21
            'xnumsininsenc = 292000005

            Dim lista_vi_aipextsintagenda As List(Of vi_aipextsintagenda) = (From p In _db.vi_aipextsintagenda
                                            Where p.idsegmanorg = idsegmanorgperit And p.nnumsiniextsintagenda = xnumsininsenc
                                            Select p).ToList
            Return lista_vi_aipextsintagenda
        End Function

    End Class
End Namespace
