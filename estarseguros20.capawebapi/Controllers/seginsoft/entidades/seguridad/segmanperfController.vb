Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.entidades.controlador
Public Class segmanperfController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selsegmanperfxid(idsegmanperf As Decimal) As segmanperf
		Dim segmanperf As segmanperf = (From p In _db.segmanperf
										Where p.idsegmanperf = idsegmanperf
										Select p).SingleOrDefault
		Return segmanperf
	End Function

	<HttpPost()> _
	Public Function selsegmanperf() As List(Of segmanperf)
            Dim lista_segmanperf As List(Of segmanperf) = (From p In _db.segmanperf
                                                           Order By p.idsegmanperf Ascending
                                                        Select p).ToList
		'
		Return lista_segmanperf
	End Function

<HttpPost()> _
	Public Function selsegmanperfxwheredinamicopag(petisegmanperfpaglist as petisegmanperfpaglist) as respsegmanperfpaglist
		Dim sb As New StringBuilder("")
		'
		If petisegmanperfpaglist.segmanperf.idsegmanperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanperf=")
				sb.Append(valor_entero(petisegmanperfpaglist.segmanperf.idsegmanperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanperf=")
				sb.Append(valor_entero(petisegmanperfpaglist.segmanperf.idsegmanperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanperfpaglist.segmanperf.xabrevperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xabrevperf='")
				sb.Append(petisegmanperfpaglist.segmanperf.xabrevperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xabrevperf='")
				sb.Append(petisegmanperfpaglist.segmanperf.xabrevperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanperfpaglist.segmanperf.xnombreperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombreperf='")
				sb.Append(petisegmanperfpaglist.segmanperf.xnombreperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombreperf='")
				sb.Append(petisegmanperfpaglist.segmanperf.xnombreperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanperfpaglist.segmanperf.nnivelperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nnivelperf=")
				sb.Append(valor_entero(petisegmanperfpaglist.segmanperf.nnivelperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nnivelperf=")
				sb.Append(valor_entero(petisegmanperfpaglist.segmanperf.nnivelperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanperfpaglist.segmanperf.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petisegmanperfpaglist.segmanperf.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petisegmanperfpaglist.segmanperf.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respsegmanperfpaglist As New respsegmanperfpaglist
	respsegmanperfpaglist.pagsegmanperf = petisegmanperfpaglist.pagsegmanperf
	Dim skip = skip_paginacion(petisegmanperfpaglist.pagsegmanperf.npagactual, petisegmanperfpaglist.pagsegmanperf.npagtamano)
	
		If sb.ToString = "" Then
			respsegmanperfpaglist.lista_segmanperf = _db.segmanperf.OrderBy(petisegmanperfpaglist.pagsegmanperf.xcamposord & " "  & petisegmanperfpaglist.pagsegmanperf.idirord).Skip(skip).Take(petisegmanperfpaglist.pagsegmanperf.npagtamano).ToList
		Else
			respsegmanperfpaglist.lista_segmanperf = _db.segmanperf.Where(sb.ToString).OrderBy(petisegmanperfpaglist.pagsegmanperf.xcamposord & " "  & petisegmanperfpaglist.pagsegmanperf.idirord).Skip(skip).Take(petisegmanperfpaglist.pagsegmanperf.npagtamano).ToList
		End If
		'
		If (respsegmanperfpaglist.lista_segmanperf.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selsegmanperfxwheredinamicocount(sb)
		respsegmanperfpaglist.pagsegmanperf.npagcantidad = cantidad_paginas(cant_entero_reg, respsegmanperfpaglist.pagsegmanperf.npagtamano)
		Else
		respsegmanperfpaglist.pagsegmanperf.npagcantidad = 0
		respsegmanperfpaglist.pagsegmanperf.npagactual = 0
		End If
	
		Return respsegmanperfpaglist
	End Function

	Public Function selsegmanperfxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.segmanperf.count
	Else
	Return _db.segmanperf.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function inssegmanperf(segmanperf as segmanperf) as respopera
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
	 param2.ParameterName = "p_idsegmanusu"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "seginsoft"
	param3.ParameterName = "p_xnombrecorto"
	
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
	param8.ParameterName = "p_idsegmanperf"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 3
	If segmanperf.xabrevperf IsNot Nothing Then
	param9.Value = segmanperf.xabrevperf
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xabrevperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanperf.xnombreperf IsNot Nothing Then
	param10.Value = segmanperf.xnombreperf
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombreperf"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.int
	param11.Value = segmanperf.nnivelperf
	param11.ParameterName = "p_nnivelperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanperf output,@p_xabrevperf,@p_xnombreperf,@p_nnivelperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function modsegmanperf(segmanperf as segmanperf) as respopera
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
	 param2.ParameterName = "p_idsegmanusu"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "seginsoft"
	param3.ParameterName = "p_xnombrecorto"
	
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
	param8.Value = segmanperf.idsegmanperf
	param8.ParameterName = "p_idsegmanperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 3
	If segmanperf.xabrevperf IsNot Nothing Then
	param9.Value = segmanperf.xabrevperf
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xabrevperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanperf.xnombreperf IsNot Nothing Then
	param10.Value = segmanperf.xnombreperf
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombreperf"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.int
	param11.Value = segmanperf.nnivelperf
	param11.ParameterName = "p_nnivelperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanperf.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanperf output,@p_xabrevperf,@p_xnombreperf,@p_nnivelperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function elisegmanperf(segmanperf as segmanperf) as respopera
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
	 param2.ParameterName = "p_idsegmanusu"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "seginsoft"
	param3.ParameterName = "p_xnombrecorto"
	
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
	param8.Value = segmanperf.idsegmanperf
	param8.ParameterName = "p_idsegmanperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 3
	If segmanperf.xabrevperf IsNot Nothing Then
	param9.Value = segmanperf.xabrevperf
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xabrevperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanperf.xnombreperf IsNot Nothing Then
	param10.Value = segmanperf.xnombreperf
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombreperf"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.int
	param11.Value = segmanperf.nnivelperf
	param11.ParameterName = "p_nnivelperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanperf.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanperf output,@p_xabrevperf,@p_xnombreperf,@p_nnivelperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function elisegmanperf(idsegmanperf as decimal) as respopera
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
	 param2.ParameterName = "p_idsegmanusu"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "seginsoft"
	param3.ParameterName = "p_xnombrecorto"
	
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
	param8.Value = idsegmanperf
	param8.ParameterName = "p_idsegmanperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 3
	param9.Value = "
	param9.ParameterName = "p_xabrevperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	param10.Value = "
	param10.ParameterName = "p_xnombreperf"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.int
	param11.Value = 0
	param11.ParameterName = "p_nnivelperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanperf output,@p_xabrevperf,@p_xnombreperf,@p_nnivelperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function actsegmanperf(segmanperf as segmanperf) as respopera
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
	 param2.ParameterName = "p_idsegmanusu"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "seginsoft"
	param3.ParameterName = "p_xnombrecorto"
	
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
	param8.Value = segmanperf.idsegmanperf
	param8.ParameterName = "p_idsegmanperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 3
	If segmanperf.xabrevperf IsNot Nothing Then
	param9.Value = segmanperf.xabrevperf
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xabrevperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanperf.xnombreperf IsNot Nothing Then
	param10.Value = segmanperf.xnombreperf
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombreperf"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.int
	param11.Value = segmanperf.nnivelperf
	param11.ParameterName = "p_nnivelperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanperf.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanperf output,@p_xabrevperf,@p_xnombreperf,@p_nnivelperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function dessegmanperf(segmanperf as segmanperf) as respopera
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
	 param2.ParameterName = "p_idsegmanusu"
	
	Dim param3 As New SqlClient.SqlParameter
	param3.SqlDbType = SqlDbType.VarChar
	param3.Size = 20
	param3.value = "seginsoft"
	param3.ParameterName = "p_xnombrecorto"
	
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
	param8.Value = segmanperf.idsegmanperf
	param8.ParameterName = "p_idsegmanperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 3
	If segmanperf.xabrevperf IsNot Nothing Then
	param9.Value = segmanperf.xabrevperf
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xabrevperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanperf.xnombreperf IsNot Nothing Then
	param10.Value = segmanperf.xnombreperf
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombreperf"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.int
	param11.Value = segmanperf.nnivelperf
	param11.ParameterName = "p_nnivelperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanperf.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanperf output,@p_xabrevperf,@p_xnombreperf,@p_nnivelperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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

        'funciones no comunes
        Public Function selsegmanperf_todos_count() As Decimal
            Dim cantidad As Decimal = (From p In _db.segmanperf
                           Select p).Count()
            '
            Return cantidad
        End Function

        Public Function selsegmanperf_todos_pag(skip As Integer, take As Integer) As List(Of segmanperf)
            Dim lista_segmanperf As List(Of segmanperf) = (From p In _db.segmanperf
                                               Order By p.nnivelperf, p.xabrevperf Ascending
                                               Select p).Skip(skip).Take(take).ToList
            '
            Return lista_segmanperf
        End Function

    End Class
End Namespace
