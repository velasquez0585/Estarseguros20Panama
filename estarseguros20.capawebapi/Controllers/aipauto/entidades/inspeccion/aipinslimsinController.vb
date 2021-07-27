Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinslimsinController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinslimsinxid(idaipinslimsin As Decimal) As aipinslimsin
		Dim aipinslimsin As aipinslimsin = (From p In _db.aipinslimsin
										Where p.idaipinslimsin = idaipinslimsin
										Select p).SingleOrDefault
		Return aipinslimsin
	End Function

	<HttpPost()> _
	Public Function selaipinslimsin() As List(Of aipinslimsin)
		Dim lista_aipinslimsin As List(Of aipinslimsin) = (From p In _db.aipinslimsin
													Select p).ToList
		'
		Return lista_aipinslimsin
	End Function

<HttpPost()> _
	Public Function selaipinslimsinxwheredinamicopag(petiaipinslimsinpaglist as petiaipinslimsinpaglist) as respaipinslimsinpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinslimsinpaglist.aipinslimsin.idaipinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idaipinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idaipinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.nfactinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nfactinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.nfactinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nfactinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.nfactinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.irepuinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irepuinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.irepuinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irepuinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.irepuinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.imobrinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.imobrinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.imobrinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imobrinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.imobrinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.xnomaseginslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.xnomaseginslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.xnomaseginslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.xsucuinslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.xsucuinslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.xsucuinslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.nkiloinslimsin <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.nkiloinslimsin))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinslimsin=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.nkiloinslimsin))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.xdescinslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.xdescinslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.xdescinslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.iestatinslimsin <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.iestatinslimsin)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsin='")
				sb.Append(petiaipinslimsinpaglist.aipinslimsin.iestatinslimsin)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsinpaglist.aipinslimsin.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsinpaglist.aipinslimsin.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinslimsinpaglist As New respaipinslimsinpaglist
	respaipinslimsinpaglist.pagaipinslimsin = petiaipinslimsinpaglist.pagaipinslimsin
	Dim skip = skip_paginacion(petiaipinslimsinpaglist.pagaipinslimsin.npagactual, petiaipinslimsinpaglist.pagaipinslimsin.npagtamano)
	
		If sb.ToString = "" Then
			respaipinslimsinpaglist.lista_aipinslimsin = _db.aipinslimsin.OrderBy(petiaipinslimsinpaglist.pagaipinslimsin.xcamposord & " "  & petiaipinslimsinpaglist.pagaipinslimsin.idirord).Skip(skip).Take(petiaipinslimsinpaglist.pagaipinslimsin.npagtamano).ToList
		Else
			respaipinslimsinpaglist.lista_aipinslimsin = _db.aipinslimsin.Where(sb.ToString).OrderBy(petiaipinslimsinpaglist.pagaipinslimsin.xcamposord & " "  & petiaipinslimsinpaglist.pagaipinslimsin.idirord).Skip(skip).Take(petiaipinslimsinpaglist.pagaipinslimsin.npagtamano).ToList
		End If
		'
		If (respaipinslimsinpaglist.lista_aipinslimsin.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinslimsinxwheredinamicocount(sb)
		respaipinslimsinpaglist.pagaipinslimsin.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinslimsinpaglist.pagaipinslimsin.npagtamano)
		Else
		respaipinslimsinpaglist.pagaipinslimsin.npagcantidad = 0
		respaipinslimsinpaglist.pagaipinslimsin.npagactual = 0
		End If
	
		Return respaipinslimsinpaglist
	End Function

	Public Function selaipinslimsinxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinslimsin.count
	Else
	Return _db.aipinslimsin.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinslimsin(aipinslimsin as aipinslimsin) as respopera
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
	param8.ParameterName = "p_idaipinslimsin"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsin.nfactinslimsin
	param10.ParameterName = "p_nfactinslimsin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsin.irepuinslimsin
	param11.ParameterName = "p_irepuinslimsin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsin.imobrinslimsin
	param12.ParameterName = "p_imobrinslimsin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsin.xnomaseginslimsin IsNot Nothing Then
	param13.Value = aipinslimsin.xnomaseginslimsin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsin.xsucuinslimsin IsNot Nothing Then
	param15.Value = aipinslimsin.xsucuinslimsin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsin.nkiloinslimsin
	param16.ParameterName = "p_nkiloinslimsin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsin.xdescinslimsin IsNot Nothing Then
	param17.Value = aipinslimsin.xdescinslimsin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsin.iestatinslimsin IsNot Nothing Then
	param18.Value = aipinslimsin.iestatinslimsin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsin output,@p_idaipinsenc,@p_nfactinslimsin,@p_irepuinslimsin,@p_imobrinslimsin,@p_xnomaseginslimsin,@p_idaipmanveh,@p_xsucuinslimsin,@p_nkiloinslimsin,@p_xdescinslimsin,@p_iestatinslimsin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function modaipinslimsin(aipinslimsin as aipinslimsin) as respopera
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
	param8.Value = aipinslimsin.idaipinslimsin
	param8.ParameterName = "p_idaipinslimsin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsin.nfactinslimsin
	param10.ParameterName = "p_nfactinslimsin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsin.irepuinslimsin
	param11.ParameterName = "p_irepuinslimsin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsin.imobrinslimsin
	param12.ParameterName = "p_imobrinslimsin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsin.xnomaseginslimsin IsNot Nothing Then
	param13.Value = aipinslimsin.xnomaseginslimsin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsin.xsucuinslimsin IsNot Nothing Then
	param15.Value = aipinslimsin.xsucuinslimsin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsin.nkiloinslimsin
	param16.ParameterName = "p_nkiloinslimsin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsin.xdescinslimsin IsNot Nothing Then
	param17.Value = aipinslimsin.xdescinslimsin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsin.iestatinslimsin IsNot Nothing Then
	param18.Value = aipinslimsin.iestatinslimsin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsin output,@p_idaipinsenc,@p_nfactinslimsin,@p_irepuinslimsin,@p_imobrinslimsin,@p_xnomaseginslimsin,@p_idaipmanveh,@p_xsucuinslimsin,@p_nkiloinslimsin,@p_xdescinslimsin,@p_iestatinslimsin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinslimsin(aipinslimsin as aipinslimsin) as respopera
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
	param8.Value = aipinslimsin.idaipinslimsin
	param8.ParameterName = "p_idaipinslimsin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsin.nfactinslimsin
	param10.ParameterName = "p_nfactinslimsin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsin.irepuinslimsin
	param11.ParameterName = "p_irepuinslimsin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsin.imobrinslimsin
	param12.ParameterName = "p_imobrinslimsin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsin.xnomaseginslimsin IsNot Nothing Then
	param13.Value = aipinslimsin.xnomaseginslimsin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsin.xsucuinslimsin IsNot Nothing Then
	param15.Value = aipinslimsin.xsucuinslimsin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsin.nkiloinslimsin
	param16.ParameterName = "p_nkiloinslimsin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsin.xdescinslimsin IsNot Nothing Then
	param17.Value = aipinslimsin.xdescinslimsin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsin.iestatinslimsin IsNot Nothing Then
	param18.Value = aipinslimsin.iestatinslimsin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsin output,@p_idaipinsenc,@p_nfactinslimsin,@p_irepuinslimsin,@p_imobrinslimsin,@p_xnomaseginslimsin,@p_idaipmanveh,@p_xsucuinslimsin,@p_nkiloinslimsin,@p_xdescinslimsin,@p_iestatinslimsin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinslimsin(idaipinslimsin as decimal) as respopera
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
	param8.Value = idaipinslimsin
	param8.ParameterName = "p_idaipinslimsin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = 0
	param10.ParameterName = "p_nfactinslimsin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = 0
	param11.ParameterName = "p_irepuinslimsin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = 0
	param12.ParameterName = "p_imobrinslimsin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
                param13.Value = ""
                param13.ParameterName = "p_xnomaseginslimsin"
	
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
	param15.ParameterName = "p_xsucuinslimsin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = 0
	param16.ParameterName = "p_nkiloinslimsin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	param17.Value = ""
	param17.ParameterName = "p_xdescinslimsin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	param18.Value = ""
	param18.ParameterName = "p_iestatinslimsin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsin output,@p_idaipinsenc,@p_nfactinslimsin,@p_irepuinslimsin,@p_imobrinslimsin,@p_xnomaseginslimsin,@p_idaipmanveh,@p_xsucuinslimsin,@p_nkiloinslimsin,@p_xdescinslimsin,@p_iestatinslimsin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function actaipinslimsin(aipinslimsin as aipinslimsin) as respopera
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
	param8.Value = aipinslimsin.idaipinslimsin
	param8.ParameterName = "p_idaipinslimsin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsin.nfactinslimsin
	param10.ParameterName = "p_nfactinslimsin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsin.irepuinslimsin
	param11.ParameterName = "p_irepuinslimsin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsin.imobrinslimsin
	param12.ParameterName = "p_imobrinslimsin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsin.xnomaseginslimsin IsNot Nothing Then
	param13.Value = aipinslimsin.xnomaseginslimsin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsin.xsucuinslimsin IsNot Nothing Then
	param15.Value = aipinslimsin.xsucuinslimsin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsin.nkiloinslimsin
	param16.ParameterName = "p_nkiloinslimsin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsin.xdescinslimsin IsNot Nothing Then
	param17.Value = aipinslimsin.xdescinslimsin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsin.iestatinslimsin IsNot Nothing Then
	param18.Value = aipinslimsin.iestatinslimsin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsin output,@p_idaipinsenc,@p_nfactinslimsin,@p_irepuinslimsin,@p_imobrinslimsin,@p_xnomaseginslimsin,@p_idaipmanveh,@p_xsucuinslimsin,@p_nkiloinslimsin,@p_xdescinslimsin,@p_iestatinslimsin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function desaipinslimsin(aipinslimsin as aipinslimsin) as respopera
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
	param8.Value = aipinslimsin.idaipinslimsin
	param8.ParameterName = "p_idaipinslimsin"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsin.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsin.nfactinslimsin
	param10.ParameterName = "p_nfactinslimsin"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsin.irepuinslimsin
	param11.ParameterName = "p_irepuinslimsin"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsin.imobrinslimsin
	param12.ParameterName = "p_imobrinslimsin"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsin.xnomaseginslimsin IsNot Nothing Then
	param13.Value = aipinslimsin.xnomaseginslimsin
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsin"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsin.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsin.xsucuinslimsin IsNot Nothing Then
	param15.Value = aipinslimsin.xsucuinslimsin
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsin"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsin.nkiloinslimsin
	param16.ParameterName = "p_nkiloinslimsin"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsin.xdescinslimsin IsNot Nothing Then
	param17.Value = aipinslimsin.xdescinslimsin
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsin"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsin.iestatinslimsin IsNot Nothing Then
	param18.Value = aipinslimsin.iestatinslimsin
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsin"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsin.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsin @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsin output,@p_idaipinsenc,@p_nfactinslimsin,@p_irepuinslimsin,@p_imobrinslimsin,@p_xnomaseginslimsin,@p_idaipmanveh,@p_xsucuinslimsin,@p_nkiloinslimsin,@p_xdescinslimsin,@p_iestatinslimsin,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
