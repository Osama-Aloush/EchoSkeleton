<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        body {font-family:Arial}
    </style>
    <title>Order Data Entry</title>
</head>
<body style="height: 576px;">
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
&nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 297px; top: 107px; position: absolute; width: 61px;" Text="Find" />
        <p>
            &nbsp;</p>
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 40px; top: 109px; position: absolute; height: 23px; width: 64px; right: 1040px" Text="Order ID:"></asp:Label>
        <asp:TextBox ID="OrderIDTextBox" runat="server" style="z-index: 1; left: 118px; top: 111px; position: absolute; width: 152px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 39px; top: 157px; position: absolute; width: 133px; right: 972px;" Text="Order Description:"></asp:Label>
        <asp:TextBox ID="OrderDescTextBox" runat="server" style="z-index: 1; left: 180px; top: 157px; position: absolute; width: 186px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="AddressTextBox" runat="server" style="z-index: 1; left: 108px; top: 238px; position: absolute; width: 193px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 41px; top: 238px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 38px; top: 193px; position: absolute" Text="Number of Items:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 38px; top: 371px; position: absolute; height: 19px;" Text="Delivery Status:"></asp:Label>
        <asp:TextBox ID="ItemNoTextBox" runat="server" style="z-index: 1; left: 163px; top: 194px; position: absolute; width: 157px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 39px; top: 273px; position: absolute; width: 99px; right: 1006px;" Text="Order Date:"></asp:Label>
        <asp:TextBox ID="OrderDateTextBox" runat="server" style="z-index: 1; left: 130px; top: 271px; position: absolute; width: 151px"></asp:TextBox>
        <asp:CheckBox ID="StatusCheckBox" runat="server" style="z-index: 1; left: 160px; top: 371px; position: absolute; height: 21px;" Text="Active" />
        <asp:Label ID="ErrorLabel" runat="server" style="z-index: 1; left: 26px; top: 560px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 36px; top: 423px; position: absolute; width: 38px;" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 82px; top: 423px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
