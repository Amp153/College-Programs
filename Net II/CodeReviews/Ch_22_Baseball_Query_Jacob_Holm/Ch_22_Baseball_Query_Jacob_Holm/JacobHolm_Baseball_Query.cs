using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_22_Baseball_Query_Jacob_Holm
{
    public partial class JacobHolm_Baseball_Query : Form
    {
        public JacobHolm_Baseball_Query()
        {
            InitializeComponent();
        }

        //Entity framework DbContext
        private Ch_22_Baseball_Query_Jacob_Holm.BaseballEntities dbcontext = new Ch_22_Baseball_Query_Jacob_Holm.BaseballEntities();
      
        //fill playersbindingsource
        private void RefreshContacts()
        {
            if (dbcontext != null)
            {
                dbcontext.Dispose();
            }//end if

           //Entity framework refresh. 
            dbcontext = new Ch_22_Baseball_Query_Jacob_Holm.BaseballEntities();

            //Query to get every entry. 
            var getAll =
                       from Player in dbcontext.Players
                       select Player;
        
            //Display data and clear boxes. 
            playersBindingSource.DataSource = getAll.ToList();
            playersBindingSource.MoveFirst();
            lastNameBox.Clear();
            rangeMaxBox.Clear();
            rangeMinBox.Clear();
           
        }//end RefreshContacts method
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseballDataSet.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.baseballDataSet.Players);

        }

        private void lastSearch_Click(object sender, EventArgs e)
        {
            String lastName = lastNameBox.Text;
            if (!(lastName.Equals("")))//start if that checks if textbox contains anything. 
            {
                //create lasname query
                var lastQuery =
                    from Player in dbcontext.Players
                    where Player.LastName.Contains( lastName )
                    select Player;
               
                //display matching players
                playersBindingSource.DataSource = lastQuery.ToList();
                playersBindingSource.MoveFirst();
                lastNameBox.Clear();
            }//end if
            else
            {
                MessageBox.Show("Enter a string value in the Last Name box before hitting search.");
                rangeMaxBox.Clear();
                rangeMinBox.Clear();
            }//end else
        }//end method

        private void reset_Click(object sender, EventArgs e)
        {
            RefreshContacts();
        }//end reset_Click method

        private void averageSearch_Click(object sender, EventArgs e)
        { Decimal rangeMax, rangeMin;
           if( Decimal.TryParse(rangeMaxBox.Text, out rangeMax)){
               if (Decimal.TryParse(rangeMinBox.Text, out rangeMin))
               {
                  
                   var rangeQuery =
                      from Player in dbcontext.Players
                      where Player.BattingAverage <= rangeMax && Player.BattingAverage >= rangeMin
                      select Player;
                   playersBindingSource.DataSource = rangeQuery.ToList();
                   playersBindingSource.MoveFirst();
               }//end if
               else
               {
                   MessageBox.Show("Enter a numeric value in the Maximum box before hitting search.");
                   rangeMaxBox.Clear();
                   rangeMinBox.Clear();
               }//end else
           }//end if
           else{
               MessageBox.Show("Enter a numeric value in the Minimum box before hitting search.");
               rangeMaxBox.Clear();
               rangeMinBox.Clear();
               }//end else
               
       }//end method
    }
}
