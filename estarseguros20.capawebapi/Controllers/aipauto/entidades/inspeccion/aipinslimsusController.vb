Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinslimsusController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinslimsusxid(idaipinslimsus As Decimal) As aipinslimsus
		Dim aipinslimsus As aipinslimsus = (From p In _db.aipinslimsus
										Where p.idaipinslimsus = idaipinslimsus
										Select p).SingleOrDefault
		Return aipinslimsus
	End Function

	<HttpPost()> _
	Public Function selaipinslimsus() As List(Of aipinslimsus)
		Dim lista_aipinslimsus As List(Of aipinslimsus) = (From p In _db.aipinslimsus
													Select p).ToList
		'
		Return lista_aipinslimsus
	End Function

<HttpPost()> _
	Public Function selaipinslimsusxwheredinamicopag(petiaipinslimsuspaglist as petiaipinslimsuspaglist) as respaipinslimsuspaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinslimsuspaglist.aipinslimsus.idaipinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idaipinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idaipinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.nfactinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nfactinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.nfactinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nfactinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.nfactinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.irepuinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irepuinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.irepuinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irepuinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.irepuinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.imobrinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.imobrinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.imobrinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.imobrinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.imobrinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.xnomaseginslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.xnomaseginslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.xnomaseginslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.xsucuinslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.xsucuinslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.xsucuinslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.nkiloinslimsus <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.nkiloinslimsus))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinslimsus=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.nkiloinslimsus))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.xdescinslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.xdescinslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.xdescinslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.iestatinslimsus <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.iestatinslimsus)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinslimsus='")
				sb.Append(petiaipinslimsuspaglist.aipinslimsus.iestatinslimsus)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinslimsuspaglist.aipinslimsus.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinslimsuspaglist.aipinslimsus.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinslimsuspaglist As New respaipinslimsuspaglist
	respaipinslimsuspaglist.pagaipinslimsus = petiaipinslimsuspaglist.pagaipinslimsus
	Dim skip = skip_paginacion(petiaipinslimsuspaglist.pagaipinslimsus.npagactual, petiaipinslimsuspaglist.pagaipinslimsus.npagtamano)
	
		If sb.ToString = "" Then
			respaipinslimsuspaglist.lista_aipinslimsus = _db.aipinslimsus.OrderBy(petiaipinslimsuspaglist.pagaipinslimsus.xcamposord & " "  & petiaipinslimsuspaglist.pagaipinslimsus.idirord).Skip(skip).Take(petiaipinslimsuspaglist.pagaipinslimsus.npagtamano).ToList
		Else
			respaipinslimsuspaglist.lista_aipinslimsus = _db.aipinslimsus.Where(sb.ToString).OrderBy(petiaipinslimsuspaglist.pagaipinslimsus.xcamposord & " "  & petiaipinslimsuspaglist.pagaipinslimsus.idirord).Skip(skip).Take(petiaipinslimsuspaglist.pagaipinslimsus.npagtamano).ToList
		End If
		'
		If (respaipinslimsuspaglist.lista_aipinslimsus.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinslimsusxwheredinamicocount(sb)
		respaipinslimsuspaglist.pagaipinslimsus.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinslimsuspaglist.pagaipinslimsus.npagtamano)
		Else
		respaipinslimsuspaglist.pagaipinslimsus.npagcantidad = 0
		respaipinslimsuspaglist.pagaipinslimsus.npagactual = 0
		End If
	
		Return respaipinslimsuspaglist
	End Function

	Public Function selaipinslimsusxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinslimsus.count
	Else
	Return _db.aipinslimsus.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinslimsus(aipinslimsus as aipinslimsus) as respopera
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
	param8.ParameterName = "p_idaipinslimsus"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsus.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsus.nfactinslimsus
	param10.ParameterName = "p_nfactinslimsus"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsus.irepuinslimsus
	param11.ParameterName = "p_irepuinslimsus"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsus.imobrinslimsus
	param12.ParameterName = "p_imobrinslimsus"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsus.xnomaseginslimsus IsNot Nothing Then
	param13.Value = aipinslimsus.xnomaseginslimsus
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsus"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsus.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsus.xsucuinslimsus IsNot Nothing Then
	param15.Value = aipinslimsus.xsucuinslimsus
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsus"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsus.nkiloinslimsus
	param16.ParameterName = "p_nkiloinslimsus"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsus.xdescinslimsus IsNot Nothing Then
	param17.Value = aipinslimsus.xdescinslimsus
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsus"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsus.iestatinslimsus IsNot Nothing Then
	param18.Value = aipinslimsus.iestatinslimsus
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsus"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsus output,@p_idaipinsenc,@p_nfactinslimsus,@p_irepuinslimsus,@p_imobrinslimsus,@p_xnomaseginslimsus,@p_idaipmanveh,@p_xsucuinslimsus,@p_nkiloinslimsus,@p_xdescinslimsus,@p_iestatinslimsus,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function modaipinslimsus(aipinslimsus as aipinslimsus) as respopera
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
	param8.Value = aipinslimsus.idaipinslimsus
	param8.ParameterName = "p_idaipinslimsus"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsus.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsus.nfactinslimsus
	param10.ParameterName = "p_nfactinslimsus"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsus.irepuinslimsus
	param11.ParameterName = "p_irepuinslimsus"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsus.imobrinslimsus
	param12.ParameterName = "p_imobrinslimsus"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsus.xnomaseginslimsus IsNot Nothing Then
	param13.Value = aipinslimsus.xnomaseginslimsus
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsus"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsus.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsus.xsucuinslimsus IsNot Nothing Then
	param15.Value = aipinslimsus.xsucuinslimsus
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsus"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsus.nkiloinslimsus
	param16.ParameterName = "p_nkiloinslimsus"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsus.xdescinslimsus IsNot Nothing Then
	param17.Value = aipinslimsus.xdescinslimsus
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsus"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsus.iestatinslimsus IsNot Nothing Then
	param18.Value = aipinslimsus.iestatinslimsus
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsus"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsus.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsus output,@p_idaipinsenc,@p_nfactinslimsus,@p_irepuinslimsus,@p_imobrinslimsus,@p_xnomaseginslimsus,@p_idaipmanveh,@p_xsucuinslimsus,@p_nkiloinslimsus,@p_xdescinslimsus,@p_iestatinslimsus,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinslimsus(aipinslimsus as aipinslimsus) as respopera
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
	param8.Value = aipinslimsus.idaipinslimsus
	param8.ParameterName = "p_idaipinslimsus"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsus.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsus.nfactinslimsus
	param10.ParameterName = "p_nfactinslimsus"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsus.irepuinslimsus
	param11.ParameterName = "p_irepuinslimsus"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsus.imobrinslimsus
	param12.ParameterName = "p_imobrinslimsus"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsus.xnomaseginslimsus IsNot Nothing Then
	param13.Value = aipinslimsus.xnomaseginslimsus
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsus"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsus.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsus.xsucuinslimsus IsNot Nothing Then
	param15.Value = aipinslimsus.xsucuinslimsus
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsus"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsus.nkiloinslimsus
	param16.ParameterName = "p_nkiloinslimsus"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsus.xdescinslimsus IsNot Nothing Then
	param17.Value = aipinslimsus.xdescinslimsus
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsus"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsus.iestatinslimsus IsNot Nothing Then
	param18.Value = aipinslimsus.iestatinslimsus
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsus"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsus.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsus output,@p_idaipinsenc,@p_nfactinslimsus,@p_irepuinslimsus,@p_imobrinslimsus,@p_xnomaseginslimsus,@p_idaipmanveh,@p_xsucuinslimsus,@p_nkiloinslimsus,@p_xdescinslimsus,@p_iestatinslimsus,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinslimsus(idaipinslimsus as decimal) as respopera
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
	param8.Value = idaipinslimsus
	param8.ParameterName = "p_idaipinslimsus"
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
	param10.ParameterName = "p_nfactinslimsus"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = 0
	param11.ParameterName = "p_irepuinslimsus"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = 0
	param12.ParameterName = "p_imobrinslimsus"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	param13.Value = "
	param13.ParameterName = "p_xnomaseginslimsus"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = 0
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	param15.Value = "
	param15.ParameterName = "p_xsucuinslimsus"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = 0
	param16.ParameterName = "p_nkiloinslimsus"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	param17.Value = "
	param17.ParameterName = "p_xdescinslimsus"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	param18.Value = "
	param18.ParameterName = "p_iestatinslimsus"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsus output,@p_idaipinsenc,@p_nfactinslimsus,@p_irepuinslimsus,@p_imobrinslimsus,@p_xnomaseginslimsus,@p_idaipmanveh,@p_xsucuinslimsus,@p_nkiloinslimsus,@p_xdescinslimsus,@p_iestatinslimsus,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function actaipinslimsus(aipinslimsus as aipinslimsus) as respopera
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
	param8.Value = aipinslimsus.idaipinslimsus
	param8.ParameterName = "p_idaipinslimsus"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsus.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsus.nfactinslimsus
	param10.ParameterName = "p_nfactinslimsus"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsus.irepuinslimsus
	param11.ParameterName = "p_irepuinslimsus"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsus.imobrinslimsus
	param12.ParameterName = "p_imobrinslimsus"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsus.xnomaseginslimsus IsNot Nothing Then
	param13.Value = aipinslimsus.xnomaseginslimsus
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsus"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsus.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsus.xsucuinslimsus IsNot Nothing Then
	param15.Value = aipinslimsus.xsucuinslimsus
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsus"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsus.nkiloinslimsus
	param16.ParameterName = "p_nkiloinslimsus"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsus.xdescinslimsus IsNot Nothing Then
	param17.Value = aipinslimsus.xdescinslimsus
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsus"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsus.iestatinslimsus IsNot Nothing Then
	param18.Value = aipinslimsus.iestatinslimsus
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsus"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsus.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsus output,@p_idaipinsenc,@p_nfactinslimsus,@p_irepuinslimsus,@p_imobrinslimsus,@p_xnomaseginslimsus,@p_idaipmanveh,@p_xsucuinslimsus,@p_nkiloinslimsus,@p_xdescinslimsus,@p_iestatinslimsus,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function desaipinslimsus(aipinslimsus as aipinslimsus) as respopera
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
	param8.Value = aipinslimsus.idaipinslimsus
	param8.ParameterName = "p_idaipinslimsus"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinslimsus.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinslimsus.nfactinslimsus
	param10.ParameterName = "p_nfactinslimsus"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinslimsus.irepuinslimsus
	param11.ParameterName = "p_irepuinslimsus"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinslimsus.imobrinslimsus
	param12.ParameterName = "p_imobrinslimsus"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinslimsus.xnomaseginslimsus IsNot Nothing Then
	param13.Value = aipinslimsus.xnomaseginslimsus
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginslimsus"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinslimsus.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinslimsus.xsucuinslimsus IsNot Nothing Then
	param15.Value = aipinslimsus.xsucuinslimsus
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinslimsus"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinslimsus.nkiloinslimsus
	param16.ParameterName = "p_nkiloinslimsus"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinslimsus.xdescinslimsus IsNot Nothing Then
	param17.Value = aipinslimsus.xdescinslimsus
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinslimsus"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinslimsus.iestatinslimsus IsNot Nothing Then
	param18.Value = aipinslimsus.iestatinslimsus
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinslimsus"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinslimsus.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinslimsus @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinslimsus output,@p_idaipinsenc,@p_nfactinslimsus,@p_irepuinslimsus,@p_imobrinslimsus,@p_xnomaseginslimsus,@p_idaipmanveh,@p_xsucuinslimsus,@p_nkiloinslimsus,@p_xdescinslimsus,@p_iestatinslimsus,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
