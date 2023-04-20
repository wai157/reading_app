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
        public AccountDTO PresentedAccount { get; set; }
        public ButtonAccount(AccountDTO account)
        {
            InitializeComponent();
            //this.pictureBox1.BackgroundImage = Image.FromStream(new MemoryStream(account.Avatar));
            this.labelUsername.Text = account.Username;
            this.labelRole.Text = "Role: " + account.RoleID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAccount formAccount = new FormAccount();
            formAccount.Show();
        }
    }
}
