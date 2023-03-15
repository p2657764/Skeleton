<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 332px">
    <form id="form1" runat="server">
        <div style="height: 195px">
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
            <asp:TextBox ID="txtCustomerName" runat="server" Width="300px"></asp:TextBox>
            <br />
            <asp:Label ID="lblAddressLine1" runat="server" Text="Address Line 1"></asp:Label>
            <asp:TextBox ID="txtAddressLine1" runat="server" Width="400px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPostCode" runat="server" Text="Post Code"></asp:Label>
            <asp:TextBox ID="txtPostCode" runat="server" Width="120px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmailAddress" runat="server" Text="Email Address"></asp:Label>
            <asp:TextBox ID="txtEmailAddress" runat="server" Width="400px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkEmailVerification" runat="server" Text="Email Verification" />
            <br />
            <asp:Label ID="lblAccountCreationDate" runat="server" Text="Account Creation Date"></asp:Label>
            <asp:TextBox ID="txtAccountCreationDate" runat="server" Width="150px"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
