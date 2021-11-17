
namespace Builder
{
    partial class IssueDashboard
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
            this.TotalIssuesLabel = new System.Windows.Forms.Label();
            this.NumberOfIssuesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBoxByMonth = new System.Windows.Forms.ListBox();
            this.ListBoxByDiscoverer = new System.Windows.Forms.ListBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TotalIssuesLabel
            // 
            this.TotalIssuesLabel.AutoSize = true;
            this.TotalIssuesLabel.Location = new System.Drawing.Point(54, 76);
            this.TotalIssuesLabel.Name = "TotalIssuesLabel";
            this.TotalIssuesLabel.Size = new System.Drawing.Size(224, 25);
            this.TotalIssuesLabel.TabIndex = 0;
            this.TotalIssuesLabel.Text = "Total Number of Issues: ";
            // 
            // NumberOfIssuesLabel
            // 
            this.NumberOfIssuesLabel.AutoSize = true;
            this.NumberOfIssuesLabel.Location = new System.Drawing.Point(285, 75);
            this.NumberOfIssuesLabel.Name = "NumberOfIssuesLabel";
            this.NumberOfIssuesLabel.Size = new System.Drawing.Size(117, 25);
            this.NumberOfIssuesLabel.TabIndex = 1;
            this.NumberOfIssuesLabel.Text = "Change ME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issues by Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Issues by Discoverer";
            // 
            // ListBoxByMonth
            // 
            this.ListBoxByMonth.FormattingEnabled = true;
            this.ListBoxByMonth.ItemHeight = 24;
            this.ListBoxByMonth.Location = new System.Drawing.Point(52, 223);
            this.ListBoxByMonth.Name = "ListBoxByMonth";
            this.ListBoxByMonth.Size = new System.Drawing.Size(433, 148);
            this.ListBoxByMonth.TabIndex = 4;
            // 
            // ListBoxByDiscoverer
            // 
            this.ListBoxByDiscoverer.FormattingEnabled = true;
            this.ListBoxByDiscoverer.ItemHeight = 24;
            this.ListBoxByDiscoverer.Location = new System.Drawing.Point(52, 434);
            this.ListBoxByDiscoverer.Name = "ListBoxByDiscoverer";
            this.ListBoxByDiscoverer.Size = new System.Drawing.Size(433, 148);
            this.ListBoxByDiscoverer.TabIndex = 5;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(349, 627);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(135, 53);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 774);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ListBoxByDiscoverer);
            this.Controls.Add(this.ListBoxByMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfIssuesLabel);
            this.Controls.Add(this.TotalIssuesLabel);
            this.Name = "IssueDashboard";
            this.Text = "IssueDashboard";
            this.Load += new System.EventHandler(this.IssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalIssuesLabel;
        private System.Windows.Forms.Label NumberOfIssuesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListBoxByMonth;
        private System.Windows.Forms.ListBox ListBoxByDiscoverer;
        private System.Windows.Forms.Button CloseButton;
    }
}