@Code
    ViewData("Title") = "Cambiar Contraseña"
    ViewData("Message") = "Cambie su contrase&ntilde;a,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            A trav&eacute;s de este formulario usted podr&aacute; cambiar su contrase&ntilde;a cada vez que sea necesario.
        </p>
    </div>
</section>
End Section

@Html.Action("CambiarContrasena", "Seguridad", New With {.esvistaparcial = True})