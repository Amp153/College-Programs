// Chris Kirk
// dotNET II
// Chapter 23 Exercise 6
// 10/1/2017
using System;

public partial class Success : System.Web.UI.Page
{
    // display Success page
    protected void Page_Load(object sender, EventArgs e)
    {
        // display all registration information collected from the user
        firstNameLabel.Text = Session["fName"].ToString();
        lastNameLabel.Text = Session["lName"].ToString();
        emailLabel.Text = Session["email"].ToString();
        bookLabel.Text = Session["book"].ToString();
        phoneLabel.Text = Session["phone"].ToString();
        osLabel.Text = Session["os"].ToString();
    }
}