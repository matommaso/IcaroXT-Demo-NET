<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbilitazioneWebForm.aspx.cs" Inherits="WebApp.AbilitazioneWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Show the table ABILITAZIONE
            <asp:Button ID="ButtonAB" runat="server" Text="Ok" OnClick="ButtonAB_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Hello" Height="26px" Width="43px" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
