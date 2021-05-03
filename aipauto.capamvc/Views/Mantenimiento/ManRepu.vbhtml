@Code
    ViewData("Title") = "Mantenimiento de Repuestos"
    ViewData("Message") = "Mantenimiento de Repuestos,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
            Control y administracion de repuestos
        </p>
    </div>
</section>
End Section
 
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/aipmanrepu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_aipmanrepu.js") 

@Html.Action("ManRepu", "Mantenimiento", New With {.esvistaparcial = True})