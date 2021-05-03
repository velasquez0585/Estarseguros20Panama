var vi_aipinsenc = function (campos_requeridos) {
    var self = this;
    self.idaipinsenc = ko.observable(0);
    self.idaipactivperi = ko.observable(0);
    self.idaipinsintext = ko.observable(0);
    self.comboinsenc = ko.observableArray();
    self.itipoinsenc = ko.observable("");
    self.combotipoinsenc = ko.observableArray();
    self.idaipinsmotiv = ko.observable(0).extend({
        required: {
            message: "El motivo de la inspección es requerido",
            params: campos_requeridos
        }
    });
    self.xnominsmotiv = ko.observable("");
    
    self.itipoperitinsenc = ko.observable("");
    self.combotipoperitinsenc = ko.observableArray();
    self.iorigeninsenc = ko.observable("");
    self.comboorigeninsenc = ko.observableArray();
    self.idsegmanusuperit = ko.observable(0).extend({
        required: {
            message: "El perito es requerido",
            params: campos_requeridos
        }
    });
    self.combomanusuperit = ko.observableArray();
    self.xcedulaperit = ko.observable("");
    self.xnombresperit = ko.observable("");
    self.xapellidosperit = ko.observable("");
    self.xnombrecompletoperit = ko.observable("");
    self.idsegmanorgperit = ko.observable(0);
    self.combomanorgperit = ko.observableArray();
    self.xnombrecomercialperit = ko.observable("");
    self.idsegmanusuaudit = ko.observable(0);
    self.combomanusuaudit = ko.observableArray();
    self.xcedulaaudit = ko.observable("");
    self.xnombresaudit = ko.observable("");
    self.xapellidosaudit = ko.observable("");
    self.xnombrecompletoaudit = ko.observable("");
    self.idsegmanorgaudit = ko.observable(0);
    self.combomanorgaudit = ko.observableArray();
    self.xnombrecomercialaudit = ko.observable("");
    self.xcedpropinsenc = ko.observable("");
    self.xcedsidoinsenc = ko.observable("");
    self.xplacinsenc = ko.observable("");
    self.xsermotinsenc = ko.observable("");
    self.xsercarrinsenc = ko.observable("");
    self.xnumpolinsenc = ko.observable("");
    self.xnumsininsenc = ko.observable("");
    self.xllavinsenc = ko.observable("");
    self.xnomprodinsenc = ko.observable("");
    self.xnomprodtorinsenc = ko.observable("");
    self.xnomramopolizinsenc = ko.observable("");
    self.xnomsucinsinsenc = ko.observable("");
    self.xnuminspinsenc = ko.observable(""); //numero de inspeccion
    self.fcreainsenc = ko.observable("");
    self.fprocinsenc = ko.observable("");
    self.faudinsenc = ko.observable("");
    self.fultrechinsenc = ko.observable("");
    self.fcancinsenc = ko.observable("");
    self.facepinsenc = ko.observable("");
    self.xdescinsenc = ko.observable("");
    self.iestatinsenc = ko.observable("");
    self.comboestatinsenc = ko.observableArray();
    self.idseglogreg = ko.observable(0);
    self.idaipactivperi = ko.observable(0);
    self.comboactivperi = ko.observableArray();
    self.idcomunmancont = ko.observable(0);
    self.combounmancont = ko.observableArray();
    self.idcomunmanpais = ko.observable(0).extend({
        required: {
            message: "El pais es requerido",
            params: campos_requeridos
        }
    });
    self.combounmanpais = ko.observableArray();
    self.idcomunmanestado = ko.observable(0).extend({
        required: {
            message: "El estado es requerido",
            params: campos_requeridos
        }
    });
    self.combounmanestado = ko.observableArray();
    self.idcomunmanlocalid = ko.observable(0).extend({
        required: {
            message: "La localidad es requerida",
            params: campos_requeridos
        }
    });
    self.combounmanlocalid = ko.observableArray();
    self.xdireccionactivperi = ko.observable("").extend({
        required: {
            message: "La dirección del peritaje es requerida",
            params: campos_requeridos
        },
        maxLength: {
            message: "La dirección no puede tener mas de 50 caracteres",
            params: 50
        }
    });
    self.xtelfmovilactivperi = ko.observable("").extend({
        required: {
            message: "El telefono movil es requerido",
            params: campos_requeridos
        }
    });
    self.xnomcliactivperi = ko.observable("");
    self.xcorreoelectronicoactivperi = ko.observable("").extend({
        required: {
            message: "El email es requerido",
            params: campos_requeridos
        }
    });
    self.xtituactivperi = ko.observable("").extend({
        required: {
            message: "El titulo del peritaje es requerido",
            params: campos_requeridos
        }
    });
    self.fejecactivperi = ko.observable("").extend({
        required: {
            message: "La fecha de la actividad es requerida",
            params: campos_requeridos
        }
    });
    self.ffinejecactivperi = ko.observable("").extend({
        required: {
            message: "La fecha de fin de la actividad es requerida",
            params: campos_requeridos
        }
    });
    self.xdescactivperi = ko.observable("");
    self.ialcanactivperi = ko.observable("");
    self.comboalcanactivperi = ko.observableArray();
    self.iestatactivperi = ko.observable("");
    self.comboestatactivperi = ko.observableArray();
    self.idsegmanusucrea = ko.observable(0);
    self.combomanusucrea = ko.observableArray();
    self.xnombrecompleto = ko.observable("");
    self.fcrearegactivperi = ko.observable("");
}
