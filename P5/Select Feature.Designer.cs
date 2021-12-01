
namespace Builder
{
    partial class Select_Feature
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectFeatureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectFeatureFeature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelectFeature = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectFeatureID,
            this.SelectFeatureFeature});
            this.dataGridView1.Location = new System.Drawing.Point(38, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(966, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // SelectFeatureID
            // 
            this.SelectFeatureID.HeaderText = "ID";
            this.SelectFeatureID.MinimumWidth = 9;
            this.SelectFeatureID.Name = "SelectFeatureID";
            this.SelectFeatureID.Width = 75;
            // 
            // SelectFeatureFeature
            // 
            this.SelectFeatureFeature.HeaderText = "Feature";
            this.SelectFeatureFeature.MinimumWidth = 9;
            this.SelectFeatureFeature.Name = "SelectFeatureFeature";
            this.SelectFeatureFeature.Width = 850;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(566, 472);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(181, 44);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelectFeature
            // 
            this.buttonSelectFeature.Location = new System.Drawing.Point(786, 472);
            this.buttonSelectFeature.Name = "buttonSelectFeature";
            this.buttonSelectFeature.Size = new System.Drawing.Size(218, 44);
            this.buttonSelectFeature.TabIndex = 2;
            this.buttonSelectFeature.Text = "Select Feature";
            this.buttonSelectFeature.UseVisualStyleBackColor = true;
            // 
            // Select_Feature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 548);
            this.Controls.Add(this.buttonSelectFeature);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Select_Feature";
            this.Text = "Select_Feature";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectFeatureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectFeatureFeature;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelectFeature;
    }
}