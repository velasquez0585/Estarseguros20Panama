<fieldset class="form-area">
    <legend>Detalles de la declaraci&oacuten</legend>

    <div class="grid-area">
        <table class="grid-table" data-bind='visible: $root.lista_vi_aipextsintagenda().length > 0'>
            <thead>
                <tr class="grid-row-header">
                    <th>Fecha</th>
                    <th>Perito</th>
                    <th>Detalle</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: $root.lista_vi_aipextsintagenda'>
                <tr class="grid-row-content">
                    <td>
                        <span data-bind='datehtml: fmovextsintagenda' />
                    </td>
                    <td>
                        <span data-bind='text: xnomusuextsintagenda' />
                    </td>
                    <td>
                        <div class="form-field-content">
                            <textarea style="width: 600px" data-bind="value: xdescripextsintagenda"></textarea>
                        </div>
                        @*<span data-bind='text: xdescripextsintagenda' />*@
                    </td>
                </tr>
            </tbody>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipextsintagenda().length == 0'>No existen registros para esta consulta</div>
    </div>
        

</fieldset>

<script type="text/javascript">
    function vminsobservsintagenmodal1() {
        var self = this;
        self.lista_vi_aipextsintagenda = ko.observableArray();

        self.cargar = function (idsegmanorgperit, xnumsininsenc) {
            //alert(xnumsininsenc);
            self.cargarlistaDetalles(idsegmanorgperit, xnumsininsenc);
        }

        self.cargarlistaDetalles = function (idsegmanorgperit, xnumsininsenc) {
            //xnumsininsenc = "";
            postajaxjsonbasico("/Inspeccion/ObtenerListaDetallesSiniestro/?idsegmanorgperit=" + idsegmanorgperit + "&xnumsininsenc=" + xnumsininsenc, "{}", function (lista_vi_aipextsintagenda) {                
                self.lista_vi_aipextsintagenda(lista_vi_aipextsintagenda);
            })
        }

    }



    //function vminsobservsintagenmodal1() {
    //    var self = this;        
    //    self.lista_vi_aipextsintagenda = ko.observableArray();
    //    self.lista_vi_aipinsdistauditdet = ko.observableArray();

    //    self.cargar = function (idsegmanorgperit, xnumsininsenc) {
    //        self.obtenerAuditores(idsegmanorgperit);
    //        self.cargarlistaDetalles(idsegmanorgperit, xnumsininsenc);            

    //    }

    //    self.cargarlistaDetalles = function (idsegmanorgperit, xnumsininsenc) {
    //        postajaxjsonbasico("/Inspeccion/ObtenerListaDetallesSiniestro/?idsegmanorgperit=" + idsegmanorgperit + "&xnumsininsenc=" + xnumsininsenc, "{}", function (lista_vi_aipextsintagenda) {                
    //            self.lista_vi_aipextsintagenda(lista_vi_aipextsintagenda);
    //            ko.mapping.fromJS(lista_vi_aipextsintagenda, {}, self.lista_vi_aipextsintagenda);
    //            self.lista_vi_aipextsintagenda(lista_vi_aipextsintagenda);
    //            for (var i = 0; i < lista_vi_aipextsintagenda.length; i++) {
    //                alert(lista_vi_aipextsintagenda[i].xdescripextsintagenda);
    //            }


    //            //alert(self.lista_vi_aipextsintagenda());
    //            //self.lista_vi_aipinsdistauditdet(lista_vi_aipinsdistauditdet);
    //        })            
    //    }

    //    self.obtenerAuditores = function (idsegmanorg) {
    //        postajaxjsonbasico("/Inspeccion/ObtenerAuditoresYLideresPorSuc/?idsegmanorg=" + idsegmanorg, "", function (lista_vi_aipinsdistauditdet) {
    //            self.lista_vi_aipinsdistauditdet(lista_vi_aipinsdistauditdet);
    //        });
    //    }

    //}

</script>