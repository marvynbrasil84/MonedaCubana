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