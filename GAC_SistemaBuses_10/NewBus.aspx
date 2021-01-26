<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewBus.aspx.cs" Inherits="GAC_SistemaBuses_10.NewBus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2>Registro de Buses</h2>
        <p>&nbsp;</p>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Codigo" style="width:200px;">Código:</span>
                <asp:TextBox ID="txt_BusID" runat="server" placeholder="Ingrese el código" CssClass="form-control" Enabled="False" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Tipo" style="width:200px;">Tipo:</span>
	            <asp:DropDownList ID="ddl_TipoBus" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>
        <!--
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Rutas" style="width:200px;">Rutas:</span>
	            <asp:DropDownList ID="ddl_Rutas" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>-->

        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Operador" style="width:200px;">Operador:</span>
	            <asp:DropDownList ID="ddl_Operador" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>

        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_Ayudante" style="width:200px;">Ayudante:</span>
	            <asp:DropDownList ID="ddl_Ayudante" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Unidad" style="width:200px;">Unidad:</span>
                <asp:TextBox ID="txt_Unidad" runat="server" placeholder="Ingrese la Unidad" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Marca" style="width:200px;">Marca:</span>
                <asp:TextBox ID="txt_Marca" runat="server" placeholder="Ingrese la Marca" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Color" style="width:200px;">Color:</span>
                <asp:TextBox ID="txt_Color" runat="server" placeholder="Ingrese el Color" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_Año" style="width:200px;">Año de Fabricación:</span>
                <asp:TextBox ID="txt_FechaFabricacion" runat="server" placeholder="Ingrese F Fabricación" CssClass="form-control" style="width:400px;"></asp:TextBox>      
            </div>
            <div class="input-group" style="left: 200px; top: 0px">
            <asp:Calendar ID="cal_FechaFabricacion" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="cal_FechaCreacion_SelectionChanged"></asp:Calendar>
            </div>         
        </div>
        <!--
        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_boleto" style="width:200px;">Boleto:</span>
	            <asp:DropDownList ID="ddl_boleto" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>-->

        <div class="p-1">
                <div>
                    <asp:Button class="btn btn-dark btn-lg" style="margin-right:300px;" ID="btn_Salir" runat="server" Text="Salir" OnClick="btn_Salir_Click"/>
                    <asp:Button class="btn btn-danger btn-lg" ID="btn_Guardar" runat="server" Text="Guardar" OnClick="btn_Guardar_Click"/>         
                </div>  
        </div>
           
            
        
                    
          
            

    </div>
</asp:Content>
