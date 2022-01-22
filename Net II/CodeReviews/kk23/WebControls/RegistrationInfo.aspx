<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegistrationInfo.aspx.cs" Inherits="RegistrationInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .listboxStyle {
            width: 450px;
            height: 150px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>Thank you for your information</h2>
        <p>
            You entered the following information:</p>
        <p>
            <asp:ListBox ID="infoListbox" runat="server" CssClass="listboxStyle"></asp:ListBox>
        </p>
    
    </div>
    </form>
</body>
</html>
