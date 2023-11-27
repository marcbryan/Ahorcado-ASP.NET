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
            <section class="d-flex justify-content-center letters">
                <asp:Label ID="LabelLetter1" runat="server" Text='<%# Chars[0] %>'></asp:Label>
                <asp:Label ID="LabelLetter2" runat="server" Text='<%# Chars[1] %>'></asp:Label>
                <asp:Label ID="LabelLetter3" runat="server" Text='<%# Chars[2] %>'></asp:Label>
                <asp:Label ID="LabelLetter4" runat="server" Text='<%# Chars[3] %>'></asp:Label>
                <asp:Label ID="LabelLetter5" runat="server" Text='<%# Chars[4] %>'></asp:Label>
                <asp:Label ID="LabelLetter6" runat="server" Text='<%# Chars[5] %>'></asp:Label>
                <asp:Label ID="LabelLetter7" runat="server" Text='<%# Chars[6] %>'></asp:Label>
                <asp:Label ID="LabelLetter8" runat="server" Text='<%# Chars[7] %>'></asp:Label>
            </section>
            <section class="buttons">
                <div class="d-flex justify-content-center">
                    <asp:Button ID="ButtonA" runat="server" Text="A" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonB" runat="server" Text="B" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonC" runat="server" Text="C" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonD" runat="server" Text="D" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonE" runat="server" Text="E" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonF" runat="server" Text="F" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonG" runat="server" Text="G" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonH" runat="server" Text="H" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonI" runat="server" Text="I" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonJ" runat="server" Text="J" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonK" runat="server" Text="K" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonL" runat="server" Text="L" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonM" runat="server" Text="M" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                </div>
                <div class="d-flex justify-content-center">
                    <asp:Button ID="ButtonN" runat="server" Text="N" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonO" runat="server" Text="O" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonP" runat="server" Text="P" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonQ" runat="server" Text="Q" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonR" runat="server" Text="R" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonS" runat="server" Text="S" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonT" runat="server" Text="T" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonU" runat="server" Text="U" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonV" runat="server" Text="V" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonW" runat="server" Text="W" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonX" runat="server" Text="X" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonY" runat="server" Text="Y" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                    <asp:Button ID="ButtonZ" runat="server" Text="Z" class="btn btn-secondary" OnClick="ButtonLetter_Click" />
                </div>
            </section>
        </div>
    </main>

</asp:Content>
