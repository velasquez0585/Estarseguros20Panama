<fieldset class="form-area" data-bind="with: comunmanempr">
    <legend>Buscar</legend>

    @*recordemos que cada vez que agreguemos parametros de busqueda nuevos debemos coordinar con el especialista de la web api
    para que configure el parametro nuevo, sino tendremos error en el query con los OrderBy y Skip*@
    <div class="form-column">
        <div class="form-field-header">
            <label>Rif:</label>
            <div class="form-field-content">
                <input type="text" placeholder="Nombre de la version" data-bind="value: xrif" />
            </div>
        </div>
    </div>

    <div class="form-column">
        <div class="form-field-header">
            <label>Razón Social:</label>
            <div class="form-field-content">
                <input type="text" placeholder="Nombre de la version" data-bind="value: xrazonsocial" />
            </div>
        </div>
    </div>
    <div class="form-column">
        <div class="form-field-header">
            <label>Nombre Comercial:</label>
            <div class="form-field-content">
                <input type="text" placeholder="Nombre de la version" data-bind="value: xnombrecomercial" />
            </div>
        </div>
    </div>    
    <div class="form-column">
        <div class="form-column-button-left">
            <input type="button" value="Buscar" data-bind="click: $root.buscar" />
        </div>
        <div class="form-column-button">
            <input type="button" value="Limpiar" data-bind="click: $root.limpiar" />
        </div>
    </div>
</fieldset>

<fieldset class="form-area">
    <legend>Lista de Versi&oacute;n</legend>
    <div class="info-pagination" data-bind="with: pagcomunmanempr">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_comunmanempr().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th></th>
                    <th>R.I.F</th>
                    <th>Razón Social</th>
                    <th>Nombre Comercial</th>
                                   
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_comunmanempr'>
                <tr class="grid-row-content">
                    <td>
                        <a href='#' data-bind='click: $root.ver'>Ver</a>
                    </td>
                    <td>
                        <a href='#' data-bind='click: $root.editar'>Editar</a>
                    </td>                    
                    <td>
                        <span data-bind='text: xrif' />
                    </td>
                    <td>
                        <span data-bind='text: xrazonsocial' />
                    </td>
                    <td>
                        <span data-bind='text: xnombrecomercial' />
                    </td>                                      
                </tr>
            </tbody>
            <tfoot>
                <tr class="grid-row-footer">
                    <td colspan="6">
                        <div class="grid-bottom-buttons">
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Primero" data-bind="click: ir_primero" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Anterior" data-bind="click: ir_anterior" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Siguiente" data-bind="click: ir_siguiente" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" class="button small info" value="Ultimo" data-bind="click: ir_ultimo" />
                            </div>
                        </div>
                    </td>
                </tr>
            </tfoot>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_comunmanempr().length == 0'>No existen registros para esta consulta</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmmanversionbuscar1() {
        var self = this;
        self.aipmanvehver = new aipmanvehver(false);
        self.comunmanempr = new comunmanempr(false);
        self.pagcomunmanempr = new paginacion(1, 10, 0, "it.idcomunmanempr", "DESC");
        self.lista_comunmanempr = ko.observableArray();
        
        self.cargar = function () {
            self.buscar();
            
        }

        self.buscar = function (tipo) {
            //esto siempre lo evaluamos para cualquier busqueda con paginacion para poder distinguir si dicha busqueda la 
            //hacemos por movimiento de registros o por hacer click en buscar.
            //Si no es por movimiento de registros entonces volvemos a la pagina uno
            if (tipo != 'MOV') {
                self.pagcomunmanempr.npagactual(1);
            }
            
            self.lista_comunmanempr("");
            postajaxjsonbasico("/Mantenimiento/ObtenerPorWhereDinamicoPagcomunmanempr/", ko.toJSON(self), function (respcomunmanemprpaglist) {
                ko.mapping.fromJS(respcomunmanemprpaglist, {}, self);
            });
        }

        self.limpiar = function () {
            self.comunmanempr.xnommanvehver("");
            self.comunmanempr.idaipmanvehmar("");
            self.comunmanempr.idaipmanvehmod("");
            self.comunmanempr.iestatmanvehver("");

        }

        self.llenarcboestatus = function () {
            var xconcepto = "ISTATUSVER";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_cmnmanvalor) {
                self.comunmanempr.comboestatmanvehver(lista_cmnmanvalor);                
            });
        }


        self.ver = function (obj) {
            //en este caso, aqui es donde activaremos el tab "ver"
            postajaxjsonbasico("/Mantenimiento/ObtenerViaipmanvehverPorIdVersiones/?idaipmanvehver=" + obj.idaipmanvehver(), '{}', function (comunmanempr) {
                vmmanversionver1.cargar(comunmanempr);
                //al hacer click en "ver" habilitamos el tab "ver"
                $("#tab-ver").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "ver"
                $("#tab_manversion").tabs("option", "active", 1);
            })
        }

        self.editar = function (obj) {
            //en este caso, aqui es donde activaremos el tab "editar"
            postajaxjsonbasico("/Mantenimiento/ObtenerViaipmanvehverPorIdVersiones/?idaipmanvehver=" + obj.idaipmanvehver(), '{}', function (comunmanempr) {
                vmmanversioneditar1.cargar(comunmanempr);
                //al hacer click en "editar" habilitamos el tab "editar"
                $("#tab-editar").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "editar"
                $("#tab_manversion").tabs("option", "active", 3);
            })
        }

        self.ir_primero = function () {
            var npagactual = self.pagcomunmanempr.npagactual();
            if (npagactual != 1) {
                self.pagcomunmanempr.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagcomunmanempr.npagactual();
            if (npagactual != 1) {
                self.pagcomunmanempr.npagactual(self.pagcomunmanempr.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagcomunmanempr.npagactual() != self.pagcomunmanempr.npagcantidad()) {
                self.pagcomunmanempr.npagactual(self.pagcomunmanempr.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagcomunmanempr.npagactual() != self.pagcomunmanempr.npagcantidad()) {
                self.pagcomunmanempr.npagactual(self.pagcomunmanempr.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    //recordemos siempre excluir del viewmodel aquellos objetos que no deseamos enviar serializados con la funcion ko.toJSON()
    //con la finalidad de que la peticion no sea tan pesada y no estemos ocupando el ancho de banda innecesariamente
    vmmanversionbuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_comunmanempr;        
        return copia;
    }
</script>
