<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="LigaFutbol.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Liga de Futbol</title>
     <link href="Content\bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <link href="Home.css" rel="stylesheet" />
</head>
<body>

    <!-- Navbar Login-->
     <nav class="navbar navbar-default">
  <div class="container">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span> 
      </button>
      <a class="navbar-brand" href="Home.aspx">Inicio</a>
    </div>
    <div class="collapse navbar-collapse" id="myNavbar">
      <ul class="nav navbar-nav navbar-right">
        <li><a href="#">Capitanes</a></li>
        <li><a href="#">Adm. Liga</a></li>
      </ul>
    </div>
  </div>
</nav>
    

    <!--Navbar Opicones-->
    <div class="container">
        <div class="row">
            <div class="col-sm-1">

            </div>
            <div class="col-sm-10" id="cont_logo">
                  <nav class="navbar navbar-inverse">
                  <div class="container">
                    <div class="navbar-header">
                      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar2">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span> 
                      </button>
                    </div>
                    <div class="collapse navbar-collapse">
                      <ul class="nav navbar-nav">
                        <li><a href="#">Equipos</a></li>
                        <li><a href="#">Roles y Estadísticas</a></li>
                        <li><a href="#">Información</a></li>
                        <li><a href="#">Más</a></li>
                      </ul>
                    </div>
                  </div>
                </nav>
            </div>
            <div class="col-sm-1">
         </div>
      </div>


        
        <div class="row">
            <div class="col-sm-1"></div>
            <div class="col-sm-7" id="cont_carousel">
                <div class="jumbotron text-center">
                    <img src="http://www.micampeonato.com/images/campeonatos/307785259061_1405_mundo_n1_twit.jpg" id="img_logo" />
                    <!--Carousel-->
                    <div id="myCarousel" class="carousel slide" data-ride="carousel">
          <!-- Indicators -->
          <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>
          </ol>

          <!-- Wrapper for slides -->
          <div class="carousel-inner" role="listbox">
            <div class="item active">
              <img src="https://i.ytimg.com/vi/NckD8nDG4o0/maxresdefault.jpg" />
            </div>

            <div class="item">
              <img src="http://holatelcel.com/wp-content/uploads/2016/06/cancha-de-futbol.jpg" />
            </div>

            <div class="item">
              <img src="http://www.fondoswiki.com/Uploads/fondoswiki.com/Resoluciones/3868-1920x1080.jpg" />
            </div>
          </div>

          <!-- Left and right controls -->
          <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
          </a>
          <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
          </a>
        </div>
                    </div>
            </div>

            <!--Redes sociales-->
            <div class="col-sm-3" id="cont_redessociales">
                <div class="jumbotron">
                    <p id="p_redessociales">Interactúa en redes sociales</p>
                    <hr />
                    <a href="https://www.facebook.com/"><img src="http://corourbano.com/wp-content/uploads/2013/11/me-gusta-.jpg"  id="megusta"/></a>
                </div>
            </div>
            <div class="col-sm-1"></div>
        </div>
   </div>
    
        


    <script src="Scripts/jquery-1.10.2.js"> </script> 
    <script src="Scripts/bootstrap.min.js"></script>

</body>
</html>

