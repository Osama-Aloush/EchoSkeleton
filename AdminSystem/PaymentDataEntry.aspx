<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Card Holder Name"></asp:Label>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 294px; top: 10px; position: absolute" Text="Find" />
            <br />
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Card Holder Name"></asp:Label>
            <asp:Label ID="Label3" runat="server" height="19px" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Card Holder Name"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Card Holder Name"></asp:Label>
            <asp:Label ID="CardNo" runat="server" height="19px" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="CardNo" width="118px"></asp:Label>
        </div>
        <asp:TextBox ID="txtHolderName" runat="server" style="z-index: 1; left: 139px; top: 12px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCardNumber" runat="server" height="22px" style="z-index: 1; left: 139px; top: 32px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="ExpDate" runat="server" height="19px" style="z-index: 1; left: 10px; top: 54px; position: absolute" Text="Expiry Date" width="118px"></asp:Label>
        <asp:TextBox ID="txtExp_Date" runat="server" height="22px" style="z-index: 1; left: 139px; top: 55px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="CVV_" runat="server" height="19px" style="z-index: 1; left: 10px; top: 75px; position: absolute; bottom: 130px" Text="CVV" width="118px"></asp:Label>
        <asp:TextBox ID="CVV" runat="server" height="22px" style="z-index: 1; left: 139px; top: 76px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <asp:Label ID="Customer_ID" runat="server" style="z-index: 1; left: 11px; top: 101px; position: absolute; margin-bottom: 0px" Text="Customer ID" width="118px"></asp:Label>
        <asp:TextBox ID="CustomerID" runat="server" height="22px" style="z-index: 1; top: 99px; position: absolute; left: 139px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="CheckBox" runat="server" style="z-index: 1; left: 6px; top: 145px; position: absolute" Text="Active" />
        <asp:Label ID="IbIError" runat="server" style="z-index: 1; left: 6px; top: 181px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 4px; top: 218px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 42px; top: 218px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
