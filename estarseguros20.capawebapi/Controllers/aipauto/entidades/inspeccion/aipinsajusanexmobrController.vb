Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsajusanexmobrController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsajusanexmobrxid(idaipinsajusanexmobr As Decimal) As aipinsajusanexmobr
		Dim aipinsajusanexmobr As aipinsajusanexmobr = (From p In _db.aipinsajusanexmobr
										Where p.idaipinsajusanexmobr = idaipinsajusanexmobr
										Select p).SingleOrDefault
		Return aipinsajusanexmobr
	End Function

	<HttpPost()> _
	Public Function selaipinsajusanexmobr() As List(Of aipinsajusanexmobr)
		Dim lista_aipinsajusanexmobr As List(Of aipinsajusanexmobr) = (From p In _db.aipinsajusanexmobr
													Select p).ToList
		'
		Return lista_aipinsajusanexmobr
	End Function

<HttpPost()> _
	Public Function selaipinsajusanexmobrxwheredinamicopag(petiaipinsajusanexmobrpaglist as petiaipinsajusanexmobrpaglist) as respaipinsajusanexmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipinsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanexmobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipinsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanexmobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipinsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.ncantinsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajusanexmobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.ncantinsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajusanexmobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.ncantinsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.nprecfininsajusanexmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininsajusanexmobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.nprecfininsajusanexmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininsajusanexmobr=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.nprecfininsajusanexmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.xdescinsajusanexmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajusanexmobr='")
				sb.Append(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.xdescinsajusanexmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajusanexmobr='")
				sb.Append(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.xdescinsajusanexmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.iestatinsajusanexmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajusanexmobr='")
				sb.Append(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.iestatinsajusanexmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajusanexmobr='")
				sb.Append(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.iestatinsajusanexmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajusanexmobrpaglist.aipinsajusanexmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsajusanexmobrpaglist As New respaipinsajusanexmobrpaglist
	respaipinsajusanexmobrpaglist.pagaipinsajusanexmobr = petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr
	Dim skip = skip_paginacion(petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagactual, petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsajusanexmobrpaglist.lista_aipinsajusanexmobr = _db.aipinsajusanexmobr.OrderBy(petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.xcamposord & " "  & petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.idirord).Skip(skip).Take(petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagtamano).ToList
		Else
			respaipinsajusanexmobrpaglist.lista_aipinsajusanexmobr = _db.aipinsajusanexmobr.Where(sb.ToString).OrderBy(petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.xcamposord & " "  & petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.idirord).Skip(skip).Take(petiaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagtamano).ToList
		End If
		'
		If (respaipinsajusanexmobrpaglist.lista_aipinsajusanexmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsajusanexmobrxwheredinamicocount(sb)
		respaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagtamano)
		Else
		respaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagcantidad = 0
		respaipinsajusanexmobrpaglist.pagaipinsajusanexmobr.npagactual = 0
		End If
	
		Return respaipinsajusanexmobrpaglist
	End Function

	Public Function selaipinsajusanexmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsajusanexmobr.count
	Else
	Return _db.aipinsajusanexmobr.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsajusanexmobr(aipinsajusanexmobr as aipinsajusanexmobr) as respopera
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
	param8.ParameterName = "p_idaipinsajusanexmobr"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexmobr.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexmobr.ncantinsajusanexmobr
	param11.ParameterName = "p_ncantinsajusanexmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexmobr.nprecfininsajusanexmobr
	param12.ParameterName = "p_nprecfininsajusanexmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexmobr.xdescinsajusanexmobr IsNot Nothing Then
	param13.Value = aipinsajusanexmobr.xdescinsajusanexmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexmobr.iestatinsajusanexmobr IsNot Nothing Then
	param14.Value = aipinsajusanexmobr.iestatinsajusanexmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexmobr output,@p_idaipinsajusanex,@p_idaipbaremobr,@p_ncantinsajusanexmobr,@p_nprecfininsajusanexmobr,@p_xdescinsajusanexmobr,@p_iestatinsajusanexmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinsajusanexmobr(aipinsajusanexmobr as aipinsajusanexmobr) as respopera
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
	param8.Value = aipinsajusanexmobr.idaipinsajusanexmobr
	param8.ParameterName = "p_idaipinsajusanexmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexmobr.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexmobr.ncantinsajusanexmobr
	param11.ParameterName = "p_ncantinsajusanexmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexmobr.nprecfininsajusanexmobr
	param12.ParameterName = "p_nprecfininsajusanexmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexmobr.xdescinsajusanexmobr IsNot Nothing Then
	param13.Value = aipinsajusanexmobr.xdescinsajusanexmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexmobr.iestatinsajusanexmobr IsNot Nothing Then
	param14.Value = aipinsajusanexmobr.iestatinsajusanexmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexmobr output,@p_idaipinsajusanex,@p_idaipbaremobr,@p_ncantinsajusanexmobr,@p_nprecfininsajusanexmobr,@p_xdescinsajusanexmobr,@p_iestatinsajusanexmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajusanexmobr(aipinsajusanexmobr as aipinsajusanexmobr) as respopera
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
	param8.Value = aipinsajusanexmobr.idaipinsajusanexmobr
	param8.ParameterName = "p_idaipinsajusanexmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexmobr.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexmobr.ncantinsajusanexmobr
	param11.ParameterName = "p_ncantinsajusanexmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexmobr.nprecfininsajusanexmobr
	param12.ParameterName = "p_nprecfininsajusanexmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexmobr.xdescinsajusanexmobr IsNot Nothing Then
	param13.Value = aipinsajusanexmobr.xdescinsajusanexmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexmobr.iestatinsajusanexmobr IsNot Nothing Then
	param14.Value = aipinsajusanexmobr.iestatinsajusanexmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexmobr output,@p_idaipinsajusanex,@p_idaipbaremobr,@p_ncantinsajusanexmobr,@p_nprecfininsajusanexmobr,@p_xdescinsajusanexmobr,@p_iestatinsajusanexmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajusanexmobr(idaipinsajusanexmobr as decimal) as respopera
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
	param8.Value = idaipinsajusanexmobr
	param8.ParameterName = "p_idaipinsajusanexmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinsajusanexmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininsajusanexmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = "
	param13.ParameterName = "p_xdescinsajusanexmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	param14.Value = "
	param14.ParameterName = "p_iestatinsajusanexmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexmobr output,@p_idaipinsajusanex,@p_idaipbaremobr,@p_ncantinsajusanexmobr,@p_nprecfininsajusanexmobr,@p_xdescinsajusanexmobr,@p_iestatinsajusanexmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinsajusanexmobr(aipinsajusanexmobr as aipinsajusanexmobr) as respopera
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
	param8.Value = aipinsajusanexmobr.idaipinsajusanexmobr
	param8.ParameterName = "p_idaipinsajusanexmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexmobr.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexmobr.ncantinsajusanexmobr
	param11.ParameterName = "p_ncantinsajusanexmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexmobr.nprecfininsajusanexmobr
	param12.ParameterName = "p_nprecfininsajusanexmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexmobr.xdescinsajusanexmobr IsNot Nothing Then
	param13.Value = aipinsajusanexmobr.xdescinsajusanexmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexmobr.iestatinsajusanexmobr IsNot Nothing Then
	param14.Value = aipinsajusanexmobr.iestatinsajusanexmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexmobr output,@p_idaipinsajusanex,@p_idaipbaremobr,@p_ncantinsajusanexmobr,@p_nprecfininsajusanexmobr,@p_xdescinsajusanexmobr,@p_iestatinsajusanexmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinsajusanexmobr(aipinsajusanexmobr as aipinsajusanexmobr) as respopera
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
	param8.Value = aipinsajusanexmobr.idaipinsajusanexmobr
	param8.ParameterName = "p_idaipinsajusanexmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexmobr.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexmobr.ncantinsajusanexmobr
	param11.ParameterName = "p_ncantinsajusanexmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexmobr.nprecfininsajusanexmobr
	param12.ParameterName = "p_nprecfininsajusanexmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexmobr.xdescinsajusanexmobr IsNot Nothing Then
	param13.Value = aipinsajusanexmobr.xdescinsajusanexmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexmobr.iestatinsajusanexmobr IsNot Nothing Then
	param14.Value = aipinsajusanexmobr.iestatinsajusanexmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexmobr output,@p_idaipinsajusanex,@p_idaipbaremobr,@p_ncantinsajusanexmobr,@p_nprecfininsajusanexmobr,@p_xdescinsajusanexmobr,@p_iestatinsajusanexmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
