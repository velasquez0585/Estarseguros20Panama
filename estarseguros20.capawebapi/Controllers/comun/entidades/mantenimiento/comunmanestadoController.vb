Imports System.Net

Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento

Namespace comun.entidades.controlador
Public Class comunmanestadoController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpGet()> _
        Public Function selcomunmanestadoxid(idcomunmanestado As Decimal) As comunmanestado
            Dim comunmanestado As comunmanestado = (From p In _db.comunmanestado
                                            Where p.idcomunmanestado = idcomunmanestado
                                            Select p).SingleOrDefault
            Return comunmanestado
        End Function

        <HttpGet()> _
        Public Function selcomunmanestado() As List(Of comunmanestado)
            Dim lista_comunmanestado As List(Of comunmanestado) = (From p In _db.comunmanestado
                                                        Select p).ToList
            '
            Return lista_comunmanestado
        End Function

        <HttpPost()> _
        Public Function selcomunmanestadoxidpais(idcomunmanpais As Decimal) As List(Of comunmanestado)
            Dim lista_comunmanestado As List(Of comunmanestado) = (From p In _db.comunmanestado
                                                        Where p.idcomunmanpais = idcomunmanpais
                                                        Order By p.xnombreestado Ascending
                                                        Select p).ToList
            'agregar el item vacio para seleccion
            Dim comunmanestado As New comunmanestado
            With comunmanestado
                .idcomunmancont = 0
                .xnombreestado = "SELECCIONE"
            End With
            lista_comunmanestado.Insert(0, comunmanestado)
            Return lista_comunmanestado
        End Function

        <HttpPost()> _
        Public Function inscomunmanestado(idcomunmanestado As Decimal, idcomunmanpais As Decimal, idcomunmancont As Decimal, xnombreestado As String, xlatitud As String, xlongitud As String) As Boolean
            Try
                Dim comunmanestado As New comunmanestado
                comunmanestado.idcomunmanestado = selcomunmanestado.Count + 1
                comunmanestado.idcomunmanpais = idcomunmanpais
                comunmanestado.idcomunmancont = idcomunmancont
                comunmanestado.xnombreestado = xnombreestado
                comunmanestado.xlatitud = xlatitud
                comunmanestado.xlongitud = xlongitud
                comunmanestado.idseglogreg = 0
                _db.AddObject("comunmanestado", comunmanestado)
                _db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpPut()> _
        Public Function modcomunmanestado(idcomunmanestado As Decimal, idcomunmanpais As Decimal, idcomunmancont As Decimal, xnombreestado As String, xlatitud As String, xlongitud As String, idseglogreg As Decimal) As Boolean
            Try
                Dim comunmanestado As comunmanestado = selcomunmanestadoxid(idcomunmanestado)
                If comunmanestado IsNot Nothing Then
                    comunmanestado.idcomunmanpais = idcomunmanpais
                    comunmanestado.idcomunmancont = idcomunmancont
                    comunmanestado.xnombreestado = xnombreestado
                    comunmanestado.xlatitud = xlatitud
                    comunmanestado.xlongitud = xlongitud
                    comunmanestado.idseglogreg = idseglogreg
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
        Public Function elicomunmanestado(idcomunmanestado As Decimal) As Boolean
            Try
                Dim comunmanestado As comunmanestado = selcomunmanestadoxid(idcomunmanestado)
                If comunmanestado IsNot Nothing Then
                    _db.DeleteObject(idcomunmanestado)
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

        'funciones no basicas
        <HttpPost()> _
        Public Function selcomunmanestadoxpais(idcomunmanpais As Decimal) As List(Of comunmanestado)
            Dim lista_comunmanestado As List(Of comunmanestado) = (From p In _db.comunmanestado
                                            Where p.idcomunmanpais = idcomunmanpais Order By p.xnombreestado
                                            Select p).ToList

            Dim comunmanestado As New comunmanestado
            comunmanestado.idcomunmanestado = 0
            comunmanestado.xnombreestado = "SELECCIONE..."
            comunmanestado.idcomunmanpais = idcomunmanpais
            lista_comunmanestado.Insert(0, comunmanestado)

            Return lista_comunmanestado
        End Function


End Class
End Namespace
