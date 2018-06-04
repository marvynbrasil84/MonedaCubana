$("#btnCrear").click(function () {
    var Periodo = $("#Periodo").val();
    var Curricular = $("#Curricular").val();
    
    var PlanE = {
        Periodo: Periodo, Plan_Curricular: Curricular
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Programa_Entrenamiento/Adicionar",
            data: JSON.stringify(PlanE),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Programa_Entrenamiento/Index";
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
    var Periodo = $("#Periodo").val();
    var Curricular = $("#Curricular").val();

    var PlanE = {
        Periodo: Periodo, Plan_Curricular: Curricular
    };


    try {

        jQuery.ajax({
            type: "POST",
            url: "/Programa_Entrenamiento/Modificar",
            data: JSON.stringify(PlanE),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Programa_Entrenamiento/Index";
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
    var Periodo = $("#Periodo").val();
    var PlanE = {
        Periodo: Periodo
    };
    try {

        jQuery.ajax({
            type: "POST",
            url: "/Programa_Entrenamiento/Eliminar",
            data: JSON.stringify(PlanE),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            cache: false,
            beforeSend: function (xhr) {

            },
            success: function (dato) {

                if (dato.data) {
                    location.href = "/Programa_Entrenamiento/Index";
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
            minDate: '01/01/1940',
            changeMonth: true,
            changeYear: true,
            yearRange: "1930:2050"
            //  isRTL: false,
            // showMonthAfterYear: false,
            //yearSuffix: ''
        };
        $.datepicker.setDefaults($.datepicker.regional['es']);

        //Cambiar de acuerdo al Plan de Entrenamiento
        $("#Persona_Fecha_Nacimiento").mask("99/99/9999", { placeholder: "dd/mm/yyyy" });
        $("#Persona_Fecha_Nacimiento").datepicker().datepicker("setDate", new Date());
        $("#Fecha_Inicio_Contrato").mask("99/99/9999", { placeholder: "dd/mm/yyyy" });
        $("#Fecha_Inicio_Contrato").datepicker().datepicker("setDate", new Date());

    }
    catch (ex) {
        console.log(ex.toString);
    }
}

function Visualizar(/*pObjet*/) {
    try {
        
        $("#Plan_Entrenamiento").dataTable({
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