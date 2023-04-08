using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormUserMainScreen : Form
    {
        private readonly BookManager _bookManager;

        public FormUserMainScreen()
        {
            InitializeComponent();
            _bookManager = new BookManager(new BookRepository(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString));
        }

        private void FormUserMainScreen_Load(object sender, EventArgs e)
        {
            List<Book> hotBooks = _bookManager.GetHotBooks();
            foreach (Book hotBook in hotBooks)
            {
                //.BackgroundImage = Image.FromStream(new MemoryStream(hotBook.BookCover));
            }        
        }
    }

}
