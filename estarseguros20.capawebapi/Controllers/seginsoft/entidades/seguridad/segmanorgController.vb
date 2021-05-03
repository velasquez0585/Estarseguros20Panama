﻿Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.entidades.seguridad
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace seginsoft.entidades.controlador
Public Class segmanorgController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selsegmanorgxid(idsegmanorg As Decimal) As segmanorg
		Dim segmanorg As segmanorg = (From p In _db.segmanorg
										Where p.idsegmanorg = idsegmanorg
										Select p).SingleOrDefault
		Return segmanorg
	End Function

	<HttpPost()> _
	Public Function selsegmanorg() As List(Of segmanorg)
		Dim lista_segmanorg As List(Of segmanorg) = (From p In _db.segmanorg
													Select p).ToList
		'
		Return lista_segmanorg
	End Function

<HttpPost()> _
	Public Function selsegmanorgxwheredinamicopag(petisegmanorgpaglist as petisegmanorgpaglist) as respsegmanorgpaglist
		Dim sb As New StringBuilder("")
		'
		If petisegmanorgpaglist.segmanorg.idsegmanorg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idsegmanorg=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idsegmanorg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idsegmanorg=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idsegmanorg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanorgpaglist.segmanorg.idcomunmanempr <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmanempr=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idcomunmanempr))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmanempr=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idcomunmanempr))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanorgpaglist.segmanorg.idcomunmandir <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmandir=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idcomunmandir))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmandir=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idcomunmandir))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanorgpaglist.segmanorg.idcomunmancom <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmancom=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idcomunmancom))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmancom=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idcomunmancom))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petisegmanorgpaglist.segmanorg.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petisegmanorgpaglist.segmanorg.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respsegmanorgpaglist As New respsegmanorgpaglist
	respsegmanorgpaglist.pagsegmanorg = petisegmanorgpaglist.pagsegmanorg
	Dim skip = skip_paginacion(petisegmanorgpaglist.pagsegmanorg.npagactual, petisegmanorgpaglist.pagsegmanorg.npagtamano)
	
		If sb.ToString = "" Then
			respsegmanorgpaglist.lista_segmanorg = _db.segmanorg.OrderBy(petisegmanorgpaglist.pagsegmanorg.xcamposord & " "  & petisegmanorgpaglist.pagsegmanorg.idirord).Skip(skip).Take(petisegmanorgpaglist.pagsegmanorg.npagtamano).ToList
		Else
			respsegmanorgpaglist.lista_segmanorg = _db.segmanorg.Where(sb.ToString).OrderBy(petisegmanorgpaglist.pagsegmanorg.xcamposord & " "  & petisegmanorgpaglist.pagsegmanorg.idirord).Skip(skip).Take(petisegmanorgpaglist.pagsegmanorg.npagtamano).ToList
		End If
		'
		If (respsegmanorgpaglist.lista_segmanorg.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selsegmanorgxwheredinamicocount(sb)
		respsegmanorgpaglist.pagsegmanorg.npagcantidad = cantidad_paginas(cant_entero_reg, respsegmanorgpaglist.pagsegmanorg.npagtamano)
		Else
		respsegmanorgpaglist.pagsegmanorg.npagcantidad = 0
		respsegmanorgpaglist.pagsegmanorg.npagactual = 0
		End If
	
		Return respsegmanorgpaglist
	End Function

	Public Function selsegmanorgxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.segmanorg.count
	Else
	Return _db.segmanorg.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function inssegmanorg(segmanorg as segmanorg) as respopera
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
	param8.ParameterName = "p_idsegmanorg"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segmanorg.idcomunmanempr
	param9.ParameterName = "p_idcomunmanempr"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segmanorg.idcomunmandir
	param10.ParameterName = "p_idcomunmandir"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segmanorg.idcomunmancom
	param11.ParameterName = "p_idcomunmancom"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanorg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanorg output,@p_idcomunmanempr,@p_idcomunmandir,@p_idcomunmancom,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function modsegmanorg(segmanorg as segmanorg) as respopera
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
	param8.Value = segmanorg.idsegmanorg
	param8.ParameterName = "p_idsegmanorg"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segmanorg.idcomunmanempr
	param9.ParameterName = "p_idcomunmanempr"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segmanorg.idcomunmandir
	param10.ParameterName = "p_idcomunmandir"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segmanorg.idcomunmancom
	param11.ParameterName = "p_idcomunmancom"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanorg.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanorg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanorg output,@p_idcomunmanempr,@p_idcomunmandir,@p_idcomunmancom,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function elisegmanorg(segmanorg as segmanorg) as respopera
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
	param8.Value = segmanorg.idsegmanorg
	param8.ParameterName = "p_idsegmanorg"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segmanorg.idcomunmanempr
	param9.ParameterName = "p_idcomunmanempr"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segmanorg.idcomunmandir
	param10.ParameterName = "p_idcomunmandir"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segmanorg.idcomunmancom
	param11.ParameterName = "p_idcomunmancom"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanorg.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanorg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanorg output,@p_idcomunmanempr,@p_idcomunmandir,@p_idcomunmancom,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function elisegmanorg(idsegmanorg as decimal) as respopera
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
	param8.Value = idsegmanorg
	param8.ParameterName = "p_idsegmanorg"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idcomunmanempr"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_idcomunmandir"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = 0
	param11.ParameterName = "p_idcomunmancom"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanorg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanorg output,@p_idcomunmanempr,@p_idcomunmandir,@p_idcomunmancom,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function actsegmanorg(segmanorg as segmanorg) as respopera
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
	param8.Value = segmanorg.idsegmanorg
	param8.ParameterName = "p_idsegmanorg"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segmanorg.idcomunmanempr
	param9.ParameterName = "p_idcomunmanempr"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segmanorg.idcomunmandir
	param10.ParameterName = "p_idcomunmandir"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segmanorg.idcomunmancom
	param11.ParameterName = "p_idcomunmancom"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanorg.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanorg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanorg output,@p_idcomunmanempr,@p_idcomunmandir,@p_idcomunmancom,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function dessegmanorg(segmanorg as segmanorg) as respopera
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
	param8.Value = segmanorg.idsegmanorg
	param8.ParameterName = "p_idsegmanorg"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = segmanorg.idcomunmanempr
	param9.ParameterName = "p_idcomunmanempr"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = segmanorg.idcomunmandir
	param10.ParameterName = "p_idcomunmandir"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.decimal
	param11.Precision = 18
	param11.Scale = 0
	param11.Value = segmanorg.idcomunmancom
	param11.ParameterName = "p_idcomunmancom"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = segmanorg.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_segmanorg @p_ioperacion,@p_idsegmanusu,@p_xnombrecorto,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idsegmanorg output,@p_idcomunmanempr,@p_idcomunmandir,@p_idcomunmancom,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
