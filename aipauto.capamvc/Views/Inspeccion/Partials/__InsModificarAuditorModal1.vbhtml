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
    <legend>Lista de Auditores</legend>

    <div class="">
        
        <div class="">
            <input type="button" value="Actualizar" data-bind="click: $root.actualizar, visible: lista_vi_aipinsdistauditdet().length > 0" />
        </div>
    </div>

    
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipinsdistauditdet().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th>Nombre</th> 
                    <th>Perfil</th>    
                    <th>Inspecciones Asig.</th>                                     
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipinsdistauditdet'>
                <tr class="grid-row-content">
                    <td>
                      <input type="radio" name="rbl_usuario" data-bind="attr: { value: idsegmanusu }, checked: $root.idsegmanusuaudit " />
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
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsdistauditdet().length == 0'>No existen registros para esta consulta</div>
    </div>
        
    <div class="">
            <input type="button" value="Actualizar" data-bind="click: $root.actualizar, visible: lista_vi_aipinsdistauditdet().length > 0" />
        </div>


    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipextsintagenda().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th>Fecha</th>
                    <th>Perito</th>
                    <th>Detalle</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipextsintagenda'>
                <tr class="grid-row-content">
                    <td>
                        <span data-bind='text: fmovextsintagenda' />
                    </td>
                    <td>
                        <span data-bind='text: xnomusuextsintagenda' />
                    </td>
                    <td>
                        <span data-bind='text: xdescripextsintagenda' />
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipextsintagenda().length > 0'>No existen registros para esta consulta</div>
    </div>



</fieldset>

<script type="text/javascript">
    function vminsmodificarauditormodal1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.vi_segusudetperf2 = new vi_segusudetperf2(false);
        self.lista_vi_segusudetperf2 = ko.observableArray();
        self.lista_vi_aipinsdistauditdet = ko.observableArray();
        self.pagvi_segusudetperf2 = new paginacion(1, 100, 0, "it.xnombrecompleto", "ASC");
        self.cbosucursal = ko.observableArray();
        self.idsegmanusuaudit = ko.observable(0);



        self.lista_vi_aipextsintagenda = ko.observableArray();

        self.cargar = function (vi_aipinsenc) {
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);

            self.idsegmanusuaudit(vi_aipinsenc.idsegmanusuaudit);
            self.llenarcbosucursal(vi_aipinsenc.idsegmanorgperit);
            self.vi_segusudetperf2.idsegmanorg(vi_aipinsenc.idsegmanorgperit);
            self.obtenerAuditores(vi_aipinsenc.idsegmanorgperit);
            self.cargarlistaDetalles(vi_aipinsenc.idsegmanorgperit,"111");
        }

        self.cargarlista = function (lista_vi_aipinsenc) {
            self.lista_vi_aipinsenc(lista_vi_aipinsenc);
            alert(self.lista_vi_aipinsenc().length)
        }


        self.obtenerAuditores = function (idsegmanorg) {
            postajaxjsonbasico("/Inspeccion/ObtenerAuditoresYLideresPorSuc/?idsegmanorg=" + idsegmanorg, "", function (lista_vi_aipinsdistauditdet) {
                self.lista_vi_aipinsdistauditdet(lista_vi_aipinsdistauditdet);
            });
        }


        self.cargarlistaDetalles = function (idsegmanorgperit, xnumsininsenc) {
            xnumsininsenc = "";
            postajaxjsonbasico("/Inspeccion/ObtenerListaDetallesSiniestro/?idsegmanorgperit=" + idsegmanorgperit + "&xnumsininsenc=" + xnumsininsenc, "{}", function (lista_vi_aipextsintagenda) {
                self.lista_vi_aipextsintagenda(lista_vi_aipextsintagenda);
            })
        }


        self.llenarcbosucursal = function (idsegmanorgperit) {
            postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", '{}', function (lista_vi_combosegmanorg) {
                self.cbosucursal(lista_vi_combosegmanorg);
                self.vi_aipinsenc.idsegmanorgperit(idsegmanorgperit);
            });
        }
        
        self.actualizar = function () {

            self.vi_aipinsenc.idsegmanusuaudit(self.idsegmanusuaudit());

            postajaxjsonbasico("/Inspeccion/ModificarAuditorInspeccion/", ko.toJSON(self.vi_aipinsenc), function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto(respopera.xmsjusuario, "success");
                    self.obtenerAuditores(self.vi_aipinsenc.idsegmanorgperit());
                    vminsadminactividadesbuscar1.buscar();
                    
                } else {
                    generar_noty(respopera.xmsjusuario, "error");
                }
            });
        }

    }

</script>