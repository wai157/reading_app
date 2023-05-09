using BusinessLogicLayer;
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
    public partial class ForgotPasswordScreen : UserControl
    {
        private int countdown;
        private readonly AccountManager _accountManager;
        public ForgotPasswordScreen()
        {
            InitializeComponent();
            _accountManager = new AccountManager();
        }

        private void linkLabelBackToLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInScreen logInScreen = new LogInScreen();
            Utils.ShowScreen(ParentForm, logInScreen);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || textBoxUsername.ForeColor != Color.Black)
            {
                errorProvider.SetError(buttonSend, "Vui lòng nhập tên đăng nhập!");
            }
            else
            {
                errorProvider.SetError(buttonSend, null);
            }
            if (string.IsNullOrEmpty(errorProvider.GetError(buttonSend)))
            {
                bool sent = false;
                try
                {
                    sent = _accountManager.SendCode(textBoxUsername.Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng kết nối wifi.");
                    return;
                }
                if (sent != true)
                {
                    labelError.Text = "Không tìm thấy người dùng nào với tên đăng nhập này. Vui lòng thử lại.";
                    return;
                }
                labelError.Text = "";
                countdown = 60;
                timer.Tick += Timer_Tick;
                timer.Start();
                buttonSend.Enabled = false;
                MessageBox.Show("Email đã được gửi đi.\nVui lòng kiểm tra hộp thư của bạn.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (--countdown <= 0)
            {
                buttonSend.Enabled = true;
                buttonSend.Text = "Gửi";
                timer.Stop();
                timer.Tick -= Timer_Tick;
            }
            else
            {
                buttonSend.Text = countdown.ToString();
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

        private void textBoxCode_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCode.Text))
            {
                textBoxCode.Text = "Mã xác thực";
                textBoxCode.ForeColor = Color.Gray;
            }
        }

        private void textBox_RemoveText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor != Color.Black)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text) || textBoxUsername.ForeColor != Color.Black)
            {
                errorProvider.SetError(buttonSend, "Vui lòng nhập tên đăng nhập!");
            }
            else
            {
                errorProvider.SetError(buttonSend, null);
            }
            if (string.IsNullOrEmpty(textBoxCode.Text) || textBoxCode.ForeColor != Color.Black)
            {
                errorProvider.SetError(textBoxCode, "Vui lòng nhập mã xác thực!");
            }
            else
            {
                errorProvider.SetError(textBoxCode, null);
            }

            ValidateChildren(ValidationConstraints.Enabled);
            if (string.IsNullOrEmpty(errorProvider.GetError(buttonSend)) 
                && string.IsNullOrEmpty(errorProvider.GetError(textBoxCode)))
            {
                AccountDTO accountDTO = _accountManager.GetAccountByUsername(textBoxUsername.Text);
                if (accountDTO == null)
                {
                    labelError.Text = "Không tìm thấy người dùng nào với tên đăng nhập này. Vui lòng thử lại.";
                }
                else if (_accountManager.VerifyCode(textBoxUsername.Text, textBoxCode.Text) == true)
                {
                    labelError.Text = "";
                    using (FormResetPassword formResetPassword = new FormResetPassword(accountDTO.Id))
                    {
                        formResetPassword.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Mã xác thực không đúng hoặc đã quá hạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
