/*  
    http://www.dailycoding.com/ 
*/
(function ($) {
    $.fn.imageLens = function (options) {

        var defaults = {
            lensSize: 100,
            borderSize: 4,
            borderColor: "#888"
        };
        var options = $.extend(defaults, options);
        var lensStyle = "background-position: 0px 0px;width: " + String(options.lensSize) + "px;height: " + String(options.lensSize)
            + "px;float: left;display: none;z-index:9999;border-radius: " + String(options.lensSize / 2 + options.borderSize)
            + "px;border: " + String(options.borderSize) + "px solid " + options.borderColor 
            + ";background-repeat: no-repeat;position: absolute;";

        return this.each(function () {
            obj = $(this);

            var offset = $(this).offset();

            // Creating lens
            $("#lent-ratio").remove();
            var target = $("<div id='lent-ratio' style='" + lensStyle + "' class='" + options.lensCss + "'>&nbsp;</div>").appendTo($("body"));
            var targetSize = target.size();

            // Calculating actual size of image
            var imageSrc = options.imageSrc ? options.imageSrc : $(this).attr("src");
            $(".img-dupli").remove();
            //var Array_ruta = imageSrc.split('/');
            //var pos = Array_ruta.length - 1;
            ////alert(Array_ruta[pos]);
            //var nombre_archivo = Array_ruta[pos];
            //var ruta_zoom = "";
            //for (var i = 0; i < Array_ruta.length - 1; i++) {
            //    if (i > 0) { ruta_zoom += "/" }
            //    ruta_zoom += Array_ruta[i];
            //}
            
            //var img_zoom = ruta_zoom + "/zoom/" + nombre_archivo;

            //var imageTag = "<img class='img-dupli' style='display:none;' src='" + img_zoom + "' />";
            var imageTag = "<img class='img-dupli' style='display:none;' src='" + imageSrc + "' />";

            var widthRatio = 0;
            var heightRatio = 0;

            $(imageTag).load(function () {
                widthRatio = $(this).width() / obj.width();
                heightRatio = $(this).height() / obj.height();
                //alert(widthRatio + " - hei " + heightRatio);
            }).appendTo($(this).parent());

            //target.css({ backgroundImage: "url('" + img_zoom + "')" });
            target.css({ backgroundImage: "url('" + imageSrc + "')" });

            
            target.mousemove(setPosition);
            $(this).mousemove(setPosition);

            function setPosition(e) {

                var leftPos = parseInt(e.pageX - offset.left);
                var topPos = parseInt(e.pageY - offset.top);

                if (leftPos < 0 || topPos < 0 || leftPos > obj.width() || topPos > obj.height()) {
                    target.hide();
                }
                else {
                    target.show();

                    leftPos = String(((e.pageX - offset.left) * widthRatio - target.width() / 2) * (-1));
                    topPos = String(((e.pageY - offset.top) * heightRatio - target.height() / 2) * (-1));
                    target.css({ backgroundPosition: leftPos + 'px ' + topPos + 'px' });

                    leftPos = String(e.pageX - target.width() / 2);
                    topPos = String(e.pageY - target.height() / 2);
                    target.css({ left: leftPos + 'px', top: topPos + 'px' });
                }
            }
        });
    };
})(jQuery);