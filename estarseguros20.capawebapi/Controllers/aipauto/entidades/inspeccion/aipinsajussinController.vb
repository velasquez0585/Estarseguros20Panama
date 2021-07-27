Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsajussinController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsajussinxid(idaipinsajussin As Decimal) As aipinsajussin
		Dim aipinsajussin As aipinsajussin = (From p In _db.aipinsajussin
										Where p.idaipinsajussin = idaipinsajussin
										Select p).SingleOrDefault
		Return aipinsajussin
	End Function

	<HttpPost()> _
	Public Function selaipinsajussin() As List(Of aipinsajussin)
		Dim lista_aipinsajussin As List(Of aipinsajussin) = (From p In _db.aipinsajussin
													Select p).ToList
		'
		Return lista_aipinsajussin
	End Function

<HttpPost()> _
	Public Function selaipinsajussinxwheredinamicopag(petiaipinsajussinpaglist as petiaipinsajussinpaglist) as respaipinsajussinpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsajussinpaglist.aipinsajussin.idaipinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idaipinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idaipinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.isininsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.isininsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.isininsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.isininsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.isininsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.irecupinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irecupinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.irecupinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irecupinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.irecupinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.itercinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.itercinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.itercinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itercinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.itercinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.xnomaseginsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.xnomaseginsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.xnomaseginsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.xsucuinsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.xsucuinsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.xsucuinsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.nkiloinsajussin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.nkiloinsajussin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinsajussin=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.nkiloinsajussin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.xdescinsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.xdescinsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.xdescinsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.iestatinsajussin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.iestatinsajussin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajussin='")
				sb.Append(petiaipinsajussinpaglist.aipinsajussin.iestatinsajussin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajussinpaglist.aipinsajussin.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajussinpaglist.aipinsajussin.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsajussinpaglist As New respaipinsajussinpaglist
	respaipinsajussinpaglist.pagaipinsajussin = petiaipinsajussinpaglist.pagaipinsajussin
	Dim skip = skip_paginacion(petiaipinsajussinpaglist.pagaipinsajussin.npagactual, petiaipinsajussinpaglist.pagaipinsajussin.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsajussinpaglist.lista_aipinsajussin = _db.aipinsajussin.OrderBy(petiaipinsajussinpaglist.pagaipinsajussin.xcamposord & " "  & petiaipinsajussinpaglist.pagaipinsajussin.idirord).Skip(skip).Take(petiaipinsajussinpaglist.pagaipinsajussin.npagtamano).ToList
		Else
			respaipinsajussinpaglist.lista_aipinsajussin = _db.aipinsajussin.Where(sb.ToString).OrderBy(petiaipinsajussinpaglist.pagaipinsajussin.xcamposord & " "  & petiaipinsajussinpaglist.pagaipinsajussin.idirord).Skip(skip).Take(petiaipinsajussinpaglist.pagaipinsajussin.npagtamano).ToList
		End If
		'
		If (respaipinsajussinpaglist.lista_aipinsajussin.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsajussinxwheredinamicocount(sb)
		respaipinsajussinpaglist.pagaipinsajussin.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsajussinpaglist.pagaipinsajussin.npagtamano)
		Else
		respaipinsajussinpaglist.pagaipinsajussin.npagcantidad = 0
		respaipinsajussinpaglist.pagaipinsajussin.npagactual = 0
		End If
	
		Return respaipinsajussinpaglist
	End Function

	Public Function selaipinsajussinxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsajussin.count
	Else
	Return _db.aipinsajussin.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsajussin(aipinsajussin as aipinsajussin) as respopera
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
	param8.ParameterName = "p_idaipinsajussin"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajussin.isininsajussin
	param10.ParameterName = "p_isininsajussin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajussin.irecupinsajussin
	param11.ParameterName = "p_irecupinsajussin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajussin.itercinsajussin
	param12.ParameterName = "p_itercinsajussin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajussin.xnomaseginsajussin IsNot Nothing Then
	param13.Value = aipinsajussin.xnomaseginsajussin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajussin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajussin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajussin.xsucuinsajussin IsNot Nothing Then
	param15.Value = aipinsajussin.xsucuinsajussin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajussin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajussin.nkiloinsajussin
	param16.ParameterName = "p_nkiloinsajussin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajussin.xdescinsajussin IsNot Nothing Then
	param17.Value = aipinsajussin.xdescinsajussin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajussin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajussin.iestatinsajussin IsNot Nothing Then
	param18.Value = aipinsajussin.iestatinsajussin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajussin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussin output,@p_idaipinsenc,@p_isininsajussin,@p_irecupinsajussin,@p_itercinsajussin,@p_xnomaseginsajussin,@p_idaipmanveh,@p_xsucuinsajussin,@p_nkiloinsajussin,@p_xdescinsajussin,@p_iestatinsajussin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function modaipinsajussin(aipinsajussin as aipinsajussin) as respopera
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
	param8.Value = aipinsajussin.idaipinsajussin
	param8.ParameterName = "p_idaipinsajussin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajussin.isininsajussin
	param10.ParameterName = "p_isininsajussin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajussin.irecupinsajussin
	param11.ParameterName = "p_irecupinsajussin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajussin.itercinsajussin
	param12.ParameterName = "p_itercinsajussin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajussin.xnomaseginsajussin IsNot Nothing Then
	param13.Value = aipinsajussin.xnomaseginsajussin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajussin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajussin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajussin.xsucuinsajussin IsNot Nothing Then
	param15.Value = aipinsajussin.xsucuinsajussin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajussin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajussin.nkiloinsajussin
	param16.ParameterName = "p_nkiloinsajussin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajussin.xdescinsajussin IsNot Nothing Then
	param17.Value = aipinsajussin.xdescinsajussin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajussin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajussin.iestatinsajussin IsNot Nothing Then
	param18.Value = aipinsajussin.iestatinsajussin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajussin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajussin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussin output,@p_idaipinsenc,@p_isininsajussin,@p_irecupinsajussin,@p_itercinsajussin,@p_xnomaseginsajussin,@p_idaipmanveh,@p_xsucuinsajussin,@p_nkiloinsajussin,@p_xdescinsajussin,@p_iestatinsajussin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinsajussin(aipinsajussin as aipinsajussin) as respopera
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
	param8.Value = aipinsajussin.idaipinsajussin
	param8.ParameterName = "p_idaipinsajussin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajussin.isininsajussin
	param10.ParameterName = "p_isininsajussin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajussin.irecupinsajussin
	param11.ParameterName = "p_irecupinsajussin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajussin.itercinsajussin
	param12.ParameterName = "p_itercinsajussin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajussin.xnomaseginsajussin IsNot Nothing Then
	param13.Value = aipinsajussin.xnomaseginsajussin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajussin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajussin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajussin.xsucuinsajussin IsNot Nothing Then
	param15.Value = aipinsajussin.xsucuinsajussin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajussin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajussin.nkiloinsajussin
	param16.ParameterName = "p_nkiloinsajussin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajussin.xdescinsajussin IsNot Nothing Then
	param17.Value = aipinsajussin.xdescinsajussin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajussin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajussin.iestatinsajussin IsNot Nothing Then
	param18.Value = aipinsajussin.iestatinsajussin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajussin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajussin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussin output,@p_idaipinsenc,@p_isininsajussin,@p_irecupinsajussin,@p_itercinsajussin,@p_xnomaseginsajussin,@p_idaipmanveh,@p_xsucuinsajussin,@p_nkiloinsajussin,@p_xdescinsajussin,@p_iestatinsajussin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinsajussin(idaipinsajussin as decimal) as respopera
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
	param8.Value = idaipinsajussin
	param8.ParameterName = "p_idaipinsajussin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = 0
	param10.ParameterName = "p_isininsajussin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = 0
	param11.ParameterName = "p_irecupinsajussin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = 0
	param12.ParameterName = "p_itercinsajussin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	param13.Value = ""
	param13.ParameterName = "p_xnomaseginsajussin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = 0
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
                param15.Value = ""
                param15.ParameterName = "p_xsucuinsajussin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = 0
	param16.ParameterName = "p_nkiloinsajussin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	param17.Value = ""
	param17.ParameterName = "p_xdescinsajussin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
                param18.Value = ""
                param18.ParameterName = "p_iestatinsajussin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussin output,@p_idaipinsenc,@p_isininsajussin,@p_irecupinsajussin,@p_itercinsajussin,@p_xnomaseginsajussin,@p_idaipmanveh,@p_xsucuinsajussin,@p_nkiloinsajussin,@p_xdescinsajussin,@p_iestatinsajussin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function actaipinsajussin(aipinsajussin as aipinsajussin) as respopera
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
	param8.Value = aipinsajussin.idaipinsajussin
	param8.ParameterName = "p_idaipinsajussin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajussin.isininsajussin
	param10.ParameterName = "p_isininsajussin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajussin.irecupinsajussin
	param11.ParameterName = "p_irecupinsajussin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajussin.itercinsajussin
	param12.ParameterName = "p_itercinsajussin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajussin.xnomaseginsajussin IsNot Nothing Then
	param13.Value = aipinsajussin.xnomaseginsajussin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajussin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajussin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajussin.xsucuinsajussin IsNot Nothing Then
	param15.Value = aipinsajussin.xsucuinsajussin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajussin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajussin.nkiloinsajussin
	param16.ParameterName = "p_nkiloinsajussin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajussin.xdescinsajussin IsNot Nothing Then
	param17.Value = aipinsajussin.xdescinsajussin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajussin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajussin.iestatinsajussin IsNot Nothing Then
	param18.Value = aipinsajussin.iestatinsajussin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajussin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajussin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussin output,@p_idaipinsenc,@p_isininsajussin,@p_irecupinsajussin,@p_itercinsajussin,@p_xnomaseginsajussin,@p_idaipmanveh,@p_xsucuinsajussin,@p_nkiloinsajussin,@p_xdescinsajussin,@p_iestatinsajussin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function desaipinsajussin(aipinsajussin as aipinsajussin) as respopera
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
	param8.Value = aipinsajussin.idaipinsajussin
	param8.ParameterName = "p_idaipinsajussin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajussin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajussin.isininsajussin
	param10.ParameterName = "p_isininsajussin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajussin.irecupinsajussin
	param11.ParameterName = "p_irecupinsajussin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajussin.itercinsajussin
	param12.ParameterName = "p_itercinsajussin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajussin.xnomaseginsajussin IsNot Nothing Then
	param13.Value = aipinsajussin.xnomaseginsajussin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajussin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajussin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajussin.xsucuinsajussin IsNot Nothing Then
	param15.Value = aipinsajussin.xsucuinsajussin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajussin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajussin.nkiloinsajussin
	param16.ParameterName = "p_nkiloinsajussin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajussin.xdescinsajussin IsNot Nothing Then
	param17.Value = aipinsajussin.xdescinsajussin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajussin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajussin.iestatinsajussin IsNot Nothing Then
	param18.Value = aipinsajussin.iestatinsajussin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajussin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajussin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajussin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajussin output,@p_idaipinsenc,@p_isininsajussin,@p_irecupinsajussin,@p_itercinsajussin,@p_xnomaseginsajussin,@p_idaipmanveh,@p_xsucuinsajussin,@p_nkiloinsajussin,@p_xdescinsajussin,@p_iestatinsajussin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
