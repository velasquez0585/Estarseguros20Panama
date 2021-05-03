@*<fieldset class="form-area">
    <legend>PAR&Aacute;METROS DE B&Uacute;SQUEDA</legend>

    <div class="form-column" data-bind="with: seglogerr">
        <div class="form-field-header">
            Fecha desde
        </div>
        <div class="form-field-content">
            <input placeholder="Ej: 01/01/2014" class="date-field" type="text" data-bind="value: flogerr" />
        </div>
    </div>
      
    <div class="form-column">
        <div class="form-field-header">
            Fecha desde
        </div>
        <div class="form-field-content">
            <input placeholder="Ej: 01/01/2014" class="date-field" type="text" data-bind="value: fdesde" />
        </div>
    </div>

    <div class="form-column">
        <div class="form-field-header">
            Fecha Hasta
        </div>
        <div class="form-field-content">
            <input placeholder="Ej: 01/02/2014" class="date-field" type="text" data-bind="value: fhasta" />
        </div>
    </div>

   <div>
        <div class="form-column-button-left">
            <input type="button" value="Buscar" data-bind="click: buscar" />
        </div>
        <div class="form-column-button">
            <input type="button" value="Limpiar" data-bind="click: limpiar" />
        </div>
    </div>
</fieldset>*@

<fieldset class="form-area">
    <legend>Lista de Errores</legend>
  
    <div class="info-pagination" data-bind="with: pagseglogerr">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>

  <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_seglogerr().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th>Id</th>
                    <th>Fecha</th>
                    <th>Datos</th>
                    <th>Mensaje</th>
                    <th>Exsource</th>
                    
                </tr>
            </thead>
       
            <tbody data-bind='foreach: lista_seglogerr'>
                <tr class="grid-row-content">
                    
                    <td>
                       <span data-bind='text: idseglogerr'></span>
                    </td>
                    <td>
                        <span data-bind='datehtml: flogerr'></span>
                    </td>
                    <td>
                        <span data-bind='text: xdatoslogerr'></span>
                    </td>
                    <td>
                       <span data-bind='text: xexmessage'></span>
                    </td>
                    <td>
                       <span data-bind='text: xexsource'></span>
                    </td>                   
                </tr>
            </tbody>
            <tfoot>
                <tr class="grid-row-footer">
                    <td colspan="6">
                        <div class="grid-bottom-buttons">
                            <div class="grid-bottom-button">
                                <input type="button" value="Primero" data-bind="click: ir_primero" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" value="Anterior" data-bind="click: ir_anterior" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" value="Siguiente" data-bind="click: ir_siguiente" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" value="Ultimo" data-bind="click: ir_ultimo" />
                            </div>
                        </div>
                    </td>
                </tr>
            </tfoot>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_seglogerr().length == 0'>No existen Registros almacenados...</div>
    </div>

</fieldset>

<script type="text/javascript">

    function vmlogerrbuscar1() {
        var self = this;
        self.seglogerr = new seglogerr(false);

        self.pagseglogerr = new paginacion(1, 10, 0, "it.idseglogerr", "DESC");
        self.lista_seglogerr = ko.observableArray();

        self.fdesde = ko.observable("").extend({
            required: {
                message: "Fecha desde es requerida.",
                params: true
            }
        });
        self.fhasta = ko.observable("").extend({
            required: {
                message: "Fecha Hasta es requerida.",
                params: true
            }
        });
        
      
        self.buscar = function () {
            
            //if (self.fdesde() == "") {
            //    $(".noty_message").click();
            //    generar_noty_auto('<li style="color: red;">La fecha desde es requerida</li>', "warning");
            //    return false;
            //}
            //if (self.fhasta() == "") {
            //    $(".noty_message").click();
            //    generar_noty_auto('<li style="color: red;">La fecha hasta es requerida</li>', "warning");
            //    return false;
            //}

            //if (self.fdesde() == "" && self.fhasta() == "") {
            //    $(".noty_message").click();
            //    generar_noty_auto('<li style="color: red;">La fecha desde es requerida</li><li style="color: red;">La fecha hasta es requerida</li>', "warning");
            //    return false;
            //}


            
            //postajaxjsonbasico("/Log/ObtenerLogErrores/", "{'fdesde':'" + self.fdesde() + "','fhasta':'" + self.fhasta() + "'}", function (respseglogerrpaglist) {
            postajaxjsonbasico("/Log/ObtenerLogErrores/", ko.toJSON(self), function (respseglogerrpaglist) {
                ko.mapping.fromJS(respseglogerrpaglist, {}, self);
            })
        }
              
        self.limpiar = function () {
            self.fdesde("");
            self.fhasta("");
            self.seglogerr.flogerr("");
        }
        
        self.ir_primero = function () {
            var npagactual = self.pagseglogerr.npagactual();
            if (npagactual != 1) {
                self.pagseglogerr.npagactual(1);
                self.buscar();
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagseglogerr.npagactual();
            if (npagactual != 1) {
                self.pagseglogerr.npagactual(self.pagseglogerr.npagactual() - 1);
                self.buscar();
            }
        }

        self.ir_siguiente = function () {
            if (self.pagseglogerr.npagactual() != self.pagseglogerr.npagcantidad()) {
                self.pagseglogerr.npagactual(self.pagseglogerr.npagactual() + 1);
                self.buscar();
            }
        }

        self.ir_ultimo = function () {
            if (self.pagseglogerr.npagactual() != self.pagseglogerr.npagcantidad()) {
                self.pagseglogerr.npagactual(self.pagseglogerr.npagcantidad);
                self.buscar();
            }
        }

    }

    vmlogerrbuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_seglogerr;
        return copia;
    }

</script>