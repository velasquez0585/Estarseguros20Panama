var segusuperf = function (campos_requeridos) {

    var self = this;

    self.idsegusuperf = ko.observable(0);

    self.idsegmanusu = ko.observable(0).extend({
        required: {
            message: "El Usuario es requerido.",
            params: campos_requeridos
        }
    });
    
    self.idsegappperf = ko.observable("").extend({
        required: {
            message: "El perfil es requerido.",
            params: campos_requeridos
        }
    });

    self.comboaplicacion = ko.observableArray();
}