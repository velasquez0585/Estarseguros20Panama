Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinslimsusmobrController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinslimsusmobrxid(idaipinslimsusmobr As Decimal) As aipinslimsusmobr
		Dim aipinslimsusmobr As aipinslimsusmobr = (From p In _db.aipinslimsusmobr
										Where p.idaipinslimsusmobr = idaipinslimsusmobr
										Select p).SingleOrDefault
		Return aipinslimsusmobr
	End Function

	<HttpPost()> _
	Public Function selaipinslimsusmobr() As List(Of aipinslimsusmobr)
		Dim lista_aipinslimsusmobr As List(Of aipinslimsusmobr) = (From p In _db.aipinslimsusmobr
													Select p).ToList
		'
		Return lista_aipinslimsusmobr
	End Function

<HttpPost()> _
	Public Function selaipinslimsusmobrxwheredinamicopag(petiaipinslimsusmobrpaglist as petiaipinslimsusmobrpaglist) as respaipinslimsusmobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipinslimsusmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsusmobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipinslimsusmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsusmobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipinslimsusmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsus=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsus=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.ncantinslimsusmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.ncantinslimsusmobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.ncantinslimsusmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.ncantinslimsusmobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.ncantinslimsusmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.nprecfininslimsusmobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nprecfininslimsusmobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.nprecfininslimsusmobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nprecfininslimsusmobr=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.nprecfininslimsusmobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.xdescinslimsusmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsusmobr='")
				sb.Append(petiaipinslimsusmobrpaglist.aipinslimsusmobr.xdescinslimsusmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsusmobr='")
				sb.Append(petiaipinslimsusmobrpaglist.aipinslimsusmobr.xdescinslimsusmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.iestatinslimsusmobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsusmobr='")
				sb.Append(petiaipinslimsusmobrpaglist.aipinslimsusmobr.iestatinslimsusmobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsusmobr='")
				sb.Append(petiaipinslimsusmobrpaglist.aipinslimsusmobr.iestatinslimsusmobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsusmobrpaglist.aipinslimsusmobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsusmobrpaglist.aipinslimsusmobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinslimsusmobrpaglist As New respaipinslimsusmobrpaglist
	respaipinslimsusmobrpaglist.pagaipinslimsusmobr = petiaipinslimsusmobrpaglist.pagaipinslimsusmobr
	Dim skip = skip_paginacion(petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagactual, petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagtamano)
	
		If sb.ToString = "" Then
			respaipinslimsusmobrpaglist.lista_aipinslimsusmobr = _db.aipinslimsusmobr.OrderBy(petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.xcamposord & " "  & petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.idirord).Skip(skip).Take(petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagtamano).ToList
		Else
			respaipinslimsusmobrpaglist.lista_aipinslimsusmobr = _db.aipinslimsusmobr.Where(sb.ToString).OrderBy(petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.xcamposord & " "  & petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.idirord).Skip(skip).Take(petiaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagtamano).ToList
		End If
		'
		If (respaipinslimsusmobrpaglist.lista_aipinslimsusmobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinslimsusmobrxwheredinamicocount(sb)
		respaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagtamano)
		Else
		respaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagcantidad = 0
		respaipinslimsusmobrpaglist.pagaipinslimsusmobr.npagactual = 0
		End If
	
		Return respaipinslimsusmobrpaglist
	End Function

	Public Function selaipinslimsusmobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinslimsusmobr.count
	Else
	Return _db.aipinslimsusmobr.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinslimsusmobr(aipinslimsusmobr as aipinslimsusmobr) as respopera
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
	param8.ParameterName = "p_idaipinslimsusmobr"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusmobr.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusmobr.ncantinslimsusmobr
	param11.ParameterName = "p_ncantinslimsusmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusmobr.nprecfininslimsusmobr
	param12.ParameterName = "p_nprecfininslimsusmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusmobr.xdescinslimsusmobr IsNot Nothing Then
	param13.Value = aipinslimsusmobr.xdescinslimsusmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusmobr.iestatinslimsusmobr IsNot Nothing Then
	param14.Value = aipinslimsusmobr.iestatinslimsusmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusmobr output,@p_idaipinslimsus,@p_idaipbaremobr,@p_ncantinslimsusmobr,@p_nprecfininslimsusmobr,@p_xdescinslimsusmobr,@p_iestatinslimsusmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipinslimsusmobr(aipinslimsusmobr as aipinslimsusmobr) as respopera
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
	param8.Value = aipinslimsusmobr.idaipinslimsusmobr
	param8.ParameterName = "p_idaipinslimsusmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusmobr.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusmobr.ncantinslimsusmobr
	param11.ParameterName = "p_ncantinslimsusmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusmobr.nprecfininslimsusmobr
	param12.ParameterName = "p_nprecfininslimsusmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusmobr.xdescinslimsusmobr IsNot Nothing Then
	param13.Value = aipinslimsusmobr.xdescinslimsusmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusmobr.iestatinslimsusmobr IsNot Nothing Then
	param14.Value = aipinslimsusmobr.iestatinslimsusmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusmobr output,@p_idaipinslimsus,@p_idaipbaremobr,@p_ncantinslimsusmobr,@p_nprecfininslimsusmobr,@p_xdescinslimsusmobr,@p_iestatinslimsusmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsusmobr(aipinslimsusmobr as aipinslimsusmobr) as respopera
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
	param8.Value = aipinslimsusmobr.idaipinslimsusmobr
	param8.ParameterName = "p_idaipinslimsusmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusmobr.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusmobr.ncantinslimsusmobr
	param11.ParameterName = "p_ncantinslimsusmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusmobr.nprecfininslimsusmobr
	param12.ParameterName = "p_nprecfininslimsusmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusmobr.xdescinslimsusmobr IsNot Nothing Then
	param13.Value = aipinslimsusmobr.xdescinslimsusmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusmobr.iestatinslimsusmobr IsNot Nothing Then
	param14.Value = aipinslimsusmobr.iestatinslimsusmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusmobr output,@p_idaipinslimsus,@p_idaipbaremobr,@p_ncantinslimsusmobr,@p_nprecfininslimsusmobr,@p_xdescinslimsusmobr,@p_iestatinslimsusmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipinslimsusmobr(idaipinslimsusmobr as decimal) as respopera
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
	param8.Value = idaipinslimsusmobr
	param8.ParameterName = "p_idaipinslimsusmobr"
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
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = 0
	param11.ParameterName = "p_ncantinslimsusmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_nprecfininslimsusmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = "
	param13.ParameterName = "p_xdescinslimsusmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	param14.Value = "
	param14.ParameterName = "p_iestatinslimsusmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusmobr output,@p_idaipinslimsus,@p_idaipbaremobr,@p_ncantinslimsusmobr,@p_nprecfininslimsusmobr,@p_xdescinslimsusmobr,@p_iestatinslimsusmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipinslimsusmobr(aipinslimsusmobr as aipinslimsusmobr) as respopera
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
	param8.Value = aipinslimsusmobr.idaipinslimsusmobr
	param8.ParameterName = "p_idaipinslimsusmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusmobr.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusmobr.ncantinslimsusmobr
	param11.ParameterName = "p_ncantinslimsusmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusmobr.nprecfininslimsusmobr
	param12.ParameterName = "p_nprecfininslimsusmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusmobr.xdescinslimsusmobr IsNot Nothing Then
	param13.Value = aipinslimsusmobr.xdescinslimsusmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusmobr.iestatinslimsusmobr IsNot Nothing Then
	param14.Value = aipinslimsusmobr.iestatinslimsusmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusmobr output,@p_idaipinslimsus,@p_idaipbaremobr,@p_ncantinslimsusmobr,@p_nprecfininslimsusmobr,@p_xdescinslimsusmobr,@p_iestatinslimsusmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipinslimsusmobr(aipinslimsusmobr as aipinslimsusmobr) as respopera
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
	param8.Value = aipinslimsusmobr.idaipinslimsusmobr
	param8.ParameterName = "p_idaipinslimsusmobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsusmobr.idaipinslimsus
	param9.ParameterName = "p_idaipinslimsus"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsusmobr.idaipbaremobr
	param10.ParameterName = "p_idaipbaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.smallint
	param11.Value = aipinslimsusmobr.ncantinslimsusmobr
	param11.ParameterName = "p_ncantinslimsusmobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipinslimsusmobr.nprecfininslimsusmobr
	param12.ParameterName = "p_nprecfininslimsusmobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipinslimsusmobr.xdescinslimsusmobr IsNot Nothing Then
	param13.Value = aipinslimsusmobr.xdescinslimsusmobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescinslimsusmobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipinslimsusmobr.iestatinslimsusmobr IsNot Nothing Then
	param14.Value = aipinslimsusmobr.iestatinslimsusmobr
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatinslimsusmobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipinslimsusmobr.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsusmobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsusmobr output,@p_idaipinslimsus,@p_idaipbaremobr,@p_ncantinslimsusmobr,@p_nprecfininslimsusmobr,@p_xdescinslimsusmobr,@p_iestatinslimsusmobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
