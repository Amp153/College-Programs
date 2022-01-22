using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebControls : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode =
            System.Web.UI.UnobtrusiveValidationMode.None;

        if (IsPostBack)
        {
            //Make sure info is correct
            Validate();

            if (IsValid)
            {
                //add info to sessions
                Session.Add("First Name", firstNameTextbox.Text);
                Session.Add("Last Name", lastNameTextbox.Text);
                Session.Add("Email", emailTextbox.Text);
                Session.Add("Phone", phoneTextbox.Text);
                Session.Add("Book", booksDropdownList.SelectedValue);
                Session.Add("OS", osRadioButtonList.SelectedValue);

                //go to the next page
                Server.Transfer("RegistrationInfo.aspx", true);
            }
        }
    }
}