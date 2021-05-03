Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinssinController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinssinxid(idaipinssin As Decimal) As vi_aipinssin
            Dim vi_aipinssin As vi_aipinssin = (From p In _db.vi_aipinssin
                                            Where p.idaipinssin = idaipinssin
                                            Select p).SingleOrDefault
            Return vi_aipinssin
        End Function

	<HttpPost()> _
	Public Function selvi_aipinssin() As List(Of vi_aipinssin)
		Dim lista_vi_aipinssin As List(Of vi_aipinssin) = (From p In _db.vi_aipinssin
													Select p).ToList
		'
		Return lista_vi_aipinssin
	End Function

<HttpPost()> _
	Public Function selvi_aipinssinxwheredinamicopag(petivi_aipinssinpaglist as petivi_aipinssinpaglist) as respvi_aipinssinpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinssinpaglist.vi_aipinssin.idaipinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.idsegmanusuperit <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idsegmanusuperit))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanusuperit=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idsegmanusuperit))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xsercarrinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsercarrinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsercarrinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.nfactinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nfactinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.nfactinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nfactinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.nfactinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.irepuinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irepuinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.irepuinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irepuinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.irepuinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.imobrinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.imobrinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.imobrinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imobrinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.imobrinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnomaseginssin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnomaseginssin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnomaseginssin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xsercarrmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrmanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsercarrmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrmanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsercarrmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xsermotmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotmanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsermotmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotmanveh='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsermotmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xsucuinssin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsucuinssin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xsucuinssin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.nkiloinssin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.nkiloinssin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinssin=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.nkiloinssin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.xdescinssin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xdescinssin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.xdescinssin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.iestatinssin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.iestatinssin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinssin='")
				sb.Append(petivi_aipinssinpaglist.vi_aipinssin.iestatinssin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinssinpaglist.vi_aipinssin.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinssinpaglist.vi_aipinssin.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinssinpaglist As New respvi_aipinssinpaglist
	respvi_aipinssinpaglist.pagvi_aipinssin = petivi_aipinssinpaglist.pagvi_aipinssin
	Dim skip = skip_paginacion(petivi_aipinssinpaglist.pagvi_aipinssin.npagactual, petivi_aipinssinpaglist.pagvi_aipinssin.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinssinpaglist.lista_vi_aipinssin = _db.vi_aipinssin.OrderBy(petivi_aipinssinpaglist.pagvi_aipinssin.xcamposord & " "  & petivi_aipinssinpaglist.pagvi_aipinssin.idirord).Skip(skip).Take(petivi_aipinssinpaglist.pagvi_aipinssin.npagtamano).ToList
		Else
			respvi_aipinssinpaglist.lista_vi_aipinssin = _db.vi_aipinssin.Where(sb.ToString).OrderBy(petivi_aipinssinpaglist.pagvi_aipinssin.xcamposord & " "  & petivi_aipinssinpaglist.pagvi_aipinssin.idirord).Skip(skip).Take(petivi_aipinssinpaglist.pagvi_aipinssin.npagtamano).ToList
		End If
		'
		If (respvi_aipinssinpaglist.lista_vi_aipinssin.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinssinxwheredinamicocount(sb)
		respvi_aipinssinpaglist.pagvi_aipinssin.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinssinpaglist.pagvi_aipinssin.npagtamano)
		Else
		respvi_aipinssinpaglist.pagvi_aipinssin.npagcantidad = 0
		respvi_aipinssinpaglist.pagvi_aipinssin.npagactual = 0
		End If
	
		Return respvi_aipinssinpaglist
	End Function

	Public Function selvi_aipinssinxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinssin.count
	Else
	Return _db.vi_aipinssin.Where(sb.ToString).Count
	End If
	End Function


        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinssinxidinsenc(idaipinsenc As Decimal) As vi_aipinssin
            Dim vi_aipinssin As vi_aipinssin = (From p In _db.vi_aipinssin
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinssin
        End Function

End Class
End Namespace
