Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmaninfcompController
	Inherits ApiController

	'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
	Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmaninfcompxid(idaipmaninfcomp As Decimal) As aipmaninfcomp
		Dim aipmaninfcomp As aipmaninfcomp = (From p In _db.aipmaninfcomp
										Where p.idaipmaninfcomp = idaipmaninfcomp
										Select p).SingleOrDefault
		Return aipmaninfcomp
	End Function

	<HttpPost()> _
	Public Function selaipmaninfcomp() As List(Of aipmaninfcomp)
		Dim lista_aipmaninfcomp As List(Of aipmaninfcomp) = (From p In _db.aipmaninfcomp
													Select p).ToList
		'
		Return lista_aipmaninfcomp
	End Function

<HttpPost()> _
	Public Function selaipmaninfcompxwheredinamicopag(petiaipmaninfcomppaglist as petiaipmaninfcomppaglist) as respaipmaninfcomppaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmaninfcomppaglist.aipmaninfcomp.idaipmaninfcomp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmaninfcomp=")
				sb.Append(valor_entero(petiaipmaninfcomppaglist.aipmaninfcomp.idaipmaninfcomp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmaninfcomp=")
				sb.Append(valor_entero(petiaipmaninfcomppaglist.aipmaninfcomp.idaipmaninfcomp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmaninfcomppaglist.aipmaninfcomp.xnommaninfcomp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommaninfcomp='")
				sb.Append(petiaipmaninfcomppaglist.aipmaninfcomp.xnommaninfcomp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommaninfcomp='")
				sb.Append(petiaipmaninfcomppaglist.aipmaninfcomp.xnommaninfcomp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmaninfcomppaglist.aipmaninfcomp.nordenmaninfcomp <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nordenmaninfcomp=")
				sb.Append(valor_entero(petiaipmaninfcomppaglist.aipmaninfcomp.nordenmaninfcomp))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nordenmaninfcomp=")
				sb.Append(valor_entero(petiaipmaninfcomppaglist.aipmaninfcomp.nordenmaninfcomp))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmaninfcomppaglist.aipmaninfcomp.xdescmaninfcomp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmaninfcomp='")
				sb.Append(petiaipmaninfcomppaglist.aipmaninfcomp.xdescmaninfcomp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmaninfcomp='")
				sb.Append(petiaipmaninfcomppaglist.aipmaninfcomp.xdescmaninfcomp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmaninfcomppaglist.aipmaninfcomp.iestatmaninfcomp <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmaninfcomp='")
				sb.Append(petiaipmaninfcomppaglist.aipmaninfcomp.iestatmaninfcomp)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmaninfcomp='")
				sb.Append(petiaipmaninfcomppaglist.aipmaninfcomp.iestatmaninfcomp)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmaninfcomppaglist.aipmaninfcomp.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmaninfcomppaglist.aipmaninfcomp.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmaninfcomppaglist.aipmaninfcomp.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmaninfcomppaglist As New respaipmaninfcomppaglist
	respaipmaninfcomppaglist.pagaipmaninfcomp = petiaipmaninfcomppaglist.pagaipmaninfcomp
	Dim skip = skip_paginacion(petiaipmaninfcomppaglist.pagaipmaninfcomp.npagactual, petiaipmaninfcomppaglist.pagaipmaninfcomp.npagtamano)
	
		If sb.ToString = "" Then
			respaipmaninfcomppaglist.lista_aipmaninfcomp = _db.aipmaninfcomp.OrderBy(petiaipmaninfcomppaglist.pagaipmaninfcomp.xcamposord & " "  & petiaipmaninfcomppaglist.pagaipmaninfcomp.idirord).Skip(skip).Take(petiaipmaninfcomppaglist.pagaipmaninfcomp.npagtamano).ToList
		Else
			respaipmaninfcomppaglist.lista_aipmaninfcomp = _db.aipmaninfcomp.Where(sb.ToString).OrderBy(petiaipmaninfcomppaglist.pagaipmaninfcomp.xcamposord & " "  & petiaipmaninfcomppaglist.pagaipmaninfcomp.idirord).Skip(skip).Take(petiaipmaninfcomppaglist.pagaipmaninfcomp.npagtamano).ToList
		End If
		'
		If (respaipmaninfcomppaglist.lista_aipmaninfcomp.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmaninfcompxwheredinamicocount(sb)
		respaipmaninfcomppaglist.pagaipmaninfcomp.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmaninfcomppaglist.pagaipmaninfcomp.npagtamano)
		Else
		respaipmaninfcomppaglist.pagaipmaninfcomp.npagcantidad = 0
		respaipmaninfcomppaglist.pagaipmaninfcomp.npagactual = 0
		End If
	
		Return respaipmaninfcomppaglist
	End Function

	Public Function selaipmaninfcompxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmaninfcomp.count
	Else
	Return _db.aipmaninfcomp.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmaninfcomp(aipmaninfcomp as aipmaninfcomp) as respopera
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
	param8.ParameterName = "p_idaipmaninfcomp"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmaninfcomp.xnommaninfcomp IsNot Nothing Then
	param9.Value = aipmaninfcomp.xnommaninfcomp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommaninfcomp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.smallint
	param10.Value = aipmaninfcomp.nordenmaninfcomp
	param10.ParameterName = "p_nordenmaninfcomp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 500
	If aipmaninfcomp.xdescmaninfcomp IsNot Nothing Then
	param11.Value = aipmaninfcomp.xdescmaninfcomp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmaninfcomp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmaninfcomp.iestatmaninfcomp IsNot Nothing Then
	param12.Value = aipmaninfcomp.iestatmaninfcomp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmaninfcomp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = 0
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmaninfcomp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmaninfcomp output,@p_xnommaninfcomp,@p_nordenmaninfcomp,@p_xdescmaninfcomp,@p_iestatmaninfcomp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function modaipmaninfcomp(aipmaninfcomp as aipmaninfcomp) as respopera
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
	param8.Value = aipmaninfcomp.idaipmaninfcomp
	param8.ParameterName = "p_idaipmaninfcomp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmaninfcomp.xnommaninfcomp IsNot Nothing Then
	param9.Value = aipmaninfcomp.xnommaninfcomp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommaninfcomp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.smallint
	param10.Value = aipmaninfcomp.nordenmaninfcomp
	param10.ParameterName = "p_nordenmaninfcomp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 500
	If aipmaninfcomp.xdescmaninfcomp IsNot Nothing Then
	param11.Value = aipmaninfcomp.xdescmaninfcomp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmaninfcomp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmaninfcomp.iestatmaninfcomp IsNot Nothing Then
	param12.Value = aipmaninfcomp.iestatmaninfcomp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmaninfcomp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmaninfcomp.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmaninfcomp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmaninfcomp output,@p_xnommaninfcomp,@p_nordenmaninfcomp,@p_xdescmaninfcomp,@p_iestatmaninfcomp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function eliaipmaninfcomp(aipmaninfcomp as aipmaninfcomp) as respopera
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
	param8.Value = aipmaninfcomp.idaipmaninfcomp
	param8.ParameterName = "p_idaipmaninfcomp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmaninfcomp.xnommaninfcomp IsNot Nothing Then
	param9.Value = aipmaninfcomp.xnommaninfcomp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommaninfcomp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.smallint
	param10.Value = aipmaninfcomp.nordenmaninfcomp
	param10.ParameterName = "p_nordenmaninfcomp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 500
	If aipmaninfcomp.xdescmaninfcomp IsNot Nothing Then
	param11.Value = aipmaninfcomp.xdescmaninfcomp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmaninfcomp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmaninfcomp.iestatmaninfcomp IsNot Nothing Then
	param12.Value = aipmaninfcomp.iestatmaninfcomp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmaninfcomp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmaninfcomp.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmaninfcomp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmaninfcomp output,@p_xnommaninfcomp,@p_nordenmaninfcomp,@p_xdescmaninfcomp,@p_iestatmaninfcomp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function eliaipmaninfcomp(idaipmaninfcomp as decimal) as respopera
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
	param8.Value = idaipmaninfcomp
	param8.ParameterName = "p_idaipmaninfcomp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xnommaninfcomp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.smallint
	param10.Value = 0
	param10.ParameterName = "p_nordenmaninfcomp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 500
	param11.Value = "
	param11.ParameterName = "p_xdescmaninfcomp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	param12.Value = "
	param12.ParameterName = "p_iestatmaninfcomp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = 0
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmaninfcomp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmaninfcomp output,@p_xnommaninfcomp,@p_nordenmaninfcomp,@p_xdescmaninfcomp,@p_iestatmaninfcomp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function actaipmaninfcomp(aipmaninfcomp as aipmaninfcomp) as respopera
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
	param8.Value = aipmaninfcomp.idaipmaninfcomp
	param8.ParameterName = "p_idaipmaninfcomp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmaninfcomp.xnommaninfcomp IsNot Nothing Then
	param9.Value = aipmaninfcomp.xnommaninfcomp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommaninfcomp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.smallint
	param10.Value = aipmaninfcomp.nordenmaninfcomp
	param10.ParameterName = "p_nordenmaninfcomp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 500
	If aipmaninfcomp.xdescmaninfcomp IsNot Nothing Then
	param11.Value = aipmaninfcomp.xdescmaninfcomp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmaninfcomp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmaninfcomp.iestatmaninfcomp IsNot Nothing Then
	param12.Value = aipmaninfcomp.iestatmaninfcomp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmaninfcomp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmaninfcomp.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmaninfcomp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmaninfcomp output,@p_xnommaninfcomp,@p_nordenmaninfcomp,@p_xdescmaninfcomp,@p_iestatmaninfcomp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function desaipmaninfcomp(aipmaninfcomp as aipmaninfcomp) as respopera
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
	param8.Value = aipmaninfcomp.idaipmaninfcomp
	param8.ParameterName = "p_idaipmaninfcomp"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmaninfcomp.xnommaninfcomp IsNot Nothing Then
	param9.Value = aipmaninfcomp.xnommaninfcomp
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommaninfcomp"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.smallint
	param10.Value = aipmaninfcomp.nordenmaninfcomp
	param10.ParameterName = "p_nordenmaninfcomp"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 500
	If aipmaninfcomp.xdescmaninfcomp IsNot Nothing Then
	param11.Value = aipmaninfcomp.xdescmaninfcomp
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmaninfcomp"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmaninfcomp.iestatmaninfcomp IsNot Nothing Then
	param12.Value = aipmaninfcomp.iestatmaninfcomp
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmaninfcomp"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmaninfcomp.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmaninfcomp @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmaninfcomp output,@p_xnommaninfcomp,@p_nordenmaninfcomp,@p_xdescmaninfcomp,@p_iestatmaninfcomp,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
