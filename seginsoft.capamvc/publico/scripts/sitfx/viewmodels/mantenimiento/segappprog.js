var segappprog = function (campos_requeridos) {

    var self = this;

    self.idsegappprog = ko.observable(0);

    self.idsegmanapp = ko.observable(0).extend({
        required: {
            message: "La aplicación es requerida.",
            params: campos_requeridos
        }
    });

    self.idsegmanmod = ko.observable(0).extend({
        required: {
            message: "El modulo es requerido.",
            params: campos_requeridos
        }
    });

    self.idsegmansubmod = ko.observable(0).extend({
        required: {
            message: "El submodulo es requerido.",
            params: campos_requeridos
        }
    });

    self.idsegmanprog = ko.observable(0).extend({
        required: {
            message: "El programa es requerido.",
            params: campos_requeridos
        }
    });

    self.xdirurl = ko.observable("~/").extend({
        required: {
            message: "La ruta es requerida.",
            params: campos_requeridos
        }
    });

    self.comboaplicacion = ko.observableArray();
    self.combomodulo = ko.observableArray();
    self.combosubmodulo = ko.observableArray();
    self.comboprograma = ko.observableArray();

    

}
