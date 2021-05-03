<fieldset class="form-area">
    <legend>Crear Baremo para Mano de Obra</legend>

    <div data-bind="with: vi_aipbaremobr">
        <ul id="lista_err_aipbaremobr1" class="no-display-validation-message">
           <li class="validation-message" data-bind="validationMessage: itipobaremobr"></li>
            <li class="validation-message" data-bind="validationMessage: itamapiezbaremobr"></li>
            <li class="validation-message" data-bind="validationMessage: imaterpiezbaremobr"></li>
        </ul>
         <div class="form-column">
            <div class="form-field-header">
                Repuesto
            </div>
            <div class="form-field-content">
            
                    <select   data-bind="options: combomanrepu, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipmanrepu"></select>
               
            </div>
        </div>
       
       
         
        <div id="excluiraipbaremobrbuscar1_1">
            <div class="form-column-button-left">
                <input type="button" value="Crear Baremo" data-bind="click: $root.crear" />
            </div>
            
        </div> 
    </div>
</fieldset>

<fieldset data-bind="with: vi_aipbaremobr" class="form-area">
    <legend>Mano de Obra</legend>     
    <div data-bind='foreach: combotipobaremobr'>
        <div data-bind="if: xvalorcodigo">
              <input type="checkbox"   data-bind="value: xvalorcodigo, click: $root.choselist" />
                    <label style="display: inline" data-bind="text: xvalorcodigo"></label>
        </div>        
    </div>     
</fieldset>


@**************************************************************************************@
@*SE COMENTA ESTE BLOQUE PARA QUITAR LA SELECCION DE MATERIAL Y TAMAÑO DE LA PIEZA*@

<fieldset data-bind="with: vi_aipbaremobr" class="form-area">
    <legend>Tamaño de Pieza</legend>     
    <div data-bind='foreach: combotamapiezbaremobr'>
        <div data-bind="if: xvalorcodigo">
              <input type="checkbox"   data-bind="value: xvalorcodigo, click: $root.choselist" />
                    <label style="display: inline" data-bind="text: xvalorcodigo"></label>
        </div>        
    </div>     
</fieldset>
@*<fieldset data-bind="with: vi_aipbaremobr" class="form-area">
    <legend>Material de Pieza</legend>     
    <div data-bind='foreach: combomaterpiezbaremobr'>
        <div data-bind="if: xvalorcodigo">
              <input type="checkbox"  data-bind="value: xvalorcodigo, click: $root.choselist" />
                    <label style="display: inline" data-bind="text: xvalorcodigo"></label>
        </div>        
    </div>     
</fieldset>*@
 
@**************************************************************************************@

<script type="text/javascript">
    function vmBareMobrModal1() {
        var self = this;
         
        self.vi_aipbaremobr = new vi_aipbaremobr(false);
        self.pagvi_aipbaremobr = new paginacion(1, 10, 0, "it.idaipbaremobr", "DESC");
        self.lista_vi_aipbaremobr = ko.observableArray();
        self.lista_baremobrmasivo = ko.observableArray();
        self.sel_idaipbaremobr = ko.observable(0);



        self.llenarcomborepuesto = function (idaipmanrepu) {
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivos/", "{}", function (lista_aipmanrepu) {
                self.vi_aipbaremobr.combomanrepu(lista_aipmanrepu);
                self.vi_aipbaremobr.idaipmanrepu(idaipmanrepu);
            })
        };
        self.llenarcombomanoobra = function () {
            var xconcepto = "ITIPOBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipbaremobr.combotipobaremobr(lista_comunconfvalor);
            })
        };
     
        self.llenarcombotamano = function () {
            var xconcepto = "ITAMAPIEZBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipbaremobr.combotamapiezbaremobr(lista_comunconfvalor);
            })
        };
        self.llenarcombopieza = function () {
            var xconcepto = "IMATERPIEZBAREMOBR";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipbaremobr.combomaterpiezbaremobr(lista_comunconfvalor);
            })
        };
        self.iniciar = function (idaipmanrepu,idaipbaremobr) {
            self.lista_vi_aipbaremobr = ko.observableArray();
            self.lista_baremobrmasivo = ko.observableArray();
            self.sel_idaipbaremobr = ko.observable(0);
            self.vi_aipbaremobr.idaipbaremobr(idaipbaremobr)
            self.llenarcombomanoobra();
            self.llenarcombotamano();
            self.llenarcombopieza();
            self.llenarcomborepuesto(idaipmanrepu);
        }

        self.crear = function () {
            //var baremobrmasivoo = new baremobrmasivo();                                 //SE ESTA PASANDO POR DEBAJO EL VALOR DE MEDIANA Y METAL
            //baremobrmasivoo.idaipbaremobr = (self.vi_aipbaremobr.idaipbaremobr());      //PARA OCULTAR LOS CHECHBOX DE SELECCION DE ESTOS VALORES.
            //baremobrmasivoo.xconcepto = ("ITAMAPIEZBAREMOBR");                          //LO QUE SE ESTA HACIENDO ES AGREGAR DE FORMA MANUAL
            //baremobrmasivoo.xvalorcodigo = ("MEDIANA");                                 //A LA LISTA LISTA_BAREMOBRMASIVO 2 OBJETOS CON LOS DATOS
            //self.lista_baremobrmasivo.push(baremobrmasivoo);                            //DE TAMAÑO Y MATERIAL POR DEFECTO (MEDIANA Y METAL)
            var baremobrmasivoo = new baremobrmasivo();                                   //MATERIAL
            baremobrmasivoo.idaipbaremobr = (self.vi_aipbaremobr.idaipbaremobr());
            baremobrmasivoo.xconcepto = ("IMATERPIEZBAREMOBR");
            baremobrmasivoo.xvalorcodigo = ("METAL");
            self.lista_baremobrmasivo.push(baremobrmasivoo);                            //FIN
            postajaxjsonbasico("/Baremo/CrearBaremoMobr/", ko.toJSON(self.lista_baremobrmasivo), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    $("#dlg_BareMobrModal1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

        self.choselist = function (obj) {
            var baremobrmasivoo =  new baremobrmasivo() ;
            baremobrmasivoo.idaipbaremobr = (self.vi_aipbaremobr.idaipbaremobr());
            baremobrmasivoo.xconcepto = (obj.xconcepto);
            baremobrmasivoo.xvalorcodigo = (obj.xvalorcodigo);
            var match = ko.utils.arrayFirst(self.lista_baremobrmasivo(), function (item) {
                return ((baremobrmasivoo.xconcepto === item.xconcepto) && (baremobrmasivoo.xvalorcodigo === item.xvalorcodigo));
            });

            if (!match) {
                self.lista_baremobrmasivo.push(baremobrmasivoo);
            }
             else
                self.lista_baremobrmasivo.remove(function (item) {
                    return (baremobrmasivoo.xconcepto === item.xconcepto) && (baremobrmasivoo.xvalorcodigo === item.xvalorcodigo)
                });
            return true;
        }
    }
</script>