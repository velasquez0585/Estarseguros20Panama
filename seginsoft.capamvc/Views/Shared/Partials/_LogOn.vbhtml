@If Request.IsAuthenticated Then
     @<p>
        @Html.ActionLink("Inicio", "Index", "Home")
        @Html.ActionLink("Acerca De...", "AcercaDe", "Home")
        <b>Bienvenido(a)</b> ¡@Html.ActionLink(User.Identity.name, "DatosUsuario", "Seguridad", Nothing, New With {.class = "username"})!      
        @Html.ActionLink("Cerrar Sesión", "CerrarSesion", "Seguridad")
        @Html.ActionLink("Contactanos", "Contactanos", "Home")
    </p>
Else
    @<p>
        @Html.ActionLink("Inicio", "Index", "Home")
        @Html.ActionLink("Acerca De...", "AcercaDe", "Home")
        @*@Html.ActionLink("Iniciar Sesión", "IniciarSesion", "Seguridad")
        @Html.ActionLink("¿Olvidó su contraseña?", "RecuperarContrasena", "Seguridad")*@          
        @Html.ActionLink("Contactanos", "Contactanos", "Home")
    </p>
End If
