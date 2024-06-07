<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tareas.aspx.cs" Inherits="TPCuatrimestral_EquipoG.Tareas" %>

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




    <button type="button" class="btn btn-secondary btn-sm" id="btnAnterior">Anterior</button>
    <button type="button" class="btn btn-primary btn-sm" id="btnBuscar">Buscar</button>
    <button type="button" class="btn btn-secondary btn-sm" id="btnSiguiente">Siguiente</button>

    <br />
    <hr />

    <section class="flex-container">

        <div class="caja">
            <asp:Label ID="lbAsunto" runat="server" Text="Asunto:"></asp:Label>
            <asp:TextBox ID="txbAsunto" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="caja">
            <asp:Label ID="lbNumero" runat="server" Text="Número:"></asp:Label>
            <asp:TextBox ID="txbNumero" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="cajaBig">
            <asp:Label ID="lbTipoTarea" runat="server" Text="Tipo de tarea:"></asp:Label>
            <asp:TextBox ID="txbTipoTarea" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <br />
        <hr />
        <div class="caja">
            <asp:Label ID="lbCliente" runat="server" Text="Cliente:"></asp:Label>
            <asp:TextBox ID="txbCliente" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="caja">
            <asp:Label ID="lbRzSocial" runat="server" Text="Razón Social:"></asp:Label>
            <asp:TextBox ID="txbRzSocial" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
      
        <div class="cajaBig">
            <asp:Label ID="lbAsignacion" runat="server" Text="Asignado a:"></asp:Label>
            <asp:TextBox ID="txbAsignacion" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
       
        <div class="caja">
            <asp:Label ID="lbFechaInicio" runat="server" Text="Fecha Inicio:"></asp:Label>
            <asp:TextBox ID="txbFechaInicio" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="caja">
            <asp:Label ID="lbFechaVencimiento" runat="server" Text="Fecha Vencimiento:"></asp:Label>
            <asp:TextBox ID="txbFechaVencimiento" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="caja">
            <asp:Label ID="lbIncidente" runat="server" Text="Incidente:"></asp:Label>
            <asp:TextBox ID="txbIncidente" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="caja">
            <asp:Label ID="lbCierre" runat="server" Text="Cierre:"></asp:Label>
            <asp:TextBox ID="txbCierre" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
    </section>



    <br />
    <hr />

    <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="Aceptar" />
    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" />






</asp:Content>
