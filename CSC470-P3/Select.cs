using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSC470_P3
{
    public partial class Select : Form
    {
        int cancelCount = 0;
        public Select()
        {
            InitializeComponent();
        }

        private void SelectProjectCancelButton_Click(object sender, EventArgs e)
        {
            cancelCount += 1;
            if (cancelCount == 2)
            {
                Application.Exit();
            }
            MessageBox.Show("You must Select a Project", "Error");
        }

        private void SelectProjectButton_Click(object sender, EventArgs e)
        {
            cancelCount = 0;

        }
    }
}
