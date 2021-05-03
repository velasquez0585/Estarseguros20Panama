@Code
    ViewData("Title") = "Recuperar Contraseña"
    ViewData("Message") = "Recuperación de contraseña,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Suministra tu direcci&oacute;n de correo electr&oacute;nico y recupera f&aacute;cilmente tu contrase&ntilde;a.
        </p>
    </div>
</section>
End Section

@Html.Action("RecuperarContrasena", "Seguridad", New With {.esvistaparcial = True})
