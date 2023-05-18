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
    public partial class FormBookVerification : Form
    {
        private readonly GenreManager _genreManager;
        public FormBookVerification(BookDTO book)
        {
            InitializeComponent();
            _genreManager = new GenreManager();
            labelName.Text = "Tên sách: " + book.Name;
            labelAuthor.Text = "Tác giả: " + book.Author;
            labelGenre.Text = "Thể loại: " + _genreManager.GetGenreById(book.GenreId).Name;
            textBoxDescription.Text = book.Description;
            pictureBoxCover.BackgroundImage = Extensions.ByteArrayToImage(book.BookCover);
        }

        private void FormBookVerification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.No)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc không duyệt truyện này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
