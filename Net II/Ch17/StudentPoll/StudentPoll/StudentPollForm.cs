// Ex. 17.8: StudentPoll.cs
// Allow student to take a survey
// and view the results in a TextBox
using System;
using System.Windows.Forms;
using System.IO;

//Code was edited by Anthony Fuller
//.Net II
//Chapter 17 Exercise 8

namespace StudentPoll
{
   public partial class StudentPollForm : Form
   {
      StreamWriter writer;
      StreamReader input;
      int number;
 

      // parameterless constructor
      public StudentPollForm()
      {
         InitializeComponent();

         //Edited Code ***************************
         //Create the StreamWriter object done
          //Open the file with Write and Read access
         writer = new StreamWriter(new FileStream("numbers.txt", 
             FileMode.OpenOrCreate, FileAccess.ReadWrite));

      } // end constructor

      private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            //Edited Code ************************
            //Added exception handling
             try //This try block catches any errors when writing to the file
             {
                 try //This try block checks for anything that isn't a number
                 {
                     char[] txtCheck = new char[inputTextBox.TextLength];

                     for (int num = 0; num < txtCheck.Length; num++)
                     {
                         txtCheck[num] = Convert.ToChar(inputTextBox.Text[num]);
                         if (!Char.IsNumber(txtCheck[num]))
                         {
                             throw new Exception("Not a number");
                         }
                     }
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Enter a number from 1 - 10");
                     return;
                 }

                 if (String.IsNullOrEmpty(inputTextBox.Text))
                 {
                     MessageBox.Show("Please fill in the TextBox.");
                 } // end if
                 else
                 {

                     number = Convert.ToInt32(inputTextBox.Text);

                     //Edited Code ******************************
                     //  Validates that the number is 1 - 10. When valid, use method Write to put the value into the file
                     if (number > 0 && number < 11)
                     {
                         writer.Write(number + " ");
                     }
                     else
                     {
                         MessageBox.Show("Enter a number from 1 - 10");
                     }

                 } // end else
             }
             catch (Exception) 
             {
                 MessageBox.Show("An unknown error has occured");
             }
            inputTextBox.Clear();
         } // end if
      }

      private void doneButton_Click(object sender, EventArgs e)
      {
         writer.Close();
         //Edited Code *********************************
         //Changed properties such that the display button can be used and this button can't be used.
          //The textbox is read-only
         doneButton.Enabled = false;
         displayButton.Enabled = true;
         inputTextBox.ReadOnly = true;
      }

      private void displayButton_Click(object sender, EventArgs e)
      {
         input = new StreamReader("numbers.txt");

         string inputString = input.ReadToEnd();
         string[] stringArray;
         int[] frequency = new int[11];

         //Edited Code ******************
         //Split the read data into the array. 
          //Populate another integer array with the values from the string array converted to integers. 
          //Updated the frequency array to include a count for each of the responses.

         try //Try block is for if an extra space gets added to the number.txt causeing errors
         {
             stringArray = inputString.Split(' ');
             for (int x = 0; x < stringArray.Length - 1; x++)
             {
                 try
                 {
                     ++frequency[Convert.ToInt32(stringArray[x])];
                 }
                 catch (IndexOutOfRangeException)
                 {
                     displayTextBox.AppendText(String.Format("Responses({0}) = {1}", x, stringArray[x]));
                 }
             }
         }
         catch (Exception)
         {
             MessageBox.Show("Please delete numbers.txt and restart me");
         }
        

         displayTextBox.Clear();
         displayTextBox.AppendText("Rating\tFrequency\n");

         //Edited Code *******************
         //Write out the ratings and frequencies
         for (int rating = 1; rating < frequency.Length; ++rating )
         {
             displayTextBox.AppendText(String.Format("{0,11}\t{1,14}\n",rating,frequency[rating]));
         }

      

      } // end method displayButton_Click
   } // end class StudentPollForm
} // end namespace StudentPoll

