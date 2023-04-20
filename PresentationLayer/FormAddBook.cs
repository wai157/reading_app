using BusinessLogicLayer;
using Common;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormAddBook : Form
    {
        private readonly GenreManager _genreManager;
        private readonly BookManager _bookManager;
        private readonly BookDTO _bookToAdd;
        private readonly AccountDTO _uploadAccount;
        public FormAddBook(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _uploadAccount = logInAccountDTO;
            _genreManager = new GenreManager();
            _bookManager = new BookManager();
            comboBoxGenre.DataSource = _genreManager.GetAllGenres();
            _bookToAdd = new BookDTO();
        }

        private void buttonSelectCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = fileDialog.FileName;
                Bitmap image = new Bitmap(fileName);
                pictureBoxCover.BackgroundImage = image;
            }
        }

        private void FormAddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                ValidateChildren(ValidationConstraints.Enabled);
                if (string.IsNullOrEmpty(errorProvider.GetError(textBoxName)) == false
                    || string.IsNullOrEmpty(errorProvider.GetError(textBoxAuthor)) == false
                    || string.IsNullOrEmpty(errorProvider.GetError(textBoxDescription)) == false
                    || string.IsNullOrEmpty(errorProvider.GetError(buttonSelectCover)) == false)
                {
                    MessageBox.Show("Không được bỏ trống những vùng bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    _bookToAdd.Name = textBoxName.Text;
                    _bookToAdd.Author = textBoxAuthor.Text;
                    _bookToAdd.Description = textBoxDescription.Text;
                    _bookToAdd.BookCover = Extensions.ImageToByteArray(pictureBoxCover.BackgroundImage);
                    _bookToAdd.Genre = comboBoxGenre.SelectedItem.ToString();
                    _bookToAdd.UploadAccountId = _uploadAccount.Id;
                    _bookManager.AddBook(_bookToAdd);
                    MessageBox.Show("Thêm sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = false;
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Hủy thêm sách!", "Hủy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Vui lòng nhập tên sách!");
            }
            else
            {
                errorProvider.SetError(textBoxName, null);
            }
        }

        private void textBoxAuthor_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAuthor.Text))
            {
                errorProvider.SetError(textBoxAuthor, "Vui lòng nhập tên tác giả!");
            }
            else
            {
                errorProvider.SetError(textBoxAuthor, null);
            }
        }

        private void textBoxDescription_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                errorProvider.SetError(textBoxDescription, "Vui lòng nhập nội dung sách!");
            }
            else
            {
                errorProvider.SetError(textBoxDescription, null);
            }
        }

        private void pictureBoxCover_Validated(object sender, EventArgs e)
        {
            if (pictureBoxCover.BackgroundImage == null)
            {
                errorProvider.SetError(buttonSelectCover, "Vui lòng chọn bìa sách!");
            }
            else
            {
                errorProvider.SetError(buttonSelectCover, null);
            }
        }
    }
}
