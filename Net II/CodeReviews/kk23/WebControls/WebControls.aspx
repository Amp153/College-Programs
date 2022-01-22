<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebControls.aspx.cs" Inherits="WebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Controls Demonstration</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>Registration Form</h3>
        <p>
            Please fill in all fields and click the Register button</p>
        <p>
            <asp:Image ID="userInformationImage" runat="server" ImageUrl="~/images/user.png" />
        </p>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Image ID="firstNameImage" runat="server" ImageUrl="~/images/fname.png" />
                    <asp:TextBox ID="firstNameTextbox" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstNameTextbox" Display="Dynamic" ErrorMessage="Please enter your first name" ForeColor="#990000"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Image ID="lastNameImage" runat="server" ImageUrl="~/images/lname.png" />
                    <asp:TextBox ID="lastNameTextbox" runat="server"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastNameTextbox" Display="Dynamic" ErrorMessage="Please enter you last name" ForeColor="#990000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Image ID="emailImage" runat="server" ImageUrl="~/images/email.png" />
                    <asp:TextBox ID="emailTextbox" runat="server"></asp:TextBox>
                    &nbsp;email@domain.com<br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="emailTextbox" Display="Dynamic" ErrorMessage="Please enter in an email" ForeColor="#990000"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Please enter a valid email" ControlToValidate="emailTextbox" Display="Dynamic" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Image ID="phoneImage" runat="server" ImageUrl="~/images/phone.png" />
                    <asp:TextBox ID="phoneTextbox" runat="server"></asp:TextBox>
                    &nbsp;(555) 555-1234<br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="phoneTextbox" Display="Dynamic" ErrorMessage="Please enter in a phone number" ForeColor="#990000"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Please enter in a valid phone number" ControlToValidate="phoneTextbox" Display="Dynamic" ForeColor="#990000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
    
    </div>
        <asp:Image ID="publicationsImage" runat="server" ImageUrl="~/images/publications.png" />
        <br />
        <p>
        Which Book would you like information about?</p>
        <p>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="booksDropdownList" Display="Dynamic" ErrorMessage="Please chose a book" ForeColor="#990000" Operator="NotEqual" ValueToCompare="-1"></asp:CompareValidator>
            <br />
        <asp:DropDownList ID="booksDropdownList" runat="server">
            <asp:ListItem Value="-1">Select a book...</asp:ListItem>
            <asp:ListItem>Visual C# 2012 How to Program</asp:ListItem>
            <asp:ListItem>Java How to program</asp:ListItem>
            <asp:ListItem>C++ How to Program</asp:ListItem>
        </asp:DropDownList>
        </p>
        <p>
            <asp:HyperLink ID="bookHyperLink" runat="server" NavigateUrl="http://www.deitel.com">Click here to view more information about our books</asp:HyperLink>
        </p>
        <p>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/os.png" />
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="osRadioButtonList" Display="Dynamic" ErrorMessage="Please select an operating system" ForeColor="#990000"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:RadioButtonList ID="osRadioButtonList" runat="server">
                <asp:ListItem>Windows 8</asp:ListItem>
                <asp:ListItem>Windows 7</asp:ListItem>
                <asp:ListItem>Mac OS X</asp:ListItem>
                <asp:ListItem>Linux</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            <asp:Button ID="registerButton" runat="server" Text="Register" />
        <br />
        </p>
    </form>
</body>
</html>
