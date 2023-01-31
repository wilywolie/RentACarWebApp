<%@ Page Async="true"  Title="" Language="C#" MasterPageFile="~/galeri.Master" AutoEventWireup="true" CodeBehind="modelekle.aspx.cs" Inherits="otoGaleriWebApp.modelekle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table">
        <tr>
            <td>Marka Adı: </td>
            <td><asp:TextBox ID="txtMarkaAdi" runat="server"/></td>
        </tr>
        <tr>
            <td>Marka Id: </td>
            <td><asp:TextBox ID="txtMarkaId" runat="server"/></td>
        </tr>
        <tr>
            <td>Marka seçin: </td>
            <td>
                <asp:DropDownList ID="ddlMarkalar" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Fotograf Yukleyin </td>
            <td>
                <asp:FileUpload ID="fileResim" runat="server" />
            </td>
        </tr>
         <tr>
            <td> </td>
            <td>
                <asp:Button runat="server" ID="btn1" OnClick="fileUpload" Text="MODEL EKLE" />
            </td>
        </tr>
    </table>
        

</asp:Content>
