using DataAccessLayer;
using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace PresentationLayer
{
    public partial class MainScreen : UserControl
    {
        private readonly BookManager _bookManager;

        public MainScreen()
        {
            InitializeComponent();
            _bookManager = new BookManager(new BookRepository(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString));
        }
        public void LoadBooks(Account logInAcc)
        {
            List<Book> hotBooks = _bookManager.GetHotBooks();
            List<btnBookCover> btnHotBooks = new List<btnBookCover>
            {
                btnHotBookCover1,
                btnHotBookCover2,
                btnHotBookCover3,
                btnHotBookCover4,
                btnHotBookCover5,
                btnHotBookCover6,
            };
            for (int i = 0; i < hotBooks.Count; i++)
            {
                btnHotBooks[i].PresentedBook = hotBooks[i];
                btnHotBooks[i].Button.BackgroundImage = Image.FromStream(new MemoryStream(hotBooks[i].BookCover));
            }
        }
    }
}
