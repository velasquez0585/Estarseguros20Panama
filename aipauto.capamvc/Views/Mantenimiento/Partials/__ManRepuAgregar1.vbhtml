<fieldset style="width: 930px;">
    <legend>Agregar Repuesto</legend>
    <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: agregar_aipmanrepu" />
    </div>
    <div data-bind="with: aipmanrepu">
        <ul id="lista_err_aipmanrepuagregar1" style="display: none;">
            @*    <li data-bind="validationMessage: xnumcotizenc" style="color: red;"></li>
            <li data-bind="validationMessage: fdesdecobcotizenc" style="color: red;"></li>
            <li data-bind="validationMessage: fhastacobcotizenc" style="color: red;"></li>*@
        </ul>
        <div class="form-row">
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
                    <input type="checkbox" data-bind="checked: ipartextdelmanrepu" />
                    <label style="display: inline">Externa Delantera</label>
                    <input type="checkbox" data-bind="checked: ipartextmedmanrepu" />
                    <label style="display: inline">Externa Media</label>
                    <input type="checkbox" data-bind="checked: ipartexttrasmanrepu" />
                    <label style="display: inline">Externa Trasera</label>
                    <input type="checkbox" data-bind="checked: ipartintmanrepu" />
                    <label style="display: inline">Interna</label>
                </div>

            </fieldset>
            <fieldset style="width: 730px;">
                <legend>Posicion</legend>

                <div class="form-column">
                    <input type="checkbox" data-bind="checked: iposdermanrepu" />
                    <label style="display: inline">Derecha</label>
                    <input type="checkbox" data-bind="checked: iposfronmanrepu" />
                    <label style="display: inline">Frontal</label>
                    <input type="checkbox" data-bind="checked: iposizqmanrepu" />
                    <label style="display: inline">Izquierda</label>
                </div>

            </fieldset>
        </div>
        <div class="form-row">
            <textarea data-bind="text: xdescmanrepu" />
        </div>


        
    </div>
    <div class="form-row">
            <textarea data-bind="value: xdescmanrepu" rows='5' cols='60'></textarea>
    </div>
   <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: $root.agregar_aipmanrepu" />
    </div>
</fieldset>


<script type="text/javascript">
    function vmManRepuagregar1() {
        var self = this;
        self.aipmanrepu = new aipmanrepu(true);

        self.ver_boton_guardar = ko.observable(false);
        self.ver_fieldset_botones = ko.observable(false);
      
        self.limpiar = function () {
            self.aipmanrepu.idaipmanrepu(0); 
            self.aipmanrepu.xnommanrepu("");
            self.aipmanrepu.ipartextdelmanrepu(false);
            self.aipmanrepu.ipartextmedmanrepu(false);
            self.aipmanrepu.ipartexttrasmanrepu(false);
            self.aipmanrepu.ipartintmanrepu(false);
            self.aipmanrepu.iposdermanrepu(false);
            self.aipmanrepu.iposfronmanrepu(false);
            self.aipmanrepu.iposizqmanrepu(false);
        }

        self.iniciar = function () { 

        }


        self.agregar_aipmanrepu = function () {

            self.aipmanrepu.errors = ko.validation.group(self.aipmanrepu);
            if (self.aipmanrepu.errors().length > 0) {
                generar_noty($('#lista_err_mandocagregar1').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/AgregarRepuesto/", ko.toJSON(self), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success"); 
                     self.limpiar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })

        }



    }
</script>
