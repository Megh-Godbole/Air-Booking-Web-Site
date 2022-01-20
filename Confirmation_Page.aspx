<%@ Page Title="" Language="C#" MasterPageFile="~/MasterBooking.Master" AutoEventWireup="true" CodeBehind="Confirmation_Page.aspx.cs" Inherits="State_Management_Tasks.Confirmation_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cph1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        Booking Confirmed</p>
    <p>
        <asp:Label ID="lblTravellerDetails" runat="server"></asp:Label>
    </p>
    <p>
        <strong>
        <asp:Button ID="btnBack" runat="server" PostBackUrl="~/Default.aspx" Text="Back" CssClass="auto-style1" />
        </strong>
    </p>
</asp:Content>
