using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Builder
{
    public partial class Modify : Form 
    {
        FakeIssueRepository _Issues = new FakeIssueRepository();
        //public static Dictionary<int, Issue> _Issues;
        // _Issues = new Dictionary<int, Issue>();

        public bool isFromRemove = false;
        DataGridViewSelectedRowCollection rowIndex;

        P5.AppUser _CurrentAppUser;
        public Modify(P5.AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        public Modify(P5.AppUser appUser, bool remove)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
            if (remove == true)
            {
                SelectIssueButton.Text = "Remove Selection";
                isFromRemove = remove;
            }
        }
         
        private void SelectIssueDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = SelectIssueDataGridView.SelectedRows;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
           // foreach(KeyValuePair<int, Issue> entey in _Issues)
           // {
           //
           //     string[] row = new string[] { "1", entey.Value.title, entey.Value.discoveryDate, entey.Value.discoverer, entey.Value.inicialDiscription, entey.Value.component, entey.Value.status };
           //     SelectIssueDataGridView.Rows.Add(row);
           // }
        }

        private void SelectIssueButton_Click(object sender, EventArgs e)
        {
            if (isFromRemove == true)
            {
                
            }
        }
    }
}
