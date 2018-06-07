var ci_profesor;
$(document).ready(function () {
    Visualizar();
});

function Visualizar() {
    try {
        


        $("#profesorasignatura").dataTable({
            
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



$(".asociar").click(function () {
    ci_profesor = $(this).attr("data-tipo");

    var asignatura = $(this).attr("data-tipo");
    var datos = {
        CI: ci_profesor,
       
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/AlumnoTaller/TalleresporAlumno",
            data: JSON.stringify(datos),
            contentType: "application/json; charset=utf-8",
            //dataType: "json",
            cache: false,
            beforeSend: function (xhr) {
                $("#divProcesando").show();

            },
            success: function (dato) {
                //todo:
                //Visualizar1();
                $("#contentModalTipoArchivo").html(dato);
            },
            failure: function (msg) {
                console.log(msg.description);
            },
            error: function (xhr, err) {
                console.log("ESTADO---->>>  " + xhr.status + "\n" + "xhr.responseText---->>>  " + xhr.responseText, "\n" + "ERR---->>>  " + err);
            },
            complete: function (xhr, com) {
                $("#divProcesando").hide();
            }
        });

    }

    catch (ex) {
        console.log(ex.message);
    }
   
});

//$("btnAsignar").click(function () {


//});


