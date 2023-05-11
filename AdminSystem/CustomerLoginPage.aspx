<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLoginPage.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 30px;
        }
        .auto-style2 {
            margin-left: 55px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblemaillog" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emalbox1" runat="server" CssClass="auto-style2"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Passbox1" runat="server" CssClass="auto-style1"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="logbtn" runat="server" ForeColor="#0099FF" OnClick="logbtn_Click" Text="Login" Width="55px" />
            <asp:Button ID="delbtn" runat="server" ForeColor="#CC0000" OnClick="delbtn_Click" Text="Delete" />
        </p>
    </form>
</body>
</html>
