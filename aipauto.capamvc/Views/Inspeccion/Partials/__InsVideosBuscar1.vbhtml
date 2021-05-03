<fieldset class="form-area">
    <legend>Videos de la Inspección</legend>
    @*<div class="row">
        <div class="form-column">
            <input type="button" value="Buscar" data-bind="click: $root.llenarVideos" />
        </div>
    </div>*@

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
                <span data-bind="datehtml: fcreainsenc"></span>

            </div>
        </div>
    </div>

    <div data-bind="" class="form-row">
        <div class="bxslidervideos" data-bind="foreach: $root.listaVideos">
            <div class="slide">
                <img src="@Url.Content("~/publico/imagenes/video-no-disponible-min.jpg")" data-bind="click: $root.cambiarVideo" />
            </div>
        </div>

    </div>

    @*<div data-bind="visible: listaVideos.length == 0">
        <p>No existen videos disponibles.</p>
    </div>*@

    <div data-bind="visible: visibleVideo" class="form-row">
        <video id="example_video_1" class="video-js vjs-default-skin" controls preload="none" width="640" height="264" poster="@Url.Content("~/publico/imagenes/video-iniciar.jpg")" data-setup="{}">

            <!-- Tracks need an ending tag thanks to IE9 -->
            <p class="vjs-no-js">To view this video please enable JavaScript, and consider upgrading to a web browser that <a href="http://videojs.com/html5-video-support/" target="_blank">supports HTML5 video</a></p>
        </video>
    </div>



    @*<div data-bind="foreach: listaVideos">
        <a data-bind="text: xnombre, click: $root.cambiarVideo"></a>
    </div>*@

</fieldset>

<link href="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.css" rel="stylesheet" />
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.js"></script>
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.min.js"></script>
<script type="text/javascript">


    function vmInsVideosBuscar1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.visibleVideo = ko.observable(false);
        self.listaVideos = ko.observableArray();
        self.idaipinsenc = ko.observable(0);
        self.itipoinsarch = ko.observable("");
        self.iniciar = function () {
            self.llenarVideos();
        }

        self.cargar = function (vi_aipinsenc, itipoinsarch) {

            var sliderVideo = $('.bxslidervideos').bxSlider({
                slideWidth: 200,
                minSlides: 2,
                maxSlides: 4,
                slideMargin: 10
            });

            self.itipoinsarch(itipoinsarch);
            self.idaipinsenc(vi_aipinsenc.idaipinsenc());
            self.llenarVideos();
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.llenarcombotipo(vi_aipinsenc.itipoinsenc());


        }

        

        self.llenarVideos = function () {
           
            postajaxjsonbasico("/Inspeccion/ObtenerArchivosPorEncYTipo/?idaipinsenc=" + self.idaipinsenc() + "&itipoinsarch=" + self.itipoinsarch(), "", function (lista_videos) {
                self.listaVideos(lista_videos);
                sliderVideo.destroySlider();
                sliderVideo.reloadSlider();

            })

        }

        self.llenarcombotipo = function (itipoinsenc) {
            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipinsenc.combotipoinsenc(lista_comunconfvalor);
                self.vi_aipinsenc.itipoinsenc(itipoinsenc);
            })
        }

        self.cambiarVideo = function (obj) {

            var xNomVideo = obj.xurlinsarch;
            self.visibleVideo(true);
            var player = videojs('example_video_1', { /* Options */ }, function () {
                player.src(xNomVideo);
                this.play();
                self.visibleVideo(true);
            });
        }
    }
</script>
