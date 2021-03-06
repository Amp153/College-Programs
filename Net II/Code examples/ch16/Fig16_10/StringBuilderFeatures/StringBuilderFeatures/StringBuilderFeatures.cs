// Fig. 16.10: StringBuilderFeatures.cs
// Demonstrating some features of class StringBuilder.
using System;
using System.Text;

class StringBuilderFeatures
{
   public static void Main( string[] args )
   {
      StringBuilder buffer =
         new StringBuilder( "Hello, how are you?" );

      // use Length and Capacity properties
      Console.WriteLine( "buffer = " + buffer +
         "\nLength = " + buffer.Length +
         "\nCapacity = " + buffer.Capacity );

      buffer.EnsureCapacity( 75 ); // ensure a capacity of at least 75
      Console.WriteLine( "\nNew capacity = " +
         buffer.Capacity );

      // truncate StringBuilder by setting Length property
      buffer.Length = 10;
      Console.Write( "\nNew length = " +
         buffer.Length + "\nbuffer = " );

      // use StringBuilder indexer
      for ( int i = 0; i < buffer.Length; ++i )
         Console.Write( buffer[ i ] );

      Console.WriteLine( "\n" );
   } // end Main
} // end class StringBuilderFeatures

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
 *************************************************************************/