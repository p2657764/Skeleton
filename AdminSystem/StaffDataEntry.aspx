﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="lblStaffId" runat="server" Text="StaffId"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="margin-left: 93px; margin-top: 0px;" Width="213px"></asp:TextBox>
        </div>
        <asp:Label ID="lblRole" runat="server" style="z-index: 1; left: 15px; top: 161px; position: absolute; height: 23px;" Text="Staff Role" width="683px"></asp:Label>
        <p style="height: 19px; width: 683px">
            <asp:TextBox ID="txtStaffWage" runat="server" style="z-index: 1; left: 142px; top: 50px; position: absolute; width: 219px; height: 12px;"></asp:TextBox>
            Staff Wage</p>
        <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 10px; top: 86px; position: absolute; right: 487px" Text="Staff Department" width="683px"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" OnTextChanged="txtDepartment_TextChanged" style="z-index: 1; top: 92px; position: absolute; left: 144px; width: 222px; height: 13px"></asp:TextBox>
        <p>
            <asp:Label ID="tblName" runat="server" height="19px" style="z-index: 1; left: 10px; top: 110px; position: absolute" Text="Staff Name" width="683px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 139px; top: 115px; position: absolute; width: 219px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 136px; top: 146px; position: absolute; width: 221px; height: 11px"></asp:TextBox>
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 131px; top: 173px; position: absolute; width: 229px; height: 14px; bottom: 484px;"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkUpdateCatalogue" runat="server" style="z-index: 1; left: 14px; top: 196px; position: absolute; height: 19px; width: 135px" Text="Update Catalogue" TextAlign="Left" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 84px; top: 259px; position: absolute; height: 27px; width: 44px; right: 643px;" Text="OK" />
        <p>
            <asp:Button ID="btnCancel0" runat="server" style="z-index: 1; left: 147px; top: 260px; position: absolute; width: 112px; height: 25px" Text="Cancel" />
            <asp:Button ID="btnFind" runat="server" Height="38px" OnClick="btnFind_Click" style="margin-left: 268px; margin-top: 0px" Text="Find" Width="179px" />
        </p>
        <asp:Label ID="tblStartDate" runat="server" style="z-index: 1; left: 13px; top: 122px; position: absolute; height: 19px; margin-top: 12px; width: 352px;" Text="Start Date"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 220px; position: absolute; height: 21px; width: 103px;"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="btnOK0" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 84px; top: 259px; position: absolute; height: 27px; width: 44px" Text="OK" />
        </p>
    </form>
</body>
</html>
