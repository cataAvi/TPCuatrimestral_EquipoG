<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Mensaje.aspx.cs" Inherits="TPCuatrimestral_EquipoG.Mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Acción realizada con éxito! </h1>
    <hr />
    <asp:LinkButton ID="LinkHome"  href="Default.aspx"  runat="server">Home</asp:LinkButton>
     <hr />
    <asp:LinkButton ID="LinkFormulario"  href="ListadoCliente.aspx"  runat="server">Volver al listado</asp:LinkButton>
</asp:Content>
