@Code
    ViewData("Title") = "Baremos"
    ViewData("Message") = "Baremos,"
End Code

@section featured
<section class="featured">
    <div class="content-wrapper">
        <hgroup class="title">
            <h1>@ViewData("Message")</h1>
        </hgroup>
        <p> 
            Creacion y configuracion de baremos por repuestos y mano de obra
        </p>
    </div>
</section>
End Section

@Scripts.Render("~/publico/scripts/sitfx/viewmodels/baremo/barerepumasivo.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/baremo/baremobrmasivo.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/baremo/aipbaremobr.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/baremo/aipbarerepu.js")
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/baremo/vi_aipbaremobr.js") 
@Scripts.Render("~/publico/scripts/sitfx/viewmodels/baremo/vi_aipbarerepu.js") 

@Html.Action("Bare", "Baremo", New With {.esvistaparcial = True})