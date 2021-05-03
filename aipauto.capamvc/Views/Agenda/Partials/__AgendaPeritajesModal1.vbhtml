<fieldset class="form-area">
    <table>
        <tr>
            <td>
                <label>Bienvenido </label>
            </td>
            <td>
                <label data-bind="text: $root.usuario"></label>
            </td>
        </tr>
    </table>
    <legend>Lista de Peritajes</legend>
    <div>
        <table cellspacing="10">
            <thead>
                <tr>
                    <th>Dia:</th>
                    <th>Mes:</th>
                    <th>Año:</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td><span data-bind='text: vmdia'></span></td>
                    <td><span data-bind='text: vmmes'></span></td>
                    <td><span data-bind='text: vmanio'></span></td>
                </tr>
            </tbody>
        </table>
    </div>

    <!-- ko stopBinding: true -->
    <div id="div_agendaaperitajesgrid1">
            @Html.Partial("__AgendaPeritajesGrid1")
    </div>
    <!-- /ko -->

</fieldset>

<script type="text/javascript">

    function vmagendaactividadesmodal1() {
        var self = this
        self.vmdia = ko.observable("");
        self.vmmes = ko.observable("");
        self.vmanio = ko.observable("");
        self.usuario = ko.observable("");
        self.obtenerusuarioconectado = function () {
            postajaxjsonbasico("/Agenda/ObtenerUsuarioConectado/", {}, function (usuario) {
                var nombre = ucWords(usuario);
                self.usuario(nombre);
            });
        }
    }

</script>


