<div id="dlg_agendaperitajesmodal1" class="dialognoauto" title="Lista de peritajes">
    @Html.Partial("__AgendaPeritajesModal1")
</div>
<div id="dlg_agendaperitajeagregar1" class="dialognoauto" title="Agregar/Modificar peritaje">
    @Html.Partial("__AgendaPeritajesAgregar1")
</div>

<script type="text/javascript">

    var vmagendaactividadesmodal1 = new vmagendaactividadesmodal1();
    ko.applyBindings(vmagendaactividadesmodal1, $('#dlg_agendaperitajesmodal1')[0]);

    //-----------------------------------------------------------------------------------------------
    var vmagendaperitajesgrid1 = new vmagendaperitajesgrid1();
    ko.applyBindings(vmagendaperitajesgrid1, $('#div_agendaaperitajesgrid1')[0]);

    //-----------------------------------------------------------------------------------------------
    var vmagendaperitajeagregar1 = new vmagendaperitajeagregar1();
    ko.applyBindings(vmagendaperitajeagregar1, $('#dlg_agendaperitajeagregar1')[0]);

    //-----------------------------------------------------------------------------------------------

    /*INICIO CODIGO DEL FULLCALENDAR*/
    $(function () {
        var idsegmanorg = 0;//valor del querystring, posicion 1
        var idperito = 0;//valor del querystring, posicion 2
        var idintermediacion = 0;//valor del querystring, posicion 3
        $('#idintermediacion').val(idintermediacion);

        llenarcombosucursal();//se llena primero el combo del sucursal antes de llamar al obtener valores del querystring esto para asignar idsegmanorg cuando ya este lleno el combo de susursal
        // el obtener los valores del querystring se llaman en el metodo de llenarcombosucursal

        //llenarcomboperitos(false);
        var date = new Date();
        var d = date.getDate();
        var m = date.getMonth();
        var y = date.getFullYear();
        var calendar = $('#calendar').fullCalendar({
            theme: true,
            defaultView: 'agendaWeek',
            firstDay: 1,
            slotDuration: '00:45:00',
            monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
            monthNamesShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
            dayNames: ['Domingo', 'Lunes', 'Martes', 'Miercoles',
            'Jueves', 'Viernes', 'Sábado'],
            dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sab'],
            buttonText:
             {
                 prev: ' ◄ ',
                 next: ' ► ',
                 prevYear: ' &lt;&lt; ',
                 nextYear: ' &gt;&gt; ',
                 today: 'hoy',
                 month: 'mes',
                 week: 'semana',
                 day: 'día'
             },
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'agendaDay,agendaWeek,month'
            },
            editable: true,
            selectable: true,
            selectHelper: true,
            allDayDefault: false,
            select: function (start, end, allDay) {
                
                var view = $('#calendar').fullCalendar('getView');                
                var anio = $.fullCalendar.formatDate(start, 'yyyy');
                var mes = $.fullCalendar.formatDate(start, 'MM');
                var mestexto = $.fullCalendar.formatDate(start, 'MMMM');//,new Locale("es","ES"));
                var dia = $.fullCalendar.formatDate(start, 'dd');
                var anioFin = $.fullCalendar.formatDate(end, 'yyyy');
                var mesFin = $.fullCalendar.formatDate(end, 'MM');
                var diaFin = $.fullCalendar.formatDate(end, 'dd');

                
                var fechaEjecucion = dia + "/" + mes + "/" + anio;
                var fechaFin = diaFin + "/" + mesFin + "/" + anioFin;
                var tipo = "MOV";
                var perito = $('#selectPer').val();
                var sucursal = $('#selectSuc').val();

               
                $(function () {
                    vmagendaperitajeagregar1.limpiar();
                    vmagendaperitajeagregar1.visibleDivModificar(false);
                    vmagendaperitajeagregar1.fecha(fechaEjecucion);
                    vmagendaperitajeagregar1.fechaFin(fechaFin);
                    vmagendaperitajesgrid1.idsegmanusuperit(perito);                                                            
                    
                    //vmagendaperitajesgrid1.idsegmanorg(sucursal);
                    
                    vmagendaperitajesgrid1.fechaEjecucion(fechaEjecucion);
                });
                if ((perito != 0) && (allDay==false)) {
                    if ((view.name == "agendaDay") || (view.name == "agendaWeek"))  {
                        //vmagendaperitajesgrid1.buscar_peritajes(tipo, fechaEjecucion);
                        vmagendaperitajeagregar1.llenarcboidcmnmanestad(9);
                        vmagendaactividadesmodal1.vmdia(dia);
                        vmagendaactividadesmodal1.vmmes(mestexto);
                        vmagendaactividadesmodal1.vmanio(anio);
                        
                        //vmagendaactividadesmodal1.obtenerusuarioconectado();
                        var horaI = $.fullCalendar.formatDate(start, 'HH');
                        var minutosI = $.fullCalendar.formatDate(start, 'mm');
                        var horaF = $.fullCalendar.formatDate(end, 'HH');
                        var minutosF = $.fullCalendar.formatDate(end, 'mm');
                        vmagendaperitajeagregar1.llenarcombohoras(horaI, horaF);
                        vmagendaperitajeagregar1.llenarcombominutos(minutosI, minutosF);
                        vmagendaperitajeagregar1.visibleDivAgregar(true);
                        //vmagendaperitajeagregar1.llenarcbotipoinsenc("");
                        
                        vmagendaperitajeagregar1.idsegmanusuperit(perito);                        
                        vmagendaperitajeagregar1.ObtenerSucursalUsuario(perito);
                        vmagendaperitajeagregar1.idaipinsintext($('#idintermediacion').val());
                        //alert(idintermediacion);                                                
                        vmagendaperitajeagregar1.ObtenerDatosPendiente($('#selectSuc').val(), $('#idintermediacion').val());                        
                    }
                    else if (view.name == "month") {
                        vmagendaperitajesgrid1.buscar_peritajes(tipo, fechaEjecucion);
                    }

                    
                    $('#dlg_agendaperitajeagregar1').dialog({
                        width: "65%"
                    });
                    $('#dlg_agendaperitajeagregar1').dialog("open");
                    $("#dlg_agendaperitajeagregar1").dialog({
                        close: function (event, ui) {
                            $('#calendar').fullCalendar('removeEvents');
                            $('#calendar').fullCalendar('refetchEvents');
                        }
                    });
                }
            },
            eventResize: function (event, dayDelta, minuteDelta, revertFunc) {

            },
            eventDragStop: function (event, jsEvent, ui, view) {

            },
            eventClick: function (calEvent, jsEvent, view) {
                var view = $('#calendar').fullCalendar('getView');
                var anio = $.fullCalendar.formatDate(calEvent.start, 'yyyy');
                var mes = $.fullCalendar.formatDate(calEvent.start, 'MM');
                var mestexto = $.fullCalendar.formatDate(calEvent.start, 'MMMM');//,new Locale("es","ES"));
                var dia = $.fullCalendar.formatDate(calEvent.start, 'dd');
                var fechaEjecucion = dia + "/" + mes + "/" + anio;
                var tipo = "MOV";
                if ((view.name == "agendaDay") || (view.name == "agendaWeek")) {
                    var horaI = $.fullCalendar.formatDate(calEvent.start, 'HH');
                    var minutosI = $.fullCalendar.formatDate(calEvent.start, 'mm');
                    var horaF = $.fullCalendar.formatDate(calEvent.end, 'HH');
                    var minutosF = $.fullCalendar.formatDate(calEvent.end, 'mm');
                    var diaF = $.fullCalendar.formatDate(calEvent.end, 'dd');
                    var mesF = $.fullCalendar.formatDate(calEvent.end, 'MM');
                    var anioF = $.fullCalendar.formatDate(calEvent.end, 'yyyy');
                    var fechaFin = diaF + "/" + mesF + "/" + anioF;
                    //vmagendaperitajeagregar1.llenarcombohoras(horaI, horaF);
                    //vmagendaperitajeagregar1.llenarcombominutos(minutosI, minutosF);
                    var perito = $('#selectPer').val();
                }
                if (isNaN(calEvent.title) == true) {

                    postajaxjsonbasico("/Inspeccion/ObtenerInspeccionPorId/", "{'idaipinsenc':'" + calEvent.id + "'}", function (vi_aipinsenc) {
                        vmagendaperitajeagregar1.fecha(fechaEjecucion);
                        vmagendaperitajeagregar1.fechaFin(fechaFin);
                        vmagendaperitajeagregar1.cargar(vi_aipinsenc);
                        vmagendaperitajeagregar1.llenarcombohoras(horaI, horaF);
                        vmagendaperitajeagregar1.llenarcombominutos(minutosI, minutosF);
                        vmagendaperitajesgrid1.fechaEjecucion(fechaEjecucion);
                        vmagendaperitajesgrid1.idsegmanusuperit($('#selectPer').val());
                        vmagendaperitajesgrid1.buscar_peritajes(tipo, fechaEjecucion);
                        vmagendaperitajeagregar1.visibleDivAgregar(false);

                        vmagendaperitajeagregar1.idaipinsintext(idintermediacion);

                    });
                    $('#dlg_agendaperitajeagregar1').dialog({
                        width: "65%"
                    });
                    $('#dlg_agendaperitajeagregar1').dialog("open");
                    $("#dlg_agendaperitajeagregar1").dialog({
                        close: function (event, ui) {
                            $('#calendar').fullCalendar('removeEvents');
                            $('#calendar').fullCalendar('refetchEvents');
                        }
                    });
                    //$('#textboxNombreTripulante').focus();
                }
                else {
                    vmagendaperitajesgrid1.idsegmanusuperit($('#selectPer').val());
                    vmagendaperitajesgrid1.buscar_peritajes(tipo, fechaEjecucion);
                    vmagendaactividadesmodal1.vmdia(dia);
                    vmagendaactividadesmodal1.vmmes(mestexto);
                    vmagendaactividadesmodal1.vmanio(anio);
                    vmagendaactividadesmodal1.obtenerusuarioconectado();
                   
                    
                    vmagendaperitajesgrid1.fechaEjecucion(fechaEjecucion);
                    $('#dlg_agendaperitajesmodal1').dialog("open");
                    $("#dlg_agendaperitajesmodal1").dialog({
                        close: function (event, ui) {
                            $('#calendar').fullCalendar('removeEvents');
                            $('#calendar').fullCalendar('refetchEvents');
                        }
                    });
                }
            },
            eventRender: function (calEvent, element, view) {
                if (calEvent.custom_title) {
                    element[0].innerHTML = element[0].innerHTML.replace(calEvent.title,
                calEvent.custom_title);
                }
            },
            events: function (start, ends, callback) {
                var mesActual = parseInt(getMonth()) + 1;
                if (mesActual < 10)
                    mesActual = "0" + mesActual;
                var anioActual = getYear();
                var cuentaDiasMesActual = cuentaDiasMes(mesActual, anioActual);
                var perito = $('#selectPer').val();
                if (perito == null) {
                    perito = 0;
                }
                $('#calendar').fullCalendar('removeEvents');
                var view = $('#calendar').fullCalendar('getView');
                if (((view.name == "agendaDay") || (view.name == "agendaWeek")) && (perito != 0)) {
                    var tipoActividad = "PUBLICA"; //$('#selectTipoAct').val();

                    vmagendaperitajeagregar1.idsegmanusuperit(perito);
                    vmagendaperitajeagregar1.ObtenerSucursalUsuario(perito);
                    var dia_desd = start.getDate();
                    var mes_desd = start.getMonth();
                    var anio_desd = start.getFullYear();
                    if (mes_desd == 0) {
                        mes_desd = "12";
                        anio_desd = start.getFullYear() - 1;
                    }
                    //alert("mes_desd: " + mes_desd + " anio_desd: " + anio_desd);
                    var fecha_desde = anio_desd + "/" + mes_desd + "/01";// + dia_desd;
                    var dia_hasta = ends.getDate();
                    var mes_hasta = ends.getMonth() + 2;
                    var anio_hasta = ends.getFullYear();
                    if (mes_hasta == 13) {
                        mes_hasta = "01";
                        anio_hasta = ends.getFullYear() + 1;
                    }
                    //alert("mes_hasta: " + mes_hasta + " anio_hasta: " + anio_hasta);
                    var fecha_hasta = anio_hasta + "/" + mes_hasta + "/" + cuentaDiasMesActual;
                    postajaxjsonbasico("/Agenda/Obtener_Eventos/", "{'start': '" + fecha_desde + "', 'ends': '" + fecha_hasta + "', 'ialcanactivperi': '" + tipoActividad + "', 'idsegmanusuperit': '" + perito + "'}", function (respuesta) {
                        for (var i = 0; i < respuesta.length ; i++) {
                            var id = respuesta[i].idaipinsenc;
                            var inicio = respuesta[i].fejecactivperi;
                            var fin = respuesta[i].ffinejecactivperi;
                            var titulo = respuesta[i].xplacinsenc + " - " + respuesta[i].xtituactivperi;
                            var horaSalida = inicio.substring(11, 16);
                            var horaLlegada = fin.substring(11, 16);
                            var usuarioCreador = respuesta[i].xnombrecompleto;
                            //var usuarioCreador1 = usuarioCreador.split('"');
                            //usuarioCreador = usuarioCreador1[1];
                            var listaColores = new Array();
                            listaColores[0] = '#B0ADAA';
                            listaColores[1] = '#A2F988';
                            listaColores[2] = '#88C4F9';
                            listaColores[3] = '#F9F17D';
                            listaColores[4] = '#F7BE81';
                            listaColores[5] = '#F9C288';
                            listaColores[6] = '#F98888';
                            listaColores[7] = '#00ffff';
                            listaColores[8] = '#F485F0';
                            listaColores[9] = '#F9F17D';
                            listaColores[10] = '#D55B7E';
                            listaColores[11] = '#5ACFCD';
                            listaColores[12] = '#D62D9B';
                            listaColores[13] = '#956AF2';
                            listaColores[14] = '#A4AF09';
                            listaColores[15] = '#07C40A';
                            listaColores[16] = '#537AEF';
                            listaColores[17] = '#EFB653';
                            listaColores[18] = '#D8E2F9';
                            listaColores[19] = '#DEF7C6';
                            listaColores[20] = '#CBD962';
                            var numeroColor = Math.floor((Math.random() * 20) + 1);  //Funcion randon entre 1 y 20
                            $("#calendar").fullCalendar('renderEvent',
                                {

                                    id: id,
                                    title: titulo,
                                    custom_title: '<b>' + titulo + '</b>' + '<br>' + '<br>' + '<b>Inicia:</b>' + '<br>' + inicio.substring(8, 10) + '/' + inicio.substring(5, 7) + '/' + inicio.substring(0, 4) + ' - ' + horaSalida + '<br>' + '<br>' + '<b>Finaliza:</b>' + '<br>' + fin.substring(8, 10) + '/' + fin.substring(5, 7) + '/' + fin.substring(0, 4) + ' - ' + horaLlegada + '<br>' + '<br>' + '<b>Creador:</b>' + '<br>' + usuarioCreador,
                                    start: inicio,
                                    end: fin,
                                    allDay: false,
                                    color: 'black',
                                    textColor: 'black',
                                    backgroundColor: listaColores[numeroColor]
                                });
                        }
                    });
                    postajaxjsonbasico("/Agenda/ObtenerContadorEventos/", "{'mes': '" + mesActual + "', 'anio': '" + anioActual + "', 'idsegmanusuperit': '" + perito + "'}", function (lista_contadoreventos) {
                        for (var i = 1; i <= cuentaDiasMesActual; i++) {
                            if (i < 10)
                                var dia = "0" + i;
                            else
                                var dia = i;
                            //var ContPriv = lista_contadoreventos[i - 1].contadorprivados;
                            var ContPub = lista_contadoreventos[i - 1].contadorpublicos;
                            //var ContPubOtros = lista_contadoreventos[i - 1].contadorpublicosotros;
                            var listaColores = new Array();
                            listaColores[0] = '#B0ADAA';
                            listaColores[1] = '#A2F988';
                            listaColores[2] = '#88C4F9';
                            listaColores[3] = '#F9F17D';
                            listaColores[4] = '#F7BE81';
                            listaColores[5] = '#F9C288';
                            listaColores[6] = '#F98888';
                            listaColores[7] = '#00ffff';
                            listaColores[8] = '#F485F0';
                            listaColores[9] = '#F9F17D';
                            listaColores[10] = '#D55B7E';
                            listaColores[11] = '#5ACFCD';
                            listaColores[12] = '#D62D9B';
                            listaColores[13] = '#956AF2';
                            listaColores[14] = '#A4AF09';
                            listaColores[15] = '#07C40A';
                            listaColores[16] = '#537AEF';
                            listaColores[17] = '#EFB653';
                            listaColores[18] = '#D8E2F9';
                            listaColores[19] = '#DEF7C6';
                            listaColores[20] = '#CBD962';
                            if (ContPub != 0) {
                                var numeroColor = Math.floor((Math.random() * 20) + 1);  //Funcion randon entre 1 y 20
                                //var numeroColor = 3; //Amarillo
                            }
                            else {
                                var numeroColor = 0
                            }
                            $("#calendar").fullCalendar('renderEvent',
                                    {
                                        title: '',
                                        start: anioActual + "-" + mesActual + "-" + dia,//'2013-12-11T14:30:00',
                                        custom_title: '<div style="color:#000000;background-color:#ffffff;text-align:center;"><div style="height:0px;"> </span>&nbsp;<span style="font-size:12px;color:#000000;">' + ContPub + '</div></div>',
                                        color: '#ffffff',
                                        allDay: true,
                                        backgroundColor: listaColores[numeroColor]
                                    });
                        }
                    });
                };
                if ((view.name == "month") && (perito != 0)) {
                    var tipoActividad = "PUBLICA";
                    //vmactencagregar1.idragmanaero(perito);
                    var dia_desd = start.getDate();
                    var mes_desd = start.getMonth() + 1;
                    var anio_desd = start.getFullYear();
                    var fecha_desde = anio_desd + "/" + mes_desd + "/" + dia_desd;
                    var dia_hasta = ends.getDate();
                    var mes_hasta = ends.getMonth() + 1;
                    var anio_hasta = ends.getFullYear();
                    var fecha_hasta = anio_hasta + "/" + mes_hasta + "/" + dia_hasta;
                    postajaxjsonbasico("/Agenda/ObtenerContadorEventos/", "{'mes': '" + mesActual + "', 'anio': '" + anioActual + "', 'idsegmanusuperit': '" + perito + "'}", function (lista_contadoreventos) {
                        for (var i = 1; i <= cuentaDiasMesActual; i++) {
                            if (i < 10)
                                var dia = "0" + i;
                            else
                                var dia = i;
                            var ContPub = lista_contadoreventos[i - 1].contadorpublicos;
                            var listaColores = new Array();
                            listaColores[0] = '#B0ADAA';
                            listaColores[1] = '#A2F988';
                            listaColores[2] = '#88C4F9';
                            listaColores[3] = '#F9F17D';
                            listaColores[4] = '#F7BE81';
                            listaColores[5] = '#F9C288';
                            listaColores[6] = '#F98888';
                            listaColores[7] = '#00ffff';
                            listaColores[8] = '#F485F0';
                            listaColores[9] = '#F9F17D';
                            listaColores[10] = '#D55B7E';
                            listaColores[11] = '#5ACFCD';
                            listaColores[12] = '#D62D9B';
                            listaColores[13] = '#956AF2';
                            listaColores[14] = '#A4AF09';
                            listaColores[15] = '#07C40A';
                            listaColores[16] = '#537AEF';
                            listaColores[17] = '#EFB653';
                            listaColores[18] = '#D8E2F9';
                            listaColores[19] = '#DEF7C6';
                            listaColores[20] = '#CBD962';
                            if (ContPub != 0) {
                                var numeroColor = Math.floor((Math.random() * 20) + 1);  //Funcion randon entre 1 y 10
                                //var numeroColor = 3; //Amarillo
                            }
                            else {
                                var numeroColor = 0
                            }
                            $("#calendar").fullCalendar('renderEvent',
                                    {
                                        title: '',
                                        start: anioActual + "-" + mesActual + "-" + dia,//'2013-12-11T14:30:00',
                                        custom_title: '<div style="color:#000000;background-color:#ffffff;text-align:center;"><div style="height:0px;"> </span>&nbsp;<span style="font-size:12px;color:#000000;">' + ContPub + '</div></div>',
                                        //custom_title: '<div style="color:#000000;background-color:#ffffff;text-align:center;"><div style="height:0px;"><span style="font-size:12px;background-color:#00ff00;color:#000000; margin-right: 30px;">' + ContPriv + '</span>&nbsp;<span style="font-size:12px;background-color:#ffff00;color:#000000;">' + ContPub + '</span>&nbsp;<span style="font-size:12px;background-color:#00ffff;color:#000000;margin-left: 30px;">' + ContPubOtros + '</span></div></div>',
                                        color: '#ffffff',
                                        allDay: true,
                                        backgroundColor: listaColores[numeroColor]
                                    });
                        }
                    });

                }
            },
            viewDisplay: function (view) {
                if ((view.name == "agendaDay") || (view.name == "agendaWeek")) {
                    $('#selectTipoAct').removeAttr("disabled");
                }
                else if (view.name == "month") {
                    $('#selectTipoAct').attr("disabled", "disabled");
                }
                $('#calendar').fullCalendar('refetchEvents');
            }
        });

    });
    function llenarcomboperitos(porsucursal) {

        if (porsucursal) {

            var _sucursal = $('#selectSuc').val();

            postajaxjsonbasico("/Agenda/ObtenerComboPeritosPorUsuarioYOrg/?idsegmanorg=" + _sucursal, {}, function (lista_vi_segusudetperf2) {
                $("#selectPer").html("");

                if (lista_vi_segusudetperf2.length > 0) {

                    for (var i = 0; i < lista_vi_segusudetperf2.length; i++) {
                        var select = $("#selectPer");

                        var option = "<option value=" + lista_vi_segusudetperf2[i].idsegmanusu + " >" + lista_vi_segusudetperf2[i].xnombrecompleto + "</option>"
                        select.append(option);
                        //var comboperitos = document.getElementById("selectPer");
                        //var newOption = document.createElement("option");
                        //newOption.value = lista_vi_segusudetperf2[i].idsegmanusu;
                        //newOption.text = lista_vi_segusudetperf2[i].xnombrecompleto;
                        //comboperitos.removeAllOptions(comboperitos, true);
                        //comboperitos.add(newOption, comboperitos.options[null]);
                    }
                } else {
                    var select = $("#selectPer");

                    var option = "<option value='0' >SELECCIONE...</option>"
                    select.append(option);
                }
                //if (idperito>0)
                //{
                //    $("#selectPer").val(idperito);
                //}
            });
        }
        //else {
        //    postajaxjsonbasico("/Agenda/ObtenerComboPeritosPorUsuario/", {}, function (lista_vi_segusudetperf2) {
        //        $("#selectPer").html("");
        //        if (lista_vi_segusudetperf2.length > 0) {
        //            for (var i = 0; i < lista_vi_segusudetperf2.length; i++) {
        //                var select = $("#selectPer");

        //                var option = "<option value=" + lista_vi_segusudetperf2[i].idsegmanusu + " >" + lista_vi_segusudetperf2[i].xnombrecompleto + "</option>"
        //                select.append(option);
        //                //var comboperitos = document.getElementById("selectPer");
        //                //var newOption = document.createElement("option");
        //                //newOption.value = lista_vi_segusudetperf2[i].idsegmanusu;
        //                //newOption.text = lista_vi_segusudetperf2[i].xnombrecompleto;
        //                //comboperitos.removeAllOptions(comboperitos, true);
        //                //comboperitos.add(newOption, comboperitos.options[null]);
        //            }
        //        } else {
        //            var select = $("#selectPer");

        //            var option = "<option value='0' >SELECCIONE...</option>"
        //            select.append(option);
        //        }
        //    });
        //}

    }

    function valoresquerystring()
    {
        //obtengo el querystring        
        var querystring = location.search;
        //le quito la parte que no me interesa
        var querystring = querystring.replace("?esvistaparcial=false&","");

        //separo los valores
        var arreglorstring = querystring.split("&");
        if (arreglorstring.length > 0)
        {
            //sucursal
            idsegmanorg = arreglorstring[0].replace("id=", "");

            if (arreglorstring.length > 1) {
                //perito
                idperito = arreglorstring[1].replace("id2=", "");//el id del perito se sel asigna dentro del metodo de llenarcomboperito

                if (arreglorstring.length > 2)
                {
                    //idintermediacion
                    idintermediacion = arreglorstring[2].replace("id3=", "");
                    $('#idintermediacion').val(idintermediacion);
                }
            }
        }
        
        $('#selectSuc').val(idsegmanorg);                
        if (idsegmanorg > 0) {
            //vmagendaperitajeagregar1.ObtenerDatosPendiente(idsegmanorg, idintermediacion);
            llenarcomboperitos(true);
        }        
    }

    function llenarcombosucursal() {
        postajaxjsonbasico("/comun/ObtenerComboOrganizacion/", {}, function (lista_vi_segmanorg) {
            for (var i = 0; i < lista_vi_segmanorg.length; i++) {
                var combosucursal = document.getElementById("selectSuc");
                var newOption = document.createElement("option");
                newOption.value = lista_vi_segmanorg[i].idsegmanorg;
                newOption.text = lista_vi_segmanorg[i].xnombrecomercial;
                combosucursal.add(newOption, combosucursal.options[null]);
            }
            //obtengo el querystring
            valoresquerystring();
        });
    }
    /*FIN CODIGO DEL FULLCALENDAR*/
</script>

<body>

    <div class="clear-both">
        
        <div class="legenda">
            <div class="form-mini">
                <div class=" campo color blue"></div>
                <div class="legendatext">D&iacute;as sin peritajes planificados</div>
            </div>
            <div class="form-mini content-select">
                <div class="right ">
                    <b style="font-size: 16px;">Sucursal:</b> &nbsp;&nbsp;
                    <select id="selectSuc"></select>

                    <b style="font-size: 16px;">Peritos:</b> &nbsp;&nbsp;
                    <select id="selectPer"></select>
                    <input type="hidden" id="idintermediacion" name="idintermediacion" value="si">
                </div>
            </div>
        </div>

   </div>

        <div id="calendar"></div>
</body>
  @*INICIO ESTILO CALENDARIO *@
<style type="text/css">
        body {
            margin-top: 40px;
            font-size: 14px;
            font-family: "Lucida Grande",Helvetica,Arial,Verdana,sans-serif;
        }

        #calendar {
            width: 900px;
            margin: 0 auto;
        }
        div table tr td{
        padding: 3px;
        }
    </style>
    @* FIN ESTILO CALENDARIO *@
<script>

    $('#selectSuc').change(function () { 
        
        if($('#selectSuc').val() > 0)
        {
            llenarcomboperitos(true);
        } else {
            $('#selectPer').val(0)
            llenarcomboperitos(false);
            $('#calendar').fullCalendar('removeEvents');
            $('#calendar').fullCalendar('refetchEvents');
        }

        
    });


    $('#selectPer').change(function () {
        $('#calendar').fullCalendar('removeEvents');
        $('#calendar').fullCalendar('refetchEvents');
        vmagendaperitajeagregar1.vi_aipinsenc.idsegmanusuperit($('#selectPer').val());
    });




    llenarcomboperitos(false);
</script>