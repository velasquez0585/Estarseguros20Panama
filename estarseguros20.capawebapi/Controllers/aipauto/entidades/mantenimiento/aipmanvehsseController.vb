Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmanvehsseController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmanvehssexid(idaipmanvehsse As Decimal) As aipmanvehsse
		Dim aipmanvehsse As aipmanvehsse = (From p In _db.aipmanvehsse
										Where p.idaipmanvehsse = idaipmanvehsse
										Select p).SingleOrDefault
		Return aipmanvehsse
	End Function

	<HttpPost()> _
	Public Function selaipmanvehsse() As List(Of aipmanvehsse)
            Dim lista_aipmanvehsse As List(Of aipmanvehsse) = (From p In _db.aipmanvehsse
                                                               Where p.idaipmanvehsse > 0
                                                        Select p).ToList
		'
		Return lista_aipmanvehsse
	End Function

<HttpPost()> _
	Public Function selaipmanvehssexwheredinamicopag(petiaipmanvehssepaglist as petiaipmanvehssepaglist) as respaipmanvehssepaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmanvehssepaglist.aipmanvehsse.idaipmanvehsse <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehsse=")
				sb.Append(valor_entero(petiaipmanvehssepaglist.aipmanvehsse.idaipmanvehsse))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehsse=")
				sb.Append(valor_entero(petiaipmanvehssepaglist.aipmanvehsse.idaipmanvehsse))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehssepaglist.aipmanvehsse.xnommanvehsse <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehsse='")
				sb.Append(petiaipmanvehssepaglist.aipmanvehsse.xnommanvehsse)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehsse='")
				sb.Append(petiaipmanvehssepaglist.aipmanvehsse.xnommanvehsse)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehssepaglist.aipmanvehsse.xdescmanvehsse <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanvehsse='")
				sb.Append(petiaipmanvehssepaglist.aipmanvehsse.xdescmanvehsse)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanvehsse='")
				sb.Append(petiaipmanvehssepaglist.aipmanvehsse.xdescmanvehsse)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehssepaglist.aipmanvehsse.iestatmanvehsse <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehsse='")
				sb.Append(petiaipmanvehssepaglist.aipmanvehsse.iestatmanvehsse)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehsse='")
				sb.Append(petiaipmanvehssepaglist.aipmanvehsse.iestatmanvehsse)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehssepaglist.aipmanvehsse.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehssepaglist.aipmanvehsse.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehssepaglist.aipmanvehsse.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmanvehssepaglist As New respaipmanvehssepaglist
	respaipmanvehssepaglist.pagaipmanvehsse = petiaipmanvehssepaglist.pagaipmanvehsse
	Dim skip = skip_paginacion(petiaipmanvehssepaglist.pagaipmanvehsse.npagactual, petiaipmanvehssepaglist.pagaipmanvehsse.npagtamano)
	
		If sb.ToString = "" Then
			respaipmanvehssepaglist.lista_aipmanvehsse = _db.aipmanvehsse.OrderBy(petiaipmanvehssepaglist.pagaipmanvehsse.xcamposord & " "  & petiaipmanvehssepaglist.pagaipmanvehsse.idirord).Skip(skip).Take(petiaipmanvehssepaglist.pagaipmanvehsse.npagtamano).ToList
		Else
			respaipmanvehssepaglist.lista_aipmanvehsse = _db.aipmanvehsse.Where(sb.ToString).OrderBy(petiaipmanvehssepaglist.pagaipmanvehsse.xcamposord & " "  & petiaipmanvehssepaglist.pagaipmanvehsse.idirord).Skip(skip).Take(petiaipmanvehssepaglist.pagaipmanvehsse.npagtamano).ToList
		End If
		'
		If (respaipmanvehssepaglist.lista_aipmanvehsse.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmanvehssexwheredinamicocount(sb)
		respaipmanvehssepaglist.pagaipmanvehsse.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanvehssepaglist.pagaipmanvehsse.npagtamano)
		Else
		respaipmanvehssepaglist.pagaipmanvehsse.npagcantidad = 0
		respaipmanvehssepaglist.pagaipmanvehsse.npagactual = 0
		End If
	
		Return respaipmanvehssepaglist
	End Function

	Public Function selaipmanvehssexwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmanvehsse.count
	Else
	Return _db.aipmanvehsse.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmanvehsse(aipmanvehsse as aipmanvehsse) as respopera
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
	param8.ParameterName = "p_idaipmanvehsse"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehsse.xnommanvehsse IsNot Nothing Then
	param9.Value = aipmanvehsse.xnommanvehsse
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehsse"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehsse.xdescmanvehsse IsNot Nothing Then
	param10.Value = aipmanvehsse.xdescmanvehsse
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehsse"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmanvehsse.iestatmanvehsse IsNot Nothing Then
	param11.Value = aipmanvehsse.iestatmanvehsse
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehsse"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehsse @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehsse output,@p_xnommanvehsse,@p_xdescmanvehsse,@p_iestatmanvehsse,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function modaipmanvehsse(aipmanvehsse as aipmanvehsse) as respopera
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
	param8.Value = aipmanvehsse.idaipmanvehsse
	param8.ParameterName = "p_idaipmanvehsse"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehsse.xnommanvehsse IsNot Nothing Then
	param9.Value = aipmanvehsse.xnommanvehsse
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehsse"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehsse.xdescmanvehsse IsNot Nothing Then
	param10.Value = aipmanvehsse.xdescmanvehsse
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehsse"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmanvehsse.iestatmanvehsse IsNot Nothing Then
	param11.Value = aipmanvehsse.iestatmanvehsse
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehsse"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehsse.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehsse @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehsse output,@p_xnommanvehsse,@p_xdescmanvehsse,@p_iestatmanvehsse,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipmanvehsse(aipmanvehsse as aipmanvehsse) as respopera
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
	param8.Value = aipmanvehsse.idaipmanvehsse
	param8.ParameterName = "p_idaipmanvehsse"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehsse.xnommanvehsse IsNot Nothing Then
	param9.Value = aipmanvehsse.xnommanvehsse
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehsse"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehsse.xdescmanvehsse IsNot Nothing Then
	param10.Value = aipmanvehsse.xdescmanvehsse
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehsse"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmanvehsse.iestatmanvehsse IsNot Nothing Then
	param11.Value = aipmanvehsse.iestatmanvehsse
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehsse"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehsse.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehsse @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehsse output,@p_xnommanvehsse,@p_xdescmanvehsse,@p_iestatmanvehsse,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function eliaipmanvehsse(idaipmanvehsse as decimal) as respopera
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
	param8.Value = idaipmanvehsse
	param8.ParameterName = "p_idaipmanvehsse"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	param9.Value = "
	param9.ParameterName = "p_xnommanvehsse"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	param10.Value = "
	param10.ParameterName = "p_xdescmanvehsse"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	param11.Value = "
	param11.ParameterName = "p_iestatmanvehsse"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = 0
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehsse @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehsse output,@p_xnommanvehsse,@p_xdescmanvehsse,@p_iestatmanvehsse,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function actaipmanvehsse(aipmanvehsse as aipmanvehsse) as respopera
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
	param8.Value = aipmanvehsse.idaipmanvehsse
	param8.ParameterName = "p_idaipmanvehsse"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehsse.xnommanvehsse IsNot Nothing Then
	param9.Value = aipmanvehsse.xnommanvehsse
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehsse"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehsse.xdescmanvehsse IsNot Nothing Then
	param10.Value = aipmanvehsse.xdescmanvehsse
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehsse"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmanvehsse.iestatmanvehsse IsNot Nothing Then
	param11.Value = aipmanvehsse.iestatmanvehsse
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehsse"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehsse.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehsse @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehsse output,@p_xnommanvehsse,@p_xdescmanvehsse,@p_iestatmanvehsse,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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
	Public Function desaipmanvehsse(aipmanvehsse as aipmanvehsse) as respopera
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
	param8.Value = aipmanvehsse.idaipmanvehsse
	param8.ParameterName = "p_idaipmanvehsse"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.varchar
	param9.Size = 50
	If aipmanvehsse.xnommanvehsse IsNot Nothing Then
	param9.Value = aipmanvehsse.xnommanvehsse
	else
	param9.Value = ""
	end if
	param9.ParameterName = "p_xnommanvehsse"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 500
	If aipmanvehsse.xdescmanvehsse IsNot Nothing Then
	param10.Value = aipmanvehsse.xdescmanvehsse
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xdescmanvehsse"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 50
	If aipmanvehsse.iestatmanvehsse IsNot Nothing Then
	param11.Value = aipmanvehsse.iestatmanvehsse
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_iestatmanvehsse"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.decimal
	param12.Precision = 18
	param12.Scale = 0
	param12.Value = aipmanvehsse.idseglogreg
	param12.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehsse @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehsse output,@p_xnommanvehsse,@p_xdescmanvehsse,@p_iestatmanvehsse,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12)
	
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

        'metodos no automaticos
        <HttpPost()> _
        Public Function selaipmanvehsseactivos() As List(Of aipmanvehsse)
            Dim lista_aipmanvehsse As List(Of aipmanvehsse) = (From p In _db.aipmanvehsse
                                                               Where p.idaipmanvehsse > 0 And p.iestatmanvehsse = "ACTIVO"
                                                               Order By p.xnommanvehsse
                                                        Select p).ToList

            Dim aipmanvehsse As New aipmanvehsse
            aipmanvehsse.idaipmanvehsse = 0
            aipmanvehsse.idseglogreg = 0
            aipmanvehsse.iestatmanvehsse = ""
            aipmanvehsse.xdescmanvehsse = ""
            aipmanvehsse.xnommanvehsse = "SELECCIONE..."
            lista_aipmanvehsse.Insert(0, aipmanvehsse)

            '
            Return lista_aipmanvehsse
        End Function
End Class
End Namespace
