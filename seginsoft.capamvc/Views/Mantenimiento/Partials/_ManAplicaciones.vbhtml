<div class="dialognoauto" id="dialog-app" title="Aplicaci&oacute;n">
    <div id="div_manappagregarapp1">
        @Html.Partial("__ManAplicacionesAgregarApp1")
    </div>
</div>

<div class="dialognoauto" id="dialog-mod" title="Modulo">
    <div id="div_manappagregarmod1">
        @Html.Partial("__ManAplicacionesAgregarModulo1")
    </div>
</div>

<div class="dialognoauto" id="dialog-submod" title="Submodulo">
    <div id="div_manappagregarsubmod1">
        @Html.Partial("__ManAplicacionesAgregarSubMod1")
    </div>
</div>

<div class="dialognoauto" id="dialog-programa" title="Programa">
    <div id="div_manappagregarprog1">
        @Html.Partial("__ManAplicacionesAgregarProg1")
    </div>
</div>


<div  id="tab_manaplicaciones" class="tab ui-tabs ui-widget ui-widget-content ui-corner-all">
    <ul>
        <li class="tab-click"><a href="#tab-1">Buscar</a></li>
        <li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li class="tab-click"><a href="#tab-3">Agregar</a></li>
        <li id="tab-editar"><a href="#tab-4">Modificar</a></li>
        <li class="tab-click"><a href="#tab-5">Configurar</a></li>
    </ul>
    <div id="tab-1">
        <div id="div_manappbuscar1">
            @Html.Partial("__ManAplicacionesBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_manappver1">
            @Html.Partial("__ManAplicacionesVer1")
        </div>
    </div>
    <div id="tab-3">        
        <div id="div_manappagregar1">
            @Html.Partial("__ManAplicacionesAgregar1")  
        </div> 
    </div>
    <div id="tab-4">
        <div id="div_manappmodificar1">
            @Html.Partial("__ManAplicacionesModificar1")
        </div>
    </div>
    <div id="tab-5">
        <div id="div_manappconfigurar1">
            @Html.Partial("__ManAplicacionesConfigurar1")
        </div>
    </div>
</div>

<script type="text/javascript">

    //-----------------------------------------------------------------------------------------

    var vmmanappbuscar1 = new vmmanappbuscar1(true, true, true);
    ko.applyBindings(vmmanappbuscar1, $('#div_manappbuscar1')[0]);

    $(function () {
        vmmanappbuscar1.buscar();
    });

    //-----------------------------------------------------------------------------------------
    var vmmanappver1 = new vmmanappver1();
    ko.applyBindings(vmmanappver1, $('#div_manappver1')[0]);

    //-----------------------------------------------------------------------------------------

    var vmmanappagregar1 = new vmmanappagregar1();
    ko.applyBindings(vmmanappagregar1, $('#div_manappagregar1')[0]);

    $(function () {
        vmmanappagregar1.llenarcomboaplicacion();
        vmmanappagregar1.llenarcombomodulo();
        vmmanappagregar1.llenarcombosubmodulo();
        vmmanappagregar1.llenarcomboprograma();
    });

    //-----------------------------------------------------------------------------------------

    var vmmanappmodificar1 = new vmmanappmodificar1();
    ko.applyBindings(vmmanappmodificar1, $('#div_manappmodificar1')[0]);

    $(function () {        
    });

    //-----------------------------------------------------------------------------------------

    var vmmanappconfigurar1 = new vmmanappconfigurar1();
    ko.applyBindings(vmmanappconfigurar1, $('#div_manappconfigurar1')[0]);

    $(function () {
        vmmanappconfigurar1.llenarcomboaplicacion();

    });

    //------------------------------------------------------------------------------------------------------
    //viewmodels agregar aplicaciones

    var vmmanaplicacionesagregarapp1 = new vmmanaplicacionesagregarapp1();
    ko.applyBindings(vmmanaplicacionesagregarapp1, $('#div_manappagregarapp1')[0]);

    $(function () {
        vmmanaplicacionesagregarapp1.llenarcomboorganizaciones();
        vmmanaplicacionesagregarapp1.llenarcombotipoapp();
        vmmanaplicacionesagregarapp1.llenarcombosistoper();
        vmmanaplicacionesagregarapp1.llenarcombotecndesarrollo();
    });

    //---------------------------------------------------------------------------------
    //viewmodels agregar modulos

    var vmmanaplicacionesagregarmodulo1 = new vmmanaplicacionesagregarmodulo1();
    ko.applyBindings(vmmanaplicacionesagregarmodulo1, $('#div_manappagregarmod1')[0]);

    $(function () {
        
    });

    //---------------------------------------------------------------------------------
    //viewmodels agregar submodulos

    var vmaplicacionesagregarsubmodulo1 = new vmaplicacionesagregarsubmodulo1();
    ko.applyBindings(vmaplicacionesagregarsubmodulo1, $('#div_manappagregarsubmod1')[0]);

    $(function () {
       
    });

    //---------------------------------------------------------------------------------
    //viewmodels agregar programas

    var vmaplicacionesagregarprog1 = new vmaplicacionesagregarprog1();
    ko.applyBindings(vmaplicacionesagregarprog1, $('#div_manappagregarprog1')[0]);

    $(function () {
        
        //al cargar se deshabilita los tab de ver y editar
        $("#tab_manaplicaciones").tabs({ disabled: [1, 3] });

        //al dar click a los tab buscar y nuevo se dehabilita los de ver y editar
        $(".tab-click").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });
    });



</script>
