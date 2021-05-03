var vi_aipmanrepu = function (campos_requeridos) {
    var self = this;
    self.idaipmanrepu = ko.observable();
    self.combomanrepu = ko.observableArray();
    self.xnommanrepu = ko.observable("");
    self.ipartextdelmanrepu = ko.observable(false);
    self.ipartextmedmanrepu = ko.observable(false);
    self.ipartexttrasmanrepu = ko.observable(false);
    self.ipartintmanrepu = ko.observable(false);
    self.iposdermanrepu = ko.observable(false);
    self.iposizqmanrepu = ko.observable(false);
    self.iposfronmanrepu = ko.observable(false);
    self.xdescmanrepu = ko.observable("");
    self.iestatmanrepu = ko.observable("");
    self.comboestatmanrepu = ko.observableArray();
    self.idseglogreg = ko.observable(0);
    //este campo no esta enlazado en la BD solo se utiliza para determinar el color de la fila seleccionada
    self.xclass = ko.observable("");
}
