<style type="text/css">
    #perfilesconf
    {
        padding: 20px;
    }
</style>
<div class="dialognoauto" id="dialog-confperfiles" title="Configuraci&oacute;n de perfiles de usuarios">
    <fieldset class="ui-corner-all">
        <legend>Datos de Usuario</legend>

        <div class="form-column" data-bind="with: vi_segmanusu">
            <div class="form-field-header">
                <label>Usuario</label>
            </div>
            <div class="form-field-content">
                <input type="hidden" data-bind="value: idsegmanusu" />
                <input type="text" data-bind="value: xnombrecompleto" disabled />
            </div>
        </div>
    </fieldset>

    <fieldset>
        <legend>Aplicaciones y perfiles para este usuario</legend>


        <div class="form-row" id="perfilesconf">
            <div class="form-field-header">
                <label>Aplicaci&oacute;n</label>
            </div>
            <div class="editor-field">
                <select data-bind="options: comboaplicacion, optionsText: 'xnombrecorto', optionsValue: 'idsegmanapp', value: idsegmanapp"></select>
            </div>
        </div>
        <div class="form-row" >
            <div data-bind="if: idsegmanapp() > 0">
                <div class="form-field-header">
                    <label>Perfiles</label>
                </div>
                <div data-bind="foreach: lista_vi_segappperf">
                    <div>

                        <input class="radio" name="perfil" type="radio" data-bind="attr: { value: idsegmanperf }, checked: $root.idsegappperf" />

                        <span data-bind="text: xnombreperf"></span>
                        @*<span> NIVEL - </span><span data-bind="    text: nivel"></span>*@
                    </div>
                </div>
            </div>
        </div>

        <div class="form-column-button-left">
            <input type="button" value="Guardar" data-bind="click: asignar" />
        </div>
        @*<input type="button" value="Limpiar" data-bind="click: limpiar" />*@
    </fieldset>
</div>

<script type="text/javascript">
    function vmmanusuarioconfigurarperf1() {
        var self = this;
        self.vi_segmanusu = new vi_segmanusu(false);

        self.idsegmanapp = ko.observable(0);
        self.comboaplicacion = ko.observableArray();
        self.lista_vi_segappperf = ko.observableArray();
        self.idsegappperf = ko.observable(0);

        self.cargar = function (vi_segmanusu) {
            ko.mapping.fromJS(vi_segmanusu, {}, self.vi_segmanusu);
            $('#dialog-confperfiles').dialog("open");
            self.idsegmanapp(0);
            //self.idsegappperf(vi_segmanusu.idsegappperf);
        }

        self.llenarcomboaplicacion = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboAplicaciones/", "{}", function (lista_segmanapp) {
                self.comboaplicacion(lista_segmanapp);
            })
        }

        self.idsegmanapp.subscribe(function (idsegmanapp) {
            var idsegmanusu = self.vi_segmanusu.idsegmanusu();

            if (idsegmanapp == "") {
                idsegmanapp = 0;
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/ObtenerPerfilesPorApp/", "{'idsegmanapp': " + idsegmanapp + "}", function (lista_vi_segappperf) {

                self.lista_vi_segappperf(lista_vi_segappperf);


                postajaxjsonbasico("/Mantenimiento/ObtenerPerfilesPorUsuyApp/", "{'idsegmanusu': " + idsegmanusu + ",'idsegmanapp': " + idsegmanapp + "}", function (vi_segusuperf) {

                    self.idsegappperf(vi_segusuperf.idsegmanperf);
                })

            })
        });


        self.limpiar = function () {
            self.idsegmanapp(0);
            self.idsegappperf(false);
            self.idsegmanperf(0);
        }

        self.asignar = function () {

            var idsegappperf = self.idsegappperf();
            var idsegmanapp = self.idsegmanapp();
            var idsegmanusu = self.vi_segmanusu.idsegmanusu();

            if (idsegappperf == "" || idsegappperf == 0) {
                $(".noty_message").click();
                generar_noty("<li style='color: red;'>Debe seleccionar el perfil que desea asignar.</li>", "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/GuardarPerfilPorAplicacion/", "{'idsegmanusu': " + idsegmanusu + ", 'idsegmanapp': " + idsegmanapp + ", 'idsegmanperf': " + idsegappperf + "}", function (respopera) {

                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }

            });

        }
    }
</script>
