<fieldset class="form-area" data-bind="with: aipmanvehmar">
    <legend>Informaci&oacute;n</legend>
     <div class="form-row">
        <div class="form-field-header">
            Id
        </div>
        <div class="form-field-content">
            <span data-bind='text: idaipmanvehmar' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Nombre
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnommanvehmar' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Descripción
        </div>
        <div class="form-field-content">
            <textarea cols="50" rows="4"  data-bind="value: xdescmanvehmar" disabled></textarea>                
        </div>
    </div> 
    
    <div class="form-row">
        <div class="form-field-header">
            Estado
        </div>
        <div class="form-field-content">                   
            <span data-bind='text: iestatmanvehmar' />       
        </div>
    </div>     
</fieldset>


<script type="text/javascript">
    function vmmanmarcaver1() {
        var self = this;
        self.aipmanvehmar = new aipmanvehmar(false);        

        self.cargar = function (aipmanvehmar) {
            //prefiero que los tabs "ver" sean mapeados con las vistas que ya traigan todos los valores para no tener que llenar
            //combos que no seran utilizados
            ko.mapping.fromJS(aipmanvehmar, {}, self.aipmanvehmar);                      
        }
              

    }
</script>



