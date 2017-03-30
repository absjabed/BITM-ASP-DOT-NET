<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchMobile_IMEI_UI.aspx.cs" Inherits="MobileStoreWebApp.UI.SearchMobilePriceUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
<fieldset style="width: 585px">
    <legend>
        Search by IMEI
    </legend>
    <table align="center">
        <tr>
            <td>
                IMEI
            </td>
            <td></td>
            <td>
                <asp:TextBox ID="imeiTextBox" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <td>
                <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
            </td>
        </tr>
    </table>
    <table align="center">
        <tr>
            <td>Model Name: </td>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Label ID="modelNameLabel" runat="server" ForeColor="#006600"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>IMEI: </td>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Label ID="imeiLabel" runat="server" ForeColor="#006600"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Price: </td>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Label ID="priceLabel" runat="server" ForeColor="#006600"></asp:Label>
            </td>
        </tr>
    </table>
     <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="messageLabel" runat="server" Text="####"></asp:Label>
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
