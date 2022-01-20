<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBooking.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="State_Management_Tasks.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph1" runat="server">
    <br />
    Booking Confirmed<br />
    <br />
    <asp:Button ID="btnConfirmBooking" runat="server" PostBackUrl="~/Confirmation_Page.aspx" Text="View Booking Details" />
    <br />
    <br />
    <asp:Button ID="btnBack" runat="server" PostBackUrl="~/Default.aspx" Text="Back" />
</asp:Content>
