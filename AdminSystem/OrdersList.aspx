<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 710px; width: 1124px">
    <form id="form1" runat="server">
        <div style="height: 1080px; width: 1920px; background-color: #FFFFFF;">
            <asp:ListBox ID="lstOrderList" runat="server" Height="216px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" Width="362px" style="font-size: large"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" style="font-size: medium" />
            &nbsp;
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" style="font-size: medium" />
            &nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" style="font-size: medium" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblEnterAOrderPlacedDate" runat="server" Text="Enter a Order Placed Date" style="font-size: large"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEnterAnOrderPlacedDate" runat="server" OnTextChanged="txtEnterAName_TextChanged" style="font-size: medium; margin-bottom: 0px; margin-top: 1px;" Height="16px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" style="font-size: medium" />
&nbsp;
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" style="font-size: medium" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" style="font-size: large"></asp:Label>
        </div>
    </form>
</body>
</html>
