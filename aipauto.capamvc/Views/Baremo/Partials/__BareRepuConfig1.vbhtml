<fieldset class="form-area">
    <legend>Definicion de Repuestos</legend>

    <div data-bind="with: vi_aipbarerepu">
        <ul id="lista_err_aipbarerepu1" class="no-display-validation-message">
            <li class="validation-message" data-bind="validationMessage: faplibarerepu"></li>
          @*  <li class="validation-message" data-bind="validationMessage: fprocpolizencdesde"></li>
            <li class="validation-message" data-bind="validationMessage: fprocpolizenchasta"></li>
      *@  </ul>
      
         <div class="form-row">
                   <input type="radio" name="option" data-bind="click: $root.checkedbox1" value ="1">Ver Ultimo Baremo<br>
                    <input type="radio" name="option" data-bind="  click:$root.checkedbox2" value="2">Baremo Nuevo
         </div>
        <div data-bind="visible: $root.checkedOption"  class="form-row">
            <div class="form-field-header">
               Fecha desde la que aplica el baremo:
            </div>
            <div class="form-field-content">
                <input class="date-field" type="text" data-bind="datevalue: faplibarerepu" />
            </div>
        </div> 
        
    </div>
         
        <div id="excluiraipbarerepubuscar1_1">
            <div class="form-column-button-left">
                <input type="button" value="Aplicar" data-bind="click: Aplicar" />
            </div>
          
        </div> 
</fieldset>

<fieldset class="form-area">
    <legend>Configuracion de Baremo</legend>

     <div class="form-row">      <div class="grid-top-button">
            <input type="button" value="Actualizar" data-bind="click: actualizar, visible: lista_vi_aipbarerepu().length > 0" />
        </div>
    
    </div>
     <div class="form-row">
    <div class="info-pagination" data-bind="with: pagvi_aipbarerepu">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>

    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipbarerepu().length > 0'>
            <thead>
                <tr class="grid-row-header" data-bind="foreach: encabezados_vi_aipbarerepu">
                    <td data-bind="click: $parent.ordenar_vi_aipbarerepu, text: titulo"></td>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipbarerepu'>
                <tr class="grid-row-content">
                    <td>
            <input type="button" value="Crear" data-bind="click: $root.crear " />
            <input type="button" value="Eliminar" data-bind="click: $root.eliminar" /> 
                    </td>
                    <td>
                        <span data-bind='text: xnommanrepu' />
                    </td>
                 
                    <td>
                        <span data-bind='text: iorigbarerepu' />
                    </td>
                    <td  >
                        
                    <input  style="width:80%" type="text" data-bind="numeralvalue: mcostbarerepu" />  
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipbarerepu().length == 0'>No existe baremos repuestos almacenados...</div>
    </div></div>
</fieldset>

<script type="text/javascript">
    function vmBarerepuConfig1(boton_ver, boton_agregar, boton_modificar) {
        var self = this;
        self.vi_aipbarerepu = new vi_aipbarerepu(false);
        self.pagvi_aipbarerepu = new paginacion(1, 20, 0, "it.idaipbarerepu", "DESC");
        self.lista_vi_aipbarerepu = ko.observableArray();
        self.sel_idaipbarerepur = ko.observable(0);
        self.boton_ver = ko.observable(boton_ver);
        self.boton_agregar = ko.observable(boton_agregar);
        self.boton_modificar = ko.observable(boton_modificar);

        self.checkedOption = ko.observable(false);
        self.encabezados_vi_aipbarerepu = [
            { titulo: '', campo: '' },
            { titulo: 'Repuesto', campo: 'it.xnommanrepu' },
            { titulo: 'Origen', campo: 'it.iorigbarerepu' },
            { titulo: 'Monto', campo: 'it.mcostbarerepu' }
        ];
        self.buscar = function () {
            postajaxjsonbasico("/Baremo/VerUltimoBaremorepuPag/",ko.toJSON(self.pagvi_aipbarerepu)  , function (lista_vi_aipbarerepu) {
                ko.mapping.fromJS(lista_vi_aipbarerepu, {}, self);
            })
        }
        self.crear = function (obj) {
            vmBareRepuModal1.iniciar(obj.idaipmanrepu(),obj.idaipbarerepu());
            $("#dlg_BareRepuModal1").dialog("open");
            $("#dlg_BareRepuModal1").dialog({
                close: function (event, ui) {
                    self.buscar();
                }
            });
        }
        self.eliminar = function (obj) {
            postajaxjsonbasico("/Baremo/EliminarBaremoRepu/", "{'idaipbarerepu': '" + obj.idaipbarerepu() + "'}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.buscar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.actualizarnomessa = function () {
            postajaxjsonbasico("/Baremo/ActualizarBaremoRepuMasivo/", ko.toJSON(self.lista_vi_aipbarerepu()), function (respopera) {
                 
            })
        }
        self.actualizar = function () {
            postajaxjsonbasico("/Baremo/ActualizarBaremoRepuMasivo/", ko.toJSON(self.lista_vi_aipbarerepu()), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.buscar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        self.Aplicar = function () {
            var value = $('input[name="option"]:checked').val();
            if (value == 1) {
                self.buscar();
            }
            else if (value == 2) {
                if (self.vi_aipbarerepu.faplibarerepu().length <= 0) {
                    generar_noty_modal($('#lista_err_aipbarerepu1').html(), "warning");
                    return false;
                }
                 
                postajaxjsonbasico("/Baremo/CrearBaremorepuPred/", "{'faplibarerepu':'" + self.vi_aipbarerepu.faplibarerepu() + "'}", function (lista_vi_aipbarerepu) {
                    generar_noty("Registro Exitoso", "success");
                    ko.mapping.fromJS(lista_vi_aipbarerepu, {}, self.lista_vi_aipbarerepu);
                })
            }
        }


         

        self.ir_primero = function () {
            var npagactual = self.pagvi_aipbarerepu.npagactual();
            if (npagactual != 1) {
                self.actualizarnomessa();
                self.pagvi_aipbarerepu.npagactual(1);
                self.buscar('MOV');
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipbarerepu.npagactual();
            if (npagactual != 1) {
                self.actualizarnomessa();
                self.pagvi_aipbarerepu.npagactual(self.pagvi_aipbarerepu.npagactual() - 1);
                self.buscar('MOV');
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipbarerepu.npagactual() != self.pagvi_aipbarerepu.npagcantidad()) {

                self.actualizarnomessa();
                self.pagvi_aipbarerepu.npagactual(self.pagvi_aipbarerepu.npagactual() + 1);
                self.buscar('MOV');
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipbarerepu.npagactual() != self.pagvi_aipbarerepu.npagcantidad()) {

                self.actualizarnomessa();
                self.pagvi_aipbarerepu.npagactual(self.pagvi_aipbarerepu.npagcantidad);
                self.buscar('MOV');
            }
        }
        self.checkedbox1 = function () {
            self.checkedOption(false);
            return true;
        }
        self.checkedbox2 = function () {
            self.checkedOption(true);
            return true;
        }
        $(function () {
            var $radios = $('input:radio[name=option]');
            if ($radios.is(':checked') === false) {
                $radios.filter('[value=1]').prop('checked', true);
                self.buscar();
            }
        });
    }
</script>