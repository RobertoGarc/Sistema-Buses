<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateOperador.aspx.cs" Inherits="GAC_SistemaBuses_10.UpdateOperador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div>
        <h2>Actualizar Operador</h2>
        <p>&nbsp;</p>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Codigo" style="width:200px;">Código:</span>
                <asp:TextBox ID="txt_idOperador" runat="server" placeholder="Ingrese el código" CssClass="form-control" Enabled="False" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_nombre" style="width:200px;">Nombre:</span>
                <asp:TextBox ID="txt_nombre" runat="server" placeholder="Ingrese el Nombre" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_cedula" style="width:200px;">Cedula:</span>
                <asp:TextBox ID="txt_cedula" runat="server" placeholder="Ingrese la Cedula" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_fechaNacimiento" style="width:200px;">Fecha de Nacimiento:</span>
                <asp:TextBox ID="txt_fechaNacimiento" runat="server" placeholder="Ingrese año de nacimiento" CssClass="form-control" style="width:400px;"></asp:TextBox>      
            </div>
            <div class="input-group" style="left: 200px; top: 0px">
            <asp:Calendar ID="cal_fechaNacimiento" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="cal_fechaNacimiento_SelectionChanged"></asp:Calendar>
            </div>         
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_direccion" style="width:200px;">Dirección:</span>
                <asp:TextBox ID="txt_direccion" runat="server" placeholder="Ingrese la Dirección" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_telefono" style="width:200px;">Teléfono:</span>
                <asp:TextBox ID="txt_telefono" runat="server" placeholder="Ingrese el teléfono" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
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
	            <span class="input-group-addon" id="lbl_sexo" style="width:200px;">Sexo:</span>
	            <asp:DropDownList ID="ddl_Sexo" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
	            </asp:DropDownList>
            </div>
        </div>

        <div class="p-1">
                <div>
                    <asp:Button class="btn btn-dark btn-lg" style="margin-right:300px;" ID="btn_Salir" runat="server" Text="Salir" OnClick="btn_Salir_Click"/>
                    <asp:Button class="btn btn-danger btn-lg" ID="btn_Actualizar" runat="server" Text="Actualizar" OnClick="btn_Actualizar_Click"/>         
                </div>  
        </div>
    </div>

</asp:Content>
