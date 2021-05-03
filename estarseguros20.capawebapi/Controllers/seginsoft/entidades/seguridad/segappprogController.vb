Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.entidades.controlador
Public Class segappprogController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selsegappprogxid(idsegappprog As Decimal) As segappprog
		Dim segappprog As segappprog = (From p In _db.segappprog
										Where p.idsegappprog = idsegappprog
										Select p).SingleOrDefault
		Return segappprog
	End Function

	<HttpPost()> _
	Public Function selsegappprog() As List(Of segappprog)
		Dim lista_segappprog As List(Of segappprog) = (From p In _db.segappprog
													Select p).ToList
		'
		Return lista_segappprog
	End Function

<HttpPost()> _
	Public Function selsegappprogxwheredinamicopag(petisegappprogpaglist as petisegappprogpaglist) as respsegappprogpaglist
		Dim sb As New StringBuilder("")
		'
		If petisegappprogpaglist.segappprog.idsegappprog <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegappprog=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegappprog))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegappprog=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegappprog))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegappprogpaglist.segappprog.idsegmanapp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanapp=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmanapp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanapp=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmanapp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegappprogpaglist.segappprog.idsegmanmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanmod=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmanmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanmod=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmanmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegappprogpaglist.segappprog.idsegmansubmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmansubmod=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmansubmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmansubmod=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmansubmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegappprogpaglist.segappprog.idsegmanprog <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanprog=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmanprog))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanprog=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idsegmanprog))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegappprogpaglist.segappprog.xdirurl <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdirurl='")
				sb.Append(petisegappprogpaglist.segappprog.xdirurl)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdirurl='")
				sb.Append(petisegappprogpaglist.segappprog.xdirurl)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegappprogpaglist.segappprog.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petisegappprogpaglist.segappprog.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respsegappprogpaglist As New respsegappprogpaglist
	respsegappprogpaglist.pagsegappprog = petisegappprogpaglist.pagsegappprog
	Dim skip = skip_paginacion(petisegappprogpaglist.pagsegappprog.npagactual, petisegappprogpaglist.pagsegappprog.npagtamano)
	
		If sb.ToString = "" Then
			respsegappprogpaglist.lista_segappprog = _db.segappprog.OrderBy(petisegappprogpaglist.pagsegappprog.xcamposord & " "  & petisegappprogpaglist.pagsegappprog.idirord).Skip(skip).Take(petisegappprogpaglist.pagsegappprog.npagtamano).ToList
		Else
			respsegappprogpaglist.lista_segappprog = _db.segappprog.Where(sb.ToString).OrderBy(petisegappprogpaglist.pagsegappprog.xcamposord & " "  & petisegappprogpaglist.pagsegappprog.idirord).Skip(skip).Take(petisegappprogpaglist.pagsegappprog.npagtamano).ToList
		End If
		'
		If (respsegappprogpaglist.lista_segappprog.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selsegappprogxwheredinamicocount(sb)
		respsegappprogpaglist.pagsegappprog.npagcantidad = cantidad_paginas(cant_entero_reg, respsegappprogpaglist.pagsegappprog.npagtamano)
		Else
		respsegappprogpaglist.pagsegappprog.npagcantidad = 0
		respsegappprogpaglist.pagsegappprog.npagactual = 0
		End If
	
		Return respsegappprogpaglist
	End Function

	Public Function selsegappprogxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.segappprog.count
	Else
	Return _db.segappprog.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function inssegappprog(segappprog as segappprog) as respopera
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
	param8.ParameterName = "p_idsegappprog"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segappprog.idsegmanapp
	param9.ParameterName = "p_idsegmanapp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segappprog.idsegmanmod
	param10.ParameterName = "p_idsegmanmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segappprog.idsegmansubmod
	param11.ParameterName = "p_idsegmansubmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segappprog.idsegmanprog
	param12.ParameterName = "p_idsegmanprog"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If segappprog.xdirurl IsNot Nothing Then
	param13.Value = segappprog.xdirurl
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdirurl"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = 0
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segappprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegappprog output,@p_idsegmanapp,@p_idsegmanmod,@p_idsegmansubmod,@p_idsegmanprog,@p_xdirurl,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function modsegappprog(segappprog as segappprog) as respopera
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
	param8.Value = segappprog.idsegappprog
	param8.ParameterName = "p_idsegappprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segappprog.idsegmanapp
	param9.ParameterName = "p_idsegmanapp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segappprog.idsegmanmod
	param10.ParameterName = "p_idsegmanmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segappprog.idsegmansubmod
	param11.ParameterName = "p_idsegmansubmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segappprog.idsegmanprog
	param12.ParameterName = "p_idsegmanprog"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If segappprog.xdirurl IsNot Nothing Then
	param13.Value = segappprog.xdirurl
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdirurl"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = segappprog.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segappprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegappprog output,@p_idsegmanapp,@p_idsegmanmod,@p_idsegmansubmod,@p_idsegmanprog,@p_xdirurl,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function elisegappprog(segappprog as segappprog) as respopera
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
	param8.Value = segappprog.idsegappprog
	param8.ParameterName = "p_idsegappprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segappprog.idsegmanapp
	param9.ParameterName = "p_idsegmanapp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segappprog.idsegmanmod
	param10.ParameterName = "p_idsegmanmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segappprog.idsegmansubmod
	param11.ParameterName = "p_idsegmansubmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segappprog.idsegmanprog
	param12.ParameterName = "p_idsegmanprog"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If segappprog.xdirurl IsNot Nothing Then
	param13.Value = segappprog.xdirurl
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdirurl"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = segappprog.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segappprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegappprog output,@p_idsegmanapp,@p_idsegmanmod,@p_idsegmansubmod,@p_idsegmanprog,@p_xdirurl,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function elisegappprog(idsegappprog as decimal) as respopera
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
	param8.Value = idsegappprog
	param8.ParameterName = "p_idsegappprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idsegmanapp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_idsegmanmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = 0
	param11.ParameterName = "p_idsegmansubmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idsegmanprog"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	param13.Value = "
	param13.ParameterName = "p_xdirurl"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = 0
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segappprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegappprog output,@p_idsegmanapp,@p_idsegmanmod,@p_idsegmansubmod,@p_idsegmanprog,@p_xdirurl,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function actsegappprog(segappprog as segappprog) as respopera
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
	param8.Value = segappprog.idsegappprog
	param8.ParameterName = "p_idsegappprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segappprog.idsegmanapp
	param9.ParameterName = "p_idsegmanapp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segappprog.idsegmanmod
	param10.ParameterName = "p_idsegmanmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segappprog.idsegmansubmod
	param11.ParameterName = "p_idsegmansubmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segappprog.idsegmanprog
	param12.ParameterName = "p_idsegmanprog"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If segappprog.xdirurl IsNot Nothing Then
	param13.Value = segappprog.xdirurl
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdirurl"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = segappprog.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segappprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegappprog output,@p_idsegmanapp,@p_idsegmanmod,@p_idsegmansubmod,@p_idsegmanprog,@p_xdirurl,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
	Public Function dessegappprog(segappprog as segappprog) as respopera
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
	param8.Value = segappprog.idsegappprog
	param8.ParameterName = "p_idsegappprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segappprog.idsegmanapp
	param9.ParameterName = "p_idsegmanapp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segappprog.idsegmanmod
	param10.ParameterName = "p_idsegmanmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segappprog.idsegmansubmod
	param11.ParameterName = "p_idsegmansubmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segappprog.idsegmanprog
	param12.ParameterName = "p_idsegmanprog"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 500
	If segappprog.xdirurl IsNot Nothing Then
	param13.Value = segappprog.xdirurl
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xdirurl"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = segappprog.idseglogreg
	param14.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segappprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegappprog output,@p_idsegmanapp,@p_idsegmanmod,@p_idsegmansubmod,@p_idsegmanprog,@p_xdirurl,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14)
	
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
