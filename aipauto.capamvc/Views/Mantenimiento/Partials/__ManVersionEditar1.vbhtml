<fieldset class="form-area" data-bind="with: aipmanvehver">
    <legend>Informaci&oacute;n</legend>

    <ul id="lista_err_manversionnuevo1" style="display: none;">
        <li data-bind="validationMessage: idaipmanvehmod" style="color: red;"></li>   
        <li data-bind="validationMessage: xnommanvehver" style="color: red;"></li>        
    </ul>

    <div class="form-row">
        <input type="button" value="Actualizar" data-bind="click: $root.actualizar" />
    </div>

     <div class="form-row">
        <div class="form-field-header">
            Marca
        </div>
        <div class="form-field-content">
            <select id="ddl_marca" data-bind="options: $root.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar',value: $root.idaipmanvehmar, event: { change: $root.obtener_modelos }" ></select>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Modelo
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.combomanvehmod, optionsText: 'xnommanvehmod', optionsValue: 'idaipmanvehmod', value: idaipmanvehmod"></select>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Versi&oacute;n
        </div>
        <div class="form-field-content">            
            <input type="text"  data-bind="value: xnommanvehver" />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Descripción
        </div>
        <div class="form-field-content">
            <textarea cols="50" rows="4"  data-bind="value: xdescmanvehver" ></textarea>                
        </div>
    </div> 
    
    <div class="form-row">
        <div class="form-field-header">
            Estado
        </div>
        <div class="form-field-content">    
            <select data-bind="options: comboestatmanvehver, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: iestatmanvehver"></select>           
        </div>
    </div>     

    <div class="form-row">
        <input type="button" value="Actualizar" data-bind="click: $root.actualizar" />
    </div>
</fieldset>


<script type="text/javascript">
    function vmmanversioneditar1(actualizar_grid) {
        var self = this;
        self.aipmanvehver = new aipmanvehver(true);
        self.combomanvehmar = ko.observableArray();
        self.combomanvehmod = ko.observableArray();
        self.idaipmanvehmar = ko.observable(0);
        

        self.cargar = function (vi_aipmanvehver) {
            
            ko.mapping.fromJS(vi_aipmanvehver, {}, self.aipmanvehver);
            self.llenarcbomarcas(vi_aipmanvehver.idaipmanvehmar);
            self.llenarcbomodelos(vi_aipmanvehver.idaipmanvehmar, vi_aipmanvehver.idaipmanvehmod)
            self.llenarcboestatus(vi_aipmanvehver.iestatmanvehver);
        }

        self.limpiar = function () {
            self.idaipmanvehmar(0);
            self.aipmanvehver.idaipmanvehmod(0);
            self.aipmanvehver.xnommanvehver("");
            self.aipmanvehver.xdescmanvehver("");
            self.aipmanvehver.iestatmanvehver("");
        }

        this.obtener_modelos = function (obj, event) {
            if (event.originalEvent) {
                //si el usuario desencadeno el evento
                self.combomanvehmod("");
                self.aipmanvehver.idaipmanvehmod(0);
                
                self.llenarcbomodelos(self.idaipmanvehmar());
            } else {
                //si el programa desencadeno el evento

            }
        }

        self.llenarcbomarcas = function (idaipmanvehmar) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboMarcas/", "{}", function (lista_aipmanvehmar) {
                self.combomanvehmar(lista_aipmanvehmar);
                self.idaipmanvehmar(idaipmanvehmar);
            });
        }

        self.llenarcbomodelos = function (idaipmanvehmar, idaipmanvehmod) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboModelosPorMarca/", "{'idaipmanvehmar': " + idaipmanvehmar + "}", function (lista_aipmanvehmod) {
                self.combomanvehmod(lista_aipmanvehmod);
                self.aipmanvehver.idaipmanvehmod(idaipmanvehmod);
            });
        }

        self.llenarcboestatus = function (iestatmanvehver) {
            var xconcepto = "ISTATUSVER";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_cmnmanvalor) {
                self.aipmanvehver.comboestatmanvehver(lista_cmnmanvalor);
                self.aipmanvehver.iestatmanvehver(iestatmanvehver);
            });
        }
           
        
        self.actualizar = function () {
            //este bloque me sirve para activar los errores que se generen de la validacion del formulario configurada en los
            //viewmodels de knockout
            if (self.idaipmanvehmar() == 0) {
                generar_noty_modal("<li style='color: red;'>La marca es requerida.</li>", "warning");
                return false;
            }
            self.aipmanvehver.errors = ko.validation.group(self.aipmanvehver);
            if (self.aipmanvehver.errors().length > 0) {
                generar_noty_modal($('#lista_err_manversionnuevo1').html(), "warning");
                return false;
            }

            postajaxjsonbasico("/Mantenimiento/ModificarVersion/", ko.toJSON(self.aipmanvehver), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    if (actualizar_grid) {
                        vmmanversionbuscar1.buscar();
                    }
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }

    }
</script>



