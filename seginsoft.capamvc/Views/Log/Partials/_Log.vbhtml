<div class="tab ui-tabs ui-widget ui-widget-content ui-corner-all">
    <ul>
        <li><a href="#tab-1">Log Errores</a></li>
        <li><a href="#tab-2">Log Eventos</a></li>
        <li><a href="#tab-3">Log Registros</a></li>        
    </ul>
    <div id="tab-1">
        <div id="div_logerrbuscar1">
            @Html.Partial("__LogErrBuscar1")
        </div>
    </div>
    <div id="tab-2">
        <div id="div_logevebuscar1">
            @Html.Partial("__LogEveBuscar1")
        </div>
    </div>
    <div id="tab-3"> 
        <div id="div_logregbuscar1">
            @Html.Partial("__LogRegBuscar1")   
        </div>
    </div>    
</div>

<script type="text/javascript">

    //-----------------------------------------------------------------------------------------

    var vmlogerrbuscar1 = new vmlogerrbuscar1();
    ko.applyBindings(vmlogerrbuscar1, $('#div_logerrbuscar1')[0]);

    $(function () {
        vmlogerrbuscar1.buscar();
    });
       
    ////-----------------------------------------------------------------------------------------
    var vmlogevebuscar1 = new vmlogevebuscar1();
    ko.applyBindings(vmlogevebuscar1, $('#div_logevebuscar1')[0]);

    $(function () {
        vmlogevebuscar1.buscar();
    });
    ////-----------------------------------------------------------------------------------------

    var vmlogregbuscar1 = new vmlogregbuscar1();
    ko.applyBindings(vmlogregbuscar1, $('#div_logregbuscar1')[0]);
       
    $(function () {
        vmlogregbuscar1.buscar();
    });
    //-----------------------------------------------------------------------------------------
      
</script>