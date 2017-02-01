<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="CatalogoViajes.aspx.cs" Inherits="MisViajes.CatalogoViajes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />

        <table style="width:100%;">
            <tr>
                <td style="width: 279px">&nbsp;</td>
                <td><h1>Viajes</h1></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td rowspan="2" style="width: 279px">
                    <img alt="" src="images/autobus.jpg" style="width: 370px; height: 216px" /></td>
                <td rowspan="2">
                    <asp:GridView ID="GridViewViajes" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSourceViajes" ForeColor="#333333" GridLines="None" ShowFooter="True" DataKeyNames="idviaje">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="idviaje">
                                <EditItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("idviaje") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("idviaje") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton ValidationGroup="INSERT" OnClick="lbInsert_Click" ID="LbInsert" runat="server">Agregar</asp:LinkButton>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Destino" SortExpression="destino">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("destino") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditDestino" runat="server" ErrorMessage="Favor de ingresar el destino" 
                                        ControlToValidate="TextBox1" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("destino") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxDestino" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvInsertDestino" runat="server" ErrorMessage="Favor de ingresar el destino" 
                                        ControlToValidate="TextBoxDestino" ValidationGroup="INSERT" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Fecha de salida" SortExpression="fecha_salida">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("fecha_salida") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditFS" runat="server" ErrorMessage="Favor de ingresar la fecha de salida" 
                                        ControlToValidate="TextBox2" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("fecha_salida") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxFechaSalida" placeholder="dd/mm/YYYY" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvInsertFS" runat="server" ErrorMessage="Favor de ingresar la fecha de salida" 
                                        ControlToValidate="TextBoxFechaSalida" ValidationGroup="INSERT" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Fecha de regreso" SortExpression="fecha_regreso">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("fecha_regreso") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditFR" runat="server" ErrorMessage="Favor de ingresar la fecha de regreso" 
                                        ControlToValidate="TextBox3" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("fecha_regreso") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxFechaRegreso" placeholder="dd/mm/YYYY" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvInsertFR" runat="server" ErrorMessage="Favor de ingresar la fecha de regreso" 
                                        ControlToValidate="TextBoxFechaRegreso" ValidationGroup="INSERT" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Hotel" SortExpression="hotel">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("hotel") %>'></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEditHotel" runat="server" ErrorMessage="Favor de ingresar el hotel" 
                                        ControlToValidate="TextBox4" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("hotel") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxHotel" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvInsertHotel" runat="server" ErrorMessage="Favor de ingresar el hotel" 
                                        ControlToValidate="TextBoxHotel"  ValidationGroup="INSERT" Text="*" ForeColor="Red">
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
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        

    </div>
    <div>

        <table style="width:100%;">
            <tr>
                <td style="width: 154px">&nbsp;</td>
                <td rowspan="3">
                    <asp:ValidationSummary ValidationGroup="INSERT" ID="ValidationSummary1" ForeColor="Red" runat="server" />
                    <asp:ValidationSummary ID="ValidationSummary2" ForeColor="Red" runat="server" />
                    <asp:SqlDataSource ID="SqlDataSourceViajes" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" SelectCommand="SELECT * FROM [viaje]" DeleteCommand="DELETE FROM [viaje] WHERE [idviaje] = @idviaje" InsertCommand="INSERT INTO [viaje] ([destino], [fecha_salida], [fecha_regreso], [hotel]) VALUES (@destino, @fecha_salida, @fecha_regreso, @hotel)" UpdateCommand="UPDATE [viaje] SET [destino] = @destino, [fecha_salida] = @fecha_salida, [fecha_regreso] = @fecha_regreso, [hotel] = @hotel WHERE [idviaje] = @idviaje">
                        <DeleteParameters>
                            <asp:ControlParameter ControlID="GridViewViajes" Name="idviaje" PropertyName="SelectedValue" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="destino" Type="String" />
                            <asp:Parameter Name="fecha_salida" Type="String" />
                            <asp:Parameter Name="fecha_regreso" Type="String" />
                            <asp:Parameter Name="hotel" Type="String" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="destino" Type="String" />
                            <asp:Parameter Name="fecha_salida" Type="String" />
                            <asp:Parameter Name="fecha_regreso" Type="String" />
                            <asp:Parameter Name="hotel" Type="String" />
                            <asp:Parameter Name="idviaje" Type="Int32" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 154px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 154px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>
