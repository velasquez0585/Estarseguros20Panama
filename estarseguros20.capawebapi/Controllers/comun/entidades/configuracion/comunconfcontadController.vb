Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion

Namespace comun.entidades.controlador
Public Class comunconfcontadController
	Inherits ApiController

	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selcomunconfcontadxid(idcomunconfcontad As Decimal) As comunconfcontad
            Dim comunconfcontad As comunconfcontad = (From p In _db.comunconfcontad
                                            Where p.idcomunconfcontad = idcomunconfcontad
                                            Select p).SingleOrDefault
            Return comunconfcontad
        End Function

        <HttpGet()> _
        Public Function selcomunconfcontad() As List(Of comunconfcontad)
            Dim lista_comunconfcontad As List(Of comunconfcontad) = (From p In _db.comunconfcontad
                                                        Select p).ToList
            '
            Return lista_comunconfcontad
        End Function

        <HttpPost()> _
        Public Function inscomunconfcontad(idcomunconfcontad As Decimal, idcomunmanpais As Decimal, xnombrecontad As String, nsecuencia As Decimal, nincremento As Int32, ninicio As Decimal, istatuscontad As String) As Boolean
            Try
                Dim comunconfcontad As New comunconfcontad
                comunconfcontad.idcomunconfcontad = selcomunconfcontad.Count + 1
                comunconfcontad.idcomunmanpais = idcomunmanpais
                comunconfcontad.xnombrecontad = xnombrecontad
                comunconfcontad.nsecuencia = nsecuencia
                comunconfcontad.nincremento = nincremento
                comunconfcontad.ninicio = ninicio
                comunconfcontad.istatuscontad = istatuscontad
                comunconfcontad.idseglogreg = 0
                _db.AddObject("comunconfcontad", comunconfcontad)
                _db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpPut()> _
        Public Function modcomunconfcontad(idcomunconfcontad As Decimal, idcomunmanpais As Decimal, xnombrecontad As String, nsecuencia As Decimal, nincremento As Int32, ninicio As Decimal, istatuscontad As String, idseglogreg As Decimal) As Boolean
            Try
                Dim comunconfcontad As comunconfcontad = selcomunconfcontadxid(idcomunconfcontad)
                If comunconfcontad IsNot Nothing Then
                    comunconfcontad.idcomunmanpais = idcomunmanpais
                    comunconfcontad.xnombrecontad = xnombrecontad
                    comunconfcontad.nsecuencia = nsecuencia
                    comunconfcontad.nincremento = nincremento
                    comunconfcontad.ninicio = ninicio
                    comunconfcontad.istatuscontad = istatuscontad
                    comunconfcontad.idseglogreg = idseglogreg
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
        Public Function elicomunconfcontad(idcomunconfcontad As Decimal) As Boolean
            Try
                Dim comunconfcontad As comunconfcontad = selcomunconfcontadxid(idcomunconfcontad)
                If comunconfcontad IsNot Nothing Then
                    _db.DeleteObject(idcomunconfcontad)
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

End Class
End Namespace
