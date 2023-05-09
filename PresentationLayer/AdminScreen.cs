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
        private readonly AccountDTO _logInAccount;
        public AdminScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _bookManager = new BookManager();
            _accountManager = new AccountManager();
            _bookReportManager = new BookReportManager();
            _logInAccount = logInAccountDTO;
            List<BookDTO> books = _bookManager.GetAllBooks();
            foreach (BookDTO book in books)
            {
                ButtonBookCover bookCover = new ButtonBookCover(book);
                this.flowLayoutPanelBooks.Controls.Add(bookCover);
            }
            List<AccountDTO> accounts = _accountManager.GetAllAccounts();
            foreach(AccountDTO account in accounts)
            {
                ButtonAccount buttonAccount = new ButtonAccount(_logInAccount, account);
                this.flowLayoutPanelAccounts.Controls.Add(buttonAccount);
            }
            List<BookReportDTO> bookReports = _bookReportManager.GetAllBookReports();
            foreach (BookReportDTO bookReport in bookReports)
            {
                dataGridView1.Rows.Add(new string[] { bookReport.Id.ToString(), bookReport.CreateAccountID.ToString(), bookReport.ReportedBookID.ToString() });
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            using (FormAddBook formAddBook = new FormAddBook(_logInAccount))
            {
                formAddBook.ShowDialog();
                if (formAddBook.DialogResult == DialogResult.OK)
                {
                    AdminScreen adminScreen = new AdminScreen(_logInAccount);
                    Utils.ShowScreen(ParentForm, adminScreen);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                string linkValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                BookDTO book = _bookManager.GetBookById(int.Parse(linkValue));
                BookScreen bookScreen = new BookScreen(_logInAccount, book);
                Utils.ShowScreen(ParentForm, bookScreen);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
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
            if (dataGridView1.SelectedRows != null)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                if (MessageBox.Show("Bạn có chắc muốn xóa báo cáo này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(row);
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
    }
}
