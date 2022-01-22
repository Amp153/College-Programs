using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisplayTable
{
    public partial class formPlayers : Form
    {
        public formPlayers()
        {
            InitializeComponent();
            
        }

        //This is a terrible name for this class and I apologize 
        private MG_22_7.BaseballEntities dbcontext = null;

        private void RefreshPlayers()
        {
            //Remove old dbcontext if one exists
            //Probably not necessary since we're not allowing edits
            if (dbcontext != null)
                dbcontext.Dispose();

            //To get this to work I had to manually add the following to App.Config in the DisplayTable folder in the main project directory
            //<connectionStrings>
                //<add name="BaseballEntities" connectionString="metadata=res://*/BaseballModel.csdl|res://*/BaseballModel.ssdl|res://*/BaseballModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\v11.0;attachdbfilename=|DataDirectory|\Baseball.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
            //</connectionStrings>
            //This code was present in the App.Config file found under the MG_22_7 directory (the folder for the class library, not the main project directory)
            //Without this code, the executing class has no connection to the database, and throws an exception
            dbcontext = new MG_22_7.BaseballEntities();

            //Uses Linq to order the players by batting average, then last name, and then load the table
            dbcontext.Players.OrderBy(players => players.BattingAverage).ThenBy(players => players.LastName).Load();

            //Specifies the data source
            playerBindingSource.DataSource = dbcontext.Players.Local;
            //Goes to the first result
            playerBindingSource.MoveFirst();
            
        }

        //On Load, refresh the database
        private void formPlayers_Load(object sender, EventArgs e)
        {
            RefreshPlayers();

            //Disables adding/deleting new players because this app is only for queries
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void buttonNameFind_Click(object sender, EventArgs e)
        {
            //Linq filter to find players by Last Name, then order by last name, then first name
            var lastNameQuery = from Player in dbcontext.Players
                                where Player.LastName.StartsWith ( textBoxLastName.Text)
                                orderby Player.LastName, Player.FirstName
                                select Player;

            //Displays matching players
            playerBindingSource.DataSource = lastNameQuery.ToList();
            playerBindingSource.MoveFirst();

            textBoxLastName.Clear();
        }

        private void buttonBrowseAll_Click(object sender, EventArgs e)
        {
            textBoxLastName.Clear();
            RefreshPlayers();
        }

        private void buttonAvgFind_Click(object sender, EventArgs e)
        {
            //M suffix designates a literal decimal
            decimal max = 1.0M;
            decimal min = 0.0M;

            //If the numbers cannot be converted, clear the textboxes
            try 
            {
                max = Convert.ToDecimal(textBoxMax.Text);
                min = Convert.ToDecimal(textBoxMin.Text);
            }
            catch (FormatException)
            {
                textBoxMax.Clear();
                textBoxMin.Clear();
            }
            var battingAvgQuery = from Player in dbcontext.Players
                                  where Player.BattingAverage > min && Player.BattingAverage < max
                                  orderby Player.BattingAverage, Player.LastName
                                  select Player;

            playerBindingSource.DataSource = battingAvgQuery.ToList();
            playerBindingSource.MoveFirst();

            textBoxMax.Clear();
            textBoxMin.Clear();
        }
    }
}
