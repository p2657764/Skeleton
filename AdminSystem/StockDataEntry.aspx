<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 319px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 130px; top: 42px; position: absolute; height: 21px; bottom: 296px; width: 175px"></asp:TextBox>
        </div>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 9px; top: 40px; position: absolute" Text="Product ID"></asp:Label>
        <p>
            <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 10px; top: 79px; position: absolute" Text="Name" width="107px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 130px; top: 76px; position: absolute" width="175px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtColour" runat="server" style="z-index: 1; left: 130px; top: 109px; position: absolute; right: 375px;" width="175px"></asp:TextBox>
        </p>
        <asp:Label ID="lblColour" runat="server" style="z-index: 1; left: 7px; top: 116px; position: absolute" Text="Colour" width="107px"></asp:Label>
        <asp:Label ID="lblUntPrice" runat="server" style="z-index: 1; left: 9px; top: 149px; position: absolute; right: 579px" Text="Unit Price" width="107px"></asp:Label>
        <p>
            <asp:TextBox ID="txtUnitPrice" runat="server" style="z-index: 1; left: 130px; top: 148px; position: absolute" width="175px"></asp:TextBox>
            <asp:Label ID="lblDateGenerated" runat="server" style="z-index: 1; left: 13px; top: 217px; position: absolute" Text="Date Generated" width="107px"></asp:Label>
        </p>
        <asp:Label ID="lblStockQuantity" runat="server" style="z-index: 1; left: 10px; top: 183px; position: absolute" Text="Quantity" width="107px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server"  style="z-index: 1; left: 130px; top: 183px; position: absolute; margin-bottom: 0px" width="175px"></asp:TextBox>
        <asp:TextBox ID="txtDateGenerated" runat="server"  style="z-index: 1; left: 130px; top: 217px; position: absolute" width="175px"></asp:TextBox>
        <asp:CheckBox ID="chkInStock" runat="server"  style="z-index: 1; left: 13px; top: 246px; position: absolute" Text="In Stock" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 15px; top: 318px; position: absolute; height: 30px; width: 41px" Text="OK" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 16px; top: 280px; position: absolute; height: 14px; width: 1px"></asp:Label>
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 81px; top: 316px; position: absolute; height: 32px; width: 84px" Text="Cancel" />
        </p>
    </form>
</body>
</html>
