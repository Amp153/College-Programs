// Program by Amy Balser//
//Named to the project and didn't remember that this is .net and not java till I had finished the program.
//it should be named TextEditorMDI or something like that.//

//There are few mistakes I think I made while trying to get back into the swing of C#.//

using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

namespace ABChap15Prog7
{
    public partial class MyMDIForm : Form
    {

        ChildForm child;
        

//method to chage the size (but keep the font)
        private Font changeSize(Font font, int size)
        {
            String name = font.Name;
            font = new Font(name, size);
            return font;
        }
 // method to chage font family (but not size)
        private Font changeFontFamily(Font font, String family)
        {
            float size = font.Size;
            font = new Font(family, size);
            return font;
        }


        public MyMDIForm()
        {
            InitializeComponent();
        }

       
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void MyMDIForm_Load(object sender, EventArgs e)
        {

        }

// opens a new child form with text box that can be edited
        private void openNewTextToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //creating child
            child = new ChildForm("Text to Edit", "texttoedit");
            child.MdiParent = this;
            child.Show();
        }

//closes the currently selected child form
        private void closeCurrentTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
 //***********************************COLOR***************************************//
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Controls["textBox1"].ForeColor = Color.Red;
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Controls["textBox1"].ForeColor = Color.Blue;
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Controls["textBox1"].ForeColor = Color.Green;
            }
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Controls["textBox1"].ForeColor = Color.Orange;
            }
        }
//****************************************SIZE***********************************//
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
                Font font = this.ActiveMdiChild.Controls["textBox1"].Font;
                
                this.ActiveMdiChild.Controls["textBox1"].Font = changeSize(font, 8);
            
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeSize(font, 10);
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeSize(font, 12);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeSize(font, 18);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeSize(font, 24);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeSize(font, 30);
        }
//***********************************FONT FAMILY*****************************************//
        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeFontFamily(font, "Times New Roman");
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeFontFamily(font, "Arial");
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font font = this.ActiveMdiChild.Controls["textBox1"].Font;

            this.ActiveMdiChild.Controls["textBox1"].Font = changeFontFamily(font, "Courier");
        }
  //Exit Application
        private void exitApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}

