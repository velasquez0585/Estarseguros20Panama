<fieldset>
    <legend>Aplicaciones</legend>

    <div data-bind="with: vi_segappprog">
        <ul id="lista_err_manappmodificar1" style="display: none;">
            <li data-bind="validationMessage: idsegmanapp" style="color: red;"></li>
            <li data-bind="validationMessage: idsegmanmod" style="color: red;"></li>
            <li data-bind="validationMessage: idsegmansubmod" style="color: red;"></li>
            <li data-bind="validationMessage: idsegmanprog" style="color: red;"></li>
            <li data-bind="validationMessage: xdirurl" style="color: red;"></li>
        </ul>
    </div>

    <div class="form-row">
        <input style="width: 100px;" type="button" value="Modificar" data-bind="click: modificar" />      
    </div>

    <div data-bind="with: vi_segappprog">

          <div class="form-row">
            <div class="form-field-header">
                <label>Aplicaci&oacute;n</label>
            </div>
            <div class="form-field-content">
                <div class="form-column">
                    <select data-bind="options: comboaplicacion, optionsText: 'xnombrecorto', optionsValue: 'idsegmanapp', value: idsegmanapp"></select>
                </div>
                <div class="form-column">
                    <input type="button" value="+" data-bind="click: $root.agregar_app" />
                </div>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Modulo</label>
            </div>
            <div class="form-field-content">
                <div class="form-column">
                    <select  data-bind="options: combomodulo, optionsText: 'xnombrecorto', optionsValue: 'idsegmanmod', value: idsegmanmod"></select>
                </div>
                <div class="form-column">
                    <input type="button" value="+" data-bind="click: $root.agregar_mod" />
                </div>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Submodulo</label>
            </div>
            <div class="form-field-content">
                <div class="form-column">
                    <select data-bind="options: combosubmodulo, optionsText: 'xnombrecorto', optionsValue: 'idsegmansubmod', value: idsegmansubmod"></select>
                </div>
                <div class="form-column">
                    <input type="button" value="+" data-bind="click: $root.agregar_submod" />
                </div>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Programa</label>
            </div>
            <div class="form-field-content">
                <div class="form-column">
                    <select  data-bind="options: comboprograma, optionsText: 'xnombrecorto', optionsValue: 'idsegmanprog', value: idsegmanprog"></select>
                </div>
                <div class="form-column">
                    <input type="button" value="+" data-bind="click: $root.agregar_prog" />
                </div>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Ruta</label>
            </div>
            <div class="form-field-content">
                <div class="form-column">
                    <input placeholder="Ej: /Reportes/Reportes?esvistaparcial=false" style="width: 500px;" type="text" data-bind="value: xdirurl" />
                </div>                
            </div>
        </div>
        

    </div>
    
    <div class="form-row">
        <input style="width: 100px;" type="button" value="Modificar" data-bind="click: modificar" />      
    </div>
</fieldset>

<script type="text/javascript">

    function vmmanappmodificar1() {

        var self = this;

        self.vi_segappprog = new vi_segappprog(true);

        self.cargar = function (vi_segappprog) {
            ko.mapping.fromJS(vi_segappprog, {}, self.vi_segappprog);

            self.llenarcomboaplicacion(vi_segappprog.idsegmanapp);
            self.llenarcombomodulo(vi_segappprog.idsegmanmod);
            self.llenarcombosubmodulo(vi_segappprog.idsegmansubmod);
            self.llenarcomboprograma(vi_segappprog.idsegmanprog);
        }

        self.llenarcomboaplicacion = function (idsegmanapp) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboAplicaciones/", "{}", function (lista_segmanapp) {
                self.vi_segappprog.comboaplicacion(lista_segmanapp);
                self.vi_segappprog.idsegmanapp(idsegmanapp);                
            });
        }

        self.llenarcombomodulo = function (idsegmanmod) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboModulo/", "{}", function (lista_segmanmod) {
                self.vi_segappprog.combomodulo(lista_segmanmod);
                self.vi_segappprog.idsegmanmod(idsegmanmod);
            });
        }

        self.llenarcombosubmodulo = function (idsegmansubmod) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboSubModulo/", "{}", function (lista_segmansubmod) {
                self.vi_segappprog.combosubmodulo(lista_segmansubmod);
                self.vi_segappprog.idsegmansubmod(idsegmansubmod);
            });
        }

        self.llenarcomboprograma = function (idsegmanprog) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboPrograma/", "{}", function (lista_segmanprog) {
                self.vi_segappprog.comboprograma(lista_segmanprog);
                self.vi_segappprog.idsegmanprog(idsegmanprog);
            });
        }

        self.modificar = function () {
            self.vi_segappprog.errors = ko.validation.group(self.vi_segappprog);
            if (self.vi_segappprog.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_err_manappmodificar1').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/ModificarConfiguracionPrograma/", ko.toJSON(self.vi_segappprog), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    vmmanappbuscar1.buscar();                    
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
                              
            })
        }

        self.agregar_app = function () {

            $("#dialog-app").dialog("open");
            $("#dialog-app").dialog({
                close: function (event, ui) {
                    self.llenarcomboaplicacion(self.vi_segappprog.idsegmanapp());
                    vmmanappconfigurar1.llenarcomboaplicacion();
                }
            });
        }

        self.agregar_mod = function () {

            $("#dialog-mod").dialog("open");
            $("#dialog-mod").dialog({
                close: function (event, ui) {
                    self.llenarcombomodulo(self.vi_segappprog.idsegmanmod());
                }
            });
        }

        self.agregar_submod = function () {

            $("#dialog-submod").dialog("open");
            $("#dialog-submod").dialog({
                close: function (event, ui) {
                    self.llenarcombosubmodulo(self.vi_segappprog.idsegmansubmod());
                }
            });
        }

        self.agregar_prog = function () {

            $("#dialog-programa").dialog("open");
            $("#dialog-programa").dialog({
                close: function (event, ui) {
                    self.llenarcomboprograma(self.vi_segappprog.idsegmanprog());
                }
            });
        }

    }
    </script>
