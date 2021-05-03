@Code
    ViewData("Title") = "Usuario"
    ViewData("Message") = "Tu perfil,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Cambie su contrase&ntilde;a, consulte y actualice sus datos de una forma sencilla a trav&eacute;s de este 
            formulario.
        </p>
    </div>
</section>
End Section

@Html.Action("CambiarContrasena", "Seguridad", New With {.esvistaparcial = True})
