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
    public partial class FormEditBook : Form
    {
        private readonly GenreManager _genreManager;
        private readonly BookManager _bookManager;
        private readonly BookDTO _book;
        public FormEditBook(BookDTO book)
        {
            InitializeComponent();
            _genreManager = new GenreManager();
            _bookManager = new BookManager();
            _book = book;
            comboBoxGenre.DataSource = _genreManager.GetAllGenres();
            comboBoxGenre.DisplayMember = "Name";
            comboBoxGenre.ValueMember = "Id";
            comboBoxGenre.SelectedValue = _book.GenreId;
            textBoxName.Text = _book.Name;
            textBoxAuthor.Text = _book.Author;
            textBoxDescription.Text = _book.Description;
            pictureBoxCover.BackgroundImage = Extensions.ByteArrayToImage(_book.BookCover);
        }

        private void buttonSelectCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png)|*.bmp;*.jpg;*.jpeg;*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = fileDialog.FileName;
                    Bitmap image = new Bitmap(fileName);
                    pictureBoxCover.BackgroundImage = image;
                }
            }
        }

        private void FormEditBook_FormClosing(object sender, FormClosingEventArgs e)
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
                    _book.BookCover = Extensions.ImageToByteArray(pictureBoxCover.BackgroundImage);
                    _book.Name = textBoxName.Text;
                    _book.Author = textBoxAuthor.Text;
                    _book.Description = textBoxDescription.Text;
                    _book.GenreId = (int)comboBoxGenre.SelectedValue;
                    _bookManager.UpdateBook(_book);
                    MessageBox.Show("Chỉnh sửa sách thành công!\n Sách đã được gửi đi để kiểm duyệt!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = false;
                    this.Dispose();
                }
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

        private void buttonSelectCover_Validated(object sender, EventArgs e)
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa sách này!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bookManager.DeleteBook(_book.Id);
                _book.Id = -1;
                MessageBox.Show("Xóa sách thành công!", "Xóa sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
