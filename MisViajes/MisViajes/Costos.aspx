<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Costos.aspx.cs" Inherits="MisViajes.Costos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <table style="width:100%;">
            <tr>
                <td style="width: 48px">&nbsp;</td>
                <td><h1>Costos</h1></td>
                <td>
                    Buscar por:<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="destino" DataValueField="idviaje" AutoPostBack="True"></asp:DropDownList>
                    <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td rowspan="2" style="width: 48px">
                    <img alt="" src="images/costo.png" style="width: 298px; height: 227px" /></td>
                <td rowspan="2">
                    <asp:GridView ID="GridViewCostos" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="idcosto" DataSourceID="SqlDataSourceCostos" ForeColor="#333333" GridLines="None" ShowFooter="True" AllowSorting="True">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="idcosto">
                                <EditItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("idcosto") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("idcosto") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ValidationGroup="INSERT" ID="lbInsert" OnClick="lbInsert_Click" runat="server">Agregar</asp:LinkButton>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Viaje" SortExpression="idviaje">
                                <EditItemTemplate>
                                    <asp:DropDownList ID="DplViaje" runat="server" DataSourceID="SqlDataSourceViaje" DataTextField="destino" DataValueField="idviaje" SelectedValue ='<%# Bind("idviaje") %>'></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourceViaje" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("idviaje") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:DropDownList ID="DplViaje" runat="server" DataSourceID="SqlDataSourceViaje" DataTextField="destino" DataValueField="idviaje" SelectedValue ='<%# Bind("idviaje") %>'></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourceViaje" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre" SortExpression="nombre">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("nombre") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditNombre" runat="server" ErrorMessage="Favor de ingresar el nombre" 
                                        ControlToValidate="TextBox2" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ValidationGroup="INSERT" ID="rfvInsertNombre" runat="server" ErrorMessage="Favor de ingresar el nombre" 
                                        ControlToValidate="TextBoxNombre" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Precio" SortExpression="precio">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("precio") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditPrecio" runat="server" ErrorMessage="Favor de ingresar el precio" 
                                        ControlToValidate="TextBox3" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("precio") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxPrecio" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ValidationGroup="INSERT" ID="rfvInsertPrecio" runat="server" ErrorMessage="Favor de ingresar el precio" 
                                        ControlToValidate="TextBoxPrecio" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="White" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                    <asp:ValidationSummary ValidationGroup="INSERT" ID="ValidationSummary1" ForeColor="Red" runat="server" />
                    <asp:ValidationSummary  ID="ValidationSummary2" ForeColor="Red" runat="server" />
                    <asp:SqlDataSource ID="SqlDataSourceCostos" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" DeleteCommand="DELETE FROM [costo] WHERE [idcosto] = @idcosto" InsertCommand="INSERT INTO [costo] ([idviaje], [nombre], [precio]) VALUES (@idviaje, @nombre, @precio)" SelectCommand="SELECT idcosto, idviaje, nombre, precio FROM costo WHERE (idviaje = @idviaje)" UpdateCommand="UPDATE [costo] SET [idviaje] = @idviaje, [nombre] = @nombre, [precio] = @precio WHERE [idcosto] = @idcosto">
                        <DeleteParameters>
                            <asp:Parameter Name="idcosto" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="idviaje" Type="Int32" />
                            <asp:Parameter Name="nombre" Type="String" />
                            <asp:Parameter Name="precio" Type="Decimal" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="idviaje" PropertyName="SelectedValue" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="idviaje" Type="Int32" />
                            <asp:Parameter Name="nombre" Type="String" />
                            <asp:Parameter Name="precio" Type="Decimal" />
                            <asp:Parameter Name="idcosto" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>
