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

    <br />
    <hr />

    <section class="flex-container">


        <%--GENERALES > CLIENTE > RAZON SOCIAL--%>
        <div class="caja">
            <asp:Label ID="lblCliente" runat="server" Text="Cliente:"></asp:Label>
            <asp:TextBox ID="txtCliente" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
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



        <%--CAJA DE TEXTO PARA LA DESCRIPCION DEL PROBLEMA--%>
        <div class="caja">
            <asp:Label ID="lblDescripcionProblema" runat="server" Text="Descripcion del Problema:"></asp:Label>
            <asp:TextBox ID="txtDescripcionProblema" runat="server" Width="300px" Height="30px" BackColor="LightBlue"></asp:TextBox>

        </div>
        




        <asp:Button ID="btnRegistrarIncidente" runat="server" Text="Registrar Incidente " />
        
        <hr />




    </section>



    


    <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-primary" Text="Cancelar" />



















</asp:Content>
