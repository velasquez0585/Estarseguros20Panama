Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssusrepuestController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssusrepuestxid(idaipinssusrepuest As Decimal) As vi_aipinssusrepuest
            Dim vi_aipinssusrepuest As vi_aipinssusrepuest = (From p In _db.vi_aipinssusrepuest
                                            Where p.idaipinssusrepuest = idaipinssusrepuest
                                            Select p).SingleOrDefault
            Return vi_aipinssusrepuest
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssusrepuest() As List(Of vi_aipinssusrepuest)
		Dim lista_vi_aipinssusrepuest As List(Of vi_aipinssusrepuest) = (From p In _db.vi_aipinssusrepuest
													Select p).ToList
		'
		Return lista_vi_aipinssusrepuest
	End Function

        <HttpPost()> _
           Public Function selvi_aipinssusrepuestxwheredinamicopag(petivi_aipinssusrepuestpaglist As petivi_aipinssusrepuestpaglist) As respvi_aipinssusrepuestpaglist
            Dim sb As New StringBuilder("")
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssusrepuest=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssusrepuest=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinssus <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinssus=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinssus))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinssus=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinssus))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.itipoinsenc <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.itipoinsenc='")
                    sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.itipoinsenc)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.itipoinsenc='")
                        sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.itipoinsenc)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipmanrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipmanrepu=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipmanrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipmanrepu=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idaipmanrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.xnommanrepu <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnommanrepu='")
                    sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.xnommanrepu)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnommanrepu='")
                        sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.xnommanrepu)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.nordenmanrepu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.nordenmanrepu=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.nordenmanrepu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.nordenmanrepu=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.nordenmanrepu))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.xnominssusrepuest <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnominssusrepuest='")
                    sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.xnominssusrepuest)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnominssusrepuest='")
                        sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.xnominssusrepuest)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.inoapliinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.inoapliinssusrepuest=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.inoapliinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.inoapliinssusrepuest=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.inoapliinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ileveinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ileveinssusrepuest=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ileveinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ileveinssusrepuest=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ileveinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.imedinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.imedinssusrepuest=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.imedinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.imedinssusrepuest=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.imedinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ifueinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ifueinssusrepuest=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ifueinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ifueinssusrepuest=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ifueinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ibueestinssusrepuest <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.ibueestinssusrepuest=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ibueestinssusrepuest))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.ibueestinssusrepuest=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.ibueestinssusrepuest))
                        sb.Append("")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.iestinssusrepuest <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iestinssusrepuest='")
                    sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.iestinssusrepuest)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iestinssusrepuest='")
                        sb.Append(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.iestinssusrepuest)
                        sb.Append("'")
                    End If
                End If
            End If
            '
            If petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idseglogreg <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idseglogreg=")
                    sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idseglogreg))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idseglogreg=")
                        sb.Append(valor_entero(petivi_aipinssusrepuestpaglist.vi_aipinssusrepuest.idseglogreg))
                        sb.Append("")
                    End If
                End If
            End If
            '


            Dim respvi_aipinssusrepuestpaglist As New respvi_aipinssusrepuestpaglist
            respvi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest = petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest
            Dim skip = skip_paginacion(petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagactual, petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagtamano)

            If sb.ToString = "" Then
                respvi_aipinssusrepuestpaglist.lista_vi_aipinssusrepuest = _db.vi_aipinssusrepuest.OrderBy(petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.xcamposord & " " & petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.idirord).Skip(skip).Take(petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagtamano).ToList
            Else
                respvi_aipinssusrepuestpaglist.lista_vi_aipinssusrepuest = _db.vi_aipinssusrepuest.Where(sb.ToString).OrderBy(petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.xcamposord & " " & petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.idirord).Skip(skip).Take(petivi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagtamano).ToList
            End If
            '
            If (respvi_aipinssusrepuestpaglist.lista_vi_aipinssusrepuest.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aipinssusrepuestxwheredinamicocount(sb)
                respvi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagtamano)
            Else
                respvi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagcantidad = 0
                respvi_aipinssusrepuestpaglist.pagvi_aipinssusrepuest.npagactual = 0
            End If

            Return respvi_aipinssusrepuestpaglist
        End Function

	Public Function selvi_aipinssusrepuestxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssusrepuest.count
	Else
	Return _db.vi_aipinssusrepuest.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinssusrepuestxidaipinssus(idaipinssus As Decimal) As List(Of vi_aipinssusrepuest)
            Dim lista_vi_aipinssusrepuest As List(Of vi_aipinssusrepuest) = (From p In _db.vi_aipinssusrepuest
                                                                             Order By p.nordenmanrepu
                                            Where p.idaipinssus = idaipinssus
                                            Select p).ToList
            Return lista_vi_aipinssusrepuest
        End Function
End Class
End Namespace
