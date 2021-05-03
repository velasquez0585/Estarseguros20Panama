Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento

Namespace comun.entidades.controlador
Public Class comunmancontController
	Inherits ApiController

	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))

        <HttpGet()> _
        Public Function selcomunmancontxid(idcomunmancont As Decimal) As comunmancont
            Dim comunmancont As comunmancont = (From p In _db.comunmancont
                                            Where p.idcomunmancont = idcomunmancont
                                            Select p).SingleOrDefault
            Return comunmancont
        End Function

        '<HttpGet()> _
        'Public Function selcomunmancont() As List(Of comunmancont)
        '    Dim lista_comunmancont As List(Of comunmancont) = (From p In _db.comunmancont
        '                                                Select p).ToList
        '    '
        '    Return lista_comunmancont
        'End Function

        <HttpPost()> _
        Public Function selcomunmancont() As List(Of comunmancont)
            Dim lista_comunmancont As List(Of comunmancont) = (From p In _db.comunmancont
                                                        Select p).ToList

            'agregar el item vacio para seleccion
            Dim comunmancont As New comunmancont
            With comunmancont
                .idcomunmancont = 0
                .xnombrecont = "SELECCIONE"
            End With

            lista_comunmancont.Insert(0, comunmancont)
            '
            Return lista_comunmancont
        End Function

        <HttpPost()> _
        Public Function inscomunmancont(idcomunmancont As Decimal, xnombrecont As String, xlatitud As String, xlongitud As String) As Boolean
            Try
                Dim comunmancont As New comunmancont
                comunmancont.idcomunmancont = selcomunmancont.Count + 1
                comunmancont.xnombrecont = xnombrecont
                comunmancont.xlatitud = xlatitud
                comunmancont.xlongitud = xlongitud
                comunmancont.idseglogreg = 0
                _db.AddObject("comunmancont", comunmancont)
                _db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpPut()> _
        Public Function modcomunmancont(idcomunmancont As Decimal, xnombrecont As String, xlatitud As String, xlongitud As String, idseglogreg As Decimal) As Boolean
            Try
                Dim comunmancont As comunmancont = selcomunmancontxid(idcomunmancont)
                If comunmancont IsNot Nothing Then
                    comunmancont.xnombrecont = xnombrecont
                    comunmancont.xlatitud = xlatitud
                    comunmancont.xlongitud = xlongitud
                    comunmancont.idseglogreg = idseglogreg
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
        Public Function elicomunmancont(idcomunmancont As Decimal) As Boolean
            Try
                Dim comunmancont As comunmancont = selcomunmancontxid(idcomunmancont)
                If comunmancont IsNot Nothing Then
                    _db.DeleteObject(idcomunmancont)
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
