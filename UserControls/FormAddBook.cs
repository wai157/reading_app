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

namespace UserControls
{
    public partial class FormAddBook : Form
    {
        private readonly GenreManager _genreManager;
        public BookDTO BookToAdd { get; set; }
        public FormAddBook()
        {
            InitializeComponent();
            _genreManager = new GenreManager();
            comboBoxGenre.DataSource = _genreManager.GetAllGenres();
            BookToAdd = new BookDTO();
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
                BookToAdd.BookCover = Extensions.ImageToByteArray(image);
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBoxName.Text)
               || String.IsNullOrWhiteSpace(textBoxAuthor.Text)
               || String.IsNullOrWhiteSpace(textBoxDescription.Text))
            {

            }
            else
            {
                BookToAdd.Name = textBoxName.Text;
                BookToAdd.Author = textBoxAuthor.Text;
                BookToAdd.Description = textBoxDescription.Text;

            }
        }
    }
}
