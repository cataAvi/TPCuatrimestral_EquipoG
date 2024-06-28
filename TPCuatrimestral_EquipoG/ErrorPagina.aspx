<%@ Page Title="Error" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorPagina.aspx.cs" Inherits="TPCuatrimestral_EquipoG.ErrorPagina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <title>Error</title>

    <body>
        <div>
            <h1>Ha ocurrido un error</h1>
            <asp:Label ID="lblErrorMessage" runat="server" Text="Error: "></asp:Label>
        </div>
    </body>

    
</asp:Content>
