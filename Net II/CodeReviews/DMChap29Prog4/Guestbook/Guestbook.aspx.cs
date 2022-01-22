//Devron M. McFall
//Chaper 29, Program 4
//10/09/2017
using System;

public partial class Guestbook : System.Web.UI.Page
{
   // Page_Load event handler executes when the page is loaded
   protected void Page_Load( object sender, EventArgs e )
   {
      // disable unobtrusive validation
      UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
   }

   // On click submit button adds new entry to database
   protected void submitButton_Click( object sender, EventArgs e )
   {
      // use GuestbookEntities DbContext to add a new message 
      using ( GuestbookEntities dbcontext = new GuestbookEntities() )
      {
         // create a new Message to add to the database; Message is
         // the entity data model class representing a table row
         Message message = new Message(); 

         // set new Message's properties
         message.Date = DateTime.Now.ToShortDateString();
         message.Name = nameTextBox.Text;
         message.Email = emailTextBox.Text;
         message.Message1 = messageTextBox.Text;

         // add new Message to GuestbookEntities DbContext
         dbcontext.Messages.Add( message ); 
         dbcontext.SaveChanges();
      }

      // clear TextBoxes
      nameTextBox.Text = String.Empty;
      emailTextBox.Text = String.Empty;
      messageTextBox.Text = String.Empty;

      // updates GridView with new contents
      messagesGridView.DataBind();
   }

    //clears text properties of form textboxes, does not cause validation to occur
   protected void clearButton_Click(object sender, EventArgs e)
   {
       nameTextBox.Text = String.Empty;
       emailTextBox.Text = String.Empty;
       messageTextBox.Text = String.Empty;
   }
}