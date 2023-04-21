using BusinessLogicLayer;
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
    public partial class FormEditUserInfo : Form
    {
        private readonly AccountDTO _uploadAccount;
        private readonly AccountDTO _presentedAccount;
        public FormEditUserInfo(AccountDTO logInAccountDTO, AccountDTO presentedAccount)          
        {
            InitializeComponent();
            _uploadAccount = logInAccountDTO;
            _presentedAccount = presentedAccount;
            radioButtonMale.Checked = true;
            
            if (logInAccountDTO.RoleID != 1)
            {
                labelRole.Visible= false;
                comboBoxRole.Visible= false;
                buttonDelete.Visible= false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked = radioButtonMale.Checked;
            string sex;
            if (isChecked)
            {
                sex= radioButtonMale.Text;
            }
            else sex= radioButtonFemale.Text;
            UserInfoDTO userInfoDTO = new UserInfoDTO()
            {
                Id = _uploadAccount.Id,
                Name = textBoxName.Text,
                DOB = dateTimePickerDOB.Value,
                Sex = sex                  
            };
            

        }

        private void button2_Click(object sender, EventArgs e)
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
            
        }
    }
}
