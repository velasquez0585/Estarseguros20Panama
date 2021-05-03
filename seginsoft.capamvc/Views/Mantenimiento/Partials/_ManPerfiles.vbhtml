<div id="tab_manperfiles" class="tab ui-tabs ui-widget ui-widget-content ui-corner-all">
    <ul>
        <li class="tab-click"><a href="#tab-1">Buscar</a></li>
        <li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li class="tab-click"><a href="#tab-3">Agregar</a></li>
        <li id="tab-editar"><a href="#tab-4">Modificar</a></li>
        <li class="tab-click"><a href="#tab-5">Configurar</a></li>
    </ul>
    <div id="tab-1">
        <div id="div_manperfbuscar1">
            @Html.Partial("__ManPerfilesBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_manperfver1">
            @Html.Partial("__ManPerfilesVer1")
        </div>
    </div>
    <div id="tab-3">
        <div id="div_manperfagregar1">
            @Html.Partial("__ManPerfilesAgregar1")
        </div>
    </div>
    <div id="tab-4">
        <div id="div_manperfmodificar1">
            @Html.Partial("__ManPerfilesModificar1")
        </div>
    </div>
    <div id="tab-5">
        <div id="div_manperfconfigurar1">
            @Html.Partial("__ManPerfilesConfigurar1")
        </div>
    </div>
</div>

<script type="text/javascript">

    var vmmanperfilesbuscar1 = new vmmanperfilesbuscar1(true, true, true);
    ko.applyBindings(vmmanperfilesbuscar1, $('#div_manperfbuscar1')[0]);

    $(function () {
        vmmanperfilesbuscar1.llenarcombodepartamento();
        vmmanperfilesbuscar1.buscar();
    });

    //---------------------------------------------------------------------------------

    var vmmanperfilesver1 = new vmmanperfilesver1();
    ko.applyBindings(vmmanperfilesver1, $('#div_manperfver1')[0]);

    //---------------------------------------------------------------------------------

    var vmmanperfilesagregar1 = new vmmanperfilesagregar1();
    ko.applyBindings(vmmanperfilesagregar1, $('#div_manperfagregar1')[0]);
       
    //--------------------------------------------------------------------------------

    var vmmanperfilesmodificar1 = new vmmanperfilesmodificar1();
    ko.applyBindings(vmmanperfilesmodificar1, $('#div_manperfmodificar1')[0]);

    //--------------------------------------------------------------------------------

    var vmmanappconfigurar1 = new vmmanappconfigurar1();
    ko.applyBindings(vmmanappconfigurar1, $('#div_manperfconfigurar1')[0]);

    $(function () {
        vmmanappconfigurar1.iniciar();
    });

    $(function () {
        //al cargar se deshabilita los tab de ver y editar
        $("#tab_manperfiles").tabs({ disabled: [1, 3] });

        //al dar click a los tab buscar y nuevo se dehabilita los de ver y editar
        $(".tab-click").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });

    });
    

</script>