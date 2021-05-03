<fieldset class="form-area">
    <legend>Subir fotos a la Inspeccion</legend>

    <div data-bind="with: vi_aipinsenc">
        <div class="form-row">
            <div class="form-column">
                <div class="form-field-header">
                    <label>Sucursal</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: Siniestro" type="text" data-bind="value: xnombrecomercialperit" disabled />
                </div>

            </div>

            <div class="form-column">
                <div class="form-field-header">
                    <label>Inspección</label>
                </div>
                <div class="form-field-content">
                    <input placeholder="Ej: Inspección" type="text" data-bind="value: xtituactivperi" disabled />
                </div>

            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    <div class="form-row">
        <p>Seleccione una imagen para cargar:</p>
    </div>
    <div class="form-row">
        <input type="file" id="file_foto" multiple />
    </div>
</fieldset>

<script type="text/javascript">


    function vmInsSubirFotoModal1() {
        var self = this;

        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.idaipinsenc = ko.observable(0);


        self.iniciar = function (vi_aipinsenc) {
            self.idaipinsenc(vi_aipinsenc.idaipinsenc());
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);

            $('#file_foto').fileupload({
                dataType: 'json',
                url: '/Inspeccion/SubirFotoInspeccion/?idaipinsenc=' + self.idaipinsenc(),
                autoUpload: true,
                success: function (respopera) {

                    if (respopera.irespuesta == "1") {
                        generar_noty_auto(respopera.xmsjusuario, "success");
                    } else
                        generar_noty(respopera.xmsjusuario, "error");

                }
            })

        }

    }
</script>
