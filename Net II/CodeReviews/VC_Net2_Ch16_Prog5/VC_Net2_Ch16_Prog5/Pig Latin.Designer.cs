namespace VC_Net2_Ch16_Prog5
{
    partial class PigLatin
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
            this.EnterLabel = new System.Windows.Forms.Label();
            this.SentenceTxtBox = new System.Windows.Forms.TextBox();
            this.TransLabel = new System.Windows.Forms.Label();
            this.TransBtn = new System.Windows.Forms.Button();
            this.TransTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterLabel
            // 
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Location = new System.Drawing.Point(12, 9);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(187, 13);
            this.EnterLabel.TabIndex = 0;
            this.EnterLabel.Text = "Enter a sentence with no punctuation:";
            // 
            // SentenceTxtBox
            // 
            this.SentenceTxtBox.Location = new System.Drawing.Point(15, 27);
            this.SentenceTxtBox.Name = "SentenceTxtBox";
            this.SentenceTxtBox.Size = new System.Drawing.Size(257, 20);
            this.SentenceTxtBox.TabIndex = 1;
            // 
            // TransLabel
            // 
            this.TransLabel.AutoSize = true;
            this.TransLabel.Location = new System.Drawing.Point(12, 63);
            this.TransLabel.Name = "TransLabel";
            this.TransLabel.Size = new System.Drawing.Size(106, 13);
            this.TransLabel.TabIndex = 2;
            this.TransLabel.Text = "Pig Latin Translation:";
            // 
            // TransBtn
            // 
            this.TransBtn.Location = new System.Drawing.Point(197, 53);
            this.TransBtn.Name = "TransBtn";
            this.TransBtn.Size = new System.Drawing.Size(75, 23);
            this.TransBtn.TabIndex = 3;
            this.TransBtn.Text = "Translate";
            this.TransBtn.UseVisualStyleBackColor = true;
            this.TransBtn.Click += new System.EventHandler(this.TransBtn_Click);
            // 
            // TransTxtBox
            // 
            this.TransTxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TransTxtBox.Location = new System.Drawing.Point(15, 81);
            this.TransTxtBox.Multiline = true;
            this.TransTxtBox.Name = "TransTxtBox";
            this.TransTxtBox.ReadOnly = true;
            this.TransTxtBox.Size = new System.Drawing.Size(257, 168);
            this.TransTxtBox.TabIndex = 4;
            // 
            // PigLatin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TransTxtBox);
            this.Controls.Add(this.TransBtn);
            this.Controls.Add(this.TransLabel);
            this.Controls.Add(this.SentenceTxtBox);
            this.Controls.Add(this.EnterLabel);
            this.Name = "PigLatin";
            this.Text = "Pig Latin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.TextBox SentenceTxtBox;
        private System.Windows.Forms.Label TransLabel;
        private System.Windows.Forms.Button TransBtn;
        private System.Windows.Forms.TextBox TransTxtBox;
    }
}

