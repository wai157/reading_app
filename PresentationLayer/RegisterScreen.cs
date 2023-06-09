using BusinessLogicLayer;
using Common;
using DataTransferObjectLayer;
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
        private readonly AccountManager _accountManager;
        public RegisterScreen()
        {
            InitializeComponent();
            _accountManager = new AccountManager();
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);
            if(string.IsNullOrEmpty(errorProvider.GetError(textBoxEmail)) == false
               || string.IsNullOrEmpty(errorProvider.GetError(textBoxUsername)) == false
               || string.IsNullOrEmpty(errorProvider.GetError(textBoxPassword)) == false
               || string.IsNullOrEmpty(errorProvider.GetError(textBoxRePassword)) == false) 
            {

            }
            else
            {
                if (_accountManager.GetAccountByUsername(textBoxUsername.Text.Trim()) != null)
                {
                    labelError.Text = "Tên đăng nhập đã được sử dụng, vui lòng nhập tên khác!";
                }
                else
                {
                    labelError.Text = "";
                    AccountDTO registerAccount = new AccountDTO
                    {
                        Email = textBoxEmail.Text.Trim(),
                        Username = textBoxUsername.Text.Trim(),
                        Password = textBoxRePassword.Text
                    };
                    _accountManager.AddAccount(registerAccount);
                    MessageBox.Show("Đăng kí tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBoxEmail_Validated(object sender, EventArgs e)
        {
            if (textBoxEmail.ForeColor != Color.Black || string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                errorProvider.SetError(textBoxEmail, "Vui lòng nhập email!");
            }
            else if (Extensions.IsValidEmail(textBoxEmail.Text) == false)
            {
                errorProvider.SetError(textBoxEmail, "Vui lòng nhập email hợp lệ!");
            }
            else
            {
                errorProvider.SetError(textBoxEmail, null);
            }
        }

        private void textBoxUsername_Validated(object sender, EventArgs e)
        {
            if (textBoxUsername.ForeColor != Color.Black || string.IsNullOrWhiteSpace(textBoxUsername.Text))
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
                return;
            }

            if (Utils.ValidatePassword(textBoxPassword.Text) != true)
            {
                errorProvider.SetError(textBoxPassword, "Mật khẩu cần chứa ít nhất:\n- 8 kí tự\n- 1 chữ cái thường\n- 1 chữ cái hoa\n- 1 số\n- 1 kí tự đặc biệt!");
                return;
            }
            
            errorProvider.SetError(textBoxPassword, null);
        }

        private void textBoxRePassword_Validated(object sender, EventArgs e)
        {
            if (textBoxRePassword.ForeColor != Color.Black || string.IsNullOrEmpty(textBoxRePassword.Text))
            {
                errorProvider.SetError(textBoxRePassword, "Vui lòng nhập lại mật khẩu!");
            }
            else if (textBoxPassword.Text != textBoxRePassword.Text)
            {
                errorProvider.SetError(textBoxRePassword, "Mật khẩu nhập lại không đúng!");
            }
            else
            {
                errorProvider.SetError(textBoxRePassword, null);
            }
        }
    }
}
