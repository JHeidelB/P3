using P5;
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
    public partial class d : Form
    {
        public int nextIDNumber;
        public int id;
        public string title;
        public string discoveryDate;
        public string discoverer;
        public string component;
        public string status;
        public string initialDiscription;
        P5.AppUser _CurrentAppUser;


        public d(P5.AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void d_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // nextIDNumber = _Issues.Count;



        }

        private void TitleTextChanged(object sender, EventArgs e)
        {
            title = TitleTextBox.Text;
        }

        private void DatePicked(object sender, EventArgs e)
        {
            discoveryDate = DiscoveryDateTimePicker.Text;
        }

        private void DiscovererComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            discoverer = DiscovererComboBox1.Text;
        }

        private void ComponentTextBox1_TextChanged(object sender, EventArgs e)
        {
            component = ComponentTextBox1.Text;
        }

        private void StatusComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = StatusComboBox1.Text;
        }

        private void InictialDiscriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            initialDiscription = InictialDiscriptionTextBox.Text;
        }

        private void CreateIssueButton_Click(object sender, EventArgs e)
        {
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            Issue newIssue = new Issue();
            newIssue.id = id;
            newIssue.title = title;
            newIssue.discoveryDate = discoveryDate;
            newIssue.discoverer = discoverer;
            newIssue.inicialDiscription = initialDiscription;
            newIssue.component = component;
            newIssue.status = status;

            issueRepository.Add(1, newIssue);
            this.Close();
        }
    }
}
