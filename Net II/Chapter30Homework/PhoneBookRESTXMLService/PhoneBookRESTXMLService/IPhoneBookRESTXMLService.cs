using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PhoneBookRESTXMLService
{
   [ServiceContract]
   public interface IPhoneBookRESTXMLService
   {
      // add an entry to the phone book database
      [OperationContract]
      [WebGet(UriTemplate =
         "AddEntry/{lastName}/{firstName}/{phoneNumber}")]
      void AddEntry(string lastName, string firstName,
         string phoneNumber);

      // retrieve phone book entries with a given last name
      [OperationContract]
      [WebGet(UriTemplate = "GetEntries/{lastName}")]
      string[] GetEntries(string lastName);
   } // end interface IPhoneBookRESTXMLService
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
