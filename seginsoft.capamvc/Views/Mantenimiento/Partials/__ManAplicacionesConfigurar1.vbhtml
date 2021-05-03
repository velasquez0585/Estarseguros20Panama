<fieldset class="ui-corner-all">
    <legend>Configuración de Perfiles y Aplicación</legend>

    <div data-bind="with: segappperf">
        <div class="editor-label">
            <label>Aplicaci&oacute;n</label>
        </div>
        <div class="editor-field">
            <select data-bind="options: comboaplicacion, optionsText: 'xnombrecorto', optionsValue: 'idsegmanapp', value: idsegmanapp"></select>
        </div>



    <div data-bind="if: idsegmanapp() > 0">
        <div class="editor-label">
            <label>Perfiles</label>
        </div>
        <div data-bind="foreach: $root.lista_perfiles">
            <div>
                <input name="perfil" type="checkbox" data-bind="value: $data.idsegmanperf, checked: check, click: $root.togglecheck" />
                <span data-bind="text: xnombreperf"></span>
                @*<span> - NIVEL  </span><span data-bind="    text: nnivelperf"></span>*@

            </div>
        </div>
            </div>
    </div>
</fieldset>



<script type="text/javascript">

    function vmmanappconfigurar1() {

        var self = this;

        self.segappperf = new segappperf(false);
        
        self.comboaplicacion = ko.observableArray();
        self.lista_perfiles = ko.observableArray();
        self.lista_perfiles_check = ko.observableArray();

        self.llenarcomboaplicacion = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboAplicaciones/", "{}", function (lista_segmanapp) {
                self.segappperf.comboaplicacion(lista_segmanapp);
            });
        }

        self.segappperf.idsegmanapp.subscribe(function (idsegmanapp) {

            if (idsegmanapp == "") {
                return false;
            }
            self.llenarselectperfiles(idsegmanapp);
        });

        self.llenarselectperfiles = function (idsegmanapp) {
            self.lista_perfiles("");
            postajaxjsonbasico("/Mantenimiento/ObtenerPerfilesPorAppCheck/", "{'idsegmanapp': " + idsegmanapp + "}", function (lista_segmanperf) {
                self.lista_perfiles(lista_segmanperf);
            })
        }

    
        self.togglecheck = function (item) {            

            if (item.check) {

                postajaxjsonbasico("/Mantenimiento/AgregarPerfilesPorApp/", "{'idsegmanapp': " + self.segappperf.idsegmanapp() + ", 'idsegmanperf': " + item.idsegmanperf + "}", function (respopera) {

                    if (respopera.irespuesta == 1) {                        
                        generar_noty_auto(respopera.xmsjusuario, "success");

                    } else {
                        $(".noty_message").click();
                        generar_noty(respopera.xmsjusuario, "success");
                    }
                })

            } else {
                postajaxjsonbasico("/Mantenimiento/EliminarPerfilesPorApp/", "{'idsegappperf': " + item.idsegappperf + "}", function (respopera) {

                    if (respopera.irespuesta == 1) {
                        generar_noty_auto(respopera.xmsjusuario, "success");

                    } else {
                        $(".noty_message").click();
                        generar_noty(respopera.xmsjusuario, "success");
                    }
                })
            }
            return true;           
        }

    }


</script>
