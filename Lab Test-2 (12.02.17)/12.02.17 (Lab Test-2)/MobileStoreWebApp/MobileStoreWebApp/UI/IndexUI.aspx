<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="MobileStoreWebApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mobile Phone Store</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset style="width: 493px; height: 143px">
            <legend>INDEX UI</legend>
            <table align="center">
                <tr>
                    <td>
                        <asp:HyperLink ID="saveMobileHyperLink" NavigateUrl="NewMobileEntryUI.aspx" runat="server">Save Mobile Handset Information</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <table align="center">
                <tr>
                    <td>
                        <asp:HyperLink ID="searchMobilePriceHyperLink" NavigateUrl="SearchMobile_Price_UI.aspx" runat="server">Search Mobile Handset by Price Range</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <table align="center">
                <tr>
                    <td>
                        <asp:HyperLink ID="searchMobileIMEIHyperLink" NavigateUrl="SearchMobile_IMEI_UI.aspx" runat="server">Search Mobile Handset by IMEI</asp:HyperLink>
                    </td>
                </tr>
            </table>
<%--            <table align="center">
                <tr>
                    <td>
                        <asp:HyperLink ID="homePageHyperLink" NavigateUrl="IndexUI.aspx" runat="server">HOME</asp:HyperLink>
                    </td>
                </tr>
            </table>--%>
        </fieldset>
    
    </div>
    </form>
</body>
</html>
