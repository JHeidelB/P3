
namespace CSC470_P3
{
    partial class Select
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
            this.ListOfProjects = new System.Windows.Forms.ListBox();
            this.SelectProjectCancelButton = new System.Windows.Forms.Button();
            this.SelectProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOfProjects
            // 
            this.ListOfProjects.FormattingEnabled = true;
            this.ListOfProjects.ItemHeight = 30;
            this.ListOfProjects.Location = new System.Drawing.Point(58, 55);
            this.ListOfProjects.Name = "ListOfProjects";
            this.ListOfProjects.Size = new System.Drawing.Size(681, 244);
            this.ListOfProjects.TabIndex = 0;
            // 
            // SelectProjectCancelButton
            // 
            this.SelectProjectCancelButton.Location = new System.Drawing.Point(436, 343);
            this.SelectProjectCancelButton.Name = "SelectProjectCancelButton";
            this.SelectProjectCancelButton.Size = new System.Drawing.Size(131, 40);
            this.SelectProjectCancelButton.TabIndex = 1;
            this.SelectProjectCancelButton.Text = "Cancel";
            this.SelectProjectCancelButton.UseVisualStyleBackColor = true;
            this.SelectProjectCancelButton.Click += new System.EventHandler(this.SelectProjectCancelButton_Click);
            // 
            // SelectProjectButton
            // 
            this.SelectProjectButton.Location = new System.Drawing.Point(608, 343);
            this.SelectProjectButton.Name = "SelectProjectButton";
            this.SelectProjectButton.Size = new System.Drawing.Size(131, 40);
            this.SelectProjectButton.TabIndex = 2;
            this.SelectProjectButton.Text = "Select Project";
            this.SelectProjectButton.UseVisualStyleBackColor = true;
            this.SelectProjectButton.Click += new System.EventHandler(this.SelectProjectButton_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 413);
            this.Controls.Add(this.SelectProjectButton);
            this.Controls.Add(this.SelectProjectCancelButton);
            this.Controls.Add(this.ListOfProjects);
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListOfProjects;
        private System.Windows.Forms.Button SelectProjectCancelButton;
        private System.Windows.Forms.Button SelectProjectButton;
    }
}