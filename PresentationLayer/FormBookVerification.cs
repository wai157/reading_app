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
        public string Reason { get; set; }

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
            if (this.DialogResult != DialogResult.No)
            {
                e.Cancel = false;
                return;
            }
            FormReason formReason = new FormReason();
            DialogResult confirm = formReason.ShowDialog();
            if (confirm != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Reason = formReason.Reason;
                e.Cancel = false;
            }
        }
    }
}
