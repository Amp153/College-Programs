// Anthony Fuller

using System;
using System.Drawing;
using System.Windows.Forms;

namespace FuzzyDiceOrderForm
{
    public partial class Form1 : Form
    {
        // Hidden labels are to the right of "can you guess my number?"

        public Form1()
        {
            InitializeComponent();
        }

        // Resets everything to default and starts the game
        private void btnNew_Click(object sender, EventArgs e)
        {
            Random randomNum = new Random();
            int guessMe = randomNum.Next(1,1001);
            //Form1.BackColor = Form1.DefaultBackColor;
            lblGuessMe.Text = guessMe.ToString();
            txtNum.Enabled = true;
            this.BackColor = DefaultBackColor;
            lblFirst.Text = "Please enter your first guess";
            txtNum.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Removes the first guess message
            if (Convert.ToInt32(lblHelper.Text) != 0)
                lblFirst.Text = "";
            
            //The number the user needs to guess
            int ranNum = Convert.ToInt32(lblGuessMe.Text);
            
            int guessedNum = 0;

            try
            {
                //The number the user guesses
                guessedNum = Convert.ToInt32((txtNum.Text).ToString());
                if (guessedNum < 0)
                    guessedNum = 0;
            }
            catch 
            {
                // Prevents crashing if user enters an invalid number
                txtNum.Text = "0";
                guessedNum = Convert.ToInt32((txtNum.Text).ToString());
            }
            int num3 = 0;

            // Closer to 0 the warmer the guess
            int num2 = Math.Abs(ranNum - guessedNum);
            if (num2 != Convert.ToInt32((lblHelper.Text).ToString()))
            {
            num3 = Convert.ToInt32((lblHelper.Text).ToString());
            }
            if (num2 == 0)
            {
                this.BackColor = Color.Green;
                lblHelper.Text = num2.ToString();
            }
            else if (num2 < num3 && Convert.ToInt32(lblHelper.Text) != 0)
            {
                this.BackColor = Color.Red;
                lblHelper.Text = num2.ToString();
            }
            else if (num2 > num3 && Convert.ToInt32(lblHelper.Text) != 0)
            {
                this.BackColor = Color.Blue;
                lblHelper.Text = num2.ToString();
            }
            else
            {
                this.BackColor = DefaultBackColor;
                lblHelper.Text = num2.ToString();
            }

            if (guessedNum < ranNum && guessedNum != 0)
            {
                lblHint.Text = "Too low";
            }
            else if (guessedNum > ranNum)
            {
                lblHint.Text = "Too high";
            }
            else if (guessedNum == 0)
            {
                //prevents negative numbers messing up the code
                lblHint.Text = "Enter positive numbers please";
                this.BackColor = DefaultBackColor;
            }
            else
            {
                lblHint.Text = "Correct!";
                txtNum.Enabled = false;
            }

            // Added when event handleing was added
            if (txtNum.Text == "0")
            {
                lblHint.Text = "Enter whole numbers please";
                this.BackColor = DefaultBackColor;
            }
        }

        

        

       
    }
}
