Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.baremo
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipbarerepuController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipbarerepuxid(idaipbarerepu As Decimal) As aipbarerepu
		Dim aipbarerepu As aipbarerepu = (From p In _db.aipbarerepu
										Where p.idaipbarerepu = idaipbarerepu
										Select p).SingleOrDefault
		Return aipbarerepu
	End Function

	<HttpPost()> _
	Public Function selaipbarerepu() As List(Of aipbarerepu)
		Dim lista_aipbarerepu As List(Of aipbarerepu) = (From p In _db.aipbarerepu
													Select p).ToList
		'
		Return lista_aipbarerepu
	End Function

<HttpPost()> _
	Public Function selaipbarerepuxwheredinamicopag(petiaipbarerepupaglist as petiaipbarerepupaglist) as respaipbarerepupaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipbarerepupaglist.aipbarerepu.idaipbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.idaipbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipbarerepu=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.idaipbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipbarerepupaglist.aipbarerepu.idaipmanrepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanrepu=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.idaipmanrepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanrepu=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.idaipmanrepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipbarerepupaglist.aipbarerepu.faplibarerepu > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petiaipbarerepupaglist.aipbarerepu.faplibarerepu)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.faplibarerepu >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petiaipbarerepupaglist.aipbarerepu.faplibarerepu)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petiaipbarerepupaglist.aipbarerepu.iorigbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iorigbarerepu='")
				sb.Append(petiaipbarerepupaglist.aipbarerepu.iorigbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iorigbarerepu='")
				sb.Append(petiaipbarerepupaglist.aipbarerepu.iorigbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbarerepupaglist.aipbarerepu.mcostbarerepu <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mcostbarerepu=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.mcostbarerepu))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mcostbarerepu=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.mcostbarerepu))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipbarerepupaglist.aipbarerepu.xdescbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescbarerepu='")
				sb.Append(petiaipbarerepupaglist.aipbarerepu.xdescbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescbarerepu='")
				sb.Append(petiaipbarerepupaglist.aipbarerepu.xdescbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbarerepupaglist.aipbarerepu.iestatbarerepu <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatbarerepu='")
				sb.Append(petiaipbarerepupaglist.aipbarerepu.iestatbarerepu)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatbarerepu='")
				sb.Append(petiaipbarerepupaglist.aipbarerepu.iestatbarerepu)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipbarerepupaglist.aipbarerepu.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipbarerepupaglist.aipbarerepu.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipbarerepupaglist As New respaipbarerepupaglist
	respaipbarerepupaglist.pagaipbarerepu = petiaipbarerepupaglist.pagaipbarerepu
	Dim skip = skip_paginacion(petiaipbarerepupaglist.pagaipbarerepu.npagactual, petiaipbarerepupaglist.pagaipbarerepu.npagtamano)
	
		If sb.ToString = "" Then
			respaipbarerepupaglist.lista_aipbarerepu = _db.aipbarerepu.OrderBy(petiaipbarerepupaglist.pagaipbarerepu.xcamposord & " "  & petiaipbarerepupaglist.pagaipbarerepu.idirord).Skip(skip).Take(petiaipbarerepupaglist.pagaipbarerepu.npagtamano).ToList
		Else
			respaipbarerepupaglist.lista_aipbarerepu = _db.aipbarerepu.Where(sb.ToString).OrderBy(petiaipbarerepupaglist.pagaipbarerepu.xcamposord & " "  & petiaipbarerepupaglist.pagaipbarerepu.idirord).Skip(skip).Take(petiaipbarerepupaglist.pagaipbarerepu.npagtamano).ToList
		End If
		'
		If (respaipbarerepupaglist.lista_aipbarerepu.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipbarerepuxwheredinamicocount(sb)
		respaipbarerepupaglist.pagaipbarerepu.npagcantidad = cantidad_paginas(cant_entero_reg, respaipbarerepupaglist.pagaipbarerepu.npagtamano)
		Else
		respaipbarerepupaglist.pagaipbarerepu.npagcantidad = 0
		respaipbarerepupaglist.pagaipbarerepu.npagactual = 0
		End If
	
		Return respaipbarerepupaglist
	End Function

	Public Function selaipbarerepuxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipbarerepu.count
	Else
	Return _db.aipbarerepu.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipbarerepu(aipbarerepu as aipbarerepu) as respopera
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
	param8.ParameterName = "p_idaipbarerepu"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbarerepu.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbarerepu.faplibarerepu > cdate("01-01-1900") Then
	param10.Value = aipbarerepu.faplibarerepu
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipbarerepu.iorigbarerepu IsNot Nothing Then
	param11.Value = aipbarerepu.iorigbarerepu
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iorigbarerepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipbarerepu.mcostbarerepu
	param12.ParameterName = "p_mcostbarerepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipbarerepu.xdescbarerepu IsNot Nothing Then
	param13.Value = aipbarerepu.xdescbarerepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescbarerepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipbarerepu.iestatbarerepu IsNot Nothing Then
	param14.Value = aipbarerepu.iestatbarerepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatbarerepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbarerepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbarerepu output,@p_idaipmanrepu,@p_faplibarerepu,@p_iorigbarerepu,@p_mcostbarerepu,@p_xdescbarerepu,@p_iestatbarerepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function modaipbarerepu(aipbarerepu as aipbarerepu) as respopera
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
	param8.Value = aipbarerepu.idaipbarerepu
	param8.ParameterName = "p_idaipbarerepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbarerepu.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbarerepu.faplibarerepu > cdate("01-01-1900") Then
	param10.Value = aipbarerepu.faplibarerepu
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipbarerepu.iorigbarerepu IsNot Nothing Then
	param11.Value = aipbarerepu.iorigbarerepu
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iorigbarerepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipbarerepu.mcostbarerepu
	param12.ParameterName = "p_mcostbarerepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipbarerepu.xdescbarerepu IsNot Nothing Then
	param13.Value = aipbarerepu.xdescbarerepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescbarerepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipbarerepu.iestatbarerepu IsNot Nothing Then
	param14.Value = aipbarerepu.iestatbarerepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatbarerepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipbarerepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbarerepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbarerepu output,@p_idaipmanrepu,@p_faplibarerepu,@p_iorigbarerepu,@p_mcostbarerepu,@p_xdescbarerepu,@p_iestatbarerepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipbarerepu(aipbarerepu as aipbarerepu) as respopera
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
	param8.Value = aipbarerepu.idaipbarerepu
	param8.ParameterName = "p_idaipbarerepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbarerepu.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbarerepu.faplibarerepu > cdate("01-01-1900") Then
	param10.Value = aipbarerepu.faplibarerepu
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipbarerepu.iorigbarerepu IsNot Nothing Then
	param11.Value = aipbarerepu.iorigbarerepu
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iorigbarerepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipbarerepu.mcostbarerepu
	param12.ParameterName = "p_mcostbarerepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipbarerepu.xdescbarerepu IsNot Nothing Then
	param13.Value = aipbarerepu.xdescbarerepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescbarerepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipbarerepu.iestatbarerepu IsNot Nothing Then
	param14.Value = aipbarerepu.iestatbarerepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatbarerepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipbarerepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbarerepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbarerepu output,@p_idaipmanrepu,@p_faplibarerepu,@p_iorigbarerepu,@p_mcostbarerepu,@p_xdescbarerepu,@p_iestatbarerepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function eliaipbarerepu(idaipbarerepu as decimal) as respopera
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
	param8.Value = idaipbarerepu
	param8.ParameterName = "p_idaipbarerepu"
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
	param10.ParameterName = "p_faplibarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	param11.Value = "
	param11.ParameterName = "p_iorigbarerepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = 0
	param12.ParameterName = "p_mcostbarerepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = "
	param13.ParameterName = "p_xdescbarerepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	param14.Value = "
	param14.ParameterName = "p_iestatbarerepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = 0
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbarerepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbarerepu output,@p_idaipmanrepu,@p_faplibarerepu,@p_iorigbarerepu,@p_mcostbarerepu,@p_xdescbarerepu,@p_iestatbarerepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function actaipbarerepu(aipbarerepu as aipbarerepu) as respopera
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
	param8.Value = aipbarerepu.idaipbarerepu
	param8.ParameterName = "p_idaipbarerepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbarerepu.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbarerepu.faplibarerepu > cdate("01-01-1900") Then
	param10.Value = aipbarerepu.faplibarerepu
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipbarerepu.iorigbarerepu IsNot Nothing Then
	param11.Value = aipbarerepu.iorigbarerepu
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iorigbarerepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipbarerepu.mcostbarerepu
	param12.ParameterName = "p_mcostbarerepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipbarerepu.xdescbarerepu IsNot Nothing Then
	param13.Value = aipbarerepu.xdescbarerepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescbarerepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipbarerepu.iestatbarerepu IsNot Nothing Then
	param14.Value = aipbarerepu.iestatbarerepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatbarerepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipbarerepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbarerepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbarerepu output,@p_idaipmanrepu,@p_faplibarerepu,@p_iorigbarerepu,@p_mcostbarerepu,@p_xdescbarerepu,@p_iestatbarerepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
	Public Function desaipbarerepu(aipbarerepu as aipbarerepu) as respopera
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
	param8.Value = aipbarerepu.idaipbarerepu
	param8.ParameterName = "p_idaipbarerepu"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipbarerepu.idaipmanrepu
	param9.ParameterName = "p_idaipmanrepu"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.datetime
	If aipbarerepu.faplibarerepu > cdate("01-01-1900") Then
	param10.Value = aipbarerepu.faplibarerepu
	else
	param10.Value = cdate("01-01-1900")
	end if
	param10.ParameterName = "p_faplibarerepu"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipbarerepu.iorigbarerepu IsNot Nothing Then
	param11.Value = aipbarerepu.iorigbarerepu
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iorigbarerepu"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 2
	param12.Value = aipbarerepu.mcostbarerepu
	param12.ParameterName = "p_mcostbarerepu"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If aipbarerepu.xdescbarerepu IsNot Nothing Then
	param13.Value = aipbarerepu.xdescbarerepu
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdescbarerepu"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.varchar
	param14.Size = 20
	If aipbarerepu.iestatbarerepu IsNot Nothing Then
	param14.Value = aipbarerepu.iestatbarerepu
	else
	param14.Value = ""
	end if
	param14.ParameterName = "p_iestatbarerepu"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.decimal
	param15.Precision = 18
	param15.Scale = 0
	param15.Value = aipbarerepu.idseglogreg
	param15.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipbarerepu @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipbarerepu output,@p_idaipmanrepu,@p_faplibarerepu,@p_iorigbarerepu,@p_mcostbarerepu,@p_xdescbarerepu,@p_iestatbarerepu,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15)
	
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
