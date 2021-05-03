Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.log
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aiplogeveController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aiplogevexid(idaiplogeve As Decimal) As vi_aiplogeve
            Dim vi_aiplogeve As vi_aiplogeve = (From p In _db.vi_aiplogeve
                                            Where p.idaiplogeve = idaiplogeve
                                            Select p).SingleOrDefault
            Return vi_aiplogeve
        End Function

	<HttpPost()> _
	Public Function selvi_aiplogeve() As List(Of vi_aiplogeve)
		Dim lista_vi_aiplogeve As List(Of vi_aiplogeve) = (From p In _db.vi_aiplogeve
													Select p).ToList
		'
		Return lista_vi_aiplogeve
	End Function

<HttpPost()> _
	Public Function selvi_aiplogevexwheredinamicopag(petivi_aiplogevepaglist as petivi_aiplogevepaglist) as respvi_aiplogevepaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aiplogevepaglist.vi_aiplogeve.idaiplogeve <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaiplogeve=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idaiplogeve))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaiplogeve=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idaiplogeve))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.xnomlogeve <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomlogeve='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnomlogeve)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomlogeve='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnomlogeve)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.idsegmanusu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idsegmanusu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idsegmanusu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.idcomunmanpers <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmanpers=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idcomunmanpers))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmanpers=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idcomunmanpers))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.fcrealogeve > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aiplogevepaglist.vi_aiplogeve.fcrealogeve)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aiplogevepaglist.vi_aiplogeve.fcrealogeve)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iamblogeve='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iamblogeve='")
				sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aiplogevepaglist.vi_aiplogeve.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aiplogevepaglist As New respvi_aiplogevepaglist
	respvi_aiplogevepaglist.pagvi_aiplogeve = petivi_aiplogevepaglist.pagvi_aiplogeve
	Dim skip = skip_paginacion(petivi_aiplogevepaglist.pagvi_aiplogeve.npagactual, petivi_aiplogevepaglist.pagvi_aiplogeve.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aiplogevepaglist.lista_vi_aiplogeve = _db.vi_aiplogeve.OrderBy(petivi_aiplogevepaglist.pagvi_aiplogeve.xcamposord & " "  & petivi_aiplogevepaglist.pagvi_aiplogeve.idirord).Skip(skip).Take(petivi_aiplogevepaglist.pagvi_aiplogeve.npagtamano).ToList
		Else
			respvi_aiplogevepaglist.lista_vi_aiplogeve = _db.vi_aiplogeve.Where(sb.ToString).OrderBy(petivi_aiplogevepaglist.pagvi_aiplogeve.xcamposord & " "  & petivi_aiplogevepaglist.pagvi_aiplogeve.idirord).Skip(skip).Take(petivi_aiplogevepaglist.pagvi_aiplogeve.npagtamano).ToList
		End If
		'
		If (respvi_aiplogevepaglist.lista_vi_aiplogeve.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aiplogevexwheredinamicocount(sb)
		respvi_aiplogevepaglist.pagvi_aiplogeve.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aiplogevepaglist.pagvi_aiplogeve.npagtamano)
		Else
		respvi_aiplogevepaglist.pagvi_aiplogeve.npagcantidad = 0
		respvi_aiplogevepaglist.pagvi_aiplogeve.npagactual = 0
		End If
	
		Return respvi_aiplogevepaglist
	End Function


        Public Function selvi_aiplogevexwheredinamicocount(sb As StringBuilder) As Integer
            If sb.ToString = "" Then
                Return _db.vi_aiplogeve.Count
            Else
                Return _db.vi_aiplogeve.Where(sb.ToString).Count
            End If


        End Function

        <HttpPost()> _
        Public Function selvi_aiplogevexwheredinamicopag2(fdesde As Date, fhasta As Date, petivi_aiplogevepaglist As petivi_aiplogevepaglist) As respvi_aiplogevepaglist
            Dim sb As New StringBuilder("")

            fdesde = New Date(fdesde.Year, fdesde.Month, fdesde.Day, 0, 0, 0)
            fhasta = New Date(fhasta.Year, fhasta.Month, fhasta.Day, 0, 0, 0)

            If (petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve = "m") Then
                petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve = "MOVIL"
            ElseIf (petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve = "w") Then
                petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve = "WEB"
            End If

            '
            If petivi_aiplogevepaglist.vi_aiplogeve.idaiplogeve <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaiplogeve=")
                    sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idaiplogeve))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaiplogeve=")
                        sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idaiplogeve))
                        sb.Append("")
                    End If
                End If
            End If
            '

            '
            If petivi_aiplogevepaglist.vi_aiplogeve.idsegmanusu <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusu=")
                    sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idsegmanusu))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusu=")
                        sb.Append(valor_entero(petivi_aiplogevepaglist.vi_aiplogeve.idsegmanusu))
                        sb.Append("")
                    End If
                End If
            End If

            If petivi_aiplogevepaglist.vi_aiplogeve.xnombrecompleto <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.xnombrecompleto LIKE '%")
                    sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnombrecompleto)
                    sb.Append("%'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.xnombrecompleto LIKE '%")
                        sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.xnombrecompleto)
                        sb.Append("%'")
                    End If
                End If
            End If

            '
            Dim fecha As String = ""
            If (fdesde > New Date(1900, 1, 1) And fhasta > New Date(1900, 1, 1)) Then
                fhasta = fhasta.AddDays(1)

                If sb.Length = 0 Then
                    fecha = [String].Format("it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}' AND it.fcrealogeve < DATETIME'{1:yyyy-MM-dd HH:mm}'", fdesde, fhasta)
                    sb.Append(fecha)
                Else
                    If sb.Length > 0 Then
                        fecha = [String].Format(" and it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}' AND it.fcrealogeve < DATETIME'{1:yyyy-MM-dd HH:mm}'", fdesde, fhasta)
                        sb.Append(fecha)
                    End If
                End If
            Else

                If (fdesde > New Date(1900, 1, 1)) Then
                    If sb.Length = 0 Then
                        fecha = [String].Format("it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}'", fdesde)
                        sb.Append(fecha)
                    Else
                        If sb.Length > 0 Then
                            fecha = [String].Format(" and it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}' ", fdesde)
                            sb.Append(fecha)
                        End If
                    End If

                Else
                    If (fhasta > New Date(1900, 1, 1)) Then
                        If sb.Length = 0 Then
                            fecha = [String].Format("it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}'", fhasta)
                            sb.Append(fecha)
                        Else
                            If sb.Length > 0 Then
                                fecha = [String].Format(" and it.fcrealogeve >= DATETIME'{0:yyyy-MM-dd HH:mm}' ", fhasta)
                                sb.Append(fecha)
                            End If
                        End If
                    End If
                End If
            End If
            '
            If petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve <> "" Then
                If sb.Length = 0 Then
                    sb.Append("it.iamblogeve='")
                    sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve)
                    sb.Append("'")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.iamblogeve='")
                        sb.Append(petivi_aiplogevepaglist.vi_aiplogeve.iamblogeve)
                        sb.Append("'")
                    End If
                End If
            Else
                If sb.Length = 0 Then
                    sb.Append("(it.iamblogeve='MOVIL' or it.iamblogeve='WEB')")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and (it.iamblogeve='MOVIL' or it.iamblogeve='WEB')")
                    End If
                End If

            End If



            Dim respvi_aiplogevepaglist As New respvi_aiplogevepaglist
            respvi_aiplogevepaglist.pagvi_aiplogeve = petivi_aiplogevepaglist.pagvi_aiplogeve
            Dim skip = skip_paginacion(petivi_aiplogevepaglist.pagvi_aiplogeve.npagactual, petivi_aiplogevepaglist.pagvi_aiplogeve.npagtamano)

            If sb.ToString = "" Then
                respvi_aiplogevepaglist.lista_vi_aiplogeve = _db.vi_aiplogeve.OrderBy(petivi_aiplogevepaglist.pagvi_aiplogeve.xcamposord & " " & petivi_aiplogevepaglist.pagvi_aiplogeve.idirord).Skip(skip).Take(petivi_aiplogevepaglist.pagvi_aiplogeve.npagtamano).ToList
            Else
                respvi_aiplogevepaglist.lista_vi_aiplogeve = _db.vi_aiplogeve.Where(sb.ToString).OrderBy(petivi_aiplogevepaglist.pagvi_aiplogeve.xcamposord & " " & petivi_aiplogevepaglist.pagvi_aiplogeve.idirord).Skip(skip).Take(petivi_aiplogevepaglist.pagvi_aiplogeve.npagtamano).ToList
            End If
            '
            If (respvi_aiplogevepaglist.lista_vi_aiplogeve.Count > 0) Then
                Dim cant_entero_reg As Integer = 0
                cant_entero_reg = selvi_aiplogevexwheredinamicocount(sb)
                respvi_aiplogevepaglist.pagvi_aiplogeve.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aiplogevepaglist.pagvi_aiplogeve.npagtamano)
            Else
                respvi_aiplogevepaglist.pagvi_aiplogeve.npagcantidad = 0
                respvi_aiplogevepaglist.pagvi_aiplogeve.npagactual = 0
            End If

            Return respvi_aiplogevepaglist
        End Function

End Class
End Namespace
