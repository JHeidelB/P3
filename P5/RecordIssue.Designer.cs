
namespace Builder
{
    partial class d
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DiscoveryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ComponentTextBox1 = new System.Windows.Forms.TextBox();
            this.DiscovererComboBox1 = new System.Windows.Forms.ComboBox();
            this.StatusComboBox1 = new System.Windows.Forms.ComboBox();
            this.InictialDiscriptionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateIssueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "DiscoveryData:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Component:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Discoverer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Initial Description";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(215, 50);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(115, 29);
            this.IDTextBox.TabIndex = 7;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(215, 96);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(411, 29);
            this.TitleTextBox.TabIndex = 8;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextChanged);
            // 
            // DiscoveryDateTimePicker
            // 
            this.DiscoveryDateTimePicker.Location = new System.Drawing.Point(215, 139);
            this.DiscoveryDateTimePicker.Name = "DiscoveryDateTimePicker";
            this.DiscoveryDateTimePicker.Size = new System.Drawing.Size(411, 29);
            this.DiscoveryDateTimePicker.TabIndex = 9;
            this.DiscoveryDateTimePicker.ValueChanged += new System.EventHandler(this.DatePicked);
            // 
            // ComponentTextBox1
            // 
            this.ComponentTextBox1.Location = new System.Drawing.Point(215, 241);
            this.ComponentTextBox1.Name = "ComponentTextBox1";
            this.ComponentTextBox1.Size = new System.Drawing.Size(411, 29);
            this.ComponentTextBox1.TabIndex = 10;
            this.ComponentTextBox1.TextChanged += new System.EventHandler(this.ComponentTextBox1_TextChanged);
            // 
            // DiscovererComboBox1
            // 
            this.DiscovererComboBox1.FormattingEnabled = true;
            this.DiscovererComboBox1.Location = new System.Drawing.Point(215, 187);
            this.DiscovererComboBox1.Name = "DiscovererComboBox1";
            this.DiscovererComboBox1.Size = new System.Drawing.Size(411, 32);
            this.DiscovererComboBox1.TabIndex = 11;
            this.DiscovererComboBox1.SelectedIndexChanged += new System.EventHandler(this.DiscovererComboBox1_SelectedIndexChanged);
            // 
            // StatusComboBox1
            // 
            this.StatusComboBox1.FormattingEnabled = true;
            this.StatusComboBox1.Items.AddRange(new object[] {
            "Open",
            "Assigned",
            "Fixed",
            "Closed - Won\'t Fix",
            "Closed - Fixed",
            "Closed - by design"});
            this.StatusComboBox1.Location = new System.Drawing.Point(215, 295);
            this.StatusComboBox1.Name = "StatusComboBox1";
            this.StatusComboBox1.Size = new System.Drawing.Size(411, 32);
            this.StatusComboBox1.TabIndex = 12;
            this.StatusComboBox1.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox1_SelectedIndexChanged);
            // 
            // InictialDiscriptionTextBox
            // 
            this.InictialDiscriptionTextBox.Location = new System.Drawing.Point(215, 390);
            this.InictialDiscriptionTextBox.Name = "InictialDiscriptionTextBox";
            this.InictialDiscriptionTextBox.Size = new System.Drawing.Size(411, 29);
            this.InictialDiscriptionTextBox.TabIndex = 13;
            this.InictialDiscriptionTextBox.TextChanged += new System.EventHandler(this.InictialDiscriptionTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(286, 482);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(148, 54);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateIssueButton
            // 
            this.CreateIssueButton.Location = new System.Drawing.Point(478, 482);
            this.CreateIssueButton.Name = "CreateIssueButton";
            this.CreateIssueButton.Size = new System.Drawing.Size(148, 54);
            this.CreateIssueButton.TabIndex = 15;
            this.CreateIssueButton.Text = "Create Issue";
            this.CreateIssueButton.UseVisualStyleBackColor = true;
            this.CreateIssueButton.Click += new System.EventHandler(this.CreateIssueButton_Click);
            // 
            // d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 636);
            this.Controls.Add(this.CreateIssueButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InictialDiscriptionTextBox);
            this.Controls.Add(this.StatusComboBox1);
            this.Controls.Add(this.DiscovererComboBox1);
            this.Controls.Add(this.ComponentTextBox1);
            this.Controls.Add(this.DiscoveryDateTimePicker);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "d";
            this.Text = "RecordIssue";
            this.Load += new System.EventHandler(this.d_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.DateTimePicker DiscoveryDateTimePicker;
        private System.Windows.Forms.TextBox ComponentTextBox1;
        private System.Windows.Forms.ComboBox DiscovererComboBox1;
        private System.Windows.Forms.ComboBox StatusComboBox1;
        private System.Windows.Forms.TextBox InictialDiscriptionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button CreateIssueButton;
    }
}