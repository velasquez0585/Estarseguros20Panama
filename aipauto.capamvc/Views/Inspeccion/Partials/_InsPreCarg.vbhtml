<div id="tab_inspinter" class="tab">
    <ul>
        <li><a href="#tab-1">Crear</a></li>
    </ul>
    <div id="tab-1">
        <div id="div_InsIntermAgregar1">
            @Html.Partial("__InsIntermAgregar1")
        </div>
    </div>
</div>


<script type="text/javascript">    
    var vmInsIntermAgregar1 = new vmInsIntermAgregar1(true, true, true);
    ko.applyBindings(vmInsIntermAgregar1, $('#div_InsIntermAgregar1')[0]);
    $(function () {
        vmInsIntermAgregar1.cargar();
    });
</script>
