@*siempre creamos un tab en la vista parcial, asi tenga una sola ficha, es importante que nos fijemos en la estructura del tab
para hacerlo siempre igual y bajo las mismas convenciones*@
<div id="tab_manadminactividades" class="tab">
    <ul>
        @*aqui van los titulos de cada tab con la referencia de su contenido*@
        <li ><a href="#tab-1" class="tab-static">Buscar</a></li>
        @*<li id="tab-ver"><a href="#tab-2">Ver</a></li>
        <li ><a href="#tab-3"  class="tab-static">Nuevo</a></li>
        <li id="tab-editar"><a href="#tab-4">Editar</a></li>*@
    </ul>
    <div id="tab-1">
        @*el contenido de un tab normalmente es un div que tiene dentro una mini vista parcial con un formulario*@
        <div id="div_manadminactividadesbuscar1">
            @Html.Partial("__InsAdminActividadesBuscar1")
        </div>
    </div>
    
</div>

 <div id="dlg_insmodificarperitomodal1" class="dialognoauto" title="Peritos">
    @Html.Partial("__InsModificarPeritoModal1")
</div>

<div id="dlg_insmodificarauditormodal1" class="dialognoauto" title="Auditor">
    @Html.Partial("__InsModificarAuditorModal1")
</div>


<script type="text/javascript">
    //en esta seccion siempre vamos a instanciar y enlazar los viewmodels de todas las mini vistas parciales
    var vminsadminactividadesbuscar1 = new vminsadminactividadesbuscar1();
    ko.applyBindings(vminsadminactividadesbuscar1, $('#div_manadminactividadesbuscar1')[0]);
    $(function () { 
        //los metodos cargar de un viewmodel normalmente inicializan al mismo con alguna accion
        //en este caso, el formulario buscar, ejecuta un metodo "cargar" apenas es instanciado porque esta habilitado
        //al cargar la pagina y debe inicializar sus acciones y valores de uso
        vminsadminactividadesbuscar1.cargar();
    });

    //--------------------------------------------------------------------------------------------

    var vminsmodificarperitomodal1 = new vminsmodificarperitomodal1();
    ko.applyBindings(vminsmodificarperitomodal1, $('#dlg_insmodificarperitomodal1')[0]);


    
    //--------------------------------------------------------------------------------------------

    var vminsmodificarauditormodal1 = new vminsmodificarauditormodal1();
    ko.applyBindings(vminsmodificarauditormodal1, $('#dlg_insmodificarauditormodal1')[0]);


    
    $(function () {
        //al cargar la pagina se deshabilitan los tabs de ver, editar y perfil para ser habilitados en una 
        //accion posterior por demanda del usuario
        $("#tab_manadminactividades").tabs({ disabled: [1, 3] });

        //al hacer click en los tabs buscar y nuevo se deshabilitan los tabs ver, editar y perfil
        $(".tab-static").click(function () {
            $("#tab-ver, #tab-editar").addClass("ui-state-disabled");
        });
    });
</script>