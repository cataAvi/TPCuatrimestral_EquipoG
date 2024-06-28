<%@ Page Title="Cargos Activos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoCargos.aspx.cs" Inherits="TPCuatrimestral_EquipoG.ListadoCargos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Listado de los Cargos activos</h1>
    
    <asp:GridView ID="dgvCargos" DataKeyNames="Codigo" OnSelectedIndexChanged="dgvCargos_SelectedIndexChanged" CssClass="table" AutoGenerateColumns="false" runat="server">
       
        <Columns>
                 <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                 <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                 <asp:CommandField ShowSelectButton="true" SelectText="Ver Detalle/editar" HeaderText="✍️" />          
        </Columns>
    
    </asp:GridView>

        <hr />  
        <br />  
      
    <asp:Button ID="btnAgregarCargo" OnClick="btnAgregarCargo_Click" CssClass="btn btn-primary" runat="server" Text="Nuevo Cargo" />


</asp:Content>














