Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsajussinmobrController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsajussinmobrxid(idaipinsajussinmobr As Decimal) As aipinsajussinmobr
		Dim aipinsajussinmobr As aipinsajussinmobr = (From p In _db.aipinsajussinmobr
										Where p.idaipinsajussinmobr = idaipinsajussinmobr
										Select p).SingleOrDefault
		Return aipinsajussinmobr
	End Function

	<HttpPost()> _
	Public Function selaipinsajussinmobr() As List(Of aipinsajussinmobr)
		Dim lista_aipinsajussinmobr As List(Of aipinsajussinmobr) = (From p In _db.aipinsajussinmobr
													Select p).ToList
		'
		Return lista_aipinsajussinmobr
	End Function

<HttpPost()> _
	Public Function selaipinsajussinmobrxwheredinamicopag(petiaipinsajussinmobrpaglist as petiaipinsajussinmobrpaglist) as respaipinsajussinmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipinsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussinmobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipinsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussinmobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipinsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.ncantinsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajussinmobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.ncantinsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajussinmobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.ncantinsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.nprecfininsajussinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininsajussinmobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.nprecfininsajussinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininsajussinmobr=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.nprecfininsajussinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.xdescinsajussinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajussinmobr='")
				sb.Append(petiaipinsajussinmobrpaglist.aipinsajussinmobr.xdescinsajussinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajussinmobr='")
				sb.Append(petiaipinsajussinmobrpaglist.aipinsajussinmobr.xdescinsajussinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.iestatinsajussinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajussinmobr='")
				sb.Append(petiaipinsajussinmobrpaglist.aipinsajussinmobr.iestatinsajussinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajussinmobr='")
				sb.Append(petiaipinsajussinmobrpaglist.aipinsajussinmobr.iestatinsajussinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinmobrpaglist.aipinsajussinmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajussinmobrpaglist.aipinsajussinmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsajussinmobrpaglist As New respaipinsajussinmobrpaglist
	respaipinsajussinmobrpaglist.pagaipinsajussinmobr = petiaipinsajussinmobrpaglist.pagaipinsajussinmobr
	Dim skip = skip_paginacion(petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagactual, petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsajussinmobrpaglist.lista_aipinsajussinmobr = _db.aipinsajussinmobr.OrderBy(petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.xcamposord & " "  & petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.idirord).Skip(skip).Take(petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagtamano).ToList
		Else
			respaipinsajussinmobrpaglist.lista_aipinsajussinmobr = _db.aipinsajussinmobr.Where(sb.ToString).OrderBy(petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.xcamposord & " "  & petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.idirord).Skip(skip).Take(petiaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagtamano).ToList
		End If
		'
		If (respaipinsajussinmobrpaglist.lista_aipinsajussinmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsajussinmobrxwheredinamicocount(sb)
		respaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagtamano)
		Else
		respaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagcantidad = 0
		respaipinsajussinmobrpaglist.pagaipinsajussinmobr.npagactual = 0
		End If
	
		Return respaipinsajussinmobrpaglist
	End Function

	Public Function selaipinsajussinmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsajussinmobr.count
	Else
	Return _db.aipinsajussinmobr.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsajussinmobr(aipinsajussinmobr as aipinsajussinmobr) as respopera
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
	param8.ParameterName = "p_idaipinsajussinmobr"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinmobr.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinmobr.ncantinsajussinmobr
	param11.ParameterName = "p_ncantinsajussinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinmobr.nprecfininsajussinmobr
	param12.ParameterName = "p_nprecfininsajussinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinmobr.xdescinsajussinmobr IsNot Nothing Then
	param13.Value = aipinsajussinmobr.xdescinsajussinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinmobr.iestatinsajussinmobr IsNot Nothing Then
	param14.Value = aipinsajussinmobr.iestatinsajussinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinmobr output,@p_idaipinsajussin,@p_idaipbaremobr,@p_ncantinsajussinmobr,@p_nprecfininsajussinmobr,@p_xdescinsajussinmobr,@p_iestatinsajussinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinsajussinmobr(aipinsajussinmobr as aipinsajussinmobr) as respopera
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
	param8.Value = aipinsajussinmobr.idaipinsajussinmobr
	param8.ParameterName = "p_idaipinsajussinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinmobr.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinmobr.ncantinsajussinmobr
	param11.ParameterName = "p_ncantinsajussinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinmobr.nprecfininsajussinmobr
	param12.ParameterName = "p_nprecfininsajussinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinmobr.xdescinsajussinmobr IsNot Nothing Then
	param13.Value = aipinsajussinmobr.xdescinsajussinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinmobr.iestatinsajussinmobr IsNot Nothing Then
	param14.Value = aipinsajussinmobr.iestatinsajussinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinmobr output,@p_idaipinsajussin,@p_idaipbaremobr,@p_ncantinsajussinmobr,@p_nprecfininsajussinmobr,@p_xdescinsajussinmobr,@p_iestatinsajussinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajussinmobr(aipinsajussinmobr as aipinsajussinmobr) as respopera
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
	param8.Value = aipinsajussinmobr.idaipinsajussinmobr
	param8.ParameterName = "p_idaipinsajussinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinmobr.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinmobr.ncantinsajussinmobr
	param11.ParameterName = "p_ncantinsajussinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinmobr.nprecfininsajussinmobr
	param12.ParameterName = "p_nprecfininsajussinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinmobr.xdescinsajussinmobr IsNot Nothing Then
	param13.Value = aipinsajussinmobr.xdescinsajussinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinmobr.iestatinsajussinmobr IsNot Nothing Then
	param14.Value = aipinsajussinmobr.iestatinsajussinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinmobr output,@p_idaipinsajussin,@p_idaipbaremobr,@p_ncantinsajussinmobr,@p_nprecfininsajussinmobr,@p_xdescinsajussinmobr,@p_iestatinsajussinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajussinmobr(idaipinsajussinmobr as decimal) as respopera
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
	param8.Value = idaipinsajussinmobr
	param8.ParameterName = "p_idaipinsajussinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinsajussinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininsajussinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = "
	param13.ParameterName = "p_xdescinsajussinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	param14.Value = "
	param14.ParameterName = "p_iestatinsajussinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinmobr output,@p_idaipinsajussin,@p_idaipbaremobr,@p_ncantinsajussinmobr,@p_nprecfininsajussinmobr,@p_xdescinsajussinmobr,@p_iestatinsajussinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinsajussinmobr(aipinsajussinmobr as aipinsajussinmobr) as respopera
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
	param8.Value = aipinsajussinmobr.idaipinsajussinmobr
	param8.ParameterName = "p_idaipinsajussinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinmobr.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinmobr.ncantinsajussinmobr
	param11.ParameterName = "p_ncantinsajussinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinmobr.nprecfininsajussinmobr
	param12.ParameterName = "p_nprecfininsajussinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinmobr.xdescinsajussinmobr IsNot Nothing Then
	param13.Value = aipinsajussinmobr.xdescinsajussinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinmobr.iestatinsajussinmobr IsNot Nothing Then
	param14.Value = aipinsajussinmobr.iestatinsajussinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinmobr output,@p_idaipinsajussin,@p_idaipbaremobr,@p_ncantinsajussinmobr,@p_nprecfininsajussinmobr,@p_xdescinsajussinmobr,@p_iestatinsajussinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinsajussinmobr(aipinsajussinmobr as aipinsajussinmobr) as respopera
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
	param8.Value = aipinsajussinmobr.idaipinsajussinmobr
	param8.ParameterName = "p_idaipinsajussinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinmobr.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinmobr.ncantinsajussinmobr
	param11.ParameterName = "p_ncantinsajussinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinmobr.nprecfininsajussinmobr
	param12.ParameterName = "p_nprecfininsajussinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinmobr.xdescinsajussinmobr IsNot Nothing Then
	param13.Value = aipinsajussinmobr.xdescinsajussinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinmobr.iestatinsajussinmobr IsNot Nothing Then
	param14.Value = aipinsajussinmobr.iestatinsajussinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinmobr output,@p_idaipinsajussin,@p_idaipbaremobr,@p_ncantinsajussinmobr,@p_nprecfininsajussinmobr,@p_xdescinsajussinmobr,@p_iestatinsajussinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
