<fieldset class="form-area" data-bind="with: vi_segusudetperf2">
    <legend>Buscar</legend>

    @*recordemos que cada vez que agreguemos parametros de busqueda nuevos debemos coordinar con el especialista de la web api
    para que configure el parametro nuevo, sino tendremos error en el query con los OrderBy y Skip*@
    <div class="form-column">
        <div class="form-field-header">
            <label>IMEI:</label>
            <div class="form-field-content">
                <input type="text" placeholder="Código IMEI" data-bind="value: xnombreusuario" />
            </div>
        </div>
    </div>
    <div class="form-column">
        <div class="form-field-header">
            <label>Correo Electronico</label>
            <div class="form-field-content">
                <input type="text" placeholder="Correo electronico" data-bind="value: xnombreusuario" />
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
    <legend>Lista de Peritos</legend>
    <div class="info-pagination" data-bind="with: pagvi_segusudetperf2">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_segusudetperf2().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th></th>
                    <th>Ced.Ident/R.U.C.</th>
                    <th>Nombre</th>
                    <th>Departamento</th>
                    <th>Cargo</th>
                    <th>Usuario</th>
                    <th>Perfil</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_segusudetperf2'>
                <tr class="grid-row-content">
                    <td>
                        <a href='#' data-bind='click: $root.ver'>Ver</a>
                    </td>
                    <td>
                        <a href='#' data-bind='click: $root.editar'>Editar</a>
                    </td>
                    <td>
                        <span data-bind='text: xcedula' />
                    </td>
                    <td>
                        <span data-bind='text: xnombrecompleto' />
                    </td>
                    <td>
                        <span data-bind='text: xnombredep' />
                    </td>
                    <td>
                        <span data-bind='text: xnombrecarg' />
                    </td>
                    <td>
                        <span data-bind='text: xnombreusuario' />
                    </td>
                     <td>
                        <span data-bind='text: xnombreperf' />
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_segusudetperf2().length == 0'>No existen regsitros para esta consulta</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmsegperitosbuscar1() {
        var self = this;
        self.vi_segusudetperf2 = new vi_segusudetperf2(false);
        self.pagvi_segusudetperf2 = new paginacion(1, 10, 0, "it.idsegmanusu", "DESC");
        self.lista_vi_segusudetperf2 = ko.observableArray();
        self.cboidsegmanperf = ko.observableArray();

        self.cargar = function () {
            self.buscar();
        }

        self.buscar = function (tipo) {
            //esto siempre lo evaluamos para cualquier busqueda con paginacion para poder distinguir si dicha busqueda la 
            //hacemos por movimiento de registros o por hacer click en buscar.
            //Si no es por movimiento de registros entonces volvemos a la pagina uno
            if (tipo != 'MOV') {
                self.pagvi_segusudetperf2.npagactual(1);
            }
            //self.vi_segusudetperf2.idsegmanperf(2);   //Para pasar como predeterminado el perfil de los peritos 
            self.lista_vi_segusudetperf2("");
            //se realiza la llamada para que busque solo los peritos
            postajaxjsonbasico("/Seguridad/ObtenerUsuariosPorTipo/?itipoaccion=PERITO", ko.toJSON(self), function (respvi_segusudetperf2paglist) {
                ko.mapping.fromJS(respvi_segusudetperf2paglist, {}, self);
            });
        }

        self.limpiar = function () {
            self.vi_segusudetperf2.idsegmanperf(0);
            self.vi_segusudetperf2.xnombreusuario("");
        }

        self.ver = function (obj) {
            //en este caso, aqui es donde activaremos el tab "ver"
            postajaxjsonbasico("/Seguridad/ObtenerPorIdViUsu/?idsegmanusu=" + obj.idsegmanusu(), '{}', function (vi_segmanusu) {
                vmsegperitosver1.cargar(vi_segmanusu);
                //al hacer click en "ver" habilitamos el tab "ver"
                $("#tab-ver").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "ver"
                $("#tab_segperitos").tabs("option", "active", 1);
            })
        }

        self.editar = function (obj) {
            //en este caso, aqui es donde activaremos el tab "editar"
            postajaxjsonbasico("/Seguridad/ObtenerPorIdViUsu/?idsegmanusu=" + obj.idsegmanusu(), '{}', function (vi_segmanusu) {
                vmsegperitoseditar1.cargar(vi_segmanusu);
                //al hacer click en "editar" habilitamos el tab "editar"
                $("#tab-editar").removeClass("ui-state-disabled");
                //ahora nos movemos hacia el tab "editar"
                $("#tab_segperitos").tabs("option", "active", 3);
            })
        }

        self.ir_primero = function () {
            var npagactual = self.pagvi_segusudetperf2.npagactual();
            if (npagactual != 1) {
                self.pagvi_segusudetperf2.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_segusudetperf2.npagactual();
            if (npagactual != 1) {
                self.pagvi_segusudetperf2.npagactual(self.pagvi_segusudetperf2.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_segusudetperf2.npagactual() != self.pagvi_segusudetperf2.npagcantidad()) {
                self.pagvi_segusudetperf2.npagactual(self.pagvi_segusudetperf2.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_segusudetperf2.npagactual() != self.pagvi_segusudetperf2.npagcantidad()) {
                self.pagvi_segusudetperf2.npagactual(self.pagvi_segusudetperf2.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    //recordemos siempre excluir del viewmodel aquellos objetos que no deseamos enviar serializados con la funcion ko.toJSON()
    //con la finalidad de que la peticion no sea tan pesada y no estemos ocupando el ancho de banda innecesariamente
    vmsegperitosbuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.lista_vi_segusudetperf2;
        delete copia.cboidsegmanperf;
        return copia;
    }
</script>
