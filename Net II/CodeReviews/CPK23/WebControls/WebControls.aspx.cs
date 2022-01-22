// Chris Kirk
// dotNET II
// Chapter 23 Exercise 6
// 10/1/2017
using System;

public partial class WebControls : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        // disable unobtrusive validation
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;


        // if this is not the first time the page is loading
        if (IsPostBack)
        {
            Validate(); // validate the form
            
            //if the form is valid
            if (IsValid)
            {
                // retreieve values submitted by the user
                // store them as session variables to be accessible in Success.aspx
                Session["fName"] = firstNameTextBox.Text;
                Session["lName"] = lastNameTextBox.Text;
                Session["email"] = emailTextBox.Text;
                Session["phone"] = phoneTextBox.Text;
                Session["book"] = booksDropDownList.Text;
                Session["os"] = osRadioButtonList.Text;
                //re-direct to new page when registration is valid
                Response.Redirect("Success.aspx");
                // display session ID

            }

        }
    }
}