Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmandispController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmandispxid(idaipmandisp As Decimal) As aipmandisp
		Dim aipmandisp As aipmandisp = (From p In _db.aipmandisp
										Where p.idaipmandisp = idaipmandisp
										Select p).SingleOrDefault
		Return aipmandisp
	End Function

	<HttpPost()> _
	Public Function selaipmandisp() As List(Of aipmandisp)
            Dim lista_aipmandisp As List(Of aipmandisp) = (From p In _db.aipmandisp
                                                           Where p.idaipmandisp > 0
                                                        Select p).ToList
		'
		Return lista_aipmandisp
	End Function

<HttpPost()> _
	Public Function selaipmandispxwheredinamicopag(petiaipmandisppaglist as petiaipmandisppaglist) as respaipmandisppaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmandisppaglist.aipmandisp.idaipmandisp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmandisp=")
				sb.Append(valor_entero(petiaipmandisppaglist.aipmandisp.idaipmandisp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmandisp=")
				sb.Append(valor_entero(petiaipmandisppaglist.aipmandisp.idaipmandisp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmandisppaglist.aipmandisp.xcodimmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xcodimmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xcodimmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xcodimmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xcodimmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmandisppaglist.aipmandisp.xfabmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xfabmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xfabmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xfabmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xfabmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmandisppaglist.aipmandisp.xmodmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xmodmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xmodmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xmodmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xmodmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmandisppaglist.aipmandisp.itipomandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipomandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.itipomandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipomandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.itipomandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmandisppaglist.aipmandisp.xdescmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xdescmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.xdescmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmandisppaglist.aipmandisp.iestatmandisp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.iestatmandisp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmandisp='")
				sb.Append(petiaipmandisppaglist.aipmandisp.iestatmandisp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmandisppaglist.aipmandisp.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmandisppaglist.aipmandisp.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmandisppaglist.aipmandisp.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmandisppaglist As New respaipmandisppaglist
	respaipmandisppaglist.pagaipmandisp = petiaipmandisppaglist.pagaipmandisp
	Dim skip = skip_paginacion(petiaipmandisppaglist.pagaipmandisp.npagactual, petiaipmandisppaglist.pagaipmandisp.npagtamano)
	
		If sb.ToString = "" Then
			respaipmandisppaglist.lista_aipmandisp = _db.aipmandisp.OrderBy(petiaipmandisppaglist.pagaipmandisp.xcamposord & " "  & petiaipmandisppaglist.pagaipmandisp.idirord).Skip(skip).Take(petiaipmandisppaglist.pagaipmandisp.npagtamano).ToList
		Else
			respaipmandisppaglist.lista_aipmandisp = _db.aipmandisp.Where(sb.ToString).OrderBy(petiaipmandisppaglist.pagaipmandisp.xcamposord & " "  & petiaipmandisppaglist.pagaipmandisp.idirord).Skip(skip).Take(petiaipmandisppaglist.pagaipmandisp.npagtamano).ToList
		End If
		'
		If (respaipmandisppaglist.lista_aipmandisp.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmandispxwheredinamicocount(sb)
		respaipmandisppaglist.pagaipmandisp.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmandisppaglist.pagaipmandisp.npagtamano)
		Else
		respaipmandisppaglist.pagaipmandisp.npagcantidad = 0
		respaipmandisppaglist.pagaipmandisp.npagactual = 0
		End If
	
		Return respaipmandisppaglist
	End Function

	Public Function selaipmandispxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmandisp.count
	Else
	Return _db.aipmandisp.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmandisp(aipmandisp as aipmandisp) as respopera
		Try
	
	Dim param1 As New SqlClient.SqlParameter
	param1.SqlDbType = SqlDbType.VarChar
	param1.Size = 20
	param1.Value = "insertar"
	param1.ParameterName = "p_ioperacion"
	
	Dim param2 As New SqlClient.SqlParameter
	param2.SqlDbType = SqlDbType.Decimal  
	param2.Precision = 18
	 param2.Scale = 0
	param2.Value = 0
	 param2.ParameterName = "p_idsegmanusulog"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "aipauto"
	param3.ParameterName = "p_xnombrecortolog"
	
	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
	param4.SqlDbType = SqlDbType.VarChar
	param4.Size = 1
	param4.ParameterName = "p_irespuesta"
	param4.Direction = ParameterDirection.Output
	
	Dim param5 As New SqlClient.SqlParameter
	param5.SqlDbType = SqlDbType.VarChar
	param5.Size = 300
	param5.ParameterName = "p_xmsjusuario"
	param5.Direction = ParameterDirection.Output
	
	Dim param6 As New SqlClient.SqlParameter
	param6.SqlDbType = SqlDbType.VarChar
	param6.Size = 300
	param6.ParameterName = "p_xmsjtecnico"
	param6.Direction = ParameterDirection.Output
	
	Dim param7 As New SqlClient.SqlParameter
	param7.SqlDbType = SqlDbType.VarChar
	param7.Size = 300
	param7.ParameterName = "p_coderrorlog"
	param7.Direction = ParameterDirection.Output
	
'Paramestros de la tabla
	
	Dim param8 As New SqlClient.SqlParameter
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = 0
	param8.ParameterName = "p_idaipmandisp"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmandisp.xcodimmandisp IsNot Nothing Then
	param9.Value = aipmandisp.xcodimmandisp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xcodimmandisp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmandisp.xfabmandisp IsNot Nothing Then
	param10.Value = aipmandisp.xfabmandisp
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xfabmandisp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmandisp.xmodmandisp IsNot Nothing Then
	param11.Value = aipmandisp.xmodmandisp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xmodmandisp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmandisp.itipomandisp IsNot Nothing Then
	param12.Value = aipmandisp.itipomandisp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itipomandisp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipmandisp.xdescmandisp IsNot Nothing Then
	param13.Value = aipmandisp.xdescmandisp
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescmandisp"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipmandisp.iestatmandisp IsNot Nothing Then
	param14.Value = aipmandisp.iestatmandisp
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatmandisp"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmandisp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmandisp output,@p_xcodimmandisp,@p_xfabmandisp,@p_xmodmandisp,@p_itipomandisp,@p_xdescmandisp,@p_iestatmandisp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
	Dim respopera As New respopera
	respopera.irespuesta = param4.Value
	respopera.xmsjusuario = param5.Value
	respopera.xmsjtecnico = param6.Value
	If IsNumeric(param8.Value) = True Then
	respopera.id = Int(param8.Value)
	End If
	
			Return respopera
	
		Catch ex As Exception
	
	Dim respopera As New respopera
	respopera.irespuesta = 0
	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
	respopera.xmsjtecnico = ex.Message
	Return respopera
		End Try
	End Function

	<HttpPost()> _
	Public Function modaipmandisp(aipmandisp as aipmandisp) as respopera
		Try
	
	Dim param1 As New SqlClient.SqlParameter
	param1.SqlDbType = SqlDbType.VarChar
	param1.Size = 20
	param1.Value = "actualizar"
	param1.ParameterName = "p_ioperacion"
	
	Dim param2 As New SqlClient.SqlParameter
	param2.SqlDbType = SqlDbType.Decimal  
	param2.Precision = 18
	 param2.Scale = 0
	param2.Value  = 0
	 param2.ParameterName = "p_idsegmanusulog"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "aipauto"
	param3.ParameterName = "p_xnombrecortolog"
	
	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
	param4.SqlDbType = SqlDbType.VarChar
	param4.Size = 1
	param4.ParameterName = "p_irespuesta"
	param4.Direction = ParameterDirection.Output
	
	Dim param5 As New SqlClient.SqlParameter
	param5.SqlDbType = SqlDbType.VarChar
	param5.Size = 300
	param5.ParameterName = "p_xmsjusuario"
	param5.Direction = ParameterDirection.Output
	
	Dim param6 As New SqlClient.SqlParameter
	param6.SqlDbType = SqlDbType.VarChar
	param6.Size = 300
	param6.ParameterName = "p_xmsjtecnico"
	param6.Direction = ParameterDirection.Output
	
	Dim param7 As New SqlClient.SqlParameter
	param7.SqlDbType = SqlDbType.VarChar
	param7.Size = 300
	param7.ParameterName = "p_coderrorlog"
	param7.Direction = ParameterDirection.Output
	
'Paramestros de la tabla
	
	Dim param8 As New SqlClient.SqlParameter
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = aipmandisp.idaipmandisp
	param8.ParameterName = "p_idaipmandisp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmandisp.xcodimmandisp IsNot Nothing Then
	param9.Value = aipmandisp.xcodimmandisp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xcodimmandisp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmandisp.xfabmandisp IsNot Nothing Then
	param10.Value = aipmandisp.xfabmandisp
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xfabmandisp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmandisp.xmodmandisp IsNot Nothing Then
	param11.Value = aipmandisp.xmodmandisp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xmodmandisp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmandisp.itipomandisp IsNot Nothing Then
	param12.Value = aipmandisp.itipomandisp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itipomandisp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipmandisp.xdescmandisp IsNot Nothing Then
	param13.Value = aipmandisp.xdescmandisp
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescmandisp"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipmandisp.iestatmandisp IsNot Nothing Then
	param14.Value = aipmandisp.iestatmandisp
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatmandisp"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipmandisp.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmandisp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmandisp output,@p_xcodimmandisp,@p_xfabmandisp,@p_xmodmandisp,@p_itipomandisp,@p_xdescmandisp,@p_iestatmandisp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
	Dim respopera As New respopera
	respopera.irespuesta = param4.Value
	respopera.xmsjusuario = param5.Value
	respopera.xmsjtecnico = param6.Value
	If IsNumeric(param8.Value) = True Then
	respopera.id = Int(param8.Value)
	End If
	
			Return respopera
	
		Catch ex As Exception
	
	Dim respopera As New respopera
	respopera.irespuesta = 0
	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
	respopera.xmsjtecnico = ex.Message
	Return respopera
		End Try
	End Function

	<HttpPost()> _
	Public Function eliaipmandisp(aipmandisp as aipmandisp) as respopera
		Try
	
	Dim param1 As New SqlClient.SqlParameter
	param1.SqlDbType = SqlDbType.VarChar
	param1.Size = 20
	param1.Value = "eliminar"
	param1.ParameterName = "p_ioperacion"
	
	Dim param2 As New SqlClient.SqlParameter
	param2.SqlDbType = SqlDbType.Decimal  
	param2.Precision = 18
	 param2.Scale = 0
	param2.Value = 0
	 param2.ParameterName = "p_idsegmanusulog"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "aipauto"
	param3.ParameterName = "p_xnombrecortolog"
	
	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
	param4.SqlDbType = SqlDbType.VarChar
	param4.Size = 1
	param4.ParameterName = "p_irespuesta"
	param4.Direction = ParameterDirection.Output
	
	Dim param5 As New SqlClient.SqlParameter
	param5.SqlDbType = SqlDbType.VarChar
	param5.Size = 300
	param5.ParameterName = "p_xmsjusuario"
	param5.Direction = ParameterDirection.Output
	
	Dim param6 As New SqlClient.SqlParameter
	param6.SqlDbType = SqlDbType.VarChar
	param6.Size = 300
	param6.ParameterName = "p_xmsjtecnico"
	param6.Direction = ParameterDirection.Output
	
	Dim param7 As New SqlClient.SqlParameter
	param7.SqlDbType = SqlDbType.VarChar
	param7.Size = 300
	param7.ParameterName = "p_coderrorlog"
	param7.Direction = ParameterDirection.Output
	
'Paramestros de la tabla
	
	Dim param8 As New SqlClient.SqlParameter
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = aipmandisp.idaipmandisp
	param8.ParameterName = "p_idaipmandisp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmandisp.xcodimmandisp IsNot Nothing Then
	param9.Value = aipmandisp.xcodimmandisp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xcodimmandisp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmandisp.xfabmandisp IsNot Nothing Then
	param10.Value = aipmandisp.xfabmandisp
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xfabmandisp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmandisp.xmodmandisp IsNot Nothing Then
	param11.Value = aipmandisp.xmodmandisp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xmodmandisp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmandisp.itipomandisp IsNot Nothing Then
	param12.Value = aipmandisp.itipomandisp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itipomandisp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipmandisp.xdescmandisp IsNot Nothing Then
	param13.Value = aipmandisp.xdescmandisp
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescmandisp"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipmandisp.iestatmandisp IsNot Nothing Then
	param14.Value = aipmandisp.iestatmandisp
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatmandisp"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipmandisp.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmandisp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmandisp output,@p_xcodimmandisp,@p_xfabmandisp,@p_xmodmandisp,@p_itipomandisp,@p_xdescmandisp,@p_iestatmandisp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
	Dim respopera As New respopera
	respopera.irespuesta = param4.Value
	respopera.xmsjusuario = param5.Value
	respopera.xmsjtecnico = param6.Value
	If IsNumeric(param8.Value) = True Then
	respopera.id = Int(param8.Value)
	End If
	
			Return respopera
	
		Catch ex As Exception
	
	Dim respopera As New respopera
	respopera.irespuesta = 0
	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
	respopera.xmsjtecnico = ex.Message
	Return respopera
		End Try
	End Function

	<HttpPost()> _
	Public Function eliaipmandisp(idaipmandisp as decimal) as respopera
		Try
	
	Dim param1 As New SqlClient.SqlParameter
	param1.SqlDbType = SqlDbType.VarChar
	param1.Size = 20
	param1.Value = "eliminar"
	param1.ParameterName = "p_ioperacion"
	
	Dim param2 As New SqlClient.SqlParameter
	param2.SqlDbType = SqlDbType.Decimal  
	param2.Precision = 18
	 param2.Scale = 0
	param2.Value = 0
	 param2.ParameterName = "p_idsegmanusulog"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "aipauto"
	param3.ParameterName = "p_xnombrecortolog"
	
	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
	param4.SqlDbType = SqlDbType.VarChar
	param4.Size = 1
	param4.ParameterName = "p_irespuesta"
	param4.Direction = ParameterDirection.Output
	
	Dim param5 As New SqlClient.SqlParameter
	param5.SqlDbType = SqlDbType.VarChar
	param5.Size = 300
	param5.ParameterName = "p_xmsjusuario"
	param5.Direction = ParameterDirection.Output
	
	Dim param6 As New SqlClient.SqlParameter
	param6.SqlDbType = SqlDbType.VarChar
	param6.Size = 300
	param6.ParameterName = "p_xmsjtecnico"
	param6.Direction = ParameterDirection.Output
	
	Dim param7 As New SqlClient.SqlParameter
	param7.SqlDbType = SqlDbType.VarChar
	param7.Size = 300
	param7.ParameterName = "p_coderrorlog"
	param7.Direction = ParameterDirection.Output
	
'Paramestros de la tabla
	
	Dim param8 As New SqlClient.SqlParameter
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = idaipmandisp
	param8.ParameterName = "p_idaipmandisp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xcodimmandisp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	param10.Value = "
	param10.ParameterName = "p_xfabmandisp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	param11.Value = "
	param11.ParameterName = "p_xmodmandisp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	param12.Value = "
	param12.ParameterName = "p_itipomandisp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = "
	param13.ParameterName = "p_xdescmandisp"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	param14.Value = "
	param14.ParameterName = "p_iestatmandisp"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmandisp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmandisp output,@p_xcodimmandisp,@p_xfabmandisp,@p_xmodmandisp,@p_itipomandisp,@p_xdescmandisp,@p_iestatmandisp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
	Dim respopera As New respopera
	respopera.irespuesta = param4.Value
	respopera.xmsjusuario = param5.Value
	respopera.xmsjtecnico = param6.Value
	If IsNumeric(param8.Value) = True Then
	respopera.id = Int(param8.Value)
	End If
	
			Return respopera
	
		Catch ex As Exception
	
	Dim respopera As New respopera
	respopera.irespuesta = 0
	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
	respopera.xmsjtecnico = ex.Message
	Return respopera
		End Try
	End Function

	<HttpPost()> _
	Public Function actaipmandisp(aipmandisp as aipmandisp) as respopera
		Try
	
	Dim param1 As New SqlClient.SqlParameter
	param1.SqlDbType = SqlDbType.VarChar
	param1.Size = 20
	param1.Value = "activar"
	param1.ParameterName = "p_ioperacion"
	
	Dim param2 As New SqlClient.SqlParameter
	param2.SqlDbType = SqlDbType.Decimal  
	param2.Precision = 18
	 param2.Scale = 0
	param2.Value = 0
	 param2.ParameterName = "p_idsegmanusulog"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "aipauto"
	param3.ParameterName = "p_xnombrecortolog"
	
	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
	param4.SqlDbType = SqlDbType.VarChar
	param4.Size = 1
	param4.ParameterName = "p_irespuesta"
	param4.Direction = ParameterDirection.Output
	
	Dim param5 As New SqlClient.SqlParameter
	param5.SqlDbType = SqlDbType.VarChar
	param5.Size = 300
	param5.ParameterName = "p_xmsjusuario"
	param5.Direction = ParameterDirection.Output
	
	Dim param6 As New SqlClient.SqlParameter
	param6.SqlDbType = SqlDbType.VarChar
	param6.Size = 300
	param6.ParameterName = "p_xmsjtecnico"
	param6.Direction = ParameterDirection.Output
	
	Dim param7 As New SqlClient.SqlParameter
	param7.SqlDbType = SqlDbType.VarChar
	param7.Size = 300
	param7.ParameterName = "p_coderrorlog"
	param7.Direction = ParameterDirection.Output
	
'Paramestros de la tabla
	
	Dim param8 As New SqlClient.SqlParameter
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = aipmandisp.idaipmandisp
	param8.ParameterName = "p_idaipmandisp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmandisp.xcodimmandisp IsNot Nothing Then
	param9.Value = aipmandisp.xcodimmandisp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xcodimmandisp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmandisp.xfabmandisp IsNot Nothing Then
	param10.Value = aipmandisp.xfabmandisp
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xfabmandisp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmandisp.xmodmandisp IsNot Nothing Then
	param11.Value = aipmandisp.xmodmandisp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xmodmandisp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmandisp.itipomandisp IsNot Nothing Then
	param12.Value = aipmandisp.itipomandisp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itipomandisp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipmandisp.xdescmandisp IsNot Nothing Then
	param13.Value = aipmandisp.xdescmandisp
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescmandisp"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipmandisp.iestatmandisp IsNot Nothing Then
	param14.Value = aipmandisp.iestatmandisp
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatmandisp"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipmandisp.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmandisp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmandisp output,@p_xcodimmandisp,@p_xfabmandisp,@p_xmodmandisp,@p_itipomandisp,@p_xdescmandisp,@p_iestatmandisp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
	Dim respopera As New respopera
	respopera.irespuesta = param4.Value
	respopera.xmsjusuario = param5.Value
	respopera.xmsjtecnico = param6.Value
	If IsNumeric(param8.Value) = True Then
	respopera.id = Int(param8.Value)
	End If
	
			Return respopera
	
		Catch ex As Exception
	
	Dim respopera As New respopera
	respopera.irespuesta = 0
	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
	respopera.xmsjtecnico = ex.Message
	Return respopera
		End Try
	End Function

	<HttpPost()> _
	Public Function desaipmandisp(aipmandisp as aipmandisp) as respopera
		Try
	
	Dim param1 As New SqlClient.SqlParameter
	param1.SqlDbType = SqlDbType.VarChar
	param1.Size = 20
	param1.Value = "desactivar"
	param1.ParameterName = "p_ioperacion"
	
	Dim param2 As New SqlClient.SqlParameter
	param2.SqlDbType = SqlDbType.Decimal  
	param2.Precision = 18
	 param2.Scale = 0
	param2.Value = 0
	 param2.ParameterName = "p_idsegmanusulog"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "aipauto"
	param3.ParameterName = "p_xnombrecortolog"
	
	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
	param4.SqlDbType = SqlDbType.VarChar
	param4.Size = 1
	param4.ParameterName = "p_irespuesta"
	param4.Direction = ParameterDirection.Output
	
	Dim param5 As New SqlClient.SqlParameter
	param5.SqlDbType = SqlDbType.VarChar
	param5.Size = 300
	param5.ParameterName = "p_xmsjusuario"
	param5.Direction = ParameterDirection.Output
	
	Dim param6 As New SqlClient.SqlParameter
	param6.SqlDbType = SqlDbType.VarChar
	param6.Size = 300
	param6.ParameterName = "p_xmsjtecnico"
	param6.Direction = ParameterDirection.Output
	
	Dim param7 As New SqlClient.SqlParameter
	param7.SqlDbType = SqlDbType.VarChar
	param7.Size = 300
	param7.ParameterName = "p_coderrorlog"
	param7.Direction = ParameterDirection.Output
	
'Paramestros de la tabla
	
	Dim param8 As New SqlClient.SqlParameter
	param8.SqlDbType = SqlDbType.decimal
	param8.Precision = 18
	param8.Scale = 0
	param8.Value = aipmandisp.idaipmandisp
	param8.ParameterName = "p_idaipmandisp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmandisp.xcodimmandisp IsNot Nothing Then
	param9.Value = aipmandisp.xcodimmandisp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xcodimmandisp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmandisp.xfabmandisp IsNot Nothing Then
	param10.Value = aipmandisp.xfabmandisp
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xfabmandisp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmandisp.xmodmandisp IsNot Nothing Then
	param11.Value = aipmandisp.xmodmandisp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xmodmandisp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmandisp.itipomandisp IsNot Nothing Then
	param12.Value = aipmandisp.itipomandisp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itipomandisp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipmandisp.xdescmandisp IsNot Nothing Then
	param13.Value = aipmandisp.xdescmandisp
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescmandisp"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipmandisp.iestatmandisp IsNot Nothing Then
	param14.Value = aipmandisp.iestatmandisp
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatmandisp"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipmandisp.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmandisp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmandisp output,@p_xcodimmandisp,@p_xfabmandisp,@p_xmodmandisp,@p_itipomandisp,@p_xdescmandisp,@p_iestatmandisp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
	Dim respopera As New respopera
	respopera.irespuesta = param4.Value
	respopera.xmsjusuario = param5.Value
	respopera.xmsjtecnico = param6.Value
	If IsNumeric(param8.Value) = True Then
	respopera.id = Int(param8.Value)
	End If
	
			Return respopera
	
		Catch ex As Exception
	
	Dim respopera As New respopera
	respopera.irespuesta = 0
	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
	respopera.xmsjtecnico = ex.Message
	Return respopera
		End Try
	End Function

    End Class
End Namespace
