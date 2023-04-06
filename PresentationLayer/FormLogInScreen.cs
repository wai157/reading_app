using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormLogInScreen : Form
    {
        private readonly AccountManager _accountManager;

        public FormLogInScreen()
        {
            InitializeComponent();
            _accountManager = new AccountManager(new AccountRepository(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString));
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            bool matchAccount = false;
            var accounts = _accountManager.GetAllAccounts();
            Account logInAccount = new Account();
            foreach (Account account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    matchAccount = true;
                    logInAccount = account;
                    break;
                }
            }
            if (matchAccount == true)
            {
                if (logInAccount.RoleID == 0)
                {
                    
                }
                else if (logInAccount.RoleID == 1)
                {

                }
                else if (logInAccount.RoleID == 2)
                {
                    Form parentForm = ParentForm;
                    Form formTest = new FormUserMainScreen();
                    formTest.TopLevel = false;
                    parentForm.SuspendLayout();
                    parentForm.Controls.Add(formTest);
                    formTest.FormBorderStyle = FormBorderStyle.None;
                    formTest.Dock = DockStyle.Fill;
                    parentForm.ResumeLayout(false);
                    Close();
                    formTest.Show();
                }
            }
            else
            {

            }
        }

        private void textBoxUsername_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                textBoxUsername.Text = "Tên đăng nhập";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_RemoveText(object sender, EventArgs e)
        {
            if (textBoxUsername.ForeColor != Color.Black)
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Mật khẩu";
                textBoxPassword.ForeColor = Color.Gray;
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void textBoxPassword_RemoveText(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar != '*')
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                this.textBoxPassword.PasswordChar = '*';
            }
        }

        private void StealFocus(object sender, EventArgs e)
        {
            panel1.Focus();
        }
    }
}
