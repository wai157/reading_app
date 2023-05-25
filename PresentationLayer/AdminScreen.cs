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
    public partial class AdminScreen : UserControl
    {
        private readonly BookManager _bookManager;
        private readonly AccountManager _accountManager;
        private readonly BookReportManager _bookReportManager;
        private readonly ChapterManager _chapterManager;
        private readonly NotificationManager _notificationManager;
        private readonly AccountDTO _logInAccount;
        public AdminScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _bookManager = new BookManager();
            _accountManager = new AccountManager();
            _bookReportManager = new BookReportManager();
            _chapterManager = new ChapterManager();
            
            _notificationManager = new NotificationManager();
            _logInAccount = logInAccountDTO;
            List<BookDTO> books = _bookManager.GetAllVerifiedBooks();
            foreach (BookDTO book in books)
            {
                ButtonBookCover bookCover = new ButtonBookCover(book);
                this.flowLayoutPanelBooks.Controls.Add(bookCover);
            }
            List<BookReportDTO> bookReports = _bookReportManager.GetAllBookReports();
            foreach (BookReportDTO bookReport in bookReports)
            {
                dataGridViewBookReports.Rows.Add(new string[] {
                    bookReport.Id.ToString(), 
                    _accountManager.GetAccountById(bookReport.CreateAccountID).Username, 
                    _bookManager.GetBookById(bookReport.ReportedBookID).Name 
                });
            }
            List<BookDTO> unverifiedBooks = _bookManager.GetAllUnverifiedBooks();
            foreach (BookDTO unverifiedBook in unverifiedBooks)
            {
                dGVUnverifiedBooks.Rows.Add(new string[] { 
                    unverifiedBook.Id.ToString(),
                    _accountManager.GetAccountById(unverifiedBook.UploadAccountId).Username,
                    _bookManager.GetBookById(unverifiedBook.Id).Name 
                });
            }
            List<ChapterDTO> unverifiedChapters = _chapterManager.GetAllUnverifiedChapters();
            foreach(ChapterDTO unverifiedChapter in unverifiedChapters)
            {
                BookDTO book = _bookManager.GetBookById(unverifiedChapter.BookId);
                dGVUnverifiedChapters.Rows.Add(new string[]
                {
                    unverifiedChapter.Id.ToString(),
                    _accountManager.GetAccountById(book.UploadAccountId).Username,
                    book.Name,
                    unverifiedChapter.No.ToString()
                });
            }

            if (_logInAccount.RoleID == 1)
            {
                List<AccountDTO> accounts = _accountManager.GetAllAccounts();
                foreach (AccountDTO account in accounts)
                {
                    UserInfoDTO userInfo = _accountManager.GetUserInfo(account.Id);
                    dGVUsers.Rows.Add(new string[]
                    {
                        account.Username,
                        account.Email,
                        userInfo.Name,
                        userInfo.Sex,
                        userInfo.DOB.ToString(),
                        account.RoleID == 1 ? "admin" : account.RoleID == 2 ? "mod" : "user"
                    });
                }
            }
            else
            {
                tabControl1.TabPages.Remove(tabPageUsers);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBookReports.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                try
                {
                    string reportId = dataGridViewBookReports.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int bookId = _bookReportManager.GetBookReportById(int.Parse(reportId)).ReportedBookID;
                    BookDTO book = _bookManager.GetBookById(bookId);
                    BookScreen bookScreen = new BookScreen(_logInAccount, book);
                    Utils.ShowScreen(ParentForm, bookScreen);
                }
                catch (Exception)
                {
                    MessageBox.Show("Truyện đã bị xóa!", "Lỗi", MessageBoxButtons.OK);
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookReports.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewBookReports.SelectedRows[0];
                    int reportId = int.Parse(row.Cells[0].Value.ToString());
                    FormBookReportView formBookReportView = new FormBookReportView(reportId);
                    formBookReportView.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Báo cáo đã được xử lí!", "Lỗi", MessageBoxButtons.OK);
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một báo cáo để xem!");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookReports.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dataGridViewBookReports.SelectedRows[0];
                    if (MessageBox.Show("Bạn có chắc muốn xóa báo cáo này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dataGridViewBookReports.Rows.Remove(row);
                        int reportId = int.Parse(row.Cells[0].Value.ToString());
                        _bookReportManager.DeleteBookReport(reportId);
                        MessageBox.Show("Xóa báo cáo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Báo cáo đã được xử lí!", "Lỗi", MessageBoxButtons.OK);
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một báo cáo để xóa!");
            }
        }

        private void buttonViewVerify_Click(object sender, EventArgs e)
        {
            if (dGVUnverifiedBooks.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sách để xem!");
                return;
            }
            try
            {
                DataGridViewRow row = dGVUnverifiedBooks.SelectedRows[0];
                BookDTO book = _bookManager.GetBookById(int.Parse(row.Cells[0].Value.ToString()));
                if (book.IsVerified == true)
                {
                    throw new Exception();
                }
                using (FormBookVerification formBookVerification = new FormBookVerification(book))
                {
                    formBookVerification.ShowDialog();
                    if (formBookVerification.DialogResult == DialogResult.Yes)
                    {
                        _bookManager.VerifyBook(book.Id);
                        _notificationManager.AddNotification(1, book.Id);
                        dGVUnverifiedBooks.Rows.Remove(row);
                        MessageBox.Show("Duyệt sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (formBookVerification.DialogResult == DialogResult.No)
                    {
                        dGVUnverifiedBooks.Rows.Remove(row);
                        _notificationManager.AddNotification(-1, book.Id, formBookVerification.Reason);
                        _bookManager.DeleteBook(book.Id);
                        MessageBox.Show("Sách đã không được duyệt!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yêu cầu đã được xử lí!", "Lỗi", MessageBoxButtons.OK);
                AdminScreen adminScreen = new AdminScreen(_logInAccount);
                Utils.ShowScreen(ParentForm, adminScreen);
            }
        }

        private void buttonVerifyAll_Click(object sender, EventArgs e)
        {                
            if (MessageBox.Show("Bạn có chắc muốn duyệt tất cả truyện?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dGVUnverifiedBooks.Rows)
                    {
                        BookDTO book = _bookManager.GetBookById(int.Parse(row.Cells[0].Value.ToString()));
                        _bookManager.VerifyBook(book.Id);
                        _notificationManager.AddNotification(1, book.Id);
                    }
                    dGVUnverifiedBooks.Rows.Clear();
                    MessageBox.Show("Duyệt tất cả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Có một số yêu cầu đã được xử lí!", "Lỗi", MessageBoxButtons.OK);
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dGVUnverifiedChapters.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sách để xem!");
                return;
            }
            try
            {
                DataGridViewRow row = dGVUnverifiedChapters.SelectedRows[0];
                ChapterDTO chapter = _chapterManager.GetChapterById(int.Parse(row.Cells[0].Value.ToString()));
                if (chapter.IsVerified == true)
                {
                    throw new NullReferenceException();
                }
                using (FormChapterVerification formChapterVerification = new FormChapterVerification(chapter))
                {
                    formChapterVerification.ShowDialog();
                    if (formChapterVerification.DialogResult == DialogResult.Yes)
                    {
                        _chapterManager.VerifyChapter(chapter.Id);
                        _notificationManager.AddNotification(2, chapter.BookId);
                        _notificationManager.AddNotification(3, chapter.BookId, "", chapter.Id);
                        dGVUnverifiedChapters.Rows.Remove(row);
                        MessageBox.Show("Duyệt chương thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (formChapterVerification.DialogResult == DialogResult.No)
                    {
                        dGVUnverifiedChapters.Rows.Remove(row);
                        _notificationManager.AddNotification(-3, chapter.BookId, formChapterVerification.Reason, chapter.Id);
                        _chapterManager.DeleteChapter(chapter.Id);
                        MessageBox.Show("Chương đã không được duyệt!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Yêu cầu đã được xử lí!", "Lỗi", MessageBoxButtons.OK);
                AdminScreen adminScreen = new AdminScreen(_logInAccount);
                Utils.ShowScreen(ParentForm, adminScreen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void buttonVerifyAllChapters_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn duyệt tất cả chương?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dGVUnverifiedChapters.Rows)
                    {
                        ChapterDTO chapter = _chapterManager.GetChapterById(int.Parse(row.Cells[0].Value.ToString()));
                        _notificationManager.AddNotification(2, chapter.BookId);
                        _notificationManager.AddNotification(3, chapter.BookId, "", chapter.Id);
                    }
                    dGVUnverifiedChapters.Rows.Clear();
                    _chapterManager.VerifyAllChapter();
                    MessageBox.Show("Duyệt tất cả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Có một số yêu cầu đã được xử lí!", "Lỗi", MessageBoxButtons.OK);
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }

        private void buttonEditUserInfo_Click(object sender, EventArgs e)
        {
            if (dGVUsers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn sách để xem!");
                return;
            }
            DataGridViewRow row = dGVUsers.SelectedRows[0];
            AccountDTO presentedAccount = _accountManager.GetAccountByUsername(row.Cells[0].Value.ToString());
            bool isSelfEdit = (_logInAccount.Id == presentedAccount.Id);
            using (FormEditUserInfo formEditUserInfo = new FormEditUserInfo(_logInAccount, presentedAccount))
            {
                try
                {
                    formEditUserInfo.ShowDialog();
                }
                catch (Exception)
                {
                    MessageBox.Show("Người dùng không tồn tại!", "Lỗi", MessageBoxButtons.OK);
                    if (_logInAccount.Id == presentedAccount.Id)
                    {
                        LogInScreen logInScreen = new LogInScreen();
                        Utils.ShowScreen(ParentForm, logInScreen);
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
                if (isSelfEdit == true && presentedAccount.Id == -1)
                {
                    MessageBox.Show("Phiên đăng nhập hết hạn!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (isSelfEdit == true && _logInAccount.RoleID != presentedAccount.RoleID)
                {
                    MessageBox.Show("Bạn vừa thay đổi phân quyền của bản thân!\nVui lòng đăng nhập lại để thay đổi có hiệu lực!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInScreen logInScreen = new LogInScreen();
                    Utils.ShowScreen(ParentForm, logInScreen);
                }
                else if (formEditUserInfo.DialogResult == DialogResult.OK || presentedAccount.Id == -1)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }
    }
}
