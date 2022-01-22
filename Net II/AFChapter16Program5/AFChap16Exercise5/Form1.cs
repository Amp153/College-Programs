using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Anthony Fuller
//.Net II
//Chapter 16 Exercise 5

namespace AFChap16Exercise5
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            //This try block is here to prevent punctuation
            try
            {
                char[] txtCheck = new char[tbInput.TextLength];

                for (int num = 0; num < txtCheck.Length; num++)
                {
                    txtCheck[num] = Convert.ToChar(tbInput.Text[num]);
                    if (Char.IsPunctuation(txtCheck[num]))
                    {
                        throw new Exception("Included punctuation");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Don't use punctuation.");
                return;
            }
            try
            {
                //Removes excess spaces
                string trimTxt = tbInput.Text.Trim();

                //Must be 2 characters in length
                if (tbInput.TextLength < 2)
                {
                    MessageBox.Show("Please enter a sentence");
                }
                else
                {
                    
                    //Splits the string so GetPigLatin translates each word
                    string[] txt = trimTxt.Split(' ');

                    //Sends the words to GetPigLatin
                    for (int num = 0; num < txt.Length; num++)
                    {
                        txt[num] = GetPigLatin(txt[num]);
                    }

                    //Inputs the translated text on a new line
                    tbOutput.Text += (string.Join(" ", txt) + "\r\n");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Too many spaces.");
                return;
            }
        }
        

        //This method translates the strings
        static string GetPigLatin(string txtLatin) {

            //Gets the first letter and stores it
            string firstLetter = txtLatin.Substring(0, 1);

            //String builder
            StringBuilder sbTxt = new StringBuilder();
            object txtAy = "ay";

            //Adds the string to the string builder
            sbTxt.Append(txtLatin);

            //Removes the first letter of the word
            sbTxt.Remove(0, 1);

            //adds the letter to the end of the word
            sbTxt.Append(firstLetter);

            //adds ay to the end of the word
            sbTxt.Append(txtAy);

            //Returns the translated word
            return (sbTxt.ToString());
        }
    }
}
