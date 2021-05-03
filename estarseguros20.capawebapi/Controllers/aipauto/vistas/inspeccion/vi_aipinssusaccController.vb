Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssusaccController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssusaccxid(idaipinssusacc As Decimal) As vi_aipinssusacc
            Dim vi_aipinssusacc As vi_aipinssusacc = (From p In _db.vi_aipinssusacc
                                            Where p.idaipinssusacc = idaipinssusacc
                                            Select p).SingleOrDefault
            Return vi_aipinssusacc
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssusacc() As List(Of vi_aipinssusacc)
		Dim lista_vi_aipinssusacc As List(Of vi_aipinssusacc) = (From p In _db.vi_aipinssusacc
													Select p).ToList
		'
		Return lista_vi_aipinssusacc
	End Function

        <HttpPost()> _
           Public Function selvi_aipinssusaccxwheredinamicopag(petivi_aipinssusaccpaglist As petivi_aipinssusaccpaglist) As respvi_aipinssusaccpaglist
            Dim sb As New StringBuilder("")
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssusacc=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssusacc=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssus=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssus=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petivi_aipinssusaccpaglist.vi_aipinssusacc.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petivi_aipinssusaccpaglist.vi_aipinssusacc.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipmanvehacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanvehacc=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipmanvehacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanvehacc=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idaipmanvehacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.xnommanvehacc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnommanvehacc='")
                    sb.Append(petivi_aipinssusaccpaglist.vi_aipinssusacc.xnommanvehacc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnommanvehacc='")
                        sb.Append(petivi_aipinssusaccpaglist.vi_aipinssusacc.xnommanvehacc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.ioriginssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ioriginssusacc=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.ioriginssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ioriginssusacc=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.ioriginssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.inoexistinssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.inoexistinssusacc=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.inoexistinssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.inoexistinssusacc=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.inoexistinssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.inooriginssusacc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.inooriginssusacc=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.inooriginssusacc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.inooriginssusacc=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.inooriginssusacc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusaccpaglist.vi_aipinssusacc.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petivi_aipinssusaccpaglist.vi_aipinssusacc.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respvi_aipinssusaccpaglist As New respvi_aipinssusaccpaglist
            respvi_aipinssusaccpaglist.pagvi_aipinssusacc = petivi_aipinssusaccpaglist.pagvi_aipinssusacc
            Dim skip = skip_paginacion(petivi_aipinssusaccpaglist.pagvi_aipinssusacc.npagactual, petivi_aipinssusaccpaglist.pagvi_aipinssusacc.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinssusaccpaglist.lista_vi_aipinssusacc = _db.vi_aipinssusacc.OrderBy(petivi_aipinssusaccpaglist.pagvi_aipinssusacc.xcamposord & " " & petivi_aipinssusaccpaglist.pagvi_aipinssusacc.idirord).Skip(skip).Take(petivi_aipinssusaccpaglist.pagvi_aipinssusacc.npagtamano).ToList
            Else
                respvi_aipinssusaccpaglist.lista_vi_aipinssusacc = _db.vi_aipinssusacc.Where(sb.ToString).OrderBy(petivi_aipinssusaccpaglist.pagvi_aipinssusacc.xcamposord & " " & petivi_aipinssusaccpaglist.pagvi_aipinssusacc.idirord).Skip(skip).Take(petivi_aipinssusaccpaglist.pagvi_aipinssusacc.npagtamano).ToList
            End If
            '
            If (respvi_aipinssusaccpaglist.lista_vi_aipinssusacc.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinssusaccxwheredinamicocount(sb)
                respvi_aipinssusaccpaglist.pagvi_aipinssusacc.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssusaccpaglist.pagvi_aipinssusacc.npagtamano)
            Else
                respvi_aipinssusaccpaglist.pagvi_aipinssusacc.npagcantidad = 0
                respvi_aipinssusaccpaglist.pagvi_aipinssusacc.npagactual = 0
            End If

            Return respvi_aipinssusaccpaglist
        End Function

	Public Function selvi_aipinssusaccxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssusacc.count
	Else
	Return _db.vi_aipinssusacc.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinssusaccxidaipinssus(idaipinssus As Decimal) As List(Of vi_aipinssusacc)
            Dim lista_vi_aipinssusacc As List(Of vi_aipinssusacc) = (From p In _db.vi_aipinssusacc
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_vi_aipinssusacc
        End Function
End Class
End Namespace
