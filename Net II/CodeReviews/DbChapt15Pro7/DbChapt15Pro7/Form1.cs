using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbChapt15Pro7

{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm2 childForm = new childForm2();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ClearColor()
        {

            blackToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            purpleToolStripMenuItem.Checked = false;
            pinkToolStripMenuItem.Checked = false;

        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
           this.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
           
           
           this.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

           this.ForeColor = Color.Yellow;
            yellowToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

           this. ForeColor = Color.Green;
            greenToolStripMenuItem.Checked = true;
            
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

          this.  ForeColor = Color.Blue;
            blackToolStripMenuItem.Checked = true;
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            ForeColor = Color.Orange;
            orangeToolStripMenuItem.Checked = true;

        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();

           this. ForeColor = Color.Purple;
            purpleToolStripMenuItem.Checked = true;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
        this.ForeColor= Color.Pink;
            pinkToolStripMenuItem.Checked = true;

        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void ClearFont()
        { 
        
        //clear all checkmarks

            timeToolStripMenuItem.Checked = false;
            microsoftSansSerifToolStripMenuItem.Checked = false;
            arilToolStripMenuItem.Checked = false;
            courierNewToolStripMenuItem.Checked = false;
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            timeToolStripMenuItem.Checked = true;
            Font = new Font("Times New Roman", 14, Font.Style);
        }

        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            microsoftSansSerifToolStripMenuItem.Checked = true;
           Font = new Font("comic Sans Ms" ,14 , Font.Style); 
        }

        private void arilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            arilToolStripMenuItem.Checked = true;
            Font = new Font("Aril", 14, Font.Style);

        }

        private void courierNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            courierNewToolStripMenuItem.Checked = true;
            Font = new Font("Times New Roman", 14, Font.Style);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Font = new Font("font size", 8);
            ActiveMdiChild.Controls["richTextBox1"].Font = new Font(ActiveMdiChild.Controls["richTextBox1"].Font.Name, 8);
        }
    }
}
 