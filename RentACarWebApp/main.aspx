<%@ Page  Title="" Language="C#" MasterPageFile="~/galeri.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="otoGaleriWebApp.main" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row text-center">
        <div class="card col-3 bg-primary text-light text-center m-3 p-2">
            <asp:Image runat="server" ID="img1" class="img-fluid" Height="200px"/>
            <br/>
            <a href="modeller.aspx?markaadi=audi" class="btn btn-light w-75 btn-outline-success">
                <asp:Label ID="lblModel1" runat="server" Text="arac1"></asp:Label>
            </a>
        </div>
        <div class="card col-3 bg-primary text-light text-center m-3 p-2">
            <asp:Image runat="server" ID="img2" class="img-fluid"  Height="200px"/>
            <br/>
            <a href="modeller.aspx?markaadi=bmw" class="btn btn-light w-75 btn-outline-success">
                <asp:Label ID="lblModel2" runat="server" Text="arac2"></asp:Label>

            </a>
        </div>
    </div>

</asp:Content>
