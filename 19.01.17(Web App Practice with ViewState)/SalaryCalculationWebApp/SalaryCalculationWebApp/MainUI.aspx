<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="SalaryCalculationWebApp.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main UI</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Basic Salary:"></asp:Label>
        <asp:TextBox ID="basicSalaryTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Medical Allowance"></asp:Label>
&nbsp;<asp:TextBox ID="medicalAllowanceTextBox" runat="server" Width="61px"></asp:TextBox>
&nbsp;<asp:Label ID="Label6" runat="server" Text="% of Basic Salary."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Conveyance Allowance"></asp:Label>
&nbsp;<asp:TextBox ID="conveyanceAllowanceTextBox" runat="server" Width="61px"></asp:TextBox>
&nbsp;<asp:Label ID="Label8" runat="server" Text="% of Basic Salary."></asp:Label>
        <br />
        <br />
        <asp:Button ID="calculateSalaryButton" runat="server" Text="Calculate" OnClick="calculateSalaryButton_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="showTotalButton" runat="server" Text="Show Total" OnClick="showTotalButton_Click" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Total :"></asp:Label>
&nbsp;<asp:Label ID="totalLabel" runat="server" Text="###"></asp:Label>
    
    </div>
    </form>
</body>
</html>
