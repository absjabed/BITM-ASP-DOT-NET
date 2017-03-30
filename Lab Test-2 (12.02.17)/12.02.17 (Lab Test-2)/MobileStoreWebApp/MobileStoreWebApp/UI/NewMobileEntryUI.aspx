<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewMobileEntryUI.aspx.cs" Inherits="MobileStoreWebApp.UI.NewMobileEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Mobile Phone Entry</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset style="width: 593px; height: 176px">
        <legend>New Mobile Phone Entry</legend>
        <table align="center">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Model Name "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="modelNameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="IMEI "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="IMEInumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Price "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="priceTextBox"  runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br/>
        <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="messageLabel" runat="server" Text="####"></asp:Label>
                    </td>
                </tr>
            </table>
        <br/>
        <table align="center">
            <tr>
                <td>
                    <asp:Button ID="saveButton" runat="server" Text="Save" Width="92px" OnClick="saveButton_Click" />
                </td>
            </tr>
        </table>
        <table align="center">
                <tr>
                    <td>
                        <asp:HyperLink ID="homePageHyperLink" NavigateUrl="IndexUI.aspx" runat="server">HOME</asp:HyperLink>
                    </td>
                </tr>
            </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
