<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckList.aspx.cs" Inherits="CheckList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            </asp:CheckBoxList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find Selcted" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
