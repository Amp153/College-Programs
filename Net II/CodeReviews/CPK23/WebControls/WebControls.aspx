<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebControls.aspx.cs" Inherits="WebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Controls Demonstration</title>
    <style type="text/css">



        .style1
        {
            width: 100%;
        }
        .auto-style1 {
            width: 211px;
        }
        .auto-style2 {
            width: 53%;
        }
        .auto-style3 {
            width: 341px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Registration Form</h3>
            <p>
                Please fill in all fields and click the Register button.</p>
            <p>
                <asp:Image ID="userInformationImage" runat="server" ImageUrl="~/images/user.png" />
            </p>
            <table class="auto-style2">
                <tr>
                    <td class="auto-style1">
                        <asp:Image ID="firstNameImage" runat="server" ImageUrl="~/images/fname.png" />
                        <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="firstNameRequiredFieldValidator" runat="server" ControlToValidate="firstNameTextBox" Display="Dynamic" ErrorMessage="Please enter your first name." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style3">
                        <asp:Image ID="lastNameImage" runat="server" ImageUrl="~/images/lname.png" />
                        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="lastNameRequiredFieldValidator" runat="server" ControlToValidate="lastNameTextBox" Display="Dynamic" ErrorMessage="Please enter your last name." ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Image ID="emailImage" runat="server" ImageUrl="~/images/email.png" />
                        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Please enter your email address." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ControlToValidate="emailTextBox" Display="Dynamic" ErrorMessage="Please enter a valid email address." ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                    <td class="auto-style3">
                        <asp:Image ID="phoneImage" runat="server" ImageUrl="~/images/phone.png" />
                        <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="phoneRequiredFieldValidator" runat="server" ControlToValidate="phoneTextBox" Display="Dynamic" ErrorMessage="Please enter your phone number." ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="phoneRegularExpressionValidator" runat="server" ControlToValidate="phoneTextBox" Display="Dynamic" ErrorMessage="Please enter a valid phone number." ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
            <p>
                <asp:Image ID="publicationsImage" runat="server" ImageUrl="~/images/publications.png" />
            </p>
            <p>
                Which book would you like information about?<br />
                <asp:DropDownList ID="booksDropDownList" runat="server">
                    <asp:ListItem Value="-1">Select...</asp:ListItem>
                    <asp:ListItem>Visual Basic 2012 How to Program</asp:ListItem>
                    <asp:ListItem>Visual C# 2012 How to Program</asp:ListItem>
                    <asp:ListItem>Java How to Program</asp:ListItem>
                    <asp:ListItem>C++ How to Program</asp:ListItem>
                </asp:DropDownList>
            &nbsp;<asp:CompareValidator ID="bookCompareValidator" runat="server" ControlToValidate="booksDropDownList" Display="Dynamic" ErrorMessage="Please select a book from the list." ForeColor="Red" Operator="NotEqual" ValueToCompare="-1"></asp:CompareValidator>
            </p>
            <p>
                <asp:HyperLink ID="booksHyperLink" runat="server" NavigateUrl="http://www.deitel.com" Target="_blank">Click here to view more information about our books</asp:HyperLink>
            </p>
            <p>
                <asp:Image ID="osImage" runat="server" ImageUrl="~/images/os.png" />
            </p>
            <p>
                <asp:RadioButtonList ID="osRadioButtonList" runat="server">
                    <asp:ListItem Value="Windows 8">Windows 8</asp:ListItem>
                    <asp:ListItem Value="Windows 7">Windows 7</asp:ListItem>
                    <asp:ListItem Value="Mac OS X"></asp:ListItem>
                    <asp:ListItem Value="Linux"></asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="osRequiredFieldValidator" runat="server" ControlToValidate="osRadioButtonList" Display="Dynamic" ErrorMessage="Please select an Operating System." ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;</p>
            <p>
                <asp:Button ID="registerButton" runat="server" Text="Register" />
            </p>
        </div>
    </form>
</body>
</html>
