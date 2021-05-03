Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports System.Web
Imports estarseguros20.capaobjetos.modelo.personalizados
Imports estarseguros20.capawebapi.aipauto.entidades.controlador
Imports estarseguros20.capawebapi.comun.entidades.controlador
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.entidades.agenda
Imports estarseguros20.capawebapi.seginsoft.vistas.controlador
Imports estarseguros20.capaobjetos.seginsoft.modelo.dbestarseguros20.vistas.seguridad
Imports estarseguros20.capaobjetos.aipauto.modelo.dbestarseguros20.vistas.inspeccion
Imports estarseguros20.capaobjetos.comun.modelo.dbestarseguros20.entidades.configuracion
Imports estarseguros20.capawebapi.aipauto.vistas.controlador

Public Class ActividadController
    Inherits ApiController

    <HttpPost()> _
    Public Function ObtenerContadorEventos(idsegmanusuperit As Decimal, mes As String, anio As String) As List(Of eventos)
        Try
            Dim lista_eventos As New List(Of eventos)
            'necesito primero determinar la cantidad de dias que posee el mes para el año en especifico
            Dim cant_dia_mes As Integer = Date.DaysInMonth(CInt(anio), CInt(mes))
            '
            Dim n_event_priv As Integer = 0
            Dim n_event_publ As Integer = 0
            Dim n_event_publ_otros As Integer = 0
            Dim dia As Integer = 0
            Dim vi_aipinsencController As New vi_aipinsencController
            '
            For i = 0 To cant_dia_mes - 1
                '
                lista_eventos.Add(New eventos)
                n_event_priv = 0
                n_event_publ = 0
                n_event_publ_otros = 0
                '
                dia = i + 1
                Dim fecha As New Date(anio, mes, dia)
                '
                'n_event_priv = ragactencController.countragactencxidsegmanusuejec_fejecactenc_y_ialcanactenc(idsegmanusuejec, fecha, "PRIVADA", idragmanaero)
                'lista_eventos.Item(i).contadorprivados = n_event_priv
                '
                n_event_publ = vi_aipinsencController.ObtenerCantidadPorFinicioAlcanceYPerito(fecha, "PUBLICA", idsegmanusuperit)
                lista_eventos.Item(i).contadorpublicos = n_event_publ
                '
                'n_event_publ_otros = ragactencController.countragactencxidsegmanusuejecdif_fejecactenc_y_ialcanactenc(idsegmanusuejec, fecha, "PUBLICA")
                'lista_eventos.Item(i).contadorpublicosotros = n_event_publ_otros
            Next
            '
            Return lista_eventos

        Catch ex As Exception

            Dim lista_eventos As New List(Of eventos)
            Return lista_eventos
        End Try
    End Function

    <HttpPost()> _
    Public Function InsertarAipactivperi(aipactivperi As aipactivperi) As respopera
        'necesitamos validar si el id del continente y del pais son 0 para asignarle America y Venezuela al evento a la hora de insertarlo
        Dim respopera As New respopera
        Dim aipactivperiController As New aipactivperiController
        If aipactivperi.idcomunmancont = 0 Then
            aipactivperi.idcomunmancont = 1
        End If
        If aipactivperi.idcomunmanpais = 0 Then
            aipactivperi.idcomunmanpais = 9
        End If
        respopera = aipactivperiController.insaipactivperi(aipactivperi)
        Return respopera

    End Function

    '<HttpPost()> _
    'Public Function EliminarAipactivperi(idaipactivperi As Decimal, idsegmanusucreaactivperi As Decimal, idsegmanapp As Decimal) As respopera
    '    Dim respopera As New respopera
    '    Dim aipactivperiController As New aipactivperiController
    '    Dim aipactivperi As aipactivperi = aipactivperiController.selaipactivperixidsegmanusucreaactivperi(idaipactivperi, idsegmanusucreaactivperi)
    '    If aipactivperi IsNot Nothing Then
    '        respopera = aipactivperiController.eliaipactivperi(aipactivperi)
    '    Else
    '        Dim vi_segusuperfController As New vi_segusuperfController
    '        Dim vi_segusuperf As vi_segusuperf = vi_segusuperfController.selvi_segusuperfxappyusu(idsegmanapp, idsegmanusucreaactivperi)
    '        If vi_segusuperf.xnombreperf = "ADMINISTRADOR" Then
    '            aipactivperi = aipactivperiController.selaipactivperixid(idaipactivperi)
    '            respopera = aipactivperiController.eliaipactivperi(aipactivperi)
    '        Else
    '            respopera.irespuesta = 0
    '            respopera.xmsjusuario = "Usted no tiene permisos para eliminar esta actividad"
    '            respopera.xmsjtecnico = "Este usuario no creó este vuelo ni es administrador"
    '        End If
    '    End If
    '    Return respopera
    'End Function

    <HttpPost()> _
    Public Function VerificarPermisos(idaipinsenc As Decimal, idsegmanusucrea As Decimal, idsegmanapp As Decimal) As respopera

        Dim vi_aipinsencController As New vi_aipinsencController
        Dim vi_aipinsenc As vi_aipinsenc = vi_aipinsencController.selvi_aipinsencxid(idaipinsenc)

        Dim respopera As New respopera

        If (vi_aipinsenc IsNot Nothing) Then

            If (vi_aipinsenc.iestatinsenc <> "INICIALIZAR" And vi_aipinsenc.iestatinsenc <> "POR PROCESAR") Then
                respopera.irespuesta = "0"
                respopera.xmsjusuario = "No puede realizar esta acción ya que la misma se encuentra en proceso de ejecución"
                Return respopera
            End If
        End If


        Dim vi_segusudetperf2 As New vi_segusudetperf2
        Dim vi_segusudetperf2Controller As New vi_segusudetperf2Controller
        vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2poridsegmanusu(idsegmanusucrea)

        Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
        Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
        Dim administrador As Decimal = ConfigurationManager.AppSettings("administrador")
       
        If (vi_segusudetperf2 IsNot Nothing) Then
            'si es auditor lider Pricipal
            If (vi_segusudetperf2.idsegmanperf = auditorlp Or vi_segusudetperf2.idsegmanperf = administrador) Then
                respopera.irespuesta = "1"
                respopera.xmsjusuario = "Este usuario posee permisos para ejecutar esta acción"
            ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                If (vi_aipinsenc.idsegmanusucrea = vi_segusudetperf2.idsegmanusu) Then
                    respopera.irespuesta = "1"
                    respopera.xmsjusuario = "La acción puede se  ejecutada"
                Else
                    respopera.irespuesta = "0"
                    respopera.xmsjusuario = "No puede  ejecutar esta acción ya que no no posee los permisos necesarios"
                End If
            Else
                respopera.irespuesta = "0"
                respopera.xmsjusuario = "No puede ejecutar esta acción ya que no no posee los permisos necesarios"
            End If
        Else
            respopera.irespuesta = "0"
            respopera.xmsjusuario = "No puede ejecutar esta acción ya que no no posee los permisos necesarios"
        End If

        Return respopera

    End Function

    <HttpPost()> _
    Public Function ObtenerComboPeritos(idsegmanusuaudit As Decimal) As List(Of vi_segusudetperf2)

        Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
        Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")
        Dim peritols As Decimal = ConfigurationManager.AppSettings("peritols")

        Dim vi_segusudetperf2 As New vi_segusudetperf2
        Dim vi_segusudetperf2Controller As New vi_segusudetperf2Controller
        vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2poridsegmanusu(idsegmanusuaudit)

        Dim lista_vi_segusudetperf2 As New List(Of vi_segusudetperf2)

        If (vi_segusudetperf2 IsNot Nothing) Then
            'si es auditor lider Principal
            If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                lista_vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2combo()

                'si es auditor lider Sucursal
            ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                lista_vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2comboPorOrg(vi_segusudetperf2.idsegmanorg)
            End If
        End If

        Return lista_vi_segusudetperf2

    End Function

    <HttpPost()> _
    Public Function ObtenerComboPeritosPorOrg(idsegmanusuaudit As Decimal, idsegmanorg As Decimal) As List(Of vi_segusudetperf2)

        Dim auditorlp As Decimal = ConfigurationManager.AppSettings("auditorlp")
        Dim auditorls As Decimal = ConfigurationManager.AppSettings("auditorls")

        Dim vi_segusudetperf2 As New vi_segusudetperf2
        Dim vi_segusudetperf2Controller As New vi_segusudetperf2Controller
        vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2poridsegmanusu(idsegmanusuaudit)

        Dim lista_vi_segusudetperf2 As New List(Of vi_segusudetperf2)

        If (vi_segusudetperf2 IsNot Nothing) Then
            'si es auditor lider Principal
            If (vi_segusudetperf2.idsegmanperf = auditorlp) Then
                lista_vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf3comboPorOrg(idsegmanorg)

                'si es auditor lider Sucursal
            ElseIf (vi_segusudetperf2.idsegmanperf = auditorls) Then
                lista_vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf3comboPorOrg(vi_segusudetperf2.idsegmanorg)
            End If
        End If


        If (lista_vi_segusudetperf2.Count = 0) Then
            'verifico que si la lista no trae informacion se lleno con los peritos de la sucursal lider
            Dim comunconfvalorController As New comunconfvalorController
            Dim lista_comunconfvalor As List(Of comunconfvalor) = comunconfvalorController.selcomunconfvalorxconceptosinsel("IDSUCPRINCIPAL")
            If lista_comunconfvalor.Count > 0 Then
                idsegmanorg = lista_comunconfvalor(0).xvalorcodigo
                lista_vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2comboPorOrg(idsegmanorg)
            End If
            'fin verifico que si la lista no trae informacion se lleno con los peritos de la sucursal lider
        End If

        Return lista_vi_segusudetperf2

    End Function


    <HttpPost()> _
    Public Function VerificarPermisosAdmin(idsegmanusu As Decimal) As respopera

        Dim vi_segusudetperf2 As New vi_segusudetperf2
        Dim vi_segusudetperf2Controller As New vi_segusudetperf2Controller
        vi_segusudetperf2 = vi_segusudetperf2Controller.selvi_segusudetperf2poridsegmanusu(idsegmanusu)
        Dim respopera As New respopera

        Dim administrador As Decimal = ConfigurationManager.AppSettings("administrador")
        If (vi_segusudetperf2 IsNot Nothing) Then

            If (vi_segusudetperf2.idsegmanperf = administrador) Then
                respopera.irespuesta = "1"
                respopera.xmsjusuario = "Este usuario posee permisos para ejecutar esta acción"
            Else
                respopera.irespuesta = "0"
                respopera.xmsjusuario = "No puede ejecutar esta acción ya que no no posee los permisos necesarios"
            End If
        Else
            respopera.irespuesta = "0"
            respopera.xmsjusuario = "No puede ejecutar esta acción ya que no no posee los permisos necesarios"
        End If

        Return respopera
    End Function


End Class