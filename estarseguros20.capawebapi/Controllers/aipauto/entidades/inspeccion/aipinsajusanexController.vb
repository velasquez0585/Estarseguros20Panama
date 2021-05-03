Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsajusanexController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsajusanexxid(idaipinsajusanex As Decimal) As aipinsajusanex
		Dim aipinsajusanex As aipinsajusanex = (From p In _db.aipinsajusanex
										Where p.idaipinsajusanex = idaipinsajusanex
										Select p).SingleOrDefault
		Return aipinsajusanex
	End Function

        <HttpPost()> _
        Public Function selaipinsajusanex() As List(Of aipinsajusanex)
            Dim lista_aipinsajusanex As List(Of aipinsajusanex) = (From p In _db.aipinsajusanex
                                                        Select p).ToList
            '
            Return lista_aipinsajusanex
        End Function

<HttpPost()> _
	Public Function selaipinsajusanexxwheredinamicopag(petiaipinsajusanexpaglist as petiaipinsajusanexpaglist) as respaipinsajusanexpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsajusanexpaglist.aipinsajusanex.idaipinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idaipinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idaipinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.isininsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.isininsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.isininsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.isininsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.isininsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.irecupinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.irecupinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.irecupinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.irecupinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.irecupinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.itercinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.itercinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.itercinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.itercinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.itercinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.xnomaseginsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomaseginsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.xnomaseginsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomaseginsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.xnomaseginsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.xsucuinsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.xsucuinsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.xsucuinsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.nkiloinsajusanex <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.nkiloinsajusanex))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinsajusanex=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.nkiloinsajusanex))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.xdescinsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.xdescinsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.xdescinsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.iestatinsajusanex <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.iestatinsajusanex)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsajusanex='")
				sb.Append(petiaipinsajusanexpaglist.aipinsajusanex.iestatinsajusanex)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsajusanexpaglist.aipinsajusanex.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsajusanexpaglist.aipinsajusanex.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsajusanexpaglist As New respaipinsajusanexpaglist
	respaipinsajusanexpaglist.pagaipinsajusanex = petiaipinsajusanexpaglist.pagaipinsajusanex
	Dim skip = skip_paginacion(petiaipinsajusanexpaglist.pagaipinsajusanex.npagactual, petiaipinsajusanexpaglist.pagaipinsajusanex.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsajusanexpaglist.lista_aipinsajusanex = _db.aipinsajusanex.OrderBy(petiaipinsajusanexpaglist.pagaipinsajusanex.xcamposord & " "  & petiaipinsajusanexpaglist.pagaipinsajusanex.idirord).Skip(skip).Take(petiaipinsajusanexpaglist.pagaipinsajusanex.npagtamano).ToList
		Else
			respaipinsajusanexpaglist.lista_aipinsajusanex = _db.aipinsajusanex.Where(sb.ToString).OrderBy(petiaipinsajusanexpaglist.pagaipinsajusanex.xcamposord & " "  & petiaipinsajusanexpaglist.pagaipinsajusanex.idirord).Skip(skip).Take(petiaipinsajusanexpaglist.pagaipinsajusanex.npagtamano).ToList
		End If
		'
		If (respaipinsajusanexpaglist.lista_aipinsajusanex.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsajusanexxwheredinamicocount(sb)
		respaipinsajusanexpaglist.pagaipinsajusanex.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsajusanexpaglist.pagaipinsajusanex.npagtamano)
		Else
		respaipinsajusanexpaglist.pagaipinsajusanex.npagcantidad = 0
		respaipinsajusanexpaglist.pagaipinsajusanex.npagactual = 0
		End If
	
		Return respaipinsajusanexpaglist
	End Function

	Public Function selaipinsajusanexxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsajusanex.count
	Else
	Return _db.aipinsajusanex.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsajusanex(aipinsajusanex as aipinsajusanex) as respopera
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
	param8.ParameterName = "p_idaipinsajusanex"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanex.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajusanex.isininsajusanex
	param10.ParameterName = "p_isininsajusanex"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajusanex.irecupinsajusanex
	param11.ParameterName = "p_irecupinsajusanex"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajusanex.itercinsajusanex
	param12.ParameterName = "p_itercinsajusanex"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajusanex.xnomaseginsajusanex IsNot Nothing Then
	param13.Value = aipinsajusanex.xnomaseginsajusanex
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajusanex"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajusanex.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajusanex.xsucuinsajusanex IsNot Nothing Then
	param15.Value = aipinsajusanex.xsucuinsajusanex
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajusanex"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajusanex.nkiloinsajusanex
	param16.ParameterName = "p_nkiloinsajusanex"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajusanex.xdescinsajusanex IsNot Nothing Then
	param17.Value = aipinsajusanex.xdescinsajusanex
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajusanex"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajusanex.iestatinsajusanex IsNot Nothing Then
	param18.Value = aipinsajusanex.iestatinsajusanex
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajusanex"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanex @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanex output,@p_idaipinsenc,@p_isininsajusanex,@p_irecupinsajusanex,@p_itercinsajusanex,@p_xnomaseginsajusanex,@p_idaipmanveh,@p_xsucuinsajusanex,@p_nkiloinsajusanex,@p_xdescinsajusanex,@p_iestatinsajusanex,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function modaipinsajusanex(aipinsajusanex as aipinsajusanex) as respopera
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
	param8.Value = aipinsajusanex.idaipinsajusanex
	param8.ParameterName = "p_idaipinsajusanex"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanex.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajusanex.isininsajusanex
	param10.ParameterName = "p_isininsajusanex"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajusanex.irecupinsajusanex
	param11.ParameterName = "p_irecupinsajusanex"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajusanex.itercinsajusanex
	param12.ParameterName = "p_itercinsajusanex"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajusanex.xnomaseginsajusanex IsNot Nothing Then
	param13.Value = aipinsajusanex.xnomaseginsajusanex
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajusanex"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajusanex.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajusanex.xsucuinsajusanex IsNot Nothing Then
	param15.Value = aipinsajusanex.xsucuinsajusanex
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajusanex"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajusanex.nkiloinsajusanex
	param16.ParameterName = "p_nkiloinsajusanex"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajusanex.xdescinsajusanex IsNot Nothing Then
	param17.Value = aipinsajusanex.xdescinsajusanex
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajusanex"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajusanex.iestatinsajusanex IsNot Nothing Then
	param18.Value = aipinsajusanex.iestatinsajusanex
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajusanex"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajusanex.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanex @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanex output,@p_idaipinsenc,@p_isininsajusanex,@p_irecupinsajusanex,@p_itercinsajusanex,@p_xnomaseginsajusanex,@p_idaipmanveh,@p_xsucuinsajusanex,@p_nkiloinsajusanex,@p_xdescinsajusanex,@p_iestatinsajusanex,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinsajusanex(aipinsajusanex as aipinsajusanex) as respopera
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
	param8.Value = aipinsajusanex.idaipinsajusanex
	param8.ParameterName = "p_idaipinsajusanex"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanex.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajusanex.isininsajusanex
	param10.ParameterName = "p_isininsajusanex"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajusanex.irecupinsajusanex
	param11.ParameterName = "p_irecupinsajusanex"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajusanex.itercinsajusanex
	param12.ParameterName = "p_itercinsajusanex"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajusanex.xnomaseginsajusanex IsNot Nothing Then
	param13.Value = aipinsajusanex.xnomaseginsajusanex
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajusanex"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajusanex.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajusanex.xsucuinsajusanex IsNot Nothing Then
	param15.Value = aipinsajusanex.xsucuinsajusanex
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajusanex"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajusanex.nkiloinsajusanex
	param16.ParameterName = "p_nkiloinsajusanex"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajusanex.xdescinsajusanex IsNot Nothing Then
	param17.Value = aipinsajusanex.xdescinsajusanex
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajusanex"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajusanex.iestatinsajusanex IsNot Nothing Then
	param18.Value = aipinsajusanex.iestatinsajusanex
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajusanex"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajusanex.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanex @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanex output,@p_idaipinsenc,@p_isininsajusanex,@p_irecupinsajusanex,@p_itercinsajusanex,@p_xnomaseginsajusanex,@p_idaipmanveh,@p_xsucuinsajusanex,@p_nkiloinsajusanex,@p_xdescinsajusanex,@p_iestatinsajusanex,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function eliaipinsajusanex(idaipinsajusanex as decimal) as respopera
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
	param8.Value = idaipinsajusanex
	param8.ParameterName = "p_idaipinsajusanex"
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
	param10.ParameterName = "p_isininsajusanex"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = 0
	param11.ParameterName = "p_irecupinsajusanex"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = 0
	param12.ParameterName = "p_itercinsajusanex"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	param13.Value = "
	param13.ParameterName = "p_xnomaseginsajusanex"
	
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
	param15.ParameterName = "p_xsucuinsajusanex"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = 0
	param16.ParameterName = "p_nkiloinsajusanex"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	param17.Value = "
	param17.ParameterName = "p_xdescinsajusanex"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	param18.Value = "
	param18.ParameterName = "p_iestatinsajusanex"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = 0
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanex @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanex output,@p_idaipinsenc,@p_isininsajusanex,@p_irecupinsajusanex,@p_itercinsajusanex,@p_xnomaseginsajusanex,@p_idaipmanveh,@p_xsucuinsajusanex,@p_nkiloinsajusanex,@p_xdescinsajusanex,@p_iestatinsajusanex,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function actaipinsajusanex(aipinsajusanex as aipinsajusanex) as respopera
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
	param8.Value = aipinsajusanex.idaipinsajusanex
	param8.ParameterName = "p_idaipinsajusanex"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanex.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajusanex.isininsajusanex
	param10.ParameterName = "p_isininsajusanex"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajusanex.irecupinsajusanex
	param11.ParameterName = "p_irecupinsajusanex"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajusanex.itercinsajusanex
	param12.ParameterName = "p_itercinsajusanex"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajusanex.xnomaseginsajusanex IsNot Nothing Then
	param13.Value = aipinsajusanex.xnomaseginsajusanex
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajusanex"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajusanex.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajusanex.xsucuinsajusanex IsNot Nothing Then
	param15.Value = aipinsajusanex.xsucuinsajusanex
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajusanex"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajusanex.nkiloinsajusanex
	param16.ParameterName = "p_nkiloinsajusanex"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajusanex.xdescinsajusanex IsNot Nothing Then
	param17.Value = aipinsajusanex.xdescinsajusanex
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajusanex"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajusanex.iestatinsajusanex IsNot Nothing Then
	param18.Value = aipinsajusanex.iestatinsajusanex
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajusanex"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajusanex.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanex @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanex output,@p_idaipinsenc,@p_isininsajusanex,@p_irecupinsajusanex,@p_itercinsajusanex,@p_xnomaseginsajusanex,@p_idaipmanveh,@p_xsucuinsajusanex,@p_nkiloinsajusanex,@p_xdescinsajusanex,@p_iestatinsajusanex,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
	Public Function desaipinsajusanex(aipinsajusanex as aipinsajusanex) as respopera
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
	param8.Value = aipinsajusanex.idaipinsajusanex
	param8.ParameterName = "p_idaipinsajusanex"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsajusanex.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.bit
	param10.Value = aipinsajusanex.isininsajusanex
	param10.ParameterName = "p_isininsajusanex"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.bit
	param11.Value = aipinsajusanex.irecupinsajusanex
	param11.ParameterName = "p_irecupinsajusanex"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.bit
	param12.Value = aipinsajusanex.itercinsajusanex
	param12.ParameterName = "p_itercinsajusanex"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.varchar
	param13.Size = 100
	If aipinsajusanex.xnomaseginsajusanex IsNot Nothing Then
	param13.Value = aipinsajusanex.xnomaseginsajusanex
	else
	param13.Value = ""
	end if
	param13.ParameterName = "p_xnomaseginsajusanex"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsajusanex.idaipmanveh
	param14.ParameterName = "p_idaipmanveh"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 100
	If aipinsajusanex.xsucuinsajusanex IsNot Nothing Then
	param15.Value = aipinsajusanex.xsucuinsajusanex
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xsucuinsajusanex"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.int
	param16.Value = aipinsajusanex.nkiloinsajusanex
	param16.ParameterName = "p_nkiloinsajusanex"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.varchar
	param17.Size = 500
	If aipinsajusanex.xdescinsajusanex IsNot Nothing Then
	param17.Value = aipinsajusanex.xdescinsajusanex
	else
	param17.Value = ""
	end if
	param17.ParameterName = "p_xdescinsajusanex"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.varchar
	param18.Size = 20
	If aipinsajusanex.iestatinsajusanex IsNot Nothing Then
	param18.Value = aipinsajusanex.iestatinsajusanex
	else
	param18.Value = ""
	end if
	param18.ParameterName = "p_iestatinsajusanex"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 0
	param19.Value = aipinsajusanex.idseglogreg
	param19.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsajusanex @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsajusanex output,@p_idaipinsenc,@p_isininsajusanex,@p_irecupinsajusanex,@p_itercinsajusanex,@p_xnomaseginsajusanex,@p_idaipmanveh,@p_xsucuinsajusanex,@p_nkiloinsajusanex,@p_xdescinsajusanex,@p_iestatinsajusanex,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19)
	
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
