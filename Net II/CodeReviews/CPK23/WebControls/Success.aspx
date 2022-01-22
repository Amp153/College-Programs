<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #33CC33;
        }
        .auto-style2 {
            width: 37%;
        }
        .auto-style3 {
            width: 121px;
        }
        .auto-style4 {
            width: 121px;
            height: 23px;
        }
        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 class="auto-style1">Registration Successful!</h2>
        </div>
        <table align="center" class="auto-style2">
            <tr>
                <td class="auto-style3">First Name:</td>
                <td>
                    <asp:Label ID="firstNameLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Last Name:</td>
                <td>
                    <asp:Label ID="lastNameLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email Address:</td>
                <td>
                    <asp:Label ID="emailLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Phone Number:</td>
                <td>
                    <asp:Label ID="phoneLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Book Selection:</td>
                <td class="auto-style5">
                    <asp:Label ID="bookLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Operating System:</td>
                <td>
                    <asp:Label ID="osLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
