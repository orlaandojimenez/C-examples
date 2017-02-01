<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Calculos.aspx.cs" Inherits="MisViajes.Calculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

        <table style="width:100%;">
            <tr>
                <td>
                    <h1>Calculos</h1>
                </td>
                <td>
                    
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceViaje" DataTextField="destino" DataValueField="idviaje">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSourceViaje" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSourceCostos" runat="server"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                
                <td rowspan="2">
                    <h3>Costos</h3>
                <br />
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="idcosto" DataSourceID="SqlDataSourceViewCostos" OnDataBound="GridView1_DataBound" OnRowDataBound="GridView1_RowDataBound">
                        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

                        <Columns>
                            <asp:BoundField DataField="idcosto" HeaderText="ID" ReadOnly="True" SortExpression="idcosto" />
                            <asp:BoundField DataField="destino" HeaderText="Destino" SortExpression="destino" />
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                            <asp:BoundField DataField="precio" HeaderText="Precio" SortExpression="precio" />
                        </Columns>

                        <EditRowStyle BackColor="#2461BF"></EditRowStyle>

                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

                        <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

                        <RowStyle BackColor="#EFF3FB"></RowStyle>

                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                        <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

                        <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

                        <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

                        <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSourceViewCostos" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" SelectCommand="SELECT idcosto, destino, nombre, precio FROM View_Costos WHERE (idviaje = @idviaje)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="idviaje" PropertyName="SelectedValue" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <br />
                    <br />

                    <h3>Personas</h3>
                    <br />
                    <asp:GridView ID="GridViewPersonas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataSourceID="SqlDataSourcePersonas">
                        <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

                        <Columns>
                            <asp:BoundField DataField="idorganiza" HeaderText="ID" SortExpression="idorganiza"></asp:BoundField>
                            <asp:BoundField DataField="destino" HeaderText="Destino" SortExpression="destino"></asp:BoundField>
                            <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre"></asp:BoundField>
                            <asp:BoundField DataField="pagado" HeaderText="Pagado" SortExpression="pagado"></asp:BoundField>
                        </Columns>

                        <EditRowStyle BackColor="#2461BF"></EditRowStyle>

                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></FooterStyle>

                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White"></HeaderStyle>

                        <PagerStyle HorizontalAlign="Center" BackColor="#2461BF" ForeColor="White"></PagerStyle>

                        <RowStyle BackColor="#EFF3FB"></RowStyle>

                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                        <SortedAscendingCellStyle BackColor="#F5F7FB"></SortedAscendingCellStyle>

                        <SortedAscendingHeaderStyle BackColor="#6D95E1"></SortedAscendingHeaderStyle>

                        <SortedDescendingCellStyle BackColor="#E9EBEF"></SortedDescendingCellStyle>

                        <SortedDescendingHeaderStyle BackColor="#4870BE"></SortedDescendingHeaderStyle>
                    </asp:GridView>

                    <asp:SqlDataSource runat="server" ID="SqlDataSourcePersonas" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT idorganiza, destino, nombre, pagado FROM View_Organiza WHERE (idviaje = @idviaje)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="idviaje" PropertyName="SelectedValue" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td>
                    Total de costos: <asp:TextBox ID="txtTotalCostos" runat="server"></asp:TextBox><br />
                    <br />
                    <h2>Costo por persona</h2>
                    <br />
                    Costo de Autobus:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;               <asp:TextBox ID="txtAutobus" runat="server"></asp:TextBox><br />
                    Costo x habitacion (por noche):&nbsp; <asp:TextBox ID="txtHab" runat="server"></asp:TextBox><br />
                    Num. de noches:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNoches" runat="server"></asp:TextBox><br />
                    Costo de comida (por persona): <asp:TextBox ID="txtComida" runat="server"></asp:TextBox><br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Calcular" OnClick="Button1_Click" /> <br />
                    <br />
                    Costo por persona: <asp:TextBox ID="txtPersona" runat="server"></asp:TextBox>
                    <br /> 
                    Cantidad a sumar:&nbsp; <asp:TextBox ID="txtSuma" runat="server"></asp:TextBox> <br /> <br />
                    <asp:Button ID="Button2" runat="server" Text="Calcular" OnClick="Button2_Click" /><br />
                    <br />
                    Cobro por persona: <asp:TextBox ID="txtCobroPersona" runat="server"></asp:TextBox><br />
                    Ganancia Total:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtGanancia" runat="server"></asp:TextBox><br />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="OK" OnClick="Button3_Click" />


                </td>
                <td>
                </td>
                <td>
                    
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
                    
        </table>

    </div>
</asp:Content>
