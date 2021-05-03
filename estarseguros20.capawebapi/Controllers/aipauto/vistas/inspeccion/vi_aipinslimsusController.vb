Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinslimsusController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinslimsusxid(idaipinslimsus As Decimal) As vi_aipinslimsus
            Dim vi_aipinslimsus As vi_aipinslimsus = (From p In _db.vi_aipinslimsus
                                            Where p.idaipinslimsus = idaipinslimsus
                                            Select p).SingleOrDefault
            Return vi_aipinslimsus
        End Function

	<HttpPost()> _
	Public Function selvi_aipinslimsus() As List(Of vi_aipinslimsus)
		Dim lista_vi_aipinslimsus As List(Of vi_aipinslimsus) = (From p In _db.vi_aipinslimsus
													Select p).ToList
		'
		Return lista_vi_aipinslimsus
	End Function

<HttpPost()> _
	Public Function selvi_aipinslimsusxwheredinamicopag(petivi_aipinslimsuspaglist as petivi_aipinslimsuspaglist) as respvi_aipinslimsuspaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipinslimsus))
				sb.Append("")
	        End If
	    End If
            End If
            '
            If petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipinsenc <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idaipinsenc=")
                    sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipinsenc))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idaipinsenc=")
                        sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipinsenc))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinslimsuspaglist.vi_aipinslimsus.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.nfactinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nfactinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.nfactinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nfactinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.nfactinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.irepuinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irepuinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.irepuinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irepuinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.irepuinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.imobrinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.imobrinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.imobrinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imobrinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.imobrinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xnomaseginslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xnomaseginslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xnomaseginslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xsucuinslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xsucuinslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xsucuinslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.nkiloinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.nkiloinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinslimsus=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.nkiloinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.xdescinslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xdescinslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.xdescinslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.iestatinslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.iestatinslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsus='")
				sb.Append(petivi_aipinslimsuspaglist.vi_aipinslimsus.iestatinslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinslimsuspaglist.vi_aipinslimsus.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinslimsuspaglist.vi_aipinslimsus.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinslimsuspaglist As New respvi_aipinslimsuspaglist
	respvi_aipinslimsuspaglist.pagvi_aipinslimsus = petivi_aipinslimsuspaglist.pagvi_aipinslimsus
	Dim skip = skip_paginacion(petivi_aipinslimsuspaglist.pagvi_aipinslimsus.npagactual, petivi_aipinslimsuspaglist.pagvi_aipinslimsus.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinslimsuspaglist.lista_vi_aipinslimsus = _db.vi_aipinslimsus.OrderBy(petivi_aipinslimsuspaglist.pagvi_aipinslimsus.xcamposord & " "  & petivi_aipinslimsuspaglist.pagvi_aipinslimsus.idirord).Skip(skip).Take(petivi_aipinslimsuspaglist.pagvi_aipinslimsus.npagtamano).ToList
		Else
			respvi_aipinslimsuspaglist.lista_vi_aipinslimsus = _db.vi_aipinslimsus.Where(sb.ToString).OrderBy(petivi_aipinslimsuspaglist.pagvi_aipinslimsus.xcamposord & " "  & petivi_aipinslimsuspaglist.pagvi_aipinslimsus.idirord).Skip(skip).Take(petivi_aipinslimsuspaglist.pagvi_aipinslimsus.npagtamano).ToList
		End If
		'
		If (respvi_aipinslimsuspaglist.lista_vi_aipinslimsus.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinslimsusxwheredinamicocount(sb)
		respvi_aipinslimsuspaglist.pagvi_aipinslimsus.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinslimsuspaglist.pagvi_aipinslimsus.npagtamano)
		Else
		respvi_aipinslimsuspaglist.pagvi_aipinslimsus.npagcantidad = 0
		respvi_aipinslimsuspaglist.pagvi_aipinslimsus.npagactual = 0
		End If
	
		Return respvi_aipinslimsuspaglist
	End Function

	Public Function selvi_aipinslimsusxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinslimsus.count
	Else
	Return _db.vi_aipinslimsus.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinslimsusxidinsenc(idaipinsenc As Decimal) As vi_aipinslimsus
            Dim vi_aipinslimsus As vi_aipinslimsus = (From p In _db.vi_aipinslimsus
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinslimsus
        End Function
End Class
End Namespace
