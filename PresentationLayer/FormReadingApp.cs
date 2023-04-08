using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormReadingApp : Form
    {
        private readonly AccountManager _accountManager;
        private Account logInAccount = new Account();

        public FormReadingApp()
        {
            InitializeComponent();
            _accountManager = new AccountManager(new AccountRepository(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString));
        }

        private void FormReadingApp_Load(object sender, EventArgs e)
        {
            logInScreen.ButtonLogIn.Click += new EventHandler(buttonLogIn_Click);
        }
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (logInScreen.TextBoxUsername.ForeColor != Color.Black || logInScreen.TextBoxPassword.ForeColor != Color.Black
                || string.IsNullOrEmpty(logInScreen.TextBoxUsername.Text) || string.IsNullOrEmpty(logInScreen.TextBoxPassword.Text)) return;
            string username = logInScreen.TextBoxUsername.Text;
            string password = logInScreen.TextBoxPassword.Text;
            bool matchAccount = false;
            var accounts = _accountManager.GetAllAccounts();
            foreach (Account account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    matchAccount = true;
                    logInAccount = account;
                    break;
                }
            }
            if (matchAccount == true)
            {
                this.mainScreen.BringToFront();
                this.AcceptButton = null;
            }
            else
            {

            }
        }
    }
}
