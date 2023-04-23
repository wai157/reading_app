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
    public partial class FormEditUserInfo : Form
    {
        private readonly AccountManager _accountManager;
        private readonly AccountDTO _presentedAccount;
        private readonly UserInfoDTO _presentedUserInfo;
        public FormEditUserInfo(AccountDTO logInAccount, AccountDTO presentedAccount)          
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            _presentedAccount = presentedAccount;
            _presentedUserInfo = _accountManager.GetUserInfo(_presentedAccount.Id);
            comboBoxRole.DataSource = new List<string>{
                "Admin",
                "User"
            };
            if (logInAccount.RoleID != 1)
            {
                labelRole.Visible = false;
                comboBoxRole.Visible = false;
                buttonDelete.Visible = false;
            }
            pictureBoxAvatar.BackgroundImage = Extensions.ByteArrayToImage(_presentedUserInfo.Avatar);
            textBoxName.Text = _presentedUserInfo.Name;
            dateTimePickerDOB.Value = _presentedUserInfo.DOB;
            if (_presentedUserInfo.Sex == "Nam")
            {
                radioButtonMale.Checked = true;
            }
            else if (_presentedUserInfo.Sex == "Nữ")
            {
                radioButtonFemale.Checked = true;
            }
            else if (_presentedUserInfo.Sex == "Khác")
            {
                radioButtonOther.Checked = true;
            }
            if (_presentedAccount.RoleID == 1)
            {
                comboBoxRole.SelectedItem = "Admin";
            }
            else
            {
                comboBoxRole.SelectedItem = "User";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string sex = null;
            if (radioButtonMale.Checked)
            {
                sex = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked)
            {
                sex = radioButtonFemale.Text;
            }
            else if (radioButtonOther.Checked)
            {
                sex = radioButtonOther.Text;
            }
            _presentedUserInfo.Avatar = Extensions.ImageToByteArray(pictureBoxAvatar.BackgroundImage);
            _presentedUserInfo.Name = textBoxName.Text;
            _presentedUserInfo.DOB = dateTimePickerDOB.Value;
            _presentedUserInfo.Sex = sex;
            if (comboBoxRole.SelectedItem.ToString() == "Admin")
            {
                _presentedAccount.RoleID = 1;
            }
            else if(comboBoxRole.SelectedItem.ToString() == "User")
            {
                _presentedAccount.RoleID = 3;
            }
            _accountManager.UpdateUserInfo(_presentedAccount, _presentedUserInfo);
            MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void buttonSelectAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    Bitmap image = new Bitmap(fileName);
                    pictureBoxAvatar.BackgroundImage = image;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _accountManager.DeleteAccount(_presentedAccount.Id);
                _presentedAccount.Id = -1;
                MessageBox.Show("Xóa tài khoản thành công!", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
