function tellMyName()
{
    var text = "Hola ";
    var name = document.getElementById("text_Name").value;
    text += name;
    alert(text);
    document.getElementById("h1_name").innerHTML = text;
}