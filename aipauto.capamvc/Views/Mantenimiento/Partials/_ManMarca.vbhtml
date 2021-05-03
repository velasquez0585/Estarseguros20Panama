@*siempre creamos un tab en la vista parcial, asi tenga una sola ficha, es importante que nos fijemos en la estructura del tab
para hacerlo siempre igual y bajo las mismas convenciones*@
<div id="tab_manmarca" class="tab">
    <ul>
        @*aqui van los titulos de cada tab con la referencia de su contenido*@
        <li ><a href="#tab-1" class="tab-static">Buscar</a></li>
        <li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li ><a href="#tab-3"  class="tab-static">Nuevo</a></li>
        <li id="tab-editar"><a href="#tab-4">Editar</a></li>
    </ul>
    <div id="tab-1">
        @*el contenido de un tab normalmente es un div que tiene dentro una mini vista parcial con un formulario*@
        <div id="div_manmarcabuscar1">
            @Html.Partial("__ManMarcaBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_manmarcaver1">
            @Html.Partial("__ManMarcaVer1")
        </div>
    </div>
    <div id="tab-3">
        <div id="div_manmarcanuevo1">
            @Html.Partial("__ManMarcaNuevo1")
        </div>
    </div>
    <div id="tab-4">
        <div id="div_manmarcaeditar1">
            @Html.Partial("__ManMarcaEditar1")
        </div>
    </div>
</div>

<script type="text/javascript">
    //en esta seccion siempre vamos a instanciar y enlazar los viewmodels de todas las mini vistas parciales
    var vmmanmarcabuscar1 = new vmmanmarcabuscar1();
    ko.applyBindings(vmmanmarcabuscar1, $('#div_manmarcabuscar1')[0]);
    $(function () { 
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario buscar, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmmanmarcabuscar1.cargar();
    });
    //------------------------------------------------------------------------------------------
    //como el formulario ver no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmmanmarcaver1 = new vmmanmarcaver1();
    ko.applyBindings(vmmanmarcaver1, $('#div_manmarcaver1')[0]);
    //------------------------------------------------------------------------------------------
    var vmmanmarcanuevo1 = new vmmanmarcanuevo1();
    ko.applyBindings(vmmanmarcanuevo1, $('#div_manmarcanuevo1')[0]);
    $(function () {
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario nuevo, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vmmanmarcanuevo1.cargar();
    });
    //-------------------------------------------------------------------------------------------
    //como el formulario editar no esta habilitado desde que carga la pagina no se ejecuta su metodo cargar
    var vmmanmarcaeditar1 = new vmmanmarcaeditar1();
    ko.applyBindings(vmmanmarcaeditar1, $('#div_manmarcaeditar1')[0]);
    
    $(function () {
        //al cargar la pagina se deshabilitan los tabs de ver, editar y perfil para ser habilitados en una 
        //accion posterior por demanda del usuario
        $("#tab_manmarca").tabs({ disabled: [1, 3] });

        //al hacer click en los tabs buscar y nuevo se deshabilitan los tabs ver, editar y perfil
        $(".tab-static").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });
    });
</script>