<fieldset style="width: 930px;">
    <legend>Modificar Repuesto</legend>
    <div class="form-row">
        <input type="button" value="Modificar" data-bind="click: modificar_aipmanrepu" />
    </div>
    <div data-bind="with: aipmanrepu">
        <ul id="lista_err_aipmanrepumodificar1" style="display: none;">
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
                <div class="form-field-header">
                    <label>Estatus</label>
                </div>
                <div class="form-field-content">
                       <select   data-bind="options: comboestatmanrepu, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatmanrepu"></select>
              </div>
            </div>
        <div class="form-row">
            <textarea data-bind="value: xdescmanrepu" rows='5' cols='60'></textarea>
        </div>



    </div>
    <div class="form-row">
        <input type="button" value="Modificar" data-bind="click: modificar_aipmanrepu" />
    </div>
</fieldset>


<script type="text/javascript">
    function vmManRepumodificar1() {
        var self = this;
        self.aipmanrepu = new aipmanrepu(true);

        self.ver_boton_guardar = ko.observable(false);
        self.ver_fieldset_botones = ko.observable(false);



        self.iniciar = function () {

            self.llenarcomboestatus();
        }

        self.llenarcomboestatus = function () {
            var xconcepto = "IESTATMANREPU";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.aipmanrepu.comboestatmanrepu(lista_comunconfvalor);
            })
        }
        self.modificar_aipmanrepu = function () {

            self.aipmanrepu.errors = ko.validation.group(self.aipmanrepu);
            if (self.aipmanrepu.errors().length > 0) {
                generar_noty($('#lista_err_mandocmodificar1').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/modificarRepuesto/", ko.toJSON(self), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success"); 
                    self.aipmanrepu.idaipmanrepu(respopera.id);
                    vmManRepubuscar1.buscar();
                    $("#tab_ManRepu").tabs("option", "active", 0);
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })

        }
        self.cargar = function (aipmanrepu) {
            self.iniciar();
            ko.mapping.fromJS(aipmanrepu, {}, self.aipmanrepu);
        }


    }
</script>
