
namespace CSC470_P3
{
    partial class Remove
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
            this.RemoveProjectNameText = new System.Windows.Forms.Label();
            this.RemoveCancelButton = new System.Windows.Forms.Button();
            this.RemoveRemoveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project to Remove:";
            // 
            // RemoveProjectNameText
            // 
            this.RemoveProjectNameText.AutoSize = true;
            this.RemoveProjectNameText.Location = new System.Drawing.Point(305, 70);
            this.RemoveProjectNameText.Name = "RemoveProjectNameText";
            this.RemoveProjectNameText.Size = new System.Drawing.Size(54, 30);
            this.RemoveProjectNameText.TabIndex = 1;
            this.RemoveProjectNameText.Text = "hold";
            // 
            // RemoveCancelButton
            // 
            this.RemoveCancelButton.Location = new System.Drawing.Point(274, 153);
            this.RemoveCancelButton.Name = "RemoveCancelButton";
            this.RemoveCancelButton.Size = new System.Drawing.Size(182, 40);
            this.RemoveCancelButton.TabIndex = 2;
            this.RemoveCancelButton.Text = "Cancel";
            this.RemoveCancelButton.UseVisualStyleBackColor = true;
            // 
            // RemoveRemoveButton
            // 
            this.RemoveRemoveButton.Location = new System.Drawing.Point(493, 153);
            this.RemoveRemoveButton.Name = "RemoveRemoveButton";
            this.RemoveRemoveButton.Size = new System.Drawing.Size(210, 40);
            this.RemoveRemoveButton.TabIndex = 3;
            this.RemoveRemoveButton.Text = "Remove Project";
            this.RemoveRemoveButton.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 252);
            this.Controls.Add(this.RemoveRemoveButton);
            this.Controls.Add(this.RemoveCancelButton);
            this.Controls.Add(this.RemoveProjectNameText);
            this.Controls.Add(this.label1);
            this.Name = "Remove";
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RemoveProjectNameText;
        private System.Windows.Forms.Button RemoveCancelButton;
        private System.Windows.Forms.Button RemoveRemoveButton;
    }
}