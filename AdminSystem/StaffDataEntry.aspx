

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 75px;
        }
        .auto-style2 {
            margin-left: 40px;
        }
        .auto-style3 {
            margin-left: 43px;
        }
        .auto-style4 {
            margin-left: 45px;
        }
        .auto-style5 {
            margin-left: 33px;
        }
        .auto-style6 {
            margin-left: 83px;
        }
        .auto-style7 {
            margin-left: 87px;
        }
        .auto-style8 {
            margin-left: 56px;
        }
    </style>
</head>
<body style="height: 321px; width: 925px">
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Staff Registration Page<br />
        </div>
        First Name<asp:TextBox ID="Emlbox" runat="server" CssClass="auto-style1" Height="18px" Width="116px"></asp:TextBox>
        <p>
            <asp:Label ID="lbllname" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="lnamebox" runat="server" CssClass="auto-style2" Height="18px" Width="116px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbldob" runat="server" Text="Dob"></asp:Label>
            <asp:TextBox ID="dobbox" runat="server" CssClass="auto-style6" Height="18px" Width="116px"></asp:TextBox>
        </p>
        <p>
            Address<asp:TextBox ID="citybox" runat="server" CssClass="auto-style7" Height="18px" Width="116px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblpcode" runat="server" Text="Post Code"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="Pcodebox" runat="server" CssClass="auto-style5" Height="18px" Width="116px"></asp:TextBox>
        </p>
        <p>
            Email&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Countrybox" runat="server" CssClass="auto-style3" Height="18px" Width="116px"></asp:TextBox>
        </p>
        <p>
            Phone&nbsp;
            <asp:TextBox ID="Passbox" runat="server" CssClass="auto-style4" Height="18px" Width="116px"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Valid" runat="server" BackColor="White" ForeColor="#FF5050" Text="Valid" />
            <asp:Button ID="Regbutton" runat="server" ForeColor="#3399FF" Text="Register" Width="122px" CssClass="auto-style8" OnClick="Regbutton_Click" />
             &nbsp;<input type="button" value="Staff List" onclick="location.href='Stafflist.aspx';" style="height: 26px" />
        </p>
    </form>
</body>
</html>
