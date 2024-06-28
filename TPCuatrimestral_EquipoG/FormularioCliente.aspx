<%@ Page Title="Nuevo Cargo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioCliente.aspx.cs" Inherits="TPCuatrimestral_EquipoG.FormularioCliente" %>

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



    <%--BOTONES ANTERIOR/BUSCAR/SIGUIENTE--%>
    <asp:Button ID="btnAnterior" cssclass="btn btn-secondary btn-sm" OnClick="btnAnterior_Click" runat="server" Text="Anterior" />
    <asp:Button ID="btnBuscar" cssclass="btn btn-primary btn-sm" OnClick="btnBuscar_Click" runat="server" Text="Buscar" />
    <asp:Button ID="btnSiguiente" cssclass="btn btn-secondary btn-sm" OnClick="btnSiguiente_Click" runat="server" Text="Siguiente" />

<%--    <button type="button" class="btn btn-secondary btn-sm"  id="btnEditar">✏️</button>
    <button type="button" class="btn btn-secondary btn-sm" href="ListadoCliente.aspx" id="btnAlta">➕</button>
    <button type="button" class="btn btn-secondary btn-sm" id="btnEliminar">❌</button>--%>


    <br />
    <hr />

    <section class="flex-container">

        <div class="caja">
            <asp:Label ID="lbCodigo" runat="server" Text="Código:"></asp:Label>
            <asp:TextBox ID="txbCodigo" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <div class="caja">
            <asp:Label ID="lbNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txbNombre" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <div class="caja">
            <asp:Label ID="lbTelefono" runat="server" Text="Telefono:"></asp:Label>
            <asp:TextBox ID="txbTelefono" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>



        <div class="caja">
            <asp:Label ID="lbEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txbEmail" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>


    </section>


    <br />
    <hr />

    <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" OnClick="btnGrabar_Click" Text="Editar" />

            <asp:Button ID="Button1" runat="server" OnClick="btnBorrar_Click" CssClass="btn btn-danger" Text="Eliminar" />

            <br />
            <hr />

            <%if (ConfirmaEliminacion)
                { %>
            <asp:CheckBox Text="Confirmar eliminación" ID="chbConfirmarEliminacion" runat="server" />
            <asp:Button ID="btnConfirmarEliminacion" OnClick="btnConfirmaEliminacion_Click" runat="server" CssClass="btn btn-outline-danger" Text="Eliminar" />
            <% } %>




</asp:Content>
