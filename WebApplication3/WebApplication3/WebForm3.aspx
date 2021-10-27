<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Height="36px" Width="65px"></asp:ListBox>
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="260px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="80px">
            <asp:ListItem>secim1 </asp:ListItem>
            <asp:ListItem>secim2 </asp:ListItem>
            <asp:ListItem>secim3 </asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
