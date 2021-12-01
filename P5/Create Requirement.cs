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
    public partial class Create_Requirement : Form
    {
        private string featureTitle;

        public Create_Requirement(string featureName)
        {
            this.featureTitle = featureName;
            this.CenterToParent();
            textBoxFeature.Text = featureName;
        }

        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCreateRequirement_Click(object sender, EventArgs e)
        {
            Requirement CreateReq = new Requirement();
            FakeRequirementRepository Req = new FakeRequirementRepository();
            CreateReq.Feature = textBoxFeature.Text;
            CreateReq.Statement = textBox1.Text;
            Req.Add(CreateReq);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            setButtonVis();
        }
        private void setButtonVis()
        {
            if (textBox1.Text != String.Empty)
            {
                buttonCreateRequirement.Enabled = true;
            }
            else
            {
                buttonCreateRequirement.Enabled = false;
            }
        }

        private void textBoxFeature_TextChanged(object sender, EventArgs e)
        {
            setTextVis();
        }

        private void setTextVis()
        {
            if (textBoxFeature.Text != String.Empty)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }
    }
}
