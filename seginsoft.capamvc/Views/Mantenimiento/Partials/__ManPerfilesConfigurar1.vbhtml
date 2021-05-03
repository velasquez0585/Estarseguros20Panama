<fieldset>
    <legend>CONFIGURAR PERFILES</legend>

    <div class="form-row" data-bind="foreach: lista_segmanperf">
        <div class="form-field-content">
            <input class="radio" name="perfil" type="radio" data-bind="attr: { value: idsegmanperf }, checked: $root.idsegappperf, click: $root.llenarcomboaplicaciones" />
            <span data-bind="text: xnombreperf"></span>

        </div>
    </div>

     
        <div class="form-row" >
            <div class="form-field-header">
                Aplicaci&oacute;n
            </div>
            <div class="form-field-content">
                <select data-bind="options: comboaplicacion, optionsText: 'xnombrecorto', optionsValue: 'idsegmanapp', value: idsegmanapp"></select>
            </div>
        </div>

    <div data-bind="   visible: comboaplicacion().length > 0 ">
        <div class="form-column-button-left">
            <input type="button" value="Buscar" data-bind="click: cargar_programas" />
        </div>
    </div>
    

</fieldset>

<fieldset data-bind="   visible: comboaplicacion().length > 0 ">
    <legend>Lista de programas</legend>

    <div class="grid-area">

        <table class="grid-table" data-bind='visible: lista_vi_segappprog().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th>Modulo</th>
                    <th>SubModulo</th>
                    <th>Programa</th>
                    <th>Tipo Acceso</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_segappprog'>
                <tr class="grid-row-content">
                    <td>
                        <input type="checkbox" data-bind="click: $root.toggle_programa, checked: check, disable: check" />
                    </td>
                    <td>
                        <span data-bind='text: xnombrecortomod'></span>
                    </td>
                    <td>
                        <span data-bind='text: xnombrecortosubmod'></span>
                    </td>
                    <td>
                        <span data-bind='text: xnombrecortoprog'></span>
                    </td>
                    <td>
                        <select data-bind="options: $root.comboaccesos, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: tipoacc, enable: check, event: { change: $root.modificar_tipoacc.bind($data) }"></select>
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_segappprog().length == 0'>No existen registros almacenados...</div>
    </div>


</fieldset>

<script type="text/javascript">

    function vmmanappconfigurar1() {

        var self = this;

        //self.segappperf = new segappperf(false);

        self.comboaplicacion = ko.observableArray();
        self.lista_segmanperf = ko.observableArray();
        self.idsegappperf = ko.observable(0);
        self.idsegmanapp = ko.observable(0);
        self.lista_vi_segappprog = ko.observableArray();

        self.comboaccesos = ko.observableArray();


        self.iniciar = function () {
            self.llenarperfiles();
            self.llenarcombotipoacceso();
        }


        self.llenarperfiles = function () {
            postajaxjsonbasico("/Mantenimiento/ObtenerListaPerfiles/", "{}", function (lista_segmanperf) {
                self.lista_segmanperf(lista_segmanperf);
            });
            return true;
        }

        self.llenarcomboaplicaciones = function (obj) {
            self.idsegappperf(obj.idsegmanperf);
            postajaxjsonbasico("/Mantenimiento/ObtenerAplicaionesPorPerfil/", "{'idsegmanperf': " + obj.idsegmanperf + "}", function (lista_vi_segappperf) {
                self.comboaplicacion(lista_vi_segappperf);
                self.cargar_programas();
            });
            return true;
        }

        self.llenarcombotipoacceso = function () {
            var xconcepto = "TIPOACCESO";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.comboaccesos(lista_comunconfvalor);
            });
        }
              
        self.modificar_tipoacc = function (obj) {
            
            postajaxjsonbasico("/Mantenimiento/ModificarTipoAcceso/", "{'idsegaccperf': " + obj.idsegaccperf + ", 'tipo_acceso': '" + obj.tipoacc + "'}", function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }

        self.cargar_programas = function () {
            
            if (self.idsegmanapp() == 0 || self.idsegmanapp() == undefined && self.idsegappperf() == 0) {
                self.lista_vi_segappprog("");
                return false;
            }

            if (self.idsegmanapp() == undefined) {
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/ObtenerConfAppProgPorAplicacionCheck/", "{'idsegmanperf': " + self.idsegappperf() + ", 'idsegmanapp': " + self.idsegmanapp() + "}", function (lista_vi_segappprog) {
                self.lista_vi_segappprog(lista_vi_segappprog);
            });
        }

        self.toggle_programa = function (obj) {

            if (!obj.check) {
                postajaxjsonbasico("/Mantenimiento/AgregarTipoAcceso/", "{'idsegmanperf': " + self.idsegappperf() + ", 'idsegappprog': " + obj.idsegappprog + ", 'tipo_acceso': '" + obj.tipoacc + "'}", function (respopera) {
                    if (respopera.irespuesta == 1) {
                        generar_noty_auto(respopera.xmsjusuario, "success");
                        self.cargar_programas();
                    } else {
                        $(".noty_message").click();
                        generar_noty(respopera.xmsjusuario, "error");
                    }
                })
                
            }

            return true;
        }

    }


</script>

