<fieldset class="form-area" data-bind="with: aipmanvehmar">
    <legend>Buscar</legend>

    @*recordemos que cada vez que agreguemos parametros de busqueda nuevos debemos coordinar con el especialista de la web api
    para que configure el parametro nuevo, sino tendremos error en el query con los OrderBy y Skip*@
    <div class="form-column">
        <div class="form-field-header">
            <label>Nombre:</label>
            <div class="form-field-content">
                <input type="text" placeholder="Nombre de la marca" data-bind="value: xnommanvehmar" />
            </div>
        </div>
    </div>
    <div class="form-column">
        <div class="form-field-header">
            <label>Estado</label>
            <div class="form-field-content">                
                <select data-bind="options: comboestatmanvehmar, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatmanvehmar"></select>
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
    <legend>Lista de Marcas</legend>
    <div class="info-pagination" data-bind="with: pagaipmanvehmar">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_aipmanvehmar().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th></th>
                    <th>Nombre</th>
                    <th>Estatus</th>                    
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_aipmanvehmar'>
                <tr class="grid-row-content">
                    <td>
                        <a href='#' data-bind='click: $root.ver'>Ver</a>
                    </td>
                    <td>
                        <a href='#' data-bind='click: $root.editar'>Editar</a>
                    </td>
                    <td>
                        <span data-bind='text: xnommanvehmar' />
                    </td>
                    <td>
                        <span data-bind='text: iestatmanvehmar' />
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
        <div class="no-grid-rows" data-bind='visible: lista_aipmanvehmar().length == 0'>No existen registros para esta consulta</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmmanmarcabuscar1() {
        var self = this;
        self.aipmanvehmar = new aipmanvehmar(false);
        self.pagaipmanvehmar = new paginacion(1, 10, 0, "it.idaipmanvehmar", "DESC");
        self.lista_aipmanvehmar = ko.observableArray();
        

        self.cargar = function () {
            self.buscar();
            self.llenarcboestatus();
        }

        self.buscar = function (tipo) {
            //esto siempre lo evaluamos para cualquier busqueda con paginacion para poder distinguir si dicha busqueda la 
            //hacemos por movimiento de registros o por hacer click en buscar.
            //Si no es por movimiento de registros entonces volvemos a la pagina uno
            if (tipo != 'MOV') {
                self.pagaipmanvehmar.npagactual(1);
            }
            
            self.lista_aipmanvehmar("");
            postajaxjsonbasico("/Mantenimiento/ObtenerPorWhereDinamicoPagAipmanvehmar/", ko.toJSON(self), function (respaipmanvehmarpaglist) {
                ko.mapping.fromJS(respaipmanvehmarpaglist, {}, self);
            });
        }

        self.limpiar = function () {
            self.aipmanvehmar.xnommanvehmar("");
            
        }

        self.llenarcboestatus = function (iestatmanvehmar) {
            var xconcepto = "ISTATUSMARCA";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_cmnmanvalor) {
                self.aipmanvehmar.comboestatmanvehmar(lista_cmnmanvalor);
                self.aipmanvehmar.iestatmanvehmar(iestatmanvehmar);
            });
        }


        self.ver = function (obj) {
            //en este caso, aqui es donde activaremos el tab "ver"
            postajaxjsonbasico("/Mantenimiento/ObtenerPorIdMarca/?idaipmanvehmar=" + obj.idaipmanvehmar(), '{}', function (aipmanvehmar) {
                vmmanmarcaver1.cargar(aipmanvehmar);
                //al hacer click en "ver" habilitamos el tab "ver"
                $("#tab-ver").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "ver"
                $("#tab_manmarca").tabs("option", "active", 1);
            })
        }

        self.editar = function (obj) {
            //en este caso, aqui es donde activaremos el tab "editar"
            postajaxjsonbasico("/Mantenimiento/ObtenerPorIdMarca/?idaipmanvehmar=" + obj.idaipmanvehmar(), '{}', function (aipmanvehmar) {
                vmmanmarcaeditar1.cargar(aipmanvehmar);
                //al hacer click en "editar" habilitamos el tab "editar"
                $("#tab-editar").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "editar"
                $("#tab_manmarca").tabs("option", "active", 3);
            })
        }

        self.ir_primero = function () {
            var npagactual = self.pagaipmanvehmar.npagactual();
            if (npagactual != 1) {
                self.pagaipmanvehmar.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagaipmanvehmar.npagactual();
            if (npagactual != 1) {
                self.pagaipmanvehmar.npagactual(self.pagaipmanvehmar.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagaipmanvehmar.npagactual() != self.pagaipmanvehmar.npagcantidad()) {
                self.pagaipmanvehmar.npagactual(self.pagaipmanvehmar.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagaipmanvehmar.npagactual() != self.pagaipmanvehmar.npagcantidad()) {
                self.pagaipmanvehmar.npagactual(self.pagaipmanvehmar.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    //recordemos siempre excluir del viewmodel aquellos objetos que no deseamos enviar serializados con la funcion ko.toJSON()
    //con la finalidad de que la peticion no sea tan pesada y no estemos ocupando el ancho de banda innecesariamente
    vmmanmarcabuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_aipmanvehmar;        
        return copia;
    }
</script>
