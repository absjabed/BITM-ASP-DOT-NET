<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAllStudentUI.aspx.cs" Inherits="UniversityStudentsDataCRUDWebApp.ViewAllStudentUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset>
        <legend>View All Students</legend>
        
        <tr>
            <td></td>
            <td></td>
            <td>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Label ID="messageLabel" runat="server" Text="# # * # #" Font-Bold="True" Font-Names="Consolas" Font-Size="X-Large"></asp:Label>
            </td>
            <td></td>
            <td></td>

        </tr>
        
        
        <br/><br/><br/>
        
        <div style="margin-left: 160px">
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
                    <asp:TemplateField HeaderText="Contact Number">
                        
                        <ItemTemplate>
                            <asp:Label  runat="server" Text='<%#Eval("ContactNumber") %>'>'></asp:Label>
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
                    <asp:TemplateField HeaderText="Email">
                        
                        <ItemTemplate>
                            <asp:Label  runat="server" Text='<%#Eval("Email") %>'>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                </Columns>

            </asp:GridView>
        </div>
        
    </fieldset>

    </div>
    </form>
</body>
</html>
