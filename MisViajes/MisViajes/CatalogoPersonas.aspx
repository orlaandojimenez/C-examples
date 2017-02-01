<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="CatalogoPersonas.aspx.cs" Inherits="MisViajes.CatalogoPersonas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <table style="width:100%;">
            <tr>
                <td style="width: 225px">&nbsp;</td>
                <td>
                    <h1>Personas</h1>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td rowspan="2" style="width: 225px">
                    <img alt="" src="images/Personas.jpg" style="width: 391px; height: 233px; margin-top: 0px;" /></td>
                <td rowspan="2">
                    <asp:GridView ID="GridViewPersonas" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="idpersona" DataSourceID="SqlDataSourcePersonas" ForeColor="#333333" GridLines="None" ShowFooter="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="idpersona">
                                <EditItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("idpersona") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("idpersona") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ValidationGroup="INSERT" OnClick="lbInsert_Click" ID="lbInsert" runat="server">Agregar</asp:LinkButton>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Nombre" SortExpression="nombre">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("nombre") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditNombre" runat="server" ErrorMessage="Favor de ingresar el nombre" 
                                        ControlToValidate="TextBox1" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ValidationGroup="INSERT" ID="rfvInsertNombre" runat="server" ErrorMessage="Favor de ingresar el nombre" 
                                        ControlToValidate="TextBoxNombre" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Telefono" SortExpression="telefono">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("telefono") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditTelefono" runat="server" ErrorMessage="Favor de ingresar el telefono" 
                                        ControlToValidate="TextBox2" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("telefono") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxTelefono" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ValidationGroup="INSERT" ID="rfvInsertTelefono" runat="server" ErrorMessage="Favor de ingresar el telefono" 
                                        ControlToValidate="TextBoxTelefono" Text="*" ForeColor="Red">
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
                    <asp:SqlDataSource ID="SqlDataSourcePersonas" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" DeleteCommand="DELETE FROM [personas] WHERE [idpersona] = @idpersona" InsertCommand="INSERT INTO [personas] ([nombre], [telefono]) VALUES (@nombre, @telefono)" SelectCommand="SELECT * FROM [personas]" UpdateCommand="UPDATE [personas] SET [nombre] = @nombre, [telefono] = @telefono WHERE [idpersona] = @idpersona">
                        <DeleteParameters>
                            <asp:Parameter Name="idpersona" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="nombre" Type="String" />
                            <asp:Parameter Name="telefono" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="nombre" Type="String" />
                            <asp:Parameter Name="telefono" Type="String" />
                            <asp:Parameter Name="idpersona" Type="Int32" />
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
