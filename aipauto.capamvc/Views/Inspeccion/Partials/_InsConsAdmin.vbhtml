 

<div id="tab_cons" class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>    
    </ul>
    <div id="tab-1">
        <div id="div_InsConsPtoBuscar1">
            @Html.Partial("__InsConsAdminBuscar1")
        </div>
    </div> 
    
</div>

<input hidden id="idsegmanperf" value='@CInt( Session("idsegmanperf"))' />
<script type="text/javascript">

    var vmInsConsAdminBuscar1 = new vmInsConsAdminBuscar1(true);
    ko.applyBindings(vmInsConsAdminBuscar1, $('#div_InsConsAdminBuscar1')[0]);

    $(function () {
        vmInsConsAdminBuscar1.iniciar();
    });

   </script>