
namespace Builder
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
            this.SelectIssueDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectIssueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectIssueDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectIssueDataGridView
            // 
            this.SelectIssueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectIssueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.DiscoveryDate,
            this.Discoverer,
            this.InitialDiscription,
            this.Component,
            this.Status});
            this.SelectIssueDataGridView.Location = new System.Drawing.Point(27, 28);
            this.SelectIssueDataGridView.Name = "SelectIssueDataGridView";
            this.SelectIssueDataGridView.RowHeadersWidth = 72;
            this.SelectIssueDataGridView.RowTemplate.Height = 31;
            this.SelectIssueDataGridView.Size = new System.Drawing.Size(1301, 353);
            this.SelectIssueDataGridView.TabIndex = 0;
            this.SelectIssueDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectIssueDataGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 9;
            this.Id.Name = "Id";
            this.Id.Width = 50;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 9;
            this.Title.Name = "Title";
            this.Title.Width = 300;
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.HeaderText = "DiscoveryDate";
            this.DiscoveryDate.MinimumWidth = 9;
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.Width = 175;
            // 
            // Discoverer
            // 
            this.Discoverer.HeaderText = "Discoverer";
            this.Discoverer.MinimumWidth = 9;
            this.Discoverer.Name = "Discoverer";
            this.Discoverer.Width = 175;
            // 
            // InitialDiscription
            // 
            this.InitialDiscription.HeaderText = "InitialDiscription";
            this.InitialDiscription.MinimumWidth = 9;
            this.InitialDiscription.Name = "InitialDiscription";
            this.InitialDiscription.Width = 175;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.MinimumWidth = 9;
            this.Component.Name = "Component";
            this.Component.Width = 175;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 9;
            this.Status.Name = "Status";
            this.Status.Width = 175;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(941, 407);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(178, 41);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectIssueButton
            // 
            this.SelectIssueButton.Location = new System.Drawing.Point(1163, 407);
            this.SelectIssueButton.Name = "SelectIssueButton";
            this.SelectIssueButton.Size = new System.Drawing.Size(165, 41);
            this.SelectIssueButton.TabIndex = 2;
            this.SelectIssueButton.Text = "Select Issue";
            this.SelectIssueButton.UseVisualStyleBackColor = true;
            this.SelectIssueButton.Click += new System.EventHandler(this.SelectIssueButton_Click);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 602);
            this.Controls.Add(this.SelectIssueButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectIssueDataGridView);
            this.Name = "Modify";
            this.Text = "Modify";
            this.Load += new System.EventHandler(this.Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectIssueDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SelectIssueDataGridView;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectIssueButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialDiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}