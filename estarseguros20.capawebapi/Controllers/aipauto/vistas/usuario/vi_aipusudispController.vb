Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.usuario
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipusudispController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipusudispxid(idaipusudisp As Decimal) As vi_aipusudisp
            Dim vi_aipusudisp As vi_aipusudisp = (From p In _db.vi_aipusudisp
                                            Where p.idaipusudisp = idaipusudisp
                                            Select p).SingleOrDefault
            Return vi_aipusudisp
        End Function

	<HttpPost()> _
	Public Function selvi_aipusudisp() As List(Of vi_aipusudisp)
		Dim lista_vi_aipusudisp As List(Of vi_aipusudisp) = (From p In _db.vi_aipusudisp
													Select p).ToList
		'
		Return lista_vi_aipusudisp
	End Function

<HttpPost()> _
	Public Function selvi_aipusudispxwheredinamicopag(petivi_aipusudisppaglist as petivi_aipusudisppaglist) as respvi_aipusudisppaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipusudisppaglist.vi_aipusudisp.idaipusudisp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipusudisp=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idaipusudisp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipusudisp=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idaipusudisp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.idsegmanusu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idsegmanusu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusu=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idsegmanusu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.fnacimiento > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fnacimiento >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipusudisppaglist.vi_aipusudisp.fnacimiento)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fnacimiento >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petivi_aipusudisppaglist.vi_aipusudisp.fnacimiento)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xsexo <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsexo='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xsexo)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsexo='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xsexo)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.idaipmandisp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmandisp=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idaipmandisp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmandisp=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idaipmandisp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xcodimmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcodimmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xcodimmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcodimmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xcodimmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xfabmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xfabmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xfabmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xfabmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xfabmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xmodmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xmodmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xmodmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xmodmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xmodmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.itipomandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.itipomandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.itipomandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.xdescmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xdescmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.xdescmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.iestatmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.iestatmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmandisp='")
				sb.Append(petivi_aipusudisppaglist.vi_aipusudisp.iestatmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipusudisppaglist.vi_aipusudisp.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipusudisppaglist.vi_aipusudisp.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipusudisppaglist As New respvi_aipusudisppaglist
	respvi_aipusudisppaglist.pagvi_aipusudisp = petivi_aipusudisppaglist.pagvi_aipusudisp
	Dim skip = skip_paginacion(petivi_aipusudisppaglist.pagvi_aipusudisp.npagactual, petivi_aipusudisppaglist.pagvi_aipusudisp.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipusudisppaglist.lista_vi_aipusudisp = _db.vi_aipusudisp.OrderBy(petivi_aipusudisppaglist.pagvi_aipusudisp.xcamposord & " "  & petivi_aipusudisppaglist.pagvi_aipusudisp.idirord).Skip(skip).Take(petivi_aipusudisppaglist.pagvi_aipusudisp.npagtamano).ToList
		Else
			respvi_aipusudisppaglist.lista_vi_aipusudisp = _db.vi_aipusudisp.Where(sb.ToString).OrderBy(petivi_aipusudisppaglist.pagvi_aipusudisp.xcamposord & " "  & petivi_aipusudisppaglist.pagvi_aipusudisp.idirord).Skip(skip).Take(petivi_aipusudisppaglist.pagvi_aipusudisp.npagtamano).ToList
		End If
		'
		If (respvi_aipusudisppaglist.lista_vi_aipusudisp.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipusudispxwheredinamicocount(sb)
		respvi_aipusudisppaglist.pagvi_aipusudisp.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipusudisppaglist.pagvi_aipusudisp.npagtamano)
		Else
		respvi_aipusudisppaglist.pagvi_aipusudisp.npagcantidad = 0
		respvi_aipusudisppaglist.pagvi_aipusudisp.npagactual = 0
		End If
	
		Return respvi_aipusudisppaglist
	End Function

	Public Function selvi_aipusudispxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipusudisp.count
	Else
	Return _db.vi_aipusudisp.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selxcodimmandispxidsegmanusu(idsegmanusu As Decimal) As String
            Dim xcodimmandisp2 As String = (From p In _db.vi_aipusudisp
                                            Where p.idsegmanusu = idsegmanusu
                                            Select p.xcodimmandisp).SingleOrDefault
            Return xcodimmandisp2
        End Function

End Class
End Namespace
