<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Perfil para este Usuario</legend>

    <div class="form-row">
        <div class="form-field-header">
            Usuario
        </div>
        <div class="form-field-content">
            <input type="text" placeholder="DAVID" data-bind="value: xnombreusuario" disabled/>
        </div>
    </div>

</fieldset>

<fieldset class="form-area">
    <legend>Lista de Perfiles</legend>

    <div class="grid-area">
        <table class="grid-table" data-bind='visible: $root.lista_vi_segappperf().length > 0'>
            <thead>
                <tr>
                    <th></th>
                    <th>Perfiles</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: $root.lista_vi_segappperf'>
                <tr class="grid-row-content">
                    <td>
                        <input type="radio" data-bind="attr: { value: idsegmanperf }, checked: $root.idsegmanperf"/>
                    </td>
                    <td>
                        <span data-bind="text: xnombreperf"></span>
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr class="">
                    <td colspan="2">
                        <div>
                            <input type="button" value="Asignar Perfil" data-bind="click: $root.asignar_perfil" />
                        </div>
                    </td>
                </tr>
            </tfoot>
        </table>
        <h3 data-bind='visible: lista_vi_segappperf().length == 0'>No hay registros para esta consulta</h3>
    </div>
</fieldset>

<script type="text/javascript">
    function vmsegusuariosperfil1() {
        var self = this;
        self.vi_segmanusu = new vi_segmanusu(true);
        self.lista_vi_segappperf = ko.observableArray();
        self.idsegmanperf = ko.observable(0);

        self.cargar = function (idsegmanusu, xnombreusuario, idsegmanperf) {
            self.vi_segmanusu.idsegmanusu(idsegmanusu);
            self.vi_segmanusu.xnombreusuario(xnombreusuario);
            self.cargar_perfiles(idsegmanperf);
        }

        self.cargar_perfiles = function (idsegmanperf) {
            postajaxjsonbasico("/Seguridad/ObtenerPerfilesPorAplicacion/", {}, function (lista_vi_segappperf) {
                self.lista_vi_segappperf(lista_vi_segappperf);
                self.idsegmanperf(idsegmanperf);
            });
        }

        self.asignar_perfil = function () {
            postajaxjsonbasico("/Seguridad/AsignarPerfil/?idsegmanusu=" + self.vi_segmanusu.idsegmanusu() + "&idsegmanperf=" + self.idsegmanperf(), {}, function (respopera) {
                if (respopera.irespuesta == 1) {
                    generar_noty_auto("Se ha asignado el Perfil con Éxito", "success");
                    vmsegusuariosbuscar1.buscar();
                } else {
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }
            });
        }
    }
</script>