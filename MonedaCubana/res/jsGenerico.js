///Valida si un objeto TextBox esta lleno
///pObjeto:String con el nombre del objeto
///pNombreCampo:Nombre del campo que se valida
function ValidarCampoTextoRequerido(pObjeto, pNombreCampo, pNombreValidador) {

    pObjeto = document.getElementById(pObjeto);
    if (pObjeto != null) {
        if (pObjeto.value == "") {
            switch (Rutina_NombreExplorador()) {
                case "Mozilla":
                case "Opera":
                    pObjeto.className = "ErrorValidadorTexto";
                    Rutina_MuestraMensaje("Debe especificar " + pNombreCampo + "!!!");
                    break;
                case "Explorer":
                    ValidatorEnable(document.getElementById(pNombreValidador), true);
                    break;
            }
            return false;
        }
        else
            if (Rutina_NombreExplorador() == "Mozilla")
                pObjeto.className = "GeneralItems";
        return true;
    }
    return false;

}



function ValidarCampoTextoFormatoCorreo(pObjeto, pNombreCampo) {
    pObjeto = document.getElementById(pObjeto);
    //  _ExpresionRegular = new RegExp("[0-9a-zA-Z]@[0-9a-zA-Z]{2,}'.'[0-9a-zA-Z]{2,}");
    //"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
    if (pObjeto != null) {
        _ExpresionRegular = new RegExp("^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$");
        if (_ExpresionRegular.exec(pObjeto.value)) {

            pObjeto.className = "GeneralItems";
            return true;
        }
        else {
            pObjeto.className = "ErrorValidadorTexto";
            Rutina_MuestraMensaje("El formato del " + pNombreCampo + " es incorrecto!!!");
            return false;
        }
    }
    return false;
}


//Función para validar el tamaño máximo del Texto
function Rutina_ValidaTamanoTexto(text, long) {
    var maxlength = new Number(long); // Convierte a número la cantidad máxima de caracteres asignada.

    if (text.value.length > maxlength) {
        text.value = text.value.substring(0, maxlength);
        Rutina_MuestraMensaje(" No puede digitar más de " + long + " caracteres!!!");
    }
}



//función para validar si el valor de un campo es Númerico
function Rutina_ValidaNumero(pObjeto) {

    //intento convertir a entero.
    //si era un entero no le afecta, si no lo era lo intenta convertir
    var valor = pObjeto.value;
    pObjeto.className = "GeneralItems";

    if (valor != "") {

        ///--> Elias: lo quite porque la funcion paseInt, cuando se encuentra la cadena "0.00ddf"
        ///-->  convierte todo a 0, por tanto siempre piensa que es un numero anque tenga letras
        //        valor = parseInt(valor.replace(',', ''));

        valor = valor.replace(/,/g, '');

        //Compruebo si es un valor numérico 
        if (isNaN(valor)) {
            //entonces (no es numero) devuelvo el valor cadena vacia
            Rutina_MuestraMensaje('Este campo solo acepta valores Númericos!!!');
            pObjeto.value = "0";
            pObjeto.focus();
            pObjeto.className = "ErrorValidadorTexto";
            return false;
        }

        if (Number(pObjeto.value) < 0) {
            pObjeto.value = '0';
            Rutina_MuestraMensaje('No se puede ingresar valores negativos.');
            pObjeto.className = "ErrorValidadorTexto";
            return false;


        }


    }
    return true;
}


function Rutina_ValidaNumero_Entero(pObjet) {
    //valida si es numerico el valor
    if (Rutina_ValidaNumero(pObjet)) {
        //si es valor numerico que no sea negativo
        if (Number(pObjet.value) < 0) {
            pObjet.value = '0';
            Rutina_MuestraMensaje('No se puede ingresar valores negativos.');
            //_dialog.dialog("open");
            //se muestra el mensaje
            pObjet.className = "ErrorValidadorTexto";
            return;


        } else {

            //si es valor numerico que solo sean valores enteros
            if (pObjet.value.indexOf('.') >= 0 || pObjet.value.indexOf(',') >= 0) {
                pObjet.value = '0';
                Rutina_MuestraMensaje('Solo se permiten valores enteros.');
                //_dialog.dialog("open");
                //se muestra el mensaje
                pObjet.className = "ErrorValidadorTexto";
                return false;
            }

            pObjet.className = "GeneralItems";
        }
    }

    return true;
}


//función para validar si el valor de un campo es Númerico
function Rutina_ValidaNumeroBoolean(pObjeto) {
    //intento convertir a entero.
    //si era un entero no le afecta, si no lo era lo intenta convertir
    var valor = pObjeto.value.replace(/,/g, '');

    if (valor != "") {
        valor = parseInt(valor)

        //Compruebo si es un valor numérico
        if (isNaN(valor)) {
            //si el valor no es númerico retorna false
            return false;
        }
    }

    return true;
}


/*
Función para validar que se ingresen solo letras en un textBox
*/
function Rutina_ValidarTexto(pObjeto) {
    _ExpresionRegular = new RegExp("[a-zA-Z]");
    pObjeto.className = "GeneralItems";

    if (pObjeto.value != "") {
        if (_ExpresionRegular.exec(pObjeto.value)) {
            return true;
        } else {
            Rutina_MuestraMensaje("El texto introducido es incorrecto.");
            pObjeto.value = "";
            pObjeto.focus();
            pObjeto.className = "ErrorValidadorTexto";
            return false;
        }
    }
}

//rRutina_mensaje Alerta
function Rutina_MuestraMensaje(pMensaje) {

    try {
        swal(pMensaje);
    }
    catch (err) {
        alert(pMensaje);
    }

}