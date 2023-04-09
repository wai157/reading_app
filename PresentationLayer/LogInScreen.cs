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
    public partial class LogInScreen : UserControl
    {
        private readonly AccountManager _accountManager;
        private Account logInAccount = new Account();

        public LogInScreen()
        {
            InitializeComponent();
            _accountManager = new AccountManager(new AccountRepository(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString));
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

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.ForeColor != Color.Black || textBoxPassword.ForeColor != Color.Black
                || string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text)) return;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            logInAccount = _accountManager.Validate(username, password);
            if (logInAccount != null)
            {
                Form parentForm = FindForm();
                MainScreen mainScreen = parentForm.Controls.Find("mainScreen", true).First() as MainScreen;
                mainScreen.LoadBooks(logInAccount);
                utils.ShowScreen(mainScreen);
            }
        }
    }
}
