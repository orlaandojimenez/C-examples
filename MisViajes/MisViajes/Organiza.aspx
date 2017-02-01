<%@ Page Title="" Language="C#" MasterPageFile="~/masterPage.Master" AutoEventWireup="true" CodeBehind="Organiza.aspx.cs" Inherits="MisViajes.Organiza" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <table style="width:100%;">
            <tr>
                <td style="width: 34px">&nbsp;</td>
                <td>
                    <h1>Organizar</h1>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td rowspan="2" style="width: 34px">
                    <img alt="" src="images/organizar.jpg" style="width: 400px; height: 300px" /></td>
                <td rowspan="2">
                    <asp:GridView ID="GridViewOrganiza" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="idorganiza" DataSourceID="SqlDataSourceOrganiza" ForeColor="#333333" GridLines="None" ShowFooter="True" AllowPaging="True">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                            <asp:TemplateField HeaderText="ID" InsertVisible="False" SortExpression="idorganiza">
                                <EditItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("idorganiza") %>'></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("idorganiza") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:LinkButton OnClick="lbInsert_Click" ValidationGroup="INSERT" ID="lbInsert" runat="server">Agregar</asp:LinkButton>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Viaje" SortExpression="idviaje">
                                <EditItemTemplate>
                                    <asp:DropDownList ID="DropDownListEditViaje" runat="server" DataSourceID="SqlDataSourceEditViaje" DataTextField="destino" DataValueField="idviaje" SelectedValue='<%# Bind("idviaje") %>'></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourceEditViaje" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("idviaje") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:DropDownList ID="DropDownListInsertViaje" runat="server" DataSourceID="SqlDataSourceViaje" DataTextField="destino" DataValueField="idviaje" SelectedValue='<%# Bind("idviaje") %>'></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourceViaje" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Persona" SortExpression="idpersona">
                                <EditItemTemplate>
                                    <asp:DropDownList ID="DropDownListEditPersona" runat="server" DataSourceID="SqlDataSourcePersona" DataTextField="nombre" DataValueField="idpersona" SelectedValue='<%# Bind("idpersona") %>'></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourcePersona" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idpersona], [nombre] FROM [personas]"></asp:SqlDataSource>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("idpersona") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:DropDownList ID="DropDownListInsertPersona" runat="server" DataSourceID="SqlDataSourceInsertPersona" DataTextField="nombre" DataValueField="idpersona"></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourceInsertPersona" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idpersona], [nombre] FROM [personas]"></asp:SqlDataSource>
                                </FooterTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Pagado" SortExpression="pagado">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("pagado") %>'></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="rfvEditPagado" runat="server" ErrorMessage="Favor de ingresar el valor" 
                                        ControlToValidate="TextBox3" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("pagado") %>'></asp:Label>
                                </ItemTemplate>
                                <FooterTemplate>
                                    <asp:TextBox ID="TextBoxPagado" runat="server"></asp:TextBox>
                                     <asp:RequiredFieldValidator ValidationGroup="INSERT" ID="rfvInsertPagado" runat="server" ErrorMessage="Favor de ingresar el valor" 
                                        ControlToValidate="TextBoxPagado" Text="*" ForeColor="Red">
                                    </asp:RequiredFieldValidator>
                                </FooterTemplate>
                            </asp:TemplateField>
                        </Columns>
                       <%-- <EmptyDataTemplate>
                             <asp:LinkButton OnClick="lbInsert_Click" ValidationGroup="INSERT" ID="lbInsert" runat="server">Agregar</asp:LinkButton>

                            <asp:DropDownList ID="DropDownListInsertViaje" runat="server" DataSourceID="SqlDataSourceViaje" DataTextField="destino" DataValueField="idviaje" SelectedValue='<%# Bind("idviaje") %>'></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourceViaje" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>

                            <asp:DropDownList ID="DropDownListInsertPersona" runat="server" DataSourceID="SqlDataSourceInsertPersona" DataTextField="nombre" DataValueField="idpersona"></asp:DropDownList>
                                    <asp:SqlDataSource runat="server" ID="SqlDataSourceInsertPersona" ConnectionString='<%$ ConnectionStrings:ViajesConnectionString %>' SelectCommand="SELECT [idpersona], [nombre] FROM [personas]"></asp:SqlDataSource>

                             <asp:TextBox ID="TextBoxPagado" runat="server"></asp:TextBox>
                        </EmptyDataTemplate>--%>
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
                    <asp:SqlDataSource ID="SqlDataSourceOrganiza" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" DeleteCommand="DELETE FROM [organiza] WHERE [idorganiza] = @idorganiza" InsertCommand="INSERT INTO [organiza] ([idviaje], [idpersona], [pagado]) VALUES (@idviaje, @idpersona, @pagado)" SelectCommand="SELECT * FROM [organiza]" UpdateCommand="UPDATE [organiza] SET [idviaje] = @idviaje, [idpersona] = @idpersona, [pagado] = @pagado WHERE [idorganiza] = @idorganiza">
                        <DeleteParameters>
                            <asp:Parameter Name="idorganiza" Type="Int32" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="idviaje" Type="Int32" />
                            <asp:Parameter Name="idpersona" Type="Int32" />
                            <asp:Parameter Name="pagado" Type="Decimal" />
                        </InsertParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="idviaje" Type="Int32" />
                            <asp:Parameter Name="idpersona" Type="Int32" />
                            <asp:Parameter Name="pagado" Type="Decimal" />
                            <asp:Parameter Name="idorganiza" Type="Int32" />
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
    <div>

    </div>
    <div>

        <table style="width:100%;">
            <tr>
                <td >
                    
                </td>
                <td>
                    <h2>Consulta</h2>
                </td>
                <td style="width: 300px">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSourceViajes" DataTextField="destino" DataValueField="idviaje" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceViajes" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" SelectCommand="SELECT [idviaje], [destino] FROM [viaje]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td style="width: 401px">&nbsp;</td>
                <td>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSourceViewOrganiza" ForeColor="#333333" GridLines="None" Width="867px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="idorganiza" HeaderText="ID" SortExpression="idorganiza" />
                <%--<asp:BoundField DataField="idviaje" HeaderText="idviaje" SortExpression="idviaje" />--%>
                <asp:BoundField DataField="destino" HeaderText="Destino" SortExpression="destino" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre" SortExpression="nombre" />
                <asp:BoundField DataField="pagado" HeaderText="Pagado" SortExpression="pagado" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
                     <asp:SqlDataSource ID="SqlDataSourceViewOrganiza" runat="server" ConnectionString="<%$ ConnectionStrings:ViajesConnectionString %>" SelectCommand="SELECT idorganiza, destino, nombre, pagado FROM View_Organiza WHERE (idviaje = @idviaje)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="idviaje" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 300px">&nbsp;</td>
                <td>
       

                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>
