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
        <asp:Label ID="lblOrderNo" runat="server" style="z-index: 2; left: 10px; top: 15px; position: absolute; bottom: 640px; width: 62px;" Text="OrderID"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 27px; top: 299px; position: absolute; height: 172px; width: 267px;"> </asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 92px; top: 249px; position: absolute; " Text="Cancel" height="26px" />
        <asp:Label ID="lblOrderPlacedDate" runat="server" style="z-index: 2; left: 10px; top: 47px; position: absolute" Text="OrderPlacedDate" width="62px" height="22px"></asp:Label>
        <asp:TextBox ID="txtOrderPlacedDate" runat="server" style="z-index: 1; left: 172px; top: 42px; position: absolute; margin-top: 0px; width: 145px;" height="22px"></asp:TextBox>
        <asp:Label ID="lblOrderVerification" runat="server" style="z-index: 2; left: 10px; top: 194px; position: absolute" Text="OrderVerification" width="62px" height="22px"></asp:Label>
        <asp:CheckBox ID="chkOrderVerification" runat="server" style="z-index: 1; left: 166px; top: 196px; position: absolute; width: 22px; height: 20px; margin-top: 0px;" Text=" " />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 337px; top: 11px; position: absolute" Text="Find" />
        <br />
        <asp:Label ID="lblProductQuantity" runat="server" style="z-index: 2; left: 10px; top: 70px; position: absolute; width: 62px; margin-top: 11px; margin-bottom: 0px" Text="ProductQuantity" height="22px"></asp:Label>
        <asp:Label ID="lblUnitPrice" runat="server" style="z-index: 2; left: 10px; top: 118px; position: absolute" Text="UnitPrice" height="22px" width="62px"></asp:Label>
        <asp:Label ID="lblShippingDate" runat="server" style="z-index: 2; left: 10px; top: 161px; position: absolute; margin-top: 0px; width: 164px;" Text="Estimated Shipping Date" height="22px"></asp:Label>
        <asp:TextBox ID="txtProductQuantity" runat="server" style="z-index: 1; left: 172px; top: 80px; position: absolute; width: 145px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtUnitPrice" runat="server" style="z-index: 1; left: 172px; top: 116px; position: absolute; width: 145px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtShippingDate" runat="server" style="z-index: 1; left: 172px; top: 152px; position: absolute; width: 145px; margin-top: 6px;" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 172px; top: 13px; position: absolute; width: 145px"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 45px; top: 249px; position: absolute; height: 27px;" Text="OK" OnClick="btnOK_Click" />
    </form>
</body>
</html>
