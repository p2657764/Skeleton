<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 1080px; width: 1920px; background-color: #CBE1EF;">
            <asp:Label ID="lblDeleteRecordConfirmation" runat="server" Text="Are you sure you want to delete this record?" style="font-size: large"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" style="font-size: medium" />
&nbsp;
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" style="font-size: medium" />
        </div>
    </form>
</body>
</html>
