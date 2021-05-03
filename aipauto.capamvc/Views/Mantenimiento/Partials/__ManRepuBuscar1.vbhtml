<fieldset style="width: 930px;">
    <legend>Par&aacute;metros de B&uacute;squeda</legend>

    
    <div data-bind="with: vi_aipmanrepu">
        <ul id="list_err_manrapubuscar1" style="display: none;">
            @*<li data-bind="validationMessage: xnumcotizenc" style="color: red;"></li>
            <li data-bind="validationMessage: fdesdecobcotizenc" style="color: red;"></li>
            <li data-bind="validationMessage: fhastacobcotizenc" style="color: red;"></li>*@
        </ul>

            <div class="form-column">
                <div class="form-field-header">
                    <label>Id:</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: 123" type="text" data-bind="numeralvalue: idaipmanrepu" />
                </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    <label>Estatus</label>
                </div>
                <div class="form-field-content">
                       <select   data-bind="options: comboestatmanrepu, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatmanrepu"></select>
              </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    <label>Repuesto</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: repuesto" type="text" data-bind="value: xnommanrepu" />
                </div>
                
            </div>
          <div class="form-row">
              
<fieldset style="width: 730px;">
    <legend>Partes</legend>
        
                <div class="form-column">
                   <input type="checkbox" data-bind="checked: ipartextdelmanrepu" /> <label style="display:inline">Externa Delantera</label>
                   <input type="checkbox" data-bind="checked: ipartextmedmanrepu" /> <label style="display:inline">Externa Media</label>
                   <input type="checkbox" data-bind="checked: ipartexttrasmanrepu" /> <label style="display:inline">Externa Trasera</label>
                   <input type="checkbox" data-bind="checked: ipartintmanrepu" /> <label style="display:inline">Interna</label> 
</div>
                       
</fieldset>
   <fieldset style="width: 730px;">
    <legend>Posicion</legend>
        
                <div class="form-column">
                   <input type="checkbox" data-bind="checked: iposdermanrepu" /> <label style="display:inline">Derecha</label>
                   <input type="checkbox" data-bind="checked: iposfronmanrepu" /> <label style="display:inline">Frontal</label>
                   <input type="checkbox" data-bind="checked: iposizqmanrepu" /> <label style="display:inline">Izquierda</label> 
</div>
                       
</fieldset>     
    </div>
    
</div> 
        <div class="form-column-button-left">
                <input type="button" value="Buscar" data-bind="click: buscar" />
                <input type="button" value="Limpiar" data-bind="click: limpiar" />
        </div>
</fieldset>

<fieldset style="width: 930px;">
    <legend>Lista de Repuestos</legend>
    <div class="grid-top-buttons">
        <div class="grid-top-button">
            <input type="button" value="Ver" data-bind="click: ir_ver, visible: boton_ver" />
        </div> 
        <div class="grid-top-button">
            <input type="button" value="Agregar" data-bind="click: ir_agregar, visible: boton_agregar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Modificar" data-bind="click: ir_modificar, visible: boton_modificar" />
        </div>
    </div>
    
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipmanrepu().length > 0' cellspacing="10">
            <thead>
                <tr class="grid-row-header">
                    <th></th> 
                    <th>Id</th>
                    <th>Repuesto</th>
                    <th>Estatus</th> 
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipmanrepu'>
                <tr  data-bind="attr: { 'class': xclass() }">
                    <td>
                        <a href='#' data-bind='click: $root.cargar_ver'>Seleccionar</a>
                    </td> 
                    <td>
                        <span data-bind='text: idaipmanrepu' />
                    </td>
                    <td>
                        <span data-bind='text: xnommanrepu' />
                    </td>                    
                    <td>
                        <span data-bind='text: iestatmanrepu' />
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr class="grid-row-footer">
                    <td colspan="5">
                        <div class="grid-bottom-buttons">
                            <div class="grid-bottom-button">
                                @*<a href='#' data-bind='click: ir_primero_cotiza_indiv, visible: npagactual() > 1'>Primero</a>*@
                                <input type="button" value="Primero" data-bind="click: ir_primero" />
                            </div>
                            <div class="grid-bottom-button">
                                @*<a href='#' data-bind='click: ir_anterior_cotiza_indiv, visible: npagactual() > 1'>Anterior</a>*@
                                <input type="button" value="Anterior" data-bind="click: ir_anterior" />
                            </div>
                            <div class="grid-bottom-button">
                                @*<a href='#' data-bind='click: ir_siguiente_cotiza_indiv, visible: npagactual() < npagcantidad'>Siguiente</a>enable: vm1.npagactual() < npagcantidad()*@
                                <input type="button" value="Siguiente" data-bind="click: ir_siguiente" />
                            </div>
                            <div class="grid-bottom-button">
                                @*<a href='#' data-bind='click: ir_ultimo_cotiza_indiv, visible: npagactual() < npagcantidad'>Ultimo</a>*@
                                <input type="button" value="Ultimo" data-bind="click: ir_ultimo" />
                            </div>
                            <div class="info-pagination-noclear" data-bind="with: pagvi_aipmanrepu">
                                <span>P&aacute;gina </span>
                                <span data-bind='text: npagactual'></span>
                                <span>de </span>
                                <span data-bind='text: npagcantidad'></span>
                            </div>
                        </div>
                    </td>
                </tr>
            </tfoot>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipmanrepu().length == 0'>No existen repuestos almacenados...</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmManRepubuscar1(boton_ver, boton_agregar, boton_modificar, modal_aceptar) {
        var self = this;
        self.vi_aipmanrepu = new vi_aipmanrepu(false);
        self.pagvi_aipmanrepu = new paginacion(1, 10, 0, "it.idaipmanrepu", "DESC");
        self.lista_vi_aipmanrepu = ko.observableArray();
        self.sel_idaipmanrepu = ko.observable(0);
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        self.modal_aceptar = ko.observable(modal_aceptar);

        self.sel_vi_aipmanrepu = new vi_aipmanrepu(false);
        self.row_vi_aipmanrepu = new vi_aipmanrepu(false);
        self.llenarcomboestatus = function () {
            var xconcepto = "IESTATMANREPU";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipmanrepu.comboestatmanrepu(lista_comunconfvalor);
            })
        }
        
        self.limpiar = function()
        {
            self.vi_aipmanrepu.idaipmanrepu(0);
            self.vi_aipmanrepu.xnommanrepu("");
            self.vi_aipmanrepu.ipartextdelmanrepu(0);
            self.vi_aipmanrepu.ipartextmedmanrepu(0);
            self.vi_aipmanrepu.ipartexttrasmanrepu(0);
            self.vi_aipmanrepu.ipartintmanrepu(0);
            self.vi_aipmanrepu.iposdermanrepu(0);
            self.vi_aipmanrepu.iposizqmanrepu(0);
            self.vi_aipmanrepu.iposfronmanrepu(0);
            self.vi_aipmanrepu.xdescmanrepu("");
            self.vi_aipmanrepu.iestatmanrepu("");
            self.vi_aipmanrepu.idseglogreg(0);
            self.buscar();
        }
        self.buscar = function (tipo) {
            self.vi_aipmanrepu.errors = ko.validation.group(self.vi_aipmanrepu);
            if (self.vi_aipmanrepu.errors().length > 0) {
                generar_noty($('#list_err_manrapubuscar1').html(), "warning");
                return false;
            }

            if (tipo != 'MOV') {
                self.pagvi_aipmanrepu.npagactual(1);
            }

            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestos/", ko.toJSON(self), function (respvi_aipmanrepupaglist) {
                self.lista_vi_aipmanrepu("");
                respvi_aipmanrepupaglist.lista_vi_aipmanrepu.forEach(function (e) {
                    e.xclass = ko.observable("");
                });
                ko.mapping.fromJS(respvi_aipmanrepupaglist, {}, self);
               
            })
        }
        self.iniciar = function () {
            self.llenarcomboestatus(); 
            self.buscar();
        }


        self.ir_ver = function () {
            $("#tab_ManRepu").tabs("option", "active", 1);
        }

        self.ir_agregar = function () {
            $("#tab_ManRepu").tabs("option", "active", 2);
        }

        self.ir_modificar = function () {
            $("#tab_ManRepu").tabs("option", "active", 3);
        }


        self.cargar_ver = function (obj) {
            self.row_vi_aipmanrepu.xclass("grid-row-content");//por defecto antes de cambiar el color al anterior le pone el que es para no seleccionado
            obj.xclass("grid-row-contentselec");// al seleccionado le cambia el color
            self.row_vi_aipmanrepu = obj; // el seleccionado lo asigna al objeto row para saber luego cual tenia  selecionado
            self.sel_idaipmanrepu(obj.idaipmanrepu());
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestoPorId/", "{'idaipmanrepu':'" + obj.idaipmanrepu() + "'}", function (aipmanrepu) {
                vmManRepuver1.cargar(aipmanrepu);
                vmManRepumodificar1.cargar(aipmanrepu);
                //vmcitapaccerrar1.cargar(aipmanrepu);

            })
        }

        self.cargar_editar = function (obj) {
            self.sel_idaipmanrepu(obj.idaipmanrepu());
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestoPorId/", "{'idaipmanrepu':'" + obj.idaipmanrepu() + "'}", function (aipmanrepu) {
                //vmcitapacver1.cargar(aipmanrepu);
               // vmcitapacmodificar1.cargar(aipmanrepu);
                //vmcitapaccerrar1.cargar(aipmanrepu);

            })
        }

        self.cargar_cerrar = function (obj) {
            self.sel_idaipmanrepu(obj.idaipmanrepu());
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestoPorId/", "{'idaipmanrepu':'" + obj.idaipmanrepu() + "'}", function (aipmanrepu) {
                //vmcitapacver1.cargar(aipmanrepu);
                //vmcitapacmodificar1.cargar(aipmanrepu);
                vmcitapaccerrar1.cargar(aipmanrepu);

            })
        }



        self.ir_primero = function () {
            var npagactual = self.pagvi_aipmanrepu.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipmanrepu.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipmanrepu.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipmanrepu.npagactual(self.pagvi_aipmanrepu.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipmanrepu.npagactual() != self.pagvi_aipmanrepu.npagcantidad()) {
                self.pagvi_aipmanrepu.npagactual(self.pagvi_aipmanrepu.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipmanrepu.npagactual() != self.pagvi_aipmanrepu.npagcantidad()) {
                self.pagvi_aipmanrepu.npagactual(self.pagvi_aipmanrepu.npagcantidad);
                self.buscar('MOV');
            }
        }
    }
</script>
