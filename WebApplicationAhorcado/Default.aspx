<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationAhorcado._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="title">
            <h1 id="title">
                <asp:Label ID="LabelTitle" runat="server" Text="Ahorcado"></asp:Label>
            </h1>
            <h3>Vidas: <asp:Label ID="LabelVidas" runat="server" Text='<%# Vidas %>'></asp:Label></h3>
        </section>

        <div class="row">
            <section class="d-flex justify-content-center">
                <asp:Image ID="ImageAhorcado" runat="server" ImageUrl="~/Images/ahorcado_inicio.png" />
            </section>
            <section ID="Letters" runat="server" class="d-flex justify-content-center letters"></section>
            <section class="buttons">
                <div ID="ButtonsTop" runat="server" class="d-flex justify-content-center"></div>
                <div ID="ButtonsBottom" runat="server" class="d-flex justify-content-center"></div>
            </section>
        </div>
    </main>

</asp:Content>
