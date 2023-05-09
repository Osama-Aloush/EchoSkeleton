<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {font-family:Arial}
    </style>
    <title>Order List</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 19px; top: 34px; position: absolute; height: 307px; width: 354px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 26px; top: 362px; position: absolute; right: 1483px;" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 91px; top: 363px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 152px; top: 362px; position: absolute" Text="Delete" />
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 27px; top: 528px; position: absolute; margin-bottom: 16px;"></asp:Label>
        </p>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 201px; top: 413px; position: absolute; width: 159px"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 23px; top: 462px; position: absolute; right: 1474px" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 83px; top: 462px; position: absolute; width: 56px" Text="Clear" />
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 23px; top: 414px; position: absolute" Text="Enter a Street type here"></asp:Label>
        </p>
    </form>
</body>
</html>
