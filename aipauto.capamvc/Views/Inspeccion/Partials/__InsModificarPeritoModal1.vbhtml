<fieldset class="form-area" data-bind="with: vi_aipinsenc">
    <legend>Buscar</legend>

    @*recordemos que cada vez que agreguemos parametros de busqueda nuevos debemos coordinar con el especialista de la web api
    para que configure el parametro nuevo, sino tendremos error en el query con los OrderBy y Skip*@
    <div class="form-column">
        <div class="form-field-header">
            <label>Sucursal</label>
            <div class="form-field-content">                
                <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorgperit, disable: $root.disabled_sucursal, event: { change: $root.evento_sucursal }, enable: false"></select>
            </div>
        </div>
    </div>
        
</fieldset>


<fieldset class="form-area">
    <legend>Lista de Peritos</legend>

    <div class="">
        
        <div class="">
            <input type="button" value="Actualizar" data-bind="click: $root.actualizar, visible: lista_vi_aipinsdistperitdet().length > 0" />
        </div>
    </div>

    
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipinsdistperitdet().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th>Nombre</th>                     
                    <th>Perfil</th> 
                    <th>Inspecciones Asig.</th>                                    
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipinsdistperitdet'>
                <tr class="grid-row-content">
                    <td>
                       <input type="radio" name="rbl_usuario" data-bind="attr: { value: idsegmanusu }, checked: $root.idsegmanusuperit " />
                    </td>                    
                    <td>
                        <span data-bind='text: xnombrecompleto' />
                    </td>
                    <td>
                        <span data-bind='text: xnombreperf' />
                    </td>
                    <td>
                        <span data-bind='text: ncantinsperit' />
                    </td>
                    
                   
                    @*<td>
                        <select data-bind="options: $root.cbosucursal, optionsText: 'xnombrecomercial', optionsValue: 'idsegmanorg', value: idsegmanorgperit" disabled></select>
                    </td>   *@              
                </tr>
            </tbody>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsdistperitdet().length == 0'>No existen registros para esta consulta</div>
    </div>
     <div class="">
            <input type="button" value="Actualizar" data-bind="click: $root.actualizar, visible: lista_vi_aipinsdistperitdet().length > 0" />
        </div>
</fieldset>

<script type="text/javascript">
    function vminsmodificarperitomodal1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.vi_segusudetperf2 = new vi_segusudetperf2(false);
        self.lista_vi_segusudetperf2 = ko.observableArray();

        self.lista_vi_aipinsdistperitdet = ko.observableArray();
        self.pagvi_segusudetperf2 = new paginacion(1, 1000, 0, "it.xnombrecompleto", "ASC");
        self.cbosucursal = ko.observableArray();
        self.idsegmanusuperit = ko.observable(0);
        self.lista_vi_aipinsenc = ko.observableArray();

        self.cargar = function (vi_aipinsenc) {
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);

            self.llenarcbosucursal(vi_aipinsenc.idsegmanorgperit);
            
            self.idsegmanusuperit(vi_aipinsenc.idsegmanusuperit);
            self.vi_segusudetperf2.idsegmanorg(vi_aipinsenc.idsegmanorgperit);
            
            self.ObtenerPeritos(vi_aipinsenc.itipoperitinsenc, vi_aipinsenc.idsegmanorgperit);
            
        }

        self.cargarlista = function (idsegmanorgperit, lista_vi_aipinsenc) {
            self.llenarcbosucursal(idsegmanorgperit);
            self.lista_vi_aipinsenc(lista_vi_aipinsenc);
            self.ObtenerPeritos("EXTERNA", idsegmanorgperit);
            
        }

        self.ObtenerPeritos = function (itipoperitinsenc, idsegmanorg) {
            if (itipoperitinsenc == "EXTERNA") {
                postajaxjsonbasico("/Inspeccion/ObtenerPeritosExternosYLiderSuc/?idsegmanorg=" + idsegmanorg, "", function (lista_vi_aipinsdistperitdet) {
                    self.lista_vi_aipinsdistperitdet(lista_vi_aipinsdistperitdet);
                });
            }
            else {
                postajaxjsonbasico("/Inspeccion/ObtenerPeritosInternosYLiderSuc/?idsegmanorg=" + idsegmanorg, "", function (lista_vi_aipinsdistperitdet) {
                    self.lista_vi_aipinsdistperitdet(lista_vi_aipinsdistperitdet);
                });
            }
        }

        self.llenarcbosucursal = function (idsegmanorgperit) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                self.vi_aipinsenc.idsegmanorgperit(idsegmanorgperit);
            });
        }

        self.actualizar = function () {

            self.vi_aipinsenc.idsegmanusuperit(self.idsegmanusuperit());

            postajaxjsonbasico("/Inspeccion/ModificarPeritoInspeccion/", ko.toJSON(self.vi_aipinsenc), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.ObtenerPeritos(self.vi_aipinsenc.itipoperitinsenc(), self.vi_aipinsenc.idsegmanorgperit());
                    vminsadminactividadesbuscar1.buscar();
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }


    }

</script>