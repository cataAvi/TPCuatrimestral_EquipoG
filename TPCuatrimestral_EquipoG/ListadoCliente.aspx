<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoCliente.aspx.cs" Inherits="TPCuatrimestral_EquipoG.ListadoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Lista de Clientes</h1>
    <asp:GridView ID="dgvClientes" runat="server" DataKeyNames="Codigo" OnSelectedIndexChanged="dgvClientes_SelectedIndexChaged" CssClass="table" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField HeaderText ="Codigo" DataField ="Codigo" />
            <asp:BoundField Headertext ="Nombre" DataField ="Nombre" />
            <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText ="Accion" />
        </Columns>
    </asp:GridView>


    <hr />
    <br />

    <asp:Button ID="btnAgregarCliente" onclick="btnAgregarCliente_Click" runat="server" CssClass="btn btn-primary" Text="Crear Cliente" />

</asp:Content>
