Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.entidades.controlador
Public Class segaccperfController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selsegaccperfxid(idsegaccperf As Decimal) As segaccperf
		Dim segaccperf As segaccperf = (From p In _db.segaccperf
										Where p.idsegaccperf = idsegaccperf
										Select p).SingleOrDefault
		Return segaccperf
	End Function

	<HttpPost()> _
	Public Function selsegaccperf() As List(Of segaccperf)
		Dim lista_segaccperf As List(Of segaccperf) = (From p In _db.segaccperf
													Select p).ToList
		'
		Return lista_segaccperf
	End Function

<HttpPost()> _
	Public Function selsegaccperfxwheredinamicopag(petisegaccperfpaglist as petisegaccperfpaglist) as respsegaccperfpaglist
		Dim sb As New StringBuilder("")
		'
		If petisegaccperfpaglist.segaccperf.idsegaccperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegaccperf=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idsegaccperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegaccperf=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idsegaccperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegaccperfpaglist.segaccperf.idsegmanperf <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanperf=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idsegmanperf))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanperf=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idsegmanperf))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegaccperfpaglist.segaccperf.idsegappprog <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegappprog=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idsegappprog))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegappprog=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idsegappprog))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegaccperfpaglist.segaccperf.itipoaccperf <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.itipoaccperf='")
				sb.Append(petisegaccperfpaglist.segaccperf.itipoaccperf)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itipoaccperf='")
				sb.Append(petisegaccperfpaglist.segaccperf.itipoaccperf)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegaccperfpaglist.segaccperf.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petisegaccperfpaglist.segaccperf.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	Dim respsegaccperfpaglist As New respsegaccperfpaglist
	respsegaccperfpaglist.pagsegaccperf = petisegaccperfpaglist.pagsegaccperf
	Dim skip = skip_paginacion(petisegaccperfpaglist.pagsegaccperf.npagactual, petisegaccperfpaglist.pagsegaccperf.npagtamano)
	
		If sb.ToString = "" Then
			respsegaccperfpaglist.lista_segaccperf = _db.segaccperf.OrderBy(petisegaccperfpaglist.pagsegaccperf.xcamposord & " "  & petisegaccperfpaglist.pagsegaccperf.idirord).Skip(skip).Take(petisegaccperfpaglist.pagsegaccperf.npagtamano).ToList
		Else
			respsegaccperfpaglist.lista_segaccperf = _db.segaccperf.Where(sb.ToString).OrderBy(petisegaccperfpaglist.pagsegaccperf.xcamposord & " "  & petisegaccperfpaglist.pagsegaccperf.idirord).Skip(skip).Take(petisegaccperfpaglist.pagsegaccperf.npagtamano).ToList
		End If
		'
		If (respsegaccperfpaglist.lista_segaccperf.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selsegaccperfxwheredinamicocount(sb)
		respsegaccperfpaglist.pagsegaccperf.npagcantidad = cantidad_paginas(cant_entero_reg, respsegaccperfpaglist.pagsegaccperf.npagtamano)
		Else
		respsegaccperfpaglist.pagsegaccperf.npagcantidad = 0
		respsegaccperfpaglist.pagsegaccperf.npagactual = 0
		End If
	
		Return respsegaccperfpaglist
	End Function

	Public Function selsegaccperfxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.segaccperf.count
	Else
	Return _db.segaccperf.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function inssegaccperf(segaccperf as segaccperf) as respopera
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
	param8.ParameterName = "p_idsegaccperf"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segaccperf.idsegmanperf
	param9.ParameterName = "p_idsegmanperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segaccperf.idsegappprog
	param10.ParameterName = "p_idsegappprog"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segaccperf.itipoaccperf IsNot Nothing Then
	param11.Value = segaccperf.itipoaccperf
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipoaccperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segaccperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegaccperf output,@p_idsegmanperf,@p_idsegappprog,@p_itipoaccperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function modsegaccperf(segaccperf as segaccperf) as respopera
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
	param8.Value = segaccperf.idsegaccperf
	param8.ParameterName = "p_idsegaccperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segaccperf.idsegmanperf
	param9.ParameterName = "p_idsegmanperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segaccperf.idsegappprog
	param10.ParameterName = "p_idsegappprog"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segaccperf.itipoaccperf IsNot Nothing Then
	param11.Value = segaccperf.itipoaccperf
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipoaccperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segaccperf.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segaccperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegaccperf output,@p_idsegmanperf,@p_idsegappprog,@p_itipoaccperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function elisegaccperf(segaccperf as segaccperf) as respopera
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
	param8.Value = segaccperf.idsegaccperf
	param8.ParameterName = "p_idsegaccperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segaccperf.idsegmanperf
	param9.ParameterName = "p_idsegmanperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segaccperf.idsegappprog
	param10.ParameterName = "p_idsegappprog"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If segaccperf.itipoaccperf IsNot Nothing Then
	param11.Value = segaccperf.itipoaccperf
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_itipoaccperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segaccperf.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segaccperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegaccperf output,@p_idsegmanperf,@p_idsegappprog,@p_itipoaccperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function elisegaccperf(idsegaccperf as decimal) as respopera
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
	param8.Value = idsegaccperf
	param8.ParameterName = "p_idsegaccperf"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idsegmanperf"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_idsegappprog"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	param11.Value = "
	param11.ParameterName = "p_itipoaccperf"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segaccperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegaccperf output,@p_idsegmanperf,@p_idsegappprog,@p_itipoaccperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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

        '	<HttpPost()> _
        '	Public Function actsegaccperf(segaccperf as segaccperf) as respopera
        '		Try

        '	Dim param1 As New SqlClient.SqlParameter
        '	param1.SqlDbType = SqlDbType.VarChar
        '	param1.Size = 20
        '	param1.Value = "activar"
        '	param1.ParameterName = "p_ioperacion"

        '	Dim param2 As New SqlClient.SqlParameter
        '	param2.SqlDbType = SqlDbType.Decimal  
        '	param2.Precision = 18
        '	 param2.Scale = 0
        '	param2.Value = 0
        '	 param2.ParameterName = "p_idsegmanusu"

        '	Dim param3 As New SqlClient.SqlParameter
        '	param3.SqlDbType = SqlDbType.VarChar
        '	param3.Size = 20
        '	param3.value = "seginsoft"
        '	param3.ParameterName = "p_xnombrecorto"

        '	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
        '	param4.SqlDbType = SqlDbType.VarChar
        '	param4.Size = 1
        '	param4.ParameterName = "p_irespuesta"
        '	param4.Direction = ParameterDirection.Output

        '	Dim param5 As New SqlClient.SqlParameter
        '	param5.SqlDbType = SqlDbType.VarChar
        '	param5.Size = 300
        '	param5.ParameterName = "p_xmsjusuario"
        '	param5.Direction = ParameterDirection.Output

        '	Dim param6 As New SqlClient.SqlParameter
        '	param6.SqlDbType = SqlDbType.VarChar
        '	param6.Size = 300
        '	param6.ParameterName = "p_xmsjtecnico"
        '	param6.Direction = ParameterDirection.Output

        '	Dim param7 As New SqlClient.SqlParameter
        '	param7.SqlDbType = SqlDbType.VarChar
        '	param7.Size = 300
        '	param7.ParameterName = "p_coderrorlog"
        '	param7.Direction = ParameterDirection.Output

        ''Paramestros de la tabla

        '	Dim param8 As New SqlClient.SqlParameter
        '	param8.SqlDbType = SqlDbType.decimal
        '	param8.Precision = 18
        '	param8.Scale = 0
        '	param8.Value = segaccperf.idsegaccperf
        '	param8.ParameterName = "p_idsegaccperf"
        '	param8.Direction = ParameterDirection.InputOutput

        '	Dim param9 As New SqlClient.SqlParameter
        '	param9.SqlDbType = SqlDbType.decimal
        '	param9.Precision = 18
        '	param9.Scale = 0
        '	param9.Value = segaccperf.idsegmanperf
        '	param9.ParameterName = "p_idsegmanperf"

        '	Dim param10 As New SqlClient.SqlParameter
        '	param10.SqlDbType = SqlDbType.decimal
        '	param10.Precision = 18
        '	param10.Scale = 0
        '	param10.Value = segaccperf.idsegappprog
        '	param10.ParameterName = "p_idsegappprog"

        '	Dim param11 As New SqlClient.SqlParameter
        '	param11.SqlDbType = SqlDbType.varchar
        '	param11.Size = 50
        '	If segaccperf.itipoaccperf IsNot Nothing Then
        '	param11.Value = segaccperf.itipoaccperf
        '	else
        '	param11.Value = ""
        '	end if
        '	param11.ParameterName = "p_itipoaccperf"

        '	Dim param12 As New SqlClient.SqlParameter
        '	param12.SqlDbType = SqlDbType.decimal
        '	param12.Precision = 18
        '	param12.Scale = 0
        '	param12.Value = segaccperf.idseglogreg
        '	param12.ParameterName = "p_idseglogreg"
        '	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segaccperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegaccperf output,@p_idsegmanperf,@p_idsegappprog,@p_itipoaccperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)

        '	Dim respopera As New respopera
        '	respopera.irespuesta = param4.Value
        '	respopera.xmsjusuario = param5.Value
        '	respopera.xmsjtecnico = param6.Value
        '	If IsNumeric(param8.Value) = True Then
        '	respopera.id = Int(param8.Value)
        '	End If

        '			Return respopera

        '		Catch ex As Exception

        '	Dim respopera As New respopera
        '	respopera.irespuesta = 0
        '	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
        '	respopera.xmsjtecnico = ex.Message
        '	Return respopera
        '		End Try
        '	End Function

        '	<HttpPost()> _
        '	Public Function dessegaccperf(segaccperf as segaccperf) as respopera
        '		Try

        '	Dim param1 As New SqlClient.SqlParameter
        '	param1.SqlDbType = SqlDbType.VarChar
        '	param1.Size = 20
        '	param1.Value = "desactivar"
        '	param1.ParameterName = "p_ioperacion"

        '	Dim param2 As New SqlClient.SqlParameter
        '	param2.SqlDbType = SqlDbType.Decimal  
        '	param2.Precision = 18
        '	 param2.Scale = 0
        '	param2.Value = 0
        '	 param2.ParameterName = "p_idsegmanusu"

        '	Dim param3 As New SqlClient.SqlParameter
        '	param3.SqlDbType = SqlDbType.VarChar
        '	param3.Size = 20
        '	param3.value = "seginsoft"
        '	param3.ParameterName = "p_xnombrecorto"

        '	Dim param4 As New SqlClient.SqlParameter 'devuelve el estatus de la operacion 1=exitoso sino error en el proceso 0 =error en todo, 2 =error el algunos pasos
        '	param4.SqlDbType = SqlDbType.VarChar
        '	param4.Size = 1
        '	param4.ParameterName = "p_irespuesta"
        '	param4.Direction = ParameterDirection.Output

        '	Dim param5 As New SqlClient.SqlParameter
        '	param5.SqlDbType = SqlDbType.VarChar
        '	param5.Size = 300
        '	param5.ParameterName = "p_xmsjusuario"
        '	param5.Direction = ParameterDirection.Output

        '	Dim param6 As New SqlClient.SqlParameter
        '	param6.SqlDbType = SqlDbType.VarChar
        '	param6.Size = 300
        '	param6.ParameterName = "p_xmsjtecnico"
        '	param6.Direction = ParameterDirection.Output

        '	Dim param7 As New SqlClient.SqlParameter
        '	param7.SqlDbType = SqlDbType.VarChar
        '	param7.Size = 300
        '	param7.ParameterName = "p_coderrorlog"
        '	param7.Direction = ParameterDirection.Output

        ''Paramestros de la tabla

        '	Dim param8 As New SqlClient.SqlParameter
        '	param8.SqlDbType = SqlDbType.decimal
        '	param8.Precision = 18
        '	param8.Scale = 0
        '	param8.Value = segaccperf.idsegaccperf
        '	param8.ParameterName = "p_idsegaccperf"
        '	param8.Direction = ParameterDirection.InputOutput

        '	Dim param9 As New SqlClient.SqlParameter
        '	param9.SqlDbType = SqlDbType.decimal
        '	param9.Precision = 18
        '	param9.Scale = 0
        '	param9.Value = segaccperf.idsegmanperf
        '	param9.ParameterName = "p_idsegmanperf"

        '	Dim param10 As New SqlClient.SqlParameter
        '	param10.SqlDbType = SqlDbType.decimal
        '	param10.Precision = 18
        '	param10.Scale = 0
        '	param10.Value = segaccperf.idsegappprog
        '	param10.ParameterName = "p_idsegappprog"

        '	Dim param11 As New SqlClient.SqlParameter
        '	param11.SqlDbType = SqlDbType.varchar
        '	param11.Size = 50
        '	If segaccperf.itipoaccperf IsNot Nothing Then
        '	param11.Value = segaccperf.itipoaccperf
        '	else
        '	param11.Value = ""
        '	end if
        '	param11.ParameterName = "p_itipoaccperf"

        '	Dim param12 As New SqlClient.SqlParameter
        '	param12.SqlDbType = SqlDbType.decimal
        '	param12.Precision = 18
        '	param12.Scale = 0
        '	param12.Value = segaccperf.idseglogreg
        '	param12.ParameterName = "p_idseglogreg"
        '	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segaccperf @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegaccperf output,@p_idsegmanperf,@p_idsegappprog,@p_itipoaccperf,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)

        '	Dim respopera As New respopera
        '	respopera.irespuesta = param4.Value
        '	respopera.xmsjusuario = param5.Value
        '	respopera.xmsjtecnico = param6.Value
        '	If IsNumeric(param8.Value) = True Then
        '	respopera.id = Int(param8.Value)
        '	End If

        '			Return respopera

        '		Catch ex As Exception

        '	Dim respopera As New respopera
        '	respopera.irespuesta = 0
        '	respopera.xmsjusuario = "Error Comuniquese con Sistemas"
        '	respopera.xmsjtecnico = ex.Message
        '	Return respopera
        '		End Try
        '	End Function

End Class
End Namespace
