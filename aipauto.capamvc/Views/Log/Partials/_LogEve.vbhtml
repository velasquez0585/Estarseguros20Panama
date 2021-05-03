 
<div id="tab_LogEve" class="tab">
    <ul>
        <li><a href="#tab-1">Buscar</a></li>
          
    </ul>
    <div id="tab-1">
        <div id="div_LogEvebuscar1">
            @Html.Partial("__LogEveBuscar1")
        </div>
    </div>
    
   
</div>

<script type="text/javascript">
    var vmLogEvebuscar1 = new vmLogEvebuscar1(true, true, true);
    ko.applyBindings(vmLogEvebuscar1, $('#div_LogEvebuscar1')[0]);



   
    $(function () {
        vmLogEvebuscar1.iniciar(); 
    });

  

   </script>