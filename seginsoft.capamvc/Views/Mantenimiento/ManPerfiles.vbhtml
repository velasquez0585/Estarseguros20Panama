@Code
    ViewData("Title") = "Mantenimiento de Perfiles"
    ViewData("Message") = "Perfiles"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p>
           Cree y administre todos los perfiles posibles que podrá configurar para cada aplicación. 
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/segmanperf.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/mantenimiento/vi_segappperf.js")

@Html.Action("ManPerfiles", "Mantenimiento", New With {.esvistaparcial = True})
