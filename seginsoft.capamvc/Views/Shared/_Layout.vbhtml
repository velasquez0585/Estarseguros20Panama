<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewData("Title") - Seginsoft</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
    <meta name="viewport" content="width=device-width" />
    @*@Styles.Render("~/Content/css")*@
   @* @Scripts.Render("~/bundles/modernizr")*@

    @Scripts.Render("~/publico/scripts/terceros/jquery-1.9.1.js")
    @Scripts.Render("~/publico/scripts/terceros/jqueryui/jquery-ui-1.10.3.metro-purple.min.js")
    @Scripts.Render("~/publico/scripts/terceros/jqueryui/jquery.ui.datepicker-es.js")
    @Scripts.Render("~/publico/scripts/mvcprincipal/knockout-2.1.0.js")
    @Scripts.Render("~/publico/scripts/terceros/knockout-validation/knockout.validation.min.js")
    @Scripts.Render("~/publico/scripts/terceros/knockout-mapping/knockout.mapping.js") 
    @Scripts.Render("~/publico/scripts/terceros/jquery_noty/js/noty/jquery.noty.js")
    @Scripts.Render("~/publico/scripts/terceros/jquery_noty/js/noty/layouts/bottom.js")
    @Scripts.Render("~/publico/scripts/terceros/jquery_noty/js/noty/themes/default.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_generales.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_noty.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_ajax.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_jqueryui.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_scrollscreen.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_knockout.js")

    @Styles.Render("~/publico/scripts/terceros/jqueryui/themes/start/jquery-ui.css") 
   @* @Styles.Render("~/publico/css/seginsoft.css")*@
    @Styles.Render("~/publico/css/custom-metro-green-sigma.css")
    
    @Styles.Render("~/publico/css/terceros/scrolltopbottom.css")
    @Styles.Render("~/publico/scripts/terceros/jquery_noty/demo/buttons.css")
    @Scripts.Render("~/publico/scripts/terceros/knockout-validation/knockout.validation.config.js")
    @Scripts.Render("~/publico/scripts/sitfx/viewmodels/paginacion.js")

    @Scripts.Render("~/publico/scripts/terceros/moment/moment.min.js")
    @Scripts.Render("~/publico/scripts/terceros/moment/moment-with-langs.min.js")


</head>
<body>

    <div id="popup_cargando" style="display: none;">
        <div>Por favor espere...</div>
    </div>

    <header>
       @Html.Partial("_Header")
    </header>
    <div id="body">
        @RenderSection("featured", False)
        <section class="content-wrapper main-content clear-fix">
            @RenderBody()
        </section>
    </div>
    <footer>
        @Html.Partial("_Footer")
    </footer>
     
</body>
</html>

