
namespace Builder
{
    partial class Create_Feature
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
            this.Title = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreateFeature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(47, 80);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(55, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(109, 80);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(551, 29);
            this.TitleTextBox.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(369, 163);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 41);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreateFeature
            // 
            this.buttonCreateFeature.Location = new System.Drawing.Point(498, 163);
            this.buttonCreateFeature.Name = "buttonCreateFeature";
            this.buttonCreateFeature.Size = new System.Drawing.Size(162, 41);
            this.buttonCreateFeature.TabIndex = 3;
            this.buttonCreateFeature.Text = "Create Feature";
            this.buttonCreateFeature.UseVisualStyleBackColor = true;
            this.buttonCreateFeature.Click += new System.EventHandler(this.buttonCreateFeature_Click);
            // 
            // Create_Feature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 246);
            this.Controls.Add(this.buttonCreateFeature);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.Title);
            this.Name = "Create_Feature";
            this.Text = "Create_Feature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreateFeature;
    }
}