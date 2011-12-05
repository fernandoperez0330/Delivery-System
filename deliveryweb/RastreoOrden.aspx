<%@ Page Title="Rastreo de Orden - Delivery System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RastreoOrden.aspx.cs" Inherits="deliveryweb.RastreoOrden" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Rastreo de Ordenes</h2>
    <p>Ingrese el numero de rastreo de su paquete para que pueda ver el estatus de ella</p>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label">Numero de Rastreo: </asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Buscar" onclick="Button1_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
