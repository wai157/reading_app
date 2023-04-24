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
    public partial class GeneralScreen : UserControl
    {
        private readonly BookManager _bookManager;
        private readonly GenreManager _genreManager;

        public GeneralScreen(int purpose, string search)
        {
            InitializeComponent();
            _bookManager = new BookManager();
            if (purpose == 0)
            {
                labelResult.Text = "Kết quả tìm kiếm cho: " + search;
                List<BookDTO> books = _bookManager.GetSearchBooks(search);
                foreach (BookDTO book in books)
                {
                    ButtonBookCover bookCover = new ButtonBookCover(book);
                    this.flowLayoutResult.Controls.Add(bookCover);
                }
            }
            else if (purpose == 1)
            {
                _genreManager = new GenreManager();
                labelResult.Text = "Các sách thể loại: " + _genreManager.GetGenreById(int.Parse(search)).Name;
                List<BookDTO> books = _bookManager.GetBooksByGenreId(int.Parse(search));
                foreach (BookDTO book in books)
                {
                    ButtonBookCover bookCover = new ButtonBookCover(book);
                    this.flowLayoutResult.Controls.Add(bookCover);
                }
            }
            else if (purpose == 2)
            {
                labelResult.Text = "Các sách của tác giả: " + search;
                List<BookDTO> books = _bookManager.GetBooksByAuthorName(search);
                foreach (BookDTO book in books)
                {
                    ButtonBookCover bookCover = new ButtonBookCover(book);
                    this.flowLayoutResult.Controls.Add(bookCover);
                }
            }
        }
    }
}
