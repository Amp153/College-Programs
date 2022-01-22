using System;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyDice
{
    public partial class FuzzyDice : Form
    {
        public FuzzyDice()
        {
            InitializeComponent();
        }

        


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtZip.Text = "";
            txtName.Text = "";
            cboState.SelectedIndex = -1;
            txtOrder.Text = "";
            ClearUp();

        }
        private void ClearUp() {
            txtBB.Text = "";
            txtRB.Text = "";
            txtWB.Text = "";
            chkWB.Checked = false;
            chkRB.Checked = false;
            chkBB.Checked = false;
            lblBB.Text = "";
            lblRB.Text = "";
            lblWB.Text = "";
            lblSubtotal.Text = "";
            lblShipping.Text = "";
            lblTotal.Text = "";
        }

       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal RB = 0, WB = 0, BB = 0, tax, total, WBq = 0, RBq = 0, BBq = 0, Ship;
            try
            {
                if (txtName.Text == "")
                    //MessageBox.Show("Must Enter a name");
                    //MessageBox.Show("Must Enter a name", "ERROR", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error);
                MessageBox.Show("Must Enter a name", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                else
                {
                    if (cboState.SelectedIndex == -1)
                        MessageBox.Show("Must select a state");
                    else
                    {
                        if ((txtWB.Text.StartsWith("-")) || (txtBB.Text.StartsWith("-"))
                            || (txtRB.Text.StartsWith("-")))
                            MessageBox.Show("No negative numbers");
                        else
                            if (chkWB.Checked)
                            {
                                WBq = Convert.ToInt32(txtWB.Text);
                                WB = 1.25m * WBq;
                                //lblWB.Text = (1.25 * Convert.ToInt32(txtWB.Text)).ToString();
                                lblWB.Text = string.Format("{0:C}", 1.25 * Convert.ToInt32(txtWB.Text)).ToString();
                            }
                        if (chkBB.Checked)
                        {
                            BBq = Convert.ToInt32(txtBB.Text);
                            BB = 2.75m * BBq;
                            //lblWB.Text = (1.25 * Convert.ToInt32(txtWB.Text)).ToString();
                            lblBB.Text = string.Format("{0:C}", 2.75 * Convert.ToInt32(txtBB.Text)).ToString();
                        }
                        if (chkRB.Checked)
                        {
                            RBq = Convert.ToInt32(txtRB.Text);
                            RB = 5m * RBq;
                            //lblWB.Text = (1.25 * Convert.ToInt32(txtWB.Text)).ToString();
                            lblRB.Text = string.Format("{0:C}", 5 * Convert.ToInt32(txtRB.Text)).ToString();
                        }

                        decimal subtotal = BB + WB + RB;
                        lblSubtotal.Text = string.Format("{0:C}", subtotal);

                        tax = subtotal * .05m;
                        lblTax.Text = string.Format("{0:C}", tax);

                        if (WBq + BBq + RBq > 20m ||
                            WBq + BBq + RBq == 0m)
                            Ship = 0m;
                        else
                            Ship = 1.5m;
                        lblShipping.Text = string.Format("{0:C}", Ship);

                        lblTotal.Text = string.Format("{0:C}",
                            subtotal + tax + Ship);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Enter whole numbers");
                ClearUp();
            }

        }
    }
}
