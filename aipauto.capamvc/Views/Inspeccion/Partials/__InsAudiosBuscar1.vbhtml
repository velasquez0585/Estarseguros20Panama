<fieldset class="form-area">
    <legend>Notas de Voz de la Inspección</legend>
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


    <div data-bind="" style="display: none;">
        <div class="bxslider-Audio" data-bind="foreach: $root.listaNotas">
            <div class="slide">
                <img src="@Url.Content("~/publico/imagenes/audio-no-disponible.jpg")" data-bind="click: $root.cambiarNota" />
            </div>
        </div>

    </div>
   
    


    <div data-bind="visible: visibleNota">
        <div id="jquery_jplayer_1" class="jp-jplayer"></div>
        <div id="jp_container_1" class="jp-audio" role="application" aria-label="media player" style="margin: 0 auto;">
            <div class="jp-type-single">
                <div class="jp-gui jp-interface">
                    <div class="jp-controls">
                        <button class="jp-play" role="button" tabindex="0">play</button>
                        <button class="jp-stop" role="button" tabindex="0">stop</button>
                    </div>
                    <div class="jp-progress">
                        <div class="jp-seek-bar">
                            <div class="jp-play-bar"></div>
                        </div>
                    </div>
                    <div class="jp-volume-controls">
                        <button class="jp-mute" role="button" tabindex="0">mute</button>
                        <button class="jp-volume-max" role="button" tabindex="0">max volume</button>
                        <div class="jp-volume-bar">
                            <div class="jp-volume-bar-value"></div>
                        </div>
                    </div>
                    <div class="jp-time-holder">
                        <div class="jp-current-time" role="timer" aria-label="time">&nbsp;</div>
                        <div class="jp-duration" role="timer" aria-label="duration">&nbsp;</div>
                        <div class="jp-toggles">
                            <button class="jp-repeat" role="button" tabindex="0">repeat</button>
                        </div>
                    </div>
                </div>
                <div class="jp-details">
                    <div class="jp-title" aria-label="title">&nbsp;</div>
                </div>
                <div class="jp-no-solution">
                    <span>Update Required</span>
                    To play the media you will need to either update your browser to a recent version or update your <a href="http://get.adobe.com/flashplayer/" target="_blank">Flash plugin</a>.
	
                </div>
            </div>
        </div>
    </div>

    <div class="form-row">
        <div id="jp_container_N" class="jp-video jp-video-270p" role="application" aria-label="media player" style="margin: 0 auto;">
            <div class="jp-type-playlist">
                <div id="jquery_jplayer_N" class="jp-jplayer"></div>
                <div class="jp-gui">
                    <div class="jp-video-play">
                        <button class="jp-video-play-icon" role="button" tabindex="0">play</button>
                    </div>
                    <div class="jp-interface">
                        <div class="jp-progress">
                            <div class="jp-seek-bar">
                                <div class="jp-play-bar"></div>
                            </div>
                        </div>
                        <div class="jp-current-time" role="timer" aria-label="time">&nbsp;</div>
                        <div class="jp-duration" role="timer" aria-label="duration">&nbsp;</div>
                        <div class="jp-controls-holder">
                            <div class="jp-controls">
                                <button class="jp-previous" role="button" tabindex="0">previous</button>
                                <button class="jp-play" role="button" tabindex="0">play</button>
                                <button class="jp-next" role="button" tabindex="0">next</button>
                                <button class="jp-stop" role="button" tabindex="0">stop</button>
                            </div>
                            <div class="jp-volume-controls">
                                <button class="jp-mute" role="button" tabindex="0">mute</button>
                                <button class="jp-volume-max" role="button" tabindex="0">max volume</button>
                                <div class="jp-volume-bar">
                                    <div class="jp-volume-bar-value"></div>
                                </div>
                            </div>
                            <div class="jp-toggles">
                                <button class="jp-repeat" role="button" tabindex="0">repeat</button>
                                <button class="jp-shuffle" role="button" tabindex="0">shuffle</button>
                                <button class="jp-full-screen" role="button" tabindex="0">full screen</button>
                                
                            </div>
                        </div>
                        <div class="jp-details">
                            <div class="jp-title" aria-label="title">&nbsp;</div>
                        </div>
                    </div>
                </div>
                <div class="jp-playlist">
                    <ul>
                        <!-- The method Playlist.displayPlaylist() uses this unordered list -->
                        <li>&nbsp;</li>
                    </ul>
                </div>
                <div class="jp-no-solution">
                    <span>Update Required</span>
                    To play the media you will need to either update your browser to a recent version or update your <a href="http://get.adobe.com/flashplayer/" target="_blank">Flash plugin</a>.
	
                </div>
            </div>
        </div>
        <!-- Fin row-->
    </div>



    @*<div data-bind="foreach: listaVideos">
        <a data-bind="text: xnombre, click: $root.cambiarVideo"></a>
    </div>*@

</fieldset>

<link href="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.css" rel="stylesheet" />
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.js"></script>
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.min.js"></script>

<link href="~/publico/scripts/terceros/jPlayer-2.9.2/dist/skin/blue.monday/css/jplayer.blue.monday.min.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="~/publico/scripts/terceros/jPlayer-2.9.2/dist/jplayer/jquery.jplayer.min.js"></script>
<script type="text/javascript" src="~/publico/scripts/terceros/jPlayer-2.9.2/dist/add-on/jplayer.playlist.min.js"></script>


<script type="text/javascript">


    function vmInsAudiosBuscar1() {
        var self = this;
        self.vi_aipinsenc = new vi_aipinsenc(false);
        self.visibleNota = ko.observable(false);
        self.listaNotas = ko.observableArray();
        self.idaipinsenc = ko.observable(0);
        self.itipoinsarch = ko.observable("");
        self.iniciar = function () {
            self.llenarAudios();
        }

        self.cargar = function (vi_aipinsenc, itipoinsarch) {
            self.itipoinsarch(itipoinsarch);
            self.idaipinsenc(vi_aipinsenc.idaipinsenc());
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.llenarAudios();
            self.llenarcombotipo(vi_aipinsenc.itipoinsenc());
        }

        var slider = $('.bxslider-Audio').bxSlider({
            slideWidth: 200,
            minSlides: 2,
            maxSlides: 4,
            slideMargin: 10
        });

        var myPlaylist = new jPlayerPlaylist({
            jPlayer: "#jquery_jplayer_N",
            cssSelectorAncestor: "#jp_container_N"
        }, [

        ], {
            playlistOptions: {
                enableRemoveControls: true
            },
            swfPath: "../../dist/jplayer",
            supplied: "webmv, ogv, m4v, oga, mp3",
            useStateClassSkin: true,
            autoBlur: false,
            smoothPlayBar: true,
            keyEnabled: true,
            audioFullScreen: true
        });


        self.llenarAudios = function () {

            postajaxjsonbasico("/Inspeccion/ObtenerArchivosPorEncYTipo/?idaipinsenc=" + self.idaipinsenc() + "&itipoinsarch=" + self.itipoinsarch(), "", function (lista_videos) {
                self.listaNotas(lista_videos);
                slider.destroySlider();
                slider.reloadSlider();

                for (var i = 0; i < lista_videos.length; i++) {

                    myPlaylist.add({
                        title: "Nota de Voz " + (i + 1),
                        artist: "Aipauto",
                        mp3: lista_videos[i].xurlinsarch,
                        poster: "@Url.Content("~/publico/imagenes/audio-no-disponible.jpg")"
                    });

                }
            })
        }

        self.eliminarActual = function(){
            alert(myPlaylist.current);
        }

        self.llenarcombotipo = function (itipoinsenc) {
            var xconcepto = "ITIPOINSENC";
            postajaxjsonbasico("/Comun/ObtenerValores/", "{'xconcepto': '" + xconcepto + "'}", function (lista_comunconfvalor) {
                self.vi_aipinsenc.combotipoinsenc(lista_comunconfvalor);
                self.vi_aipinsenc.itipoinsenc(itipoinsenc);
            })
        }


        self.cambiarNota = function (obj) {

            var xNomVideo = obj.xurlinsarch;

            xNomVideo = 'http://webapisitfx.estarseguros.com/estarseguros20.capawebapi_Desa/audios/suscripcion/ok/Sleep Away.mp3';
            self.visibleNota(true);

        }
    }
</script>
