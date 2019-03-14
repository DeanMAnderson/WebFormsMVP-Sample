 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="WebFormsMVC.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <h1><%#Model.PageHeading %></h1>
            <asp:Button runat="server" OnCommand=""></asp:Button>
            <asp:Repeater runat="server" ID="personRepeater" DataSource='<%#Model.PersonList%>' ItemType="WebFormsMVC.Models.Person" >
            <HeaderTemplate>
                <table>
                    <tr>
                        <th>Name</th>
                        <th>Age</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Item.Name %></td>
                    <td><%# Item.Age %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
            </asp:Repeater>


    </form>
</body>
</html>

