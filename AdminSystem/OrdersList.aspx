<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 459px; width: 527px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click1" style="z-index: 1; left: 30px; top: 485px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 84px; top: 485px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 46px; top: 530px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 142px; top: 485px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
