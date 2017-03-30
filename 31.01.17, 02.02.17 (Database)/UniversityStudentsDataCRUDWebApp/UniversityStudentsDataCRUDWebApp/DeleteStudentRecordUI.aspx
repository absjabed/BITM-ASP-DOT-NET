<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteStudentRecordUI.aspx.cs" Inherits="UniversityStudentsDataCRUDWebApp.DeleteStudentRecordUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>Delete Information</legend>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Registration Number: "></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="registrationNumberTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="showButton" runat="server" Text="Search" OnClick="showButton_Click" Width="126px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:HiddenField ID="idHiddenField" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
                </tr>
                                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Contact No: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="contactNoTextBox" runat="server"></asp:TextBox></td>
                </tr>
                                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
                </tr>
                                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Department: "></asp:Label></td>
                    <td>
                        <asp:TextBox ID="departmentTextBox" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td></td>
                    <td>
                    <asp:Button ID="deleteButton" runat="server" Text="DELETE" Width="129px" OnClick="deleteButton_Click" /></td>
                </tr>
                
            </table>

        </div>
        <tr><td>
                    <asp:Label ID="messageLabel" runat="server" Text="message" Font-Bold="True" Font-Names="Consolas" Font-Size="Medium"></asp:Label></td></tr>
    </fieldset>
    </div>
        <br/><br/><br/>
        <div>
            <asp:GridView ID="studentsGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
                
                <Columns>
                    
                   
                    <asp:TemplateField HeaderText="Department">
                        
                        <ItemTemplate>
                            <asp:Label  runat="server" Text='<%#Eval("Department") %>'>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        
                        <ItemTemplate>
                            <asp:Label  runat="server" Text='<%#Eval("Name") %>'>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Registration Number">
                        
                        <ItemTemplate>
                            <asp:Label  runat="server" Text='<%#Eval("RegistrationNumber") %>'>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Contact Number">
                        
                        <ItemTemplate>
                            <asp:Label  runat="server" Text='<%#Eval("ContactNumber") %>'>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email">
                        
                        <ItemTemplate>
                            <asp:Label  runat="server" Text='<%#Eval("Email") %>'>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
        </div>
    </form>
</body>
</html>
