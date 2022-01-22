<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Guestbook.aspx.cs" Inherits="Guestbook" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guestbook</title>
    <style type="text/css">
       .auto-style1 {
          width: 100%;
       }
       .textBoxWidth {
          width: 300px;
       }
       .textBoxHeight {
          height: 100px;
       }
       .gridViewWidth {
          width: 650px;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div>
          <h3> <!--Do not modify the Script Manager -->
              <asp:ScriptManager ID="ScriptManager1" runat="server">
              </asp:ScriptManager>
              Please leave a message in our guestbook:</h3>
          <table class="auto-style1">
             <tr>
                <td>Name:</td>
                <td>
                   <asp:TextBox ID="nameTextBox" runat="server" CssClass="textBoxWidth"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nameTextBox" Display="None" ErrorMessage="Please enter a name" ForeColor="Red"></asp:RequiredFieldValidator>
                    <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidatorName_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidatorName_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator1">
                    </ajaxToolkit:ValidatorCalloutExtender>
                   <br />
                </td>
             </tr>
             <tr>
                <td>E-mail:</td>
                <td>
                   <asp:TextBox ID="emailTextBox" runat="server" CssClass="textBoxWidth"></asp:TextBox>
                   &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailTextBox" Display="None" ErrorMessage="Please enter an email address" ForeColor="Red"></asp:RequiredFieldValidator>
                    <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidatorEmail_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidatorEmail_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator2">
                    </ajaxToolkit:ValidatorCalloutExtender>
                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailTextBox" Display="None" ErrorMessage="Please enter a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <ajaxToolkit:ValidatorCalloutExtender ID="RegularExpressionValidatorValidEmail_ValidatorCalloutExtender" runat="server" BehaviorID="RegularExpressionValidatorValidEmail_ValidatorCalloutExtender" TargetControlID="RegularExpressionValidator1">
                    </ajaxToolkit:ValidatorCalloutExtender>
                </td>
             </tr>
             <tr>
                <td>Tell the world:</td>
                <td>
                   <asp:TextBox ID="messageTextBox" runat="server" CssClass="textBoxWidth textBoxHeight" TextMode="MultiLine"></asp:TextBox>
                   &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="messageTextBox" Display="None" ErrorMessage="Please enter a message" ForeColor="Red"></asp:RequiredFieldValidator>
                    <ajaxToolkit:ValidatorCalloutExtender ID="RequiredFieldValidatorMessege_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidatorMessege_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator3">
                    </ajaxToolkit:ValidatorCalloutExtender>
                </td>
             </tr>
             <tr>
                <td>&nbsp;</td>
                <td> <!-- Place anything in here to be updated when submit is pressed -->
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
                            <asp:Button ID="clearButton" runat="server" OnClick="clearButton_Click" Text="Clear" />
                            <asp:GridView ID="messagesGridView" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="gridViewWidth" DataKeyNames="MessageID" DataSourceID="messagesEntityDataSource" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                    <asp:BoundField DataField="Message1" HeaderText="Message" SortExpression="Message1" />
                                </Columns>
                                <EditRowStyle BackColor="#999999" />
                                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel></td>
             </tr>
          </table>
          <br />
          <asp:EntityDataSource ID="messagesEntityDataSource" runat="server" ConnectionString="name=GuestbookEntities" DefaultContainerName="GuestbookEntities" EnableFlattening="False" EnableInsert="True" EntitySetName="Messages">
          </asp:EntityDataSource>
       </div>

    </form>
</body>
</html>
