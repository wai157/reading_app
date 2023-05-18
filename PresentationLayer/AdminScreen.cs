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
        private readonly NotificationManager _notificationManager;
        private readonly AccountDTO _logInAccount;
        public AdminScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _bookManager = new BookManager();
            _accountManager = new AccountManager();
            _bookReportManager = new BookReportManager();
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
                dataGridViewBookReports.Rows.Add(new string[] { bookReport.Id.ToString(), 
                    _accountManager.GetAccountById(bookReport.CreateAccountID).Username, 
                    _bookManager.GetBookById(bookReport.ReportedBookID).Name });
            }
            List<BookDTO> unverifiedBooks = _bookManager.GetAllUnverifiedBooks();
            foreach (BookDTO unverifiedBook in unverifiedBooks)
            {
                dGVUnverifiedBooks.Rows.Add(new string[] { unverifiedBook.Id.ToString(),
                    _accountManager.GetAccountById(unverifiedBook.UploadAccountId).Username,
                    _bookManager.GetBookById(unverifiedBook.Id).Name });
            }
            if (_logInAccount.RoleID == 1)
            {
                List<AccountDTO> accounts = _accountManager.GetAllAccounts();
                foreach (AccountDTO account in accounts)
                {
                    ButtonAccount buttonAccount = new ButtonAccount(_logInAccount, account);
                    this.flowLayoutPanelAccounts.Controls.Add(buttonAccount);
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
                string reportId = dataGridViewBookReports.Rows[e.RowIndex].Cells[0].Value.ToString();
                int bookId = _bookReportManager.GetBookReportById(int.Parse(reportId)).ReportedBookID; 
                BookDTO book = _bookManager.GetBookById(bookId);
                BookScreen bookScreen = new BookScreen(_logInAccount, book);
                Utils.ShowScreen(ParentForm, bookScreen);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookReports.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewBookReports.SelectedRows[0];
                int reportId = int.Parse(row.Cells[0].Value.ToString());
                FormBookReportView formBookReportView = new FormBookReportView(reportId);
                formBookReportView.Show();
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
                DataGridViewRow row = dataGridViewBookReports.SelectedRows[0];
                if (MessageBox.Show("Bạn có chắc muốn xóa báo cáo này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridViewBookReports.Rows.Remove(row);
                    int reportId = int.Parse(row.Cells[0].Value.ToString());
                    _bookReportManager.DeleteBookReport(reportId);
                    MessageBox.Show("Xóa báo cáo thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DataGridViewRow row = dGVUnverifiedBooks.SelectedRows[0];
            BookDTO book = _bookManager.GetBookById(int.Parse(row.Cells[0].Value.ToString()));
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

        private void buttonVerifyAll_Click(object sender, EventArgs e)
        {                
            if (MessageBox.Show("Bạn có chắc muốn duyệt tất cả truyện?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dGVUnverifiedBooks.Rows)
                {
                    BookDTO book = _bookManager.GetBookById(int.Parse(row.Cells[0].Value.ToString()));
                    _bookManager.VerifyBook(book.Id);
                    _notificationManager.AddNotification(1, book.Id);
                }
                dGVUnverifiedBooks.Rows.Clear();
                _bookManager.VerifyAllBooks();
                MessageBox.Show("Duyệt tất cả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
