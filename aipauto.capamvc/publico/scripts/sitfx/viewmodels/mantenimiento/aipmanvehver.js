var aipmanvehver = function (campos_requeridos) {
    var self = this;
    self.idaipmanvehver = ko.observable(0);
    self.idaipmanvehmod = ko.observable(0).extend({
        required: {
            message: "El modelo es requerido",
            params: campos_requeridos
        }
    });
    self.combomanvehmod = ko.observableArray();
    self.xnommanvehver = ko.observable("").extend({
        required: {
            message: "El nombre de la versión es requerido",
            params: campos_requeridos
        }
    });
    self.naniomanvehver = ko.observable(0);
    self.xdescmanvehver = ko.observable("");
    self.iestatmanvehver = ko.observable("");
    self.comboestatmanvehver = ko.observableArray();
    self.idseglogreg = ko.observable(0);
}
