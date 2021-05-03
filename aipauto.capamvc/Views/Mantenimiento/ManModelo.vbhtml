@Code
    ViewData("Title") = "Mantenimiento de Modelos"
    ViewData("Message") = "Mantenimiento de Modelos,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Control y administracion de Modelos del sistema.
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanvehmod.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_aipmanvehmod.js")
@Html.Action("ManModelo", "Mantenimiento", New With {.esvistaparcial = True})