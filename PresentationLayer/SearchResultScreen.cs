using BusinessLogicLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class SearchResultScreen : UserControl
    {
        private readonly BookManager _bookManager;
        public SearchResultScreen(string search)
        {
            InitializeComponent();
            _bookManager = new BookManager();
            labelResult.Text = "Kết quả tìm kiếm cho: " + search;
            List<BookDTO> books = _bookManager.SearchBooks(search);
            foreach (BookDTO book in books)
            {
                ButtonBookCover bookCover = new ButtonBookCover(book);
                this.flowLayoutResult.Controls.Add(bookCover);
            }
        }
    }
}
