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

namespace UserControls
{
    public partial class AdminScreen : UserControl
    {
        private readonly BookManager _bookManager;
        public AdminScreen()
        {
            InitializeComponent();
            _bookManager = new BookManager();
        }

        public void LoadScreen(AccountDTO logInAccount)
        {
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
            FormAddBook formAddBook = new FormAddBook();
            formAddBook.ShowDialog();
            if (formAddBook.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Thêm sách thành công!");
                formAddBook.Dispose();
            }
            else
            {
                MessageBox.Show("Hủy thêm sách!");
                formAddBook.Dispose();
            }
        }
    }
}
