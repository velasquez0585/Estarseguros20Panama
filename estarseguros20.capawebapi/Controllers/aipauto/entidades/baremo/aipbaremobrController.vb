Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipbaremobrController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipbaremobrxid(idaipbaremobr As Decimal) As aipbaremobr
		Dim aipbaremobr As aipbaremobr = (From p In _db.aipbaremobr
										Where p.idaipbaremobr = idaipbaremobr
										Select p).SingleOrDefault
		Return aipbaremobr
	End Function

	<HttpPost()> _
	Public Function selaipbaremobr() As List(Of aipbaremobr)
		Dim lista_aipbaremobr As List(Of aipbaremobr) = (From p In _db.aipbaremobr
													Select p).ToList
		'
		Return lista_aipbaremobr
	End Function

<HttpPost()> _
	Public Function selaipbaremobrxwheredinamicopag(petiaipbaremobrpaglist as petiaipbaremobrpaglist) as respaipbaremobrpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipbaremobrpaglist.aipbaremobr.idaipbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.idaipbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbaremobr=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.idaipbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.faplibaremobr > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petiaipbaremobrpaglist.aipbaremobr.faplibaremobr)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibaremobr >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petiaipbaremobrpaglist.aipbaremobr.faplibaremobr)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.itipobaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipobaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.itipobaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipobaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.itipobaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.itamapiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itamapiezbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.itamapiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itamapiezbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.itamapiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.imaterpiezbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.imaterpiezbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.imaterpiezbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imaterpiezbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.imaterpiezbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.mcostbaremobr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbaremobr=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.mcostbaremobr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbaremobr=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.mcostbaremobr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.xdescbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.xdescbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.xdescbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.iestatbaremobr <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.iestatbaremobr)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatbaremobr='")
				sb.Append(petiaipbaremobrpaglist.aipbaremobr.iestatbaremobr)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbaremobrpaglist.aipbaremobr.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipbaremobrpaglist.aipbaremobr.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipbaremobrpaglist As New respaipbaremobrpaglist
	respaipbaremobrpaglist.pagaipbaremobr = petiaipbaremobrpaglist.pagaipbaremobr
	Dim skip = skip_paginacion(petiaipbaremobrpaglist.pagaipbaremobr.npagactual, petiaipbaremobrpaglist.pagaipbaremobr.npagtamano)
	
		If sb.ToString = "" Then
			respaipbaremobrpaglist.lista_aipbaremobr = _db.aipbaremobr.OrderBy(petiaipbaremobrpaglist.pagaipbaremobr.xcamposord & " "  & petiaipbaremobrpaglist.pagaipbaremobr.idirord).Skip(skip).Take(petiaipbaremobrpaglist.pagaipbaremobr.npagtamano).ToList
		Else
			respaipbaremobrpaglist.lista_aipbaremobr = _db.aipbaremobr.Where(sb.ToString).OrderBy(petiaipbaremobrpaglist.pagaipbaremobr.xcamposord & " "  & petiaipbaremobrpaglist.pagaipbaremobr.idirord).Skip(skip).Take(petiaipbaremobrpaglist.pagaipbaremobr.npagtamano).ToList
		End If
		'
		If (respaipbaremobrpaglist.lista_aipbaremobr.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipbaremobrxwheredinamicocount(sb)
		respaipbaremobrpaglist.pagaipbaremobr.npagcantidad = cantidad_paginas(cant_entero_reg, respaipbaremobrpaglist.pagaipbaremobr.npagtamano)
		Else
		respaipbaremobrpaglist.pagaipbaremobr.npagcantidad = 0
		respaipbaremobrpaglist.pagaipbaremobr.npagactual = 0
		End If
	
		Return respaipbaremobrpaglist
	End Function

	Public Function selaipbaremobrxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipbaremobr.count
	Else
	Return _db.aipbaremobr.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipbaremobr(aipbaremobr as aipbaremobr) as respopera
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
	param8.ParameterName = "p_idaipbaremobr"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbaremobr.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbaremobr.faplibaremobr > cdate("01-01-1900") Then
	param10.Value = aipbaremobr.faplibaremobr
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipbaremobr.itipobaremobr IsNot Nothing Then
	param11.Value = aipbaremobr.itipobaremobr
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipobaremobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If aipbaremobr.itamapiezbaremobr IsNot Nothing Then
	param12.Value = aipbaremobr.itamapiezbaremobr
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itamapiezbaremobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If aipbaremobr.imaterpiezbaremobr IsNot Nothing Then
	param13.Value = aipbaremobr.imaterpiezbaremobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_imaterpiezbaremobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 2
	param14.Value = aipbaremobr.mcostbaremobr
	param14.ParameterName = "p_mcostbaremobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipbaremobr.xdescbaremobr IsNot Nothing Then
	param15.Value = aipbaremobr.xdescbaremobr
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdescbaremobr"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
	If aipbaremobr.iestatbaremobr IsNot Nothing Then
	param16.Value = aipbaremobr.iestatbaremobr
	else
	param16.Value = ""
	end if
	param16.ParameterName = "p_iestatbaremobr"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 0
	param17.Value = 0
	param17.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbaremobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbaremobr output,@p_idaipmanrepu,@p_faplibaremobr,@p_itipobaremobr,@p_itamapiezbaremobr,@p_imaterpiezbaremobr,@p_mcostbaremobr,@p_xdescbaremobr,@p_iestatbaremobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17)
	
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
	Public Function modaipbaremobr(aipbaremobr as aipbaremobr) as respopera
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
	param8.Value = aipbaremobr.idaipbaremobr
	param8.ParameterName = "p_idaipbaremobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbaremobr.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbaremobr.faplibaremobr > cdate("01-01-1900") Then
	param10.Value = aipbaremobr.faplibaremobr
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipbaremobr.itipobaremobr IsNot Nothing Then
	param11.Value = aipbaremobr.itipobaremobr
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipobaremobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If aipbaremobr.itamapiezbaremobr IsNot Nothing Then
	param12.Value = aipbaremobr.itamapiezbaremobr
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itamapiezbaremobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If aipbaremobr.imaterpiezbaremobr IsNot Nothing Then
	param13.Value = aipbaremobr.imaterpiezbaremobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_imaterpiezbaremobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 2
	param14.Value = aipbaremobr.mcostbaremobr
	param14.ParameterName = "p_mcostbaremobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipbaremobr.xdescbaremobr IsNot Nothing Then
	param15.Value = aipbaremobr.xdescbaremobr
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdescbaremobr"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
	If aipbaremobr.iestatbaremobr IsNot Nothing Then
	param16.Value = aipbaremobr.iestatbaremobr
	else
	param16.Value = ""
	end if
	param16.ParameterName = "p_iestatbaremobr"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 0
	param17.Value = aipbaremobr.idseglogreg
	param17.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbaremobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbaremobr output,@p_idaipmanrepu,@p_faplibaremobr,@p_itipobaremobr,@p_itamapiezbaremobr,@p_imaterpiezbaremobr,@p_mcostbaremobr,@p_xdescbaremobr,@p_iestatbaremobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17)
	
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
	Public Function eliaipbaremobr(aipbaremobr as aipbaremobr) as respopera
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
	param8.Value = aipbaremobr.idaipbaremobr
	param8.ParameterName = "p_idaipbaremobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbaremobr.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbaremobr.faplibaremobr > cdate("01-01-1900") Then
	param10.Value = aipbaremobr.faplibaremobr
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipbaremobr.itipobaremobr IsNot Nothing Then
	param11.Value = aipbaremobr.itipobaremobr
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipobaremobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If aipbaremobr.itamapiezbaremobr IsNot Nothing Then
	param12.Value = aipbaremobr.itamapiezbaremobr
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itamapiezbaremobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If aipbaremobr.imaterpiezbaremobr IsNot Nothing Then
	param13.Value = aipbaremobr.imaterpiezbaremobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_imaterpiezbaremobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 2
	param14.Value = aipbaremobr.mcostbaremobr
	param14.ParameterName = "p_mcostbaremobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipbaremobr.xdescbaremobr IsNot Nothing Then
	param15.Value = aipbaremobr.xdescbaremobr
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdescbaremobr"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
	If aipbaremobr.iestatbaremobr IsNot Nothing Then
	param16.Value = aipbaremobr.iestatbaremobr
	else
	param16.Value = ""
	end if
	param16.ParameterName = "p_iestatbaremobr"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 0
	param17.Value = aipbaremobr.idseglogreg
	param17.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbaremobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbaremobr output,@p_idaipmanrepu,@p_faplibaremobr,@p_itipobaremobr,@p_itamapiezbaremobr,@p_imaterpiezbaremobr,@p_mcostbaremobr,@p_xdescbaremobr,@p_iestatbaremobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17)
	
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
	Public Function eliaipbaremobr(idaipbaremobr as decimal) as respopera
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
	param8.Value = idaipbaremobr
	param8.ParameterName = "p_idaipbaremobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	param10.Value = cdate("01-01-1900")
	param10.ParameterName = "p_faplibaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
                param11.Value = ""
                param11.ParameterName = "p_itipobaremobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	param12.Value = ""
	param12.ParameterName = "p_itamapiezbaremobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
                param13.Value = ""
                param13.ParameterName = "p_imaterpiezbaremobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 2
	param14.Value = 0
	param14.ParameterName = "p_mcostbaremobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	param15.Value = ""
	param15.ParameterName = "p_xdescbaremobr"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
                param16.Value = ""
                param16.ParameterName = "p_iestatbaremobr"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 0
	param17.Value = 0
	param17.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbaremobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbaremobr output,@p_idaipmanrepu,@p_faplibaremobr,@p_itipobaremobr,@p_itamapiezbaremobr,@p_imaterpiezbaremobr,@p_mcostbaremobr,@p_xdescbaremobr,@p_iestatbaremobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17)
	
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
	Public Function actaipbaremobr(aipbaremobr as aipbaremobr) as respopera
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
	param8.Value = aipbaremobr.idaipbaremobr
	param8.ParameterName = "p_idaipbaremobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbaremobr.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbaremobr.faplibaremobr > cdate("01-01-1900") Then
	param10.Value = aipbaremobr.faplibaremobr
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipbaremobr.itipobaremobr IsNot Nothing Then
	param11.Value = aipbaremobr.itipobaremobr
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipobaremobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If aipbaremobr.itamapiezbaremobr IsNot Nothing Then
	param12.Value = aipbaremobr.itamapiezbaremobr
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itamapiezbaremobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If aipbaremobr.imaterpiezbaremobr IsNot Nothing Then
	param13.Value = aipbaremobr.imaterpiezbaremobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_imaterpiezbaremobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 2
	param14.Value = aipbaremobr.mcostbaremobr
	param14.ParameterName = "p_mcostbaremobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipbaremobr.xdescbaremobr IsNot Nothing Then
	param15.Value = aipbaremobr.xdescbaremobr
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdescbaremobr"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
	If aipbaremobr.iestatbaremobr IsNot Nothing Then
	param16.Value = aipbaremobr.iestatbaremobr
	else
	param16.Value = ""
	end if
	param16.ParameterName = "p_iestatbaremobr"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 0
	param17.Value = aipbaremobr.idseglogreg
	param17.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbaremobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbaremobr output,@p_idaipmanrepu,@p_faplibaremobr,@p_itipobaremobr,@p_itamapiezbaremobr,@p_imaterpiezbaremobr,@p_mcostbaremobr,@p_xdescbaremobr,@p_iestatbaremobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17)
	
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
	Public Function desaipbaremobr(aipbaremobr as aipbaremobr) as respopera
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
	param8.Value = aipbaremobr.idaipbaremobr
	param8.ParameterName = "p_idaipbaremobr"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbaremobr.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbaremobr.faplibaremobr > cdate("01-01-1900") Then
	param10.Value = aipbaremobr.faplibaremobr
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibaremobr"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipbaremobr.itipobaremobr IsNot Nothing Then
	param11.Value = aipbaremobr.itipobaremobr
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipobaremobr"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 50
	If aipbaremobr.itamapiezbaremobr IsNot Nothing Then
	param12.Value = aipbaremobr.itamapiezbaremobr
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_itamapiezbaremobr"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 50
	If aipbaremobr.imaterpiezbaremobr IsNot Nothing Then
	param13.Value = aipbaremobr.imaterpiezbaremobr
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_imaterpiezbaremobr"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 2
	param14.Value = aipbaremobr.mcostbaremobr
	param14.ParameterName = "p_mcostbaremobr"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipbaremobr.xdescbaremobr IsNot Nothing Then
	param15.Value = aipbaremobr.xdescbaremobr
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdescbaremobr"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.varchar
	param16.Size = 20
	If aipbaremobr.iestatbaremobr IsNot Nothing Then
	param16.Value = aipbaremobr.iestatbaremobr
	else
	param16.Value = ""
	end if
	param16.ParameterName = "p_iestatbaremobr"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 0
	param17.Value = aipbaremobr.idseglogreg
	param17.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbaremobr @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbaremobr output,@p_idaipmanrepu,@p_faplibaremobr,@p_itipobaremobr,@p_itamapiezbaremobr,@p_imaterpiezbaremobr,@p_mcostbaremobr,@p_xdescbaremobr,@p_iestatbaremobr,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17)
	
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
