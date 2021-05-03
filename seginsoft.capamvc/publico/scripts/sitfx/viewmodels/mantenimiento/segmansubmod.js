var segmansubmod = function (campos_requeridos) {

    var self = this;

    self.idsegmansubmod = ko.observable(0);

    self.xnombrecorto = ko.observable("").extend({
        required: {
            message: "El Nombre Corto es requerido.",
            params: campos_requeridos
        }
    });

    self.xnombrelargo = ko.observable("").extend({
        required: {
            message: "El Nombre Largo es requerido.",
            params: campos_requeridos
        }
    });

    self.fimplementacion = ko.observable("");

    self.xobjetivo = ko.observable("").extend({
        required: {
            message: "El Objetivo es requerido.",
            params: campos_requeridos
        }
    });

    self.combosubmodulo = ko.observableArray();

}