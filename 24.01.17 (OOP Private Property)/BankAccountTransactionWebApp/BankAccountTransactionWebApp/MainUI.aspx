<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainUI.aspx.cs" Inherits="BankAccountTransactionWebApp.MainUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main UI</title>
</head>
<body>
    <form id="form1" runat="server">
    <fieldset style="width: 850px">
        <legend>Account Creation</legend>
        
        <asp:Label ID="Label1" runat="server" Text="Account Number:"></asp:Label>
        <asp:TextBox ID="accountNumberTextBox" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Label ID="confirmationLabel" runat="server" ForeColor="#009933"></asp:Label>
        <br />
        <br />
        
        <asp:Label ID="Label2" runat="server" Text="Customer Name:"></asp:Label>
        &nbsp;<asp:TextBox ID="customerNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="createAccountButton" runat="server" Text="Create" OnClick="createAccountButton_Click" />
    </fieldset>
        <fieldset style="width: 852px">
            <legend>Transaction</legend>

        <asp:Label ID="Label3" runat="server" Text="Amount:"></asp:Label>
        <asp:TextBox ID="amountTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="depositeButton" runat="server" Text="Deposite" OnClick="depositeButton_Click" />
    &nbsp;<asp:Button ID="withdrawButton" runat="server" Text="Withdraw" OnClick="withdrawButton_Click" />

        </fieldset>
        <fieldset style="width: 851px">
            <legend>Account Report</legend>
        <div>        <asp:Button ID="reportButton" runat="server" Text="Report" Width="248px" OnClick="reportButton_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="reportLabel" runat="server" Text="##########"></asp:Label>
    </div>
        </fieldset>
    </form>
    </body>
</html>
