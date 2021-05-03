<fieldset class="form-area" data-bind="with: aipmanvehmod">
    <legend>Informaci&oacute;n</legend>
     <div class="form-row">
        <div class="form-field-header">
            Marca
        </div>
        <div class="form-field-content">
            <select data-bind="options: $root.combomanvehmar, optionsText: 'xnommanvehmar', optionsValue: 'idaipmanvehmar', value: idaipmanvehmar" disabled></select>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Modelo
        </div>
        <div class="form-field-content">            
            <input type="text"  data-bind="value: xnommanvehmod" disabled/>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Descripción
        </div>
        <div class="form-field-content">
            <textarea cols="50" rows="4"  data-bind="value: xdescmanvehmod" disabled></textarea>                
        </div>
    </div> 
    
    <div class="form-row">
        <div class="form-field-header">
            Estado
        </div>
        <div class="form-field-content">    
            <input type="text" data-bind="value: iestatmanvehmod" disabled/>  
        </div>
    </div>     
</fieldset>


<script type="text/javascript">
    function vmmanmodelover1() {
        var self = this;
        self.aipmanvehmod = new aipmanvehmod(false);
        self.combomanvehmar = ko.observableArray();

        self.cargar = function (aipmanvehmar) {            
            ko.mapping.fromJS(aipmanvehmar, {}, self.aipmanvehmod);
            self.llenarcbomarcas(aipmanvehmar.idaipmanvehmar);
        }

        self.llenarcbomarcas = function (idaipmanvehmar) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboMarcas/", "{}", function (lista_aipmanvehmar) {
                self.combomanvehmar(lista_aipmanvehmar);
                self.aipmanvehmod.idaipmanvehmar(idaipmanvehmar);
            });
        }
              

    }
</script>



