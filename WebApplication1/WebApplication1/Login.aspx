<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Login.css" rel="stylesheet" />
</head>
<body>
    <%--<form id="form1" runat="server">
    <div>
       User: <br />
       Pass: <br />
        <asp:Button ID="Button_Login" runat="server" Text="Login" OnClick="Button_Login_Click"/><br />
        <asp:Label ID="Label_Result" runat="server"></asp:Label>

        </div>
    </form>--%>

    <div class="container">
        <div class="card card-container">
            <!-- <img class="profile-img-card" src="//lh3.googleusercontent.com/-6V8xOA6M7BA/AAAAAAAAAAI/AAAAAAAAAAA/rzlHcD0KYwo/photo.jpg?sz=120" alt="" /> -->
            <img id="profile-img" class="profile-img-card" src="//ssl.gstatic.com/accounts/ui/avatar_2x.png" />
            <p id="profile-name" class="profile-name-card"></p>
            <form runat="server" class="form-signin">
                <span id="reauth-email" class="reauth-email"></span>
                <asp:TextBox ID="TextBox_User"  runat="server" CssClass="form-control" placeholder="User"  ></asp:TextBox>
                <asp:TextBox ID="TextBox_pass"  runat="server" CssClass="form-control" placeholder="Password" ></asp:TextBox>
                <asp:Label ID="Label_Result" runat="server" Text="..."></asp:Label><br />
                <asp:Button ID="Button_Login" runat="server" CssClass="btn btn-lg btn-primary btn-block btn-signin" Text="Sign In" OnClick="Button_Login_Click1"/>
            </form><!-- /form -->
            <a href="#" class="forgot-password">
                Forgot the password?
            </a>
        </div><!-- /card-container -->
    </div><!-- /container -->

    <script src="Scripts/jquery-1.10.2.js"> </script> 
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Login.js"></script>
   
</body>
</html>
