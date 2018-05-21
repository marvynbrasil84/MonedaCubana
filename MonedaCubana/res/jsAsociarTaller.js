$(document).ready(function () {



    Visualizar();
    Inicializar_Eventos();

});

function Visualizar(/*pObjet*/) {
    try {
        tableProyectosXPlanGeneral = $("#taller").DataTable({
            "ajax": {
                "url": g_helpers.domain + "/Planeacion/SeguimientoActividad/ListaProyectosXPlanGeneral",
                "type": "POST",
                "datatype": "json",
                "data": function () {
                    var _parametros = {};
                    _parametros["PPGUNI"] = $("#filtro_plan_general").val();

                    var pSolicitud = {
                        _genObject: "",
                        _dictParms: _parametros
                    }
                    return pSolicitud;
                }
            },
            "oLanguage": {
                "sProcessing": "Procesando...",
                "sLengthMenu": "Mostrar _MENU_ registros",
                "sZeroRecords": "No se encontraron resultados",
                "sEmptyTable": "Ningún dato disponible en esta tabla",
                "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
                "sInfoEmpty": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ ",
                "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
                "sInfoPostFix": "",
                "sSearch": "Buscar:",
                "sUrl": "",
                "sInfoThousands": ",",
                "sLoadingRecords": "Cargando...",
                "oPaginate": {
                    "sFirst": "Primero",
                    "sLast": "Último",
                    "sNext": "Siguiente",
                    "sPrevious": "Anterior"
                }
            },
            "columns": [


                { "data": "PROCOD" },
                { "data": "PRONOM" },
                { "data": "PROFIN" },
                { "data": "PROFIN" },
                { "data": "PORCENTAJE" },
                {
                    "data": "PROUNI", "render": function (data) {
                        return "<i class='fa fa-list-alt actividades-proyecto'   data-toggle='modal' data-target='#ModalActiviadesXProyecto'></i>"
                    },
                    "orderable": false,
                    "sClass": "td-center",
                    "width": "30px"
                }
            ],

        });


      

    }
    catch (ex) {
        console.log(ex.message);
    }

}