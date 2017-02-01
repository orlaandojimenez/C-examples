var tableObject = "";
var items = [];

//Esta funcion agrega un elemento al array
//y llama a la funcion displayTable()
function addItem()
{
    var item = $("#text_Item").val();
    if (item != "")
    {//Añadimos el elemento al array y desplegamos la tabla
        items.push(item);
        displayTable();
        $("#text_Item").val("");
    }
}

//Esta funcion convierte el arreglo items
//en una tabla HTML y la coloca en el div
//con id "tableContainer"
function displayTable()
{
    var textTable = "<table class=\"table\"><caption>Items</caption>";
    textTable += "<thead><tr><th>#</th><th>Item</th>";
    textTable += "</tr></thead><tbody>";
    for(var i = 0; i < items.length; i++)
    {
        textTable += "<tr><td>" + i + "</td>";
        textTable += "<td>" + items[i] + "</td>";
        textTable += "</tr>";
    }
    textTable += "</tbody></table>"
    $("#tableContainer").html(textTable);
}