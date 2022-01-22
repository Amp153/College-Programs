using System;
using System.Drawing;
using System.Windows.Forms;

//Anthony Fuller
//.Net II
//Chapter 15 Program 17
/*I was having trouble changing the font size so I used the code at
https://stackoverflow.com/questions/18949341/how-do-i-change-the-text-color-of-a-rich-text-box-that-is-is-an-mdi-parent-form
 for reference so I could change the properties of the rich text box*/

namespace AFChapter15Program7
{
    public partial class MDITextEditor : Form
    {
        public MDITextEditor()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Button was pressed
            TextBoxClass TextBox = new TextBoxClass();
            TextBox.MdiParent = this;
            TextBox.Show();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Exit
            Application.Exit();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cascade
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TileHorizontal
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TileVertical
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close
            ActiveMdiChild.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //9
            ActiveMdiChild.Controls["richTextBox1"].Font = new Font(ActiveMdiChild.Controls["richTextBox1"].Font.Name, 9);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //12
            ActiveMdiChild.Controls["richTextBox1"].Font = new Font(ActiveMdiChild.Controls["richTextBox1"].Font.Name, 12);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //15
            ActiveMdiChild.Controls["richTextBox1"].Font = new Font(ActiveMdiChild.Controls["richTextBox1"].Font.Name, 15);
        }

        private void microsoftSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Microsoft Sans Serif
            ActiveMdiChild.Controls["richTextBox1"].Font = new Font("Microsoft Sans Serif", ActiveMdiChild.Controls["richTextBox1"].Font.Size);
        }

        private void impactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Impact
            //ActiveMdiChild.Font = new Font("Impact", ActiveMdiChild.Font.Size);
            ActiveMdiChild.Controls["richTextBox1"].Font = new Font("Impact", ActiveMdiChild.Controls["richTextBox1"].Font.Size);
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Arial
            ActiveMdiChild.Controls["richTextBox1"].Font = new Font("Arial", ActiveMdiChild.Controls["richTextBox1"].Font.Size);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Black
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Red
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Blue
            ActiveMdiChild.Controls["richTextBox1"].ForeColor = Color.Blue;
        }
    }
}
