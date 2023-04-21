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
    public partial class UserProfileScreen : UserControl
    {
        private readonly AccountManager _accountManager;
        public UserProfileScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            UserInfoDTO userInfoDTO = _accountManager.GetUserInfo(logInAccountDTO.Id);
            if (userInfoDTO != null)
            {
                labelName.Text = "Họ và tên: " + userInfoDTO.Name;
                labelSex.Text = "Giới tính: " + userInfoDTO.Sex;
                labelDOB.Text = "Ngày sinh: " + userInfoDTO.DOB.ToString("yyyy-MM-dd");
                labelUsername.Text = "Tên đăng nhập: " + logInAccountDTO.Username;
                labelEmail.Text = "Email: " + logInAccountDTO.Email;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogInScreen loginScreen = new LogInScreen();
            FormReadingApp formReadingApp = ParentForm as FormReadingApp;
            formReadingApp.LogInAccountDTO = null;
            formReadingApp.AcceptButton = loginScreen.ButtonLogIn;
            Utils.ShowScreen(ParentForm, loginScreen);
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

        private void textBoxConfirmNewPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxConfirmNewPassword.Text))
            {
                textBoxConfirmNewPassword.Text = "Xác nhận mật khẩu mới";
                textBoxConfirmNewPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxNewPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                textBoxNewPassword.Text = "Mật khẩu mới";
                textBoxNewPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxCurrentPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCurrentPassword.Text))
            {
                textBoxCurrentPassword.Text = "Mật khẩu hiện tại";
                textBoxCurrentPassword.ForeColor = Color.Gray;
            }
        }

        private void buttonChangeGeneralInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
