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
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 13px; top: 168px; position: absolute; height: 23px;" Text="Staff Role" width="683px"></asp:Label>
        <asp:Label ID="lblStaffId" runat="server" Text="StaffId"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="margin-left: 93px" Width="215px"></asp:TextBox>
        <p style="height: 19px; width: 683px; margin-top: 6px;">
            <asp:TextBox ID="txtStaffWage" runat="server" style="z-index: 1; left: 142px; top: 63px; position: absolute; width: 219px"></asp:TextBox>
            Staff Wage</p>
        <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 10px; top: 87px; position: absolute; right: -45px" Text="Staff Department" width="683px"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" OnTextChanged="txtDepartment_TextChanged" style="z-index: 1; top: 92px; position: absolute; left: 136px; width: 223px; height: 13px"></asp:TextBox>
        <p>
            <asp:Label ID="tblName" runat="server" height="19px" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="Staff Name" width="683px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 139px; top: 115px; position: absolute; width: 221px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 136px; top: 146px; position: absolute; width: 223px; height: 11px"></asp:TextBox>
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 131px; top: 173px; position: absolute; width: 232px; height: 14px; bottom: 484px;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="25px" OnClick="btnFind_Click" style="margin-left: 268px; margin-top: 80px" Text="Find" Width="178px" />
        </p>
        <asp:CheckBox ID="chkUpdateCatalogue" runat="server" style="z-index: 1; left: 13px; top: 193px; position: absolute; height: 19px; width: 683px" Text="Update Catalogue" TextAlign="Left" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 84px; top: 259px; position: absolute; height: 27px; width: 44px; right: 643px;" Text="OK" />
        <p>
            <asp:Button ID="btnCancel0" runat="server" style="z-index: 1; left: 147px; top: 260px; position: absolute; width: 112px; height: 25px" Text="Cancel" />
        </p>
        <asp:Label ID="tblStartDate" runat="server" style="z-index: 1; left: 13px; top: 128px; position: absolute; height: 19px; margin-top: 12px" Text="Start Date" width="683px"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 228px; position: absolute; height: 21px" width="683px"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK0" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 84px; top: 259px; position: absolute; height: 27px; width: 44px" Text="OK" />
        </p>
    </form>
</body>
</html>
