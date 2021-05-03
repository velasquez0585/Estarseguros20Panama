Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento

Namespace comun.entidades.controlador
Public Class comunmanlocalidController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))
        <HttpGet()> _
        Public Function selcomunmanlocalidxid(idcomunmanlocalid As Decimal) As comunmanlocalid
            Dim comunmanlocalid As comunmanlocalid = (From p In _db.comunmanlocalid
                                            Where p.idcomunmanlocalid = idcomunmanlocalid
                                            Select p).SingleOrDefault
            Return comunmanlocalid
        End Function

        <HttpGet()> _
        Public Function selcomunmanlocalid() As List(Of comunmanlocalid)
            Dim lista_comunmanlocalid As List(Of comunmanlocalid) = (From p In _db.comunmanlocalid
                                                        Select p).ToList
            '
            Return lista_comunmanlocalid
        End Function

        <HttpPost()> _
        Public Function selcomunmanlocalidxidestado(idcomunmanestado As Decimal) As List(Of comunmanlocalid)
            Dim lista_comunmanlocalid As List(Of comunmanlocalid) = (From p In _db.comunmanlocalid
                                                        Where p.idcomunmanestado = idcomunmanestado
                                                        Order By p.xnombrelocalid Ascending
                                                        Select p).ToList
            'agregar el item vacio para seleccion
            Dim comunmanlocalid As New comunmanlocalid
            With comunmanlocalid
                .idcomunmancont = 0
                .xnombrelocalid = "SELECCIONE"
            End With
            lista_comunmanlocalid.Insert(0, comunmanlocalid)
            Return lista_comunmanlocalid
        End Function

        <HttpPost()> _
        Public Function inscomunmanlocalid(idcomunmanlocalid As Decimal, idcomunmanestado As Decimal, idcomunmanpais As Decimal, idcomunmancont As Decimal, xnombrelocalid As String, xlatitud As String, xlongitud As String) As Boolean
            Try
                Dim comunmanlocalid As New comunmanlocalid
                comunmanlocalid.idcomunmanlocalid = selcomunmanlocalid.Count + 1
                comunmanlocalid.idcomunmanestado = idcomunmanestado
                comunmanlocalid.idcomunmanpais = idcomunmanpais
                comunmanlocalid.idcomunmancont = idcomunmancont
                comunmanlocalid.xnombrelocalid = xnombrelocalid
                comunmanlocalid.xlatitud = xlatitud
                comunmanlocalid.xlongitud = xlongitud
                comunmanlocalid.idseglogreg = 0
                _db.AddObject("comunmanlocalid", comunmanlocalid)
                _db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpPut()> _
        Public Function modcomunmanlocalid(idcomunmanlocalid As Decimal, idcomunmanestado As Decimal, idcomunmanpais As Decimal, idcomunmancont As Decimal, xnombrelocalid As String, xlatitud As String, xlongitud As String, idseglogreg As Decimal) As Boolean
            Try
                Dim comunmanlocalid As comunmanlocalid = selcomunmanlocalidxid(idcomunmanlocalid)
                If comunmanlocalid IsNot Nothing Then
                    comunmanlocalid.idcomunmanestado = idcomunmanestado
                    comunmanlocalid.idcomunmanpais = idcomunmanpais
                    comunmanlocalid.idcomunmancont = idcomunmancont
                    comunmanlocalid.xnombrelocalid = xnombrelocalid
                    comunmanlocalid.xlatitud = xlatitud
                    comunmanlocalid.xlongitud = xlongitud
                    comunmanlocalid.idseglogreg = idseglogreg
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
        Public Function elicomunmanlocalid(idcomunmanlocalid As Decimal) As Boolean
            Try
                Dim comunmanlocalid As comunmanlocalid = selcomunmanlocalidxid(idcomunmanlocalid)
                If comunmanlocalid IsNot Nothing Then
                    _db.DeleteObject(idcomunmanlocalid)
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
        Public Function selcomunmanlocalidxestado(idcomunmanestado As Decimal) As List(Of comunmanlocalid)
            Dim lista_comunmanlocalid As List(Of comunmanlocalid) = (From p In _db.comunmanlocalid
                                                                     Where p.idcomunmanestado = idcomunmanestado Order By p.xnombrelocalid
                                                        Select p).ToList
            '
            Return lista_comunmanlocalid
        End Function
End Class
End Namespace
