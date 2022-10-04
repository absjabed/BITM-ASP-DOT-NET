<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="StudentInformationWebApp.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main UI</title>
</head>
<body style="margin-left: 120px">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Student Name: "></asp:Label>
        &nbsp;<asp:TextBox ID="studentNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Registration ID: "></asp:Label>
        <asp:TextBox ID="registrationIDTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email ID:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="emailIDTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="showAllButton" runat="server" Text="Show All" OnClick="showAllButton_Click" />
        <br />
        <br />
        <asp:ListBox ID="studentInfoListBox" runat="server" Height="125px" Width="571px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
