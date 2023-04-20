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
        private readonly AccountDTO _logInAccount;
        public AdminScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _bookManager = new BookManager();
            _accountManager = new AccountManager();
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
                ButtonAccount buttonAccount = new ButtonAccount(account);
                this.flowLayoutPanelAccounts.Controls.Add(buttonAccount);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook(_logInAccount);
            formAddBook.ShowDialog();
        }

    }
}
