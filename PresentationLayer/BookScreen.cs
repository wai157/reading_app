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
        private readonly HistoryManager _historyManager;
        private readonly LibraryManager _libraryManager;
        private readonly RatedBookManager _ratedBookManager;
        private readonly AccountDTO _logInAccount;
        private readonly BookDTO _book;
        private readonly HistoryDTO _history;
        private LibraryDTO _library;
        public BookScreen(AccountDTO logInAccount, BookDTO book)
        {
            InitializeComponent();
            _chapterManager = new ChapterManager();
            _genreManager = new GenreManager();
            _historyManager = new HistoryManager();
            _libraryManager = new LibraryManager();
            _ratedBookManager = new RatedBookManager();
            _logInAccount = logInAccount;
            if (book == null)
            {
                this.panel2.Controls.Clear();
                this.panel2.Controls.Add(this.labelError);
                return;
            }
            _book = book;
            pictureBoxCover.Image = Image.FromStream(new MemoryStream(book.BookCover));
            pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
            labelViews.Text = $"Lượt đọc: {book.Views}";
            labelRating.Text = $"Đánh giá: {book.Rating}";
            labelFollowed.Text = $"Lượt theo dõi: {book.Follows}";
            labelName.Text = book.Name;
            linkLabelAuthor.Text = book.Author;
            labelDescription.Text = "Nội dung: " + book.Description;
            linkLabelGenre.Text = _genreManager.GetGenreById(book.GenreId).Name;
            if (_logInAccount != null)
            {
                if (_logInAccount.Id == book.UploadAccountId)
                {
                    this.flowLayoutPanelChapters.Controls.Add(this.buttonAddChap);
                    this.buttonEdit.Visible = true;
                    this.buttonEdit.Enabled = true;
                }
                if (_logInAccount.RoleID != 3)
                {
                    this.buttonEdit.Visible = true;
                    this.buttonEdit.Enabled = true;
                }
                _history = _historyManager.GetHistoryOfBook(_logInAccount.Id, _book.Id);
                bool inLibrary = _libraryManager.GetLibraryByAccountId(_logInAccount.Id)
                                            .Where(x => x.BookId == _book.Id)
                                            .Count() > 0;
                if (inLibrary == true)
                {
                    btdFollow.Text = "Hủy theo dõi";
                    _library = _libraryManager.GetLibraryByAccountId(_logInAccount.Id).FirstOrDefault(x => x.BookId == _book.Id);
                }
                else
                {
                    _library = null;
                }
            }
            List<ChapterDTO> chapters = _chapterManager.GetAllVerifiedChaptersOf(book);
            
            if (_history != null && chapters.Count !=0)
            {
                btnRead.Text = "Đọc tiếp";
            }
            if (chapters.Count == 0)
            {
                btnRead.Enabled = false;
            }
            foreach (ChapterDTO chapter in chapters)
            {

                ButtonChapter buttonChapter = new ButtonChapter(_logInAccount, book, chapter);
                if (_history != null && _history.ReadChapterIds.Contains(chapter.Id))
                {
                    buttonChapter.ForeColor = Color.Gray;
                }
                this.flowLayoutPanelChapters.Controls.Add(buttonChapter);
            }
            

            double rating = _ratedBookManager.GetRatingListByBookId(_book.Id, out int count);
            this.labelRating.Text = "Đánh giá: " + rating.ToString("F1") + "/5 (" + count.ToString() + " lượt)";
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
                if (_book.Id != -1 && formEditBook.DialogResult != DialogResult.OK)
                {
                    return;
                }
                if (_logInAccount.RoleID != 3)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
                else if (_logInAccount.RoleID == 3)
                {
                    MainScreen mainScreen = new MainScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, mainScreen);
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                ChapterDTO chapterDTO = new ChapterDTO();
                if (_history != null)
                {
                    chapterDTO = _chapterManager.GetChapterById(_history.ReadChapterIds.Last());
                }
                else
                {
                    chapterDTO = _chapterManager.GetAllVerifiedChaptersOf(_book).Last();
                }
                ChapterScreen chapterScreen = new ChapterScreen(_logInAccount, _book, chapterDTO);
                Utils.ShowScreen(ParentForm, chapterScreen);
            }
            catch (Exception)
            {
                MessageBox.Show("Truyện không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                if (_logInAccount == null || _logInAccount.RoleID == 3)
                {
                    MainScreen mainScreen = new MainScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, mainScreen);
                }
                else if (_logInAccount.RoleID != 3)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }

        private void btdFollow_Click(object sender, EventArgs e)
        {
            if (_logInAccount == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để có thể thực hiện chức năng này.");
                return;
            }
            try
            {
                if (_library == null)
                {
                    _libraryManager.AddLibrary(_logInAccount.Id, _book.Id);
                    _library = _libraryManager.GetLibraryByAccountId(_logInAccount.Id).FirstOrDefault(x => x.BookId == _book.Id);
                    btdFollow.Text = "Hủy theo dõi";
                    _book.Follows += 1;
                }
                else
                {
                    _libraryManager.DeleteLibrary(_library.Id);
                    _library = null;
                    btdFollow.Text = "Theo dõi";
                    _book.Follows -= 1;
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("Truyện không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                if (_logInAccount.RoleID != 3)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
                else if (_logInAccount.RoleID == 3)
                {
                    MainScreen mainScreen = new MainScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, mainScreen);
                }
            }
            labelFollowed.Text = "Lượt theo dõi: " + _book.Follows;
        }

        private void linkLabelGenre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GeneralScreen searchResultScreen = new GeneralScreen(1, _book.GenreId.ToString());
            Utils.ShowScreen(ParentForm, searchResultScreen);
        }

        private void linkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GeneralScreen searchResultScreen = new GeneralScreen(2, _book.Author);
            Utils.ShowScreen(ParentForm, searchResultScreen);
        }

        private void linkLabelReport_Click(object sender, EventArgs e)
        {
            if (_logInAccount == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để có thể thực hiện chức năng này.");
                return;
            }
            try
            {
                using (FormReport formReport = new FormReport(_logInAccount.Id, _book.Id))
                {
                    formReport.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Truyện không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                if (_logInAccount.RoleID != 3)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
                else if (_logInAccount.RoleID == 3)
                {
                    MainScreen mainScreen = new MainScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, mainScreen);
                }
            }
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            if (_logInAccount == null)
            {
                MessageBox.Show("Bạn cần đăng nhập để có thể thực hiện chức năng này.");
                return;
            }
            try
            {
                using (FormRating formRating = new FormRating(_logInAccount.Id, _book.Id))
                {
                    formRating.ShowDialog();
                    if (formRating.DialogResult == DialogResult.OK)
                    {
                        double rating = _ratedBookManager.GetRatingListByBookId(_book.Id, out int count);
                        this.labelRating.Text = "Đánh giá: " + rating.ToString("F1") + "/5 (" + count.ToString() + " lượt)";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Truyện không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                if (_logInAccount.RoleID != 3)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
                else if (_logInAccount.RoleID == 3)
                {
                    MainScreen mainScreen = new MainScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, mainScreen);
                }
            }

        }
    }
}
