using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JessAssignment
{
    public partial class LoginForm : Form
    {
        public static string Username = "";
        int loginCounter = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTB.Text;
            string password = passwordTB.Text;
            const string fixedUsername = "LewisIsTheBest";
            const string fixedPassword = "123";
            if(true /*username == fixedUsername && password == fixedPassword*/)
            {
                errorLabel.Text = "";
                this.Hide();
                Username = username;
                var displayItemsForm = new DisplayItemsForm();
                displayItemsForm.Show();
            } else
            {
                errorLabel.Text = "Username or Password is Incorrect";
                this.loginCounter++;
                if(this.loginCounter == 3)
                {
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        // WinForms app
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        // Console app
                        System.Environment.Exit(1);
                    }
                }
            }
        }

    }
}
