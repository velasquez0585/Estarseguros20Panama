Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmanvehmarController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmanvehmarxid(idaipmanvehmar As Decimal) As aipmanvehmar
            Dim aipmanvehmar As aipmanvehmar = (From p In _db.aipmanvehmar
                                            Where p.idaipmanvehmar = idaipmanvehmar
                                            Select p).SingleOrDefault
		Return aipmanvehmar
	End Function

	<HttpPost()> _
	Public Function selaipmanvehmar() As List(Of aipmanvehmar)
            Dim lista_aipmanvehmar As List(Of aipmanvehmar) = (From p In _db.aipmanvehmar
                                                               Where p.idaipmanvehmar > 0
                                                        Select p).ToList
		'
		Return lista_aipmanvehmar
	End Function

<HttpPost()> _
	Public Function selaipmanvehmarxwheredinamicopag(petiaipmanvehmarpaglist as petiaipmanvehmarpaglist) as respaipmanvehmarpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmanvehmarpaglist.aipmanvehmar.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petiaipmanvehmarpaglist.aipmanvehmar.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petiaipmanvehmarpaglist.aipmanvehmar.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmarpaglist.aipmanvehmar.xnommanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmar='")
				sb.Append(petiaipmanvehmarpaglist.aipmanvehmar.xnommanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmar='")
				sb.Append(petiaipmanvehmarpaglist.aipmanvehmar.xnommanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmarpaglist.aipmanvehmar.xdescmanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanvehmar='")
				sb.Append(petiaipmanvehmarpaglist.aipmanvehmar.xdescmanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanvehmar='")
				sb.Append(petiaipmanvehmarpaglist.aipmanvehmar.xdescmanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmarpaglist.aipmanvehmar.iestatmanvehmar <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehmar='")
				sb.Append(petiaipmanvehmarpaglist.aipmanvehmar.iestatmanvehmar)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehmar='")
				sb.Append(petiaipmanvehmarpaglist.aipmanvehmar.iestatmanvehmar)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmarpaglist.aipmanvehmar.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehmarpaglist.aipmanvehmar.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehmarpaglist.aipmanvehmar.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmanvehmarpaglist As New respaipmanvehmarpaglist
	respaipmanvehmarpaglist.pagaipmanvehmar = petiaipmanvehmarpaglist.pagaipmanvehmar
	Dim skip = skip_paginacion(petiaipmanvehmarpaglist.pagaipmanvehmar.npagactual, petiaipmanvehmarpaglist.pagaipmanvehmar.npagtamano)
	
		If sb.ToString = "" Then
			respaipmanvehmarpaglist.lista_aipmanvehmar = _db.aipmanvehmar.OrderBy(petiaipmanvehmarpaglist.pagaipmanvehmar.xcamposord & " "  & petiaipmanvehmarpaglist.pagaipmanvehmar.idirord).Skip(skip).Take(petiaipmanvehmarpaglist.pagaipmanvehmar.npagtamano).ToList
		Else
			respaipmanvehmarpaglist.lista_aipmanvehmar = _db.aipmanvehmar.Where(sb.ToString).OrderBy(petiaipmanvehmarpaglist.pagaipmanvehmar.xcamposord & " "  & petiaipmanvehmarpaglist.pagaipmanvehmar.idirord).Skip(skip).Take(petiaipmanvehmarpaglist.pagaipmanvehmar.npagtamano).ToList
		End If
		'
		If (respaipmanvehmarpaglist.lista_aipmanvehmar.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmanvehmarxwheredinamicocount(sb)
		respaipmanvehmarpaglist.pagaipmanvehmar.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanvehmarpaglist.pagaipmanvehmar.npagtamano)
		Else
		respaipmanvehmarpaglist.pagaipmanvehmar.npagcantidad = 0
		respaipmanvehmarpaglist.pagaipmanvehmar.npagactual = 0
		End If
	
		Return respaipmanvehmarpaglist
	End Function

	Public Function selaipmanvehmarxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmanvehmar.count
	Else
	Return _db.aipmanvehmar.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmanvehmar(aipmanvehmar as aipmanvehmar) as respopera
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
	param8.ParameterName = "p_idaipmanvehmar"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehmar.xnommanvehmar IsNot Nothing Then
	param9.Value = aipmanvehmar.xnommanvehmar
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehmar.xdescmanvehmar IsNot Nothing Then
	param10.Value = aipmanvehmar.xdescmanvehmar
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehmar"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmar.iestatmanvehmar IsNot Nothing Then
	param11.Value = aipmanvehmar.iestatmanvehmar
	else
                    param11.Value = "ACTIVA"
	end if
	param11.ParameterName = "p_iestatmanvehmar"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmar @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmar output,@p_xnommanvehmar,@p_xdescmanvehmar,@p_iestatmanvehmar,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function modaipmanvehmar(aipmanvehmar as aipmanvehmar) as respopera
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
	param8.Value = aipmanvehmar.idaipmanvehmar
	param8.ParameterName = "p_idaipmanvehmar"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehmar.xnommanvehmar IsNot Nothing Then
	param9.Value = aipmanvehmar.xnommanvehmar
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehmar.xdescmanvehmar IsNot Nothing Then
	param10.Value = aipmanvehmar.xdescmanvehmar
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehmar"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmar.iestatmanvehmar IsNot Nothing Then
	param11.Value = aipmanvehmar.iestatmanvehmar
	else
                    param11.Value = "ACTIVA"
	end if
	param11.ParameterName = "p_iestatmanvehmar"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehmar.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmar @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmar output,@p_xnommanvehmar,@p_xdescmanvehmar,@p_iestatmanvehmar,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipmanvehmar(aipmanvehmar as aipmanvehmar) as respopera
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
	param8.Value = aipmanvehmar.idaipmanvehmar
	param8.ParameterName = "p_idaipmanvehmar"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehmar.xnommanvehmar IsNot Nothing Then
	param9.Value = aipmanvehmar.xnommanvehmar
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehmar.xdescmanvehmar IsNot Nothing Then
	param10.Value = aipmanvehmar.xdescmanvehmar
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehmar"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmar.iestatmanvehmar IsNot Nothing Then
	param11.Value = aipmanvehmar.iestatmanvehmar
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehmar"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehmar.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmar @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmar output,@p_xnommanvehmar,@p_xdescmanvehmar,@p_iestatmanvehmar,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipmanvehmar(idaipmanvehmar as decimal) as respopera
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
	param8.Value = idaipmanvehmar
	param8.ParameterName = "p_idaipmanvehmar"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xnommanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	param10.Value = "
	param10.ParameterName = "p_xdescmanvehmar"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	param11.Value = "
	param11.ParameterName = "p_iestatmanvehmar"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmar @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmar output,@p_xnommanvehmar,@p_xdescmanvehmar,@p_iestatmanvehmar,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function actaipmanvehmar(aipmanvehmar as aipmanvehmar) as respopera
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
	param8.Value = aipmanvehmar.idaipmanvehmar
	param8.ParameterName = "p_idaipmanvehmar"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehmar.xnommanvehmar IsNot Nothing Then
	param9.Value = aipmanvehmar.xnommanvehmar
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehmar.xdescmanvehmar IsNot Nothing Then
	param10.Value = aipmanvehmar.xdescmanvehmar
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehmar"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmar.iestatmanvehmar IsNot Nothing Then
	param11.Value = aipmanvehmar.iestatmanvehmar
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehmar"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehmar.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmar @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmar output,@p_xnommanvehmar,@p_xdescmanvehmar,@p_iestatmanvehmar,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function desaipmanvehmar(aipmanvehmar as aipmanvehmar) as respopera
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
	param8.Value = aipmanvehmar.idaipmanvehmar
	param8.ParameterName = "p_idaipmanvehmar"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehmar.xnommanvehmar IsNot Nothing Then
	param9.Value = aipmanvehmar.xnommanvehmar
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehmar.xdescmanvehmar IsNot Nothing Then
	param10.Value = aipmanvehmar.xdescmanvehmar
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehmar"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmar.iestatmanvehmar IsNot Nothing Then
	param11.Value = aipmanvehmar.iestatmanvehmar
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehmar"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehmar.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmar @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmar output,@p_xnommanvehmar,@p_xdescmanvehmar,@p_iestatmanvehmar,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
        Public Function selcomboaipmanvehmar() As List(Of aipmanvehmar)
            Dim lista_aipmanvehmar As List(Of aipmanvehmar) = (From p In _db.aipmanvehmar
                                                               Where p.idaipmanvehmar > 0
                                                                Order By p.xnommanvehmar
                                                        Select p).ToList

            Dim aipmanvehmar As New aipmanvehmar
            aipmanvehmar.idaipmanvehmar = 0
            aipmanvehmar.idseglogreg = 0
            aipmanvehmar.iestatmanvehmar = ""
            aipmanvehmar.xdescmanvehmar = ""
            aipmanvehmar.xnommanvehmar = "SELECCIONE..."
            lista_aipmanvehmar.Insert(0, aipmanvehmar)

            '
            Return lista_aipmanvehmar
        End Function



        <HttpPost()> _
        Public Function selaipmanvehmaractivas() As List(Of aipmanvehmar)            
            Dim lista_aipmanvehmar As List(Of aipmanvehmar) = (From p In _db.aipmanvehmar
                                                        Where p.idaipmanvehmar > 0 And p.iestatmanvehmar = "ACTIVA"
                                                                Order By p.xnommanvehmar
                                                        Select p).ToList

            Dim aipmanvehmar As New aipmanvehmar
            aipmanvehmar.idaipmanvehmar = 0
            aipmanvehmar.idseglogreg = 0
            aipmanvehmar.iestatmanvehmar = ""
            aipmanvehmar.xdescmanvehmar = ""
            aipmanvehmar.xnommanvehmar = "SELECCIONE..."
            lista_aipmanvehmar.Insert(0, aipmanvehmar)

            '
            Return lista_aipmanvehmar
        End Function
End Class
End Namespace
