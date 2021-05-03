Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmanvehaccController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmanvehaccxid(idaipmanvehacc As Decimal) As aipmanvehacc
		Dim aipmanvehacc As aipmanvehacc = (From p In _db.aipmanvehacc
										Where p.idaipmanvehacc = idaipmanvehacc
										Select p).SingleOrDefault
		Return aipmanvehacc
	End Function

	<HttpPost()> _
	Public Function selaipmanvehacc() As List(Of aipmanvehacc)
            Dim lista_aipmanvehacc As List(Of aipmanvehacc) = (From p In _db.aipmanvehacc
                                                               Where p.idaipmanvehacc > 0
                                                        Select p).ToList
		'
		Return lista_aipmanvehacc
	End Function

<HttpPost()> _
	Public Function selaipmanvehaccxwheredinamicopag(petiaipmanvehaccpaglist as petiaipmanvehaccpaglist) as respaipmanvehaccpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmanvehaccpaglist.aipmanvehacc.idaipmanvehacc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehacc=")
				sb.Append(valor_entero(petiaipmanvehaccpaglist.aipmanvehacc.idaipmanvehacc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehacc=")
				sb.Append(valor_entero(petiaipmanvehaccpaglist.aipmanvehacc.idaipmanvehacc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehaccpaglist.aipmanvehacc.xnommanvehacc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehacc='")
				sb.Append(petiaipmanvehaccpaglist.aipmanvehacc.xnommanvehacc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehacc='")
				sb.Append(petiaipmanvehaccpaglist.aipmanvehacc.xnommanvehacc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehaccpaglist.aipmanvehacc.xdescmanvehacc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanvehacc='")
				sb.Append(petiaipmanvehaccpaglist.aipmanvehacc.xdescmanvehacc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanvehacc='")
				sb.Append(petiaipmanvehaccpaglist.aipmanvehacc.xdescmanvehacc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehaccpaglist.aipmanvehacc.iestatmanvehacc <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehacc='")
				sb.Append(petiaipmanvehaccpaglist.aipmanvehacc.iestatmanvehacc)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehacc='")
				sb.Append(petiaipmanvehaccpaglist.aipmanvehacc.iestatmanvehacc)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehaccpaglist.aipmanvehacc.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehaccpaglist.aipmanvehacc.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehaccpaglist.aipmanvehacc.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmanvehaccpaglist As New respaipmanvehaccpaglist
	respaipmanvehaccpaglist.pagaipmanvehacc = petiaipmanvehaccpaglist.pagaipmanvehacc
	Dim skip = skip_paginacion(petiaipmanvehaccpaglist.pagaipmanvehacc.npagactual, petiaipmanvehaccpaglist.pagaipmanvehacc.npagtamano)
	
		If sb.ToString = "" Then
			respaipmanvehaccpaglist.lista_aipmanvehacc = _db.aipmanvehacc.OrderBy(petiaipmanvehaccpaglist.pagaipmanvehacc.xcamposord & " "  & petiaipmanvehaccpaglist.pagaipmanvehacc.idirord).Skip(skip).Take(petiaipmanvehaccpaglist.pagaipmanvehacc.npagtamano).ToList
		Else
			respaipmanvehaccpaglist.lista_aipmanvehacc = _db.aipmanvehacc.Where(sb.ToString).OrderBy(petiaipmanvehaccpaglist.pagaipmanvehacc.xcamposord & " "  & petiaipmanvehaccpaglist.pagaipmanvehacc.idirord).Skip(skip).Take(petiaipmanvehaccpaglist.pagaipmanvehacc.npagtamano).ToList
		End If
		'
		If (respaipmanvehaccpaglist.lista_aipmanvehacc.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmanvehaccxwheredinamicocount(sb)
		respaipmanvehaccpaglist.pagaipmanvehacc.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanvehaccpaglist.pagaipmanvehacc.npagtamano)
		Else
		respaipmanvehaccpaglist.pagaipmanvehacc.npagcantidad = 0
		respaipmanvehaccpaglist.pagaipmanvehacc.npagactual = 0
		End If
	
		Return respaipmanvehaccpaglist
	End Function

	Public Function selaipmanvehaccxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmanvehacc.count
	Else
	Return _db.aipmanvehacc.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmanvehacc(aipmanvehacc as aipmanvehacc) as respopera
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
	param8.ParameterName = "p_idaipmanvehacc"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehacc.xnommanvehacc IsNot Nothing Then
	param9.Value = aipmanvehacc.xnommanvehacc
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehacc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehacc.xdescmanvehacc IsNot Nothing Then
	param10.Value = aipmanvehacc.xdescmanvehacc
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehacc"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehacc.iestatmanvehacc IsNot Nothing Then
	param11.Value = aipmanvehacc.iestatmanvehacc
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehacc"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehacc output,@p_xnommanvehacc,@p_xdescmanvehacc,@p_iestatmanvehacc,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function modaipmanvehacc(aipmanvehacc as aipmanvehacc) as respopera
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
	param8.Value = aipmanvehacc.idaipmanvehacc
	param8.ParameterName = "p_idaipmanvehacc"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehacc.xnommanvehacc IsNot Nothing Then
	param9.Value = aipmanvehacc.xnommanvehacc
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehacc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehacc.xdescmanvehacc IsNot Nothing Then
	param10.Value = aipmanvehacc.xdescmanvehacc
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehacc"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehacc.iestatmanvehacc IsNot Nothing Then
	param11.Value = aipmanvehacc.iestatmanvehacc
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehacc"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehacc.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehacc output,@p_xnommanvehacc,@p_xdescmanvehacc,@p_iestatmanvehacc,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipmanvehacc(aipmanvehacc as aipmanvehacc) as respopera
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
	param8.Value = aipmanvehacc.idaipmanvehacc
	param8.ParameterName = "p_idaipmanvehacc"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehacc.xnommanvehacc IsNot Nothing Then
	param9.Value = aipmanvehacc.xnommanvehacc
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehacc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehacc.xdescmanvehacc IsNot Nothing Then
	param10.Value = aipmanvehacc.xdescmanvehacc
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehacc"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehacc.iestatmanvehacc IsNot Nothing Then
	param11.Value = aipmanvehacc.iestatmanvehacc
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehacc"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehacc.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehacc output,@p_xnommanvehacc,@p_xdescmanvehacc,@p_iestatmanvehacc,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipmanvehacc(idaipmanvehacc as decimal) as respopera
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
	param8.Value = idaipmanvehacc
	param8.ParameterName = "p_idaipmanvehacc"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xnommanvehacc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	param10.Value = "
	param10.ParameterName = "p_xdescmanvehacc"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	param11.Value = "
	param11.ParameterName = "p_iestatmanvehacc"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehacc output,@p_xnommanvehacc,@p_xdescmanvehacc,@p_iestatmanvehacc,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function actaipmanvehacc(aipmanvehacc as aipmanvehacc) as respopera
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
	param8.Value = aipmanvehacc.idaipmanvehacc
	param8.ParameterName = "p_idaipmanvehacc"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehacc.xnommanvehacc IsNot Nothing Then
	param9.Value = aipmanvehacc.xnommanvehacc
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehacc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehacc.xdescmanvehacc IsNot Nothing Then
	param10.Value = aipmanvehacc.xdescmanvehacc
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehacc"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehacc.iestatmanvehacc IsNot Nothing Then
	param11.Value = aipmanvehacc.iestatmanvehacc
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehacc"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehacc.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehacc output,@p_xnommanvehacc,@p_xdescmanvehacc,@p_iestatmanvehacc,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function desaipmanvehacc(aipmanvehacc as aipmanvehacc) as respopera
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
	param8.Value = aipmanvehacc.idaipmanvehacc
	param8.ParameterName = "p_idaipmanvehacc"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehacc.xnommanvehacc IsNot Nothing Then
	param9.Value = aipmanvehacc.xnommanvehacc
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehacc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehacc.xdescmanvehacc IsNot Nothing Then
	param10.Value = aipmanvehacc.xdescmanvehacc
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehacc"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehacc.iestatmanvehacc IsNot Nothing Then
	param11.Value = aipmanvehacc.iestatmanvehacc
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehacc"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehacc.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehacc @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehacc output,@p_xnommanvehacc,@p_xdescmanvehacc,@p_iestatmanvehacc,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
        Public Function selaipmanvehaccactivos() As List(Of aipmanvehacc)
            Dim lista_aipmanvehacc As List(Of aipmanvehacc) = (From p In _db.aipmanvehacc
                                                               Where p.idaipmanvehacc > 0 And p.iestatmanvehacc = "ACTIVO"
                                                               Order By p.xnommanvehacc
                                                        Select p).ToList

            Dim aipmanvehacc As New aipmanvehacc
            aipmanvehacc.idaipmanvehacc = 0
            aipmanvehacc.idseglogreg = 0
            aipmanvehacc.iestatmanvehacc = ""
            aipmanvehacc.xdescmanvehacc = ""
            aipmanvehacc.xnommanvehacc = "SELECCIONE..."
            lista_aipmanvehacc.Insert(0, aipmanvehacc)

            '
            Return lista_aipmanvehacc
        End Function
End Class
End Namespace
