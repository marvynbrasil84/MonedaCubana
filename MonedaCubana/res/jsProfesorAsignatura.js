$(document).ready(function () {
    Visualizar();
    
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


        $("#profesorasignatura").dataTable({
            //"data": _dataSet,
            //"bProcessing": true,
            //"sScrollY": 250,
            //"sScrollX": true,
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