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
    public partial class UserProfileScreen : UserControl
    {
        private readonly AccountManager _accountManager;
        private readonly AccountDTO _logInAccount;
        public UserProfileScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            _logInAccount = logInAccountDTO;
            UserInfoDTO userInfoDTO = _accountManager.GetUserInfo(logInAccountDTO.Id);
            if (userInfoDTO != null)
            {
                pictureBoxAvatar.BackgroundImage = Extensions.ByteArrayToImage(userInfoDTO.Avatar);
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
            int prevRoleId = _logInAccount.RoleID;
            using (FormEditUserInfo editUserInfoScreen = new FormEditUserInfo(_logInAccount, _logInAccount))
            {
                editUserInfoScreen.ShowDialog();
                if (_logInAccount.Id == -1)
                {
                    MessageBox.Show("Phiên đăng nhập hết hạn!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (_logInAccount.RoleID != prevRoleId)
                {
                    MessageBox.Show("Bạn vừa thay đổi phân quyền của bản thân!\nVui lòng đăng nhập lại để thay đổi có hiệu lực!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (editUserInfoScreen.DialogResult == DialogResult.OK)
                {
                    UserProfileScreen userProfileScreen = new UserProfileScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, userProfileScreen);
                }
            }
        }
    }
}
