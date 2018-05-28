﻿var habana = ["Arroyo Naranjo", "Boyeros", "Marianao"];
var cienfuegos = ["Cienfuegos", "Cruces", "Palmira"];
var santiago = ["Santiago de Cuba", "Guama", "Palma Soriano"];

$("#Provincia").change(function () {
    
    if ($(this).val() == "La Habana") {
        $("#Municipio").html("");
        for ( i= 0; i < 3; i++)
        {
            
            $("#Municipio").append('<option selected value="' + habana[i] + '">' + habana[i] + '</option>');
        }
    }
    else
        if ($(this).val() == "Pinar del Río")
        {
        }
        else
            if ($(this).val() == "Mayabeque") {
            }
            else
                if ($(this).val() == "Villa Clara") {
                }
                else
                    if ($(this).val() == "Cienfuegos")
                    {
                        $("#Municipio").html("");
                        for (i = 0; i < 3; i++) {

                            $("#Municipio").append('<option selected value="' + cienfuegos[i] + '">' + cienfuegos[i] + '</option>');
                        }
                    }
                        else
                        if ($(this).val() == "Ciego de Avila") {
                        }
                        else
                            if ($(this).val() == "Camaguey") {
                            }
                            else
                                if ($(this).val() == "Las Tunas") {
                                }
                                else
                                    if ($(this).val() == "Holguín") {
                                    }
                                    else
                                        if ($(this).val() == "Granma") {
                                        }
                                        else
                                            if ($(this).val() == "Santiago de Cuba") {
                                                $("#Municipio").html("");
                                                for (i = 0; i < 3; i++) {

                                                    $("#Municipio").append('<option selected value="' + santiago[i] + '">' + santiago[i] + '</option>');
                                                }
                                            }
                                            else
                                                if ($(this).val() == "Guantánamo") {
                                                }
                                                
                   
});

$("#btnCrear").click(function () {
    var CI = $("#Persona_CI").val();
    var Nombre = $("#Persona_Nombre").val();
    var Sexo = $("#Persona_Sexo").val();
    var Nivel_Escolar = $("#Persona_Nivel_Escolar").val();
    var Fecha_Nacimiento = $("#Persona_Fecha_Nacimiento").val();
    var Telefono = $("#Persona_Telefono").val();
    var Lugar_Nacimiento = $("#Persona_Lugar_Nacimiento").val();
    var Nacionalidad = $("#Persona_Nacionalidad").val();
    var Militancia = $("#Persona_Militancia").val();
    var Direccion = $("#Persona_Direccion").val();
    var Correo = $("#Persona_Correo").val();
    var Categoria_Docente = $("#Persona_Categoria_Docente").val();
    var Categoria_Cientifica = $("#Persona_Categoria_Cientifica").val();
    var Salario = $("#Persona_Salario").val();
    var Raza = $("#Persona_Raza").val();
    var Primer_Apellido = $("#Primer_Apellido").val();
    var Segundo_Apellido = $("#Segundo_Apellido").val();
    var Provincia = $("#Provincia").val();
    var Municipio = $("#Municipio").val();
    var FIC = $("#Fecha_Inicio_Contrato").val();
    var FFC = $("#Fecha_Fin_Contrato").val();
    var NC = $("#Numero_Contrato").val();
    var Annos_Experiencia = $("#Experiencia").val();
    var Especialidad = $("#Especialidad").val();
    var profesor = {
        CI: CI, Nombre: Nombre, Sexo: Sexo,
        Nivel_Escolar: Nivel_Escolar, Fecha_Nacimiento: Fecha_Nacimiento, Telefono: Telefono,
        Lugar_Nacimiento: Lugar_Nacimiento, Nacionalidad: Nacionalidad, Militancia: Militancia,
        Direccion: Direccion, Correo: Correo, Categoria_Docente: Categoria_Docente,
        Categoria_Cientifica: Categoria_Cientifica, Salario: Salario, Raza: Raza,
        Primer_Apellido: Primer_Apellido, Segundo_Apellido: Segundo_Apellido,
        Provincia: Provincia, Municipio: Municipio, Fecha_Inicio_Contrato: FIC, Fecha_Fin_Contrato: FFC, Numero_Contrato: NC,
        Annos_Experiencia: Annos_Experiencia, Especialidad: Especialidad
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Profesor/Adicionar",
            data: JSON.stringify(profesor),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Profesor/Index";
                }
            },
            failure: function (msg) {
                console.log(msg.description);
            },
            error: function (xhr, err) {
                console.log("ESTADO---->>>  " + xhr.status + "\n" + "xhr.responseText---->>>  " + xhr.responseText, "\n" + "ERR---->>>  " + err);
            },
            complete: function (xhr, com) {

            }
        });

    }

    catch (ex) {
        console.log(ex.message);
    }
});

$("#btnEditar").click(function () {
    var CI = $("#Persona_CI").val();
    var Nombre = $("#Persona_Nombre").val();
    var Sexo = $("#Persona_Sexo").val();
    var Nivel_Escolar = $("#Persona_Nivel_Escolar").val();
    var Fecha_Nacimiento = $("#Persona_Fecha_Nacimiento").val();
    var Telefono = $("#Persona_Telefono").val();
    var Lugar_Nacimiento = $("#Persona_Lugar_Nacimiento").val();
    var Nacionalidad = $("#Persona_Nacionalidad").val();
    var Militancia = $("#Persona_Militancia").val();
    var Direccion = $("#Persona_Direccion").val();
    var Correo = $("#Persona_Correo").val();
    var Categoria_Docente = $("#Persona_Categoria_Docente").val();
    var Categoria_Cientifica = $("#Persona_Categoria_Cientifica").val();
    var Salario = $("#Persona_Salario").val();
    var Raza = $("#Persona_Raza").val();
    var Primer_Apellido = $("#Primer_Apellido").val();
    var Segundo_Apellido = $("#Segundo_Apellido").val();
    var Provincia = $("#Provincia").val();
    var Municipio = $("#Municipio").val();
    var FIC = $("#Fecha_Inicio_Contrato").val();
    var FFC = $("#Fecha_Fin_Contrato").val();
    var NC = $("#Numero_Contrato").val();
    var Annos_Experiencia = $("#Experiencia").val();
    var Especialidad = $("#Especialidad").val();
    var profesor = {
        CI: CI, Nombre: Nombre, Sexo: Sexo,
        Nivel_Escolar: Nivel_Escolar, Fecha_Nacimiento: Fecha_Nacimiento, Telefono: Telefono,
        Lugar_Nacimiento: Lugar_Nacimiento, Nacionalidad: Nacionalidad, Militancia: Militancia,
        Direccion: Direccion, Correo: Correo, Categoria_Docente: Categoria_Docente,
        Categoria_Cientifica: Categoria_Cientifica, Salario: Salario, Raza: Raza,
        Primer_Apellido: Primer_Apellido, Segundo_Apellido: Segundo_Apellido,
        Provincia: Provincia, Municipio: Municipio, Fecha_Inicio_Contrato: FIC, Fecha_Fin_Contrato: FFC, Numero_Contrato: NC,
        Annos_Experiencia: Annos_Experiencia, Especialidad: Especialidad
    };



    try {

        jQuery.ajax({
            type: "POST",
            url: "/Profesor/Modificar",
            data: JSON.stringify(profesor),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Profesor/Index";
                }
            },
            failure: function (msg) {
                console.log(msg.description);
            },
            error: function (xhr, err) {
                console.log("ESTADO---->>>  " + xhr.status + "\n" + "xhr.responseText---->>>  " + xhr.responseText, "\n" + "ERR---->>>  " + err);
            },
            complete: function (xhr, com) {

            }
        });

    }

    catch (ex) {
        console.log(ex.message);
    }
});

$("#btnEliminar").click(function () {
    var CI = $("#Persona_CI").val();
    var trabajador = {
        CI: CI
    };
    try {

        jQuery.ajax({
            type: "POST",
            url: "/Profesor/Eliminar",
            data: JSON.stringify(trabajador),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Profesor/Index";
                }
            },
            failure: function (msg) {
                console.log(msg.description);
            },
            error: function (xhr, err) {
                console.log("ESTADO---->>>  " + xhr.status + "\n" + "xhr.responseText---->>>  " + xhr.responseText, "\n" + "ERR---->>>  " + err);
            },
            complete: function (xhr, com) {

            }
        });

    }

    catch (ex) {
        console.log(ex.message);
    }
});

$(document).ready(function () {
    Visualizar();
    Actualizar_Fecha();
});

function Actualizar_Fecha() {
    try {
        $.datepicker.regional['es'] = {
            //closeText: 'Cerrar',
            prevText: '< Ant',
            nextText: 'Sig >',
            //currentText: 'Hoy',
            monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
            monthNamesShort: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
            dayNames: ['Domingo', 'Lunes', 'Martes', 'Miércoles', 'Jueves', 'Viernes', 'Sábado'],
            //  dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mié', 'Juv', 'Vie', 'Sáb'],
            dayNamesMin: ['Do', 'Lu', 'Ma', 'Mi', 'Ju', 'Vi', 'Sá'],
            // weekHeader: 'Sm',
            dateFormat: 'dd/mm/yy',
            firstDay: 1,
            minDate:'01/01/1940',
            changeMonth: true,
            changeYear: true,
            yearRange: "1930:2050"
            //  isRTL: false,
            // showMonthAfterYear: false,
            //yearSuffix: ''
        };
        $.datepicker.setDefaults($.datepicker.regional['es']);

        //Máscara
        $("#Persona_Fecha_Nacimiento").mask("99/99/9999", { placeholder: "dd/mm/yyyy" });

        $("#Persona_Fecha_Nacimiento").datepicker().datepicker("setDate", new Date());
        $("#Fecha_Inicio_Contrato").mask("99/99/9999", { placeholder: "dd/mm/yyyy" });

        $("#Fecha_Inicio_Contrato").datepicker().datepicker("setDate", new Date());

        $("#Fecha_Fin_Contrato").mask("99/99/9999", { placeholder: "dd/mm/yyyy" });

        $("#Fecha_Fin_Contrato").datepicker().datepicker("setDate", new Date());
    }
    catch (ex) {
        console.log(ex.toString);
    }
}

function Visualizar(/*pObjet*/) {
    try {
        //var _dataSet = new Array();
        //var aux = JSON.parse(JSON.stringify(pObjet));
        //if (pObjet != '') {
        //    $.each(aux, function (idx, obj) {

        //        Aprobar = "<i class= 'fa fa-square-o sel iconh' > </i>";

        //        //_dataSet[idx] = [Aprobar, obj.ACTCOD, obj.ACTDPT, obj.ACTOB1, obj.ACTMAR, obj.ACTMOD, obj.ACTSER, obj.ACTREF, obj.ACTAMT, obj.ACTSEC, obj.ACTCTR, obj.ACTACC];
        //    });
        //}


        $("#Profesores").dataTable({
            //"data": _dataSet,
            //"bProcessing": true,
            //"sScrollY": 250,
            "sScrollX": true,
            //"bInfo": true,
            //"sInfoEmpty": false,
            //"bFilter": false,
            //"bSort": null,
            //"bAutoCss": true,
            //"bCollapse": true,
            //"bInfinite": true,
            //"bDestroy": true,
            //"bAutoWidth": false,
            //"pagingType": "simple",
            "language": {
                "url": "dataTables.german.lang",
                "decimal": ".",
                "thousands": ","
            },
            "oLanguage": {

                "sProcessing": "Procesando...",
                "sLengthMenu": "Mostrar _MENU_ registros",
                "sZeroRecords": "No se encontraron resultados",
                "sEmptyTable": "Ningún dato disponible en esta tabla",
                "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
                "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
                "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
                "sInfoPostFix": "",
                "sSearch": "Buscar:",
                "sUrl": "",
                "sInfoThousands": ",",
                "sLoadingRecords": "Cargando...",
                "oPaginate": {
                    "sFirst": "Primero",
                    "sLast": "Último",
                    "sNext": "Siguiente >>",
                    "sPrevious": "<< Anterior"
                }
            },
            "oSearch": {
                "sSearch": "",
                "bRegex": false,
                "bSmart": true
            }
        });

    }
    catch (ex) {
        console.log(ex.message);
    }

}

$(".fa-close").click(function () {
    var CI = $(this).attr("data-ci");

    var trabajador = {
        ID: CI
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Profesor/Eliminar",
            data: JSON.stringify(trabajador),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Profesor/Index";
                }
            },
            failure: function (msg) {
                console.log(msg.description);
            },
            error: function (xhr, err) {
                console.log("ESTADO---->>>  " + xhr.status + "\n" + "xhr.responseText---->>>  " + xhr.responseText, "\n" + "ERR---->>>  " + err);
            },
            complete: function (xhr, com) {

            }
        });

    }

    catch (ex) {
        console.log(ex.message);
    }
});