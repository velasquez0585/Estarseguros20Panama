<div id="tab_inspprecarga" class="tab">
    <ul>
        <li><a href="#tab-1">Nuevo</a></li>        
    </ul>
    <div id="tab-1">
        <div id="div_insprecargaintermagregar1">
            @Html.Partial("__InsPreCargaIntermAgregar1")
        </div>
    </div>   
</div>


<script type="text/javascript">    
    var vmInsPreCargaIntermAgregar1 = new vmInsPreCargaIntermAgregar1();
    ko.applyBindings(vmInsPreCargaIntermAgregar1, $('#div_insprecargaintermagregar1')[0]);
    $(function () {
        vmInsPreCargaIntermAgregar1.iniciar();
    });
   
</script>
