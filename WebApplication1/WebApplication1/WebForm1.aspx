<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Click Me" OnClick="Button1_Click"/>
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br  />
        <asp:Label ID="label1" runat="server" Text="Here goes some content">
        </asp:Label>
    </div>
    </form>
</body>
</html>
