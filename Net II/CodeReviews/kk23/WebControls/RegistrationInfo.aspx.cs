using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegistrationInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //make sure there is something is sessions
        if (Session.Count != 0)
        {
            foreach (string keyname in Session.Keys)
            {
                //Add all the items to the list box
                infoListbox.Items.Add(keyname + ": " + Session[keyname]);
            }
        }
    }
}