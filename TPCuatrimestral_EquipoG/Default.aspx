<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPCuatrimestral_EquipoG._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style>
        .slide {
            margin-top: 10px;
        }

        .slide img {
            height: 75vh;
        }

    </style>

   
    <%--CARROUSEL DE IMAGENES--%>
    <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="https://nine9crmcenter.com.br/wp-content/uploads/2021/02/capaatendimentoaocliente.png" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="https://www.ptmitratama.com/wp-content/uploads/2021/06/Kenali-Manfaat-Call-Center-bagi-Suatu-Perusahaan-848x450.jpg" class="d-block w-100" alt="...">
            </div>
            <div class="carousel-item">
                <img src="https://blogimages.softwaresuggest.com/blog/wp-content/uploads/2021/03/14170730/How-To-Setup-A-Call-Center-A-Comprehensive-Guide.jpg" class="d-block w-100" alt="...">
            </div>
        </div>
    </div>
    <%--FIN DEL CARROUSEL--%>




</asp:Content>
