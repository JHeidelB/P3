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
    
    public partial class IssueDashboard : Form
    {
        P5.AppUser _CurrentAppUser;
        public IssueDashboard(P5.AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void IssueDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
