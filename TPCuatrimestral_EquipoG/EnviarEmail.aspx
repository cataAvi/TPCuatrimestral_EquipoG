<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnviarEmail.aspx.cs" Inherits="TPCuatrimestral_EquipoG.EnviarEmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <h2>Bienvenido! completa los datos para enviar un email...</h2>
    <br />
    <%--INYECTO UN POCO DE BOOSTRAP!--%>

    <form>
        <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Email address</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
        </div>
        <div class="mb-3">
            <label for="exampleInputPassword1" class="form-label">Password</label>
            <asp:TextBox ID="txtPassword"  runat="server"></asp:TextBox>
        </div>

         <div class="mb-3">
            <label for="exampleInputPassword1" class="form-label">Mensaje</label>
            <asp:TextBox ID="txtMensaje"  runat="server"></asp:TextBox>
        </div>




        <div class="mb-3 form-check">
            <input type="checkbox" class="form-check-input" id="exampleCheck1">
            <label class="form-check-label" for="exampleCheck1">Complete todo ?</label>
        </div>
        
        <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
       
    </form>






</asp:Content>
