<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentUI.aspx.cs" Inherits="UniversitySystemWebApp.UI.UpdateStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Update Student Registration</legend>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Registration Number:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="registrationNumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:HiddenField ID="idHiddenField" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Contact Number:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="contactNumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Email ID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Department:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="messageLabel" runat="server" Text="EYES Here"></asp:Label>
                </td>
            </tr>
        </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
