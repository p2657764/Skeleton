<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 10px; top: 73px; position: absolute" Text="Staff Role"></asp:Label>
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 126px; top: 39px; position: absolute; width: 94px"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtStaffWage" runat="server" style="z-index: 1; left: 126px; top: 63px; position: absolute; width: 94px"></asp:TextBox>
            Staff Wage</p>
        <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 10px; top: 86px; position: absolute; right: 487px" Text="Staff Department"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" OnTextChanged="txtDepartment_TextChanged" style="z-index: 1; top: 92px; position: absolute; left: 129px; width: 88px; height: 13px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
