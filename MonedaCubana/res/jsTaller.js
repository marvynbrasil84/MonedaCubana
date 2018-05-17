$(document).ready(function () {

    LLenarComboboxPeriodo();
    Visualizar();
});

function LLenarComboboxPeriodo()
{
    try {

        jQuery.ajax({
            type: "POST",
            url: "/Taller/Planes_Entrenamiento",
            //data: JSON.stringify(trabajador),
            //contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {
                var pObject = dato.data;
                $.each(pObject, function (idx, obj)
                {
                    $("#cboTaller").append('<option selected value="' + obj + '">' + obj + '</option>');
                });
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
}

$("#btnCrear").click(function () {
    var Nombre = $("#Nombre").val();
    var Periodo = $("#cboTaller").val();
    
    var taller = {
        Nombre: Nombre, Periodo: Periodo
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Taller/Adicionar",
            data: JSON.stringify(taller),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Taller/Index";
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
    var Nombre = $("#Nombre").val();
    

    var taller = {
        Nombre: Nombre
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Taller/Eliminar", 
            data: JSON.stringify(taller),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/taller/Index";
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
    var Nombre = $("#Nombre").val();
    var Periodo = $("#cboTaller").val();

    var taller = {
        Nombre: Nombre, Periodo: Periodo
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Taller/Modificar",
            data: JSON.stringify(taller),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Taller/Index";
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


function Visualizar(/*pObjet*/) {
    try {   

        $("#Taller").dataTable({
            //"data": _dataSet,
            //"bProcessing": true,
            //"sScrollY": 250,
           // "sScrollX": true,
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
    var Nombre = $(this).attr("data-nombre");

    var taller = {
        Nombre: Nombre
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Taller/Eliminar",
            data: JSON.stringify(taller),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/taller/Index";
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

