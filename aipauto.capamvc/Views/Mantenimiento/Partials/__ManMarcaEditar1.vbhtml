<fieldset class="form-area" data-bind="with: aipmanvehmar">
    <legend>Datos Marca</legend>

    <ul id="lista_err_manmarcaeditar1" style="display: none;">
        <li data-bind="validationMessage: xnommanvehmar" style="color: red;"></li>        
    </ul>

    <div class="form-row">
        <input type="button" value="Actualizar" data-bind="click: $root.actualizar" />
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Nombre
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="Nombre de la marca" data-bind="value: xnommanvehmar" />
        </div>
    </div>
    <div class="form-row">
        <div class="form-field-header">
            Descripción
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="Descripción de la marca" data-bind="value: xdescmanvehmar" />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Estado
        </div>
        <div class="form-field-content">
            <select data-bind="options: comboestatmanvehmar, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatmanvehmar"></select>
        </div>
    </div>
    
    <div class="form-row">
        <input type="button" value="Actualizar" data-bind="click: $root.actualizar" />
    </div>
</fieldset>

<script type="text/javascript">
    function vmmanmarcaeditar1() {
        var self = this;
               
        self.aipmanvehmar = new aipmanvehmar(true);
        
        self.cargar = function (aipmanvehmar) {
            ko.mapping.fromJS(aipmanvehmar, {}, self.aipmanvehmar);            
            self.llenarcboestatus(aipmanvehmar.iestatmanvehmar);
        }        
        
        
        self.llenarcboestatus = function (iestatmanvehmar) {
            var xconcepto = "ISTATUSMARCA";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_cmnmanvalor) {
                self.aipmanvehmar.comboestatmanvehmar(lista_cmnmanvalor);
                self.aipmanvehmar.iestatmanvehmar(iestatmanvehmar);                
            });
        }


        self.actualizar = function () {            
            
            //este bloque me sirve para activar los errores que se generen de la validacion del formulario configurada en los
            //viewmodels de knockout
            self.aipmanvehmar.errors = ko.validation.group(self.aipmanvehmar);
            if (self.aipmanvehmar.errors().length > 0) {
                generar_noty_modal($('#lista_err_manmarcaeditar1').html(), "warning");
                return false;
            }
            
            postajaxjsonbasico("/Mantenimiento/ModificarMarcas/", ko.toJSON(self.aipmanvehmar), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");                    
                    vmmanmarcabuscar1.buscar();
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
    }
</script>
