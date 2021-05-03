Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.mantenimiento

Namespace comun.entidades.controlador
    Public Class comunmanpaisController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpGet()> _
        Public Function selcomunmanpaisxid(idcomunmanpais As Decimal) As comunmanpais
            Dim comunmanpais As comunmanpais = (From p In _db.comunmanpais
                                            Where p.idcomunmanpais = idcomunmanpais
                                            Select p).SingleOrDefault
            Return comunmanpais
        End Function

        <HttpGet()> _
        Public Function selcomunmanpais() As List(Of comunmanpais)
            Dim lista_comunmanpais As List(Of comunmanpais) = (From p In _db.comunmanpais
                                                        Select p).ToList
            '
            Return lista_comunmanpais
        End Function


        <HttpPost()> _
        Public Function selcomunmanpaisxidcont(idcomunmancont As Decimal) As List(Of comunmanpais)
            Dim lista_comunmanpais As List(Of comunmanpais) = (From p In _db.comunmanpais
                                                        Where p.idcomunmancont = idcomunmancont
                                                        Select p).ToList
            'agregar el item vacio para seleccion
            Dim comunmanpais As New comunmanpais
            With comunmanpais
                .idcomunmancont = 0
                .xnombrepais = "SELECCIONE"
            End With
            lista_comunmanpais.Insert(0, comunmanpais)
            Return lista_comunmanpais
        End Function


        <HttpPost()> _
        Public Function inscomunmanpais(idcomunmanpais As Decimal, idcomunmancont As Decimal, xnombrepais As String, xlenguajeabrev As String, xlenguaje As String, xnombrepaisabrev As String, xcultura As String, xlatitud As String, xlongitud As String) As Boolean
            Try
                Dim comunmanpais As New comunmanpais
                comunmanpais.idcomunmanpais = selcomunmanpais.Count + 1
                comunmanpais.idcomunmancont = idcomunmancont
                comunmanpais.xnombrepais = xnombrepais
                comunmanpais.xlenguajeabrev = xlenguajeabrev
                comunmanpais.xlenguaje = xlenguaje
                comunmanpais.xnombrepaisabrev = xnombrepaisabrev
                comunmanpais.xcultura = xcultura
                comunmanpais.xlatitud = xlatitud
                comunmanpais.xlongitud = xlongitud
                comunmanpais.idseglogreg = 0
                _db.AddObject("comunmanpais", comunmanpais)
                _db.SaveChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
            Return False
        End Function

        <HttpPut()> _
        Public Function modcomunmanpais(idcomunmanpais As Decimal, idcomunmancont As Decimal, xnombrepais As String, xlenguajeabrev As String, xlenguaje As String, xnombrepaisabrev As String, xcultura As String, xlatitud As String, xlongitud As String, idseglogreg As Decimal) As Boolean
            Try
                Dim comunmanpais As comunmanpais = selcomunmanpaisxid(idcomunmanpais)
                If comunmanpais IsNot Nothing Then
                    comunmanpais.idcomunmancont = idcomunmancont
                    comunmanpais.xnombrepais = xnombrepais
                    comunmanpais.xlenguajeabrev = xlenguajeabrev
                    comunmanpais.xlenguaje = xlenguaje
                    comunmanpais.xnombrepaisabrev = xnombrepaisabrev
                    comunmanpais.xcultura = xcultura
                    comunmanpais.xlatitud = xlatitud
                    comunmanpais.xlongitud = xlongitud
                    comunmanpais.idseglogreg = idseglogreg
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
        Public Function elicomunmanpais(idcomunmanpais As Decimal) As Boolean
            Try
                Dim comunmanpais As comunmanpais = selcomunmanpaisxid(idcomunmanpais)
                If comunmanpais IsNot Nothing Then
                    _db.DeleteObject(idcomunmanpais)
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
