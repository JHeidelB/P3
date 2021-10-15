
namespace CSC470_P3
{
    partial class Modify
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
            this.label1 = new System.Windows.Forms.Label();
            this.ModifyProjectTextBox = new System.Windows.Forms.TextBox();
            this.ModifyCancelButton = new System.Windows.Forms.Button();
            this.ModifyModifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name: ";
            // 
            // ModifyProjectTextBox
            // 
            this.ModifyProjectTextBox.Location = new System.Drawing.Point(258, 63);
            this.ModifyProjectTextBox.Name = "ModifyProjectTextBox";
            this.ModifyProjectTextBox.Size = new System.Drawing.Size(363, 35);
            this.ModifyProjectTextBox.TabIndex = 1;
            // 
            // ModifyCancelButton
            // 
            this.ModifyCancelButton.Location = new System.Drawing.Point(324, 125);
            this.ModifyCancelButton.Name = "ModifyCancelButton";
            this.ModifyCancelButton.Size = new System.Drawing.Size(131, 40);
            this.ModifyCancelButton.TabIndex = 2;
            this.ModifyCancelButton.Text = "Cancel";
            this.ModifyCancelButton.UseVisualStyleBackColor = true;
            // 
            // ModifyModifyButton
            // 
            this.ModifyModifyButton.Location = new System.Drawing.Point(490, 125);
            this.ModifyModifyButton.Name = "ModifyModifyButton";
            this.ModifyModifyButton.Size = new System.Drawing.Size(131, 40);
            this.ModifyModifyButton.TabIndex = 3;
            this.ModifyModifyButton.Text = "Modify";
            this.ModifyModifyButton.UseVisualStyleBackColor = true;
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 224);
            this.Controls.Add(this.ModifyModifyButton);
            this.Controls.Add(this.ModifyCancelButton);
            this.Controls.Add(this.ModifyProjectTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ModifyProjectTextBox;
        private System.Windows.Forms.Button ModifyCancelButton;
        private System.Windows.Forms.Button ModifyModifyButton;
    }
}