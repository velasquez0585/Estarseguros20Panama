<div id="tab_inspinter" class="tab">
    <ul>
        <li><a href="#tab-1">Inspecciones</a></li>
        <li id="tab-pen"><a href="#tab-2">Pendientes</a></li>
        <li id="tab-asig"><a href="#tab-3">Asignadas</a></li>
        @*<li><a href="#tab-4">Nuevo</a></li>*@
    </ul>
    <div id="tab-1">
        <div id="div_InsIntermBuscar1">
            @Html.Partial("__InsIntermBuscar1")
        </div>
    </div>

    <div id="tab-2">
        <div id="div_InsIntermPendBuscar1">
            @Html.Partial("__InsIntermPendBuscar1")
        </div>
    </div>

    <div id="tab-3">
        <div id="div_InsIntermAsigBuscar1">
            @Html.Partial("__InsIntermAsigBuscar1")
        </div>
    </div>

    @*<div id="tab-4">
        <div id="div_InsIntermAgregar1">
            @Html.Partial("__InsIntermAgregar1")
        </div>
    </div>*@  
</div>


<script type="text/javascript">    
    var vmInsIntermBuscar1 = new vmInsIntermBuscar1(true, true, true);
    ko.applyBindings(vmInsIntermBuscar1, $('#div_InsIntermBuscar1')[0]);
    $(function () {
        vmInsIntermBuscar1.iniciar();
    });

    var vmInsIntermPendBuscar1 = new vmInsIntermPendBuscar1();
    ko.applyBindings(vmInsIntermPendBuscar1, $('#div_InsIntermPendBuscar1')[0]);

    var vmInsIntermAsigBuscar1 = new vmInsIntermAsigBuscar1();
    ko.applyBindings(vmInsIntermAsigBuscar1, $('#div_InsIntermAsigBuscar1')[0]);

    //var vmInsIntermAgregar1 = new vmInsIntermAgregar1(true, true, true);
    //ko.applyBindings(vmInsIntermAgregar1, $('#div_InsIntermAgregar1')[0]);
    //$(function () {
    //    vmInsIntermAgregar1.cargar();
    //});

    $(function () {
        //al cargar la pagina se deshabilitan los tabs de pendiente
        //accion posterior por demanda del usuario
        $("#tab_inspinter").tabs({ disabled: [1, 2] });

        //al hacer click en los tabs buscar y nuevo se deshabilitan los tabs pendiente
        $(".tab-static").click(function () {
            $("#tab-pen, #tab-asig").addClass("ui-state-disabled");
        });
    });

</script>
