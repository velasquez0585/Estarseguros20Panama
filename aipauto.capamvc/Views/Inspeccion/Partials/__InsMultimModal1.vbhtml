<fieldset class="form-area">
    <legend>Multimedia de la Inspeccion</legend>

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



    <div class="tab form-row">
        <ul>
            <li style="float: right;"><a href="#videos">Videos</a></li>
            <li style="float: right;"><a href="#audios">Notas de voz</a></li>
        </ul>
        <div id="videos">

            <div class="row" style="margin-top: 10px; margin-bottom: 10px;" >
                  <input type="button" value="Buscar" data-bind="click: llenarVideos" />
             </div>

            <p style="text-align: center;" data-bind="visible: $root.visiblemsj">No existen videos.</p>

            <div class="form-row" data-bind="visible: $root.visibleSlider">
                <div class="bxsliderVideos" data-bind="foreach: $root.listaVideos">
                    <div class="slide">
                        <img src="@Url.Content("~/publico/imagenes/video-no-disponible-min.jpg")" data-bind="click: $root.cambiarVideo" />

                    </div>
                </div>
            </div>

              @*<video id="Video1" controls="controls" style="border: 1px solid blue; margin-top: 10px;" width="500">
                HTML5 Video is required for this example
            </video>*@

            <div data-bind="visible: visibleVideo" class="form-row">
                <video id="example_video_1" class="video-js vjs-default-skin" controls preload="none"  width="640" height="264" poster="@Url.Content("~/publico/imagenes/video-iniciar.jpg")" data-setup="{}">

                    <!-- Tracks need an ending tag thanks to IE9 -->
                    
                    <p class="vjs-no-js">To view this video please enable JavaScript, and consider upgrading to a web browser that <a href="http://videojs.com/html5-video-support/" target="_blank">supports HTML5 video</a></p>
                </video>

                <div class="row" style="text-align: center; margin-top: 10px;">
                    <input type="button" value="Eliminar Actual" data-bind="click: eliminarVideoActual" />
                </div>

            </div>
        </div>
        <div id="audios">
            <div data-bind="visible: visibleNotas" class="form-row">

                

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
                                        @*<button class="jp-full-screen" role="button" tabindex="0">full screen</button>*@
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
                                <li>&nbsp; Prueba</li>
                            </ul>
                        </div>
                        <div class="jp-no-solution">
                            <span>Update Required</span>
                            To play the media you will need to either update your browser to a recent version or update your <a href="http://get.adobe.com/flashplayer/" target="_blank">Flash plugin</a>.
	
                        </div>
                    </div>
                </div>


                <div class="row" style="text-align: center; margin-top: 10px;">
                    <input type="button" value="Eliminar Actual" data-bind="click: eliminarActual" />
                </div>
                <!-- Fin row-->
            </div>

            <p style="text-align: center;" data-bind="visible: $root.visibleNotasMsj">No existen Notas de voz.</p>
        </div>

    </div>

</fieldset>


<link href="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.css" rel="stylesheet" />
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.js"></script>
<script src="~/publico/scripts/terceros/bxslider-4-master/jquery.bxslider.min.js"></script>

<link href="~/publico/scripts/terceros/jPlayer-2.9.2/dist/skin/estarseguros/css/jplayer.estarseguros.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="~/publico/scripts/terceros/jPlayer-2.9.2/dist/jplayer/jquery.jplayer.min.js"></script>
<script type="text/javascript" src="~/publico/scripts/terceros/jPlayer-2.9.2/dist/add-on/jplayer.playlist.min.js"></script>

<script src="~/publico/scripts/terceros/jQueryRotate.js"></script>



<script type="text/javascript">

    function vmInsMultimediaModal1() {


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
        self.visibleSlider = ko.observable();
        self.visiblemsj = ko.observable();

        self.mensajefotos = ko.observable("");
        self.visiblemensajefotos = ko.observable(false);
        self.visibleElimFoto = ko.observable(false);
        self.esConsulta = ko.observable(false);


        //Videos
        self.visibleVideo = ko.observable(false);
        self.listaVideos = ko.observableArray();
        self.idaipinsenc = ko.observable(0);
        self.itipoinsarch = ko.observable("");
        //Videos

        self.visibleNotas = ko.observable(false);
        self.visibleNotasMsj = ko.observable(false);
        self.listaNotas = ko.observableArray();

        self.idVideoCarga = ko.observable(0);
        self.VisibleBtnBuscarVideo = ko.observable(false);

        //**********************************************************************
        //Modulo de Foto


        //Fin Modulo de Foto
        //**********************************************************************


        //**********************************************************************
        //Modulo de Video

        self.cargarMultimedia = function (vi_aipinsenc) {

            self.idaipinsenc(vi_aipinsenc.idaipinsenc());
            self.llenarVideos("VIDEO");
            ko.mapping.fromJS(vi_aipinsenc, {}, self.vi_aipinsenc);
            self.llenarcombotipo(vi_aipinsenc.itipoinsenc());

            //Audios            
            self.llenarAudios("AUDIO");

        }

        var sliderVideo = $('.bxsliderVideos').bxSlider({
            slideWidth: 200,
            minSlides: 2,
            maxSlides: 4,
            slideMargin: 10
        });

        self.llenarVideos = function (itipoinsarch) {
            if (itipoinsarch != "VIDEO")
                itipoinsarch = "VIDEO";

            self.visibleVideo(false);
            postajaxjsonbasico("/Inspeccion/ObtenerArchivosPorEncYTipo/?idaipinsenc=" + self.idaipinsenc() + "&itipoinsarch=" + itipoinsarch, "", function (lista_videos) {
                self.listaVideos(lista_videos);
                if (lista_videos.length > 0) {
                    self.visibleSlider(true);
                    self.visiblemsj(false);
                    self.VisibleBtnBuscarVideo(true);
                }
                else {
                    self.visibleSlider(false);
                    self.visiblemsj(true);
                    self.VisibleBtnBuscarVideo(false);
                }
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

            
            self.idVideoCarga(obj.idaipinsarch);
            //self.getVideo(obj.xurlinsarch);
           
            var timeStamp = (new Date()).getTime();
            var xNomVideo = obj.xurlinsarch // + "?" + timeStamp;
            //xNomVideo = "http://vjs.zencdn.net/v/oceans.mp4";
            self.visibleVideo(true);
            var player = videojs('example_video_1', { /* Options */ }, function () {
                player.src(xNomVideo);
                player.type ="video/mp4";                
                this.play();
                self.visibleVideo(true);
            });
        }

        self.eliminarVideoActual = function () {
            if (self.idVideoCarga() != 0)
            {
                if (confirm("¿Desea aliminar el video actual?")) {

                    postajaxjsonbasico("/Inspeccion/EliminarArchivoPorid/?idaipinsarch=" + self.idVideoCarga(), "", function (respopera) {
                        if (respopera != null) {
                            if (respopera.irespuesta == "1") {
                                //self.llenarAudios("AUDIO");
                                self.llenarVideos("VIDEO");
                                self.visibleVideo(false);
                                generar_noty_auto(respopera.xmsjusuario, "success");
                            }
                            else {
                                generar_noty_auto(respopera.xmsjusuario, "error");
                            }
                        }


                    });

                }
            }
            


        }

        var myPlaylist = new jPlayerPlaylist({
            jPlayer: "#jquery_jplayer_N",
            cssSelectorAncestor: "#jp_container_N"
        }, [

        ], {
            playlistOptions: {
                enableRemoveControls: false,
                audioFullScreen: false,
            },
            swfPath: "../../dist/jplayer",
            supplied: "webmv, ogv, m4v, oga, mp3",
            useStateClassSkin: true,
            autoBlur: false,
            smoothPlayBar: true,
            keyEnabled: true,
        });

        self.llenarAudios = function (itipoinsarch) {

            postajaxjsonbasico("/Inspeccion/ObtenerArchivosPorEncYTipo/?idaipinsenc=" + self.idaipinsenc() + "&itipoinsarch=" + itipoinsarch, "", function (lista_audios) {
                self.listaNotas(lista_audios);

                if (lista_audios.length > 0) {
                    self.visibleNotas(true);
                    self.visibleNotasMsj(false);
                }
                else {
                    self.visibleNotas(false);
                    self.visibleNotasMsj(true);
                }
                
                //$('.jp-playlist').on('click', '.jp-playlist-item-remove', function (event) {

                //    // Determine song index if necessary
                //    var index = $(this).parents('li').index('.jp-playlist li');

                //    // Retrieve song information, if necessary
                //    var song = myPlaylist.playlist[index];
                //    if (confirm("¿Desea aliminar la nota de voz " + song.title + "?")) {
                //        alert(song.id);
                //    }
                //    else {
                //        myPlaylist.add(song);
                //    }
                //});

                myPlaylist.remove();


                for (var i = 0; i < lista_audios.length; i++) {

                    myPlaylist.add({
                        id: lista_audios[i].idaipinsarch,
                        title: "Nota de Voz " + (i + 1),
                        artist: "Aipauto",
                        mp3: lista_audios[i].xurlinsarch,
                        //mp3: "http://www.jplayer.org/audio/mp3/Miaow-01-Tempered-song.mp3",
                        //oga: "http://www.jplayer.org/audio/ogg/Miaow-01-Tempered-song.ogg",
                        //oga: "http://webapisitfx.estarseguros.com/estarseguros20.capawebapi_Desa/audios/suscripcion/ok/insaudio_21_6.ogg"
                        poster: "@Url.Content("~/publico/imagenes/audio-no-disponible.jpg")"
                    });

                }
            })
        }

        self.eliminarActual = function () {
            if (confirm("¿Desea aliminar la nota de voz " + (myPlaylist.current + 1) + "?")) {

                postajaxjsonbasico("/Inspeccion/EliminarArchivoPorid/?idaipinsarch=" + self.listaNotas()[myPlaylist.current].idaipinsarch, "", function (respopera) {
                    if (respopera != null) {
                        if (respopera.irespuesta == "1") {
                            //self.llenarAudios("AUDIO");
                            myPlaylist.remove(myPlaylist.current);
                            generar_noty_auto(respopera.xmsjusuario, "success");
                        }
                        else {
                            generar_noty_auto(respopera.xmsjusuario, "error");
                        }
                    }


                });

            }


        }

        var video = document.getElementById("Video1");

        self.getVideo = function (url) {
            var fileURL = url; //document.getElementById("videoFile").value;  // get input field
            fileURL = "http://localhost:19789/api/camera/fromvideo/?videoName=Autogestion_Profesional";
            if (fileURL != "") {
                video.src = fileURL;
                video.load();  // if HTML source element is used
                self.vidplay();  // start play
            } else {
                errMessage("Enter a valid video URL");  // fail silently
            }
        }

        //  play video
        self.vidplay = function (evt) {
            //if (video.src == "") {  // on first run, src is empty, go get file
            //    self.getVideo();
            //}
            //button = evt.target; //  get the button id to swap the text based on the state                                    
            if (video.paused) {   // play the file, and display pause symbol
                video.play();
                //button.textContent = "||";
            } else {              // pause the file, and display play symbol  
                video.pause();
                //button.textContent = ">";
            }
        }



        //$(".jp-playlist-item-remove").click(function () {

        //});


        //Fin Modulo de Foto
        //**********************************************************************

    }
</script>


