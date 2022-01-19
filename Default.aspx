<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBooking.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="State_Management_Tasks.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="cph1">
    <br />
    Traveller Details
    <br />
    <br />
    Name :
    <asp:TextBox ID="tb_TravellerName" runat="server"></asp:TextBox>
    <br />
    <br />
    Age :
    <asp:TextBox ID="tb_TravellerAge" runat="server" TextMode="Number"></asp:TextBox>
    <br />
    <br />
    From Country :
    <asp:DropDownList ID="ddl_FromCountrys" runat="server">
        <asp:ListItem>IND</asp:ListItem>
        <asp:ListItem>USA</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    To Country :
    <asp:DropDownList ID="ddl_ToCountrys" runat="server">
        <asp:ListItem>IND</asp:ListItem>
        <asp:ListItem>USA</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:CheckBox ID="cb_IsRoundTrip" runat="server" Text=" Is Round Trip" />
    <br />
    <br />
    <asp:Button ID="btn_TravellerBook" runat="server" Text="Book" OnClick="btn_TravellerBook_Click" />
    <p>
    </p>
</asp:Content>

