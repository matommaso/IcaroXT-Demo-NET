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
        <asp:BulletedList ID="BulletedListAB" runat="server" OnClick="BulletedList1_Click">
        </asp:BulletedList>
    </form>
</body>
</html>
