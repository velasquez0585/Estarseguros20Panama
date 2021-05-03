Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.entidades.controlador
Public Class segmanprogController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selsegmanprogxid(idsegmanprog As Decimal) As segmanprog
		Dim segmanprog As segmanprog = (From p In _db.segmanprog
										Where p.idsegmanprog = idsegmanprog
										Select p).SingleOrDefault
		Return segmanprog
	End Function

	<HttpPost()> _
	Public Function selsegmanprog() As List(Of segmanprog)
		Dim lista_segmanprog As List(Of segmanprog) = (From p In _db.segmanprog
													Select p).ToList
		'
		Return lista_segmanprog
	End Function

<HttpPost()> _
	Public Function selsegmanprogxwheredinamicopag(petisegmanprogpaglist as petisegmanprogpaglist) as respsegmanprogpaglist
		Dim sb As New StringBuilder("")
		'
		If petisegmanprogpaglist.segmanprog.idsegmanprog <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanprog=")
				sb.Append(valor_entero(petisegmanprogpaglist.segmanprog.idsegmanprog))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanprog=")
				sb.Append(valor_entero(petisegmanprogpaglist.segmanprog.idsegmanprog))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanprogpaglist.segmanprog.xnombrecorto <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrecorto='")
				sb.Append(petisegmanprogpaglist.segmanprog.xnombrecorto)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrecorto='")
				sb.Append(petisegmanprogpaglist.segmanprog.xnombrecorto)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanprogpaglist.segmanprog.xnombrelargo <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnombrelargo='")
				sb.Append(petisegmanprogpaglist.segmanprog.xnombrelargo)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnombrelargo='")
				sb.Append(petisegmanprogpaglist.segmanprog.xnombrelargo)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanprogpaglist.segmanprog.fimplementacion > cdate("01-01-1920") Then
		Dim fecha As String = ""
		If sb.Length = 0 Then
		fecha = [String].Format("it.fimplementacion >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petisegmanprogpaglist.segmanprog.fimplementacion)
		sb.Append(fecha)
		Else
		If sb.Length > 0 Then
		fecha = [String].Format(" and it.fimplementacion >= DATETIME'{0:yyyy-MM-dd HH:mm}'" , petisegmanprogpaglist.segmanprog.fimplementacion)
		sb.Append(fecha)
	        End If
	    End If
	End If
	 '
		If petisegmanprogpaglist.segmanprog.xobjetivo <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xobjetivo='")
				sb.Append(petisegmanprogpaglist.segmanprog.xobjetivo)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xobjetivo='")
				sb.Append(petisegmanprogpaglist.segmanprog.xobjetivo)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petisegmanprogpaglist.segmanprog.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petisegmanprogpaglist.segmanprog.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petisegmanprogpaglist.segmanprog.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respsegmanprogpaglist As New respsegmanprogpaglist
	respsegmanprogpaglist.pagsegmanprog = petisegmanprogpaglist.pagsegmanprog
	Dim skip = skip_paginacion(petisegmanprogpaglist.pagsegmanprog.npagactual, petisegmanprogpaglist.pagsegmanprog.npagtamano)
	
		If sb.ToString = "" Then
			respsegmanprogpaglist.lista_segmanprog = _db.segmanprog.OrderBy(petisegmanprogpaglist.pagsegmanprog.xcamposord & " "  & petisegmanprogpaglist.pagsegmanprog.idirord).Skip(skip).Take(petisegmanprogpaglist.pagsegmanprog.npagtamano).ToList
		Else
			respsegmanprogpaglist.lista_segmanprog = _db.segmanprog.Where(sb.ToString).OrderBy(petisegmanprogpaglist.pagsegmanprog.xcamposord & " "  & petisegmanprogpaglist.pagsegmanprog.idirord).Skip(skip).Take(petisegmanprogpaglist.pagsegmanprog.npagtamano).ToList
		End If
		'
		If (respsegmanprogpaglist.lista_segmanprog.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selsegmanprogxwheredinamicocount(sb)
		respsegmanprogpaglist.pagsegmanprog.npagcantidad = cantidad_paginas(cant_entero_reg, respsegmanprogpaglist.pagsegmanprog.npagtamano)
		Else
		respsegmanprogpaglist.pagsegmanprog.npagcantidad = 0
		respsegmanprogpaglist.pagsegmanprog.npagactual = 0
		End If
	
		Return respsegmanprogpaglist
	End Function

	Public Function selsegmanprogxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.segmanprog.count
	Else
	Return _db.segmanprog.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function inssegmanprog(segmanprog as segmanprog) as respopera
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
                param3.ParameterName = "p_xnombrecortoapl"
	
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
	param8.ParameterName = "p_idsegmanprog"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If segmanprog.xnombrecorto IsNot Nothing Then
	param9.Value = segmanprog.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanprog.xnombrelargo IsNot Nothing Then
	param10.Value = segmanprog.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.datetime
	If segmanprog.fimplementacion > cdate("01-01-1900") Then
	param11.Value = segmanprog.fimplementacion
	else
	param11.Value = cdate("01-01-1900")
	end if
	param11.ParameterName = "p_fimplementacion"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 200
	If segmanprog.xobjetivo IsNot Nothing Then
	param12.Value = segmanprog.xobjetivo
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xobjetivo"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = 0
	param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecortoapl,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanprog output,@p_xnombrecorto,@p_xnombrelargo,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)
	
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
	Public Function modsegmanprog(segmanprog as segmanprog) as respopera
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
	param8.Value = segmanprog.idsegmanprog
	param8.ParameterName = "p_idsegmanprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If segmanprog.xnombrecorto IsNot Nothing Then
	param9.Value = segmanprog.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanprog.xnombrelargo IsNot Nothing Then
	param10.Value = segmanprog.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.datetime
	If segmanprog.fimplementacion > cdate("01-01-1900") Then
	param11.Value = segmanprog.fimplementacion
	else
	param11.Value = cdate("01-01-1900")
	end if
	param11.ParameterName = "p_fimplementacion"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 200
	If segmanprog.xobjetivo IsNot Nothing Then
	param12.Value = segmanprog.xobjetivo
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xobjetivo"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = segmanprog.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanprog output,@p_xnombrecorto,@p_xnombrelargo,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function elisegmanprog(segmanprog as segmanprog) as respopera
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
                param3.ParameterName = "p_xnombrecortoapl"
                '
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
	param8.Value = segmanprog.idsegmanprog
	param8.ParameterName = "p_idsegmanprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If segmanprog.xnombrecorto IsNot Nothing Then
	param9.Value = segmanprog.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanprog.xnombrelargo IsNot Nothing Then
	param10.Value = segmanprog.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.datetime
	If segmanprog.fimplementacion > cdate("01-01-1900") Then
	param11.Value = segmanprog.fimplementacion
	else
	param11.Value = cdate("01-01-1900")
	end if
	param11.ParameterName = "p_fimplementacion"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 200
	If segmanprog.xobjetivo IsNot Nothing Then
	param12.Value = segmanprog.xobjetivo
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xobjetivo"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = segmanprog.idseglogreg
	param13.ParameterName = "p_idseglogreg"
                Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecortoapl,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanprog output,@p_xnombrecorto,@p_xnombrelargo,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg", param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13)
	
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
	Public Function elisegmanprog(idsegmanprog as decimal) as respopera
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
	param8.Value = idsegmanprog
	param8.ParameterName = "p_idsegmanprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	param10.Value = "
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.datetime
	param11.Value = cdate("01-01-1900")
	param11.ParameterName = "p_fimplementacion"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 200
	param12.Value = "
	param12.ParameterName = "p_xobjetivo"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = 0
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanprog output,@p_xnombrecorto,@p_xnombrelargo,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function actsegmanprog(segmanprog as segmanprog) as respopera
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
	param8.Value = segmanprog.idsegmanprog
	param8.ParameterName = "p_idsegmanprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If segmanprog.xnombrecorto IsNot Nothing Then
	param9.Value = segmanprog.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanprog.xnombrelargo IsNot Nothing Then
	param10.Value = segmanprog.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.datetime
	If segmanprog.fimplementacion > cdate("01-01-1900") Then
	param11.Value = segmanprog.fimplementacion
	else
	param11.Value = cdate("01-01-1900")
	end if
	param11.ParameterName = "p_fimplementacion"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 200
	If segmanprog.xobjetivo IsNot Nothing Then
	param12.Value = segmanprog.xobjetivo
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xobjetivo"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = segmanprog.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanprog output,@p_xnombrecorto,@p_xnombrelargo,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function dessegmanprog(segmanprog as segmanprog) as respopera
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
	param8.Value = segmanprog.idsegmanprog
	param8.ParameterName = "p_idsegmanprog"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If segmanprog.xnombrecorto IsNot Nothing Then
	param9.Value = segmanprog.xnombrecorto
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnombrecorto"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If segmanprog.xnombrelargo IsNot Nothing Then
	param10.Value = segmanprog.xnombrelargo
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnombrelargo"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.datetime
	If segmanprog.fimplementacion > cdate("01-01-1900") Then
	param11.Value = segmanprog.fimplementacion
	else
	param11.Value = cdate("01-01-1900")
	end if
	param11.ParameterName = "p_fimplementacion"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 200
	If segmanprog.xobjetivo IsNot Nothing Then
	param12.Value = segmanprog.xobjetivo
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_xobjetivo"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = segmanprog.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanprog @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanprog output,@p_xnombrecorto,@p_xnombrelargo,@p_fimplementacion,@p_xobjetivo,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
