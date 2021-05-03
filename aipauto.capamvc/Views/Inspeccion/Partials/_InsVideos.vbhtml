<div id="tab_Videos" class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
    </ul>
    <div id="tab-1">
        <div id="div_InsVideosBuscar1">
            @Html.Partial("__InsVideosBuscar1")
            
        </div>
    </div>
</div>

<script type="text/javascript">
    var vmInsVideosBuscar1 = new vmInsVideosBuscar1(false, false, true);
    ko.applyBindings(vmInsVideosBuscar1, $('#div_InsVideosBuscar1')[0]);

    $(function () {
        vmInsVideosBuscar1.iniciar();
    });
</script>
