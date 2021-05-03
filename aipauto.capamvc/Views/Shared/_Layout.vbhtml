<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <meta http-equiv='cache-control' content='no-cache'>
    <meta http-equiv='expires' content='0'>
    <meta http-equiv='pragma' content='no-cache'>

    <title>@ViewData("Title") - AipAuto</title>

    @Scripts.Render("~/publico/scripts/terceros/jquery-1.9.1.js")
    @*@Scripts.Render("~/publico/scripts/terceros/jquery.tmpl.min.js")*@
    @Scripts.Render("~/publico/scripts/terceros/jqueryui/jquery-ui-1.10.3.metro-purple.min.js")
    @Scripts.Render("~/publico/scripts/terceros/jqueryui/jquery.ui.datepicker-es.js")
    @Scripts.Render("~/publico/scripts/mvcprincipal/knockout-2.1.0.js")
    @*@Scripts.Render("~/publico/scripts/mvcprincipal/knockout-3.0.0.js")*@
    @Scripts.Render("~/publico/scripts/terceros/knockout-validation/knockout.validation.min.js")
    @Scripts.Render("~/publico/scripts/terceros/knockout-mapping/knockout.mapping.js")
    @*@Scripts.Render("~/publico/scripts/terceros/knockout-pager/ko.pager.js")*@
    @*@Scripts.Render("~/publico/scripts/terceros/knockout-kogrid/koGrid-2.1.1.debug.js")*@
    @*@Scripts.Render("~/publico/scripts/terceros/knockout-simplegrid/knockout.simpleGrid.js")*@
    @Scripts.Render("~/publico/scripts/terceros/scroll-startstop.events.jquery.js")
    @Scripts.Render("~/publico/scripts/terceros/jquery_noty/js/noty/jquery.noty.js")
    @Scripts.Render("~/publico/scripts/terceros/jquery_noty/js/noty/layouts/bottom.js")
    @Scripts.Render("~/publico/scripts/terceros/jquery_noty/js/noty/themes/default.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_generales.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_noty.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_ajax.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_jqueryui.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_scrollscreen.js")
    @Scripts.Render("~/publico/scripts/sitfx/funciones_knockout.js")

    @Styles.Render("~/publico/css/custom-metro-purple-laregionalseguros.css")
    @Styles.Render("~/publico/scripts/terceros/jqueryui/themes/custom-metro-purple/jquery-ui-1.10.3.metro-purple.laregionalseguros.css")
    @Styles.Render("~/publico/css/terceros/scrolltopbottom.css")
    @Styles.Render("~/publico/scripts/terceros/jquery_noty/demo/buttons.css")
    @*@Styles.Render("~/publico/css/terceros/KoGrid.css")*@

    @Scripts.Render("~/publico/scripts/terceros/knockout-validation/knockout.validation.config.js")
    @Scripts.Render("~/publico/scripts/sitfx/viewmodels/paginacion.js")

    @Scripts.Render("~/publico/scripts/terceros/jquery_filedownload/jquery.file.download.js")
    @Scripts.Render("~/publico/scripts/terceros/jquery_fileupload/jquery.fileupload.js")

    @Scripts.Render("~/publico/scripts/terceros/moment/moment.min.js")
    @Scripts.Render("~/publico/scripts/terceros/moment/moment-with-langs.min.js")
    
    @Scripts.Render("~/publico/scripts/terceros/numeral/min/numeral.min.js")
    @Scripts.Render("~/publico/scripts/terceros/slider/jssor.core.js")
    @Scripts.Render("~/publico/scripts/terceros/slider/jssor.slider.js")
    @Scripts.Render("~/publico/scripts/terceros/slider/jssor.utils.js")

    @Scripts.Render("~/publico/scripts/fullcalendar-1.6.4/fullcalendar/fullcalendar.js")
    @Styles.Render("~/publico/scripts/fullcalendar-1.6.4/fullcalendar/fullcalendar.css")
    @Scripts.Render("~/publico/scripts/terceros/jquery.imageLens.js")

@*    @Scripts.Render("~/publico/scripts/fullcalendar-1.6.4/fullcalendar/fullcalendar.print.css")*@

    <script src='https://maps.googleapis.com/maps/api/js?key=&sensor=false&extension=.js'></script> 
</head>

<body id="sitiocompleto">
    <div id="popup_cargando" style="display: none;"><div>Obteniendo datos, por favor espere...</div></div>

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
        @Html.Partial("_Footer2")
    </footer>

    <div id="nav_up"></div>
    <div id="nav_down"></div>

</body>
</html>
