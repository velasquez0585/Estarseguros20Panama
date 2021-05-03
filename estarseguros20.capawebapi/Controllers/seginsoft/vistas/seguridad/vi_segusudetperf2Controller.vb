Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica
Imports estarseguros20.capawebapi.comun.entidades.controlador
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports estarseguros20.capawebapi.aipauto.modulos.controlador
Namespace seginsoft.vistas.controlador
    Public Class vi_segusudetperf2Controller
        Inherits ApiController

        'Dim _db As New dbairplanet.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_segusudetperf2xid(idsegmanapp As Decimal, idsegmanusu As Decimal) As vi_segusudetperf2
            Dim vi_segusudetperf2 As vi_segusudetperf2 = (From p In _db.vi_segusudetperf2
                                            Where p.idsegmanapp = idsegmanapp And p.idsegmanusu = idsegmanusu
                                            Select p).SingleOrDefault
            Return vi_segusudetperf2
        End Function


        <HttpPost()> _
        Public Function selvi_segusudetperf2() As List(Of vi_segusudetperf2)
            Dim lista_vi_segusudetperf2 As List(Of vi_segusudetperf2) = (From p In _db.vi_segusudetperf2
                                                        Select p).ToList
            '
            Return lista_vi_segusudetperf2
        End Function

        <HttpPost()> _
        Public Function selvi_segusudetperf2xwheredinamicopag(petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As respvi_segusudetperf2paglist
            Dim sb As New StringBuilder("")
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanpers=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanpers=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorg=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorg=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmandep=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmandep=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmancarg=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmancarg=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreusuario='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreusuario='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegusuperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegusuperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegappperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegappperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xabrevperf='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xabrevperf='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreperf='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreperf='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nnivelperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nnivelperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombredep='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombredep='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecarg='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecarg='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecorto='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecorto='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrelargo='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrelargo='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedula='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedula='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompleto='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompleto='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto)
                        sb.Append("'")
                    End If
                End If
            End If
            '


            Dim respvi_segusudetperf2paglist As New respvi_segusudetperf2paglist
            respvi_segusudetperf2paglist.pagvi_segusudetperf2 = petivi_segusudetperf2paglist.pagvi_segusudetperf2
            Dim skip = skip_paginacion(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual, petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)

            If sb.ToString = "" Then
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            Else
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            End If
            '
            If (respvi_segusudetperf2paglist.lista_vi_segusudetperf2.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_segusudetperf2xwheredinamicocount(sb)
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)
            Else
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = 0
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual = 0
            End If

            Return respvi_segusudetperf2paglist
        End Function

        Public Function selvi_segusudetperf2xwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.vi_segusudetperf2.Count
            Else
                Return _db.vi_segusudetperf2.Where(sb.ToString).Count
            End If
        End Function


        'Metodos no automaticos
        <HttpPost()> _
        Public Function selvi_segusudetperf2xwheredinamicopag2(petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As respvi_segusudetperf2paglist

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim sb As New StringBuilder("")
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanpers=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanpers=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmandep=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmandep=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmancarg=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmancarg=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreusuario='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreusuario='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegusuperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegusuperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegappperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegappperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf = 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xabrevperf='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xabrevperf='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreperf='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreperf='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nnivelperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nnivelperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombredep='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombredep='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecarg='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecarg='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecorto='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecorto='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrelargo='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrelargo='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedula='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedula='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompleto='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompleto='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto)
                        sb.Append("'")
                    End If
                End If
            End If
            '


            Dim respvi_segusudetperf2paglist As New respvi_segusudetperf2paglist
            respvi_segusudetperf2paglist.pagvi_segusudetperf2 = petivi_segusudetperf2paglist.pagvi_segusudetperf2
            Dim skip = skip_paginacion(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual, petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)

            If sb.ToString = "" Then
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            Else
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            End If
            '
            If (respvi_segusudetperf2paglist.lista_vi_segusudetperf2.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_segusudetperf2xwheredinamicocount(sb)
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)
            Else
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = 0
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual = 0
            End If

            Return respvi_segusudetperf2paglist
        End Function

        'metodos no genericos

        <HttpPost()> _
        Public Function selvi_segusudetperf2xwheredinamicopag_MenosPeritos(petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As respvi_segusudetperf2paglist

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim sb As New StringBuilder("")

            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanpers=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanpers=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idcomunmanpers))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmandep=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmandep=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmandep))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmancarg=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmancarg=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmancarg))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreusuario='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreusuario='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                        sb.Append("'")
                    End If
                End If
            End If


            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegusuperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegusuperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegusuperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegappperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegappperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegappperf))
                        sb.Append("")
                    End If
                End If
            End If
            '




            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                        sb.Append("")
                    End If
                End If
            End If

            ''se coloca esta asignacion para buscar todos los usuarios menos los peritos
            If sb.Length = 0 Then
                sb.Append("(it.idsegmanperf <>")
                sb.Append(valor_entero(peritoint))
                sb.Append(" or it.idsegmanperf <>")
                sb.Append(valor_entero(peritoext))
                sb.Append(")")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and (it.idsegmanperf <>")
                    sb.Append(valor_entero(peritoint))
                    sb.Append(" or it.idsegmanperf <>")
                    sb.Append(valor_entero(peritoext))
                    sb.Append(")")
                End If
            End If


            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf = 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xabrevperf='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xabrevperf='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xabrevperf)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreperf='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreperf='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreperf)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nnivelperf=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nnivelperf=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.nnivelperf))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombredep='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombredep='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombredep)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecarg='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecarg='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecarg)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecorto='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecorto='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecorto)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrelargo='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrelargo='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrelargo)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcedula='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcedula='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xcedula)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompleto='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompleto='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombrecompleto)
                        sb.Append("'")
                    End If
                End If
            End If
            '


            Dim respvi_segusudetperf2paglist As New respvi_segusudetperf2paglist
            respvi_segusudetperf2paglist.pagvi_segusudetperf2 = petivi_segusudetperf2paglist.pagvi_segusudetperf2
            Dim skip = skip_paginacion(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual, petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)

            If sb.ToString = "" Then
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            Else
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            End If
            '
            If (respvi_segusudetperf2paglist.lista_vi_segusudetperf2.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_segusudetperf2xwheredinamicocount(sb)
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)
            Else
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = 0
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual = 0
            End If

            Return respvi_segusudetperf2paglist
        End Function


        <HttpPost()> _
        Public Function selvi_segusudetperf2poridsegmanusu(idsegmanusu As Decimal) As vi_segusudetperf2
            Return (From p In _db.vi_segusudetperf2
                                                        Where p.idsegmanusu = idsegmanusu And p.idsegmanapp = 2
                                                        Select p).SingleOrDefault()

        End Function


        'metodo para obtener todos los usuario con el Perfil Perito Externo = 6
        <HttpPost()> _
        Public Function selvi_segusudetperf2combo() As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")



            Dim lista_vi_segusudetperf2 As List(Of vi_segusudetperf2) = (From p In _db.vi_segusudetperf2
                                                        Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = peritoext Or p.idsegmanperf = peritols) And p.ibloqueado = False
                                                        Select p).ToList

            'agregar el item vacio para seleccion
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            With vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function


        'metodo para obtener todos los usuario con el Perfil Perito Externo = 6 y organizacion enviada por parametro
        <HttpPost()> _
        Public Function selvi_segusudetperf2comboPorOrg(idsegmanorg As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim lista_vi_segusudetperf2 As List(Of vi_segusudetperf2) = (From p In _db.vi_segusudetperf2
                                                        Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = peritoext Or p.idsegmanperf = peritols) And p.idsegmanorg = idsegmanorg And p.ibloqueado = False
                                                        Select p).ToList

            'agregar el item vacio para seleccion
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            With vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function

        'metodo para obtener todos los usuario con el Perfil Perito Externo = 6 o perito interno = 5 y organizacion and siempre el perito lider = 7 enviada por parametro
        <HttpPost()> _
        Public Function selvi_segusudetperf3comboPorOrg(idsegmanorg As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim lista_vi_segusudetperf2 As List(Of vi_segusudetperf2) = (From p In _db.vi_segusudetperf2
                                                        Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = peritoext Or p.idsegmanperf = peritoint Or p.idsegmanperf = peritols) And p.idsegmanorg = idsegmanorg And p.ibloqueado = False
                                                        Select p).ToList

            'agregar el item vacio para seleccion
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            With vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function

        'metodo para obtener todos los usuario con el Perfil enviado, organizacion enviada por parametro e igual al usuario en sesion
        <HttpPost()> _
        Public Function selvi_segusudetperf2comboPorOrgYUsu(idsegmanorg As Decimal, idsegmanperf As Decimal, idsegmanusu As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim lista_vi_segusudetperf2 As List(Of vi_segusudetperf2) = (From p In _db.vi_segusudetperf2
                                                        Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = idsegmanperf Or p.idsegmanperf = peritols And p.idsegmanusu = idsegmanusu) And p.idsegmanorg = idsegmanorg And p.ibloqueado = False
                                                        Select p).ToList

            Return lista_vi_segusudetperf2
        End Function

        'metodo para obtener todos los usuario con el Perfil enviado, organizacion enviada por parametro y disferente al usuario en sesion
        <HttpPost()> _
        Public Function selvi_segusudetperf2comboPorOrgDifUsu(idsegmanorg As Decimal, idsegmanperf As Decimal, idsegmanusu As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim lista_vi_segusudetperf2 As List(Of vi_segusudetperf2) = (From p In _db.vi_segusudetperf2
                                                        Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = idsegmanperf) And p.idsegmanorg = idsegmanorg And p.ibloqueado = False
                                                        Select p).ToList


            Return lista_vi_segusudetperf2
        End Function

        'metodo para obtener todos los usuario con el Perfil enviado, perito lider y organizacion enviada por parametro 
        <HttpPost()> _
        Public Function selvi_segusudetperf2comboPorOrgYPerfiles(idsegmanorg As Decimal, idsegmanperf As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim lista_vi_segusudetperf2 As List(Of vi_segusudetperf2) = (From p In _db.vi_segusudetperf2
                                                        Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = idsegmanperf Or p.idsegmanperf = peritols) And p.idsegmanorg = idsegmanorg And p.ibloqueado = False
                                                        Select p).ToList

            Return lista_vi_segusudetperf2
        End Function


        <HttpPost()> _
        Public Function selvi_segusudetperf2PorNombreUsuario(xnombreusuario As String) As vi_segusudetperf2
            Dim vi_segusudetperf2 As vi_segusudetperf2 = (From p In _db.vi_segusudetperf2
                                                        Where p.xnombreusuario = xnombreusuario
                                                        Select p).SingleOrDefault()

            Return vi_segusudetperf2
        End Function

        <HttpPost()> _
        Public Function selvi_segusudetperf2xwheredinamicopagYTipoUsuario(itipoaccion As String, petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As respvi_segusudetperf2paglist
            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim sb As New StringBuilder("")

            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorg=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorg=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreusuario='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreusuario='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                        sb.Append("'")
                    End If
                End If
            End If

            If (itipoaccion = "AUDITOR") Then

                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(auditor)
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(auditor)
                        sb.Append("")
                    End If
                End If

            ElseIf (itipoaccion = "PERITO") Then
                If sb.Length = 0 Then
                    sb.Append("(it.idsegmanperf=")
                    sb.Append(peritoint)
                    sb.Append(" or it.idsegmanperf=")
                    sb.Append(peritoext)
                    sb.Append(")")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and (it.idsegmanperf=")
                        sb.Append(peritoint)
                        sb.Append(" or it.idsegmanperf=")
                        sb.Append(peritoext)
                        sb.Append(")")
                    End If
                End If
            End If



            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If
            '


            'If sb.Length = 0 Then
            '    sb.Append("it.ibloqueado=")
            '    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.ibloqueado)
            '    sb.Append("")
            'Else
            '    If sb.Length > 0 Then
            '        sb.Append(" and it.ibloqueado=")
            '        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.ibloqueado)
            '        sb.Append("")
            '    End If
            'End If


            Dim respvi_segusudetperf2paglist As New respvi_segusudetperf2paglist
            respvi_segusudetperf2paglist.pagvi_segusudetperf2 = petivi_segusudetperf2paglist.pagvi_segusudetperf2
            Dim skip = skip_paginacion(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual, petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)

            If sb.ToString = "" Then
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            Else
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            End If
            '
            If (respvi_segusudetperf2paglist.lista_vi_segusudetperf2.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_segusudetperf2xwheredinamicocount(sb)
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)
            Else
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = 0
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual = 0
            End If

            Return respvi_segusudetperf2paglist
        End Function

        <HttpPost()> _
        Public Function selvi_segusudetperf2xwheredinamicopagYTipoUsuarioMenosBloq(itipoaccion As String, petivi_segusudetperf2paglist As petivi_segusudetperf2paglist) As respvi_segusudetperf2paglist

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim sb As New StringBuilder("")

            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanusu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorg=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorg=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanorg))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombreusuario='")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombreusuario='")
                        sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.xnombreusuario)
                        sb.Append("'")
                    End If
                End If
            End If

            If (itipoaccion = "AUDITOR") Then

                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(auditor)
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(auditor)
                        sb.Append("")
                    End If
                End If

            ElseIf (itipoaccion = "PERITO") Then
                If sb.Length = 0 Then
                    sb.Append("(it.idsegmanperf=")
                    sb.Append(peritoint)
                    sb.Append(" or it.idsegmanperf=")
                    sb.Append(peritoext)
                    sb.Append(")")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and (it.idsegmanperf=")
                        sb.Append(peritoint)
                        sb.Append(" or it.idsegmanperf=")
                        sb.Append(peritoext)
                        sb.Append(")")
                    End If
                End If
            End If



            If petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(petivi_segusudetperf2paglist.vi_segusudetperf2.idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If
            '


            If sb.Length = 0 Then
                sb.Append("it.ibloqueado=")
                sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.ibloqueado)
                sb.Append("")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.ibloqueado=")
                    sb.Append(petivi_segusudetperf2paglist.vi_segusudetperf2.ibloqueado)
                    sb.Append("")
                End If
            End If


            Dim respvi_segusudetperf2paglist As New respvi_segusudetperf2paglist
            respvi_segusudetperf2paglist.pagvi_segusudetperf2 = petivi_segusudetperf2paglist.pagvi_segusudetperf2
            Dim skip = skip_paginacion(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual, petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)

            If sb.ToString = "" Then
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            Else
                respvi_segusudetperf2paglist.lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).OrderBy(petivi_segusudetperf2paglist.pagvi_segusudetperf2.xcamposord & " " & petivi_segusudetperf2paglist.pagvi_segusudetperf2.idirord).Skip(skip).Take(petivi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano).ToList
            End If
            '
            If (respvi_segusudetperf2paglist.lista_vi_segusudetperf2.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_segusudetperf2xwheredinamicocount(sb)
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagtamano)
            Else
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagcantidad = 0
                respvi_segusudetperf2paglist.pagvi_segusudetperf2.npagactual = 0
            End If

            Return respvi_segusudetperf2paglist
        End Function

        'metodo para obtener todos los usuario segun el tipo de accion PERITO o AUDITOR
        <HttpPost()> _
        Public Function ObtenerComboPorAccionYTipoUsuario(itipoaccion As String, idsegmanusu As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim sb As New StringBuilder("")
            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim vi_segusudetperf2 As New vi_segusudetperf2
            vi_segusudetperf2 = selvi_segusudetperf2poridsegmanusu(idsegmanusu)
            Dim lista_vi_segusudetperf2 As New List(Of vi_segusudetperf2)

            If idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If

            If (vi_segusudetperf2 IsNot Nothing) Then

                If (itipoaccion = "AUDITOR") Then

                    If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                        'si es auditor lider principal se buscan los auditores lider suc y auditores
                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(auditorls)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(auditor)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(auditorls)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(auditor)
                                sb.Append(") ")
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                        'si es auditor lider Suc se buscan los auditores
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanperf=")
                            sb.Append(auditor)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanperf=")
                                sb.Append(auditor)
                                sb.Append("")
                            End If
                        End If

                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If

                    End If

                    lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).ToList

                ElseIf (itipoaccion = "PERITO") Then

                    If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                        'si es auditor lider principal se buscan los perito lider suc y peritos ext e int

                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(peritols)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoext)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoint)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                        'si es auditor lider principal se buscan los peritos lid suc y peritos ext e int de su suc

                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(peritols)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoext)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoint)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            End If
                        End If

                        ''se buscan por organizacion ya que es lider sucursal
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = peritols) Then
                        'si es Perito lider Suc se buscan los peritos externos e internos
                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(peritoext)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoint)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            End If
                        End If

                        ''se buscan por organizacion ya que es lider sucursal
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If
                    End If

                    If sb.Length = 0 Then
                        sb.Append("it.ibloqueado=")
                        sb.Append(False)
                        sb.Append("")
                    Else
                        If sb.Length > 0 Then
                            sb.Append(" and it.ibloqueado=")
                            sb.Append(False)
                            sb.Append("")
                        End If
                    End If

                    lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).ToList
                End If
            End If







            'If (itipoaccion = "AUDITOR") Then

            '    lista_vi_segusudetperf2 = (From p In _db.vi_segusudetperf2
            '            Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = auditorlp Or p.idsegmanperf = auditorls Or p.idsegmanperf = auditor)
            '                                            Select p).ToList

            'ElseIf (itipoaccion = "PERITO") Then
            '    lista_vi_segusudetperf2 = (From p In _db.vi_segusudetperf2
            '        Where p.idsegmanapp = idsegmanapp And (p.idsegmanperf = peritols Or p.idsegmanperf = peritoext Or p.idsegmanperf = peritoint)
            '                                            Select p).ToList
            'End If



            'agregar el item vacio para seleccion
            Dim _vi_segusudetperf2 As New vi_segusudetperf2
            With _vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, _vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function


        <HttpPost()> _
        Public Function ObtenerComboPorAccionOrgYTipoUsuario(idsegmanorg As Decimal, itipoaccion As String, idsegmanusu As Decimal) As List(Of vi_segusudetperf2)
            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim sb As New StringBuilder("")
            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim vi_segusudetperf2 As New vi_segusudetperf2
            vi_segusudetperf2 = selvi_segusudetperf2poridsegmanusu(idsegmanusu)

            If (vi_segusudetperf2 IsNot Nothing) Then

                If (itipoaccion = "AUDITOR") Then

                    If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                        'si es auditor lider principal se buscan los auditores lider suc y auditores
                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(auditorls)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(auditor)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(auditorls)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(auditor)
                                sb.Append(") ")
                            End If
                        End If

                        If (idsegmanorg > 0) Then
                            If sb.Length = 0 Then
                                sb.Append("it.idsegmanorg=")
                                sb.Append(idsegmanorg)
                                sb.Append("")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and it.idsegmanorg=")
                                    sb.Append(idsegmanorg)
                                    sb.Append("")
                                End If
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                        'si es auditor lider Suc se buscan los auditores
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanperf=")
                            sb.Append(auditor)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanperf=")
                                sb.Append(auditor)
                                sb.Append("")
                            End If
                        End If

                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If

                    End If


                ElseIf (itipoaccion = "PERITO") Then

                    If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                        'si es auditor lider principal se buscan los perito lider suc y peritos ext e int

                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(peritols)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoext)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoint)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            End If
                        End If

                        If (idsegmanorg > 0) Then
                            If sb.Length = 0 Then
                                sb.Append("it.idsegmanorg=")
                                sb.Append(idsegmanorg)
                                sb.Append("")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and it.idsegmanorg=")
                                    sb.Append(idsegmanorg)
                                    sb.Append("")
                                End If
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                        'si es auditor lider principal se buscan los peritos lid suc y peritos ext e int de su suc

                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(peritols)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoext)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoint)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            End If
                        End If

                        ''se buscan por organizacion ya que es lider sucursal
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = peritols) Then
                        'si es Perito lider Suc se buscan los peritos externos e internos
                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(peritoext)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(peritoint)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            End If
                        End If

                        ''se buscan por organizacion ya que es lider sucursal
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If
                    End If

                End If
            End If

            If idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If

            If sb.Length = 0 Then
                sb.Append("it.ibloqueado=")
                sb.Append(False)
                sb.Append("")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.ibloqueado=")
                    sb.Append(False)
                    sb.Append("")
                End If
            End If

            Dim lista_vi_segusudetperf2 As New List(Of vi_segusudetperf2)
            lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).ToList

            'agregar el item vacio para seleccion
            Dim _vi_segusudetperf2 As New vi_segusudetperf2
            With _vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, _vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function


        <HttpPost()> _
        Public Function ObtenerComboPorAccionOrgTipoPeritYTipoUsuario(idsegmanorg As Decimal, itipoaccion As String, itipoperit As String, idsegmanusu As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim sb As New StringBuilder("")
            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")
            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim vi_segusudetperf2 As New vi_segusudetperf2
            vi_segusudetperf2 = selvi_segusudetperf2poridsegmanusu(idsegmanusu)
            Dim aplica As Boolean = False

            If (vi_segusudetperf2 IsNot Nothing) Then
                If (vi_segusudetperf2.idsegmanperf <> auditor Or vi_segusudetperf2.idsegmanperf <> peritoext Or vi_segusudetperf2.idsegmanperf <> peritoint) Then
                    aplica = True
                End If


                If (itipoaccion = "AUDITOR") Then

                    If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                        'si es auditor lider principal se buscan los auditores lider suc y auditores
                        If sb.Length = 0 Then
                            sb.Append(" (it.idsegmanperf=")
                            sb.Append(auditorls)
                            sb.Append(" or it.idsegmanperf=")
                            sb.Append(auditor)
                            sb.Append(") ")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and (it.idsegmanperf=")
                                sb.Append(auditorls)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(auditor)
                                sb.Append(") ")
                            End If
                        End If

                        If (idsegmanorg > 0) Then
                            If sb.Length = 0 Then
                                sb.Append("it.idsegmanorg=")
                                sb.Append(idsegmanorg)
                                sb.Append("")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and it.idsegmanorg=")
                                    sb.Append(idsegmanorg)
                                    sb.Append("")
                                End If
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                        'si es auditor lider Suc se buscan los auditores
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanperf=")
                            sb.Append(auditor)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanperf=")
                                sb.Append(auditor)
                                sb.Append("")
                            End If
                        End If

                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If

                    End If


                ElseIf (itipoaccion = "PERITO") Then

                    If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                        'si es auditor lider principal se buscan los perito lider suc y peritos ext e int

                        If (itipoperit = "EXTERNO") Then
                            If sb.Length = 0 Then
                                sb.Append(" (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(") ")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and (it.idsegmanperf=")
                                    sb.Append(peritols)
                                    sb.Append(" or it.idsegmanperf=")
                                    sb.Append(peritoext)
                                    sb.Append(") ")
                                End If
                            End If
                        Else
                            If sb.Length = 0 Then
                                sb.Append(" (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and (it.idsegmanperf=")
                                    sb.Append(peritols)
                                    sb.Append(" or it.idsegmanperf=")
                                    sb.Append(peritoint)
                                    sb.Append(") ")
                                End If
                            End If
                        End If


                        If (idsegmanorg > 0) Then
                            If sb.Length = 0 Then
                                sb.Append("it.idsegmanorg=")
                                sb.Append(idsegmanorg)
                                sb.Append("")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and it.idsegmanorg=")
                                    sb.Append(idsegmanorg)
                                    sb.Append("")
                                End If
                            End If
                        End If


                    ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                        'si es auditor lider principal se buscan los peritos lid suc y peritos ext e int de su suc


                        If (itipoperit = "EXTERNO") Then
                            If sb.Length = 0 Then
                                sb.Append(" (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(") ")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and (it.idsegmanperf=")
                                    sb.Append(peritols)
                                    sb.Append(" or it.idsegmanperf=")
                                    sb.Append(peritoext)
                                    sb.Append(") ")
                                End If
                            End If
                        Else
                            If sb.Length = 0 Then
                                sb.Append(" (it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(") ")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and (it.idsegmanperf=")
                                    sb.Append(peritols)
                                    sb.Append(" or it.idsegmanperf=")
                                    sb.Append(peritoint)
                                    sb.Append(") ")
                                End If
                            End If
                        End If

                        ''se buscan por organizacion ya que es lider sucursal
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If

                    ElseIf (vi_segusudetperf2.idsegmanperf = peritols) Then
                        'si es Perito lider Suc se buscan los peritos externos e internos
                        If (itipoperit = "EXTERNO") Then
                            If sb.Length = 0 Then
                                sb.Append(" (it.idsegmanperf=")
                                sb.Append(peritoext)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" and it.idsegmanusu=")
                                sb.Append(idsegmanusu)
                                sb.Append(") ")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and (it.idsegmanperf=")
                                    sb.Append(peritoext)
                                    sb.Append(" or it.idsegmanperf=")
                                    sb.Append(peritols)
                                    sb.Append(" and it.idsegmanusu=")
                                    sb.Append(idsegmanusu)
                                    sb.Append(") ")
                                End If
                            End If
                        Else
                            If sb.Length = 0 Then
                                sb.Append(" (it.idsegmanperf=")
                                sb.Append(peritoint)
                                sb.Append(" or it.idsegmanperf=")
                                sb.Append(peritols)
                                sb.Append(" and it.idsegmanusu=")
                                sb.Append(idsegmanusu)
                                sb.Append(") ")
                            Else
                                If sb.Length > 0 Then
                                    sb.Append(" and (it.idsegmanperf=")
                                    sb.Append(peritoint)
                                    sb.Append(" or it.idsegmanperf=")
                                    sb.Append(peritols)
                                    sb.Append(" and it.idsegmanusu=")
                                    sb.Append(idsegmanusu)
                                    sb.Append(") ")
                                End If
                            End If
                        End If

                        ''se buscan por organizacion ya que es lider sucursal
                        If sb.Length = 0 Then
                            sb.Append("it.idsegmanorg=")
                            sb.Append(vi_segusudetperf2.idsegmanorg)
                            sb.Append("")
                        Else
                            If sb.Length > 0 Then
                                sb.Append(" and it.idsegmanorg=")
                                sb.Append(vi_segusudetperf2.idsegmanorg)
                                sb.Append("")
                            End If
                        End If
                    End If

                End If
            End If

            If idsegmanapp <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanapp=")
                    sb.Append(valor_entero(idsegmanapp))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanapp=")
                        sb.Append(valor_entero(idsegmanapp))
                        sb.Append("")
                    End If
                End If
            End If

            If sb.Length = 0 Then
                sb.Append("it.ibloqueado=")
                sb.Append(False)
                sb.Append("")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.ibloqueado=")
                    sb.Append(False)
                    sb.Append("")
                End If
            End If

            Dim lista_vi_segusudetperf2 As New List(Of vi_segusudetperf2)
            'si se cumplen los perfiles para la busqueda
            If (aplica) Then
                lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).ToList
            End If

            Dim idsegmanperfnv As Decimal = 0

            Dim comunconfvalorController As New comunconfvalorController
            Dim lista_comunconfvalor As List(Of comunconfvalor) = comunconfvalorController.selcomunconfvalorxconceptosinsel("IDSUCPRINCIPAL")
            If lista_comunconfvalor.Count > 0 Then
                idsegmanorg = lista_comunconfvalor(0).xvalorcodigo
            End If

            If (lista_vi_segusudetperf2.Count = 0 Or lista_vi_segusudetperf2.Count = 1) Then

                If (itipoperit = "EXTERNO") Then
                    idsegmanperfnv = peritoext
                Else
                    idsegmanperfnv = peritoint
                End If

                ''si el tipo de accion es perito buscos por este perfil
                If (itipoaccion = "PERITO") Then

                    Dim lista_vi_segusudetperf2_nueva As New List(Of vi_segusudetperf2)
                    ''si es igual a uno quiere decir que si existe el perito ls pero no se encuentran mas
                    If (lista_vi_segusudetperf2.Count = 1) Then
                        lista_vi_segusudetperf2_nueva = selvi_segusudetperf2comboPorOrgDifUsu(idsegmanorg, idsegmanperfnv, idsegmanusu)
                        ''agrego el perito de la lista nueva
                        lista_vi_segusudetperf2_nueva.Add(lista_vi_segusudetperf2(0))
                        'luego guardo toda la lista en la de retorno
                        lista_vi_segusudetperf2 = lista_vi_segusudetperf2_nueva
                    Else
                        lista_vi_segusudetperf2 = selvi_segusudetperf2comboPorOrgYUsu(idsegmanorg, idsegmanperfnv, idsegmanusu)
                    End If

                Else
                    lista_vi_segusudetperf2 = selvi_segusudetperf2comboPorOrgYPerfiles(idsegmanorg, idsegmanperfnv)
                End If



            End If


            'agregar el item vacio para seleccion
            Dim _vi_segusudetperf2 As New vi_segusudetperf2
            With _vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, _vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function

        'metodo para obtener todos los usuario segun el tipo de accion PERITO o AUDITOR
        <HttpPost()> _
        Public Function selvi_segusudetperf2comboporaccionyorg(idsegmanorg As Decimal, itipoaccion As String, idsegmanusu As Decimal) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
            Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
            Dim auditor As Decimal = ConfigurationManager.AppSettings("auditor")
            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim lista_vi_segusudetperf2 As New List(Of vi_segusudetperf2)
            If (itipoaccion = "AUDITOR") Then

                lista_vi_segusudetperf2 = (From p In _db.vi_segusudetperf2
                        Where p.idsegmanapp = idsegmanapp And p.idsegmanorg = idsegmanorg And (p.idsegmanperf = auditorlp Or p.idsegmanperf = auditorls Or p.idsegmanperf = auditor) And p.ibloqueado = False
                                                        Select p).ToList

            ElseIf (itipoaccion = "PERITO") Then
                lista_vi_segusudetperf2 = (From p In _db.vi_segusudetperf2
                    Where p.idsegmanapp = idsegmanapp And p.idsegmanorg = idsegmanorg And (p.idsegmanperf = peritols Or p.idsegmanperf = peritoext Or p.idsegmanperf = peritoint) And p.ibloqueado = False
                                                        Select p).ToList
            End If



            'agregar el item vacio para seleccion
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            With vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function


        'metodo para obtener todos los usuario segun el tipo de accion PERITO
        <HttpPost()> _
        Public Function selvi_segusudetperf2peritoswheredinamico(idsegmanorg As Decimal, itipoaccion As String) As List(Of vi_segusudetperf2)

            'aqui lo primero que verfica es cuales son los usuarios que estan suspendidos para sacarlos de la suspension si ya la fecha de fin es menor a la fecha actual                
            Dim inspeccionController As New InspeccionController
            inspeccionController.VerificarUsuarioSuspendidos()

            Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")
            Dim peritoint As Decimal = ConfigurationManager.AppSettings("peritoint")
            Dim peritoext As Decimal = ConfigurationManager.AppSettings("peritoext")

            Dim idsegmanapp As Decimal = ConfigurationManager.AppSettings("idsegmanapp")

            Dim idsegmanperf As Decimal = 0


            Dim lista_vi_segusudetperf2 As New List(Of vi_segusudetperf2)
            If (itipoaccion = "EXTERNO") Then
                idsegmanperf = peritoext
            ElseIf (itipoaccion = "INTERNO") Then
                idsegmanperf = peritoint
            End If

            Dim sb As New StringBuilder("")


            If sb.Length = 0 Then
                sb.Append("it.idsegmanapp=")
                sb.Append(valor_entero(idsegmanapp))
                sb.Append("")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.idsegmanapp=")
                    sb.Append(valor_entero(idsegmanapp))
                    sb.Append("")
                End If
            End If


            If idsegmanorg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanorg=")
                    sb.Append(valor_entero(idsegmanorg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanorg=")
                        sb.Append(valor_entero(idsegmanorg))
                        sb.Append("")
                    End If
                End If
            End If

            If idsegmanperf <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanperf=")
                    sb.Append(valor_entero(idsegmanperf))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanperf=")
                        sb.Append(valor_entero(idsegmanperf))
                        sb.Append("")
                    End If
                End If
            End If

            If sb.Length = 0 Then
                sb.Append("it.ibloqueado=")
                sb.Append(False)
                sb.Append("")
            Else
                If sb.Length > 0 Then
                    sb.Append(" and it.ibloqueado=")
                    sb.Append(False)
                    sb.Append("")
                End If
            End If

            lista_vi_segusudetperf2 = _db.vi_segusudetperf2.Where(sb.ToString).ToList




            'agregar el item vacio para seleccion
            Dim vi_segusudetperf2 As New vi_segusudetperf2
            With vi_segusudetperf2
                .idsegmanusu = 0
                .idsegmanperf = 0
                .xnombrecompleto = "SELECCIONE..."
                .xnombreperf = ""
            End With
            lista_vi_segusudetperf2.Insert(0, vi_segusudetperf2)
            Return lista_vi_segusudetperf2
        End Function

    End Class
End Namespace
