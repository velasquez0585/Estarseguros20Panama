<div id="tab_manusuario" class="tab ui-tabs ui-widget ui-widget-content ui-corner-all">
    <ul>
        <li class="tab-click"><a href="#tab-1">Buscar</a></li>
        <li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li class="tab-click"><a href="#tab-3">Agregar</a></li>
        <li id="tab-editar"><a href="#tab-4">Modificar</a></li>
    </ul>
    
    <div id="tab-1">
        <div id="div_manusuariobuscar1">
            @Html.Partial("__ManUsuarioBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_manusuver1">
            @Html.Partial("__ManUsuarioVer1")
        </div>
    </div>
    <div id="tab-3">
        <div id="div_manusuagregar1">
            @Html.Partial("__ManUsuarioAgregar1")
        </div>
    </div>
    <div id="tab-4">
        <div id="div_manusumodificar1">
            @Html.Partial("__ManUsuarioModificar1")
        </div>
    </div>
    
        <div id="div_manusuconfigurarperf1">
            @Html.Partial("__ManUsuarioConfigurarPerf1")
        </div>

</div>

<script type="text/javascript">

    var vmmanusuariobuscar1 = new vmmanusuariobuscar1(true, true, true);
    ko.applyBindings(vmmanusuariobuscar1, $('#div_manusuariobuscar1')[0]);

    $(function () {
        vmmanusuariobuscar1.llenarcombodepartamento();
        vmmanusuariobuscar1.buscar();
    });

    //----------------------------------------------------------------------------------

    var vmmanusuariover1 = new vmmanusuariover1();
    ko.applyBindings(vmmanusuariover1, $('#div_manusuver1')[0]);


    //---------------------------------------------------------------------------------

    var vmmanusuarioagregar1 = new vmmanusuarioagregar1();
    ko.applyBindings(vmmanusuarioagregar1, $('#div_manusuagregar1')[0]);
  
    $(function () {        
        vmmanusuarioagregar1.iniciar();      
    });

    //--------------------------------------------------------------------------------

    var vmmanusuariomodificar1 = new vmmanusuariomodificar1();
    ko.applyBindings(vmmanusuariomodificar1, $('#div_manusumodificar1')[0]);

    $(function () {        
    });

    //-----------------------------------------------------------------------------------
    var vmmanusuarioconfigurarperf1 = new vmmanusuarioconfigurarperf1();
    ko.applyBindings(vmmanusuarioconfigurarperf1, $('#div_manusuconfigurarperf1')[0]);
    $(function () {

        vmmanusuarioconfigurarperf1.llenarcomboaplicacion();
    });


    $(function () {        
        //al cargar se deshabilita los tab de ver y editar
        $("#tab_manusuario").tabs({ disabled: [1, 3] });

        //al dar click a los tab buscar y nuevo se dehabilita los de ver y editar
        $(".tab-click").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });

    });
</script>