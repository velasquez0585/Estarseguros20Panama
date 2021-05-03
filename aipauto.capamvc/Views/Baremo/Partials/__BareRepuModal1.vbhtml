<fieldset class="form-area">
    <legend>Crear Baremo para Mano de Obra</legend>

    <div data-bind="with: vi_aipbarerepu">
        <ul id="lista_err_aipbarerepu1" class="no-display-validation-message">
          <li class="validation-message" data-bind="validationMessage: iorigbarerepu"></li>
          @*    <li class="validation-message" data-bind="validationMessage: fprocpolizencdesde"></li>
            <li class="validation-message" data-bind="validationMessage: fprocpolizenchasta"></li>
      *@  </ul>
         <div class="form-column">
            <div class="form-field-header">
                Repuesto
            </div>
            <div class="form-field-content">
            
                    <select   data-bind="options: $root.combomanrepu, optionsText: 'xnommanrepu', optionsValue: 'idaipmanrepu', value: idaipmanrepu"></select>
               
            </div>
        </div>
       
       
         
        <div id="excluiraipbarerepubuscar1_1">
            <div class="form-column-button-left">
                <input type="button" value="Crear Baremo" data-bind="click: $root.crear" />
            </div>
            
        </div> 
    </div>
</fieldset>

<fieldset data-bind="with: vi_aipbarerepu" class="form-area">
    <legend>Origen</legend>     
    <div data-bind='foreach: comboorigbarerepu'>
        <div data-bind="if: xvalorcodigo">
              <input type="checkbox"   data-bind="value: xvalorcodigo, click: $root.choselist" />
                    <label style="display: inline" data-bind="text: xvalorcodigo"></label>
        </div>
        
    </div>
           @*<select   data-bind="options: comboestatmanrepu, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatmanrepu"></select>*@
   
</fieldset>

<script type="text/javascript">
    function vmBareRepuModal1() {
        var self = this;
        self.vi_aipbarerepu = new vi_aipbarerepu(false);
        self.pagvi_aipbarerepu = new paginacion(1, 10, 0, "it.idaipbarerepu", "DESC");
        self.lista_vi_aipbarerepu = ko.observableArray();
        self.sel_idaipbarerepu = ko.observable(0);
        self.lista_barerepumasivo = ko.observableArray();
        self.combomanrepu= ko.observableArray();

        self.llenarcomborepuesto = function (idaipmanrepu) { 
            postajaxjsonbasico("/Mantenimiento/ObtenerRepuestosActivos/", "{}", function (lista_aipmanrepu) {
                self.combomanrepu(lista_aipmanrepu);
                self.vi_aipbarerepu.idaipmanrepu(idaipmanrepu); 
            })
        }
        self.llenarcombopartes = function () {
            var xconcepto = "IORIGBAREREPU";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipbarerepu.comboorigbarerepu(lista_comunconfvalor);
            })
        }
        self.iniciar = function (idaipmanrepu, idaipbarerepu) {
            self.vi_aipbarerepu.idaipbarerepu = idaipbarerepu;
            self.llenarcombopartes();
            self.llenarcomborepuesto(idaipmanrepu);
             self.lista_vi_aipbarerepu = ko.observableArray();
            self.sel_idaipbarerepu = ko.observable(0);
            self.lista_barerepumasivo = ko.observableArray();

        }
        
        self.crear = function () {
           
            postajaxjsonbasico("/Baremo/CrearBaremoRepu/", ko.toJSON(self.lista_barerepumasivo), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");

                    $("#dlg_BareRepuModal1").dialog("close");
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }
        
        self.choselist = function (obj) {
            var barerepumasivoo = new barerepumasivo();
            barerepumasivoo.idaipbarerepu = (self.vi_aipbarerepu.idaipbarerepu);
            barerepumasivoo.xconcepto = (obj.xconcepto);
            barerepumasivoo.xvalorcodigo = (obj.xvalorcodigo);
            var match = ko.utils.arrayFirst(self.lista_barerepumasivo(), function (item) {
                return ((barerepumasivoo.xconcepto === item.xconcepto) && (barerepumasivoo.xvalorcodigo === item.xvalorcodigo));
            });

            if (!match) {
                self.lista_barerepumasivo.push(barerepumasivoo);
            }
            else
                self.lista_barerepumasivo.remove(function (item) {
                    return (barerepumasivoo.xconcepto === item.xconcepto) && (barerepumasivoo.xvalorcodigo === item.xvalorcodigo)
                });
            return true;
        }

         

        
        
    }
</script>