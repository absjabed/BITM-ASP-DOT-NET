<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TakeUserInputUI.aspx.cs" Inherits="HelloWorldWebApp.TakeUserInputUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
    
    </div>
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        <br />
        <br />
        <br />
        <asp:Label ID="nameLabel" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
