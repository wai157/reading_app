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

    }
}
