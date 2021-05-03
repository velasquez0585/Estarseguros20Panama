Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad

Namespace seginsoft.entidades.controlador
    Public Class segmanusuController
        Inherits ApiController
        'HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpGet()> _
        Public Function selsegmanusuxid(idsegmanusu As Decimal) As segmanusu
            Dim segmanusu As segmanusu = (From p In _db.segmanusu
                                          Where p.idsegmanusu = idsegmanusu
                                          Select p).SingleOrDefault
            Return segmanusu
        End Function

        <HttpGet()> _
        Public Function selsegmanusu() As List(Of segmanusu)
            Dim lista_segmanusu As List(Of segmanusu) = (From p In _db.segmanusu
                                                         Select p).ToList
            Return lista_segmanusu
        End Function

        <HttpGet()> _
        Public Function selsegmanusuxnomusu(xnombreusuario As String) As segmanusu
            Dim segmanusu As segmanusu = (From p In _db.segmanusu
                                          Where p.xnombreusuario = xnombreusuario
                                          Select p).SingleOrDefault
            Return segmanusu
        End Function

        <HttpGet()> _
        Public Function selsegmanusuxnomypass(xnombreusuario As String, xcontrasena As String) As segmanusu
            Dim segmanusu As segmanusu = (From p In _db.segmanusu
                                          Where p.xnombreusuario = xnombreusuario _
                                          And p.xcontrasena = xcontrasena
                                          Select p).SingleOrDefault
            Return segmanusu
        End Function

        'OJO ESTE METODO FALTA TERMINARLO
        <HttpPost()> _
        Public Function inssegmanusu(idcomunmanpers As Decimal, idcomunmancom As Decimal, _
                                  idcomunmandir As Decimal, idsegmanorg As Decimal, idsegmandep As Decimal, _
                                  idsegmancarg As Decimal, xnombreusuario As String, xcontrasena As String, _
                                  fcreacion As DateTime, ibloqueado As Boolean, fultbloqueo As DateTime, _
                                  fultiniciosesion As DateTime, fultcambpass As DateTime, fultrecuppass As DateTime, _
                                  fultpassintfallido As DateTime, npassintfallido As Int64, npassintfallidoacum As Int64) As Boolean
            Try
                Dim segmanusu As New segmanusu
                segmanusu.idsegmanusu = selsegmanusu.Count + 1
                segmanusu.idcomunmanpers = idcomunmanpers
                segmanusu.idcomunmancom = idcomunmancom
                segmanusu.idcomunmandir = idcomunmandir
                segmanusu.idsegmanorg = idsegmanorg
                segmanusu.idsegmandep = idsegmandep
                segmanusu.idsegmancarg = idsegmancarg
                segmanusu.xnombreusuario = xnombreusuario
                segmanusu.xcontrasena = xcontrasena
                segmanusu.fcreacion = fcreacion
                segmanusu.ibloqueado = ibloqueado
                segmanusu.fultbloqueo = fultbloqueo
                segmanusu.fultiniciosesion = fultiniciosesion
                segmanusu.fultcambpass = fultcambpass
                segmanusu.fultrecuppass = fultrecuppass
                segmanusu.fultpassintfallido = fultpassintfallido
                segmanusu.npassintfallido = npassintfallido
                segmanusu.npassintfallidoacum = npassintfallidoacum
                segmanusu.idseglogreg = 0
                _db.AddObject("segmanusu", segmanusu)
                _db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpPut()> _
        Public Function modsegmanusu(idsegmanusu As Decimal, idcomunmanpers As Decimal, idcomunmancom As Decimal, _
                                  idcomunmandir As Decimal, idsegmanorg As Decimal, idsegmandep As Decimal, _
                                  idsegmancarg As Decimal, xnombreusuario As String, xcontrasena As String, _
                                  fcreacion As DateTime, ibloqueado As Boolean, fultbloqueo As DateTime, _
                                  fultiniciosesion As DateTime, fultcambpass As DateTime, fultrecuppass As DateTime, _
                                  fultpassintfallido As DateTime, npassintfallido As Int64, npassintfallidoacum As Int64, _
                                  idseglogreg As Decimal) As Boolean
            Try
                Dim segmanusu As segmanusu = selsegmanusuxid(idsegmanusu)
                If segmanusu IsNot Nothing Then
                    segmanusu.idcomunmanpers = idcomunmanpers
                    segmanusu.idcomunmancom = idcomunmancom
                    segmanusu.idcomunmandir = idcomunmandir
                    segmanusu.idsegmanorg = idsegmanorg
                    segmanusu.idsegmandep = idsegmandep
                    segmanusu.idsegmancarg = idsegmancarg
                    segmanusu.xnombreusuario = xnombreusuario
                    segmanusu.xcontrasena = xcontrasena
                    segmanusu.fcreacion = fcreacion
                    segmanusu.ibloqueado = ibloqueado
                    segmanusu.fultbloqueo = fultbloqueo
                    segmanusu.fultiniciosesion = fultiniciosesion
                    segmanusu.fultcambpass = fultcambpass
                    segmanusu.fultrecuppass = fultrecuppass
                    segmanusu.fultpassintfallido = fultpassintfallido
                    segmanusu.npassintfallido = npassintfallido
                    segmanusu.npassintfallidoacum = npassintfallidoacum
                    segmanusu.idseglogreg = idseglogreg
                    _db.SaveChanges()
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpDelete()> _
        Public Function elisegmanusu(idsegmanusu As Decimal) As Boolean
            Try
                Dim segmanusu As segmanusu = selsegmanusuxid(idsegmanusu)
                If segmanusu IsNot Nothing Then
                    _db.DeleteObject(idsegmanusu)
                    _db.SaveChanges()
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function


        <HttpGet()> _
        <HttpPost()> _
        Public Function selsegmanusuxnombreusuario(xnombreusuario As String) As segmanusu
            Dim segmanusu As segmanusu = (From p In _db.segmanusu
                                          Where p.xnombreusuario = xnombreusuario
                                          Select p).SingleOrDefault
            Return segmanusu
        End Function

        <HttpPost()> _
        Public Function selsegmanusuidsegmanorg(idsegmanusu As String) As Decimal
            Dim idsegmanorg1 As Decimal = (From p In _db.segmanusu
                                          Where p.idsegmanusu = idsegmanusu
                                          Select p.idsegmanorg).SingleOrDefault
            Return idsegmanorg1
        End Function

        <HttpPost()> _
        Public Function existeporidsegmanusu(idsegmanusu As String) As Boolean
            Dim existe As Boolean = (From p In _db.segmanusu
                                          Where p.idsegmanusu = idsegmanusu
                                          Select p).Any
            Return existe
        End Function
    End Class
End Namespace

