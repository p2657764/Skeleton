<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 205px">
    <form id="form1" runat="server">
        <div style="height: 202px">
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" Width="150px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server" ClientIDMode="AutoID" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="150px"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="lblAddressLine1" runat="server" Text="Address Line 1" width="150px"></asp:Label>
            <asp:TextBox ID="txtAddressLine1" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPostCode" runat="server" Text="Post Code" width="150px"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address" width="150px"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkEmailVerification" runat="server" Text="Email Verification" OnCheckedChanged="chkEmailVerification_CheckedChanged" width="126px" />
            <br />
            <asp:Label ID="lblAccountCreationDate" runat="server" Text="Account Creation Date" width="150px"></asp:Label>
            <asp:TextBox ID="txtAccountCreationDate" runat="server" Width="200px" TextMode="DateTime"></asp:TextBox>
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </div>
    </form>
</body>
</html>
