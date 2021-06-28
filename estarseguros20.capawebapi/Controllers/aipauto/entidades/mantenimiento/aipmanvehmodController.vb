Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.mantenimiento
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipmanvehmodController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipmanvehmodxid(idaipmanvehmod As Decimal) As aipmanvehmod
		Dim aipmanvehmod As aipmanvehmod = (From p In _db.aipmanvehmod
										Where p.idaipmanvehmod = idaipmanvehmod
										Select p).SingleOrDefault
		Return aipmanvehmod
	End Function

	<HttpPost()> _
	Public Function selaipmanvehmod() As List(Of aipmanvehmod)
            Dim lista_aipmanvehmod As List(Of aipmanvehmod) = (From p In _db.aipmanvehmod
                                                               Where p.idaipmanvehmod > 0
                                                        Select p).ToList
		'
		Return lista_aipmanvehmod
	End Function

<HttpPost()> _
	Public Function selaipmanvehmodxwheredinamicopag(petiaipmanvehmodpaglist as petiaipmanvehmodpaglist) as respaipmanvehmodpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipmanvehmodpaglist.aipmanvehmod.idaipmanvehmod <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmod=")
				sb.Append(valor_entero(petiaipmanvehmodpaglist.aipmanvehmod.idaipmanvehmod))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmod=")
				sb.Append(valor_entero(petiaipmanvehmodpaglist.aipmanvehmod.idaipmanvehmod))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmodpaglist.aipmanvehmod.idaipmanvehmar <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanvehmar=")
				sb.Append(valor_entero(petiaipmanvehmodpaglist.aipmanvehmod.idaipmanvehmar))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanvehmar=")
				sb.Append(valor_entero(petiaipmanvehmodpaglist.aipmanvehmod.idaipmanvehmar))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmodpaglist.aipmanvehmod.xnommanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnommanvehmod='")
				sb.Append(petiaipmanvehmodpaglist.aipmanvehmod.xnommanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnommanvehmod='")
				sb.Append(petiaipmanvehmodpaglist.aipmanvehmod.xnommanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmodpaglist.aipmanvehmod.xdescmanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescmanvehmod='")
				sb.Append(petiaipmanvehmodpaglist.aipmanvehmod.xdescmanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescmanvehmod='")
				sb.Append(petiaipmanvehmodpaglist.aipmanvehmod.xdescmanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmodpaglist.aipmanvehmod.iestatmanvehmod <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatmanvehmod='")
				sb.Append(petiaipmanvehmodpaglist.aipmanvehmod.iestatmanvehmod)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatmanvehmod='")
				sb.Append(petiaipmanvehmodpaglist.aipmanvehmod.iestatmanvehmod)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipmanvehmodpaglist.aipmanvehmod.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehmodpaglist.aipmanvehmod.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipmanvehmodpaglist.aipmanvehmod.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipmanvehmodpaglist As New respaipmanvehmodpaglist
	respaipmanvehmodpaglist.pagaipmanvehmod = petiaipmanvehmodpaglist.pagaipmanvehmod
	Dim skip = skip_paginacion(petiaipmanvehmodpaglist.pagaipmanvehmod.npagactual, petiaipmanvehmodpaglist.pagaipmanvehmod.npagtamano)
	
		If sb.ToString = "" Then
			respaipmanvehmodpaglist.lista_aipmanvehmod = _db.aipmanvehmod.OrderBy(petiaipmanvehmodpaglist.pagaipmanvehmod.xcamposord & " "  & petiaipmanvehmodpaglist.pagaipmanvehmod.idirord).Skip(skip).Take(petiaipmanvehmodpaglist.pagaipmanvehmod.npagtamano).ToList
		Else
			respaipmanvehmodpaglist.lista_aipmanvehmod = _db.aipmanvehmod.Where(sb.ToString).OrderBy(petiaipmanvehmodpaglist.pagaipmanvehmod.xcamposord & " "  & petiaipmanvehmodpaglist.pagaipmanvehmod.idirord).Skip(skip).Take(petiaipmanvehmodpaglist.pagaipmanvehmod.npagtamano).ToList
		End If
		'
		If (respaipmanvehmodpaglist.lista_aipmanvehmod.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipmanvehmodxwheredinamicocount(sb)
		respaipmanvehmodpaglist.pagaipmanvehmod.npagcantidad = cantidad_paginas(cant_entero_reg, respaipmanvehmodpaglist.pagaipmanvehmod.npagtamano)
		Else
		respaipmanvehmodpaglist.pagaipmanvehmod.npagcantidad = 0
		respaipmanvehmodpaglist.pagaipmanvehmod.npagactual = 0
		End If
	
		Return respaipmanvehmodpaglist
	End Function

	Public Function selaipmanvehmodxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipmanvehmod.count
	Else
	Return _db.aipmanvehmod.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipmanvehmod(aipmanvehmod as aipmanvehmod) as respopera
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
	param8.ParameterName = "p_idaipmanvehmod"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehmod.idaipmanvehmar
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehmod.xnommanvehmod IsNot Nothing Then
	param10.Value = aipmanvehmod.xnommanvehmod
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmod.xdescmanvehmod IsNot Nothing Then
	param11.Value = aipmanvehmod.xdescmanvehmod
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmanvehmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmanvehmod.iestatmanvehmod IsNot Nothing Then
	param12.Value = aipmanvehmod.iestatmanvehmod
	else
                    param12.Value = "ACTIVO"
	end if
	param12.ParameterName = "p_iestatmanvehmod"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = 0
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmod @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmod output,@p_idaipmanvehmar,@p_xnommanvehmod,@p_xdescmanvehmod,@p_iestatmanvehmod,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function modaipmanvehmod(aipmanvehmod as aipmanvehmod) as respopera
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
	param8.Value = aipmanvehmod.idaipmanvehmod
	param8.ParameterName = "p_idaipmanvehmod"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehmod.idaipmanvehmar
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehmod.xnommanvehmod IsNot Nothing Then
	param10.Value = aipmanvehmod.xnommanvehmod
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmod.xdescmanvehmod IsNot Nothing Then
	param11.Value = aipmanvehmod.xdescmanvehmod
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmanvehmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmanvehmod.iestatmanvehmod IsNot Nothing Then
	param12.Value = aipmanvehmod.iestatmanvehmod
	else
                    param12.Value = "ACTIVO"
	end if
	param12.ParameterName = "p_iestatmanvehmod"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmanvehmod.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmod @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmod output,@p_idaipmanvehmar,@p_xnommanvehmod,@p_xdescmanvehmod,@p_iestatmanvehmod,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function eliaipmanvehmod(aipmanvehmod as aipmanvehmod) as respopera
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
	param8.Value = aipmanvehmod.idaipmanvehmod
	param8.ParameterName = "p_idaipmanvehmod"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehmod.idaipmanvehmar
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehmod.xnommanvehmod IsNot Nothing Then
	param10.Value = aipmanvehmod.xnommanvehmod
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmod.xdescmanvehmod IsNot Nothing Then
	param11.Value = aipmanvehmod.xdescmanvehmod
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmanvehmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmanvehmod.iestatmanvehmod IsNot Nothing Then
	param12.Value = aipmanvehmod.iestatmanvehmod
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmanvehmod"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmanvehmod.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmod @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmod output,@p_idaipmanvehmar,@p_xnommanvehmod,@p_xdescmanvehmod,@p_iestatmanvehmod,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function eliaipmanvehmod(idaipmanvehmod as decimal) as respopera
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
	param8.Value = idaipmanvehmod
	param8.ParameterName = "p_idaipmanvehmod"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = 0
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	param10.Value = "
	param10.ParameterName = "p_xnommanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	param11.Value = "
	param11.ParameterName = "p_xdescmanvehmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	param12.Value = "
	param12.ParameterName = "p_iestatmanvehmod"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = 0
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmod @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmod output,@p_idaipmanvehmar,@p_xnommanvehmod,@p_xdescmanvehmod,@p_iestatmanvehmod,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function actaipmanvehmod(aipmanvehmod as aipmanvehmod) as respopera
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
	param8.Value = aipmanvehmod.idaipmanvehmod
	param8.ParameterName = "p_idaipmanvehmod"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehmod.idaipmanvehmar
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehmod.xnommanvehmod IsNot Nothing Then
	param10.Value = aipmanvehmod.xnommanvehmod
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmod.xdescmanvehmod IsNot Nothing Then
	param11.Value = aipmanvehmod.xdescmanvehmod
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmanvehmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmanvehmod.iestatmanvehmod IsNot Nothing Then
	param12.Value = aipmanvehmod.iestatmanvehmod
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmanvehmod"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmanvehmod.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmod @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmod output,@p_idaipmanvehmar,@p_xnommanvehmod,@p_xdescmanvehmod,@p_iestatmanvehmod,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
	Public Function desaipmanvehmod(aipmanvehmod as aipmanvehmod) as respopera
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
	param8.Value = aipmanvehmod.idaipmanvehmod
	param8.ParameterName = "p_idaipmanvehmod"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipmanvehmod.idaipmanvehmar
	param9.ParameterName = "p_idaipmanvehmar"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.varchar
	param10.Size = 50
	If aipmanvehmod.xnommanvehmod IsNot Nothing Then
	param10.Value = aipmanvehmod.xnommanvehmod
	else
	param10.Value = ""
	end if
	param10.ParameterName = "p_xnommanvehmod"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 20
	If aipmanvehmod.xdescmanvehmod IsNot Nothing Then
	param11.Value = aipmanvehmod.xdescmanvehmod
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xdescmanvehmod"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.varchar
	param12.Size = 20
	If aipmanvehmod.iestatmanvehmod IsNot Nothing Then
	param12.Value = aipmanvehmod.iestatmanvehmod
	else
	param12.Value = ""
	end if
	param12.ParameterName = "p_iestatmanvehmod"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipmanvehmod.idseglogreg
	param13.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipmanvehmod @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipmanvehmod output,@p_idaipmanvehmar,@p_xnommanvehmod,@p_xdescmanvehmod,@p_iestatmanvehmod,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13)
	
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
        Public Function selaipmanvehmodactivosxidmarca(idaipmanvehmar As Decimal) As List(Of aipmanvehmod)
            Dim lista_aipmanvehmod As List(Of aipmanvehmod) = (From p In _db.aipmanvehmod
                                                               Where p.idaipmanvehmod > 0 And p.idaipmanvehmar = idaipmanvehmar And p.iestatmanvehmod = "ACTIVO" Or p.iestatmanvehmod = "ACTIVA"
                                                               Order By p.xnommanvehmod
                                                        Select p).ToList

            Dim aipmanvehmod As New aipmanvehmod
            aipmanvehmod.idaipmanvehmod = 0
            aipmanvehmod.idseglogreg = 0
            aipmanvehmod.iestatmanvehmod = ""
            aipmanvehmod.xdescmanvehmod = ""
            aipmanvehmod.xnommanvehmod = "SELECCIONE..."
            lista_aipmanvehmod.Insert(0, aipmanvehmod)
            '
            Return lista_aipmanvehmod
        End Function

        'metodos no automaticos
        <HttpPost()> _
        Public Function selaipmanvehmodactivos() As List(Of aipmanvehmod)
            Dim lista_aipmanvehmod As List(Of aipmanvehmod) = (From p In _db.aipmanvehmod
                                                               Where p.idaipmanvehmod > 0 And p.iestatmanvehmod = "ACTIVO"
                                                                Order By p.xnommanvehmod
                                                        Select p).ToList

            Dim aipmanvehmod As New aipmanvehmod
            aipmanvehmod.idaipmanvehmod = 0
            aipmanvehmod.idseglogreg = 0
            aipmanvehmod.iestatmanvehmod = ""
            aipmanvehmod.xdescmanvehmod = ""
            aipmanvehmod.xnommanvehmod = "SELECCIONE..."
            lista_aipmanvehmod.Insert(0, aipmanvehmod)

            '
            Return lista_aipmanvehmod
        End Function


        <HttpPost()> _
        Public Function selcomboaipmanvehmod() As List(Of aipmanvehmod)
            Dim lista_aipmanvehmod As List(Of aipmanvehmod) = (From p In _db.aipmanvehmod
                                                               Where p.idaipmanvehmod > 0
                                                                Order By p.xnommanvehmod
                                                        Select p).ToList

            Dim aipmanvehmod As New aipmanvehmod
            aipmanvehmod.idaipmanvehmar = 0
            aipmanvehmod.idaipmanvehmod = 0
            aipmanvehmod.idseglogreg = 0
            aipmanvehmod.iestatmanvehmod = ""
            aipmanvehmod.xdescmanvehmod = ""
            aipmanvehmod.xnommanvehmod = "SELECCIONE..."
            lista_aipmanvehmod.Insert(0, aipmanvehmod)

            '
            Return lista_aipmanvehmod
        End Function


        <HttpPost()> _
        Public Function selcomboaipmanvehmodxidaipmanvehmar(idaipmanvehmar As Decimal) As List(Of aipmanvehmod)
            Dim lista_aipmanvehmod As List(Of aipmanvehmod) = (From p In _db.aipmanvehmod
                                                               Where p.idaipmanvehmod > 0 And p.idaipmanvehmar = idaipmanvehmar
                                                                Order By p.xnommanvehmod
                                                        Select p).ToList

            Dim aipmanvehmod As New aipmanvehmod
            aipmanvehmod.idaipmanvehmar = 0
            aipmanvehmod.idaipmanvehmod = 0
            aipmanvehmod.idseglogreg = 0
            aipmanvehmod.iestatmanvehmod = ""
            aipmanvehmod.xdescmanvehmod = ""
            aipmanvehmod.xnommanvehmod = "SELECCIONE..."
            lista_aipmanvehmod.Insert(0, aipmanvehmod)

            '
            Return lista_aipmanvehmod
        End Function
End Class
End Namespace
