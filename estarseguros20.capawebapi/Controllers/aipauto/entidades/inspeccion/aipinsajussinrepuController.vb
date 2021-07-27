Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsajussinrepuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsajussinrepuxid(idaipinsajussinrepu As Decimal) As aipinsajussinrepu
		Dim aipinsajussinrepu As aipinsajussinrepu = (From p In _db.aipinsajussinrepu
										Where p.idaipinsajussinrepu = idaipinsajussinrepu
										Select p).SingleOrDefault
		Return aipinsajussinrepu
	End Function

	<HttpPost()> _
	Public Function selaipinsajussinrepu() As List(Of aipinsajussinrepu)
		Dim lista_aipinsajussinrepu As List(Of aipinsajussinrepu) = (From p In _db.aipinsajussinrepu
													Select p).ToList
		'
		Return lista_aipinsajussinrepu
	End Function

<HttpPost()> _
	Public Function selaipinsajussinrepuxwheredinamicopag(petiaipinsajussinrepupaglist as petiaipinsajussinrepupaglist) as respaipinsajussinrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipinsajussinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussinrepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipinsajussinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussinrepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipinsajussinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.ncantinsajussinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinsajussinrepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.ncantinsajussinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinsajussinrepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.ncantinsajussinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.nprecfininsajussinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininsajussinrepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.nprecfininsajussinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininsajussinrepu=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.nprecfininsajussinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.xdescinsajussinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajussinrepu='")
				sb.Append(petiaipinsajussinrepupaglist.aipinsajussinrepu.xdescinsajussinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajussinrepu='")
				sb.Append(petiaipinsajussinrepupaglist.aipinsajussinrepu.xdescinsajussinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.iestatinsajussinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajussinrepu='")
				sb.Append(petiaipinsajussinrepupaglist.aipinsajussinrepu.iestatinsajussinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajussinrepu='")
				sb.Append(petiaipinsajussinrepupaglist.aipinsajussinrepu.iestatinsajussinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinrepupaglist.aipinsajussinrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajussinrepupaglist.aipinsajussinrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsajussinrepupaglist As New respaipinsajussinrepupaglist
	respaipinsajussinrepupaglist.pagaipinsajussinrepu = petiaipinsajussinrepupaglist.pagaipinsajussinrepu
	Dim skip = skip_paginacion(petiaipinsajussinrepupaglist.pagaipinsajussinrepu.npagactual, petiaipinsajussinrepupaglist.pagaipinsajussinrepu.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsajussinrepupaglist.lista_aipinsajussinrepu = _db.aipinsajussinrepu.OrderBy(petiaipinsajussinrepupaglist.pagaipinsajussinrepu.xcamposord & " "  & petiaipinsajussinrepupaglist.pagaipinsajussinrepu.idirord).Skip(skip).Take(petiaipinsajussinrepupaglist.pagaipinsajussinrepu.npagtamano).ToList
		Else
			respaipinsajussinrepupaglist.lista_aipinsajussinrepu = _db.aipinsajussinrepu.Where(sb.ToString).OrderBy(petiaipinsajussinrepupaglist.pagaipinsajussinrepu.xcamposord & " "  & petiaipinsajussinrepupaglist.pagaipinsajussinrepu.idirord).Skip(skip).Take(petiaipinsajussinrepupaglist.pagaipinsajussinrepu.npagtamano).ToList
		End If
		'
		If (respaipinsajussinrepupaglist.lista_aipinsajussinrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsajussinrepuxwheredinamicocount(sb)
		respaipinsajussinrepupaglist.pagaipinsajussinrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsajussinrepupaglist.pagaipinsajussinrepu.npagtamano)
		Else
		respaipinsajussinrepupaglist.pagaipinsajussinrepu.npagcantidad = 0
		respaipinsajussinrepupaglist.pagaipinsajussinrepu.npagactual = 0
		End If
	
		Return respaipinsajussinrepupaglist
	End Function

	Public Function selaipinsajussinrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsajussinrepu.count
	Else
	Return _db.aipinsajussinrepu.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsajussinrepu(aipinsajussinrepu as aipinsajussinrepu) as respopera
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
	param8.ParameterName = "p_idaipinsajussinrepu"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinrepu.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinrepu.ncantinsajussinrepu
	param11.ParameterName = "p_ncantinsajussinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinrepu.nprecfininsajussinrepu
	param12.ParameterName = "p_nprecfininsajussinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinrepu.xdescinsajussinrepu IsNot Nothing Then
	param13.Value = aipinsajussinrepu.xdescinsajussinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinrepu.iestatinsajussinrepu IsNot Nothing Then
	param14.Value = aipinsajussinrepu.iestatinsajussinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinrepu output,@p_idaipinsajussin,@p_idaipbarerepu,@p_ncantinsajussinrepu,@p_nprecfininsajussinrepu,@p_xdescinsajussinrepu,@p_iestatinsajussinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinsajussinrepu(aipinsajussinrepu as aipinsajussinrepu) as respopera
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
	param8.Value = aipinsajussinrepu.idaipinsajussinrepu
	param8.ParameterName = "p_idaipinsajussinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinrepu.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinrepu.ncantinsajussinrepu
	param11.ParameterName = "p_ncantinsajussinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinrepu.nprecfininsajussinrepu
	param12.ParameterName = "p_nprecfininsajussinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinrepu.xdescinsajussinrepu IsNot Nothing Then
	param13.Value = aipinsajussinrepu.xdescinsajussinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinrepu.iestatinsajussinrepu IsNot Nothing Then
	param14.Value = aipinsajussinrepu.iestatinsajussinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinrepu output,@p_idaipinsajussin,@p_idaipbarerepu,@p_ncantinsajussinrepu,@p_nprecfininsajussinrepu,@p_xdescinsajussinrepu,@p_iestatinsajussinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajussinrepu(aipinsajussinrepu as aipinsajussinrepu) as respopera
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
	param8.Value = aipinsajussinrepu.idaipinsajussinrepu
	param8.ParameterName = "p_idaipinsajussinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinrepu.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinrepu.ncantinsajussinrepu
	param11.ParameterName = "p_ncantinsajussinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinrepu.nprecfininsajussinrepu
	param12.ParameterName = "p_nprecfininsajussinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinrepu.xdescinsajussinrepu IsNot Nothing Then
	param13.Value = aipinsajussinrepu.xdescinsajussinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinrepu.iestatinsajussinrepu IsNot Nothing Then
	param14.Value = aipinsajussinrepu.iestatinsajussinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinrepu output,@p_idaipinsajussin,@p_idaipbarerepu,@p_ncantinsajussinrepu,@p_nprecfininsajussinrepu,@p_xdescinsajussinrepu,@p_iestatinsajussinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinsajussinrepu(idaipinsajussinrepu as decimal) as respopera
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
	param8.Value = idaipinsajussinrepu
	param8.ParameterName = "p_idaipinsajussinrepu"
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
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinsajussinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininsajussinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = ""
	param13.ParameterName = "p_xdescinsajussinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
                param14.Value = ""
                param14.ParameterName = "p_iestatinsajussinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinrepu output,@p_idaipinsajussin,@p_idaipbarerepu,@p_ncantinsajussinrepu,@p_nprecfininsajussinrepu,@p_xdescinsajussinrepu,@p_iestatinsajussinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinsajussinrepu(aipinsajussinrepu as aipinsajussinrepu) as respopera
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
	param8.Value = aipinsajussinrepu.idaipinsajussinrepu
	param8.ParameterName = "p_idaipinsajussinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinrepu.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinrepu.ncantinsajussinrepu
	param11.ParameterName = "p_ncantinsajussinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinrepu.nprecfininsajussinrepu
	param12.ParameterName = "p_nprecfininsajussinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinrepu.xdescinsajussinrepu IsNot Nothing Then
	param13.Value = aipinsajussinrepu.xdescinsajussinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinrepu.iestatinsajussinrepu IsNot Nothing Then
	param14.Value = aipinsajussinrepu.iestatinsajussinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinrepu output,@p_idaipinsajussin,@p_idaipbarerepu,@p_ncantinsajussinrepu,@p_nprecfininsajussinrepu,@p_xdescinsajussinrepu,@p_iestatinsajussinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinsajussinrepu(aipinsajussinrepu as aipinsajussinrepu) as respopera
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
	param8.Value = aipinsajussinrepu.idaipinsajussinrepu
	param8.ParameterName = "p_idaipinsajussinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussinrepu.idaipinsajussin
	param9.ParameterName = "p_idaipinsajussin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsajussinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinsajussinrepu.ncantinsajussinrepu
	param11.ParameterName = "p_ncantinsajussinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinsajussinrepu.nprecfininsajussinrepu
	param12.ParameterName = "p_nprecfininsajussinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinsajussinrepu.xdescinsajussinrepu IsNot Nothing Then
	param13.Value = aipinsajussinrepu.xdescinsajussinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinsajussinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinsajussinrepu.iestatinsajussinrepu IsNot Nothing Then
	param14.Value = aipinsajussinrepu.iestatinsajussinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinsajussinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinsajussinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussinrepu output,@p_idaipinsajussin,@p_idaipbarerepu,@p_ncantinsajussinrepu,@p_nprecfininsajussinrepu,@p_xdescinsajussinrepu,@p_iestatinsajussinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
