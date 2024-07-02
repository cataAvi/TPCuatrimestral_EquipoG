<%@ Page Title="Razones Sociales Activas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoRazonSocial.aspx.cs" Inherits="TPCuatrimestral_EquipoG.ListadoRazonSocial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Razones Sociales Activas!</h1>
    <asp:GridView ID="dgvRazonesSociales" DataKeyNames="Codigo" OnSelectedIndexChanged="dgvRazonesSociales_SelectedIndexChanged" CssClass="table" AutoGenerateColumns="false" runat="server">
        <Columns>
           
          
            <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="CUIT" DataField="CUIT" />
            <asp:BoundField HeaderText="Cliente" DataField="CodigoCliente" />


            <asp:CommandField ShowSelectButton="true" SelectText="✍️" HeaderText="✍️Edit" />
           
        </Columns>

    </asp:GridView>

   

    <hr />  
    <br />  
      
    <asp:Button ID="btnAgregarRazonSocial" OnClick="btnAgregarRazonSocial_Click" CssClass="btn btn-primary" runat="server" Text="Nueva Razon Social" />


</asp:Content>
