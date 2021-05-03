<fieldset class="form-area" data-bind="with: aipmanvehmar">
    <legend>Datos Marca</legend>

    <ul id="lista_err_manmarcanuevo1" style="display: none;">
        <li data-bind="validationMessage: xnommanvehmar" style="color: red;"></li>        
    </ul>

    <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: $root.agregar" />
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
        <input type="button" value="Agregar" data-bind="click: $root.agregar" />
    </div>
</fieldset>

<script type="text/javascript">
    function vmmanmarcanuevo1() {
        var self = this;
               
        self.aipmanvehmar = new aipmanvehmar(true);
        
        self.cargar = function () {
            self.limpiar();            
        }

        self.limpiar = function () {
            self.aipmanvehmar.idaipmanvehmar(0);
            self.aipmanvehmar.xnommanvehmar("");
            self.aipmanvehmar.xdescmanvehmar("");
            self.aipmanvehmar.iestatmanvehmar("");
            self.aipmanvehmar.idseglogreg(0);
            
        }       
        

        self.agregar = function () {
            
            
            //este bloque me sirve para activar los errores que se generen de la validacion del formulario configurada en los
            //viewmodels de knockout
            self.aipmanvehmar.errors = ko.validation.group(self.aipmanvehmar);
            if (self.aipmanvehmar.errors().length > 0) {
                generar_noty_modal($('#lista_err_manmarcanuevo1').html(), "warning");
                return false;
            }
            
            postajaxjsonbasico("/Mantenimiento/AgregarMarcas/", ko.toJSON(self.aipmanvehmar), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.limpiar();
                    vmmanmarcabuscar1.buscar();
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
    }
</script>
