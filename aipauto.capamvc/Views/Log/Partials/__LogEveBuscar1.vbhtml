<fieldset class="form-area">
    <legend>Log de Eventos</legend>

    <div data-bind="with: vi_aiplogeve">
        <ul id="lista_err_aiplogeve1" class="no-display-validation-message">
       @*     <li class="validation-message" data-bind="validationMessage: xnumpolizenc"></li>
            <li class="validation-message" data-bind="validationMessage: fprocpolizencdesde"></li>
            <li class="validation-message" data-bind="validationMessage: fprocpolizenchasta"></li>
      *@  </ul>

        <div class="form-column">
            <div class="form-field-header">
               Perito:
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: 883763" type="text" data-bind="value: xnombrecompleto" />
            </div>
        </div>
        <div class="form-column">
            <div class="form-field-header">
                Fecha creaci&oacute;n desde
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: 01/01/2000" class="date-field" type="text" data-bind="datevalue: $root.fdesde" />
            </div>
        </div>
        <div class="form-column">
            <div class="form-field-header">
                Fecha creaci&oacute;n hasta
            </div>
            <div class="form-field-content">
                <input placeholder="Ej: 01/01/2001" class="date-field" type="text" data-bind="datevalue: $root.fhasta" />
            </div>
        </div>
        <div class="form-column">
            <div class="form-field-header">
               Ambiente
            </div>
            <div class="form-field-content">
            
                    <select   data-bind="options: comboamblogeve, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iamblogeve"></select>
               
            </div>
        </div>

        
        <div id="excluiraiplogevebuscar1_1">
            <div class="form-column-button-left">
                <input type="button" value="Buscar" data-bind="click: $root.buscar" />
            </div>
            <div class="form-column-button">
                <input type="button" value="Limpiar" data-bind="click: $root.limpiar" />
            </div>
        </div> 
    </div>
</fieldset>

<fieldset class="form-area">
    <legend>Log de Eventos</legend>

    <div class="grid-top-buttons">
     @*   <div class="grid-top-button">
            <input type="button" value="Ver" data-bind="click: ir_ver, visible: boton_ver" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Agregar" data-bind="click: ir_agregar, visible: boton_agregar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Modificar" data-bind="click: ir_modificar, visible: boton_modificar" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Recibo" data-bind="click: ir_recibo" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Financiamiento" data-bind="click: ir_financiamiento" />
        </div>
        <div class="grid-top-button">
            <input type="button" value="Imprimir" data-bind="click: imprimir" />
        </div>*@
    </div>

    <div class="info-pagination" data-bind="with: pagvi_aiplogeve">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>

    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aiplogeve().length > 0'>
            <thead>
                <tr class="grid-row-header" data-bind="foreach: encabezados_vi_aiplogeve">
                    <td data-bind="click: $parent.ordenar_vi_aiplogeve, text: titulo"></td>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aiplogeve'>
                <tr class="grid-row-content">
                    
                    
                    <td style="width:50px"  >
                        <span style="width:100px" data-bind='text: xnombrecompleto' />
                    </td>
                    <td style="width:50px"  >
                        <span style="width:100px" data-bind='datetimehtml: fcrealogeve' />
                        
                    </td>
                    <td style="width:50px"  >
                        <span style="width:100px" data-bind='text: iamblogeve' />
                    </td>
                    <td style="width:50px"  >
                        <span style="width:50px" data-bind='text: xnomlogeve' />
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr class="grid-row-footer">
                    <td colspan="5">
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_aiplogeve().length == 0'>No existe log de eventos almacenados...</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmLogEvebuscar1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.vi_aiplogeve = new vi_aiplogeve(false);
        self.pagvi_aiplogeve = new paginacion(1, 10, 0, "it.idaiplogeve", "DESC");
        self.lista_vi_aiplogeve = ko.observableArray();
        self.sel_idaiplogeve = ko.observable(0);
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        self.fdesde = ko.observable("");
        self.fhasta = ko.observable("");

        self.encabezados_vi_aiplogeve = [            
            { titulo: 'Perito', campo: 'it.xnombrecompleto' },
            { titulo: 'Fecha/Hora', campo: 'it.fcrealogeve' },
            { titulo: 'Ambiente', campo: 'it.iamblogeve' },
            { titulo: 'Descripcion', campo: 'it.xnomlogeve' }
          
        ];

        self.llenarcomboambiente = function () {
            var xconcepto = "IAMBLOGEVE";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aiplogeve.comboamblogeve(lista_comunconfvalor);
            })
        }
        self.iniciar = function () {
            self.llenarcomboambiente();
            self.buscar();
        }
        self.buscar = function (tipo) {
            self.vi_aiplogeve.errors = ko.validation.group(self.vi_aiplogeve);

            var fdesde = self.FormatearFecha(self.fdesde());
            var fhasta = self.FormatearFecha(self.fhasta());


            
            if (tipo != 'MOV'){
                self.pagvi_aiplogeve.npagactual(1);
            }

            self.lista_vi_aiplogeve("");
            postajaxjsonbasico("/Log/ObtenerLogEventos?fdesde=" + fdesde + "&fhasta=" + fhasta, ko.toJSON(self), function (respvi_aiplogevepaglist) {
                ko.mapping.fromJS(respvi_aiplogevepaglist, {}, self);
            })
        }

        self.limpiar = function () {
            self.vi_aiplogeve.xnombrecompleto("");
            self.fdesde("");
            self.fhasta("");
            self.vi_aiplogeve.iamblogeve("");
        }

        self.ir_ver = function () {
            $("#tab_aiplogeve").tabs("option", "active", 1);
        }

        self.ir_agregar = function () {
            $("#tab_aiplogeve").tabs("option", "active", 2);
        }

        self.ir_modificar = function () {
            $("#tab_aiplogeve").tabs("option", "active", 3);
        }

        self.ir_recibo = function () {
            $("#tab_aiplogeve").tabs("option", "active", 4);
        }

        self.ir_financiamiento = function () {
            $("#tab_aiplogeve").tabs("option", "active", 5);
        }

      

        //self.seleccionar = function (obj) {
        //    self.sel_idaicpolizenc(obj.idaicpolizenc());
        //    postajaxjsonbasico("/Poliza/ObtenerPolizaPorId/", "{'idaicpolizenc':'" + obj.idaicpolizenc() + "'}", function (aicpolizenc) {
        //        vmaiplogevever1.cargar(aicpolizenc);
        //        vmaiplogevemodificar1.cargar(aicpolizenc);
        //        vmrecibpolizmodal2.cargar(aicpolizenc.idaicpolizenc, aicpolizenc.xnumpolizenc, aicpolizenc.fdesdepolizenc, aicpolizenc.fhastapolizenc);
        //        vmrecibfinanmodal1.cargar(aicpolizenc.idaicpolizenc, aicpolizenc.xnumpolizenc, aicpolizenc.fdesdepolizenc, aicpolizenc.fhastapolizenc);
        //        if (aicpolizenc.idaicmantercer > 0) {
        //            vmaiplogevemodificar1.ver_tercero();
        //            vmaiplogevever1.ver_tercero();
        //        }
        //        if (aicpolizenc.idaicmanciatom > 0) {
        //            vmaiplogevemodificar1.ver_cia();
        //            vmaiplogevever1.ver_cia();
        //        }               
                
        //    })
        //}

        self.FormatearFecha = function (date) {

            var fecha = "";

            if (date != "") {

                //verifica si existe la T esto es para formatear si la fecha viene desde base de datos y no fue modificada
                if (date.match('T')) {
                    var valueparts = date.split('T');
                    var fecha = moment(valueparts[0]).format('YYYY-MM-DD');

                } else {
                    //si no existe la T quiere decir que fue una fecha seleccionada por picker y ya deberia estar en forma dd/mm/yyyy
                    var split = date.split("/");
                    fecha = split[2] + "-" + split[1] + "-" + split[0];
                }
            }
            else {
                fecha = "1900/01/01"
            }
            return fecha;
        }

        self.ordenar_vi_aiplogeve = function (encabezado) {
            self.pagvi_aiplogeve.xcamposord(encabezado.campo);
            if (self.pagvi_aiplogeve.idirord() == 'ASC') {
                self.pagvi_aiplogeve.idirord('DESC');
            } else {
                self.pagvi_aiplogeve.idirord('ASC');
            }
            self.buscar();
        };

        self.ir_primero = function () {
            var npagactual = self.pagvi_aiplogeve.npagactual();
            if (npagactual != 1) {
                self.pagvi_aiplogeve.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aiplogeve.npagactual();
            if (npagactual != 1) {
                self.pagvi_aiplogeve.npagactual(self.pagvi_aiplogeve.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aiplogeve.npagactual() != self.pagvi_aiplogeve.npagcantidad()) {
                self.pagvi_aiplogeve.npagactual(self.pagvi_aiplogeve.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aiplogeve.npagactual() != self.pagvi_aiplogeve.npagcantidad()) {
                self.pagvi_aiplogeve.npagactual(self.pagvi_aiplogeve.npagcantidad);
                self.buscar('MOV');
            }
        }
    }

    vmLogEvebuscar1.prototype.toJSON = function () {
        var copia = ko.toJS(this);
        delete copia.encabezados_vi_aiplogeve;
        delete copia.fdesde;
        delete copia.fhasta;
        delete copia.lista_vi_aiplogeve;
        return copia;
    }
</script>