Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.vistas.controlador
Public Class vi_aipinsajussinController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

        <HttpPost()> _
        Public Function selvi_aipinsajussinxid(idaipinsajussin As Decimal) As vi_aipinsajussin
            Dim vi_aipinsajussin As vi_aipinsajussin = (From p In _db.vi_aipinsajussin
                                            Where p.idaipinsajussin = idaipinsajussin
                                            Select p).SingleOrDefault
            Return vi_aipinsajussin
        End Function

	<HttpPost()> _
	Public Function selvi_aipinsajussin() As List(Of vi_aipinsajussin)
		Dim lista_vi_aipinsajussin As List(Of vi_aipinsajussin) = (From p In _db.vi_aipinsajussin
													Select p).ToList
		'
		Return lista_vi_aipinsajussin
	End Function

<HttpPost()> _
	Public Function selvi_aipinsajussinxwheredinamicopag(petivi_aipinsajussinpaglist as petivi_aipinsajussinpaglist) as respvi_aipinsajussinpaglist
		Dim sb As New StringBuilder("")
		'
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.itipoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.itipoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.itipoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
            If petivi_aipinsajussinpaglist.vi_aipinsajussin.idsegmanusuperit <> 0 Then
                If sb.Length = 0 Then
                    sb.Append("it.idsegmanusuperit=")
                    sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idsegmanusuperit))
                    sb.Append("")
                Else
                    If sb.Length > 0 Then
                        sb.Append(" and it.idsegmanusuperit=")
                        sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idsegmanusuperit))
                        sb.Append("")
                    End If
                End If
            End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedula <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedula='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedula)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedula='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedula)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnombres <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombres='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnombres)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombres='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnombres)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xapellidos <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xapellidos='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xapellidos)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xapellidos='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xapellidos)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnombrecompleto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecompleto='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnombrecompleto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecompleto='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnombrecompleto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedpropinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedpropinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedpropinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedpropinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedpropinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedsidoinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedsidoinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcedsidoinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xcedsidoinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xplacinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xplacinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xplacinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xsermotinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsermotinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsermotinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsermotinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsermotinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xsercarrinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsercarrinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsercarrinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnumpolinsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumpolinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnumpolinsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumpolinsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnumpolinsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnumsininsenc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnumsininsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnumsininsenc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnumsininsenc='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnumsininsenc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.isininsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.isininsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.isininsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.isininsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.isininsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.irecupinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irecupinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.irecupinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irecupinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.irecupinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.itercinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.itercinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.itercinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itercinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.itercinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnomaseginsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnomaseginsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnomaseginsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehver <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehver))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehver=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idaipmanvehver))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehver <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehver='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehver)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehver='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xnommanvehver)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.itipotransmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipotransmanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.itipotransmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipotransmanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.itipotransmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.itipomanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.itipomanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.itipomanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.iclasemanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iclasemanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.iclasemanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iclasemanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.iclasemanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.icolormanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.icolormanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.icolormanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.icolormanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.icolormanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xplacamanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xplacamanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xplacamanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xplacamanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xplacamanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xsercarrmanveh <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsercarrmanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsercarrmanveh)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsercarrmanveh='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsercarrmanveh)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xsucuinsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsucuinsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xsucuinsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.nkiloinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.nkiloinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinsajussin=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.nkiloinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.xdescinsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xdescinsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.xdescinsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.iestatinsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.iestatinsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajussin='")
				sb.Append(petivi_aipinsajussinpaglist.vi_aipinsajussin.iestatinsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petivi_aipinsajussinpaglist.vi_aipinsajussin.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petivi_aipinsajussinpaglist.vi_aipinsajussin.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respvi_aipinsajussinpaglist As New respvi_aipinsajussinpaglist
	respvi_aipinsajussinpaglist.pagvi_aipinsajussin = petivi_aipinsajussinpaglist.pagvi_aipinsajussin
	Dim skip = skip_paginacion(petivi_aipinsajussinpaglist.pagvi_aipinsajussin.npagactual, petivi_aipinsajussinpaglist.pagvi_aipinsajussin.npagtamano)
	
		If sb.ToString = "" Then
			respvi_aipinsajussinpaglist.lista_vi_aipinsajussin = _db.vi_aipinsajussin.OrderBy(petivi_aipinsajussinpaglist.pagvi_aipinsajussin.xcamposord & " "  & petivi_aipinsajussinpaglist.pagvi_aipinsajussin.idirord).Skip(skip).Take(petivi_aipinsajussinpaglist.pagvi_aipinsajussin.npagtamano).ToList
		Else
			respvi_aipinsajussinpaglist.lista_vi_aipinsajussin = _db.vi_aipinsajussin.Where(sb.ToString).OrderBy(petivi_aipinsajussinpaglist.pagvi_aipinsajussin.xcamposord & " "  & petivi_aipinsajussinpaglist.pagvi_aipinsajussin.idirord).Skip(skip).Take(petivi_aipinsajussinpaglist.pagvi_aipinsajussin.npagtamano).ToList
		End If
		'
		If (respvi_aipinsajussinpaglist.lista_vi_aipinsajussin.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selvi_aipinsajussinxwheredinamicocount(sb)
		respvi_aipinsajussinpaglist.pagvi_aipinsajussin.npagcantidad = cantidad_paginas(cant_entero_reg, respvi_aipinsajussinpaglist.pagvi_aipinsajussin.npagtamano)
		Else
		respvi_aipinsajussinpaglist.pagvi_aipinsajussin.npagcantidad = 0
		respvi_aipinsajussinpaglist.pagvi_aipinsajussin.npagactual = 0
		End If
	
		Return respvi_aipinsajussinpaglist
	End Function

	Public Function selvi_aipinsajussinxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.vi_aipinsajussin.count
	Else
	Return _db.vi_aipinsajussin.Where(sb.ToString).Count
	End If
	End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selvi_aipinsajussinxidinsenc(idaipinsenc As Decimal) As vi_aipinsajussin
            Dim vi_aipinsajussin As vi_aipinsajussin = (From p In _db.vi_aipinsajussin
                                            Where p.idaipinsenc = idaipinsenc
                                            Select p).SingleOrDefault
            Return vi_aipinsajussin
        End Function
End Class
End Namespace
