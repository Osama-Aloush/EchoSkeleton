<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 576px">
    <p>
        &nbsp;</p>
&nbsp;<form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderID" runat="server" style="z-index: 1; left: 40px; top: 109px; position: absolute; height: 23px; width: 106px; right: 1050px" Text="Order ID:"></asp:Label>
        <asp:TextBox ID="OrderIDTextBox" runat="server" style="z-index: 1; left: 118px; top: 111px; position: absolute; width: 152px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 38px; top: 151px; position: absolute; " Text="Order Description:" width="106px"></asp:Label>
        <asp:TextBox ID="OrderDescTextBox" runat="server" style="z-index: 1; left: 170px; top: 152px; position: absolute; width: 186px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="AddressTextBox" runat="server" style="z-index: 1; left: 107px; top: 197px; position: absolute; width: 193px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 38px; top: 197px; position: absolute" Text="Address:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 36px; top: 244px; position: absolute" Text="Number of Items:"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 37px; top: 289px; position: absolute" Text="Delivery Status:"></asp:Label>
        <asp:TextBox ID="ItemNoTextBox" runat="server" style="z-index: 1; left: 152px; top: 242px; position: absolute; width: 157px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 38px; top: 333px; position: absolute; width: 78px" Text="Order Date:"></asp:Label>
        <asp:TextBox ID="OrderDateTextBox" runat="server" style="z-index: 1; left: 124px; top: 333px; position: absolute; width: 151px"></asp:TextBox>
        <asp:CheckBox ID="StatusCheckBox" runat="server" style="z-index: 1; left: 147px; top: 288px; position: absolute" Text="Active" />
        <asp:Label ID="ErrorLabel" runat="server" style="z-index: 1; left: 26px; top: 560px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 36px; top: 390px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 80px; top: 390px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
