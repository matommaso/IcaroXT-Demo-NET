<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyNameWebForm.aspx.cs" Inherits="WebApp.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            My name is
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="Button1_Click"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ok" />
        &nbsp;&nbsp; - Show my name:&nbsp;
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
