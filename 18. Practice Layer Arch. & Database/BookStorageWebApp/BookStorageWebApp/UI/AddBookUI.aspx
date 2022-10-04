<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBookUI.aspx.cs" Inherits="BookStorageWebApp.UI.AddBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <fieldset style="width: 324px; height: 204px">
            <legend>Add Book</legend>
            <table align="center">
                <br/>
                 <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name   "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="bookNameTextBox" runat="server"></asp:TextBox>
                </td>
                </tr>
                <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="ISBN  "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="isbnNumberTextBox" runat="server"></asp:TextBox>
                </td>
                </tr>
                <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Author    "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="authorNameTextBox" runat="server" OnTextChanged="authorNameTextBox_TextChanged"></asp:TextBox>
                </td>
                </tr>
                 <tr>
                <td>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="saveBookButton" runat="server" Text="Save" style="margin-left: 0px" Width="57px" OnClick="saveBookButton_Click" />
                </td>
                </tr>
            </table>
            <asp:Label ID="messageLable" runat="server" Text="#INFO#"></asp:Label>
        </fieldset>
    
    </div>
    </form>
</body>
</html>
