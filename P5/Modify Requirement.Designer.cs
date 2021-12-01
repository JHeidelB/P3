
namespace Builder
{
    partial class Modify_Requirement
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
            this.comboBoxFeature = new System.Windows.Forms.ComboBox();
            this.buttonModifyRequirement = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStatement = new System.Windows.Forms.Label();
            this.labelFeature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxFeature
            // 
            this.comboBoxFeature.FormattingEnabled = true;
            this.comboBoxFeature.Location = new System.Drawing.Point(185, 71);
            this.comboBoxFeature.Name = "comboBoxFeature";
            this.comboBoxFeature.Size = new System.Drawing.Size(587, 32);
            this.comboBoxFeature.TabIndex = 18;
            // 
            // buttonModifyRequirement
            // 
            this.buttonModifyRequirement.Location = new System.Drawing.Point(549, 575);
            this.buttonModifyRequirement.Name = "buttonModifyRequirement";
            this.buttonModifyRequirement.Size = new System.Drawing.Size(223, 44);
            this.buttonModifyRequirement.TabIndex = 17;
            this.buttonModifyRequirement.Text = "Select Requirement";
            this.buttonModifyRequirement.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(400, 575);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 44);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 414);
            this.textBox1.TabIndex = 15;
            // 
            // labelStatement
            // 
            this.labelStatement.AutoSize = true;
            this.labelStatement.Location = new System.Drawing.Point(77, 128);
            this.labelStatement.Name = "labelStatement";
            this.labelStatement.Size = new System.Drawing.Size(101, 25);
            this.labelStatement.TabIndex = 14;
            this.labelStatement.Text = "Statement";
            // 
            // labelFeature
            // 
            this.labelFeature.AutoSize = true;
            this.labelFeature.Location = new System.Drawing.Point(99, 71);
            this.labelFeature.Name = "labelFeature";
            this.labelFeature.Size = new System.Drawing.Size(79, 25);
            this.labelFeature.TabIndex = 13;
            this.labelFeature.Text = "Feature";
            this.labelFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Modify_Requirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 683);
            this.Controls.Add(this.comboBoxFeature);
            this.Controls.Add(this.buttonModifyRequirement);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStatement);
            this.Controls.Add(this.labelFeature);
            this.Name = "Modify_Requirement";
            this.Text = "Modify_Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFeature;
        private System.Windows.Forms.Button buttonModifyRequirement;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelStatement;
        private System.Windows.Forms.Label labelFeature;
    }
}