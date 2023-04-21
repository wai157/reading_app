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
        private readonly AccountDTO _logInAccount;
        private readonly AccountDTO _presentedAccount;
        private readonly UserInfoDTO _presentedUserInfo;
        public FormEditUserInfo(AccountDTO logInAccount, AccountDTO presentedAccount)          
        {
            InitializeComponent();
            _accountManager = new AccountManager();
            _logInAccount = logInAccount;
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
            Bitmap image = new Bitmap(pictureBoxAvatar.BackgroundImage);
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                _presentedUserInfo.Avatar = Extensions.ImageToByteArray(Image.FromStream(ms));
            }
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
            if (_logInAccount.Id == _presentedAccount.Id && _logInAccount.RoleID != _presentedAccount.RoleID)
            {
                MessageBox.Show("Bạn vừa thay đổi phân quyền của bản thân!\nVui lòng đăng nhập lại để thay đổi có hiệu lực!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Cập nhật thông tin thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSelectAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Bitmap image = new Bitmap(fileName);
                pictureBoxAvatar.BackgroundImage = image;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa tài khoản này!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                MessageBox.Show("Xóa tài khoản thành công!", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
