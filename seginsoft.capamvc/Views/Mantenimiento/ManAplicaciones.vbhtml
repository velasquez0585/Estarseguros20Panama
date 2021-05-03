@Code
    ViewData("Title") = "Mantenimiento de Aplicaciones"
    ViewData("Message") = "Aplicaciones"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
           Configure cualquier aplicación a través de este programa estableciendo sus módulos y menú de navegación. 
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/segmanapp.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/segmanmod.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/segmansubmod.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/segappprog.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/segmanprog.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_segappprog.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/segappperf.js")

@Html.Action("ManAplicaciones", "Mantenimiento", New With {.esvistaparcial = True})
