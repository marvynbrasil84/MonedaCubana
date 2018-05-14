$(document).ready(function () {

    LLenarComboboxPeriodo();
    
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

