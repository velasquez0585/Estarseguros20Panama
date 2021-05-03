Imports System.Net
Imports System.Web.Http
Imports estarseguros20.capawebapi.modelo
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.inspeccion
Imports System.Data.SqlClient
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports funciones.lib.matematica

Namespace aipauto.entidades.controlador
Public Class aipinsrestController
	Inherits ApiController

        'Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais(HttpContext.Current.Request.Headers.GetValues("xnombrepais").FirstOrDefault))
        Dim _db As New dbestarseguros20.config(funciones.obtener_cnxcadenaxpais("venezuela"))

	<HttpPost()> _
	Public Function selaipinsrestxid(idaipinsrest As Decimal) As aipinsrest
		Dim aipinsrest As aipinsrest = (From p In _db.aipinsrest
										Where p.idaipinsrest = idaipinsrest
										Select p).SingleOrDefault
		Return aipinsrest
	End Function

	<HttpPost()> _
	Public Function selaipinsrest() As List(Of aipinsrest)
		Dim lista_aipinsrest As List(Of aipinsrest) = (From p In _db.aipinsrest
													Select p).ToList
		'
		Return lista_aipinsrest
	End Function

<HttpPost()> _
	Public Function selaipinsrestxwheredinamicopag(petiaipinsrestpaglist as petiaipinsrestpaglist) as respaipinsrestpaglist
		Dim sb As New StringBuilder("")
		'
		If petiaipinsrestpaglist.aipinsrest.idaipinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idaipinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idaipinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.idaipinsenc <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idaipinsenc))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipinsenc=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idaipinsenc))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.idaipmanveh <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idaipmanveh))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idaipmanveh=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idaipmanveh))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.xsucuinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xsucuinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xsucuinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xsucuinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xsucuinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.nkiloinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.nkiloinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.nkiloinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.nkiloinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.nkiloinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.idcomunmanestado <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmanestado=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idcomunmanestado))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmanestado=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idcomunmanestado))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.idcomunmanlocalid <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idcomunmanlocalid=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idcomunmanlocalid))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idcomunmanlocalid=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idcomunmanlocalid))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.xdirinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdirinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xdirinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdirinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xdirinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.msumaseginsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.msumaseginsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.msumaseginsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.msumaseginsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.msumaseginsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.msumaseg75insrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.msumaseg75insrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.msumaseg75insrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.msumaseg75insrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.msumaseg75insrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.mvalinminsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mvalinminsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.mvalinminsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mvalinminsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.mvalinminsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.mdanoinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mdanoinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.mdanoinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mdanoinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.mdanoinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.mavalinsrest <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.mavalinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.mavalinsrest))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.mavalinsrest=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.mavalinsrest))
				sb.Append("")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.xnomtalinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomtalinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xnomtalinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomtalinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xnomtalinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.xnomperinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomperinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xnomperinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomperinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xnomperinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.xnomjefperinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xnomjefperinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xnomjefperinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xnomjefperinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xnomjefperinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.xdescinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.xdescinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xdescinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.xdescinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.xdescinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.iestatinsrest <> "" Then
	    If sb.Length = 0 Then
				sb.Append("it.iestatinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.iestatinsrest)
				sb.Append("'")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.iestatinsrest='")
				sb.Append(petiaipinsrestpaglist.aipinsrest.iestatinsrest)
				sb.Append("'")
	        End If
	    End If
	End If
	 '
		If petiaipinsrestpaglist.aipinsrest.idseglogreg <> 0 Then
	    If sb.Length = 0 Then
				sb.Append("it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idseglogreg))
				sb.Append("")
	    Else
	        If sb.Length > 0 Then
				sb.Append(" and it.idseglogreg=")
				sb.Append(valor_entero(petiaipinsrestpaglist.aipinsrest.idseglogreg))
				sb.Append("")
	        End If
	    End If
	End If
	 '
	
	
	Dim respaipinsrestpaglist As New respaipinsrestpaglist
	respaipinsrestpaglist.pagaipinsrest = petiaipinsrestpaglist.pagaipinsrest
	Dim skip = skip_paginacion(petiaipinsrestpaglist.pagaipinsrest.npagactual, petiaipinsrestpaglist.pagaipinsrest.npagtamano)
	
		If sb.ToString = "" Then
			respaipinsrestpaglist.lista_aipinsrest = _db.aipinsrest.OrderBy(petiaipinsrestpaglist.pagaipinsrest.xcamposord & " "  & petiaipinsrestpaglist.pagaipinsrest.idirord).Skip(skip).Take(petiaipinsrestpaglist.pagaipinsrest.npagtamano).ToList
		Else
			respaipinsrestpaglist.lista_aipinsrest = _db.aipinsrest.Where(sb.ToString).OrderBy(petiaipinsrestpaglist.pagaipinsrest.xcamposord & " "  & petiaipinsrestpaglist.pagaipinsrest.idirord).Skip(skip).Take(petiaipinsrestpaglist.pagaipinsrest.npagtamano).ToList
		End If
		'
		If (respaipinsrestpaglist.lista_aipinsrest.Count > 0) Then
		 Dim cant_entero_reg As Integer = 0
		cant_entero_reg = selaipinsrestxwheredinamicocount(sb)
		respaipinsrestpaglist.pagaipinsrest.npagcantidad = cantidad_paginas(cant_entero_reg, respaipinsrestpaglist.pagaipinsrest.npagtamano)
		Else
		respaipinsrestpaglist.pagaipinsrest.npagcantidad = 0
		respaipinsrestpaglist.pagaipinsrest.npagactual = 0
		End If
	
		Return respaipinsrestpaglist
	End Function

	Public Function selaipinsrestxwheredinamicocount(sb As StringBuilder) as  integer
	If sb.ToString = "" Then
	Return _db.aipinsrest.count
	Else
	Return _db.aipinsrest.Where(sb.ToString).Count
	End If
	End Function

	<HttpPost()> _
	Public Function insaipinsrest(aipinsrest as aipinsrest) as respopera
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
	param8.ParameterName = "p_idaipinsrest"
	param8.Direction = ParameterDirection.Output
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsrest.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsrest.idaipmanveh
	param10.ParameterName = "p_idaipmanveh"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 100
	If aipinsrest.xsucuinsrest IsNot Nothing Then
	param11.Value = aipinsrest.xsucuinsrest
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xsucuinsrest"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.int
	param12.Value = aipinsrest.nkiloinsrest
	param12.ParameterName = "p_nkiloinsrest"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipinsrest.idcomunmanestado
	param13.ParameterName = "p_idcomunmanestado"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsrest.idcomunmanlocalid
	param14.ParameterName = "p_idcomunmanlocalid"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipinsrest.xdirinsrest IsNot Nothing Then
	param15.Value = aipinsrest.xdirinsrest
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdirinsrest"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 2
	param16.Value = aipinsrest.msumaseginsrest
	param16.ParameterName = "p_msumaseginsrest"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 2
	param17.Value = aipinsrest.msumaseg75insrest
	param17.ParameterName = "p_msumaseg75insrest"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.decimal
	param18.Precision = 18
	param18.Scale = 2
	param18.Value = aipinsrest.mvalinminsrest
	param18.ParameterName = "p_mvalinminsrest"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 2
	param19.Value = aipinsrest.mdanoinsrest
	param19.ParameterName = "p_mdanoinsrest"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.decimal
	param20.Precision = 18
	param20.Scale = 2
	param20.Value = aipinsrest.mavalinsrest
	param20.ParameterName = "p_mavalinsrest"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.varchar
	param21.Size = 50
	If aipinsrest.xnomtalinsrest IsNot Nothing Then
	param21.Value = aipinsrest.xnomtalinsrest
	else
	param21.Value = ""
	end if
	param21.ParameterName = "p_xnomtalinsrest"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 50
	If aipinsrest.xnomperinsrest IsNot Nothing Then
	param22.Value = aipinsrest.xnomperinsrest
	else
	param22.Value = ""
	end if
	param22.ParameterName = "p_xnomperinsrest"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 50
	If aipinsrest.xnomjefperinsrest IsNot Nothing Then
	param23.Value = aipinsrest.xnomjefperinsrest
	else
	param23.Value = ""
	end if
	param23.ParameterName = "p_xnomjefperinsrest"
	
	Dim param24 As New SqlClient.SqlParameter
	param24.SqlDbType = SqlDbType.varchar
	param24.Size = 500
	If aipinsrest.xdescinsrest IsNot Nothing Then
	param24.Value = aipinsrest.xdescinsrest
	else
	param24.Value = ""
	end if
	param24.ParameterName = "p_xdescinsrest"
	
	Dim param25 As New SqlClient.SqlParameter
	param25.SqlDbType = SqlDbType.varchar
	param25.Size = 20
	If aipinsrest.iestatinsrest IsNot Nothing Then
	param25.Value = aipinsrest.iestatinsrest
	else
	param25.Value = ""
	end if
	param25.ParameterName = "p_iestatinsrest"
	
	Dim param26 As New SqlClient.SqlParameter
	param26.SqlDbType = SqlDbType.decimal
	param26.Precision = 18
	param26.Scale = 0
	param26.Value = 0
	param26.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrest output,@p_idaipinsenc,@p_idaipmanveh,@p_xsucuinsrest,@p_nkiloinsrest,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_xdirinsrest,@p_msumaseginsrest,@p_msumaseg75insrest,@p_mvalinminsrest,@p_mdanoinsrest,@p_mavalinsrest,@p_xnomtalinsrest,@p_xnomperinsrest,@p_xnomjefperinsrest,@p_xdescinsrest,@p_iestatinsrest,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19,param20,param21,param22,param23,param24,param25,param26)
	
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
	Public Function modaipinsrest(aipinsrest as aipinsrest) as respopera
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
	param8.Value = aipinsrest.idaipinsrest
	param8.ParameterName = "p_idaipinsrest"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsrest.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsrest.idaipmanveh
	param10.ParameterName = "p_idaipmanveh"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 100
	If aipinsrest.xsucuinsrest IsNot Nothing Then
	param11.Value = aipinsrest.xsucuinsrest
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xsucuinsrest"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.int
	param12.Value = aipinsrest.nkiloinsrest
	param12.ParameterName = "p_nkiloinsrest"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipinsrest.idcomunmanestado
	param13.ParameterName = "p_idcomunmanestado"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsrest.idcomunmanlocalid
	param14.ParameterName = "p_idcomunmanlocalid"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipinsrest.xdirinsrest IsNot Nothing Then
	param15.Value = aipinsrest.xdirinsrest
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdirinsrest"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 2
	param16.Value = aipinsrest.msumaseginsrest
	param16.ParameterName = "p_msumaseginsrest"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 2
	param17.Value = aipinsrest.msumaseg75insrest
	param17.ParameterName = "p_msumaseg75insrest"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.decimal
	param18.Precision = 18
	param18.Scale = 2
	param18.Value = aipinsrest.mvalinminsrest
	param18.ParameterName = "p_mvalinminsrest"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 2
	param19.Value = aipinsrest.mdanoinsrest
	param19.ParameterName = "p_mdanoinsrest"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.decimal
	param20.Precision = 18
	param20.Scale = 2
	param20.Value = aipinsrest.mavalinsrest
	param20.ParameterName = "p_mavalinsrest"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.varchar
	param21.Size = 50
	If aipinsrest.xnomtalinsrest IsNot Nothing Then
	param21.Value = aipinsrest.xnomtalinsrest
	else
	param21.Value = ""
	end if
	param21.ParameterName = "p_xnomtalinsrest"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 50
	If aipinsrest.xnomperinsrest IsNot Nothing Then
	param22.Value = aipinsrest.xnomperinsrest
	else
	param22.Value = ""
	end if
	param22.ParameterName = "p_xnomperinsrest"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 50
	If aipinsrest.xnomjefperinsrest IsNot Nothing Then
	param23.Value = aipinsrest.xnomjefperinsrest
	else
	param23.Value = ""
	end if
	param23.ParameterName = "p_xnomjefperinsrest"
	
	Dim param24 As New SqlClient.SqlParameter
	param24.SqlDbType = SqlDbType.varchar
	param24.Size = 500
	If aipinsrest.xdescinsrest IsNot Nothing Then
	param24.Value = aipinsrest.xdescinsrest
	else
	param24.Value = ""
	end if
	param24.ParameterName = "p_xdescinsrest"
	
	Dim param25 As New SqlClient.SqlParameter
	param25.SqlDbType = SqlDbType.varchar
	param25.Size = 20
	If aipinsrest.iestatinsrest IsNot Nothing Then
	param25.Value = aipinsrest.iestatinsrest
	else
	param25.Value = ""
	end if
	param25.ParameterName = "p_iestatinsrest"
	
	Dim param26 As New SqlClient.SqlParameter
	param26.SqlDbType = SqlDbType.decimal
	param26.Precision = 18
	param26.Scale = 0
	param26.Value = aipinsrest.idseglogreg
	param26.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrest output,@p_idaipinsenc,@p_idaipmanveh,@p_xsucuinsrest,@p_nkiloinsrest,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_xdirinsrest,@p_msumaseginsrest,@p_msumaseg75insrest,@p_mvalinminsrest,@p_mdanoinsrest,@p_mavalinsrest,@p_xnomtalinsrest,@p_xnomperinsrest,@p_xnomjefperinsrest,@p_xdescinsrest,@p_iestatinsrest,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19,param20,param21,param22,param23,param24,param25,param26)
	
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
	Public Function eliaipinsrest(aipinsrest as aipinsrest) as respopera
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
	param8.Value = aipinsrest.idaipinsrest
	param8.ParameterName = "p_idaipinsrest"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsrest.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsrest.idaipmanveh
	param10.ParameterName = "p_idaipmanveh"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 100
	If aipinsrest.xsucuinsrest IsNot Nothing Then
	param11.Value = aipinsrest.xsucuinsrest
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xsucuinsrest"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.int
	param12.Value = aipinsrest.nkiloinsrest
	param12.ParameterName = "p_nkiloinsrest"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipinsrest.idcomunmanestado
	param13.ParameterName = "p_idcomunmanestado"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsrest.idcomunmanlocalid
	param14.ParameterName = "p_idcomunmanlocalid"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipinsrest.xdirinsrest IsNot Nothing Then
	param15.Value = aipinsrest.xdirinsrest
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdirinsrest"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 2
	param16.Value = aipinsrest.msumaseginsrest
	param16.ParameterName = "p_msumaseginsrest"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 2
	param17.Value = aipinsrest.msumaseg75insrest
	param17.ParameterName = "p_msumaseg75insrest"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.decimal
	param18.Precision = 18
	param18.Scale = 2
	param18.Value = aipinsrest.mvalinminsrest
	param18.ParameterName = "p_mvalinminsrest"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 2
	param19.Value = aipinsrest.mdanoinsrest
	param19.ParameterName = "p_mdanoinsrest"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.decimal
	param20.Precision = 18
	param20.Scale = 2
	param20.Value = aipinsrest.mavalinsrest
	param20.ParameterName = "p_mavalinsrest"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.varchar
	param21.Size = 50
	If aipinsrest.xnomtalinsrest IsNot Nothing Then
	param21.Value = aipinsrest.xnomtalinsrest
	else
	param21.Value = ""
	end if
	param21.ParameterName = "p_xnomtalinsrest"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 50
	If aipinsrest.xnomperinsrest IsNot Nothing Then
	param22.Value = aipinsrest.xnomperinsrest
	else
	param22.Value = ""
	end if
	param22.ParameterName = "p_xnomperinsrest"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 50
	If aipinsrest.xnomjefperinsrest IsNot Nothing Then
	param23.Value = aipinsrest.xnomjefperinsrest
	else
	param23.Value = ""
	end if
	param23.ParameterName = "p_xnomjefperinsrest"
	
	Dim param24 As New SqlClient.SqlParameter
	param24.SqlDbType = SqlDbType.varchar
	param24.Size = 500
	If aipinsrest.xdescinsrest IsNot Nothing Then
	param24.Value = aipinsrest.xdescinsrest
	else
	param24.Value = ""
	end if
	param24.ParameterName = "p_xdescinsrest"
	
	Dim param25 As New SqlClient.SqlParameter
	param25.SqlDbType = SqlDbType.varchar
	param25.Size = 20
	If aipinsrest.iestatinsrest IsNot Nothing Then
	param25.Value = aipinsrest.iestatinsrest
	else
	param25.Value = ""
	end if
	param25.ParameterName = "p_iestatinsrest"
	
	Dim param26 As New SqlClient.SqlParameter
	param26.SqlDbType = SqlDbType.decimal
	param26.Precision = 18
	param26.Scale = 0
	param26.Value = aipinsrest.idseglogreg
	param26.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrest output,@p_idaipinsenc,@p_idaipmanveh,@p_xsucuinsrest,@p_nkiloinsrest,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_xdirinsrest,@p_msumaseginsrest,@p_msumaseg75insrest,@p_mvalinminsrest,@p_mdanoinsrest,@p_mavalinsrest,@p_xnomtalinsrest,@p_xnomperinsrest,@p_xnomjefperinsrest,@p_xdescinsrest,@p_iestatinsrest,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19,param20,param21,param22,param23,param24,param25,param26)
	
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
	Public Function eliaipinsrest(idaipinsrest as decimal) as respopera
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
	param8.Value = idaipinsrest
	param8.ParameterName = "p_idaipinsrest"
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
	param10.ParameterName = "p_idaipmanveh"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 100
	param11.Value = "
	param11.ParameterName = "p_xsucuinsrest"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.int
	param12.Value = 0
	param12.ParameterName = "p_nkiloinsrest"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = 0
	param13.ParameterName = "p_idcomunmanestado"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = 0
	param14.ParameterName = "p_idcomunmanlocalid"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	param15.Value = "
	param15.ParameterName = "p_xdirinsrest"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 2
	param16.Value = 0
	param16.ParameterName = "p_msumaseginsrest"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 2
	param17.Value = 0
	param17.ParameterName = "p_msumaseg75insrest"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.decimal
	param18.Precision = 18
	param18.Scale = 2
	param18.Value = 0
	param18.ParameterName = "p_mvalinminsrest"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 2
	param19.Value = 0
	param19.ParameterName = "p_mdanoinsrest"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.decimal
	param20.Precision = 18
	param20.Scale = 2
	param20.Value = 0
	param20.ParameterName = "p_mavalinsrest"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.varchar
	param21.Size = 50
	param21.Value = "
	param21.ParameterName = "p_xnomtalinsrest"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 50
	param22.Value = "
	param22.ParameterName = "p_xnomperinsrest"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 50
	param23.Value = "
	param23.ParameterName = "p_xnomjefperinsrest"
	
	Dim param24 As New SqlClient.SqlParameter
	param24.SqlDbType = SqlDbType.varchar
	param24.Size = 500
	param24.Value = "
	param24.ParameterName = "p_xdescinsrest"
	
	Dim param25 As New SqlClient.SqlParameter
	param25.SqlDbType = SqlDbType.varchar
	param25.Size = 20
	param25.Value = "
	param25.ParameterName = "p_iestatinsrest"
	
	Dim param26 As New SqlClient.SqlParameter
	param26.SqlDbType = SqlDbType.decimal
	param26.Precision = 18
	param26.Scale = 0
	param26.Value = 0
	param26.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrest output,@p_idaipinsenc,@p_idaipmanveh,@p_xsucuinsrest,@p_nkiloinsrest,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_xdirinsrest,@p_msumaseginsrest,@p_msumaseg75insrest,@p_mvalinminsrest,@p_mdanoinsrest,@p_mavalinsrest,@p_xnomtalinsrest,@p_xnomperinsrest,@p_xnomjefperinsrest,@p_xdescinsrest,@p_iestatinsrest,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19,param20,param21,param22,param23,param24,param25,param26)
	
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
	Public Function actaipinsrest(aipinsrest as aipinsrest) as respopera
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
	param8.Value = aipinsrest.idaipinsrest
	param8.ParameterName = "p_idaipinsrest"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsrest.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsrest.idaipmanveh
	param10.ParameterName = "p_idaipmanveh"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 100
	If aipinsrest.xsucuinsrest IsNot Nothing Then
	param11.Value = aipinsrest.xsucuinsrest
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xsucuinsrest"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.int
	param12.Value = aipinsrest.nkiloinsrest
	param12.ParameterName = "p_nkiloinsrest"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipinsrest.idcomunmanestado
	param13.ParameterName = "p_idcomunmanestado"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsrest.idcomunmanlocalid
	param14.ParameterName = "p_idcomunmanlocalid"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipinsrest.xdirinsrest IsNot Nothing Then
	param15.Value = aipinsrest.xdirinsrest
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdirinsrest"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 2
	param16.Value = aipinsrest.msumaseginsrest
	param16.ParameterName = "p_msumaseginsrest"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 2
	param17.Value = aipinsrest.msumaseg75insrest
	param17.ParameterName = "p_msumaseg75insrest"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.decimal
	param18.Precision = 18
	param18.Scale = 2
	param18.Value = aipinsrest.mvalinminsrest
	param18.ParameterName = "p_mvalinminsrest"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 2
	param19.Value = aipinsrest.mdanoinsrest
	param19.ParameterName = "p_mdanoinsrest"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.decimal
	param20.Precision = 18
	param20.Scale = 2
	param20.Value = aipinsrest.mavalinsrest
	param20.ParameterName = "p_mavalinsrest"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.varchar
	param21.Size = 50
	If aipinsrest.xnomtalinsrest IsNot Nothing Then
	param21.Value = aipinsrest.xnomtalinsrest
	else
	param21.Value = ""
	end if
	param21.ParameterName = "p_xnomtalinsrest"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 50
	If aipinsrest.xnomperinsrest IsNot Nothing Then
	param22.Value = aipinsrest.xnomperinsrest
	else
	param22.Value = ""
	end if
	param22.ParameterName = "p_xnomperinsrest"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 50
	If aipinsrest.xnomjefperinsrest IsNot Nothing Then
	param23.Value = aipinsrest.xnomjefperinsrest
	else
	param23.Value = ""
	end if
	param23.ParameterName = "p_xnomjefperinsrest"
	
	Dim param24 As New SqlClient.SqlParameter
	param24.SqlDbType = SqlDbType.varchar
	param24.Size = 500
	If aipinsrest.xdescinsrest IsNot Nothing Then
	param24.Value = aipinsrest.xdescinsrest
	else
	param24.Value = ""
	end if
	param24.ParameterName = "p_xdescinsrest"
	
	Dim param25 As New SqlClient.SqlParameter
	param25.SqlDbType = SqlDbType.varchar
	param25.Size = 20
	If aipinsrest.iestatinsrest IsNot Nothing Then
	param25.Value = aipinsrest.iestatinsrest
	else
	param25.Value = ""
	end if
	param25.ParameterName = "p_iestatinsrest"
	
	Dim param26 As New SqlClient.SqlParameter
	param26.SqlDbType = SqlDbType.decimal
	param26.Precision = 18
	param26.Scale = 0
	param26.Value = aipinsrest.idseglogreg
	param26.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrest output,@p_idaipinsenc,@p_idaipmanveh,@p_xsucuinsrest,@p_nkiloinsrest,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_xdirinsrest,@p_msumaseginsrest,@p_msumaseg75insrest,@p_mvalinminsrest,@p_mdanoinsrest,@p_mavalinsrest,@p_xnomtalinsrest,@p_xnomperinsrest,@p_xnomjefperinsrest,@p_xdescinsrest,@p_iestatinsrest,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19,param20,param21,param22,param23,param24,param25,param26)
	
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
	Public Function desaipinsrest(aipinsrest as aipinsrest) as respopera
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
	param8.Value = aipinsrest.idaipinsrest
	param8.ParameterName = "p_idaipinsrest"
	param8.Direction = ParameterDirection.InputOutput
	
	Dim param9 As New SqlClient.SqlParameter
	param9.SqlDbType = SqlDbType.decimal
	param9.Precision = 18
	param9.Scale = 0
	param9.Value = aipinsrest.idaipinsenc
	param9.ParameterName = "p_idaipinsenc"
	
	Dim param10 As New SqlClient.SqlParameter
	param10.SqlDbType = SqlDbType.decimal
	param10.Precision = 18
	param10.Scale = 0
	param10.Value = aipinsrest.idaipmanveh
	param10.ParameterName = "p_idaipmanveh"
	
	Dim param11 As New SqlClient.SqlParameter
	param11.SqlDbType = SqlDbType.varchar
	param11.Size = 100
	If aipinsrest.xsucuinsrest IsNot Nothing Then
	param11.Value = aipinsrest.xsucuinsrest
	else
	param11.Value = ""
	end if
	param11.ParameterName = "p_xsucuinsrest"
	
	Dim param12 As New SqlClient.SqlParameter
	param12.SqlDbType = SqlDbType.int
	param12.Value = aipinsrest.nkiloinsrest
	param12.ParameterName = "p_nkiloinsrest"
	
	Dim param13 As New SqlClient.SqlParameter
	param13.SqlDbType = SqlDbType.decimal
	param13.Precision = 18
	param13.Scale = 0
	param13.Value = aipinsrest.idcomunmanestado
	param13.ParameterName = "p_idcomunmanestado"
	
	Dim param14 As New SqlClient.SqlParameter
	param14.SqlDbType = SqlDbType.decimal
	param14.Precision = 18
	param14.Scale = 0
	param14.Value = aipinsrest.idcomunmanlocalid
	param14.ParameterName = "p_idcomunmanlocalid"
	
	Dim param15 As New SqlClient.SqlParameter
	param15.SqlDbType = SqlDbType.varchar
	param15.Size = 500
	If aipinsrest.xdirinsrest IsNot Nothing Then
	param15.Value = aipinsrest.xdirinsrest
	else
	param15.Value = ""
	end if
	param15.ParameterName = "p_xdirinsrest"
	
	Dim param16 As New SqlClient.SqlParameter
	param16.SqlDbType = SqlDbType.decimal
	param16.Precision = 18
	param16.Scale = 2
	param16.Value = aipinsrest.msumaseginsrest
	param16.ParameterName = "p_msumaseginsrest"
	
	Dim param17 As New SqlClient.SqlParameter
	param17.SqlDbType = SqlDbType.decimal
	param17.Precision = 18
	param17.Scale = 2
	param17.Value = aipinsrest.msumaseg75insrest
	param17.ParameterName = "p_msumaseg75insrest"
	
	Dim param18 As New SqlClient.SqlParameter
	param18.SqlDbType = SqlDbType.decimal
	param18.Precision = 18
	param18.Scale = 2
	param18.Value = aipinsrest.mvalinminsrest
	param18.ParameterName = "p_mvalinminsrest"
	
	Dim param19 As New SqlClient.SqlParameter
	param19.SqlDbType = SqlDbType.decimal
	param19.Precision = 18
	param19.Scale = 2
	param19.Value = aipinsrest.mdanoinsrest
	param19.ParameterName = "p_mdanoinsrest"
	
	Dim param20 As New SqlClient.SqlParameter
	param20.SqlDbType = SqlDbType.decimal
	param20.Precision = 18
	param20.Scale = 2
	param20.Value = aipinsrest.mavalinsrest
	param20.ParameterName = "p_mavalinsrest"
	
	Dim param21 As New SqlClient.SqlParameter
	param21.SqlDbType = SqlDbType.varchar
	param21.Size = 50
	If aipinsrest.xnomtalinsrest IsNot Nothing Then
	param21.Value = aipinsrest.xnomtalinsrest
	else
	param21.Value = ""
	end if
	param21.ParameterName = "p_xnomtalinsrest"
	
	Dim param22 As New SqlClient.SqlParameter
	param22.SqlDbType = SqlDbType.varchar
	param22.Size = 50
	If aipinsrest.xnomperinsrest IsNot Nothing Then
	param22.Value = aipinsrest.xnomperinsrest
	else
	param22.Value = ""
	end if
	param22.ParameterName = "p_xnomperinsrest"
	
	Dim param23 As New SqlClient.SqlParameter
	param23.SqlDbType = SqlDbType.varchar
	param23.Size = 50
	If aipinsrest.xnomjefperinsrest IsNot Nothing Then
	param23.Value = aipinsrest.xnomjefperinsrest
	else
	param23.Value = ""
	end if
	param23.ParameterName = "p_xnomjefperinsrest"
	
	Dim param24 As New SqlClient.SqlParameter
	param24.SqlDbType = SqlDbType.varchar
	param24.Size = 500
	If aipinsrest.xdescinsrest IsNot Nothing Then
	param24.Value = aipinsrest.xdescinsrest
	else
	param24.Value = ""
	end if
	param24.ParameterName = "p_xdescinsrest"
	
	Dim param25 As New SqlClient.SqlParameter
	param25.SqlDbType = SqlDbType.varchar
	param25.Size = 20
	If aipinsrest.iestatinsrest IsNot Nothing Then
	param25.Value = aipinsrest.iestatinsrest
	else
	param25.Value = ""
	end if
	param25.ParameterName = "p_iestatinsrest"
	
	Dim param26 As New SqlClient.SqlParameter
	param26.SqlDbType = SqlDbType.decimal
	param26.Precision = 18
	param26.Scale = 0
	param26.Value = aipinsrest.idseglogreg
	param26.ParameterName = "p_idseglogreg"
	Dim f As Integer = _db.ExecuteStoreCommand("exec sp_aipinsrest @p_ioperacion,@p_idsegmanusulog,@p_xnombrecortolog,@p_irespuesta output,@p_xmsjusuario output,@p_xmsjtecnico output,@p_coderrorlog output,@p_idaipinsrest output,@p_idaipinsenc,@p_idaipmanveh,@p_xsucuinsrest,@p_nkiloinsrest,@p_idcomunmanestado,@p_idcomunmanlocalid,@p_xdirinsrest,@p_msumaseginsrest,@p_msumaseg75insrest,@p_mvalinminsrest,@p_mdanoinsrest,@p_mavalinsrest,@p_xnomtalinsrest,@p_xnomperinsrest,@p_xnomjefperinsrest,@p_xdescinsrest,@p_iestatinsrest,@p_idseglogreg",param1, param2, param3, param4, param5, param6, param7,param8,param9,param10,param11,param12,param13,param14,param15,param16,param17,param18,param19,param20,param21,param22,param23,param24,param25,param26)
	
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
