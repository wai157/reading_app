using BusinessLogicLayer;
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
    public partial class FormResetPassword : Form
    {
        private readonly AccountManager _accountManager;
        private readonly int _accountId;
        public FormResetPassword(int accountId)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            _accountId = accountId;
        }

        private void textBox_RemoveText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor != Color.Black)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = '*';
            }
        }

        private void textBoxPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Mật khẩu mới";
                textBoxPassword.ForeColor = Color.Gray;
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void textBoxRePassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRePassword.Text))
            {
                textBoxRePassword.Text = "Nhập lại mật khẩu mới";
                textBoxRePassword.ForeColor = Color.Gray;
                textBoxRePassword.PasswordChar = '\0';
            }
        }

        private void textBoxPassword_Validated(object sender, EventArgs e)
        {
            if (textBoxPassword.ForeColor == Color.Gray || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                errorProvider.SetError(textBoxPassword, "Vui lòng nhập mật khẩu mới!");
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
            if (textBoxRePassword.ForeColor == Color.Gray || string.IsNullOrEmpty(textBoxRePassword.Text))
            {
                errorProvider.SetError(textBoxRePassword, "Vui lòng nhập lại mật khẩu mới!");
            }
            else if (textBoxRePassword.Text != textBoxPassword.Text)
            {
                errorProvider.SetError(textBoxRePassword, "Mật khẩu nhập lại không trùng khớp!");
            }
            else
            {
                errorProvider.SetError(textBoxRePassword, null);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);
            if (string.IsNullOrEmpty(errorProvider.GetError(textBoxPassword))
                && string.IsNullOrEmpty(errorProvider.GetError(textBoxRePassword)))
            {
                _accountManager.ResetPassword(_accountId, textBoxRePassword.Text);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
