Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsmotivController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsmotivxid(idaipinsmotiv As Decimal) As aipinsmotiv
		Dim aipinsmotiv As aipinsmotiv = (From p In _db.aipinsmotiv
										Where p.idaipinsmotiv = idaipinsmotiv
										Select p).SingleOrDefault
		Return aipinsmotiv
	End Function

	<HttpPost()> _
	Public Function selaipinsmotiv() As List(Of aipinsmotiv)
		Dim lista_aipinsmotiv As List(Of aipinsmotiv) = (From p In _db.aipinsmotiv
													Select p).ToList
		'
		Return lista_aipinsmotiv
	End Function

<HttpPost()> _
	Public Function selaipinsmotivxwheredinamicopag(petiaipinsmotivpaglist as petiaipinsmotivpaglist) as respaipinsmotivpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsmotivpaglist.aipinsmotiv.idaipinsmotiv <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsmotiv=")
				sb.Append(valor_entero(petiaipinsmotivpaglist.aipinsmotiv.idaipinsmotiv))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsmotiv=")
				sb.Append(valor_entero(petiaipinsmotivpaglist.aipinsmotiv.idaipinsmotiv))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsmotivpaglist.aipinsmotiv.xnominsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnominsmotiv='")
				sb.Append(petiaipinsmotivpaglist.aipinsmotiv.xnominsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnominsmotiv='")
				sb.Append(petiaipinsmotivpaglist.aipinsmotiv.xnominsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsmotivpaglist.aipinsmotiv.xdescinsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsmotiv='")
				sb.Append(petiaipinsmotivpaglist.aipinsmotiv.xdescinsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsmotiv='")
				sb.Append(petiaipinsmotivpaglist.aipinsmotiv.xdescinsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsmotivpaglist.aipinsmotiv.iestatinsmotiv <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsmotiv='")
				sb.Append(petiaipinsmotivpaglist.aipinsmotiv.iestatinsmotiv)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsmotiv='")
				sb.Append(petiaipinsmotivpaglist.aipinsmotiv.iestatinsmotiv)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsmotivpaglist.aipinsmotiv.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsmotivpaglist.aipinsmotiv.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsmotivpaglist.aipinsmotiv.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsmotivpaglist As New respaipinsmotivpaglist
	respaipinsmotivpaglist.pagaipinsmotiv = petiaipinsmotivpaglist.pagaipinsmotiv
	Dim skip = skip_paginacion(petiaipinsmotivpaglist.pagaipinsmotiv.npagactual, petiaipinsmotivpaglist.pagaipinsmotiv.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsmotivpaglist.lista_aipinsmotiv = _db.aipinsmotiv.OrderBy(petiaipinsmotivpaglist.pagaipinsmotiv.xcamposord & " "  & petiaipinsmotivpaglist.pagaipinsmotiv.idirord).Skip(skip).Take(petiaipinsmotivpaglist.pagaipinsmotiv.npagtamano).ToList
		Else
			respaipinsmotivpaglist.lista_aipinsmotiv = _db.aipinsmotiv.Where(sb.ToString).OrderBy(petiaipinsmotivpaglist.pagaipinsmotiv.xcamposord & " "  & petiaipinsmotivpaglist.pagaipinsmotiv.idirord).Skip(skip).Take(petiaipinsmotivpaglist.pagaipinsmotiv.npagtamano).ToList
		End If
		'
		If (respaipinsmotivpaglist.lista_aipinsmotiv.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsmotivxwheredinamicocount(sb)
		respaipinsmotivpaglist.pagaipinsmotiv.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsmotivpaglist.pagaipinsmotiv.npagtamano)
		Else
		respaipinsmotivpaglist.pagaipinsmotiv.npagcantidad = 0
		respaipinsmotivpaglist.pagaipinsmotiv.npagactual = 0
		End If
	
		Return respaipinsmotivpaglist
	End Function

	Public Function selaipinsmotivxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsmotiv.count
	Else
	Return _db.aipinsmotiv.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsmotiv(aipinsmotiv as aipinsmotiv) as respopera
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
	param8.ParameterName = "p_idaipinsmotiv"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipinsmotiv.xnominsmotiv IsNot Nothing Then
	param9.Value = aipinsmotiv.xnominsmotiv
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnominsmotiv"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipinsmotiv.xdescinsmotiv IsNot Nothing Then
	param10.Value = aipinsmotiv.xdescinsmotiv
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescinsmotiv"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipinsmotiv.iestatinsmotiv IsNot Nothing Then
	param11.Value = aipinsmotiv.iestatinsmotiv
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatinsmotiv"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsmotiv output,@p_xnominsmotiv,@p_xdescinsmotiv,@p_iestatinsmotiv,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function modaipinsmotiv(aipinsmotiv as aipinsmotiv) as respopera
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
	param8.Value = aipinsmotiv.idaipinsmotiv
	param8.ParameterName = "p_idaipinsmotiv"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipinsmotiv.xnominsmotiv IsNot Nothing Then
	param9.Value = aipinsmotiv.xnominsmotiv
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnominsmotiv"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipinsmotiv.xdescinsmotiv IsNot Nothing Then
	param10.Value = aipinsmotiv.xdescinsmotiv
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescinsmotiv"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipinsmotiv.iestatinsmotiv IsNot Nothing Then
	param11.Value = aipinsmotiv.iestatinsmotiv
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatinsmotiv"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipinsmotiv.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsmotiv output,@p_xnominsmotiv,@p_xdescinsmotiv,@p_iestatinsmotiv,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipinsmotiv(aipinsmotiv as aipinsmotiv) as respopera
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
	param8.Value = aipinsmotiv.idaipinsmotiv
	param8.ParameterName = "p_idaipinsmotiv"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipinsmotiv.xnominsmotiv IsNot Nothing Then
	param9.Value = aipinsmotiv.xnominsmotiv
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnominsmotiv"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipinsmotiv.xdescinsmotiv IsNot Nothing Then
	param10.Value = aipinsmotiv.xdescinsmotiv
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescinsmotiv"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipinsmotiv.iestatinsmotiv IsNot Nothing Then
	param11.Value = aipinsmotiv.iestatinsmotiv
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatinsmotiv"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipinsmotiv.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsmotiv output,@p_xnominsmotiv,@p_xdescinsmotiv,@p_iestatinsmotiv,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipinsmotiv(idaipinsmotiv as decimal) as respopera
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
	param8.Value = idaipinsmotiv
	param8.ParameterName = "p_idaipinsmotiv"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xnominsmotiv"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	param10.Value = "
	param10.ParameterName = "p_xdescinsmotiv"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	param11.Value = "
	param11.ParameterName = "p_iestatinsmotiv"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsmotiv output,@p_xnominsmotiv,@p_xdescinsmotiv,@p_iestatinsmotiv,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function actaipinsmotiv(aipinsmotiv as aipinsmotiv) as respopera
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
	param8.Value = aipinsmotiv.idaipinsmotiv
	param8.ParameterName = "p_idaipinsmotiv"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipinsmotiv.xnominsmotiv IsNot Nothing Then
	param9.Value = aipinsmotiv.xnominsmotiv
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnominsmotiv"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipinsmotiv.xdescinsmotiv IsNot Nothing Then
	param10.Value = aipinsmotiv.xdescinsmotiv
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescinsmotiv"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipinsmotiv.iestatinsmotiv IsNot Nothing Then
	param11.Value = aipinsmotiv.iestatinsmotiv
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatinsmotiv"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipinsmotiv.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsmotiv output,@p_xnominsmotiv,@p_xdescinsmotiv,@p_iestatinsmotiv,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function desaipinsmotiv(aipinsmotiv as aipinsmotiv) as respopera
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
	param8.Value = aipinsmotiv.idaipinsmotiv
	param8.ParameterName = "p_idaipinsmotiv"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipinsmotiv.xnominsmotiv IsNot Nothing Then
	param9.Value = aipinsmotiv.xnominsmotiv
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnominsmotiv"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipinsmotiv.xdescinsmotiv IsNot Nothing Then
	param10.Value = aipinsmotiv.xdescinsmotiv
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescinsmotiv"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipinsmotiv.iestatinsmotiv IsNot Nothing Then
	param11.Value = aipinsmotiv.iestatinsmotiv
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatinsmotiv"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipinsmotiv.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsmotiv @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsmotiv output,@p_xnominsmotiv,@p_xdescinsmotiv,@p_iestatinsmotiv,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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

        'metodos no automaticos
        <HttpPost()> _
        Public Function selaipinsmotivactivos() As List(Of aipinsmotiv)
            Dim lista_aipinsmotiv As List(Of aipinsmotiv) = (From p In _db.aipinsmotiv
                                                               Where p.iestatinsmotiv = "ACTIVO"
                                                        Select p).ToList

            Dim aipinsmotiv As New aipinsmotiv
            aipinsmotiv.idaipinsmotiv = 0
            aipinsmotiv.idseglogreg = 0
            aipinsmotiv.iestatinsmotiv = ""
            aipinsmotiv.xdescinsmotiv = ""
            aipinsmotiv.xnominsmotiv = "SELECCIONE..."
            lista_aipinsmotiv.Insert(0, aipinsmotiv)

            '
            Return lista_aipinsmotiv
        End Function


        <HttpPost()> _
        Public Function selaipinsmotivactivosportipo(itipoinsmotiv As String) As List(Of aipinsmotiv)
            Dim lista_aipinsmotiv As List(Of aipinsmotiv) = (From p In _db.aipinsmotiv
                                                               Where p.itipoinsmotiv = itipoinsmotiv and p.iestatinsmotiv = "ACTIVO"
                                                        Select p).ToList

            Dim aipinsmotiv As New aipinsmotiv
            aipinsmotiv.idaipinsmotiv = 0
            aipinsmotiv.idseglogreg = 0
            aipinsmotiv.iestatinsmotiv = ""
            aipinsmotiv.xdescinsmotiv = ""
            aipinsmotiv.xnominsmotiv = "SELECCIONE..."
            lista_aipinsmotiv.Insert(0, aipinsmotiv)

            '
            Return lista_aipinsmotiv
        End Function

        <HttpPost()> _
        Public Function selaipinsmotivactivosportipo2(itipoinsmotiv As String) As List(Of aipinsmotiv)
            Dim lista_aipinsmotiv As List(Of aipinsmotiv) = (From p In _db.aipinsmotiv
                                                               Where p.itipoinsmotiv = itipoinsmotiv And p.iestatinsmotiv = "ACTIVO"
                                                        Select p).ToList

            '
            Return lista_aipinsmotiv
        End Function

End Class
End Namespace
