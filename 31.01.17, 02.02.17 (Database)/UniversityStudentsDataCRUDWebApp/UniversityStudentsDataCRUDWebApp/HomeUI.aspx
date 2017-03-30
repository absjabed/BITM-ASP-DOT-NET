<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="UniversityStudentsDataCRUDWebApp.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Home</legend>
        <tr>
        <td>
            <asp:HyperLink ID="studentRegistrationPageHyperLink" NavigateUrl="StudentRegistrationUI.aspx" runat="server" BorderColor="#FF6600" Font-Bold="True" Font-Names="Consolas" Font-Size="Medium" ToolTip="Register Students here">Register a Student</asp:HyperLink>  
        </td>
        <br/>
        <td>
            <asp:HyperLink ID="updateStudentHyperLink" NavigateUrl="UpdateStudentsInfoUI.aspx" runat="server" Font-Bold="True" Font-Names="Consolas" Font-Size="Medium">Update Student info</asp:HyperLink>  
        </td>
            <br/>
        <td>
            <asp:HyperLink ID="deleteStudentHyperLink" NavigateUrl="DeleteStudentRecordUI.aspx" runat="server" Font-Bold="True" Font-Names="Consolas" Font-Size="Medium">Delete Student Record</asp:HyperLink>  
        </td>
            <br/>
        <td>
            <asp:HyperLink ID="viewStudentsHyperLink" NavigateUrl="ViewAllStudentUI.aspx" runat="server" Font-Bold="True" Font-Names="Consolas" Font-Size="Medium">View All Students</asp:HyperLink>  
        </td>
    </tr>
    </fieldset>
    </div>
    </form>
</body>
</html>
