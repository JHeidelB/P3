using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P3
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameText.Text == "travis" && PasswordText.Text == "0000")
            {
                bool isAuthenticated;
                FakeAppUserRepository check = new FakeAppUserRepository();
                isAuthenticated = check.Login(UserNameText.Text, PasswordText.Text);

                if (isAuthenticated)
                {
                    check.SetAuthentication(UserNameText.Text, isAuthenticated);
                    Main mainPage = new Main();
                    this.Close();
                    mainPage.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect");
                }

                
            }
        }
    }


}
