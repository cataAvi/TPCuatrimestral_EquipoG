<%@ Page Title="Incidentes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Incidentes.aspx.cs" Inherits="TPCuatrimestral_EquipoG.Incidentes" %>

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
    <button type="button" class="btn btn-secondary btn-sm" id="btnAnterior">Anterior</button>
    <button type="button" class="btn btn-primary btn-sm" id="btnBuscar">Buscar</button>
    <button type="button" class="btn btn-secondary btn-sm" id="btnSiguiente">Siguiente</button>

    <button type="button" class="btn btn-secondary btn-sm" id="btnAlta">✏️</button>
    <button type="button" class="btn btn-secondary btn-sm" id="btnEditar">➕</button>
    <button type="button" class="btn btn-secondary btn-sm" id="btnEliminar">❌</button>


    <br />
    <hr />

    <section class="flex-container">

        <div class="caja">
            <asp:Label ID="lblNroIncidente" runat="server" Text="Número Incidente:"></asp:Label>
            <asp:TextBox ID="txtNroIncidente" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <div class="caja">
            <asp:Label ID="lblregistradoPor" runat="server" Text="Registrado por:"></asp:Label>
            <asp:TextBox ID="txtRegistradoPor" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <div class="caja">
            <asp:Label ID="lbFechaRegistro" runat="server" Text="Fecha de Registro:"></asp:Label>
            <asp:TextBox ID="txtFechaRegistro" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>


        <%--GENERALES > CLIENTE nro > RAZON SOCIAL--%>
        <div class="caja">
            <asp:Label ID="lblNroCliente" runat="server" Text="Numero de Cliente:"></asp:Label>
            <asp:TextBox ID="txtNroCliente" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>

        <div class="caja">
            <asp:Label ID="lblRazonSocial" runat="server" Text="Razón Social:"></asp:Label>
            <asp:TextBox ID="txtRazonSocial" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>


        <br />

        <%--Prioridad: Una lista desplegable para seleccionar la prioridad (baja, media, alta).--%>

        <div class="caja">
            <asp:Label ID="lblPrioridad" runat="server" Text="Tipo de Prioridad:"></asp:Label>
            <asp:DropDownList ID="ddlPrioridad" runat="server"></asp:DropDownList>
        </div>
        <hr />


        <div class="caja">
            <asp:Label ID="lblTipo" runat="server" Text="Tipo:"></asp:Label>
            <asp:TextBox ID="txbTipo" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <hr />


        <%--CAJA DE TEXTO PARA LA DESCRIPCION DEL PROBLEMA--%>
        <div class="caja">
            <asp:Label ID="lblDescripcionProblema" runat="server" Text="Descripcion del Problema:"></asp:Label>
            <asp:TextBox ID="txtDescripcionProblema" runat="server" Width="300px" Height="30px" BackColor="LightBlue"></asp:TextBox>

        </div>



    </section>


    <br />
    <hr />

    <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary" Text="Grabar" />
    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" />



















</asp:Content>
