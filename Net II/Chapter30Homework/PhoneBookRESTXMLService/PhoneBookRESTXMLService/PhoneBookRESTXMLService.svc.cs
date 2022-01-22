using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PhoneBookRESTXMLService
{
   public class PhoneBookRESTXMLService : IPhoneBookRESTXMLService
   {
      // create a dbcontext object to access PhoneBook database
      private PhoneBookEntities dbcontext = new PhoneBookEntities();

      // add an entry to the phone book database
      public void AddEntry(string lastName, string firstName,
         string phoneNumber)
      {
         // create PhoneBook entry to be inserted in database
         PhoneBook contact = new PhoneBook
         {
            FirstName = firstName,
            LastName = lastName,
            PhoneNumber = phoneNumber
         }; //end new PhoneBook object

         // insert PhoneBook entry in database
         dbcontext.PhoneBooks.Add(contact);
         dbcontext.SaveChanges();
      } // end method AddEntry

      // retrieve phone book entries with a given last name
       //tried implementing a PhoneBookEntry class with little knowledge on what I'm doing
      public PhoneBookEntry[] GetEntries(string lastName)
      {
         // LINQ query to find contacts matching the given last name
         // and get result as rows of strings
         var matchingEntries =
            from contact in dbcontext.PhoneBooks
            where contact.LastName == lastName
            select contact;

          //an array of objects as opposed to strings
         List<PhoneBookEntry> list = new List<PhoneBookEntry>(matchingEntries.Count());
         foreach (var entry in matchingEntries)
            list.Add(PhoneBookEntry.Format("{0}, {1}: {2}",
               entry.LastName.Trim(), entry.FirstName.Trim(), entry.PhoneNumber.Trim()));

         return list.ToArray(); // return string array of matching entries
      } // end method GetEntries
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
