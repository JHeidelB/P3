
namespace Builder
{
    partial class Create_Requirement
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
            this.labelFeature = new System.Windows.Forms.Label();
            this.textBoxFeature = new System.Windows.Forms.TextBox();
            this.labelStatement = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreateRequirement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFeature
            // 
            this.labelFeature.AutoSize = true;
            this.labelFeature.Location = new System.Drawing.Point(115, 60);
            this.labelFeature.Name = "labelFeature";
            this.labelFeature.Size = new System.Drawing.Size(79, 25);
            this.labelFeature.TabIndex = 0;
            this.labelFeature.Text = "Feature";
            this.labelFeature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFeature
            // 
            this.textBoxFeature.Location = new System.Drawing.Point(201, 60);
            this.textBoxFeature.Name = "textBoxFeature";
            this.textBoxFeature.Size = new System.Drawing.Size(587, 29);
            this.textBoxFeature.TabIndex = 1;
            this.textBoxFeature.TextChanged += new System.EventHandler(this.textBoxFeature_TextChanged);
            // 
            // labelStatement
            // 
            this.labelStatement.AutoSize = true;
            this.labelStatement.Location = new System.Drawing.Point(93, 117);
            this.labelStatement.Name = "labelStatement";
            this.labelStatement.Size = new System.Drawing.Size(101, 25);
            this.labelStatement.TabIndex = 2;
            this.labelStatement.Text = "Statement";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(201, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 414);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(416, 564);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 44);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreateRequirement
            // 
            this.buttonCreateRequirement.Enabled = false;
            this.buttonCreateRequirement.Location = new System.Drawing.Point(565, 564);
            this.buttonCreateRequirement.Name = "buttonCreateRequirement";
            this.buttonCreateRequirement.Size = new System.Drawing.Size(223, 44);
            this.buttonCreateRequirement.TabIndex = 5;
            this.buttonCreateRequirement.Text = "Create Requirement";
            this.buttonCreateRequirement.UseVisualStyleBackColor = true;
            this.buttonCreateRequirement.Click += new System.EventHandler(this.buttonCreateRequirement_Click);
            // 
            // Create_Requirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 666);
            this.Controls.Add(this.buttonCreateRequirement);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelStatement);
            this.Controls.Add(this.textBoxFeature);
            this.Controls.Add(this.labelFeature);
            this.Name = "Create_Requirement";
            this.Text = "Create_Requirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFeature;
        private System.Windows.Forms.TextBox textBoxFeature;
        private System.Windows.Forms.Label labelStatement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreateRequirement;
    }
}