<%@ Page Title="Nueva Razon Social" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioRazonSocial.aspx.cs" Inherits="TPCuatrimestral_EquipoG.FormularioRazonSocial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .body {
            background-color: cadetblue;
        }

        .caja {
            height: 50px;
            text-align: left;
            margin: 5px;
            line-height: 50px;
            width: 40%;
            /*border: 1px solid #808080;*/
        }

        .cajaBig {
            flex-basis: 100%;
            height: 50px;
            text-align: left;
            margin: 5px;
            line-height: 50px;
            width: 40%;
            /*border: 1px solid #808080;*/
        }



        .flex-container {
            display: flex;
            justify-content: space-between;
            flex-flow: row wrap;
            flex-direction: row;
            width: 100%;
            background-color: cadetblue;
        }
    </style>

    <br />
    <hr />


    <section class="flex-container">
        <div class="caja">
            <asp:Label ID="lblCodigo" runat="server" Text="Codigo:"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <div class="caja">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <div class="caja">
            <asp:Label ID="lblCUIT" runat="server" Text="CUIT:"></asp:Label>
            <asp:TextBox ID="txtCUIT" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <%--(4 /4 )--%>
        <div class="caja">
            <asp:DropDownList ID="ddlClientes" AutoPostBack="true" runat="server"></asp:DropDownList>
        </div>
    
    
    
    
    </section>


    <br />
    <hr />

    
      
    <br />
    
    <asp:Button ID="btnGrabar" runat="server" CssClass="btn btn-primary" OnClick="btnGrabar_Click" Text="Grabar Registro" />


    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" CssClass="btn btn-danger" Text="Eliminar Registro" />

    <br />
    <hr />
  
   
       <%if (ConfirmaEliminacion)
                { %>
            <asp:CheckBox Text="Confirmar eliminación" ID="chbConfirmarEliminacion" runat="server" />
            <asp:Button ID="btnConfirmarEliminacion" OnClick="btnConfirmarEliminacion_Click" runat="server" CssClass="btn btn-outline-danger" Text="Eliminar Ahora Mismo" />
            <% } %>

    

</asp:Content>
