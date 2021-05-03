<div data-bind="with: segmanapp">
    <ul id="lista_segmanappagregarapp1_err" style="display: none;">
        <li data-bind="validationMessage: xnombrecorto" style="color: red;"></li>
        <li data-bind="validationMessage: xnombrelargo" style="color: red;"></li>
        <li data-bind="validationMessage: xtipoapp" style="color: red;"></li>
        <li data-bind="validationMessage: xso" style="color: red;"></li>
        <li data-bind="validationMessage: xdesatec" style="color: red;"></li>
        <li data-bind="validationMessage: xobjetivo" style="color: red;"></li>
        <li data-bind="validationMessage: idsegmanorg" style="color: red;"></li>

    </ul>
</div>

<fieldset class="ui-corner-all">
    <legend>Mantenimiento Aplicaciones</legend>

    <div data-bind="with: segmanapp">

        <div class="form-row">
            <div class="form-field-header">
                <label>Nombre Corto<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombrecorto" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Nombre Largo<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xnombrelargo" />
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Tipo de Aplicaci&oacute;n<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: combotipoapp, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xtipoapp"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Sistema Operativo<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: comboso, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xso"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Tecnolog&iacute;a Desarrollo<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <select data-bind="options: combodesatec, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: xdesatec"></select>
            </div>
        </div>

        <div class="form-row">
            <div class="form-field-header">
                <label>Objetivo<span class="importante">(*)</span></label>
            </div>
            <div class="form-field-content">
                <input type="text" data-bind="value: xobjetivo" />
            </div>
        </div>

        <div class="editor-label">
            <label>Organizaci&oacute;n<span class="importante">(*)</span></label>
        </div>
    </div>
    <select class="selectlist" id="lb_organizaciones_inc" size="7" multiple>
    </select>

    <input type="button" class="btn_inc_exc" id="btn_inc" value="<" data-bind="click: incluir" />
    <input type="button" class="btn_inc_exc" id="btn_exc" value=">" data-bind="click: excluir" />
    <select class="selectlist" id="lb_organizaciones_exc" size="7" multiple data-bind="options: combo_organizaciones, optionsText: 'xnombrecomercial', optionsValue: 'idcomunmanempr'"></select>


    <p>
        <input type="button" value="Agregar" data-bind="click: agregar" />
    </p>
</fieldset>

<script type="text/javascript">

    function vmmanaplicacionesagregarapp1() {
        var self = this;

        self.segmanapp = new segmanapp(true);

        self.combo_organizaciones = ko.observableArray();
        self.organizaciones = ko.observable("");

        self.llenarcomboorganizaciones = function () {
            
            postajaxjsonbasico("/Mantenimiento/ObtenerOrganizaciones/", "{}", function (lista_comunmanempr) {
                self.combo_organizaciones(lista_comunmanempr);
            });           
        }
        
        self.llenarcombotipoapp = function () {
            var xconcepto = "TIPOAPLICACION";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.segmanapp.combotipoapp(lista_comunconfvalor);
            })
        }

        self.llenarcombosistoper = function () {
            var xconcepto = "SO";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.segmanapp.comboso(lista_comunconfvalor);
            })
        }

        self.llenarcombotecndesarrollo = function () {
            var xconcepto = "DESATECNOLOGIA";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.segmanapp.combodesatec(lista_comunconfvalor);
            })
        }

        

        self.incluir = function () {

            $('#lb_organizaciones_exc :selected').each(function (i, selected) {
                $('#lb_organizaciones_inc').append('<option value="' + selected.value + '">' + selected.text + '</option>');
                $("#lb_organizaciones_exc option[value='" + selected.value + "']").remove();
            })

        }

        self.excluir = function () {

            $('#lb_organizaciones_inc :selected').each(function (i, selected) {
                $('#lb_organizaciones_exc').append('<option value="' + selected.value + '">' + selected.text + '</option>');
                $("#lb_organizaciones_inc option[value='" + selected.value + "']").remove();
            })
        }


        self.limpiar = function () {
            self.segmanapp.xnombrecorto("");
            self.segmanapp.xnombrecorto("");
            self.segmanapp.xnombrelargo("");
            self.segmanapp.xtipoapp("");
            self.segmanapp.xso("");
            self.segmanapp.xdesatec("");
            self.segmanapp.fimplementacion("");
            self.segmanapp.xtipoapp("");
            self.segmanapp.xobjetivo("");
            //self.segmanapp.idsegmanorg("");

            $('#lb_organizaciones_inc option').each(function (i, selected) {
                $("#lb_organizaciones_inc option[value='" + selected.value + "']").remove();
            })

            self.llenarcomboorganizaciones();
        }

        self.agregar = function () {
            
            var organizaciones = "", i = 0;
            $('#lb_organizaciones_inc option').each(function () {
                if (i != 0) organizaciones += ",";
                organizaciones += $(this).val();
                i++;
            });

            self.organizaciones = organizaciones;

            self.segmanapp.errors = ko.validation.group(self.segmanapp);
            if (self.segmanapp.errors().length > 0) {
                $(".noty_message").click();
                generar_noty($('#lista_segmanappagregarapp1_err').html(), "warning");
                return false;
            }

            if (organizaciones == "") {
                $(".noty_message").click();
                generar_noty($('#lista_segmanappagregarapp1_err').html(), "warning");
                return false;
            }



            postajaxjsonbasico("/Mantenimiento/AgregarAplicacion/", ko.toJSON(self), function (respopera) {
                if (respopera.irespuesta == 1) {
                    //$("#dialog-app").dialog("close");
                    generar_noty_auto(respopera.xmsjusuario, "success");                    
                    self.limpiar();
                    //vmmanappagregar1.llenarcomboaplicacion();
                    //vmmanappconfigurar1.llenarcomboaplicacion();
                } else {
                    $(".noty_message").click();
                    generar_noty(respopera.xmsjusuario, "error");
                }
            })
        }

    }
</script>

