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
    public partial class Header : UserControl
    {
        private AccountDTO LogInAccount { get; set; }
        public Header()
        {
            InitializeComponent();
        }
        
        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (LogInAccount == null)
            {
                MainScreen mainScreen = new MainScreen(LogInAccount);
                Utils.ShowScreen(ParentForm, mainScreen);
                return;
            }
            if (LogInAccount.RoleID != 3)
            {
                AdminScreen adminScreen = new AdminScreen(LogInAccount);
                Utils.ShowScreen(ParentForm, adminScreen);
            }
            else if (LogInAccount.RoleID == 3)
            {
                MainScreen mainScreen = new MainScreen(LogInAccount);
                Utils.ShowScreen(ParentForm, mainScreen);
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
            UserProfileScreen userProfileScreen = new UserProfileScreen(LogInAccount);
            Utils.ShowScreen(ParentForm, userProfileScreen);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text) == false && textBoxSearch.ForeColor != Color.Gray)
            {
                GeneralScreen searchResultScreen = new GeneralScreen(0, textBoxSearch.Text);
                Utils.ShowScreen(ParentForm, searchResultScreen);
            }
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            bool opened = false;
            foreach (Control childControl in ParentForm.Controls)
            {
                if (childControl is FormNotifications childForm)
                {
                    childForm.Close();
                    childForm.Dispose();
                    opened = true;
                    break;
                }
            }
            if (!opened)
            {
                if (LogInAccount == null)
                {
                    MessageBox.Show("Bạn cần đăng nhập để có thể thực hiện chức năng này.");
                    return;
                }
                FormNotifications formNotifications = new FormNotifications(LogInAccount.Id)
                {
                    TopLevel = false
                };
                ParentForm.Controls.Add(formNotifications);
                formNotifications.BringToFront();
                formNotifications.Location = new Point(this.buttonNotification.Location.X-363, 62);
                formNotifications.Show();
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (LogInAccount == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để có thể thực hiện chức năng này.");
                return;
            }
            using (FormAddBook formAddBook = new FormAddBook(LogInAccount))
            {
                formAddBook.ShowDialog();
            }
        }

        private void Header_Load(object sender, EventArgs e)
        {
            FormReadingApp formReadingApp = ParentForm as FormReadingApp;
            LogInAccount = formReadingApp.LogInAccountDTO;
            if (LogInAccount == null)
            {
                buttonUserProfile.Enabled = false;
                buttonUserProfile.Visible = false;
                buttonLogIn.Enabled = true;
                buttonLogIn.Visible = true;
            }
            else
            {
                buttonUserProfile.Enabled = true;
                buttonUserProfile.Visible = true;
                buttonLogIn.Enabled = false;
                buttonLogIn.Visible = false;
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            LogInScreen logInScreen = new LogInScreen();
            Utils.ShowScreen(ParentForm, logInScreen);
        }
    }
}
