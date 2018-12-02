<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculation.aspx.cs" Inherits="Calculate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>This&nbsp; is calculation app<br />
            <br />
            First number:
            <asp:TextBox ID="txtn1" runat="server" Width="90px"></asp:TextBox>
            <br />
            Second number:
            <asp:TextBox ID="txtn2" runat="server" Width="90px"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="sum" />
            <br />
            <asp:Label ID="laresult" runat="server" Text="Label"></asp:Label>
            </strong>
        </div>
    </form>
</body>
</html>
