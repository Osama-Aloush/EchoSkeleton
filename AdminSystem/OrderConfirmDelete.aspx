<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {font-family:Arial}
    </style>
    <title>Confirm Delete</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Are you sure you want to delete this record?</p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 13px; top: 86px; position: absolute" Text="Yes" />
        </p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 63px; top: 87px; position: absolute; width: 43px" Text="No" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
