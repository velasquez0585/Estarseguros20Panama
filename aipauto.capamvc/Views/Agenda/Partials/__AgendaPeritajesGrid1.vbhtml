<fieldset class="form-area">
    <legend>Peritajes agendados para este d&iacute;a</legend>
    <div class="form-row">
        <input type="button" value="Agregar" data-bind="click: agregar" />
    </div>
    <div style="clear: both; margin-left: 14px;" data-bind="with: pagvi_aipinsenc">
        <span>P&aacute;gina </span>
        <span data-bind='text: npagactual'></span>
        <span>de </span>
        <span data-bind='text: npagcantidad'></span>
    </div>
    <div class="grid-area">
        <table class="grid-table" data-bind='visible: lista_vi_aipinsenc().length > 0' cellspacing="10" cellpadding="5">
            <thead>
                <tr class="grid-row-header">
                    <th></th>
                    <th></th>
                    <th>Hora de inicio</th>
                    <th>Peritaje</th>
                </tr>
            </thead>
            <tbody data-bind='foreach: lista_vi_aipinsenc'>
                <tr class="grid-row-content">  
                    <td>
                        <a href='#' data-bind='click: $root.eliminar'>Eliminar</a>
                    </td>
                    <td>
                        <a href='#' data-bind='click: $root.ver'>Ver detalle</a>
                    </td>
                    <td>
                        <span data-bind='timehtml: fejecactivperi' />
                    </td>
                    <td>                        
                        <span data-bind='text: xplacinsenc' />
                        <span data-bind='text: xtituactivperi' />
                    </td>
                </tr>
            </tbody>
            <tfoot>
                <tr class="grid-row-footer">
                    <td colspan="3">
                        <div class="grid-bottom-buttons">
                            <div class="grid-bottom-button">
                                <input type="button" value="Primero" data-bind="click: ir_primero" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" value="Anterior" data-bind="click: ir_anterior" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" value="Siguiente" data-bind="click: ir_siguiente" />
                            </div>
                            <div class="grid-bottom-button">
                                <input type="button" value="Ultimo" data-bind="click: ir_ultimo" />
                            </div>
                        </div>
                    </td>
                </tr>
            </tfoot>
        </table>
        <div class="no-grid-rows" data-bind='visible: lista_vi_aipinsenc().length == 0'>No existen peritajes creados para este d&iacute;a...</div>
    </div>
</fieldset>

<script type="text/javascript">
    function vmagendaperitajesgrid1() {
        var self = this;
        self.lista_vi_aipinsenc = ko.observableArray();
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.fechaEjecucion = ko.observable("");
        self.pagvi_aipinsenc = new paginacion(1, 10, 0, "it.idaipactivperi", "DESC");
        self.idsegmanusuperit = ko.observable(0);
        self.agregar = function () {
            vmagendaperitajeagregar1.visibleDivAgregar(true);
            vmagendaperitajeagregar1.visibleDivModificar(false);
            vmagendaperitajeagregar1.limpiar();
            vmagendaperitajeagregar1.llenarcboidcmnmanestad(9);
            vmagendaperitajeagregar1.llenarcombohoras("00", "00");
            vmagendaperitajeagregar1.llenarcombominutos("00", "00");
            vmagendaperitajeagregar1.aipactivperi.idsegmanusu(0);
            
            vmagendaperitajeagregar1.formatearfecha(self.fechaEjecucion());
            $("#date").datepicker("disable");
            $('#dlg_agendaperitajeagregar1').dialog("open");
            vmagendaperitajeagregar1.fechaEjecucion(self.fechaEjecucion());
        }
        self.eliminar = function (obj) {
            var botones = [
                {
                    addClass: 'btn btn-primary', text: 'Si', onClick: function ($noty) {
                        $noty.close();
                        postajaxjsonbasico("/Agenda/EliminarPeritajePorId/", "{'idaipactivperi':'" + obj.idaipactivperi() + "'}", function (respopera) {
                            var tipo = "MOV"
                            self.buscar_peritajes(tipo, self.fechaEjecucion);
                            if (respopera.irespuesta == 1) {
                                generar_noty_auto(respopera.xmsjusuario, "success");
                            } else {
                                generar_noty_modal(respopera.xmsjusuario, "error");
                            }
                        });
                    }
                },
                {
                    addClass: 'btn btn-danger', text: 'No', onClick: function ($noty) {
                        $noty.close();
                    }
                }
            ];
            generar_noty_confirmacion("¿Está seguro que desea eliminar esta actividad?", botones);
        }

        self.ver = function (obj) {
            //postajaxjsonbasico("/Agenda/ObtenerActporId/", "{'idaipactivperi':'" + obj.idaipactivperi() + "'}", function (aipactivperi) {
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionPorId/", "{'idaipinsenc':'" + obj.idaipinsenc() + "'}", function (vi_aipinsenc) {
                vmagendaperitajeagregar1.cargar(vi_aipinsenc);
            });

            self.fechaformat(obj.fejecactivperi(), obj.ffinejecactivperi())

            $('#dlg_agendaperitajeagregar1').dialog("open");
            $("#dlg_agendaperitajeagregar1").dialog({
                close: function (event, ui) {
                    var tipo = "MOV";
                    //vmagendaperitajesgrid1.buscar_peritajes(tipo, self.fechaEjecucion());
                }
            });
        }

        self.fechaformat = function (fejecactivperi, ffinejecactivperi) {
            
            var date = new Date(fejecactivperi);
            var dia = date.getDate();
            var mes = parseInt(date.getMonth()) + 1;
            var anio = date.getFullYear();

            
            vmagendaperitajeagregar1.fecha(dia + "/" + mes + "/" + anio);

            var hora = date.getHours();
            var minutos = date.getMinutes();
            if (minutos < 10)
                minutos = "0" + minutos;
                       
            

            var dateFin = new Date(ffinejecactivperi);
            var diaRegreso = dateFin.getDate();
            var mesRegreso = parseInt(dateFin.getMonth()) + 1;
            var anioRegreso = dateFin.getFullYear();

            vmagendaperitajeagregar1.fechaFin(diaRegreso + "/" + mesRegreso + "/" + anioRegreso);

            var horaFin = dateFin.getHours();
            var minutosFin = dateFin.getMinutes();
            if (minutosFin < 10)
                minutosFin = "0" + minutosFin;

            
            vmagendaperitajeagregar1.llenarcombohoras(hora, horaFin);
            vmagendaperitajeagregar1.llenarcombominutos(minutos, minutosFin);
        }

        self.buscar_peritajes = function (tipo, fechaEjecucion) {
            
            if (tipo != 'MOV') {
                self.pagvi_aipinsenc.npagactual(1);
            }
            self.vi_aipinsenc.fejecactivperi(fechaEjecucion);
            self.vi_aipinsenc.ffinejecactivperi(fechaEjecucion);
            self.vi_aipinsenc.idsegmanusuperit(self.idsegmanusuperit());
            
            self.lista_vi_aipinsenc("");
            //alert(self.vi_aipinsenc.idsegmanusu());
            postajaxjsonbasico("/Agenda/Obtener_Actividades/", ko.toJSON(self), function (respvi_aipinsencpaglist) {
                
                ko.mapping.fromJS(respvi_aipinsencpaglist, {}, self);

                
            });
        }
        self.ir_primero = function () {
            var npagactual = self.pagvi_aipinsenc.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsenc.npagactual(1);
                self.buscar_peritajes('MOV', self.fechaEjecucion);
            }
        }

        self.ir_anterior = function () {
            var npagactual = self.pagvi_aipinsenc.npagactual();
            if (npagactual != 1) {
                self.pagvi_aipinsenc.npagactual(self.pagvi_aipinsenc.npagactual() - 1);
                self.buscar_peritajes('MOV', self.fechaEjecucion);
            }
        }

        self.ir_siguiente = function () {
            if (self.pagvi_aipinsenc.npagactual() != self.pagvi_aipinsenc.npagcantidad()) {
                self.pagvi_aipinsenc.npagactual(self.pagvi_aipinsenc.npagactual() + 1);
                self.buscar_peritajes('MOV', self.fechaEjecucion);
            }
        }

        self.ir_ultimo = function () {
            if (self.pagvi_aipinsenc.npagactual() != self.pagvi_aipinsenc.npagcantidad()) {
                self.pagvi_aipinsenc.npagactual(self.pagvi_aipinsenc.npagcantidad);
                self.buscar_peritajes('MOV', self.fechaEjecucion);
            }
        }
    }
</script>