<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchBus.aspx.cs" Inherits="GAC_SistemaBuses_10.SearchBus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>

        <h2>Administrar Buses</h2>

        <table>
            <tr>
                <td>
                    <div class="input-group">
                        <span class="input-group-btn">
                            <asp:LinkButton ID="lb_Buscar" runat="server" class="btn btn-danger" Text="Buscar" OnClick="lb_Buscar_Click"><span class="glyphicon glyphicon-search"></span>&nbspBuscar</asp:LinkButton>
                        </span>                 
                        <asp:TextBox ID="txt_Criterio" placeholder="Ingrese" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </td>
            </tr>

            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>

             <tr>
                    <td>
        
                        <asp:UpdatePanel ID="udp_Buses" runat="server">
                            <ContentTemplate>
                                <asp:GridView ID="gv_Buses" runat="server" AutoGenerateColumns="False" CellPadding="4" CellSpacing="2" EmptyDataText="No se encontró ningun registro" ForeColor="#333333" GridLines="Vertical" Height="62px" HorizontalAlign="Center" OnRowCommand="gv_Buses_RowCommand" Width="690px">
                                    <AlternatingRowStyle BackColor="White" HorizontalAlign="Left" VerticalAlign="Middle" />
                                    <Columns>
                                        <asp:BoundField DataField="id_bus" HeaderText="Id_Bus" />
                                        <asp:BoundField DataField="unidad" HeaderText="Unidad" />
                                        <asp:BoundField DataField="marca" HeaderText="Marca" />
                                        <asp:BoundField DataField="color" HeaderText="Color" />
                                        <asp:BoundField DataField="añofabricacion" HeaderText="Año de Fabricación" />
                                        <asp:ButtonField AccessibleHeaderText="Actualizar" CommandName="Actualizar" HeaderText="Actualizar" Text="Actualizar" ControlStyle-ForeColor="white" ControlStyle-BackColor="#821223" ControlStyle-Font-Bold="true"/>
                                        <asp:ButtonField AccessibleHeaderText="Eliminar" CommandName="Eliminar" HeaderText="Eliminar" Text="Eliminar" ControlStyle-ForeColor="white" ControlStyle-BackColor="#821223" ControlStyle-Font-Bold="true" />
                                    </Columns>
                                    <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#821223" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                    <SortedDescendingHeaderStyle BackColor="#820000" />
                                </asp:GridView>
                            </ContentTemplate>
                        </asp:UpdatePanel>
        
                     </td>
             </tr>
        </table>
        <p>&nbsp;</p>
        <div class="p-1">
                <div>
                    <asp:Button class="btn btn-dark btn-lg" style="margin-right:300px;" ID="btn_Salir" runat="server" Text="Salir" OnClick="btn_Salir_Click"/>
                    <asp:Button class="btn btn-danger btn-lg" ID="btn_Nuevo" runat="server" Text="Nuevo" OnClick="btn_Nuevo_Click"/>         
                </div>  
        </div>
  </div>

</asp:Content>
