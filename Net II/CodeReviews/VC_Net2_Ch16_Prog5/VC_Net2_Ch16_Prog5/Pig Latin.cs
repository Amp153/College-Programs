using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Vincent Cha
//Chapter 16, Prog 5

namespace VC_Net2_Ch16_Prog5
{
    public partial class PigLatin : Form
    {
        //variables
        String[] text;
        String newText;
        String pigText;
        String firstLetter;
        String otherLetters;

        public PigLatin()
        {
            InitializeComponent();
        }

      //when translate button is clicked, execute methods
        private void TransBtn_Click(object sender, EventArgs e)
        {
            //prompts user to enter a sentence when textbox contains nothing
            if (SentenceTxtBox.Text == "")
            {
                MessageBox.Show("Enter a sentence");
            }
            else
            {
                //converts and splits entered text into a string array
                text = SentenceTxtBox.Text.Split(null);

                //invoke GetPigLatin method with text as args
                GetPigLatin(text);

                //display the string value of pigText, after being converted via method, inside the large textbox
                TransTxtBox.AppendText(pigText);

                //allows new text to appear on the next line
                TransTxtBox.AppendText(Environment.NewLine);

                //resets textbox to nothing
                SentenceTxtBox.Text = "";

                //resets pigText so no word repeats occur
                pigText = null;

            }

        }

        //Method to convert words into pig latin
        private void GetPigLatin(Array sentence)
        {
            
            //foreach loop to convert each word into pig latin
            foreach (String x in sentence)
            {
                //exception handling for ArgumentOutOfRangeException
                try
                {
                    //takes first Char of string and stores into firstLetter
                    firstLetter = x.Substring(0, 1);

                    //takes rest of the word and stores into otherLetters
                    otherLetters = x.Substring(1);

                    //combines both variables with "ay" to complete pig latin word
                    newText = otherLetters + firstLetter + "ay";

                    //adds every combined word into the sentence
                    pigText += " " + newText;

                }

                catch (ArgumentOutOfRangeException e)
                {
                    //resets pigText if exception is caught so that it doesnt display anything
                    pigText = "";
                }


            }



            //return pigText;
        }

    }
}
