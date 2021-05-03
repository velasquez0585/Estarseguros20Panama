@Code
    ViewData("Title") = "Mantenimiento de Usuarios"
    ViewData("Message") = "Usuarios"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
           Cree y administre a todos los usuarios del sistema.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_segmanusu.js")


@Html.Action("ManUsuario", "Mantenimiento", New With {.esvistaparcial = True})
