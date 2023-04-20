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
        private readonly int _roleId;
        private readonly BookDTO _book;
        public BookScreen(int roleId, BookDTO book)
        {
            InitializeComponent();
            _chapterManager = new ChapterManager();
            if (book != null)
            {
                _roleId = roleId;
                _book = book;
                pictureBoxCover.Image = Image.FromStream(new MemoryStream(book.BookCover));
                pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                labelViews.Text = $"Lượt đọc: {book.Views}";
                labelRating.Text = $"Đánh giá: {book.Rating}";
                labelFollowed.Text = $"Lượt theo dõi: {book.Follows}";
                labelName.Text = book.Name;
                labelAuthor.Text = "Tác giả: " + book.Author;
                labelDescription.Text = "Nội dung: " + book.Description;
                labelGenres.Text = "Thể loại: " + book.Genre;
                if (roleId == 1)
                    this.flowLayoutPanelChapters.Controls.Add(this.buttonAddChap);
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
            FormAddChap formAddChap = new FormAddChap(_book);
            formAddChap.ShowDialog();
        }
    }
}
