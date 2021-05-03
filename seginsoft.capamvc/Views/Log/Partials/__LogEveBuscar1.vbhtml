@*<fieldset>
    <legend>PAR&Aacute;METROS DE B&Uacute;SQUEDA</legend>


    <div class="form-column" data-bind="with: seglogeve">
        <div class="form-field-header">
            Fecha desde
        </div>
        <div class="form-field-content">
            <input placeholder="Ej: 01/01/2014" class="date-field" type="text" data-bind="value: flogeve" />
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
            <input placeholder="Ej: 01/01/2014" class="date-field" type="text" data-bind="value: fhasta" />
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

<fieldset>
    <legend>Lista de Eventos</legend>
  
    <div class="info-pagination" data-bind="with: pagseglogeve">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>

  <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_seglogeve().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th>Id</th>
                    <th>Datos</th>
                    <th>Fecha</th>                   
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_seglogeve'>
                <tr class="grid-row-content">
                    
                    <td>
                       <span data-bind='text: idseglogeve'></span>
                    </td>
                    <td>
                        <span data-bind='text: xdatoslogeve'></span>
                    </td>
                    <td>
                        <span data-bind='datehtml: flogeve'></span>
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
        <div class="no-grid-rows" data-bind='visible: lista_seglogeve().length == 0'>No existen Registros almacenados...</div>
    </div>

</fieldset>

<script type="text/javascript">

    function vmlogevebuscar1() {
        var self = this;
        self.seglogeve = new seglogeve(false);

        self.pagseglogeve = new paginacion(1, 10, 0, "it.idseglogeve", "DESC");
        self.lista_seglogeve = ko.observableArray();

        self.fdesde = ko.observable("");
        self.fhasta = ko.observable("");
   
        self.buscar = function () {
        //    if (self.fdesde() == "") {
        //        $(".noty_message").click();
        //        generar_noty_auto('<li style="color: red;">La fecha desde es requerida</li>', "warning");
        //        return false;
        //    }
        //    if (self.fhasta() == "") {
        //        $(".noty_message").click();
        //        generar_noty_auto('<li style="color: red;">La fecha hasta es requerida</li>', "warning");
        //        return false;
        //    }

        //    if (self.fdesde() == "" && self.fhasta() == "") {
        //        $(".noty_message").click();
        //        generar_noty_auto('<li style="color: red;">La fecha desde es requerida</li><li style="color: red;">La fecha hasta es requerida</li>', "warning");
        //        return false;
        //    }
        //}

        //postajaxjsonbasico("/Log/ObtenerLogEventos/", "{'fdesde':'" + self.fdesde() + "','fhasta':'" + self.fhasta() + "'}", function (respseglogerrpaglist) {
        postajaxjsonbasico("/Log/ObtenerLogEventos/", ko.toJSON(self), function (respseglogerrpaglist) {
                ko.mapping.fromJS(respseglogerrpaglist, {}, self);
            })
        }
              
        self.limpiar = function () {
            self.fdesde("");
            self.fhasta("");
            self.seglogeve.flogeve("");
        }


        self.ir_primero = function () {
            var npagactual = self.pagseglogeve.npagactual();
            if (npagactual != 1) {
                self.pagseglogeve.npagactual(1);
                self.buscar();
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagseglogeve.npagactual();
            if (npagactual != 1) {
                self.pagseglogeve.npagactual(self.pagseglogeve.npagactual() - 1);
                self.buscar();
            }
        }

        self.ir_siguiente = function () {
            if (self.pagseglogeve.npagactual() != self.pagseglogeve.npagcantidad()) {
                self.pagseglogeve.npagactual(self.pagseglogeve.npagactual() + 1);
                self.buscar();
            }
        }

        self.ir_ultimo = function () {
            if (self.pagseglogeve.npagactual() != self.pagseglogeve.npagcantidad()) {
                self.pagseglogeve.npagactual(self.pagseglogeve.npagcantidad);
                self.buscar();
            }
        }

    }

    vmlogevebuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_seglogeve;
        return copia;
    }

</script>