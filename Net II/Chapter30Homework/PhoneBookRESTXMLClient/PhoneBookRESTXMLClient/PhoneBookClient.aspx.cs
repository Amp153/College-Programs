using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PhoneBookRESTXMLClient
{
   public partial class PhoneBookClient : System.Web.UI.Page
   {
      private const string OPERATION = "operation";
      private const string ADD_ENTRY = "AddEntry";
      private const string GET_ENTRIES = "GetEntry";

      // create an object to invoke to PhoneBookService
      private HttpClient client = new HttpClient();

      // namespace of XML response
      private XNamespace xmlNamespace = XNamespace.Get(
         "http://schemas.microsoft.com/2003/10/Serialization/Arrays");

      // handle page load events
      protected async void Page_Load(object sender, EventArgs e)
      {
         if (IsPostBack)
         {
            // send request to PhoneBookRESTXMLService if fields are filled
            if ((!string.IsNullOrEmpty(firstTextBox.Text)) &&
               (!string.IsNullOrEmpty(lastTextBox.Text)) &&
               (!string.IsNullOrEmpty(phoneTextBox.Text)))
            {
               HttpResponseMessage response =
                  await client.GetAsync(new Uri(
                     "http://localhost:52163/PhoneBookRESTXMLService.svc/AddEntry/" +
                     lastTextBox.Text.Trim() + "/" + firstTextBox.Text.Trim() + "/" + 
                     phoneTextBox.Text.Trim()));

               clearFields();

               if (response.StatusCode == System.Net.HttpStatusCode.OK)
                  resultsTextBox.Text = "Entry added successfully";
               else
                  resultsTextBox.Text = "AddEntry failed with HTTP code " + response.StatusCode;
            } // end if
            else if (findLastTextBox.Text != string.Empty) // send request to PhoneBookRESTXMLService if field is filled
            {
               String result = await client.GetStringAsync(new Uri(
                  "http://localhost:52163/PhoneBookRESTXMLService.svc/GetEntries/" + findLastTextBox.Text));

               XDocument xmlResponse = XDocument.Parse(result); // parse the returned XML string 
               clearFields();

               // if there are no phone book entries in response
               if (xmlResponse.Element(xmlNamespace + "ArrayOfstring").Value == string.Empty)
               {
                  resultsTextBox.Text = "No entries with that last name.";
               }
               else
               {
                  // print information for each phone book entry
                  foreach (XElement element in xmlResponse.Element(xmlNamespace + "ArrayOfstring").Elements())
                  {
                     resultsTextBox.Text += '\n' + element.Value;
                  } // end foreach
               } // end else
            } // end if
         }
      }

      private void clearFields()
      {
         resultsTextBox.Text = string.Empty;
         firstTextBox.Text = string.Empty;
         lastTextBox.Text = string.Empty;
         phoneTextBox.Text = string.Empty;
         findLastTextBox.Text = string.Empty;
      }
   }
}

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/