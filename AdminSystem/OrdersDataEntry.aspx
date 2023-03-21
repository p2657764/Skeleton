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
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 1; left: 11px; top: 15px; position: absolute; bottom: 643px;" Text="OrderID"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 24px; top: 260px; position: absolute; height: 19px;" width="53px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 84px; top: 223px; position: absolute; right: 1341px" Text="Cancel" />
        <asp:Label ID="lblOrderPlacedDate" runat="server" style="z-index: 1; left: 9px; top: 38px; position: absolute" Text="OrderPlacedDate" width="53px"></asp:Label>
        <asp:TextBox ID="txtOrderPlacedDate" runat="server" style="z-index: 1; left: 170px; top: 42px; position: absolute; margin-top: 0px; width: 153px;"></asp:TextBox>
        <asp:Label ID="lblOrderVerification" runat="server" style="z-index: 1; left: 9px; top: 68px; position: absolute" Text="OrderVerification" width="53px"></asp:Label>
        <asp:CheckBox ID="chkOrderVerification" runat="server" style="z-index: 1; left: 123px; top: 67px; position: absolute; width: 22px; height: 18px; margin-top: 0px;" />
        <asp:TextBox ID="txtOrderNo" runat="server" style="z-index: 1; top: 16px; position: absolute; width: 150px; left: 170px; right: 1157px;" OnTextChanged="txtOrderNo_TextChanged"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 15px; top: 221px; position: absolute" Text="OK" OnClick="btnOK_Click_Click" />
        <br />
        <asp:Button ID="FindButton" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 386px; top: 14px; position: absolute" Text="Find" />
        <br />
        <asp:Label ID="lblProductQuantity" runat="server" style="z-index: 1; left: 13px; top: 107px; position: absolute; width: 72px; margin-top: 11px; margin-bottom: 0px" Text="ProductQuantity"></asp:Label>
        <asp:Label ID="lblUnitPrice" runat="server" style="z-index: 1; left: 12px; top: 154px; position: absolute" Text="UnitPrice"></asp:Label>
        <asp:Label ID="lblShippingDate" runat="server" style="z-index: 1; left: 10px; top: 186px; position: absolute; margin-top: 0px" Text="Estimated Shipping Date"></asp:Label>
        <asp:TextBox ID="txtProductQuantity" runat="server" style="z-index: 1; left: 178px; top: 119px; position: absolute; width: 148px"></asp:TextBox>
        <asp:TextBox ID="txtUnitPrice" runat="server" style="z-index: 1; left: 181px; top: 154px; position: absolute; width: 144px"></asp:TextBox>
        <asp:TextBox ID="txtShippingDate" runat="server" style="z-index: 1; left: 178px; top: 186px; position: absolute; width: 152px"></asp:TextBox>
    </form>
</body>
</html>
