<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexUI.aspx.cs" Inherits="BookStorageWebApp.UI.IndexUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset style="width: 359px; height: 119px">
        <legend>Index</legend>
        <table align="center">
           <br/> <tr>
                <td>
                    <asp:HyperLink ID="addBookHyperLink" runat="server" NavigateUrl="AddBookUI.aspx">Add Book</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="showBooksHyperLink" runat="server" NavigateUrl="ShowBooksUI.aspx">Show Book</asp:HyperLink>
                </td>
            </tr>
        </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
