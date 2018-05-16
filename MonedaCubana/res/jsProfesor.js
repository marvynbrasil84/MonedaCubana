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
    var Raza = "M"
    var profesor = {
        CI: CI, Nombre: Nombre, Sexo: Sexo,
        Nivel_Escolar: Nivel_Escolar, Fecha_Nacimiento: Fecha_Nacimiento, Telefono: Telefono,
        Lugar_Nacimiento: Lugar_Nacimiento, Nacionalidad: Nacionalidad, Militancia: Militancia,
        Direccion: Direccion, Correo: Correo, Categoria_Docente: Categoria_Docente,
        Categoria_Cientifica: Categoria_Cientifica, Salario: Salario, Raza: Raza
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
    var Raza = "M"
    var profesor = {
        CI: CI, Nombre: Nombre, Sexo: Sexo,
        Nivel_Escolar: Nivel_Escolar, Fecha_Nacimiento: Fecha_Nacimiento, Telefono: Telefono,
        Lugar_Nacimiento: Lugar_Nacimiento, Nacionalidad: Nacionalidad, Militancia: Militancia,
        Direccion: Direccion, Correo: Correo, Categoria_Docente: Categoria_Docente,
        Categoria_Cientifica: Categoria_Cientifica, Salario: Salario, Raza: Raza
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