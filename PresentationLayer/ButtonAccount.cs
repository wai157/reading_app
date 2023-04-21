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
        public AccountDTO LogInAccount { get; set; }
        public AccountDTO PresentedAccount { get; set; }
        public ButtonAccount(AccountDTO logInAccount, AccountDTO presentedAccount)
        {
            InitializeComponent();
            //this.pictureBox1.BackgroundImage = Image.FromStream(new MemoryStream(account.Avatar));
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
