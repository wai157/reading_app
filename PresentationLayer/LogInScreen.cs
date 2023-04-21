using BusinessLogicLayer;
using DataTransferObjectLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LogInScreen : UserControl
    {
        private readonly AccountManager _accountManager;
        public AccountDTO LogInAccount { get; set; }

        public LogInScreen()
        {
            InitializeComponent();
            _accountManager = new AccountManager();
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
            labelError.Text = "";
            ValidateChildren(ValidationConstraints.Enabled);
            if (string.IsNullOrEmpty(errorProvider.GetError(textBoxUsername)) == false
                || string.IsNullOrEmpty(errorProvider.GetError(textBoxPassword)) == false) return;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            LogInAccount = _accountManager.Validate(username, password);
            if (LogInAccount != null)
            {
                FormReadingApp formReadingApp = ParentForm as FormReadingApp;
                formReadingApp.LogInAccountDTO = LogInAccount;
                formReadingApp.AcceptButton = null;
                if (LogInAccount.RoleID == 1)
                {
                    AdminScreen adminScreen = new AdminScreen(LogInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
                else if (LogInAccount.RoleID == 3)
                {
                    MainScreen mainScreen = new MainScreen(LogInAccount);
                    Utils.ShowScreen(ParentForm, mainScreen);
                }
                this.textBoxUsername.Text = "Tên đăng nhập";
                this.textBoxUsername.ForeColor = Color.Gray;
                this.textBoxPassword.Text = "Mật khẩu";
                this.textBoxPassword.ForeColor = Color.Gray;
                this.textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                labelError.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }

        private void textBoxUsername_Validated(object sender, EventArgs e)
        {
            if (textBoxUsername.ForeColor != Color.Black || string.IsNullOrEmpty(textBoxUsername.Text))
            {
                errorProvider.SetError(textBoxUsername, "Vui lòng nhập tên đăng nhập!");
            }
            else
            {
                errorProvider.SetError(textBoxUsername, null);
            }
        }

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            if (textBoxPassword.ForeColor != Color.Black || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                errorProvider.SetError(textBoxPassword, "Vui lòng nhập mật khẩu!");
            }
            else
            {
                errorProvider.SetError(textBoxPassword, null);
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            Utils.ShowScreen(ParentForm, registerScreen);
        }
    }
}
