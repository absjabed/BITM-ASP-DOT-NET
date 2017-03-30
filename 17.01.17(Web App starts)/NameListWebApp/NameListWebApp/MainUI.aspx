<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="NameListWebApp.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Name List Web App</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <br />
        <br />
        <asp:Button ID="showAllButton" runat="server" Text="Show All" OnClick="showAllButton_Click" />
        <br />
        <br />
        <asp:ListBox ID="nameListBox" runat="server" Height="132px" Width="140px"></asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Total:"></asp:Label>
&nbsp;
        <asp:Label ID="totalNumberLabel" runat="server" Text="###"></asp:Label>
    
    </div>
    </form>
</body>
</html>
