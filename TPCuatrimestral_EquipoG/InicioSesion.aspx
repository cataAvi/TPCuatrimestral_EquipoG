<%@ Page Title="InicioSesion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="InicioSesion.aspx.cs" Inherits="TPCuatrimestral_EquipoG.InicioSesion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .caja {
            height: 50px;
            text-align: right;
            margin: 5px;
            line-height: 50px;
            width: 40%;
            /*border: 1px solid #808080;*/
        }

        .cajaBig {
            flex-basis: 100%;
            height: 50px;
            text-align: center;
            margin: 5px;
            line-height: 50px;
            width: 40%;
            /*border: 1px solid #808080;*/
        }

        .flex-container {
            display: flex;
            justify-content: center;
            align-content: center;
            flex-flow: row wrap;
            flex-direction: row;
            width: 50%;
            background-color: cadetblue;
            border: 1px solid #4800ff;
        }
    </style>

    <br />
    <hr />

    <section class="flex-container">

        <div class="cajaBig">
            <asp:Label ID="lbUsuario" runat="server" Text="Usuario: "></asp:Label>
            <asp:TextBox ID="txbAsunto" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="cajaBig">
            <asp:Label ID="lbContra" runat="server" Text="Contraseña: "></asp:Label>
            <asp:TextBox ID="txbContra" runat="server" Width="350px" Height="30px" BackColor="LightBlue"></asp:TextBox>
        </div>
        <div class="caja">
            <asp:Button ID="btnIngresar" runat="server" CssClass="btn btn-primary" Text="Ingresar" />
        </div>
    </section>


    <br />


</asp:Content>
