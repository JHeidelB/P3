
namespace Builder
{
    partial class Modify_Feature
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
            this.buttonModifyFeature = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonModifyFeature
            // 
            this.buttonModifyFeature.Location = new System.Drawing.Point(512, 144);
            this.buttonModifyFeature.Name = "buttonModifyFeature";
            this.buttonModifyFeature.Size = new System.Drawing.Size(162, 41);
            this.buttonModifyFeature.TabIndex = 7;
            this.buttonModifyFeature.Text = "Modify Feature";
            this.buttonModifyFeature.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(383, 144);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 41);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(123, 61);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(551, 29);
            this.TitleTextBox.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(61, 61);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 25);
            this.Title.TabIndex = 4;
            this.Title.Text = "Title:";
            // 
            // Modify_Feature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 260);
            this.Controls.Add(this.buttonModifyFeature);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.Title);
            this.Name = "Modify_Feature";
            this.Text = "Modify_Feature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifyFeature;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label Title;
    }
}