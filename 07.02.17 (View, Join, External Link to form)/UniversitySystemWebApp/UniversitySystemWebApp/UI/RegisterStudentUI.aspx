<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterStudentUI.aspx.cs" Inherits="UniversitySystemWebApp.UI.RegisterStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Student Registration</legend>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Registration Number:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="registrationNumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Contact Number:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="contactNumberTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Email ID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Department:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="departmentDropDownList" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="registerButton" runat="server" Text="Register" OnClick="registerButton_Click" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="messageLabel" runat="server" Text="EYES Here"></asp:Label>
                </td>
            </tr>
        </table>
    </fieldset>
    </div>
        <br/>
        <br/>
        <br/>
        <div>
            <asp:GridView ID="studentsGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <Columns>
                    <asp:TemplateField HeaderText="Registration Number">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("RegNo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <%--<asp:TextBox runat="server" Text='<%#Eval("StudentName") %>'></asp:TextBox>--%>
                            <asp:Label runat="server" Text='<%#Eval("StudentName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email Address">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Contact Number">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Contact") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Department">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("DeptCode") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:HyperLink NavigateUrl='<%#Eval("StudentId", "UpdateStudentUI.aspx?id={0}") %>' runat="server" Text="Update"></asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#Eval("StudentId", "DeleteConfirmationUI.aspx?id={0}") %>' runat="server" Text="Delete"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
