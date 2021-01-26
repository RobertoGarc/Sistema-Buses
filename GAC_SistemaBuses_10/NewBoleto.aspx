<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewBoleto.aspx.cs" Inherits="GAC_SistemaBuses_10.NewBoleto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2>Registro de Boletos</h2>
        <p>&nbsp;</p>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Boleto" style="width:200px;">Código:</span>
                <asp:TextBox ID="txt_idBoleto" runat="server" placeholder="Ingrese el código" CssClass="form-control" Enabled="False" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_pasajero" style="width:200px;">Usuario:</span>
	            <asp:DropDownList ID="ddl_pasajero" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>

        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_bus" style="width:200px;">Bus:</span>
	            <asp:DropDownList ID="ddl_bus" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>

        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Ruta" style="width:200px;">Ruta:</span>
	            <asp:DropDownList ID="ddl_ruta" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
       

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_horasalida" style="width:200px;">Hora de Salida:</span>
                <asp:TextBox ID="txt_horasalida" runat="server" placeholder="Ingrese la hora de salida" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_salida" style="width:200px;">Fecha de salida:</span>
                <asp:TextBox ID="txt_salida" runat="server" placeholder="Ingrese Fecha de salida" CssClass="form-control" style="width:400px;"></asp:TextBox>      
            </div>
            <div class="input-group" style="left: 200px; top: 0px">
            <asp:Calendar ID="cal_FechaSalida" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="cal_FechaSalida_SelectionChanged"></asp:Calendar>
            </div>         
        </div>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Asientos" style="width:200px;">Asiento:</span>
                <asp:TextBox ID="txt_asientos" runat="server" placeholder="Ingrese el asiento" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Precio" style="width:200px;">Precio:</span>
                <asp:TextBox ID="txt_precio" runat="server" placeholder="Ingrese el precio" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

         <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_vendedor" style="width:200px;">Vendedor:</span>
	            <asp:DropDownList ID="ddl_vendedor" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>

        <div class="p-1">
                <div>
                    <asp:Button class="btn btn-dark btn-lg" style="margin-right:300px;" ID="btn_Salir" runat="server" Text="Salir" OnClick="btn_Salir_Click"/>
                    <asp:Button class="btn btn-danger btn-lg" ID="btn_Guardar" runat="server" Text="Guardar" OnClick="btn_Guardar_Click"/>         
                </div>  
        </div>
           
</div>
</asp:Content>
