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
        public Header()
        {
            InitializeComponent();
        }
        
        private void buttonHome_Click(object sender, EventArgs e)
        {
            FormReadingApp formReadingApp = ParentForm as FormReadingApp;
            if (formReadingApp.LogInAccountDTO.RoleID == 1)
            {
                AdminScreen adminScreen = new AdminScreen(formReadingApp.LogInAccountDTO);
                Utils.ShowScreen(ParentForm, adminScreen);
            }
            else if (formReadingApp.LogInAccountDTO.RoleID == 3)
            {
                MainScreen mainScreen = new MainScreen(formReadingApp.LogInAccountDTO);
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
            FormReadingApp formReadingApp = ParentForm as FormReadingApp;
            UserProfileScreen userProfileScreen = new UserProfileScreen(formReadingApp.LogInAccountDTO);
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
    }
}
