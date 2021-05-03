var segmanprog = function (campos_requeridos) {
    var self = this;

    self.idsegmanprog = ko.observable(0);

    self.xnombrecorto = ko.observable("").extend({
        required: {
            message: "El nombre corto es requerido.",
            params: campos_requeridos
        }
    });

    self.xnombrelargo = ko.observable("").extend({
        required: {
            message: "El nombre largo es requerido.",
            params: campos_requeridos
        }
    });

    self.fimplementacion = ko.observable("");

    self.xobjetivo = ko.observable("").extend({
        required: {
            message: "El objetivo es requerido.",
            params: campos_requeridos
        }
    });
}
