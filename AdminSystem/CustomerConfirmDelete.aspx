﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblDeleteRecordConfirmation" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" Text="Yes" />
&nbsp;
            <asp:Button ID="btnNo" runat="server" OnClick="Button2_Click" Text="No" />
        </div>
    </form>
</body>
</html>
