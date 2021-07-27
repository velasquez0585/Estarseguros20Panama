Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinslimsusrepuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinslimsusrepuxid(idaipinslimsusrepu As Decimal) As aipinslimsusrepu
		Dim aipinslimsusrepu As aipinslimsusrepu = (From p In _db.aipinslimsusrepu
										Where p.idaipinslimsusrepu = idaipinslimsusrepu
										Select p).SingleOrDefault
		Return aipinslimsusrepu
	End Function

	<HttpPost()> _
	Public Function selaipinslimsusrepu() As List(Of aipinslimsusrepu)
		Dim lista_aipinslimsusrepu As List(Of aipinslimsusrepu) = (From p In _db.aipinslimsusrepu
													Select p).ToList
		'
		Return lista_aipinslimsusrepu
	End Function

<HttpPost()> _
	Public Function selaipinslimsusrepuxwheredinamicopag(petiaipinslimsusrepupaglist as petiaipinslimsusrepupaglist) as respaipinslimsusrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipinslimsusrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsusrepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipinslimsusrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsusrepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipinslimsusrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsus=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsus=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.ncantinslimsusrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsusrepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.ncantinslimsusrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsusrepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.ncantinslimsusrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.nprecfininslimsusrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsusrepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.nprecfininslimsusrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsusrepu=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.nprecfininslimsusrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.xdescinslimsusrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsusrepu='")
				sb.Append(petiaipinslimsusrepupaglist.aipinslimsusrepu.xdescinslimsusrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsusrepu='")
				sb.Append(petiaipinslimsusrepupaglist.aipinslimsusrepu.xdescinslimsusrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.iestatinslimsusrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsusrepu='")
				sb.Append(petiaipinslimsusrepupaglist.aipinslimsusrepu.iestatinslimsusrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsusrepu='")
				sb.Append(petiaipinslimsusrepupaglist.aipinslimsusrepu.iestatinslimsusrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusrepupaglist.aipinslimsusrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsusrepupaglist.aipinslimsusrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinslimsusrepupaglist As New respaipinslimsusrepupaglist
	respaipinslimsusrepupaglist.pagaipinslimsusrepu = petiaipinslimsusrepupaglist.pagaipinslimsusrepu
	Dim skip = skip_paginacion(petiaipinslimsusrepupaglist.pagaipinslimsusrepu.npagactual, petiaipinslimsusrepupaglist.pagaipinslimsusrepu.npagtamano)
	
		If sb.ToString = "" Then
			respaipinslimsusrepupaglist.lista_aipinslimsusrepu = _db.aipinslimsusrepu.OrderBy(petiaipinslimsusrepupaglist.pagaipinslimsusrepu.xcamposord & " "  & petiaipinslimsusrepupaglist.pagaipinslimsusrepu.idirord).Skip(skip).Take(petiaipinslimsusrepupaglist.pagaipinslimsusrepu.npagtamano).ToList
		Else
			respaipinslimsusrepupaglist.lista_aipinslimsusrepu = _db.aipinslimsusrepu.Where(sb.ToString).OrderBy(petiaipinslimsusrepupaglist.pagaipinslimsusrepu.xcamposord & " "  & petiaipinslimsusrepupaglist.pagaipinslimsusrepu.idirord).Skip(skip).Take(petiaipinslimsusrepupaglist.pagaipinslimsusrepu.npagtamano).ToList
		End If
		'
		If (respaipinslimsusrepupaglist.lista_aipinslimsusrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinslimsusrepuxwheredinamicocount(sb)
		respaipinslimsusrepupaglist.pagaipinslimsusrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinslimsusrepupaglist.pagaipinslimsusrepu.npagtamano)
		Else
		respaipinslimsusrepupaglist.pagaipinslimsusrepu.npagcantidad = 0
		respaipinslimsusrepupaglist.pagaipinslimsusrepu.npagactual = 0
		End If
	
		Return respaipinslimsusrepupaglist
	End Function

	Public Function selaipinslimsusrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinslimsusrepu.count
	Else
	Return _db.aipinslimsusrepu.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinslimsusrepu(aipinslimsusrepu as aipinslimsusrepu) as respopera
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
	param8.ParameterName = "p_idaipinslimsusrepu"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusrepu.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusrepu.ncantinslimsusrepu
	param11.ParameterName = "p_ncantinslimsusrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusrepu.nprecfininslimsusrepu
	param12.ParameterName = "p_nprecfininslimsusrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusrepu.xdescinslimsusrepu IsNot Nothing Then
	param13.Value = aipinslimsusrepu.xdescinslimsusrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusrepu.iestatinslimsusrepu IsNot Nothing Then
	param14.Value = aipinslimsusrepu.iestatinslimsusrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusrepu output,@p_idaipinslimsus,@p_idaipbarerepu,@p_ncantinslimsusrepu,@p_nprecfininslimsusrepu,@p_xdescinslimsusrepu,@p_iestatinslimsusrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinslimsusrepu(aipinslimsusrepu as aipinslimsusrepu) as respopera
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
	param8.Value = aipinslimsusrepu.idaipinslimsusrepu
	param8.ParameterName = "p_idaipinslimsusrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusrepu.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusrepu.ncantinslimsusrepu
	param11.ParameterName = "p_ncantinslimsusrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusrepu.nprecfininslimsusrepu
	param12.ParameterName = "p_nprecfininslimsusrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusrepu.xdescinslimsusrepu IsNot Nothing Then
	param13.Value = aipinslimsusrepu.xdescinslimsusrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusrepu.iestatinslimsusrepu IsNot Nothing Then
	param14.Value = aipinslimsusrepu.iestatinslimsusrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusrepu output,@p_idaipinslimsus,@p_idaipbarerepu,@p_ncantinslimsusrepu,@p_nprecfininslimsusrepu,@p_xdescinslimsusrepu,@p_iestatinslimsusrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsusrepu(aipinslimsusrepu as aipinslimsusrepu) as respopera
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
	param8.Value = aipinslimsusrepu.idaipinslimsusrepu
	param8.ParameterName = "p_idaipinslimsusrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusrepu.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusrepu.ncantinslimsusrepu
	param11.ParameterName = "p_ncantinslimsusrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusrepu.nprecfininslimsusrepu
	param12.ParameterName = "p_nprecfininslimsusrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusrepu.xdescinslimsusrepu IsNot Nothing Then
	param13.Value = aipinslimsusrepu.xdescinslimsusrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusrepu.iestatinslimsusrepu IsNot Nothing Then
	param14.Value = aipinslimsusrepu.iestatinslimsusrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusrepu output,@p_idaipinslimsus,@p_idaipbarerepu,@p_ncantinslimsusrepu,@p_nprecfininslimsusrepu,@p_xdescinslimsusrepu,@p_iestatinslimsusrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsusrepu(idaipinslimsusrepu as decimal) as respopera
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
	param8.Value = idaipinslimsusrepu
	param8.ParameterName = "p_idaipinslimsusrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinslimsusrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininslimsusrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = ""
	param13.ParameterName = "p_xdescinslimsusrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
                param14.Value = ""
                param14.ParameterName = "p_iestatinslimsusrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusrepu output,@p_idaipinslimsus,@p_idaipbarerepu,@p_ncantinslimsusrepu,@p_nprecfininslimsusrepu,@p_xdescinslimsusrepu,@p_iestatinslimsusrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinslimsusrepu(aipinslimsusrepu as aipinslimsusrepu) as respopera
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
	param8.Value = aipinslimsusrepu.idaipinslimsusrepu
	param8.ParameterName = "p_idaipinslimsusrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusrepu.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusrepu.ncantinslimsusrepu
	param11.ParameterName = "p_ncantinslimsusrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusrepu.nprecfininslimsusrepu
	param12.ParameterName = "p_nprecfininslimsusrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusrepu.xdescinslimsusrepu IsNot Nothing Then
	param13.Value = aipinslimsusrepu.xdescinslimsusrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusrepu.iestatinslimsusrepu IsNot Nothing Then
	param14.Value = aipinslimsusrepu.iestatinslimsusrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusrepu output,@p_idaipinslimsus,@p_idaipbarerepu,@p_ncantinslimsusrepu,@p_nprecfininslimsusrepu,@p_xdescinslimsusrepu,@p_iestatinslimsusrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinslimsusrepu(aipinslimsusrepu as aipinslimsusrepu) as respopera
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
	param8.Value = aipinslimsusrepu.idaipinslimsusrepu
	param8.ParameterName = "p_idaipinslimsusrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusrepu.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusrepu.ncantinslimsusrepu
	param11.ParameterName = "p_ncantinslimsusrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusrepu.nprecfininslimsusrepu
	param12.ParameterName = "p_nprecfininslimsusrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusrepu.xdescinslimsusrepu IsNot Nothing Then
	param13.Value = aipinslimsusrepu.xdescinslimsusrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusrepu.iestatinslimsusrepu IsNot Nothing Then
	param14.Value = aipinslimsusrepu.iestatinslimsusrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusrepu output,@p_idaipinslimsus,@p_idaipbarerepu,@p_ncantinslimsusrepu,@p_nprecfininslimsusrepu,@p_xdescinslimsusrepu,@p_iestatinslimsusrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
