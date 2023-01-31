<%@ Page enableEventValidation="false" Title="" Language="C#" MasterPageFile="~/galeri.Master" AutoEventWireup="true" CodeBehind="modeller.aspx.cs" Inherits="otoGaleriWebApp.modeller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
    <asp:Repeater ID="Repeater1" runat="server">
             <ItemTemplate>
                 <div class="card col-3 p-3 m-2">
                     <img src="<%#  Eval("modelimageurl") %>" class="img-thumbnail" height="200px">
                     <h3><%#  Eval("modeladi") %></h3>
                     <asp:Button  class="btn-light btn-outline-dark" runat="server" OnClick="item_Click" CommandArgument='<%# Eval("modelid") %>' text="Satın Al"></asp:Button>
                 </div>
              </ItemTemplate>
    </asp:Repeater>
        </div>

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />

</asp:Content>
