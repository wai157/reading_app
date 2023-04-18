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
        private readonly AccountDTO _logInAccount;
        public AdminScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _bookManager = new BookManager();
            _logInAccount = logInAccountDTO;
            List<BookDTO> books = _bookManager.GetAllBooks();
            foreach (BookDTO book in books)
            {
                ButtonBookCover bookCover = new ButtonBookCover();
                bookCover.PresentedBook = book;
                bookCover.Button.BackgroundImage = Image.FromStream(new MemoryStream(book.BookCover));
                this.flowLayoutPanelBooks.Controls.Add(bookCover);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook(_logInAccount);
            formAddBook.ShowDialog();
        }
    }
}
