using BusinessLayer;
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

namespace UserControls
{   
    public partial class UserProfileScreen : UserControl
    {
        private readonly AccountManager _accountManager;
        public UserProfileScreen()
        {
            InitializeComponent();
            _accountManager = new AccountManager();
        }
        public void LoadScreen(AccountDTO logInAccount)
        {
            UserInfoDTO userInfoDTO = _accountManager.GetUserInfo(logInAccount.Id);
            if (userInfoDTO != null)
            {
                labelName.Text = "Họ và tên: " + userInfoDTO.Name;
                labelSex.Text = "Giới tính: " + userInfoDTO.Sex;
                labelDOB.Text = "Ngày sinh: " + userInfoDTO.DOB.ToString("yyyy-MM-dd");
                labelUsername.Text = "Tên đăng nhập: " + logInAccount.Username;
                labelEmail.Text = "Email: " + logInAccount.Email;
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            LogInScreen loginScreen = parentForm.Controls.Find("logInScreen", true).First() as LogInScreen;
            Utils.ShowScreen(loginScreen);
        }

    }
}
