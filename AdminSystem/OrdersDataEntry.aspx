<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 497px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 11px; top: 15px; position: absolute" Text="OrderID"></asp:Label>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 16px; top: 78px; position: absolute; width: 80px;" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 198px; position: absolute; height: 19px;" width="53px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 99px; top: 135px; position: absolute; right: 1159px" Text="Cancel" />
        <asp:Label ID="lblOrderPlacedDate" runat="server" style="z-index: 1; left: 13px; top: 38px; position: absolute" Text="OrderPlacedDate" width="53px"></asp:Label>
        <asp:TextBox ID="txtOrderPlacedDate" runat="server" style="z-index: 1; left: 127px; top: 39px; position: absolute; margin-top: 0px"></asp:TextBox>
        <asp:Label ID="lblOrderVerification" runat="server" style="z-index: 1; left: 14px; top: 59px; position: absolute" Text="OrderVerification" width="53px"></asp:Label>
        <asp:CheckBox ID="chkOrderVerification" runat="server" style="z-index: 1; left: 129px; top: 62px; position: absolute" />
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; top: 17px; position: absolute; width: 150px; left: 74px; right: 1086px;"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK_Click" runat="server" style="z-index: 1; left: 43px; top: 139px; position: absolute" Text="OK" />
        <br />
        <asp:Button ID="FindButton_Click" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 252px; top: 13px; position: absolute" Text="Find" />
        <br />
    </form>
</body>
</html>
