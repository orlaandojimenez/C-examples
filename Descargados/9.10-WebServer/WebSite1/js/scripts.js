function obtieneArchivoPorAJAX()
{//Usando la librería de AJAX de jquerys
    $.ajax({
        type: "GET",
        url: "test.txt",
        dataType: "html",
        data:
        {
        },
        success:
            function (data)
            {
                $("#genericContanier").html(data);
            },
        error:
            function ()
            {
                alert("ERROR");
            }
    });
}