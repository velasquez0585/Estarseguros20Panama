var vi_aipbarerepu = function (campos_requeridos) {
    var self = this;
    self.idaipbarerepu = ko.observable(0);
    self.combobarerepu = ko.observableArray();
    self.idaipmanrepu = ko.observable(0);
    self.combomanrepu = ko.observableArray();
    self.xnommanrepu = ko.observable("");
    self.faplibarerepu = ko.observable("") ;
    self.iorigbarerepu = ko.observable("").extend({

        required: {
            message: "Origen es requerido.",
        }
    });
    self.comboorigbarerepu = ko.observableArray();
    self.mcostbarerepu = ko.observable(0);
}
