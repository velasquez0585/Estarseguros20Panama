Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.agenda
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
    Public Class vi_aipactivperidetController
        Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipactivperidetxid(idaipactivperi As Decimal) As vi_aipactivperidet
            Dim vi_aipactivperidet As vi_aipactivperidet = (From p In _db.vi_aipactivperidet
                                            Where p.idaipactivperi = idaipactivperi
                                            Select p).SingleOrDefault
            Return vi_aipactivperidet
        End Function

        <HttpPost()> _
        Public Function selvi_aipactivperidet() As List(Of vi_aipactivperidet)
            Dim lista_vi_aipactivperidet As List(Of vi_aipactivperidet) = (From p In _db.vi_aipactivperidet
                                                        Select p).ToList
            '
            Return lista_vi_aipactivperidet
        End Function

        <HttpPost()> _
           Public Function selvi_aipactivperidetxwheredinamicopag(petivi_aipactivperidetpaglist As petivi_aipactivperidetpaglist) As respvi_aipactivperidetpaglist
            Dim sb As New StringBuilder("")
            '
            If petivi_aipactivperidetpaglist.vi_aipactivperidet.idaipactivperi <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipactivperi=")
                    sb.Append(valor_entero(petivi_aipactivperidetpaglist.vi_aipactivperidet.idaipactivperi))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipactivperi=")
                        sb.Append(valor_entero(petivi_aipactivperidetpaglist.vi_aipactivperidet.idaipactivperi))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipactivperidetpaglist.vi_aipactivperidet.fejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperidetpaglist.vi_aipactivperidet.fejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperidetpaglist.vi_aipactivperidet.fejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipactivperidetpaglist.vi_aipactivperidet.xtituactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtituactivperi='")
                    sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.xtituactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtituactivperi='")
                        sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.xtituactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperidetpaglist.vi_aipactivperidet.ialcanactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.ialcanactivperi='")
                    sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.ialcanactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ialcanactivperi='")
                        sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.ialcanactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperidetpaglist.vi_aipactivperidet.iestatactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestatactivperi='")
                    sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.iestatactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestatactivperi='")
                        sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.iestatactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipactivperidetpaglist.vi_aipactivperidet.ffinejecactivperi > CDate("01-01-1920") Then
                Dim fecha As String = ""
                If sb.Length = 0 Then
                    fecha = [String].Format("it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperidetpaglist.vi_aipactivperidet.ffinejecactivperi)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.ffinejecactivperi >= DATETIME'{0:yyyy-MM-dd HH:mm}'", petivi_aipactivperidetpaglist.vi_aipactivperidet.ffinejecactivperi)
                        sb.Append(fecha)
                    End If
                End If
            End If
            '
            If petivi_aipactivperidetpaglist.vi_aipactivperidet.xtelfmovilactivperi <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xtelfmovilactivperi='")
                    sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.xtelfmovilactivperi)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xtelfmovilactivperi='")
                        sb.Append(petivi_aipactivperidetpaglist.vi_aipactivperidet.xtelfmovilactivperi)
                        sb.Append("'")
                    End If
                End If
            End If
            '


            Dim respvi_aipactivperidetpaglist As New respvi_aipactivperidetpaglist
            respvi_aipactivperidetpaglist.pagvi_aipactivperidet = petivi_aipactivperidetpaglist.pagvi_aipactivperidet
            Dim skip = skip_paginacion(petivi_aipactivperidetpaglist.pagvi_aipactivperidet.npagactual, petivi_aipactivperidetpaglist.pagvi_aipactivperidet.npagtamano)

            If sb.ToString = "" Then
                respvi_aipactivperidetpaglist.lista_vi_aipactivperidet = _db.vi_aipactivperidet.OrderBy(petivi_aipactivperidetpaglist.pagvi_aipactivperidet.xcamposord & " " & petivi_aipactivperidetpaglist.pagvi_aipactivperidet.idirord).Skip(skip).Take(petivi_aipactivperidetpaglist.pagvi_aipactivperidet.npagtamano).ToList
            Else
                respvi_aipactivperidetpaglist.lista_vi_aipactivperidet = _db.vi_aipactivperidet.Where(sb.ToString).OrderBy(petivi_aipactivperidetpaglist.pagvi_aipactivperidet.xcamposord & " " & petivi_aipactivperidetpaglist.pagvi_aipactivperidet.idirord).Skip(skip).Take(petivi_aipactivperidetpaglist.pagvi_aipactivperidet.npagtamano).ToList
            End If
            '
            If (respvi_aipactivperidetpaglist.lista_vi_aipactivperidet.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipactivperidetxwheredinamicocount(sb)
                respvi_aipactivperidetpaglist.pagvi_aipactivperidet.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipactivperidetpaglist.pagvi_aipactivperidet.npagtamano)
            Else
                respvi_aipactivperidetpaglist.pagvi_aipactivperidet.npagcantidad = 0
                respvi_aipactivperidetpaglist.pagvi_aipactivperidet.npagactual = 0
            End If

            Return respvi_aipactivperidetpaglist
        End Function

        Public Function selvi_aipactivperidetxwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.vi_aipactivperidet.count
            Else
                Return _db.vi_aipactivperidet.Where(sb.ToString).Count
            End If
        End Function
        'metodos no automaticos
        '<HttpPost()> _
        'Public Function selvi_aipactivperidetxidsegmanusuejecstart(start As Date, ialcanactivperi As String, idsegmanusu As String) As List(Of vi_aipactivperidet)
        '    Dim fecha_start As New Date(start.Year, start.Month, start.Day, 0, 0, 0)
        '    '
        '    Dim lista_vi_ragactencdet As List(Of vi_aipactivperidet) = (From p In _db.vi_aipactivperidet
        '                                                             Where p.fejecactivperi >= fecha_start And p.ialcanactivperi = ialcanactivperi And p.idsegmanusu = idsegmanusu
        '                                                             Select p).ToList
        '    '
        '    Return lista_vi_ragactencdet
        'End Function

        '<HttpPost()> _
        'Public Function selvi_aipactivperidetxCorreoElectronicoYstart(start As Date, ialcanactivperi As String, xcorreoelectronico1 As String) As List(Of vi_aipactivperidet)
        '    Dim fecha_start As New Date(start.Year, start.Month, start.Day, 0, 0, 0)
        '    '
        '    Dim lista_vi_ragactencdet As List(Of vi_aipactivperidet) = (From p In _db.vi_aipactivperidet
        '                                                             Where p.fejecactivperi >= fecha_start And p.ialcanactivperi = ialcanactivperi And p.xcorreoelectronico1 = xcorreoelectronico1
        '                                                             Select p).ToList
        '    '
        '    Return lista_vi_ragactencdet
        'End Function
    End Class
End Namespace
