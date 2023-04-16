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
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }
        
        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            LogInScreen logInScreen = parentForm.Controls.Find("logInScreen", true).First() as LogInScreen;
            if (logInScreen.LogInAccount.RoleID == 1)
            {
                AdminScreen adminScreen = parentForm.Controls.Find("adminScreen", true).First() as AdminScreen;
                Utils.ShowScreen(adminScreen);
            }
            else if (logInScreen.LogInAccount.RoleID == 3)
            {
                MainScreen mainScreen = parentForm.Controls.Find("mainScreen", true).First() as MainScreen;
                Utils.ShowScreen(mainScreen);
            }
        }

        private void textBoxSearch_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                textBoxSearch.Text = " Tìm kiếm";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void textBoxSearch_RemoveText(object sender, EventArgs e)
        {
            if (textBoxSearch.ForeColor != Color.Black)
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void buttonUserProfile_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            LogInScreen logInScreen = parentForm.Controls.Find("logInScreen", true).First() as LogInScreen;
            UserProfileScreen userProfileScreen = parentForm.Controls.Find("userProfileScreen", true).First() as UserProfileScreen;
            userProfileScreen.LoadScreen(logInScreen.LogInAccount);
            Utils.ShowScreen(userProfileScreen);
        }
    }
}
