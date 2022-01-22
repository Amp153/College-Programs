using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;

//Anthony Fuller
//.Net II
//Chapter 22 Exercise 7

namespace DisplayTable
{
    public partial class DisplayPlayersTable : Form
    {
        public DisplayPlayersTable()
        {
            InitializeComponent();
        }

        private Chapter22Exercise7.BaseballEntities dbcontext = null;
            
        //Displays everyone
        private void RefreshList() 
        {
            if (dbcontext != null)
                dbcontext.Dispose();

            dbcontext = new Chapter22Exercise7.BaseballEntities();

            //Determines how the app displays all of the baseball players
            dbcontext.Players
                .OrderBy(player => player.LastName)
                .ThenBy(player => player.FirstName)
                .Load();

            playerBindingSource.DataSource = dbcontext.Players.Local;
            playerBindingSource.MoveFirst();
            tbLastName.Clear();
            tbMin.Clear();
            tbMax.Clear();
        }

        //Automatic on startup
        private void DisplayPlayersTable_Load(object sender, EventArgs e)
        {
            /*The user is only supposed to be able to view the information
             * and not update it.*/
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;

            RefreshList();
        }

        //The browse all button
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        //The last name button
        private void btnLastName_Click(object sender, EventArgs e)
        {
            //error handling
            tbLastName.Text = tbLastName.Text.Trim();

            /*Finds the players who last names that start with 
             * the specified letters and displays the result*/
            var lastNameQuery =
                from player in dbcontext.Players
                where player.LastName.StartsWith(tbLastName.Text)
                orderby player.LastName, player.FirstName
                select player;

            playerBindingSource.DataSource = lastNameQuery.ToList();
            playerBindingSource.MoveFirst();
        }

        //The batting Average button
        private void btnBatAvg_Click(object sender, EventArgs e)
        {
            //Setting default values
            decimal numMax = 1;
            decimal numMin = 0;

            /*Checks if user only entered numbers into one textbox 
             * and if the user entered numbers*/
            try
            {
                if (tbMax.Text == "")
                    tbMax.Text = "1";
                if (tbMin.Text == "")
                    tbMin.Text = "0";
                numMax = Convert.ToDecimal(tbMax.Text);
                numMin = Convert.ToDecimal(tbMin.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter a number from (0.000 - 1.000).");

                return;
            }

            //Finds the batting average in the range specified by the user
            var batAvgQuery =
                from player in dbcontext.Players
                where player.BattingAverage >= numMin && player.BattingAverage <= numMax
                orderby player.LastName, player.FirstName
                select player;

            playerBindingSource.DataSource = batAvgQuery.ToList();
            playerBindingSource.MoveFirst();
        }
    }
}
