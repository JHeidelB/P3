using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Create_Feature : Form
    {
        public Create_Feature(object sender)
        {
            this.CenterToParent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateFeature_Click(object sender, EventArgs e)
        {
            List<Feature> _Feature = new List<Feature>();
            if(TitleTextBox.Text == "")
            {
                MessageBox.Show("Title must have a value");
            }
            foreach (Feature p in _Feature)
            {
                if (TitleTextBox.Text == p.Title)
                {
                    MessageBox.Show("Title must be unique");
                    return;
                }
            }
            Create_Requirement form = new Create_Requirement(Title.Text.Trim());
        }
    }
}
