var aipinsajussinrepu = function (campos_requeridos) {
    var self = this;
    self.idaipinsajussinrepu = ko.observable(0);
    self.idaipinsajussin = ko.observable(0);
    self.comboinsajussin = ko.observableArray();
    self.idaipsusrepu = ko.observable(0);
    self.combosusrepu = ko.observableArray();
    self.idaipsusori = ko.observable(0);
    self.combosusori = ko.observableArray();
    self.idaipbarerepu = ko.observable(0);
    self.combobarerepu = ko.observableArray();
    self.ncantinsajussinrepu = ko.observable(0);
    self.nprecfininsajussinrepu = ko.observable(0);
    self.xdescinsajussinrepu = ko.observable("");
    self.iestatinsajussinrepu = ko.observable("");
    self.comboestatinsajussinrepu = ko.observableArray();
    self.idseglogreg = ko.observable(0);
}
