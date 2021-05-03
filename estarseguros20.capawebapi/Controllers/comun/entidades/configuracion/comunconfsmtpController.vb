Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion

Namespace comun.entidades.controlador
Public Class comunconfsmtpController
	Inherits ApiController

	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selcomunconfsmtpxid(idcomunconfsmtp As Decimal) As comunconfsmtp
            Dim comunconfsmtp As comunconfsmtp = (From p In _db.comunconfsmtp
                                            Where p.idcomunconfsmtp = idcomunconfsmtp
                                            Select p).SingleOrDefault
            Return comunconfsmtp
        End Function

        <HttpGet()> _
        Public Function selcomunconfsmtp() As List(Of comunconfsmtp)
            Dim lista_comunconfsmtp As List(Of comunconfsmtp) = (From p In _db.comunconfsmtp
                                                        Select p).ToList
            '
            Return lista_comunconfsmtp
        End Function

        <HttpPost()> _
        Public Function inscomunconfsmtp(idcomunconfsmtp As Decimal, xhost As String, npuerto As Int64, xcuenta As String, xcontrasena As String, issl As Boolean, xdescripsmtp As String) As Boolean
            Try
                Dim comunconfsmtp As New comunconfsmtp
                comunconfsmtp.idcomunconfsmtp = selcomunconfsmtp.Count + 1
                comunconfsmtp.xhost = xhost
                comunconfsmtp.npuerto = npuerto
                comunconfsmtp.xcuenta = xcuenta
                comunconfsmtp.xcontrasena = xcontrasena
                comunconfsmtp.issl = issl
                comunconfsmtp.xdescripsmtp = xdescripsmtp
                comunconfsmtp.idseglogreg = 0
                _db.AddObject("comunconfsmtp", comunconfsmtp)
                _db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpPut()> _
        Public Function modcomunconfsmtp(idcomunconfsmtp As Decimal, xhost As String, npuerto As Int64, xcuenta As String, xcontrasena As String, issl As Boolean, xdescripsmtp As String, idseglogreg As Decimal) As Boolean
            Try
                Dim comunconfsmtp As comunconfsmtp = selcomunconfsmtpxid(idcomunconfsmtp)
                If comunconfsmtp IsNot Nothing Then
                    comunconfsmtp.xhost = xhost
                    comunconfsmtp.npuerto = npuerto
                    comunconfsmtp.xcuenta = xcuenta
                    comunconfsmtp.xcontrasena = xcontrasena
                    comunconfsmtp.issl = issl
                    comunconfsmtp.xdescripsmtp = xdescripsmtp
                    comunconfsmtp.idseglogreg = idseglogreg
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
        Public Function elicomunconfsmtp(idcomunconfsmtp As Decimal) As Boolean
            Try
                Dim comunconfsmtp As comunconfsmtp = selcomunconfsmtpxid(idcomunconfsmtp)
                If comunconfsmtp IsNot Nothing Then
                    _db.DeleteObject(idcomunconfsmtp)
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
