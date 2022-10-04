<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchMobile_Price_UI.aspx.cs" Inherits="MobileStoreWebApp.UI.SearchMobileIMEI_UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Mobile Phone by Price Range</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <fieldset style="height: 501px; width: 771px;">
        <legend>
            Search by Price Range
        </legend>
        <table align="center">
            <tr>
                <td>
                    Price between
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="startingPriceTextBox" runat="server" Width="91px"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    and
                </td>
                <td></td>
                <td>
                    <asp:TextBox ID="endingPriceTextBox" runat="server" Width="91px"></asp:TextBox>
                </td>
                <td></td>
                <td>
                    <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" />
                </td>
            </tr>
        </table>
        <br/><br/>
         <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="messageLabel" runat="server" Text="####"></asp:Label>
                    </td>
                </tr>
            </table>
        <br/>
        <table align="center">
            <tr>
                <td>
                    <asp:GridView ID="mobileGridView" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                                <Columns>
                    <asp:TemplateField HeaderText="SL#">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Container.DataItemIndex+1 %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Model Name">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("ModelName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="IMEI">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("IMEI") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label runat="server" Text='<%#Eval("Price") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                </Columns>
                                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                                <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
        <table align="center">
                <tr>
                    <td>
                        <asp:HyperLink ID="homePageHyperLink" NavigateUrl="IndexUI.aspx" runat="server">HOME</asp:HyperLink>
                    </td>
                </tr>
            </table>
    </fieldset>
    </div>
    </form>
</body>
</html>
