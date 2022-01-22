namespace FuzzyDiceOrderForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblGuessMe = new System.Windows.Forms.Label();
            this.lblHelper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(27, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(320, 13);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "I have a number between 1 and 1000--can you guess my number?";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(109, 54);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(128, 13);
            this.lblFirst.TabIndex = 1;
            this.lblFirst.Text = "Select New Game to start";
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(112, 93);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(272, 149);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(30, 135);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(27, 185);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(53, 13);
            this.lblHint.TabIndex = 5;
            this.lblHint.Text = "Unknown";
            // 
            // lblGuessMe
            // 
            this.lblGuessMe.AutoSize = true;
            this.lblGuessMe.BackColor = System.Drawing.Color.Transparent;
            this.lblGuessMe.ForeColor = System.Drawing.Color.Black;
            this.lblGuessMe.Location = new System.Drawing.Point(349, 35);
            this.lblGuessMe.Name = "lblGuessMe";
            this.lblGuessMe.Size = new System.Drawing.Size(13, 13);
            this.lblGuessMe.TabIndex = 6;
            this.lblGuessMe.Text = "0";
            this.lblGuessMe.Visible = false;
            // 
            // lblHelper
            // 
            this.lblHelper.AutoSize = true;
            this.lblHelper.BackColor = System.Drawing.Color.Transparent;
            this.lblHelper.ForeColor = System.Drawing.Color.Black;
            this.lblHelper.Location = new System.Drawing.Point(353, 9);
            this.lblHelper.Name = "lblHelper";
            this.lblHelper.Size = new System.Drawing.Size(13, 13);
            this.lblHelper.TabIndex = 7;
            this.lblHelper.Text = "0";
            this.lblHelper.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(374, 226);
            this.Controls.Add(this.lblHelper);
            this.Controls.Add(this.lblGuessMe);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblStart);
            this.Name = "Form1";
            this.Text = "Guess the numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblGuessMe;
        private System.Windows.Forms.Label lblHelper;
    }
}

