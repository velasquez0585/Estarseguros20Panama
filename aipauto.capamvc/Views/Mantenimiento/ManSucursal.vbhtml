@Code
    ViewData("Title") = "Mantenimiento de Sucursales"
    ViewData("Message") = "Mantenimiento de Sucursales,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Control y administracion de Sucursales del sistema.
        </p>
    </div>
</section>
End Section

@*@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanvehver.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_aipmanvehver.js")*@
@Html.Action("ManSucursal", "Mantenimiento", New With {.esvistaparcial = True})