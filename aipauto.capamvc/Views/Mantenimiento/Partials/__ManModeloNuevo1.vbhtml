<fieldset class="form-area" data-bind="with: aipmanvehmod">
    <legend>Datos del modelo</legend>

    <ul id="lista_err_modelonuevo1" style="display: none;">
        <li data-bind="validationMessage: idaipmanvehmar" style="color: red;"></li>
        <li data-bind="validationMessage: xnommanvehmod" style="color: red;"></li>

    </ul>

    <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: $root.agregar" />
    </div>

     <div class="form-row">
        <div class="form-field-header">
            Marca
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar"></select>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Modelo
        </div>
        <div class="form-field-content">            
            <input type="text"  data-bind="value: xnommanvehmod"/>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Descripción
        </div>
        <div class="form-field-content">
            <textarea cols="50" rows="4"  data-bind="value: xdescmanvehmod"></textarea>                
        </div>
    </div> 
        
    <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: $root.agregar" />
    </div>
</fieldset>


<script type="text/javascript">
    function vmmanmodelonuevo1() {
        var self = this;

        self.aipmanvehmod = new aipmanvehmod(true);
        self.combomanvehmar = ko.observableArray();

        self.cargar = function () {
            self.limpiar();
            self.llenarcbomarcas();
        }

        self.limpiar = function () {
            self.aipmanvehmod.idaipmanvehmar(0);
            self.aipmanvehmod.idaipmanvehmod(0);            
            self.aipmanvehmod.xdescmanvehmod("");
            self.aipmanvehmod.iestatmanvehmod("");            
        }

        self.llenarcbomarcas = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboMarcas/", "{}", function (lista_aipmanvehmar) {
                self.combomanvehmar(lista_aipmanvehmar);
            });
        }

        self.agregar = function () {
            //este bloque me sirve para activar los errores que se generen de la validacion del formulario configurada en los
            //viewmodels de knockout
            if (self.aipmanvehmod.idaipmanvehmar() == 0) {
                generar_noty_modal("<li style='color: red;'>La marca es requerida.</li>", "warning");
                return false;
            }
            self.aipmanvehmod.errors = ko.validation.group(self.aipmanvehmod);
            if (self.aipmanvehmod.errors().length > 0) {
                generar_noty_modal($('#lista_err_modelonuevo1').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/AgregarModelo/", ko.toJSON(self.aipmanvehmod), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    vmmanmodelobuscar1.buscar();
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
    }
</script>
