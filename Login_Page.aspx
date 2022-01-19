<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Page.aspx.cs" Inherits="State_Management_Tasks.Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User Name :  <asp:TextBox ID="tb_UserName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_UserName" runat="server" ErrorMessage="User Name Can't Be Empty" ControlToValidate="tb_UserName" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><br />
            Password : <asp:TextBox ID="tb_Password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_Password" runat="server" ErrorMessage="Password Can't Be Empty" ControlToValidate="tb_Password" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><br />
            <asp:Button ID="btn_Submit" runat="server" Text="Submit" OnClick="btn_Submit_Click" />
            <br /><br />
            <asp:Label ID="lbl_Messege" runat="server" Text="" ForeColor ="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
