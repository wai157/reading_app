using BusinessLogicLayer;
using Common;
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
        private readonly HistoryManager _historyManager;
        private readonly LibraryManager _libraryManager;
        private readonly BookManager _bookManager;
        private readonly AccountDTO _logInAccount;
        public UserProfileScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            _historyManager = new HistoryManager();
            _libraryManager = new LibraryManager();
            _bookManager = new BookManager();
            _logInAccount = logInAccountDTO;
            List<HistoryDTO> histories = _historyManager.GetHistoryByAccountId(_logInAccount.Id);
            List<LibraryDTO> libraries = _libraryManager.GetLibraryByAccountId(_logInAccount.Id);
            UserInfoDTO userInfoDTO = _accountManager.GetUserInfo(logInAccountDTO.Id);
            if (userInfoDTO != null)
            {
                pictureBoxAvatar.BackgroundImage = Extensions.ByteArrayToImage(userInfoDTO.Avatar);
                labelName.Text = "Họ và tên: " + userInfoDTO.Name;
                labelSex.Text = "Giới tính: " + userInfoDTO.Sex;
                labelDOB.Text = "Ngày sinh: " + userInfoDTO.DOB.ToString("yyyy-MM-dd");
                labelUsername.Text = "Tên đăng nhập: " + logInAccountDTO.Username;
                labelEmail.Text = "Email: " + logInAccountDTO.Email;
            }
            foreach (HistoryDTO history in histories)
            {
                ButtonBookCover buttonBookCover = new ButtonBookCover(_bookManager.GetBookById(history.BookId));
                flowLayoutPanelHistory.Controls.Add(buttonBookCover);
            }
            foreach (LibraryDTO library in libraries)
            {
                ButtonBookCover buttonBookCover = new ButtonBookCover(_bookManager.GetBookById(library.BookId));
                flowLayoutPanelLibrary.Controls.Add(buttonBookCover);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogInScreen loginScreen = new LogInScreen();
            Utils.ShowScreen(ParentForm, loginScreen);
        }

        private void textBox_RemoveText(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.ForeColor != Color.Black)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = '*';
            }
        }

        private void textBoxConfirmNewPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxConfirmNewPassword.Text))
            {
                textBoxConfirmNewPassword.Text = "Xác nhận mật khẩu mới";
                textBoxConfirmNewPassword.ForeColor = Color.Gray;
                textBoxConfirmNewPassword.PasswordChar = '\0';
            }
        }

        private void textBoxNewPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                textBoxNewPassword.Text = "Mật khẩu mới";
                textBoxNewPassword.ForeColor = Color.Gray;
                textBoxNewPassword.PasswordChar = '\0';
            }
        }

        private void textBoxCurrentPassword_AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCurrentPassword.Text))
            {
                textBoxCurrentPassword.Text = "Mật khẩu hiện tại";
                textBoxCurrentPassword.ForeColor = Color.Gray;
                textBoxCurrentPassword.PasswordChar = '\0';
            }
        }

        private void buttonChangeGeneralInfo_Click(object sender, EventArgs e)
        {
            int prevRoleId = _logInAccount.RoleID;
            using (FormEditUserInfo editUserInfoScreen = new FormEditUserInfo(_logInAccount, _logInAccount))
            {
                editUserInfoScreen.ShowDialog();
                if (_logInAccount.Id == -1)
                {
                    MessageBox.Show("Phiên đăng nhập hết hạn!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (_logInAccount.RoleID != prevRoleId)
                {
                    MessageBox.Show("Bạn vừa thay đổi phân quyền của bản thân!\nVui lòng đăng nhập lại để thay đổi có hiệu lực!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (editUserInfoScreen.DialogResult == DialogResult.OK)
                {
                    UserProfileScreen userProfileScreen = new UserProfileScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, userProfileScreen);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxCurrentPassword.ForeColor == Color.Gray || string.IsNullOrEmpty(textBoxCurrentPassword.Text))
            {
                errorProvider.SetError(textBoxCurrentPassword, "Vui lòng nhập mật khẩu hiện tại!");
            }
            else
            {
                errorProvider.SetError(textBoxCurrentPassword, null);
            }

            if (textBoxNewPassword.ForeColor == Color.Gray || string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                errorProvider.SetError(textBoxNewPassword, "Vui lòng nhập mật khẩu mới!");
            }
            else
            {
                errorProvider.SetError(textBoxNewPassword, null);
            }

            if (textBoxConfirmNewPassword.ForeColor == Color.Gray || string.IsNullOrEmpty(textBoxConfirmNewPassword.Text))
            {
                errorProvider.SetError(textBoxConfirmNewPassword, "Vui lòng nhập lại mật khẩu!");
            }
            else if (textBoxConfirmNewPassword.Text != textBoxNewPassword.Text)
            {
                errorProvider.SetError(textBoxConfirmNewPassword, "Mật khẩu nhập lại không đúng!");
            }
            else 
            {
                errorProvider.SetError(textBoxConfirmNewPassword, null);
            }

            ValidateChildren(ValidationConstraints.Enabled);
            if (string.IsNullOrEmpty(errorProvider.GetError(textBoxCurrentPassword))
                && string.IsNullOrEmpty(errorProvider.GetError(textBoxNewPassword))
                && string.IsNullOrEmpty(errorProvider.GetError(textBoxConfirmNewPassword)))
            {
                bool res = _accountManager.ChangePassword(_logInAccount.Id, textBoxCurrentPassword.Text, textBoxConfirmNewPassword.Text);
                if (res != true)
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonAccountInfo_Click(object sender, EventArgs e)
        {
            flowLayoutPanelHistory.Visible = false;
            flowLayoutPanelHistory.Enabled = false;
            flowLayoutPanelLibrary.Visible = false;
            flowLayoutPanelLibrary.Enabled = false;
            panelAccountInfo.Visible = true;
            panelAccountInfo.Enabled = true;
            buttonAccountInfo.BackColor = SystemColors.ActiveCaption;
            buttonHistory.BackColor = Color.White;
            buttonFollowed.BackColor = Color.White;
        }

        private void buttonFollowed_Click(object sender, EventArgs e)
        {
            flowLayoutPanelHistory.Visible = false;
            flowLayoutPanelHistory.Enabled = false;
            panelAccountInfo.Visible = false;
            panelAccountInfo.Enabled = false;
            flowLayoutPanelLibrary.Visible = true;
            flowLayoutPanelLibrary.Enabled = true;
            buttonFollowed.BackColor = SystemColors.ActiveCaption;
            buttonHistory.BackColor = Color.White;
            buttonAccountInfo.BackColor = Color.White;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            panelAccountInfo.Visible = false;
            panelAccountInfo.Enabled = false;
            flowLayoutPanelLibrary.Visible = false;
            flowLayoutPanelLibrary.Enabled = false;
            flowLayoutPanelHistory.Visible = true;
            flowLayoutPanelHistory.Enabled = true;
            buttonHistory.BackColor = SystemColors.ActiveCaption;
            buttonAccountInfo.BackColor = Color.White;
            buttonFollowed.BackColor = Color.White;
        }
    }
}
