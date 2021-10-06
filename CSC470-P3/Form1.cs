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
            // Travis: The Program wasnot working because you left the commented out code in when you were testing
            //if (UserNameText.Text == "travis" && PasswordText.Text == "0000")
            {
                bool isAuthenticated;
                FakeAppUserRepository check = new FakeAppUserRepository();
                isAuthenticated = check.Login(UserNameText.Text, PasswordText.Text);

                if (isAuthenticated)
                {
                    check.SetAuthentication(UserNameText.Text, isAuthenticated);
                    Main mainPage = new Main();
                    this.Hide(); // Travis: I changed this to Hide, Close exits the program
                    mainPage.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password","Attention");/*("Username or Password Incorrect");*/ // Travis: Changed this to match the sequence Diagram
                }
            //}
                
            }
        }
    }


}
