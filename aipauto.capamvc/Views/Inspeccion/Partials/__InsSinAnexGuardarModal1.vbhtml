<fieldset class="form-area">
    <legend>Asignar anexo</legend>

    <div class="" data-bind="visible: ibtnvisible">
        <input type="button" value="Crear" data-bind="click: $root.guardar" />
        </div>


    <div data-bind="with: vi_aipinsenc">
        <div class="form-row">

            <fieldset style="width: 900px;">
                <legend>Motivo de la inspeccion</legend>
                <div class="form-row" data-bind="foreach: $root.lista_aipinsmotiv">

                    <div class="form-column" style="width: 200px">
                        <span style="display: inline" data-bind="text: xnominsmotiv"></span>
                    </div>
                    <div class="form-column" style="width: 60px; margin-bottom: 30px;">
                        <input type="radio" name="motivoins" data-bind="attr: { value: isel }, checked: IsTCheckbox, click: $root.clickM1" />
                    </div>

                </div>
            </fieldset>

        </div>

        <div class="form-row" style="float: left; margin-right: 10%;">
            <div class="form-field-header">
                Perito
            </div>
            <div class="form-field-content">
                <select data-bind="options: $root.cboperito, optionsText: 'xnombrecompleto', optionsValue: 'idsegmanusu', value: idsegmanusuperit"></select>
            </div>
        </div>

    </div>

    <div class="form-row" data-bind="visible: ibtnvisible">
        <input type="button" value="Crear" data-bind="click: $root.guardar" />
    </div>

</fieldset>

<script type="text/javascript">
    function vmInsSinAnexGuardarModal1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.alista_aipinsmotiv = ko.observableArray();
        self.lista_aipinsmotiv = ko.observableArray();        
        self.idaipinsmotiv = ko.observable(0);
        self.cboperito = ko.observableArray();
        self.ibtnvisible = ko.observable(true);

        self.cargar = function (vi_aipinsenc) {

            self.alista_aipinsmotiv("");
            self.lista_aipinsmotiv("");

            self.ibtnvisible(true);
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);

            self.llenar_lista_aipinsmotiv(vi_aipinsenc.itipoinsenc());
            self.llenarcboperito(vi_aipinsenc.idsegmanorgperit());
        }

        self.llenar_lista_aipinsmotiv = function (itipoinsenc) {
            //alert(itipoinsenc);
            postajaxjsonbasico("/Inspeccion/ObtenerMotivosInspeccionPorSiniestro/?itipoinsmotiv=" + itipoinsenc, '{}', function (lista_aipinsmotiv) {                
                ko.mapping.fromJS(lista_aipinsmotiv, {}, self.alista_aipinsmotiv);

                ko.utils.arrayForEach(self.alista_aipinsmotiv(), function (feature) {
                    feature.IsTCheckbox = ko.computed({
                        read: function () {
                            return feature.isel() + "";
                        },
                        write: function (v) {
                            if (v == "true") feature.isel(true)
                            else feature.isel(false)
                        }
                    });

                });
                ko.mapping.fromJS(self.alista_aipinsmotiv, {}, self.lista_aipinsmotiv);                
            })
        }

        self.llenarcboperito = function (idsegmanorg) {
            //alert(idsegmanorg);
            postajaxjsonbasico("/Agenda/ObtenerComboPeritosPorUsuarioYOrg/?idsegmanorg=" + idsegmanorg, '{}', function (lista_segmanusuperit) {
                self.cboperito(lista_segmanusuperit);                                
            });
        }

        self.clickM1 = function (obj) {
            for (var i = 0; i < self.lista_aipinsmotiv().length; i++) {                
                if (self.lista_aipinsmotiv()[i].idaipinsmotiv() == obj.idaipinsmotiv()) {
                    self.lista_aipinsmotiv()[i].isel(true);
                    obj.isel(true);
                    self.idaipinsmotiv(self.lista_aipinsmotiv()[i].idaipinsmotiv());
                }
                else
                    self.lista_aipinsmotiv()[i].isel(false);
            }
            return true;
        }


        self.guardar = function () {           

            postajaxjsonbasico("/Inspeccion/CrearInspeccionPorAnexo/?idaipinsencAnt=" + self.vi_aipinsenc.idaipinsenc() + "&idsegmanorgperit=" + self.vi_aipinsenc.idsegmanorgperit() + "&idaipinsmotiv=" + self.idaipinsmotiv() + "&idsegmanusuperit=" + self.vi_aipinsenc.idsegmanusuperit(), '{}', function (respopera) {
                if (respopera.irespuesta == "1") {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.ibtnvisible(false);
                    vmInsSinGuardar1.ocultarAnexo();
                    
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }

    }

</script>