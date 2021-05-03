﻿<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos Personales</legend>

    <div class="form-row">
        <div class="form-field-header">
            Perfil
        </div>
        <div class="form-field-content">
            <span data-bind='text: $root.xnombreperfil' />
        </div>
    </div>

     <div class="form-row">
        <div class="form-field-header">
            Ced.Ident/R.U.C.
        </div>
        <div class="form-field-content">
            <span data-bind='text: xcedula' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Nombre
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombres' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Apellido
        </div>
        <div class="form-field-content">
            <span data-bind='text: xapellidos' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Fecha de Nacimiento
        </div>
        <div class="form-field-content">
            <span data-bind='datehtml: fnacimiento' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Sexo
        </div>
        <div class="form-field-content">
            <span data-bind='text: xsexo' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Nacionalidad
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnacionalidad' />
        </div>
    </div>
</fieldset>

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos de Contacto</legend>

    <div class="form-row">
        <div class="form-field-header">
            Telefono Movil
        </div>
        <div class="form-field-content">
            <span data-bind='text: xtelfmovil1' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Correo Electronico
        </div>
        <div class="form-field-content">
            <span data-bind='text: xcorreoelectronico1' />
        </div>
    </div>

    @*<div class="form-row">
        <div class="form-field-header">
            Twitter
        </div>
        <div class="form-field-content">
            <span data-bind='text: xtwitter1' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Facebook
        </div>
        <div class="form-field-content">
            <span data-bind='text: xfacebook1' />
        </div>
    </div>*@

</fieldset>

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos de Direccion</legend>

    <div class="form-row">
        <div class="form-field-header">
            Continente
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombrecont' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Pais
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombrepais' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Estado
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombreestado' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Localidad
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombrelocalid' />
        </div>
    </div>

   @* <div class="form-row">
        <div class="form-field-header">
            Direccion
        </div>
        <div class="form-field-content">
            <textarea cols="50" rows="4" data-bind="value: xdireccion" disabled></textarea
        </div>
    </div>*@

</fieldset>

<fieldset class="form-area" data-bind="with: vi_segmanusu">
    <legend>Datos Laborales</legend>

    <div class="form-row">
        <div class="form-field-header">
            Sucursal
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombrecomercial' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Departamento
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombredep' />
        </div>
    </div>

    <div class="form-row">
        <div class="form-field-header">
            Cargo
        </div>
        <div class="form-field-content">
            <span data-bind='text: xnombrecarg' />
        </div>
    </div>

    <div class="form-row" data-bind="visible: $root.visibleperito">
        <div class="form-field-header">
            IMEI
        </div>
        <div class="form-field-content">
            <span data-bind='text: $root.xcodimmandisp' />
        </div>
    </div>

</fieldset>

<script type="text/javascript">
    function vmsegusuariosver1() {
        var self = this;
        self.vi_segmanusu = new vi_segmanusu(false);
        self.xnombreperfil = ko.observable("");
        self.xcodimmandisp = ko.observable("");
        self.visibleperito = ko.observable(false);

        self.cargar = function (vi_segmanusu) {
            //prefiero que los tabs "ver" sean mapeados con las vistas que ya traigan todos los valores para no tener que llenar
            //combos que no seran utilizados
            ko.mapping.fromJS(vi_segmanusu, {}, self.vi_segmanusu);
            self.obternerDatosUsuario(vi_segmanusu.idsegmanusu);
        }

        self.obternerDatosUsuario = function (idsegmanusu) {
            postajaxjsonbasico("/Seguridad/Obtenervi_segusudetperf2PorIdsegmanusu/?idsegmanusu=" + idsegmanusu, "", function (vi_segusudetperf2) {
                if (vi_segusudetperf2 != null) {
                    self.xnombreperfil(vi_segusudetperf2.xnombreperf);

                    if ((vi_segusudetperf2.idsegmanperf == 5 || vi_segusudetperf2.idsegmanperf == 6 || vi_segusudetperf2.idsegmanperf == 7)) {
                        self.visibleperito(true);
                        self.obtenerCodigoPerito(idsegmanusu);
                    } else {
                        self.visibleperito(false);
                    }
                }
            });
        }

        self.obtenerCodigoPerito = function (idsegmanusu) {
            postajaxjsonbasico("/Mantenimiento/ObtenerCodigoImei/", "{'idsegmanusu': " + idsegmanusu + "}", function (xcodimmandisp) {
                self.xcodimmandisp(xcodimmandisp);
            });
        }

    }
</script>



