Imports System.Configuration

Public Class funciones
    Public Shared Function obtener_cnxcadenaxpais(pais As String) As String
        Dim cnxcadena As String = ""
        Select Case pais
            Case "venezuela"
                cnxcadena = "cnxdbestarseguros20" & ConfigurationManager.AppSettings("motoddb") & ConfigurationManager.AppSettings("ambiente") & "ve"
            Case Else
                cnxcadena = "cnxdbestarseguros20" & ConfigurationManager.AppSettings("motoddb") & ConfigurationManager.AppSettings("ambiente") & "ve"
        End Select
        Return cnxcadena
    End Function

    'Public Shared Function obtener_ec(pais As String) As EntityClient.EntityConnection
    '    Dim ec As New EntityClient.EntityConnection("name=" & obtener_cnxcadenaxpais(pais, "desa"))
    '    If ec.State <> ConnectionState.Open Then
    '        Try
    '            ec.Open()
    '        Catch entex As EntityException
    '            ec.ConnectionString = "name=" & obtener_cnxcadenaxpais(pais, "prod")
    '        End Try
    '    End If
    '    Return ec
    'End Function

    Public Shared Function convertToDegree2(ByVal stringDMS As String) As Double

        Dim result As Double = 0
        Dim DMS() As String = Split(stringDMS, ",")
        Dim stringD() As String = Split(DMS(0), "/")

        Dim D0 As Double = Double.Parse(stringD(0))
        Dim D1 As Double = Double.Parse(stringD(1))
        Dim FloatD As Double = D0 / D1

        Dim stringM() As String = Split(DMS(1), "/")
        Dim M0 As Double = Double.Parse(stringM(1))
        Dim M1 As Double = Double.Parse(stringM(1))
        Dim FloatM As Double = M0 / M1

        Dim stringS() As String = Split(DMS(2), "/")
        Dim S0 As Double = Double.Parse(stringS(1))
        Dim S1 As Double = Double.Parse(stringS(1))
        Dim FloatS As Double = S0 / S1


        result = FloatD + (FloatM / 60) + (FloatS / 3600)

        Return result


    End Function
End Class
