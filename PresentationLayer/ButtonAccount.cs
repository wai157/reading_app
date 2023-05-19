using BusinessLogicLayer;
using Common;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ButtonAccount : UserControl
    {   
        private readonly AccountManager _accountManager;
        private readonly AccountDTO _logInAccount;
        private readonly AccountDTO _presentedAccount;
        public ButtonAccount(AccountDTO logInAccount, AccountDTO presentedAccount)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            UserInfoDTO userInfoDTO = _accountManager.GetUserInfo(presentedAccount.Id);
            this.pictureBox1.BackgroundImage = Extensions.ByteArrayToImage(userInfoDTO.Avatar);
            this.labelUsername.Text = presentedAccount.Username;
            this.labelRole.Text = "Role: " + presentedAccount.RoleID.ToString();
            _presentedAccount= presentedAccount;
            _logInAccount = logInAccount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSelfEdit = (_logInAccount.Id == _presentedAccount.Id);
            using (FormEditUserInfo formEditUserInfo = new FormEditUserInfo(_logInAccount, _presentedAccount))
            {
                try
                {
                    formEditUserInfo.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Người dùng không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                    if (_logInAccount.Id == _presentedAccount.Id)
                    {
                        LogInScreen logInScreen = new LogInScreen();
                        Utils.ShowScreen(ParentForm, logInScreen);
                    }
                    if (_logInAccount.RoleID != 3)
                    {
                        AdminScreen adminScreen = new AdminScreen(_logInAccount);
                        Utils.ShowScreen(ParentForm, adminScreen);
                    }
                    else if (_logInAccount.RoleID == 3)
                    {
                        MainScreen mainScreen = new MainScreen(_logInAccount);
                        Utils.ShowScreen(ParentForm, mainScreen);
                    }
                }
                if (isSelfEdit == true && _presentedAccount.Id == -1)
                {
                    MessageBox.Show("Phiên đăng nhập hết hạn!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (isSelfEdit == true && _logInAccount.RoleID != _presentedAccount.RoleID)
                {
                    MessageBox.Show("Bạn vừa thay đổi phân quyền của bản thân!\nVui lòng đăng nhập lại để thay đổi có hiệu lực!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (formEditUserInfo.DialogResult == DialogResult.OK || _presentedAccount.Id == -1)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }
    }
}
