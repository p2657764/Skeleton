<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 1080px; width: 1920px; background-color: #CBE1EF;">
    <form id="form1" runat="server">
        <div style="background-position: inherit; height: 472px; width: 290px;">
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" Width="150px" Height="16px" style="font-size: large"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" ClientIDMode="AutoID" Width="200px" style="font-size: medium"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" style="font-size: medium" />
            <br />
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="150px" style="font-size: large"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" Width="200px" style="font-size: medium"></asp:TextBox>
            <br />
            <asp:Label ID="lblAddressLine1" runat="server" Text="Address Line 1" width="150px" style="font-size: large"></asp:Label>
            <asp:TextBox ID="txtAddressLine1" runat="server" Width="200px" style="font-size: medium"></asp:TextBox>
            <br />
            <asp:Label ID="lblPostCode" runat="server" Text="Post Code" width="150px" style="font-size: large"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server" Width="200px" style="font-size: medium"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" width="150px" style="font-size: large; text-align: left"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server" Width="200px" style="font-size: medium"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkEmailVerification" runat="server" Text="Email Verification" OnCheckedChanged="chkEmailVerification_CheckedChanged" width="275px" style="font-size: large" />
            <br />
            <asp:Label ID="lblAccountCreationDate" runat="server" Text="Account Creation Date" width="191px" style="font-size: large"></asp:Label>
            <asp:TextBox ID="txtAccountCreationDate" runat="server" Width="200px" TextMode="DateTime" style="font-size: medium"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" style="font-size: medium" />
            &nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" style="font-size: medium" />
            <br />
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" style="font-size: large"></asp:Label>
            </div>
    </form>
</body>
</html>
