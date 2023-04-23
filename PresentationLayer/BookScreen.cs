using BusinessLogicLayer;
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
    public partial class BookScreen : UserControl
    {
        private readonly ChapterManager _chapterManager;
        private readonly GenreManager _genreManager;
        private readonly AccountDTO _logInAccount;
        private readonly BookDTO _book;
        public BookScreen(AccountDTO logInAccount, BookDTO book)
        {
            InitializeComponent();
            _chapterManager = new ChapterManager();
            _genreManager = new GenreManager();
            _logInAccount = logInAccount;
            if (book != null)
            {
                _book = book;
                pictureBoxCover.Image = Image.FromStream(new MemoryStream(book.BookCover));
                pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                labelViews.Text = $"Lượt đọc: {book.Views}";
                labelRating.Text = $"Đánh giá: {book.Rating}";
                labelFollowed.Text = $"Lượt theo dõi: {book.Follows}";
                labelName.Text = book.Name;
                labelAuthor.Text = "Tác giả: " + book.Author;
                labelDescription.Text = "Nội dung: " + book.Description;
                labelGenres.Text = "Thể loại: " + _genreManager.GetGenreById(book.GenreId).Name;
                if (_logInAccount.RoleID == 1)
                {
                    this.flowLayoutPanelChapters.Controls.Add(this.buttonAddChap);
                    this.buttonEdit.Visible = true;
                    this.buttonEdit.Enabled = true;
                }
                List<ChapterDTO> chapters = _chapterManager.GetAllChapters(book);
                int X = buttonAddChap.Location.X;
                int Y = buttonAddChap.Location.Y + buttonAddChap.Size.Height + 3;
                foreach (ChapterDTO chapter in chapters)
                {
                    ButtonChapter buttonChapter = new ButtonChapter(book, chapter)
                    {
                        Location = new Point(X, Y)
                    };
                    Y += buttonChapter.Size.Height + 3;
                    this.flowLayoutPanelChapters.Controls.Add(buttonChapter);
                }
            }
        }

        private void buttonAddChap_Click(object sender, EventArgs e)
        {
            using (FormAddChap formAddChap = new FormAddChap(_book))
            {
                formAddChap.ShowDialog();
            }
        }

        private void buttonChangeGeneralInfo_Click(object sender, EventArgs e)
        {
            using (FormEditBook formEditBook = new FormEditBook(_book))
            {
                formEditBook.ShowDialog();
                if (_book.Id == -1)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }
    }
}
