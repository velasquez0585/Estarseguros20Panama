<fieldset class="form-area">
    <legend>Definicion de Baremo</legend>

    <div data-bind="with: vi_aipbaremobr">
        <ul id="lista_err_aipbaremobr1" class="no-display-validation-message">
            <li class="validation-message" data-bind="validationMessage: faplibaremobr"></li>
          @*  <li class="validation-message" data-bind="validationMessage: fprocpolizencdesde"></li>
            <li class="validation-message" data-bind="validationMessage: fprocpolizenchasta"></li>
      *@  </ul>
      
         <div class="form-row">
                   <input type="radio" name="option1"  data-bind="  click: $root.checkedbox1" value="1">Ver Ultimo Baremo<br>
                    <input type="radio" id="nuevo"  data-bind="  click: $root.checkedbox2"  name="option1" value="2">Baremo Nuevo
         </div>
        <div data-bind="visible: $root.checkedOption" class="form-row">
            <div  class="form-field-header">
               Fecha desde la que aplica el baremo:
            </div>
            <div class="form-field-content">
                <input class="date-field" type="text" data-bind="datevalue: faplibaremobr" />
            </div>
        </div> 
        
    </div>
         
        <div id="excluiraipbaremobrbuscar1_1">
            <div class="form-column-button-left">
                <input type="button" value="Aplicar" data-bind="click: Aplicar" />
            </div>
          
        </div> 
</fieldset>

<fieldset class="form-area">
    <legend>Configuracion de Baremo</legend>

    <div class="form-row">
         <div class="grid-top-button">
            <input type="button" value="Actualizar" data-bind="click: actualizar, visible: lista_vi_aipbaremobr().length > 0" />
        </div>
    
    </div>
    
    <div class="form-row">
    <div class="info-pagination" data-bind="with: pagvi_aipbaremobr">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>

    <div class="grid-area">
       <table class="grid-table" data-bind='visible: lista_vi_aipbaremobr().length > 0'>
             <thead>
                <tr class="grid-row-header" data-bind="foreach: encabezados_vi_aipbaremobr">
                    <td data-bind="click: $parent.ordenar_vi_aipbaremobr, text: titulo"></td>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipbaremobr'>
                <tr class="grid-row-content">
                    <td>
                          <input type="button" value="Crear" data-bind="click: $root.crear " />
            <input type="button" value="Eliminar" data-bind="click: $root.eliminar" /> 
        
                    </td>
                    <td>
                        <span data-bind='text: xnommanrepu' />
                    </td>
                    <td>
                        <span data-bind='text: itipobaremobr' />
                    </td>
@*                    <td>
                        <span data-bind='text: imaterpiezbaremobr' />
                    </td>*@
                    <td>
                        <span data-bind='text: itamapiezbaremobr' />
                    </td>
                    <td>
                      
                    <input style="width:80%"   type="text" data-bind="numeralvalue: mcostbaremobr" />    
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipbaremobr().length == 0'>No existe baremos almacenados...</div>
    </div>
        </div>
</fieldset>

<script type="text/javascript">
    function vmBareMobrConfig1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.vi_aipbaremobr = new vi_aipbaremobr(false);
        self.pagvi_aipbaremobr = new paginacion(1, 20, 0, "it.idaipbaremobr", "DESC");
        self.lista_vi_aipbaremobr = ko.observableArray();
        self.sel_idaipbaremobr = ko.observable(0);
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);
        self.checkedOption = ko.observable(false);
        self.encabezados_vi_aipbaremobr = [
            { titulo: '', campo: '' },
            { titulo: 'Repuesto', campo: 'it.xnommanrepu' },
            { titulo: 'Mano de Obra', campo: 'it.itipobaremobr' },
            { titulo: 'Tamaño pieza', campo: 'it.imaterpiezbaremobr' },
            //{ titulo: 'Material Pieza', campo: 'it.itamapiezbaremobr' },
        { titulo: 'Costo', campo: 'it.mcostbaremobr' }
        ];
        self.buscar = function () {
            postajaxjsonbasico("/Baremo/VerUltimoBaremoMobrPag/",ko.toJSON(self.pagvi_aipbaremobr) , function (lista_vi_aipbaremobr) {
                ko.mapping.fromJS(lista_vi_aipbaremobr, {},   self);
            })
        }
       
        self.crear = function (obj) {
            vmBareMobrModal1.iniciar(obj.idaipmanrepu(), obj.idaipbaremobr());
            $("#dlg_BareMobrModal1").dialog("open");
            $("#dlg_BareMobrModal1").dialog({
                close: function (event, ui) {
                    self.buscar();
                }
            });
        }
        self.eliminar = function (obj) {
            postajaxjsonbasico("/Baremo/EliminarBaremoMobr/", "{'idaipbaremobr': '" + obj.idaipbaremobr() + "'}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.buscar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.actualizarnomessa = function () {
            postajaxjsonbasico("/Baremo/ActualizarBaremoMobrMasivo/", ko.toJSON(self.lista_vi_aipbaremobr()), function (respopera) {
                 
            })
        }
        self.actualizar = function () {
            postajaxjsonbasico("/Baremo/ActualizarBaremoMobrMasivo/", ko.toJSON(self.lista_vi_aipbaremobr()), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.buscar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.Aplicar = function () {
            var value = $('input[name="option1"]:checked').val();
            if (value == 1) {
                self.buscar();
            }
            else if(value == 2)
            {
                self.vi_aipbaremobr.errors = ko.validation.group(self.vi_aipbaremobr);
                if (self.vi_aipbaremobr.faplibaremobr().length <= 0) {
                    generar_noty_modal($('#lista_err_aipbaremobr1').html(), "warning");
                    return false;
                }
                postajaxjsonbasico("/Baremo/CrearBaremoMobrPred/", "{'faplibaremobr':'" + self.vi_aipbaremobr.faplibaremobr() + "'}", function (lista_vi_aipbaremobr) {
                    ko.mapping.fromJS(lista_vi_aipbaremobr, {}, self.lista_vi_aipbaremobr);
                    generar_noty("Registro Exitoso", "success");

                })
            }
        }

      
 
        self.ordenar_vi_aipbaremobr = function (encabezado) {
            self.pagvi_aipbaremobr.xcamposord(encabezado.campo);
            if (self.pagvi_aipbaremobr.idirord() == 'ASC') {
                self.pagvi_aipbaremobr.idirord('DESC');
            } else {
                self.pagvi_aipbaremobr.idirord('ASC');
            }
            self.buscar();
        };

        self.ir_primero = function () {
            var npagactual = self.pagvi_aipbaremobr.npagactual();
            if (npagactual != 1) {
                self.actualizarnomessa();
                self.pagvi_aipbaremobr.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
           
            var npagactual = self.pagvi_aipbaremobr.npagactual();
            if (npagactual != 1) {
                self.actualizarnomessa();
                self.pagvi_aipbaremobr.npagactual(self.pagvi_aipbaremobr.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {

            if (self.pagvi_aipbaremobr.npagactual() != self.pagvi_aipbaremobr.npagcantidad()) {

                self.actualizarnomessa();
                self.pagvi_aipbaremobr.npagactual(self.pagvi_aipbaremobr.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipbaremobr.npagactual() != self.pagvi_aipbaremobr.npagcantidad()) {
                self.actualizarnomessa();
                self.pagvi_aipbaremobr.npagactual(self.pagvi_aipbaremobr.npagcantidad);
                self.buscar('MOV');
            }
        }
        self.checkedbox1 = function  () {
            self.checkedOption(false);
            return true;
        }
        self.checkedbox2 = function () {
            self.checkedOption(true);
            return true;
        }
        $(function () {
            var $radios = $('input:radio[name=option1]');
            if ($radios.is(':checked') === false) {
                $radios.filter('[value=1]').prop('checked', true);
                self.buscar();
            }
        });
    }
</script>