
namespace Builder
{
    partial class Select_Requirement
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
            this.buttonSelectRequirement = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStatement = new System.Windows.Forms.Label();
            this.labelFeature = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSelectRequirement
            // 
            this.buttonSelectRequirement.Location = new System.Drawing.Point(541, 588);
            this.buttonSelectRequirement.Name = "buttonSelectRequirement";
            this.buttonSelectRequirement.Size = new System.Drawing.Size(223, 44);
            this.buttonSelectRequirement.TabIndex = 11;
            this.buttonSelectRequirement.Text = "Select Requirement";
            this.buttonSelectRequirement.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(392, 588);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 44);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 414);
            this.textBox1.TabIndex = 9;
            // 
            // labelStatement
            // 
            this.labelStatement.AutoSize = true;
            this.labelStatement.Location = new System.Drawing.Point(69, 141);
            this.labelStatement.Name = "labelStatement";
            this.labelStatement.Size = new System.Drawing.Size(101, 25);
            this.labelStatement.TabIndex = 8;
            this.labelStatement.Text = "Statement";
            // 
            // labelFeature
            // 
            this.labelFeature.AutoSize = true;
            this.labelFeature.Location = new System.Drawing.Point(91, 84);
            this.labelFeature.Name = "labelFeature";
            this.labelFeature.Size = new System.Drawing.Size(79, 25);
            this.labelFeature.TabIndex = 6;
            this.labelFeature.Text = "Feature";
            this.labelFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(177, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(587, 32);
            this.comboBox1.TabIndex = 12;
            // 
            // Select_Requirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 708);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSelectRequirement);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStatement);
            this.Controls.Add(this.labelFeature);
            this.Name = "Select_Requirement";
            this.Text = "Select_Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectRequirement;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStatement;
        private System.Windows.Forms.Label labelFeature;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}