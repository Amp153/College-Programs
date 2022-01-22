using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/**
 * Benjamin Steier
 * 
 * This program uses the new xaml style of formating to create a cash register calculator. This is done by more complex means than a normal
 * windows form would have. For starters we are able to group thing up within seperate grids within a grid much more easily. And because of this
 * we have the xaml code to manipulate. In the code we are able to do things like create an event handler for every button in a specific grid.
 * This cuts down on the amount of code you have to do by a significant amount as you see down below. Instead of having an event handler for each
 * button on the calculator, we are able to give the grid a specific event to look for, and anything in that event will trigger the handler.
 * */

namespace CashRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Initiate the variables needed for the code
       // private decimal userNumber;
        decimal tax = .07125M;
        private decimal subtotal;
        private decimal grandTotal;
        private decimal taxAmount;

        private String taxString = "";
        private String subtotalString;
        private String totalString = "";
        private String cashAmount = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        //This is the grid that stores all the calculator buttons on. It will look at the content of that button (in this case the number that 
        //the button represents) and append that to the text box at the top of the screen creating the desigered number.
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            //cashAmount is the string that will take the textbox's text, and add the casted version of the sender's content (So if a button
            //is pressed it will take that content, turn it to a string, and place it into the text box).
            cashAmount = CashInput.Text += ((Button)sender).Content.ToString();
            
        }

        //Simple enter button that will take the variables created in the numberbutton click and append them to the subtotal textbox
        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            //this will look to see if the number in the text box is empty or equal to 0. if it is it will prompt the user to enter a value into
            //the text box through the buttons.
            if (string.IsNullOrEmpty(cashAmount) || cashAmount.Equals("0"))
            {
                CashInput.Clear();
                MessageBox.Show("Please enter an amount into the cash register");
            }
                //if it isn't 0 try to convert the number to a decimal and append it to the subtotal box
            else
            {
                try
                {
                    subtotal += System.Convert.ToDecimal(cashAmount);
                    subtotalString = System.Convert.ToString(subtotal);
                    subtotalTextBox.Text = subtotalString;
                    CashInput.Clear();
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Please enter an amount into the cash register");
                }
            }
        }

        //if the total button is clicked it will then take the information in the previous variables (only the subtotal variable) 
        //and populate the text boxes necesarry

        private void totalButton_Click(object sender, RoutedEventArgs e)
        {
                

                //populate the tax
                taxAmount = tax * subtotal;
                decimal.Round(taxAmount, 2);
                taxString = taxAmount.ToString("0.##");
                taxTextBox.Text = taxString;

                //populate the grand total
                grandTotal = taxAmount + subtotal;
                totalString = grandTotal.ToString("0.##");

                totalTextBox.Text = totalString;
            

        }

        //this will just clear the cash input. It won't edit anything else about the code because you have to press enter for the 
        //other variables to be affected.
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            CashInput.Clear();
        }

        //I was looking online to figure out the best way and couldn't get any way to work so I just created a method that will set
        //every value to 0 and call that method.
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }

        //reset method that sets everything to 0.
        public void reset()
        {
            subtotal = 0;
            grandTotal = 0;
            taxAmount = 0;

            String taxString = "";
            String subtotalString;
            String totalString = "";
            String cashAmount = "";

            taxTextBox.Clear();
            totalTextBox.Clear();
            subtotalTextBox.Clear();
            CashInput.Clear();

        }

    }
}
