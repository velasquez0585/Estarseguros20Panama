Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsajusanexrepuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsajusanexrepuxid(idaipinsajusanexrepu As Decimal) As aipinsajusanexrepu
		Dim aipinsajusanexrepu As aipinsajusanexrepu = (From p In _db.aipinsajusanexrepu
										Where p.idaipinsajusanexrepu = idaipinsajusanexrepu
										Select p).SingleOrDefault
		Return aipinsajusanexrepu
	End Function

	<HttpPost()> _
	Public Function selaipinsajusanexrepu() As List(Of aipinsajusanexrepu)
		Dim lista_aipinsajusanexrepu As List(Of aipinsajusanexrepu) = (From p In _db.aipinsajusanexrepu
													Select p).ToList
		'
		Return lista_aipinsajusanexrepu
	End Function

<HttpPost()> _
	Public Function selaipinsajusanexrepuxwheredinamicopag(petiaipinsajusanexrepupaglist as petiaipinsajusanexrepupaglist) as respaipinsajusanexrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipinsajusanexrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanexrepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipinsajusanexrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanexrepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipinsajusanexrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.ncantinsajusanexrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajusanexrepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.ncantinsajusanexrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajusanexrepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.ncantinsajusanexrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.nprecfininsajusanexrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininsajusanexrepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.nprecfininsajusanexrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininsajusanexrepu=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.nprecfininsajusanexrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.xdescinsajusanexrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajusanexrepu='")
				sb.Append(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.xdescinsajusanexrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajusanexrepu='")
				sb.Append(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.xdescinsajusanexrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.iestatinsajusanexrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajusanexrepu='")
				sb.Append(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.iestatinsajusanexrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajusanexrepu='")
				sb.Append(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.iestatinsajusanexrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajusanexrepupaglist.aipinsajusanexrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsajusanexrepupaglist As New respaipinsajusanexrepupaglist
	respaipinsajusanexrepupaglist.pagaipinsajusanexrepu = petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu
	Dim skip = skip_paginacion(petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagactual, petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsajusanexrepupaglist.lista_aipinsajusanexrepu = _db.aipinsajusanexrepu.OrderBy(petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.xcamposord & " "  & petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.idirord).Skip(skip).Take(petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagtamano).ToList
		Else
			respaipinsajusanexrepupaglist.lista_aipinsajusanexrepu = _db.aipinsajusanexrepu.Where(sb.ToString).OrderBy(petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.xcamposord & " "  & petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.idirord).Skip(skip).Take(petiaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagtamano).ToList
		End If
		'
		If (respaipinsajusanexrepupaglist.lista_aipinsajusanexrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsajusanexrepuxwheredinamicocount(sb)
		respaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagtamano)
		Else
		respaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagcantidad = 0
		respaipinsajusanexrepupaglist.pagaipinsajusanexrepu.npagactual = 0
		End If
	
		Return respaipinsajusanexrepupaglist
	End Function

	Public Function selaipinsajusanexrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsajusanexrepu.count
	Else
	Return _db.aipinsajusanexrepu.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsajusanexrepu(aipinsajusanexrepu as aipinsajusanexrepu) as respopera
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
	param8.ParameterName = "p_idaipinsajusanexrepu"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexrepu.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexrepu.ncantinsajusanexrepu
	param11.ParameterName = "p_ncantinsajusanexrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexrepu.nprecfininsajusanexrepu
	param12.ParameterName = "p_nprecfininsajusanexrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexrepu.xdescinsajusanexrepu IsNot Nothing Then
	param13.Value = aipinsajusanexrepu.xdescinsajusanexrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexrepu.iestatinsajusanexrepu IsNot Nothing Then
	param14.Value = aipinsajusanexrepu.iestatinsajusanexrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexrepu output,@p_idaipinsajusanex,@p_idaipbarerepu,@p_ncantinsajusanexrepu,@p_nprecfininsajusanexrepu,@p_xdescinsajusanexrepu,@p_iestatinsajusanexrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinsajusanexrepu(aipinsajusanexrepu as aipinsajusanexrepu) as respopera
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
	param8.Value = aipinsajusanexrepu.idaipinsajusanexrepu
	param8.ParameterName = "p_idaipinsajusanexrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexrepu.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexrepu.ncantinsajusanexrepu
	param11.ParameterName = "p_ncantinsajusanexrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexrepu.nprecfininsajusanexrepu
	param12.ParameterName = "p_nprecfininsajusanexrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexrepu.xdescinsajusanexrepu IsNot Nothing Then
	param13.Value = aipinsajusanexrepu.xdescinsajusanexrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexrepu.iestatinsajusanexrepu IsNot Nothing Then
	param14.Value = aipinsajusanexrepu.iestatinsajusanexrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexrepu output,@p_idaipinsajusanex,@p_idaipbarerepu,@p_ncantinsajusanexrepu,@p_nprecfininsajusanexrepu,@p_xdescinsajusanexrepu,@p_iestatinsajusanexrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajusanexrepu(aipinsajusanexrepu as aipinsajusanexrepu) as respopera
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
	param8.Value = aipinsajusanexrepu.idaipinsajusanexrepu
	param8.ParameterName = "p_idaipinsajusanexrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexrepu.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexrepu.ncantinsajusanexrepu
	param11.ParameterName = "p_ncantinsajusanexrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexrepu.nprecfininsajusanexrepu
	param12.ParameterName = "p_nprecfininsajusanexrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexrepu.xdescinsajusanexrepu IsNot Nothing Then
	param13.Value = aipinsajusanexrepu.xdescinsajusanexrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexrepu.iestatinsajusanexrepu IsNot Nothing Then
	param14.Value = aipinsajusanexrepu.iestatinsajusanexrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexrepu output,@p_idaipinsajusanex,@p_idaipbarerepu,@p_ncantinsajusanexrepu,@p_nprecfininsajusanexrepu,@p_xdescinsajusanexrepu,@p_iestatinsajusanexrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajusanexrepu(idaipinsajusanexrepu as decimal) as respopera
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
	param8.Value = idaipinsajusanexrepu
	param8.ParameterName = "p_idaipinsajusanexrepu"
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
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinsajusanexrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininsajusanexrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = "
	param13.ParameterName = "p_xdescinsajusanexrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	param14.Value = "
	param14.ParameterName = "p_iestatinsajusanexrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexrepu output,@p_idaipinsajusanex,@p_idaipbarerepu,@p_ncantinsajusanexrepu,@p_nprecfininsajusanexrepu,@p_xdescinsajusanexrepu,@p_iestatinsajusanexrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinsajusanexrepu(aipinsajusanexrepu as aipinsajusanexrepu) as respopera
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
	param8.Value = aipinsajusanexrepu.idaipinsajusanexrepu
	param8.ParameterName = "p_idaipinsajusanexrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexrepu.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexrepu.ncantinsajusanexrepu
	param11.ParameterName = "p_ncantinsajusanexrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexrepu.nprecfininsajusanexrepu
	param12.ParameterName = "p_nprecfininsajusanexrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexrepu.xdescinsajusanexrepu IsNot Nothing Then
	param13.Value = aipinsajusanexrepu.xdescinsajusanexrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexrepu.iestatinsajusanexrepu IsNot Nothing Then
	param14.Value = aipinsajusanexrepu.iestatinsajusanexrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexrepu output,@p_idaipinsajusanex,@p_idaipbarerepu,@p_ncantinsajusanexrepu,@p_nprecfininsajusanexrepu,@p_xdescinsajusanexrepu,@p_iestatinsajusanexrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinsajusanexrepu(aipinsajusanexrepu as aipinsajusanexrepu) as respopera
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
	param8.Value = aipinsajusanexrepu.idaipinsajusanexrepu
	param8.ParameterName = "p_idaipinsajusanexrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanexrepu.idaipinsajusanex
	param9.ParameterName = "p_idaipinsajusanex"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajusanexrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajusanexrepu.ncantinsajusanexrepu
	param11.ParameterName = "p_ncantinsajusanexrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajusanexrepu.nprecfininsajusanexrepu
	param12.ParameterName = "p_nprecfininsajusanexrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajusanexrepu.xdescinsajusanexrepu IsNot Nothing Then
	param13.Value = aipinsajusanexrepu.xdescinsajusanexrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajusanexrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajusanexrepu.iestatinsajusanexrepu IsNot Nothing Then
	param14.Value = aipinsajusanexrepu.iestatinsajusanexrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajusanexrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajusanexrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanexrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanexrepu output,@p_idaipinsajusanex,@p_idaipbarerepu,@p_ncantinsajusanexrepu,@p_nprecfininsajusanexrepu,@p_xdescinsajusanexrepu,@p_iestatinsajusanexrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
