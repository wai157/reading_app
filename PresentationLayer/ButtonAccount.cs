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
        public AccountDTO LogInAccount { get; set; }
        public AccountDTO PresentedAccount { get; set; }
        public ButtonAccount(AccountDTO logInAccount, AccountDTO presentedAccount)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            UserInfoDTO userInfoDTO = _accountManager.GetUserInfo(presentedAccount.Id);
            this.pictureBox1.BackgroundImage = Extensions.ByteArrayToImage(userInfoDTO.Avatar);
            this.labelUsername.Text = presentedAccount.Username;
            this.labelRole.Text = "Role: " + presentedAccount.RoleID.ToString();
            PresentedAccount= presentedAccount;
            LogInAccount = logInAccount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditUserInfo formEditUserInfo = new FormEditUserInfo(LogInAccount, PresentedAccount);
            formEditUserInfo.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
