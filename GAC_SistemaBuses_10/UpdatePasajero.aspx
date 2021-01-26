<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePasajero.aspx.cs" Inherits="GAC_SistemaBuses_10.UpdatePasajero" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h2>Actualización de Pasajeros</h2>
        <p>&nbsp;</p>

        <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Codigo" style="width:200px;">Código:</span>
                <asp:TextBox ID="txt_id" runat="server" placeholder="Ingrese el código" CssClass="form-control" Enabled="False" style="width:400px;"></asp:TextBox>
            </div>
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Unidad" style="width:200px;">Nombre:</span>
                <asp:TextBox ID="txt_nombre" runat="server" placeholder="Ingrese el Nombre" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Marca" style="width:200px;">Apellido:</span>
                <asp:TextBox ID="txt_apellido" runat="server" placeholder="Ingrese el Apellido" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

         <div class="p-1">
            <div class="input-group">
                <span class="input-group-addon" id="lbl_Color" style="width:200px;">Cédula:</span>
                <asp:TextBox ID="txt_cedula" runat="server" placeholder="Ingrese la Cédula" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
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
                <asp:TextBox ID="txt_telefono" runat="server" placeholder="Ingrese el telefono" CssClass="form-control" Enabled="True" style="width:400px;"></asp:TextBox>
            </div>
        </div>

        <div class="p-1">
            <div class="input-group" style="left: 0px; top: 0px">
                <span class="input-group-addon" id="lbl_Año" style="width:200px;">Año de Fabricación:</span>
                <asp:TextBox ID="txt_FechaNacimiento" runat="server" placeholder="Ingrese Fecha de Nacimiento" CssClass="form-control" style="width:400px;"></asp:TextBox>      
            </div>
            <div class="input-group" style="left: 200px; top: 0px">
            <asp:Calendar ID="cal_FechaNacimiento" runat="server" SelectedDate="07/22/2018 14:50:51" OnSelectionChanged="cal_FechaNacimiento_SelectionChanged"></asp:Calendar>
            </div>         
        </div>

        <div class="p-1"> 
            <div class ="input-group">
	            <span class="input-group-addon" id="lbl_sexo" style="width:200px;">Sexo:</span>
	            <asp:DropDownList ID="ddl_sexo" runat="server" CssClass="form-control" AutoPostBack="True" Width="300px">
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
