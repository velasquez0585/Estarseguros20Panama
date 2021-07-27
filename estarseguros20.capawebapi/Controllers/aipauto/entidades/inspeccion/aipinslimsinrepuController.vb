Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinslimsinrepuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinslimsinrepuxid(idaipinslimsinrepu As Decimal) As aipinslimsinrepu
		Dim aipinslimsinrepu As aipinslimsinrepu = (From p In _db.aipinslimsinrepu
										Where p.idaipinslimsinrepu = idaipinslimsinrepu
										Select p).SingleOrDefault
		Return aipinslimsinrepu
	End Function

	<HttpPost()> _
	Public Function selaipinslimsinrepu() As List(Of aipinslimsinrepu)
		Dim lista_aipinslimsinrepu As List(Of aipinslimsinrepu) = (From p In _db.aipinslimsinrepu
													Select p).ToList
		'
		Return lista_aipinslimsinrepu
	End Function

<HttpPost()> _
	Public Function selaipinslimsinrepuxwheredinamicopag(petiaipinslimsinrepupaglist as petiaipinslimsinrepupaglist) as respaipinslimsinrepupaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipinslimsinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsinrepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipinslimsinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsinrepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipinslimsinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.ncantinslimsinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsinrepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.ncantinslimsinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsinrepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.ncantinslimsinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.nprecfininslimsinrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsinrepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.nprecfininslimsinrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsinrepu=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.nprecfininslimsinrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.xdescinslimsinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsinrepu='")
				sb.Append(petiaipinslimsinrepupaglist.aipinslimsinrepu.xdescinslimsinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsinrepu='")
				sb.Append(petiaipinslimsinrepupaglist.aipinslimsinrepu.xdescinslimsinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.iestatinslimsinrepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsinrepu='")
				sb.Append(petiaipinslimsinrepupaglist.aipinslimsinrepu.iestatinslimsinrepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsinrepu='")
				sb.Append(petiaipinslimsinrepupaglist.aipinslimsinrepu.iestatinslimsinrepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinrepupaglist.aipinslimsinrepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsinrepupaglist.aipinslimsinrepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinslimsinrepupaglist As New respaipinslimsinrepupaglist
	respaipinslimsinrepupaglist.pagaipinslimsinrepu = petiaipinslimsinrepupaglist.pagaipinslimsinrepu
	Dim skip = skip_paginacion(petiaipinslimsinrepupaglist.pagaipinslimsinrepu.npagactual, petiaipinslimsinrepupaglist.pagaipinslimsinrepu.npagtamano)
	
		If sb.ToString = "" Then
			respaipinslimsinrepupaglist.lista_aipinslimsinrepu = _db.aipinslimsinrepu.OrderBy(petiaipinslimsinrepupaglist.pagaipinslimsinrepu.xcamposord & " "  & petiaipinslimsinrepupaglist.pagaipinslimsinrepu.idirord).Skip(skip).Take(petiaipinslimsinrepupaglist.pagaipinslimsinrepu.npagtamano).ToList
		Else
			respaipinslimsinrepupaglist.lista_aipinslimsinrepu = _db.aipinslimsinrepu.Where(sb.ToString).OrderBy(petiaipinslimsinrepupaglist.pagaipinslimsinrepu.xcamposord & " "  & petiaipinslimsinrepupaglist.pagaipinslimsinrepu.idirord).Skip(skip).Take(petiaipinslimsinrepupaglist.pagaipinslimsinrepu.npagtamano).ToList
		End If
		'
		If (respaipinslimsinrepupaglist.lista_aipinslimsinrepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinslimsinrepuxwheredinamicocount(sb)
		respaipinslimsinrepupaglist.pagaipinslimsinrepu.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinslimsinrepupaglist.pagaipinslimsinrepu.npagtamano)
		Else
		respaipinslimsinrepupaglist.pagaipinslimsinrepu.npagcantidad = 0
		respaipinslimsinrepupaglist.pagaipinslimsinrepu.npagactual = 0
		End If
	
		Return respaipinslimsinrepupaglist
	End Function

	Public Function selaipinslimsinrepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinslimsinrepu.count
	Else
	Return _db.aipinslimsinrepu.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinslimsinrepu(aipinslimsinrepu as aipinslimsinrepu) as respopera
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
	param8.ParameterName = "p_idaipinslimsinrepu"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinrepu.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinrepu.ncantinslimsinrepu
	param11.ParameterName = "p_ncantinslimsinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinrepu.nprecfininslimsinrepu
	param12.ParameterName = "p_nprecfininslimsinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinrepu.xdescinslimsinrepu IsNot Nothing Then
	param13.Value = aipinslimsinrepu.xdescinslimsinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinrepu.iestatinslimsinrepu IsNot Nothing Then
	param14.Value = aipinslimsinrepu.iestatinslimsinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinrepu output,@p_idaipinslimsin,@p_idaipbarerepu,@p_ncantinslimsinrepu,@p_nprecfininslimsinrepu,@p_xdescinslimsinrepu,@p_iestatinslimsinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinslimsinrepu(aipinslimsinrepu as aipinslimsinrepu) as respopera
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
	param8.Value = aipinslimsinrepu.idaipinslimsinrepu
	param8.ParameterName = "p_idaipinslimsinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinrepu.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinrepu.ncantinslimsinrepu
	param11.ParameterName = "p_ncantinslimsinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinrepu.nprecfininslimsinrepu
	param12.ParameterName = "p_nprecfininslimsinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinrepu.xdescinslimsinrepu IsNot Nothing Then
	param13.Value = aipinslimsinrepu.xdescinslimsinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinrepu.iestatinslimsinrepu IsNot Nothing Then
	param14.Value = aipinslimsinrepu.iestatinslimsinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinrepu output,@p_idaipinslimsin,@p_idaipbarerepu,@p_ncantinslimsinrepu,@p_nprecfininslimsinrepu,@p_xdescinslimsinrepu,@p_iestatinslimsinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsinrepu(aipinslimsinrepu as aipinslimsinrepu) as respopera
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
	param8.Value = aipinslimsinrepu.idaipinslimsinrepu
	param8.ParameterName = "p_idaipinslimsinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinrepu.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinrepu.ncantinslimsinrepu
	param11.ParameterName = "p_ncantinslimsinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinrepu.nprecfininslimsinrepu
	param12.ParameterName = "p_nprecfininslimsinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinrepu.xdescinslimsinrepu IsNot Nothing Then
	param13.Value = aipinslimsinrepu.xdescinslimsinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinrepu.iestatinslimsinrepu IsNot Nothing Then
	param14.Value = aipinslimsinrepu.iestatinslimsinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinrepu output,@p_idaipinslimsin,@p_idaipbarerepu,@p_ncantinslimsinrepu,@p_nprecfininslimsinrepu,@p_xdescinslimsinrepu,@p_iestatinslimsinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsinrepu(idaipinslimsinrepu as decimal) as respopera
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
	param8.Value = idaipinslimsinrepu
	param8.ParameterName = "p_idaipinslimsinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinslimsinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininslimsinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = ""
	param13.ParameterName = "p_xdescinslimsinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
                param14.Value = ""
                param14.ParameterName = "p_iestatinslimsinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinrepu output,@p_idaipinslimsin,@p_idaipbarerepu,@p_ncantinslimsinrepu,@p_nprecfininslimsinrepu,@p_xdescinslimsinrepu,@p_iestatinslimsinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinslimsinrepu(aipinslimsinrepu as aipinslimsinrepu) as respopera
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
	param8.Value = aipinslimsinrepu.idaipinslimsinrepu
	param8.ParameterName = "p_idaipinslimsinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinrepu.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinrepu.ncantinslimsinrepu
	param11.ParameterName = "p_ncantinslimsinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinrepu.nprecfininslimsinrepu
	param12.ParameterName = "p_nprecfininslimsinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinrepu.xdescinslimsinrepu IsNot Nothing Then
	param13.Value = aipinslimsinrepu.xdescinslimsinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinrepu.iestatinslimsinrepu IsNot Nothing Then
	param14.Value = aipinslimsinrepu.iestatinslimsinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinrepu output,@p_idaipinslimsin,@p_idaipbarerepu,@p_ncantinslimsinrepu,@p_nprecfininslimsinrepu,@p_xdescinslimsinrepu,@p_iestatinslimsinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinslimsinrepu(aipinslimsinrepu as aipinslimsinrepu) as respopera
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
	param8.Value = aipinslimsinrepu.idaipinslimsinrepu
	param8.ParameterName = "p_idaipinslimsinrepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinrepu.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinrepu.idaipbarerepu
	param10.ParameterName = "p_idaipbarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinrepu.ncantinslimsinrepu
	param11.ParameterName = "p_ncantinslimsinrepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinrepu.nprecfininslimsinrepu
	param12.ParameterName = "p_nprecfininslimsinrepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinrepu.xdescinslimsinrepu IsNot Nothing Then
	param13.Value = aipinslimsinrepu.xdescinslimsinrepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinrepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinrepu.iestatinslimsinrepu IsNot Nothing Then
	param14.Value = aipinslimsinrepu.iestatinslimsinrepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinrepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinrepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinrepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinrepu output,@p_idaipinslimsin,@p_idaipbarerepu,@p_ncantinslimsinrepu,@p_nprecfininslimsinrepu,@p_xdescinslimsinrepu,@p_iestatinslimsinrepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
