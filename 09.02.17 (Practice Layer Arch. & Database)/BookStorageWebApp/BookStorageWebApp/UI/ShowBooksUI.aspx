<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowBooksUI.aspx.cs" Inherits="BookStorageWebApp.UI.ShowBooksUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset style="width: 442px">
            <legend>Show Book</legend>
            <table align="right">
                 <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name   "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="searchBookNameTextBox" runat="server"></asp:TextBox>
                </td>
                     <td>
                         <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                     </td>
                </tr>
              
            </table>
            <br/><br/><br/><br/>
            <table align="center">
                 <tr>
                    <td>
                         <asp:GridView ID="booksGridView" runat="server" AutoGenerateColumns="False" Width="286px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Height="210px">
                             
                             
                             <Columns>
                    <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ISBN">
                        <ItemTemplate>
                            <%--<asp:TextBox runat="server" Text='<%#Eval("StudentName") %>'></asp:TextBox>--%>
                            <asp:Label runat="server" Text='<%#Eval("ISBN") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Author">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Author") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                   <%-- <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:HyperLink NavigateUrl='<%#Eval("StudentId", "UpdateStudentUI.aspx?id={0}") %>' runat="server" Text="Update"></asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%#Eval("StudentId", "DeleteConfirmationUI.aspx?id={0}") %>' runat="server" Text="Delete"></asp:HyperLink>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                    
                </Columns>
                             
                             
                             <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                             <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                             <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                             <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                             <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#FFF1D4" />
                             <SortedAscendingHeaderStyle BackColor="#B95C30" />
                             <SortedDescendingCellStyle BackColor="#F1E5CE" />
                             <SortedDescendingHeaderStyle BackColor="#93451F" />
                         </asp:GridView>
                    </td>
                </tr>
            </table>
           
        </fieldset>
    
    </div>
    </form>
</body>
</html>
