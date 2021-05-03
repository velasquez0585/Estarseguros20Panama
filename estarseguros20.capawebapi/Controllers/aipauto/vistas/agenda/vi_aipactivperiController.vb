Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.agenda
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipactivperiController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipactivperixid(idaipactivperi As Decimal) As vi_aipactivperi
            Dim vi_aipactivperi As vi_aipactivperi = (From p In _db.vi_aipactivperi
                                            Where p.idaipactivperi = idaipactivperi
                                            Select p).SingleOrDefault
            Return vi_aipactivperi
        End Function

        <HttpPost()> _
        Public Function selvi_aipactivperi() As List(Of vi_aipactivperi)
            Dim lista_vi_aipactivperi As List(Of vi_aipactivperi) = (From p In _db.vi_aipactivperi
                                                        Select p).ToList
            '
            Return lista_vi_aipactivperi
        End Function

        <HttpPost()> _
           Public Function selvi_aipactivperixwheredinamicopag(petivi_aipactivperipaglist As petivi_aipactivperipaglist) As respvi_aipactivperipaglist
            Dim sb As New StringBuilder("")
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.idaipactivperi <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipactivperi=")
                    sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idaipactivperi))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipactivperi=")
                        sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idaipactivperi))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.idcomunmancont <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmancont=")
                    sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmancont))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmancont=")
                        sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmancont))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanpais <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanpais=")
                    sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanpais))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanpais=")
                        sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanpais))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanlocalid <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanlocalid=")
                    sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanlocalid))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanlocalid=")
                        sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanlocalid))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.fejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperipaglist.vi_aipactivperi.fejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperipaglist.vi_aipactivperi.fejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanestado <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idcomunmanestado=")
                    sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanestado))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idcomunmanestado=")
                        sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idcomunmanestado))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.xdireccionactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdireccionactivperi='")
                    sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xdireccionactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdireccionactivperi='")
                        sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xdireccionactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.xtelfmovilactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtelfmovilactivperi='")
                    sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xtelfmovilactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtelfmovilactivperi='")
                        sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xtelfmovilactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.ffinejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperipaglist.vi_aipactivperi.ffinejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperipaglist.vi_aipactivperi.ffinejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.xcorreoelectronicoactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xcorreoelectronicoactivperi='")
                    sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xcorreoelectronicoactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xcorreoelectronicoactivperi='")
                        sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xcorreoelectronicoactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.xdescactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xdescactivperi='")
                    sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xdescactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xdescactivperi='")
                        sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xdescactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.ialcanactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.ialcanactivperi='")
                    sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.ialcanactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ialcanactivperi='")
                        sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.ialcanactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.xtituactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtituactivperi='")
                    sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xtituactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtituactivperi='")
                        sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.xtituactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.iestatactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatactivperi='")
                    sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.iestatactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatactivperi='")
                        sb.Append(petivi_aipactivperipaglist.vi_aipactivperi.iestatactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperipaglist.vi_aipactivperi.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petivi_aipactivperipaglist.vi_aipactivperi.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respvi_aipactivperipaglist As New respvi_aipactivperipaglist
            respvi_aipactivperipaglist.pagvi_aipactivperi = petivi_aipactivperipaglist.pagvi_aipactivperi
            Dim skip = skip_paginacion(petivi_aipactivperipaglist.pagvi_aipactivperi.npagactual, petivi_aipactivperipaglist.pagvi_aipactivperi.npagtamano)

            If sb.ToString = "" Then
                respvi_aipactivperipaglist.lista_vi_aipactivperi = _db.vi_aipactivperi.OrderBy(petivi_aipactivperipaglist.pagvi_aipactivperi.xcamposord & " " & petivi_aipactivperipaglist.pagvi_aipactivperi.idirord).Skip(skip).Take(petivi_aipactivperipaglist.pagvi_aipactivperi.npagtamano).ToList
            Else
                respvi_aipactivperipaglist.lista_vi_aipactivperi = _db.vi_aipactivperi.Where(sb.ToString).OrderBy(petivi_aipactivperipaglist.pagvi_aipactivperi.xcamposord & " " & petivi_aipactivperipaglist.pagvi_aipactivperi.idirord).Skip(skip).Take(petivi_aipactivperipaglist.pagvi_aipactivperi.npagtamano).ToList
            End If
            '
            If (respvi_aipactivperipaglist.lista_vi_aipactivperi.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipactivperixwheredinamicocount(sb)
                respvi_aipactivperipaglist.pagvi_aipactivperi.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipactivperipaglist.pagvi_aipactivperi.npagtamano)
            Else
                respvi_aipactivperipaglist.pagvi_aipactivperi.npagcantidad = 0
                respvi_aipactivperipaglist.pagvi_aipactivperi.npagactual = 0
            End If

            Return respvi_aipactivperipaglist
        End Function

        Public Function selvi_aipactivperixwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.vi_aipactivperi.count
            Else
                Return _db.vi_aipactivperi.Where(sb.ToString).Count
            End If
        End Function

End Class
End Namespace
