Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class CambiarContrasenaModel
    Public Property xcontrasena_actual() As String
    Public Property xcontrasena_nueva() As String
    Public Property xcontrasena_confirmacion() As String
    Public Property infomodel() As InfoModel
End Class

Public Class IniciarSesionModel
    Public Property xnombreusuario() As String
    Public Property xcontrasena() As String
    Public Property infomodel() As InfoModel
End Class

Public Class RecuperarContrasenaModel
    Public Property xcorreo() As String
    Public Property infomodel() As InfoModel
End Class