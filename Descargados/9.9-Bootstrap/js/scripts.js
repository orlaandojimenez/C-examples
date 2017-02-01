var items = [];

//Esta funcion agrega un elemento al array
//y llama a la funcion displayTable()
function addItem()
{//Obtenemos los valores de todo el formulario
    //Obtenemos la propiedad value del elemento del DOM
    //usando la funcion val() de jquery
    var email   = $("#inputEmail").val();
    var pass = $("#inputPassword").val();
    //Por medio de :checked podemos obtener el atributo
    //correspondiente de elementos de seleccion del DOM
    var newsLetter = $("#inputPassword:checked").length;
    //El TextArea se obtiene tambien con .val()
    var textAreaDesc = $("#textArea").val();
    //Obtenemos cual Radio esta checkeado
    var radiosVal = "";
    if($("#optionsRadios1:checked").length > 0)
    {//Radio 1 fue seleccionado
        radiosVal = $("#optionsRadios1").val();
    }
    else if ($("#optionsRadios2:checked").length > 0)
    {//Radio 2 fue seleccionado
        radiosVal = $("#optionsRadios2").val();
    }
    //Obtenemos el valor seleccionado del Select
    var selectSimple = $("#selectNormal").val();
    var textoSelectSimple = $("#selectNormal option:selected").text();
    //Obtenemos los valores del Select Multiple
    //.val() regresara un array de valores seleccionados
    var selectMultiple = $("#selectMultiple").val();
    var selectMultipleString = "";
    if (selectMultiple != null)
        for(var i = 0; i < selectMultiple.length; i++)
            selectMultipleString += selectMultiple[i] + ", ";
    
    //Construimos un array con los valores y lo guardamos
    var item = [email, pass, newsLetter, textAreaDesc, radiosVal,
        selectSimple, textoSelectSimple, selectMultipleString];
    items.push(item);

    //Se construye y despliega la tabla
    displayTable();
}

//Esta funcion convierte el arreglo items
//en una tabla HTML y la coloca en el div
//con id "tableContainer"
function displayTable()
{
    var textTable = "<table class=\"table\"><caption>Items</caption>";
    textTable += "<thead><tr><th>#</th>";
    textTable += "<th>Email</th>";
    textTable += "<th>Pass</th>";
    textTable += "<th>NewsLetter Check</th>";
    textTable += "<th>TextAreaDesc</th>";
    textTable += "<th>Radios</th>";
    textTable += "<th>Select Simple</th>";
    textTable += "<th>Select Simple Text</th>";
    textTable += "<th>Select Multiple</th>";
    textTable += "</tr></thead><tbody>";
    for(var i = 0; i < items.length; i++)
    {
        textTable += "<tr>";//Inicio de fila
        var item = items[i];
        //Agregamos el # de Fila
        textTable += "<td>" + i + "</td>";
        for (var j = 0; j < item.length; j++)
        {//Recorremos el arreglo de columnas
            textTable += "<td>" + item[j] + "</td>";
        }
        textTable += "</tr>";//Fin de fila
    }
    textTable += "</tbody></table>"
    $("#tableContainer").html(textTable);
}