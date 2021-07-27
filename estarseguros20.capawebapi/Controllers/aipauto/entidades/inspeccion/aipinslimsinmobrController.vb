Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinslimsinmobrController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinslimsinmobrxid(idaipinslimsinmobr As Decimal) As aipinslimsinmobr
		Dim aipinslimsinmobr As aipinslimsinmobr = (From p In _db.aipinslimsinmobr
										Where p.idaipinslimsinmobr = idaipinslimsinmobr
										Select p).SingleOrDefault
		Return aipinslimsinmobr
	End Function

	<HttpPost()> _
	Public Function selaipinslimsinmobr() As List(Of aipinslimsinmobr)
		Dim lista_aipinslimsinmobr As List(Of aipinslimsinmobr) = (From p In _db.aipinslimsinmobr
													Select p).ToList
		'
		Return lista_aipinslimsinmobr
	End Function

<HttpPost()> _
	Public Function selaipinslimsinmobrxwheredinamicopag(petiaipinslimsinmobrpaglist as petiaipinslimsinmobrpaglist) as respaipinslimsinmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipinslimsinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsinmobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipinslimsinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsinmobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipinslimsinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.ncantinslimsinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsinmobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.ncantinslimsinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsinmobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.ncantinslimsinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.nprecfininslimsinmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsinmobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.nprecfininslimsinmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsinmobr=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.nprecfininslimsinmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.xdescinslimsinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsinmobr='")
				sb.Append(petiaipinslimsinmobrpaglist.aipinslimsinmobr.xdescinslimsinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsinmobr='")
				sb.Append(petiaipinslimsinmobrpaglist.aipinslimsinmobr.xdescinslimsinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.iestatinslimsinmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsinmobr='")
				sb.Append(petiaipinslimsinmobrpaglist.aipinslimsinmobr.iestatinslimsinmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsinmobr='")
				sb.Append(petiaipinslimsinmobrpaglist.aipinslimsinmobr.iestatinslimsinmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinmobrpaglist.aipinslimsinmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsinmobrpaglist.aipinslimsinmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinslimsinmobrpaglist As New respaipinslimsinmobrpaglist
	respaipinslimsinmobrpaglist.pagaipinslimsinmobr = petiaipinslimsinmobrpaglist.pagaipinslimsinmobr
	Dim skip = skip_paginacion(petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagactual, petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagtamano)
	
		If sb.ToString = "" Then
			respaipinslimsinmobrpaglist.lista_aipinslimsinmobr = _db.aipinslimsinmobr.OrderBy(petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.xcamposord & " "  & petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.idirord).Skip(skip).Take(petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagtamano).ToList
		Else
			respaipinslimsinmobrpaglist.lista_aipinslimsinmobr = _db.aipinslimsinmobr.Where(sb.ToString).OrderBy(petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.xcamposord & " "  & petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.idirord).Skip(skip).Take(petiaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagtamano).ToList
		End If
		'
		If (respaipinslimsinmobrpaglist.lista_aipinslimsinmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinslimsinmobrxwheredinamicocount(sb)
		respaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagtamano)
		Else
		respaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagcantidad = 0
		respaipinslimsinmobrpaglist.pagaipinslimsinmobr.npagactual = 0
		End If
	
		Return respaipinslimsinmobrpaglist
	End Function

	Public Function selaipinslimsinmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinslimsinmobr.count
	Else
	Return _db.aipinslimsinmobr.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinslimsinmobr(aipinslimsinmobr as aipinslimsinmobr) as respopera
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
	param8.ParameterName = "p_idaipinslimsinmobr"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinmobr.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinmobr.ncantinslimsinmobr
	param11.ParameterName = "p_ncantinslimsinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinmobr.nprecfininslimsinmobr
	param12.ParameterName = "p_nprecfininslimsinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinmobr.xdescinslimsinmobr IsNot Nothing Then
	param13.Value = aipinslimsinmobr.xdescinslimsinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinmobr.iestatinslimsinmobr IsNot Nothing Then
	param14.Value = aipinslimsinmobr.iestatinslimsinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinmobr output,@p_idaipinslimsin,@p_idaipbaremobr,@p_ncantinslimsinmobr,@p_nprecfininslimsinmobr,@p_xdescinslimsinmobr,@p_iestatinslimsinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinslimsinmobr(aipinslimsinmobr as aipinslimsinmobr) as respopera
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
	param8.Value = aipinslimsinmobr.idaipinslimsinmobr
	param8.ParameterName = "p_idaipinslimsinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinmobr.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinmobr.ncantinslimsinmobr
	param11.ParameterName = "p_ncantinslimsinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinmobr.nprecfininslimsinmobr
	param12.ParameterName = "p_nprecfininslimsinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinmobr.xdescinslimsinmobr IsNot Nothing Then
	param13.Value = aipinslimsinmobr.xdescinslimsinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinmobr.iestatinslimsinmobr IsNot Nothing Then
	param14.Value = aipinslimsinmobr.iestatinslimsinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinmobr output,@p_idaipinslimsin,@p_idaipbaremobr,@p_ncantinslimsinmobr,@p_nprecfininslimsinmobr,@p_xdescinslimsinmobr,@p_iestatinslimsinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsinmobr(aipinslimsinmobr as aipinslimsinmobr) as respopera
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
	param8.Value = aipinslimsinmobr.idaipinslimsinmobr
	param8.ParameterName = "p_idaipinslimsinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinmobr.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinmobr.ncantinslimsinmobr
	param11.ParameterName = "p_ncantinslimsinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinmobr.nprecfininslimsinmobr
	param12.ParameterName = "p_nprecfininslimsinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinmobr.xdescinslimsinmobr IsNot Nothing Then
	param13.Value = aipinslimsinmobr.xdescinslimsinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinmobr.iestatinslimsinmobr IsNot Nothing Then
	param14.Value = aipinslimsinmobr.iestatinslimsinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinmobr output,@p_idaipinslimsin,@p_idaipbaremobr,@p_ncantinslimsinmobr,@p_nprecfininslimsinmobr,@p_xdescinslimsinmobr,@p_iestatinslimsinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsinmobr(idaipinslimsinmobr as decimal) as respopera
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
	param8.Value = idaipinslimsinmobr
	param8.ParameterName = "p_idaipinslimsinmobr"
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
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinslimsinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininslimsinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = ""
	param13.ParameterName = "p_xdescinslimsinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
                param14.Value = ""
                param14.ParameterName = "p_iestatinslimsinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinmobr output,@p_idaipinslimsin,@p_idaipbaremobr,@p_ncantinslimsinmobr,@p_nprecfininslimsinmobr,@p_xdescinslimsinmobr,@p_iestatinslimsinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinslimsinmobr(aipinslimsinmobr as aipinslimsinmobr) as respopera
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
	param8.Value = aipinslimsinmobr.idaipinslimsinmobr
	param8.ParameterName = "p_idaipinslimsinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinmobr.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinmobr.ncantinslimsinmobr
	param11.ParameterName = "p_ncantinslimsinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinmobr.nprecfininslimsinmobr
	param12.ParameterName = "p_nprecfininslimsinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinmobr.xdescinslimsinmobr IsNot Nothing Then
	param13.Value = aipinslimsinmobr.xdescinslimsinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinmobr.iestatinslimsinmobr IsNot Nothing Then
	param14.Value = aipinslimsinmobr.iestatinslimsinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinmobr output,@p_idaipinslimsin,@p_idaipbaremobr,@p_ncantinslimsinmobr,@p_nprecfininslimsinmobr,@p_xdescinslimsinmobr,@p_iestatinslimsinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinslimsinmobr(aipinslimsinmobr as aipinslimsinmobr) as respopera
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
	param8.Value = aipinslimsinmobr.idaipinslimsinmobr
	param8.ParameterName = "p_idaipinslimsinmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsinmobr.idaipinslimsin
	param9.ParameterName = "p_idaipinslimsin"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsinmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsinmobr.ncantinslimsinmobr
	param11.ParameterName = "p_ncantinslimsinmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsinmobr.nprecfininslimsinmobr
	param12.ParameterName = "p_nprecfininslimsinmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsinmobr.xdescinslimsinmobr IsNot Nothing Then
	param13.Value = aipinslimsinmobr.xdescinslimsinmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsinmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsinmobr.iestatinslimsinmobr IsNot Nothing Then
	param14.Value = aipinslimsinmobr.iestatinslimsinmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsinmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsinmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsinmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsinmobr output,@p_idaipinslimsin,@p_idaipbaremobr,@p_ncantinslimsinmobr,@p_nprecfininslimsinmobr,@p_xdescinslimsinmobr,@p_iestatinslimsinmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
