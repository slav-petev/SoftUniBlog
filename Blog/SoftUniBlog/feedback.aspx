<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="feedback.aspx.cs" Inherits="SoftUniBlog.feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 188px;
        }
        .auto-style2 {
            width: 215px;
        }
        .auto-style3 {
            width: 188px;
            height: 26px;
        }
        .auto-style4 {
            width: 215px;
            height: 26px;
        }
        .auto-style5 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Name</td>
                <td class="auto-style2">
                    <asp:TextBox ID="nametxt" runat="server" Width="182px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Required" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td class="auto-style4">
                    <asp:TextBox ID="emailtxt" runat="server" Width="182px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ForeColor="Red">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Website</td>
                <td class="auto-style2">
                    <asp:TextBox ID="webtxt" runat="server" Width="182px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Content</td>
                <td class="auto-style2">
                    <asp:TextBox ID="contentxt" runat="server" Height="61px" TextMode="MultiLine" Width="183px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" Text="Comment" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <asp:Repeater ID="Repeater1" runat="server">
        </asp:Repeater>
    </form>
</body>
</html>
