using DataTransferObjectLayer;
using BusinessLogicLayer;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PresentationLayer
{
    public partial class MainScreen : UserControl
    {
        private readonly BookManager _bookManager;

        public MainScreen(AccountDTO logInAccountDTO)
        {
            InitializeComponent();
            _bookManager = new BookManager(); List<BookDTO> hotBooks = _bookManager.GetHotBooks();
            foreach (BookDTO book in hotBooks)
            {
                ButtonBookCover bookCover = new ButtonBookCover(book);
                this.flowLayoutPanelHotBooks.Controls.Add(bookCover);
            }
            List<BookDTO> books = _bookManager.GetAllVerifiedBooks();
            foreach (BookDTO book in books)
            {
                ButtonBookCover bookCover = new ButtonBookCover(book);
                this.flowLayoutPanelAllBooks.Controls.Add(bookCover);
            }
        }

    }
}
