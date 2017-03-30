<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="UniversitySystemWebApp.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <tr>
        <td>
            <asp:HyperLink ID="indexPageHyperLink" NavigateUrl="IndexUI.aspx" runat="server">Go to Index page...</asp:HyperLink>  
        </td>
        <br/><br/><br/>
                <td>
            <asp:HyperLink ID="updateStudentHyperLink" NavigateUrl="UpdateStudentUI.aspx" runat="server">Go to Update Student page...</asp:HyperLink>  
        </td>
    </tr>
    </div>
    </form>
</body>
</html>
