@Code
    ViewData("Title") = "Mantenimiento de Marcas"
    ViewData("Message") = "Mantenimiento de Marcas,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Control y administracion de Marcas del sistema.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanvehmar.js")
@Html.Action("ManMarca", "Mantenimiento", New With {.esvistaparcial = True})