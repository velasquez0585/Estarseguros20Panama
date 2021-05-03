﻿@*siempre creamos un tab en la vista parcial, asi tenga una sola ficha, es importante que nos fijemos en la estructura del tab
para hacerlo siempre igual y bajo las mismas convenciones*@
<div id="tab_manperitos" class="tab">
    <ul>
        @*aqui van los titulos de cada tab con la referencia de su contenido*@
        <li ><a href="#tab-1">Buscar</a></li>
        <li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li ><a href="#tab-3">Nuevo</a></li>
        <li id="tab-editar"><a href="#tab-4">Editar</a></li>
    </ul>
    <div id="tab-1">
        @*el contenido de un tab normalmente es un div que tiene dentro una mini vista parcial con un formulario*@
        <div id="div_manperitosbuscar1">
            @Html.Partial("__ManPeritosBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_manperitosver1">
            @Html.Partial("__ManPeritosVer1")
        </div>
    </div>
    <div id="tab-3">
        <div id="div_manperitosnuevo1">
            @Html.Partial("__ManPeritosNuevo1")
        </div>
    </div>
    <div id="tab-4">
        <div id="div_manperitoseditar1">
            @Html.Partial("__ManPeritosEditar1")
        </div>
    </div>
</div>

<script type="text/javascript">
    //en esta seccion siempre vamos a instanciar y enlazar los viewmodels de todas las mini vistas parciales
    var vmmanperitosbuscar1 = new vmmanperitosbuscar1();
    ko.applyBindings(vmmanperitosbuscar1, $('#div_manperitosbuscar1')[0]);
    $(function () { 
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario buscar, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmmanperitosbuscar1.cargar();
    });
    //------------------------------------------------------------------------------------------
    //como el formulario ver no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmmanperitosver1 = new vmmanperitosver1();
    ko.applyBindings(vmmanperitosver1, $('#div_manperitosver1')[0]);
    //------------------------------------------------------------------------------------------
    var vmmanperitosnuevo1 = new vmmanperitosnuevo1();
    ko.applyBindings(vmmanperitosnuevo1, $('#div_manperitosnuevo1')[0]);
    $(function () {
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario nuevo, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmmanperitosnuevo1.cargar();
    });
    //-------------------------------------------------------------------------------------------
    //como el formulario editar no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmmanperitoseditar1 = new vmmanperitoseditar1();
    ko.applyBindings(vmmanperitoseditar1, $('#div_manperitoseditar1')[0]);
    
    $(function () {
        //al cargar la pagina se deshabilitan los tabs de ver, editar y perfil para ser habilitados en una 
        //accion posterior por demanda del usuario
        $("#tab_manperitos").tabs({ disabled: [1, 3] });

        //al hacer click en los tabs buscar y nuevo se deshabilitan los tabs ver, editar y perfil
        $(".tab-static").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });
    });
</script>