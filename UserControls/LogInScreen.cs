using BusinessLayer;
using DataTransferObjectLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace UserControls
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
            if (textBoxUsername.ForeColor != Color.Black || textBoxPassword.ForeColor != Color.Black
                || string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPassword.Text)) return;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            LogInAccount = _accountManager.Validate(username, password);
            if (LogInAccount != null)
            {
                Form parentForm = FindForm();
                if (LogInAccount.RoleID == 1)
                {
                    AdminScreen adminScreen = parentForm.Controls.Find("adminScreen", true).First() as AdminScreen;
                    adminScreen.LoadScreen(LogInAccount);
                    Utils.ShowScreen(adminScreen);
                }
                else if (LogInAccount.RoleID == 3)
                {
                    MainScreen mainScreen = parentForm.Controls.Find("mainScreen", true).First() as MainScreen;
                    mainScreen.LoadScreen(LogInAccount);
                    Utils.ShowScreen(mainScreen);
                }
                this.textBoxUsername.Text = "Tên đăng nhập";
                this.textBoxUsername.ForeColor = Color.Gray;
                this.textBoxPassword.Text = "Mật khẩu";
                this.textBoxPassword.ForeColor = Color.Gray;
                this.textBoxPassword.PasswordChar = '\0';
            }
        }
    }
}
