using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class RegisterScreen : UserControl
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }
        private void textBoxEmail_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_RemoveText(object sender, EventArgs e)
        {
            if (textBoxEmail.ForeColor != Color.Black)
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
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

        private void textBoxRePassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRePassword.Text))
            {
                textBoxRePassword.Text = "Nhập lại mật khẩu";
                textBoxRePassword.ForeColor = Color.Gray;
                textBoxRePassword.PasswordChar = '\0';
            }
        }

        private void textBoxRePassword_RemoveText(object sender, EventArgs e)
        {
            if (textBoxRePassword.PasswordChar != '*')
            {
                textBoxRePassword.Text = "";
                textBoxRePassword.ForeColor = Color.Black;
                this.textBoxRePassword.PasswordChar = '*';
            }
        }

        private void linkLabelBackToLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen logInScreen = new LogInScreen();
            Utils.ShowScreen(ParentForm, logInScreen);
        }
    }
}
