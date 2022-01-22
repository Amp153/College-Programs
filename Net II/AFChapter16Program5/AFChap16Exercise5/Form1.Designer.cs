namespace AFChap16Exercise5
{
    partial class formMain
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
            this.lblDirections = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lblTranslate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(13, 13);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(187, 13);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "Enter a sentence with no punctuation:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(16, 30);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(256, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(193, 56);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(79, 23);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(16, 85);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(256, 165);
            this.tbOutput.TabIndex = 3;
            // 
            // lblTranslate
            // 
            this.lblTranslate.AutoSize = true;
            this.lblTranslate.Location = new System.Drawing.Point(16, 66);
            this.lblTranslate.Name = "lblTranslate";
            this.lblTranslate.Size = new System.Drawing.Size(106, 13);
            this.lblTranslate.TabIndex = 4;
            this.lblTranslate.Text = "Pig Latin Translation:";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTranslate);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblDirections);
            this.Name = "formMain";
            this.Text = "Pig Latin Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lblTranslate;
    }
}

