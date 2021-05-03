<fieldset class="form-area" data-bind="with: vi_aipmanvehver">
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
            <select data-bind="options: $root.combomanvehmod, optionsText: 'xnommanvehmod', optionsValue: 'idaipmanvehmod', value: idaipmanvehmod" disabled></select>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Versi&oacute;n
        </div>
        <div class="form-field-content">            
            <input type="text"  data-bind="value: xnommanvehver" disabled/>
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Descripción
        </div>
        <div class="form-field-content">
            <textarea cols="50" rows="4"  data-bind="value: xdescmanvehver" disabled></textarea>                
        </div>
    </div> 
    
    <div class="form-row">
        <div class="form-field-header">
            Estado
        </div>
        <div class="form-field-content">    
            <input type="text" data-bind="value: iestatmanvehver" disabled/>  
        </div>
    </div>     
</fieldset>


<script type="text/javascript">
    function vmmanversionver1() {
        var self = this;
        self.vi_aipmanvehver = new vi_aipmanvehver(false);
        self.combomanvehmar = ko.observableArray();
        self.combomanvehmod = ko.observableArray();

        self.cargar = function (vi_aipmanvehver) {
            ko.mapping.fromJS(vi_aipmanvehver, {}, self.vi_aipmanvehver);
            self.llenarcbomarcas(vi_aipmanvehver.idaipmanvehmar);
            self.llenarcbomodelos(vi_aipmanvehver.idaipmanvehmar,vi_aipmanvehver.idaipmanvehmod);
        }

        self.llenarcbomarcas = function (idaipmanvehmar) {
            
            postajaxjsonbasico("/Mantenimiento/ObtenerComboMarcas/", "{}", function (lista_aipmanvehmar) {
                self.combomanvehmar(lista_aipmanvehmar);
                self.vi_aipmanvehver.idaipmanvehmar(idaipmanvehmar);
            });
        }

        self.llenarcbomodelos = function (idaipmanvehmar, idaipmanvehmod) {
            postajaxjsonbasico("/Mantenimiento/ObtenerComboModelosPorMarca/", "{'idaipmanvehmar': " + idaipmanvehmar + "}", function (lista_aipmanvehmod) {
                self.combomanvehmod(lista_aipmanvehmod);
                self.vi_aipmanvehver.idaipmanvehmod(idaipmanvehmod);
            });
        }
              

    }
</script>



