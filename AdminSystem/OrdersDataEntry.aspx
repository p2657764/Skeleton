<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 29px; top: 47px; position: absolute" Text="OrderID"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 43px; top: 375px; position: absolute" Text="Active" width="53px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 52px; top: 348px; position: absolute; height: 19px;" width="53px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 42px; top: 413px; position: absolute; right: 625px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 94px; top: 413px; position: absolute; right: 546px" Text="Cancel" />
        <asp:Label ID="lblOrderPlacedDate" runat="server" style="z-index: 1; left: 27px; top: 72px; position: absolute" Text="OrderPlacedDate" width="53px"></asp:Label>
        <asp:TextBox ID="txtOrderPlacedDate" runat="server" style="z-index: 1; left: 145px; top: 72px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblOrderVerification" runat="server" style="z-index: 1; left: 28px; top: 102px; position: absolute" Text="OrderVerification" width="53px"></asp:Label>
        <asp:CheckBox ID="chkOrderVerification" runat="server" style="z-index: 1; left: 142px; top: 101px; position: absolute" />
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; top: 45px; position: absolute; width: 109px; left: 92px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="FindButton" runat="server" Height="40px" OnClick="FindButton_Click" style="margin-bottom: 63px" Text="Find" Width="227px" />
    </form>
</body>
</html>
