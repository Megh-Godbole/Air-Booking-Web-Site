<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBooking.Master" AutoEventWireup="true" CodeBehind="Confirmation_Page.aspx.cs" Inherits="State_Management_Tasks.Confirmation_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Booking Confirmed</p>
    <p>
        Name :
        <asp:Label ID="lblName" runat="server"></asp:Label>
    </p>
    <p>
        Age :
        <asp:Label ID="lblAge" runat="server"></asp:Label>
    </p>
    <p>
        From :
        <asp:Label ID="lblFrom" runat="server"></asp:Label>
    </p>
    <p>
        To :
        <asp:Label ID="lblTo" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnBack" runat="server" PostBackUrl="~/Default.aspx" Text="Back" />
    </p>
</asp:Content>
