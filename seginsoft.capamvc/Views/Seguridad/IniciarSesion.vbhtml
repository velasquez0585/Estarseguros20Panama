@Code
    ViewData("Title") = "Iniciar Sesión"
    ViewData("Message") = "Inicia sesión,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Suministre su direcci&oacute;n de correo electr&oacute;nico y contrase&ntilde;a para ingresar a las opciones de 
            Seginsoft.
        </p>
    </div>
</section>
End Section

@Html.Action("IniciarSesion", "Seguridad", New With {.esvistaparcial = True})