<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentUI.aspx.cs" Inherits="UniversitySystemWebApp.UpdateStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Student Information</legend>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Registration Number: "></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="registrationNumberTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" Width="126px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HiddenField ID="idHiddenField" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
                </tr>
                                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Contact No: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox></td>
                </tr>
                                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
                </tr>
                                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Department: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td></td>
                    <td>
                    <asp:Button ID="updateButton" runat="server" Text="Update" Width="129px" OnClick="updateButton_Click" /></td>
                </tr>
                <tr><td>
                    <asp:Label ID="messageLabel" runat="server" Text="message"></asp:Label></td></tr>
            </table>

        </div>

    </fieldset>
    </div>
    </form>
</body>
</html>
