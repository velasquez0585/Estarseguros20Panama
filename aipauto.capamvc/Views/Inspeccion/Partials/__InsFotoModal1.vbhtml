<fieldset class="form-area">
    <legend>Fotos de la Inspeccion</legend>

    <div>
        <ul id="lista_err_aipinsenc1" class="no-display-validation-message">
            @*   <li class="validation-message" data-bind="validationMessage: itipobaremobr"></li>
                <li class="validation-message" data-bind="validationMessage: itamapiezbaremobr"></li>
                <li class="validation-message" data-bind="validationMessage: imaterpiezbaremobr"></li>*@
        </ul>
        <div data-bind="with: vi_aipinsenc" class="form-row">
            <div class="form-column">
                <div class="form-field-header">
                    Tipo de Inspeccion
                </div>
                <div class="form-field-content">

                    <select disabled data-bind="options: combotipoinsenc, optionsText: 'xvalordescripcion', optionsValue: 'xvalorcodigo', value: itipoinsenc"></select>

                </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    Fecha Creacion
                </div>
                <div class="form-field-content">
                    <span data-bind="datehtml: fcreainsenc" ></span>

                </div>
            </div>
        </div>
         
        <div data-bind="with: vi_aipinsfoto" class="form-row">
            <div class="form-column">
                <div class="form-field-header">
                    Fecha Inspección
                </div>
                <div class="form-field-content">             
                    @*<input class="date-field" type="text" data-bind="datehtml: fcreaaipinsfoto" />  
                    <input class="date-field" type="text" data-bind="timehtml: fcreaaipinsfoto" />*@         
                    <span data-bind="datehtml: fcreaaipinsfoto"></span>
                    <span data-bind="timehtml: fcreaaipinsfoto"></span>

                </div>
            </div>
            <div class="form-column">
                <div class="form-field-header">
                    &nbsp;&nbsp;
                </div>
                <div class="form-field-content">
                    &nbsp;&nbsp;
                </div>
            </div>

            <div class="form-column">
                <div class="form-field-header">
                    Origen
                </div>
                <div class="form-field-content">
                    <span data-bind="text: ioriginsfoto"></span>             
                </div>
            </div>                        
        </div>
    </div>
    <br />
    <br />
    <br />
    <br />
    <script>

    </script>
    <!-- Jssor Slider Begin -->
    <!-- You can move inline styles (except 'top', 'left', 'width' and 'height') to css file or css block. -->
@*    <div class="form-row" id="slider1_container" style="position: relative; top: 0px; left: 0px; width: 600px; height: 300px; float: left; margin-right: 7px">

        <!-- Slides Container -->
        <div u="slides" data-bind="foreach: $root.DownloadFilesResult" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 200px; height: 100px; overflow: hidden;">

            <div><img u="image" data-bind="attr: {src: $data.ruta}" /></div>

        </div>

        <!-- Direction Navigator Skin Begin -->
        <style>
            /* jssor slider direction navigator skin 03 css */
            /*
                    .jssord03l              (normal)
                    .jssord03r              (normal)
                    .jssord03l:hover        (normal mouseover)
                    .jssord03r:hover        (normal mouseover)
                    .jssord03ldn            (mousedown)
                    .jssord03rdn            (mousedown)
                    */
            .jssord03l, .jssord03r, .jssord03ldn, .jssord03rdn {
                position: absolute;
                cursor: pointer;
                display: block;
                background: url(../img/d03.png) no-repeat;
                overflow: hidden;
            }

            .jssord03l {
                background-position: -3px -33px;
            }

            .jssord03r {
                background-position: -63px -33px;
            }

            .jssord03l:hover {
                background-position: -123px -33px;
            }

            .jssord03r:hover {
                background-position: -183px -33px;
            }

            .jssord03ldn {
                background-position: -243px -33px;
            }

            .jssord03rdn {
                background-position: -303px -33px;
            }
        </style>
        <!-- Arrow Left -->
        <span u="arrowleft" data-bind="click: $root.izquierda" class="jssord03l" style="width: 55px; height: 55px; top: 123px; left: 8px;"></span>
        <!-- Arrow Right -->
        <span u="arrowright" data-bind="click: $root.derecha" class="jssord03r" style="width: 55px; height: 55px; top: 123px; right: 8px"></span>

    </div>*@

    <ul class="bxslider" data-bind="foreach: $root.DownloadFilesResult">
        <li><img data-bind="attr: {src: $data.ruta}, click: $root.cargar" /></li>
    </ul>
    <table data-bind="visible: $root.visible">
        <tr>
            <td>
                <div id="divfoto" style="width:501px; float: left; margin-right: 45px;">         
                    <img id="foto_auto" width="500" data-bind="attr: { src: $root.foto }" />
                </div>
            </td>
            <td>
                <div id="map" style="width: 361px; height: 401px;"></div>
            </td>
        </tr>
        <tr>
            <td align="center">
                <img id="rotatebtni" style="/*margin-left:190px*/" src="~/publico/imagenes/rotate_izq.png" data-bind="click: $root.girarImagen_izquierda"/>
                <img id="rotatebtnd" style="/*margin-left:0px*/" src="~/publico/imagenes/rotate_der.png" data-bind="click: $root.girarImagen_derecha"/>
            </td>
        </tr>
        <tr>
            <td align="center">
                <input type="button" data-bind="click: $root.eliminarFoto, visible: $root.visibleElimFoto" value="Eliminar"/>                
            </td>
        </tr>

    </table>

    <p style="text-align: center" data-bind="text: $root.mensajefotos, visible: $root.visiblemensajefotos"></p>
    @*<div data-bind="visible: $root.visible">*@
        @*<div id="divfoto" style="width:501px; float: left; margin-right: 45px;">
         
            <img id="foto_auto" width="500" data-bind="attr: {src: $root.foto}" />
        </div>*@
        @*<div id="map" style="width: 361px; height: 401px;"></div>*@
        
            @*<img id="rotatebtni" style="margin-left:190px" src="~/publico/imagenes/rotate_izq.png" data-bind="click: $root.izq"/>
            <img id="rotatebtnd" style="margin-left:0px" src="~/publico/imagenes/rotate_der.png" data-bind="click: $root.der"/>*@
        
    @*</div>*@
    
    @*<img class="foto_auto" src="~/publico/imagenes/insfoto_30_1.jpg" width="500">*@
    
</fieldset>

@Scripts.Render("~/publico/scripts/terceros/slider/jssor.core.js")
@Scripts.Render("~/publico/scripts/terceros/slider/jssor.slider.js")
@Scripts.Render("~/publico/scripts/terceros/slider/jssor.utils.js")
<link href="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.css" rel="stylesheet" />
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.js"></script>
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.min.js"></script>
@*<script src="http://jqueryrotate.googlecode.com/svn/trunk/jQueryRotate.js"></script>*@
<script src="~/publico/scripts/terceros/jQueryRotate.js"></script>
@*<link href="~/publico/scripts/terceros/multizoom/multizoom.css" rel="stylesheet" />
<script src="~/publico/scripts/terceros/multizoom/multizoom.js"></script>
<img src="~/publico/scripts/terceros/multizoom/spinningred.gif" />*@

<script type="text/javascript">
    

    function vmInsFotoModal1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.vi_aipinsfoto = new vi_aipinsfoto(false);
        self.pagvi_aipinsenc = new paginacion(1, 10, 0, "it.idaipinsenc", "DESC");
        self.sel_idaipinsenc = ko.observable(0);
        self.DownloadFilesResult = ko.observableArray();
        self.contador = ko.observable(0);
        self.horacreaaipinsfoto = ko.observable("");
        self.foto = ko.observable("");
        self.xnombre_foto = ko.observable("");
        self.visible = ko.observable(false);
        self.contador = ko.observable(1);

        self.mensajefotos = ko.observable("");
        self.visiblemensajefotos = ko.observable(false);
        self.visibleElimFoto = ko.observable(false);
        self.esConsulta = ko.observable(false);

        var rotate_angle = 0;
        self.izq = function () {
            $("#foto_auto").imageLens({ lensSize: 200 });
            rotate_angle = rotate_angle - 90;
            $('#foto_auto, .img-dupli').rotate({ angle: rotate_angle });
            
            var ancho = $("#divfoto").width();
            var alto = $("#divfoto").height();
            //alert("alto: " + alto + " x  ancho: " + ancho);
            if (alto >= 400) {
                $("#rotatebtnd").css({ marginTop: "50px" });
                $("#rotatebtni").css({ marginTop: "50px" });
                //$("#rotatebtni").addClass("botfoto");
                //$("#rotatebtnd").addClass("botfoto");
            }
            if (alto < 400) {
                $("#rotatebtnd").css({ marginTop: "0px" });
                $("#rotatebtni").css({ marginTop: "0px" });
                //$("#rotatebtni").removeClass("botfoto");
                //$("#rotatebtnd").removeClass("botfoto");
            }
        }

        self.der = function () {
            $("#foto_auto").imageLens({ lensSize: 200 });
            rotate_angle = rotate_angle + 90;
            $('#foto_auto, .img-dupli').rotate({ angle: rotate_angle });
            
            var ancho = $("#divfoto").width();
            var alto = $("#divfoto").height();
            //alert("alto: " + alto + " x  ancho: " + ancho);
            if (alto >= 400) {
                $("#rotatebtnd").css({ marginTop: "50px" });
                $("#rotatebtni").css({ marginTop: "50px" });
                //$("#rotatebtni").addClass("botfoto");
                //$("#rotatebtnd").addClass("botfoto");
            }
            if (alto < 400) {
                $("#rotatebtnd").css({ marginTop: "0px" });
                $("#rotatebtni").css({ marginTop: "0px" });
                //$("#rotatebtni").removeClass("botfoto");
                //$("#rotatebtnd").removeClass("botfoto");
            }
        }

        var slider = null;
        var map;
        var elevator;
        var latlng = new google.maps.LatLng('44.339565', '-114.960937');
        var styleArray = [
            {
                featureType: "all",
                stylers: [{ visibility: "off" }]
            },
            {
                featureType: "road",
                stylers: [{ visibility: "on" }]
            },
            {
                featureType: "administrative",
                stylers: [{ visibility: "on" }]
            }
        ];
        var mapOptions = {
            center: new google.maps.LatLng(10.473633, 293.076896),
            zoom: 15,
            zoomControl: true,
            zoomControlOptions: {
                style: google.maps.ZoomControlStyle.DEFAULT,
            },
            disableDoubleClickZoom: true,
            mapTypeControl: true,
            mapTypeControlOptions: {
                style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
            },
            scaleControl: true,
            scrollwheel: true,
            panControl: true,
            streetViewControl: true,
            draggable: true,
            overviewMapControl: true,
            overviewMapControlOptions: {
                opened: false,
            },
            mapTypeId: google.maps.MapTypeId.ROADMAP,
        }


        self.llenarcombotipo = function (itipoinsenc) {
            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipinsenc.combotipoinsenc(lista_comunconfvalor);
                self.vi_aipinsenc.itipoinsenc(itipoinsenc);
            })
        }

        self.iniciar = function (vi_aipinsenc, itipoinsenc, esConsulta) {
            
            if (esConsulta == true) {                
                self.esConsulta(true);
            }
            
            //alert(vi_aipinsenc.idaipinsenc());
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.llenarcombotipo(itipoinsenc());
            self.buscar(vi_aipinsenc.idaipinsenc());
            
            if (self.esConsulta() == false) {
                if (self.vi_aipinsenc.iestatinsenc() == "POR PROCESAR" || self.vi_aipinsenc.iestatinsenc() == "POR AUDITAR")
                    self.visibleElimFoto(true);
                else
                    self.visibleElimFoto(false);
            }
            else
                self.visibleElimFoto(false);
            
        }

        self.girarImagen_derecha = function () {
            var grados = -90;
            self.contador(self.contador() + 1);
            
            postajaxjsonbasico("/Inspeccion/girarImagen/", "{'idaipinsenc': " + self.vi_aipinsenc.idaipinsenc() + ", 'xnomarchinsfoto': '" + self.xnombre_foto() + "', 'grados': " + grados + ", 'contador': "+ self.contador() + "}", function (aipinsfoto) {
              
                self.foto(aipinsfoto.ruta);
                $("#foto_auto").imageLens({ lensSize: 200 });

            });
        }

        self.girarImagen_izquierda = function () {
            var grados = 90;
            self.contador(self.contador() + 1);
            
            postajaxjsonbasico("/Inspeccion/girarImagen/", "{'idaipinsenc': " + self.vi_aipinsenc.idaipinsenc() + ", 'xnomarchinsfoto': '" + self.xnombre_foto() + "', 'grados': " + grados + ", 'contador': "+ self.contador() +"}", function (aipinsfoto) {

                self.foto(aipinsfoto.ruta);
                $("#foto_auto").imageLens({ lensSize: 200 });

               
            });

        }

        self.cargar = function (obj) {
            //alert(obj.nombre() + " " + self.vi_aipinsenc.idaipinsenc());
            
            //metodo para copiar la imagen de zoom a la carpeta de publico
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionFotoPorInspeccionEncyXNombFoto/", "{'idaipinsenc': '" + self.vi_aipinsenc.idaipinsenc() + "', 'xnomarchinsfoto': '" + obj.nombre() + "', 'contador': " + self.contador() + "}", function (aipinsfoto) {
                
                self.foto(aipinsfoto.ruta);
                self.visible(true);
                self.xnombre_foto(obj.nombre());
            
                postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesProcesarXidaipinsencandxnomarchinsfoto/", "{'idaipinsenc': '" + self.vi_aipinsenc.idaipinsenc() + "', 'xnomarchinsfoto': '" + obj.nombre() + "'}", function (vi_aipinsfoto) {
                    ko.mapping.fromJS(vi_aipinsfoto, {}, self.vi_aipinsfoto);
                    var hora = vi_aipinsfoto.fcreaaipinsfoto.split('T');
                    self.horacreaaipinsfoto(hora[1]);
                    $("#foto_auto").imageLens({ lensSize: 200 });
                    var mapOptions = {
                        center: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        zoom: 15,
                        zoomControl: true,
                        zoomControlOptions: {
                            style: google.maps.ZoomControlStyle.DEFAULT,
                        },
                        disableDoubleClickZoom: true,
                        mapTypeControl: true,
                        mapTypeControlOptions: {
                            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                        },
                        scaleControl: true,
                        scrollwheel: true,
                        panControl: true,
                        streetViewControl: true,
                        draggable: true,
                        overviewMapControl: true,
                        overviewMapControlOptions: {
                            opened: false,
                        },
                        mapTypeId: google.maps.MapTypeId.ROADMAP,
                    }
                    map = new google.maps.Map($('#map')[0], mapOptions);
                    var marker = new google.maps.Marker({
                        //position: latlng,
                        title: vi_aipinsfoto.xdescinsfoto,
                        position: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        map: map,
                        icon: '/publico/imagenes/solid-pin-red.png',
                        //icon: 'http://google-maps-icons.googlecode.com/files/walking-tour.png',
                        draggable: false
                    });
                });
            });
            
        }
        
        self.buscar = function (tipo) {
            
            var idaipinsenc = 0;
            var nsecinsfoto = 0;
            postajaxjsonbasico("/Inspeccion/ObtenerInspeccionFotoPorInspeccionEnc/", "{idaipinsenc:" + tipo + "}", function (DownloadFilesResult) {
                //self.DownloadFilesResult("");
                ko.mapping.fromJS(DownloadFilesResult, {}, self.DownloadFilesResult);


                if (DownloadFilesResult.length > 0) {
                    self.visiblemensajefotos(false);
                    //self.contador(self.DownloadFilesResult().length);
                    //if (self.DownloadFilesResult().length > 0) {
                    //    var options = {
                    //        $DragOrientation: 3,                                //[Optional] Orientation to drag slide, 0 no drag, 1 horizental, 2 vertical, 3 either, default value is 1 (Note that the $DragOrientation should be the same as $PlayOrientation when $DisplayPieces is greater than 1, or parking position is not 0)
                    //        $DirectionNavigatorOptions: {                       //[Optional] Options to specify and enable direction navigator or not
                    //            $Class: $JssorDirectionNavigator$,              //[Requried] Class to create direction navigator instance
                    //            $ChanceToShow: 2,                               //[Required] 0 Never, 1 Mouse Over, 2 Always
                    //            $AutoCenter: 0,                                 //[Optional] Auto center arrows in parent container, 0 No, 1 Horizontal, 2 Vertical, 3 Both, default value is 0
                    //            $Steps: 4,                                       //[Optional] Steps to go for each navigation request, default value is 1
                    //            $DisplayPieces: 3
                    //        }
                    //    };
                    //    var jssor_slider1 = new $JssorSlider$("slider1_container", options);
                    //}
                    if (self.DownloadFilesResult().length > 0) {
                        //var slider = $('.bxslider').bxSlider({
                        //    minSlides: 3,
                        //    maxSlides: 4,
                        //    slideWidth: 170,
                        //    slideMargin: 10
                        //});
                        slider = $('.bxslider').bxSlider({
                            minSlides: 3,
                            maxSlides: 4,
                            slideWidth: 170,
                            slideMargin: 10
                        });
                        

                        
                    }
                    //alert(self.DownloadFilesResult()[0].nombre());
                    postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesProcesarXidaipinsencandxnomarchinsfoto/", "{'idaipinsenc': '" + tipo + "', 'xnomarchinsfoto': '" + self.DownloadFilesResult()[0].nombre() + "'}", function (vi_aipinsfoto) {
                        ko.mapping.fromJS(vi_aipinsfoto, {}, self.vi_aipinsfoto);
                        var hora = vi_aipinsfoto.fcreaaipinsfoto.split('T');
                        self.horacreaaipinsfoto(hora[1]);
                        var mapOptions = {
                            center: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                            zoom: 15,
                            zoomControl: true,
                            zoomControlOptions: {
                                style: google.maps.ZoomControlStyle.DEFAULT,
                            },
                            disableDoubleClickZoom: true,
                            mapTypeControl: true,
                            mapTypeControlOptions: {
                                style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                            },
                            scaleControl: true,
                            scrollwheel: true,
                            panControl: true,
                            streetViewControl: true,
                            draggable: true,
                            overviewMapControl: true,
                            overviewMapControlOptions: {
                                opened: false,
                            },
                            mapTypeId: google.maps.MapTypeId.ROADMAP,
                        }
                        map = new google.maps.Map($('#map')[0], mapOptions);
                        var marker = new google.maps.Marker({
                            //position: latlng,
                            title: vi_aipinsfoto.xdescinsfoto,
                            position: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                            map: map,
                            icon: '/publico/imagenes/solid-pin-red.png',
                            //icon: 'http://google-maps-icons.googlecode.com/files/walking-tour.png',
                            draggable: false
                        });
                    });
                } else {
                    self.visiblemensajefotos(true);
                    self.mensajefotos("No existen fotos cargadas.");
                }
            })
        }

        self.evento = function () {
            //alert(self.DownloadFilesResult()[0].nombre());
            var i = self.DownloadFilesResult().length;
            //alert("Contador: " + self.contador() + " i: " + i);
            if (i == self.contador()) {
                //alert(self.DownloadFilesResult()[0].nombre());
                self.contador(self.contador() - 1);
            }
            else {
                //alert(self.DownloadFilesResult()[i - self.contador()].nombre());
                if ((self.contador() - 1) == 0) {
                   // alert("entre al if");
                    self.contador(self.DownloadFilesResult().length);
                }
                else {
                    self.contador(self.contador() - 1);
                }

            }
        }

        self.derecha = function () {
            //alert(self.vi_aipinsenc.idaipinsenc());
            if (self.contador() + 1 != self.DownloadFilesResult().length) {
                //alert(self.DownloadFilesResult()[self.contador() + 1].nombre());
                postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesProcesarXidaipinsencandxnomarchinsfoto/", "{'idaipinsenc': '" + self.vi_aipinsenc.idaipinsenc() + "', 'xnomarchinsfoto': '" + self.DownloadFilesResult()[self.contador() + 1].nombre() + "'}", function (vi_aipinsfoto) {
                    ko.mapping.fromJS(vi_aipinsfoto, {}, self.vi_aipinsfoto);
                    var hora = vi_aipinsfoto.fcreaaipinsfoto.split('T');
                    self.horacreaaipinsfoto(hora[1]);
                    var mapOptions = {
                        center: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        zoom: 15,
                        zoomControl: true,
                        zoomControlOptions: {
                            style: google.maps.ZoomControlStyle.DEFAULT,
                        },
                        disableDoubleClickZoom: true,
                        mapTypeControl: true,
                        mapTypeControlOptions: {
                            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                        },
                        scaleControl: true,
                        scrollwheel: true,
                        panControl: true,
                        streetViewControl: true,
                        draggable: true,
                        overviewMapControl: true,
                        overviewMapControlOptions: {
                            opened: false,
                        },
                        mapTypeId: google.maps.MapTypeId.ROADMAP,
                    }
                    map = new google.maps.Map($('#map')[0], mapOptions);
                    var marker = new google.maps.Marker({
                        //position: latlng,
                        title: vi_aipinsfoto.xdescinsfoto,
                        position: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        map: map,
                        icon: '/publico/imagenes/solid-pin-red.png',
                        //icon: 'http://google-maps-icons.googlecode.com/files/walking-tour.png',
                        draggable: false
                    });
                });
            }

            if (self.contador() + 1 == self.DownloadFilesResult().length) {
                self.contador(0);
                //alert("reinicie el contador");
                //alert(self.DownloadFilesResult()[self.contador()].nombre() + " RESETEO contador");
                postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesProcesarXidaipinsencandxnomarchinsfoto/", "{'idaipinsenc': '" + self.vi_aipinsenc.idaipinsenc() + "', 'xnomarchinsfoto': '" + self.DownloadFilesResult()[self.contador()].nombre() + "'}", function (vi_aipinsfoto) {
                    ko.mapping.fromJS(vi_aipinsfoto, {}, self.vi_aipinsfoto);
                    var hora = vi_aipinsfoto.fcreaaipinsfoto.split('T');
                    self.horacreaaipinsfoto(hora[1]);
                    var mapOptions = {
                        center: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        zoom: 15,
                        zoomControl: true,
                        zoomControlOptions: {
                            style: google.maps.ZoomControlStyle.DEFAULT,
                        },
                        disableDoubleClickZoom: true,
                        mapTypeControl: true,
                        mapTypeControlOptions: {
                            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                        },
                        scaleControl: true,
                        scrollwheel: true,
                        panControl: true,
                        streetViewControl: true,
                        draggable: true,
                        overviewMapControl: true,
                        overviewMapControlOptions: {
                            opened: false,
                        },
                        mapTypeId: google.maps.MapTypeId.ROADMAP,
                    }
                    map = new google.maps.Map($('#map')[0], mapOptions);
                    var marker = new google.maps.Marker({
                        //position: latlng,
                        title: vi_aipinsfoto.xdescinsfoto,
                        position: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        map: map,
                        icon: '/publico/imagenes/solid-pin-red.png',
                        //icon: 'http://google-maps-icons.googlecode.com/files/walking-tour.png',
                        draggable: false
                    });
                });
            }
            else {
                self.contador(self.contador() + 1);
                //alert("incremente en 1 el contador");
            }

        }

        self.izquierda = function () {

            //alert("contador: " + self.contador());
            if (self.contador() == 0) {
                self.contador(self.DownloadFilesResult().length - 1);
                //alert(self.DownloadFilesResult()[self.contador()].nombre());
                postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesProcesarXidaipinsencandxnomarchinsfoto/", "{'idaipinsenc': '" + self.vi_aipinsenc.idaipinsenc() + "', 'xnomarchinsfoto': '" + self.DownloadFilesResult()[self.contador()].nombre() + "'}", function (vi_aipinsfoto) {
                    ko.mapping.fromJS(vi_aipinsfoto, {}, self.vi_aipinsfoto);
                    var hora = vi_aipinsfoto.fcreaaipinsfoto.split('T');
                    self.horacreaaipinsfoto(hora[1]);
                    var mapOptions = {
                        center: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        zoom: 15,
                        zoomControl: true,
                        zoomControlOptions: {
                            style: google.maps.ZoomControlStyle.DEFAULT,
                        },
                        disableDoubleClickZoom: true,
                        mapTypeControl: true,
                        mapTypeControlOptions: {
                            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                        },
                        scaleControl: true,
                        scrollwheel: true,
                        panControl: true,
                        streetViewControl: true,
                        draggable: true,
                        overviewMapControl: true,
                        overviewMapControlOptions: {
                            opened: false,
                        },
                        mapTypeId: google.maps.MapTypeId.ROADMAP,
                    }
                    map = new google.maps.Map($('#map')[0], mapOptions);
                    var marker = new google.maps.Marker({
                        //position: latlng,
                        title: vi_aipinsfoto.xdescinsfoto,
                        position: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        map: map,
                        icon: '/publico/imagenes/solid-pin-red.png',
                        //icon: 'http://google-maps-icons.googlecode.com/files/walking-tour.png',
                        draggable: false
                    });
                });
            }
            else {
                //alert(self.DownloadFilesResult()[self.contador() - 1].nombre());
                postajaxjsonbasico("/Inspeccion/ObtenerInspeccionesProcesarXidaipinsencandxnomarchinsfoto/", "{'idaipinsenc': '" + self.vi_aipinsenc.idaipinsenc() + "', 'xnomarchinsfoto': '" + self.DownloadFilesResult()[self.contador() - 1].nombre() + "'}", function (vi_aipinsfoto) {
                    ko.mapping.fromJS(vi_aipinsfoto, {}, self.vi_aipinsfoto);
                    var hora = vi_aipinsfoto.fcreaaipinsfoto.split('T');
                    self.horacreaaipinsfoto(hora[1]);
                    var mapOptions = {
                        center: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        zoom: 15,
                        zoomControl: true,
                        zoomControlOptions: {
                            style: google.maps.ZoomControlStyle.DEFAULT,
                        },
                        disableDoubleClickZoom: true,
                        mapTypeControl: true,
                        mapTypeControlOptions: {
                            style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                        },
                        scaleControl: true,
                        scrollwheel: true,
                        panControl: true,
                        streetViewControl: true,
                        draggable: true,
                        overviewMapControl: true,
                        overviewMapControlOptions: {
                            opened: false,
                        },
                        mapTypeId: google.maps.MapTypeId.ROADMAP,
                    }
                    map = new google.maps.Map($('#map')[0], mapOptions);
                    var marker = new google.maps.Marker({
                        //position: latlng,
                        title: vi_aipinsfoto.xdescinsfoto,
                        position: new google.maps.LatLng(vi_aipinsfoto.xlatcinsfoto, vi_aipinsfoto.xlonginsfoto),
                        map: map,
                        icon: '/publico/imagenes/solid-pin-red.png',
                        //icon: 'http://google-maps-icons.googlecode.com/files/walking-tour.png',
                        draggable: false
                    });
                });
                self.contador(self.contador() - 1);
            }
        }

        self.eliminarFoto = function () {
            postajaxjsonbasico("/Inspeccion/EliminarFotoInspeccion/", "{'idaipinsenc': '" + self.vi_aipinsenc.idaipinsenc() + "', 'xnomarchinsfoto': '" + self.xnombre_foto() + "'}", function (respopera) {
                if (respopera.irespuesta == "1")
                {
                    //alert(respopera.irespuesta);
                    self.visible(false);                                        
                    slider.destroySlider();
                    slider.redrawSlider();
                    self.buscar(self.vi_aipinsenc.idaipinsenc());
                    generar_noty_auto(respopera.xmsjusuario, "success");
                }
                else {
                    //generar_noty_auto(respopera.xmsjusuario, "error");
                    generar_noty_modal(respopera.xmsjusuario, "error");
                }

            });
        }

    }
</script>

@*<script>
        google.maps.event.addDomListener(window, 'load', init);
        var map;
        function init() {
            var mapOptions = {
                center: new google.maps.LatLng(49.93708, -68.184816),
                zoom: 3,
                zoomControl: true,
                zoomControlOptions: {
                    style: google.maps.ZoomControlStyle.DEFAULT,
                },
                disableDoubleClickZoom: true,
                mapTypeControl: true,
                mapTypeControlOptions: {
                    style: google.maps.MapTypeControlStyle.HORIZONTAL_BAR,
                },
                scaleControl: true,
                scrollwheel: true,
                panControl: true,
                streetViewControl: true,
                draggable: true,
                overviewMapControl: true,
                overviewMapControlOptions: {
                    opened: false,
                },
                mapTypeId: google.maps.MapTypeId.ROADMAP,
            }
            var mapElement = document.getElementById('map');
            var map = new google.maps.Map(mapElement, mapOptions);
            var locations = [
    ['Punto', 'undefined', 'undefined', 'undefined', 'undefined', 10.5, -66.916667]
            ];
            for (i = 0; i < locations.length; i++) {
                if (locations[i][1] == 'undefined') { description = ''; } else { description = locations[i][1]; }
                if (locations[i][2] == 'undefined') { telephone = ''; } else { telephone = locations[i][2]; }
                if (locations[i][3] == 'undefined') { email = ''; } else { email = locations[i][3]; }
                if (locations[i][4] == 'undefined') { web = ''; } else { web = locations[i][4]; }
                marker = new google.maps.Marker({
                    icon: 'hollow-pin-blue.png',
                    position: new google.maps.LatLng(locations[i][5], locations[i][6]),
                    map: map,
                    title: locations[i][0],
                    desc: description,
                    tel: telephone,
                    email: email,
                    web: web
                });
            }
        }
    </script>*@

