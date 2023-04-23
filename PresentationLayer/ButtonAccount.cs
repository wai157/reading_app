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
                formEditUserInfo.ShowDialog();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
