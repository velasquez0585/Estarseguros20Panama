@*siempre creamos un tab en la vista parcial, asi tenga una sola ficha, es importante que nos fijemos en la estructura del tab
para hacerlo siempre igual y bajo las mismas convenciones*@
<div id="tab_manversion" class="tab">
    <ul>
        @*aqui van los titulos de cada tab con la referencia de su contenido*@
        <li ><a href="#tab-1" class="tab-static">Buscar</a></li>
        <li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li ><a href="#tab-3"  class="tab-static">Nuevo</a></li>
        <li id="tab-editar"><a href="#tab-4">Editar</a></li>
    </ul>
    <div id="tab-1">
        @*el contenido de un tab normalmente es un div que tiene dentro una mini vista parcial con un formulario*@
        <div id="div_manversionbuscar1">
            @Html.Partial("__ManVersionBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_manversionver1">
            @Html.Partial("__ManVersionVer1")
        </div>
    </div>
    <div id="tab-3">
        <div id="div_manversionnuevo1">
            @Html.Partial("__ManVersionNuevo1")
        </div>
    </div>
    <div id="tab-4">
        <div id="div_manversioneditar1">
            @Html.Partial("__ManVersionEditar1")
        </div>
    </div>
</div>

<script type="text/javascript">
    //en esta seccion siempre vamos a instanciar y enlazar los viewmodels de todas las mini vistas parciales
    var vmmanversionbuscar1 = new vmmanversionbuscar1();
    ko.applyBindings(vmmanversionbuscar1, $('#div_manversionbuscar1')[0]);
    $(function () { 
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario buscar, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmmanversionbuscar1.cargar();
    });
    //------------------------------------------------------------------------------------------
    //como el formulario ver no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmmanversionver1 = new vmmanversionver1();
    ko.applyBindings(vmmanversionver1, $('#div_manversionver1')[0]);
    ////------------------------------------------------------------------------------------------

    //al vmmanversionnuevo1 se le pasa un parametro de true o false si deseea que se actualize el grid de consulta al agregar una version nueva
    var vmmanversionnuevo1 = new vmmanversionnuevo1(true);
    ko.applyBindings(vmmanversionnuevo1, $('#div_manversionnuevo1')[0]);
    $(function () {
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario nuevo, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmmanversionnuevo1.cargar();
    });
    //////-------------------------------------------------------------------------------------------
    //////como el formulario editar no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmmanversioneditar1 = new vmmanversioneditar1(true);
    ko.applyBindings(vmmanversioneditar1, $('#div_manversioneditar1')[0]);
    
    $(function () {
        //al cargar la pagina se deshabilitan los tabs de ver, editar y perfil para ser habilitados en una 
        //accion posterior por demanda del usuario
        $("#tab_manversion").tabs({ disabled: [1, 3] });

        //al hacer click en los tabs buscar y nuevo se deshabilitan los tabs ver, editar y perfil
        $(".tab-static").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });
    });
</script>