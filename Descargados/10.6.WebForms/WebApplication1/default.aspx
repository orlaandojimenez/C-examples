<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <nav class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">Bootstrap theme</a>
                </div>
                <div id="navbar" class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="#">Home</a></li>
                        <li><a href="#about">About</a></li>
                        <li><a href="#contact">Contact</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Dropdown <span class="caret"></span></a>
                            <ul class="dropdown-menu">
                                <li><a href="#">Action</a></li>
                                <li><a href="#">Another action</a></li>
                                <li><a href="#">Something else here</a></li>
                                <li role="separator" class="divider"></li>
                                <li class="dropdown-header">Nav header</li>
                                <li><a href="#">Separated link</a></li>
                                <li><a href="#">One more separated link</a></li>
                            </ul>
                        </li>
                    </ul>
                </div><!--/.nav-collapse -->
            </div>
        </nav>

    <br /><br /><br /><br />

    <div class="bs-docs-section">
        <div class="container">
            <div class="row">
                <div class="col-lg-12">
                    <div class="well bs-component">
                        <div class="form-horizontal">
                            <fieldset>
                                <legend>Datos de Usuario</legend>
                                <asp:ScriptManager ID="ScriptManager1" runat="server" />
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <div class="form-group">
                                            <label for="inputEmail" class="col-lg-2 control-label">ID del Customer</label>
                                            <div class="col-lg-10">
                                                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                        <br /><br />
                                        <div class="form-group">
                                            <div class="col-lg-10 col-lg-offset-2">
                                                <asp:Button ID="button_Hello" runat="server" OnClick="button_Hello_Click" CssClass="btn btn-lg btn-primary" Text="Execute Query" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <div class="col-lg-10 col-lg-offset-2">
                                                <asp:GridView ID="GridView_Hello" CssClass="table" runat="server"></asp:GridView>
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </fieldset>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>    

    </form>


    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
