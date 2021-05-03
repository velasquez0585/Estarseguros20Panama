<fieldset class="form-area" data-bind="with: vi_aipmanvehmod">
    <legend>Buscar</legend>

    @*recordemos que cada vez que agreguemos parametros de busqueda nuevos debemos coordinar con el especialista de la web api
    para que configure el parametro nuevo, sino tendremos error en el query con los OrderBy y Skip*@

    <div class="form-column">
        <div class="form-field-header">
            <label>Marca:</label>
            <div class="form-field-content">
                <select data-bind="options: $root.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar"></select>
            </div>
        </div>
    </div>
    <div class="form-column">
        <div class="form-field-header">
            <label>Nombre:</label>
            <div class="form-field-content">
                <input type="text" placeholder="Nombre del modelo" data-bind="value: xnommanvehmod" />
            </div>
        </div>
    </div>
    <div class="form-column">
        <div class="form-field-header">
            <label>Estado</label>
            <div class="form-field-content">                
                <select data-bind="options: comboestatmanvehmod, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatmanvehmod"></select>
            </div>
        </div>
    </div>

    <div class="form-row">
        <div class="form-column-button-left">
            <input type="button" value="Buscar" data-bind="click: $root.buscar" />
        </div>
        <div class="form-column-button">
            <input type="button" value="Limpiar" data-bind="click: $root.limpiar" />
        </div>
    </div>
</fieldset>

<fieldset class="form-area">
    <legend>Lista de Modelos</legend>
    <div class="info-pagination" data-bind="with: pagvi_aipmanvehmod">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipmanvehmod().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th></th>
                    <th>Marca</th>
                    <th>Modelo</th>
                    <th>Estatus</th>                    
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipmanvehmod'>
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
                        <span data-bind='text: xnommanvehmod' />
                    </td>
                    <td>
                        <span data-bind='text: iestatmanvehmod' />
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipmanvehmod().length == 0'>No existen registros para esta consulta</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmmanmodelobuscar1() {
        var self = this;
        self.aipmanvehmod = new aipmanvehmod(false);
        self.vi_aipmanvehmod = new vi_aipmanvehmod(false);
        self.pagvi_aipmanvehmod = new paginacion(1, 10, 0, "it.idaipmanvehmod", "DESC");
        self.lista_vi_aipmanvehmod = ko.observableArray();
        self.combomanvehmar = ko.observableArray();
        
        self.cargar = function () {
            self.buscar();
            self.llenarcboestatus();
            self.llenarcbomarcas();
        }

        self.buscar = function (tipo) {
            //esto siempre lo evaluamos para cualquier busqueda con paginacion para poder distinguir si dicha busqueda la 
            //hacemos por movimiento de registros o por hacer click en buscar.
            //Si no es por movimiento de registros entonces volvemos a la pagina uno
            if (tipo != 'MOV') {
                self.pagvi_aipmanvehmod.npagactual(1);
            }
            
            self.lista_vi_aipmanvehmod("");
            postajaxjsonbasico("/Mantenimiento/ObtenerPorWhereDinamicoPagvi_aipmanvehmod/", ko.toJSON(self), function (respvi_aipmanvehmodpaglist) {
                ko.mapping.fromJS(respvi_aipmanvehmodpaglist, {}, self);
            });
        }

        self.limpiar = function () {
            self.vi_aipmanvehmod.xnommanvehmod("");
            self.vi_aipmanvehmod.idaipmanvehmar(0);
            self.vi_aipmanvehmod.iestatmanvehmod("");             
        }

        self.llenarcbomarcas = function () {            
            postajaxjsonbasico("/Mantenimiento/ObtenerComboMarcas/", "{}", function (lista_aipmanvehmar) {
                self.combomanvehmar(lista_aipmanvehmar);
            });
        }


        self.llenarcboestatus = function () {
            var xconcepto = "ISTATUSMODELO";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_cmnmanvalor) {
                self.vi_aipmanvehmod.comboestatmanvehmod(lista_cmnmanvalor);                
            });
        }


        self.ver = function (obj) {
            //en este caso, aqui es donde activaremos el tab "ver"
            postajaxjsonbasico("/Mantenimiento/ObtenerPorIdModelo/?idaipmanvehmod=" + obj.idaipmanvehmod(), '{}', function (aipmanvehmod) {
                vmmanmodelover1.cargar(aipmanvehmod);
                //al hacer click en "ver" habilitamos el tab "ver"
                $("#tab-ver").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "ver"
                $("#tab_manmodelo").tabs("option", "active", 1);
            })
        }

        self.editar = function (obj) {
            //en este caso, aqui es donde activaremos el tab "editar"
            postajaxjsonbasico("/Mantenimiento/ObtenerPorIdModelo/?idaipmanvehmod=" + obj.idaipmanvehmod(), '{}', function (aipmanvehmod) {
                vmmanmodeloeditar1.cargar(aipmanvehmod);
                //al hacer click en "editar" habilitamos el tab "editar"
                $("#tab-editar").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "editar"
                $("#tab_manmodelo").tabs("option", "active", 3);
            })
        }

        self.ir_primero = function () {
            var npagactual = self.pagvi_aipmanvehmod.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipmanvehmod.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipmanvehmod.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipmanvehmod.npagactual(self.pagvi_aipmanvehmod.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipmanvehmod.npagactual() != self.pagvi_aipmanvehmod.npagcantidad()) {
                self.pagvi_aipmanvehmod.npagactual(self.pagvi_aipmanvehmod.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipmanvehmod.npagactual() != self.pagvi_aipmanvehmod.npagcantidad()) {
                self.pagvi_aipmanvehmod.npagactual(self.pagvi_aipmanvehmod.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    //recordemos siempre excluir del viewmodel aquellos objetos que no deseamos enviar serializados con la funcion ko.toJSON()
    //con la finalidad de que la peticion no sea tan pesada y no estemos ocupando el ancho de banda innecesariamente
    vmmanmodelobuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_vi_aipmanvehmod;
        delete copia.combomanvehmar;
        return copia;
    }
</script>
