Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajusanexController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajusanexxid(idaipinsajusanex As Decimal) As vi_aipinsajusanex
            Dim vi_aipinsajusanex As vi_aipinsajusanex = (From p In _db.vi_aipinsajusanex
                                            Where p.idaipinsajusanex = idaipinsajusanex
                                            Select p).SingleOrDefault
            Return vi_aipinsajusanex
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsajusanex() As List(Of vi_aipinsajusanex)
		Dim lista_vi_aipinsajusanex As List(Of vi_aipinsajusanex) = (From p In _db.vi_aipinsajusanex
													Select p).ToList
		'
		Return lista_vi_aipinsajusanex
	End Function

<HttpPost()> _
	Public Function selvi_aipinsajusanexxwheredinamicopag(petivi_aipinsajusanexpaglist as petivi_aipinsajusanexpaglist) as respvi_aipinsajusanexpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsercarrinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsercarrinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsercarrinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.isininsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.isininsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.isininsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.isininsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.isininsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.irecupinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irecupinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.irecupinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irecupinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.irecupinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itercinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.itercinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itercinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itercinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itercinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnomaseginsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnomaseginsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnomaseginsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsucuinsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsucuinsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xsucuinsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.nkiloinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.nkiloinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinsajusanex=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.nkiloinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xdescinsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xdescinsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.xdescinsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.iestatinsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.iestatinsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajusanex='")
				sb.Append(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.iestatinsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajusanexpaglist.vi_aipinsajusanex.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajusanexpaglist As New respvi_aipinsajusanexpaglist
	respvi_aipinsajusanexpaglist.pagvi_aipinsajusanex = petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex
	Dim skip = skip_paginacion(petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagactual, petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajusanexpaglist.lista_vi_aipinsajusanex = _db.vi_aipinsajusanex.OrderBy(petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.xcamposord & " "  & petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.idirord).Skip(skip).Take(petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagtamano).ToList
		Else
			respvi_aipinsajusanexpaglist.lista_vi_aipinsajusanex = _db.vi_aipinsajusanex.Where(sb.ToString).OrderBy(petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.xcamposord & " "  & petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.idirord).Skip(skip).Take(petivi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajusanexpaglist.lista_vi_aipinsajusanex.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajusanexxwheredinamicocount(sb)
		respvi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagtamano)
		Else
		respvi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagcantidad = 0
		respvi_aipinsajusanexpaglist.pagvi_aipinsajusanex.npagactual = 0
		End If
	
		Return respvi_aipinsajusanexpaglist
	End Function

	Public Function selvi_aipinsajusanexxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajusanex.count
	Else
	Return _db.vi_aipinsajusanex.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsajusanexxidinsenc(idaipinsenc As Decimal) As vi_aipinsajusanex
            Dim vi_aipinsajusanex As vi_aipinsajusanex = (From p In _db.vi_aipinsajusanex
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinsajusanex
        End Function
End Class
End Namespace
