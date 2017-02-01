<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Archivos.aspx.cs" Inherits="MisViajes.Archivos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />

        <table style="width:100%;">
            <tr>
                <td style="width: 186px">&nbsp;</td>
                <td>
                    <h1>Abrir Archivo</h1>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td rowspan="2" style="width: 186px">
                    <img alt="" src="images/archivo.jpg" style="width: 300px; height: 248px" /></td>
                <td style="height: 27px">
                    <br />
                    <asp:Button ID="btnHab" runat="server" OnClick="btnExaminar_Click" Text="Llenado de Habitaciones" Width="212px" />
                    <br />
                    <br />
                    <asp:Button ID="btnAutobus" runat="server" Text="Llenado de Autobus" Width="213px" OnClick="btnAutobus_Click" />
                </td>
                <td style="height: 27px">
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>
