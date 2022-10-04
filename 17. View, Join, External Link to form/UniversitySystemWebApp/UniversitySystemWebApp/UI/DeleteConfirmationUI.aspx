<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteConfirmationUI.aspx.cs" Inherits="UniversitySystemWebApp.UI.DeleteConfirmationUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label> 
            </td>
            <td>
                <asp:Label ID="nameLabel" runat="server"></asp:Label> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Reg No."></asp:Label> 
            </td>
            <td>
                <asp:Label ID="regNoLabel" runat="server"></asp:Label> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label> 
            </td>
            <td>
                <asp:Label ID="emailLabel" runat="server"></asp:Label> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Contact"></asp:Label> 
            </td>
            <td>
                <asp:Label ID="contactLabel" runat="server"></asp:Label> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Department"></asp:Label> 
            </td>
            <td>
                <asp:Label ID="departmentLabel" runat="server"></asp:Label> 
            </td>
        </tr>
    </table>
        <asp:Label ID="Label11" runat="server" Text="Do you want to delete this student information?" Font-Bold="True" Font-Italic="True"></asp:Label>
        <br/>
        <asp:Button ID="deleteButton" runat="server" Text="Delete" OnClick="deleteButton_Click" />
        <asp:Button ID="cancelButton" runat="server" Text="Cancel" OnClick="cancelButton_Click" />
    </div>
    </form>
</body>
</html>
