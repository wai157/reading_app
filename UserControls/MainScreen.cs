using DataTransferObjectLayer;
using BusinessLogicLayer;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace UserControls
{
    public partial class MainScreen : UserControl
    {
        private readonly BookManager _bookManager;

        public MainScreen()
        {
            InitializeComponent();
            _bookManager = new BookManager();
        }
        public void LoadScreen(AccountDTO logInAcc)
        {
            List<BookDTO> hotBooks = _bookManager.GetHotBooks();
            List<ButtonBookCover> btnHotBooks = new List<ButtonBookCover>
            {
                btnHotBookCover1,
                btnHotBookCover2,
                btnHotBookCover3,
                btnHotBookCover4,
                btnHotBookCover5,
                btnHotBookCover6,
            };
            for (int i = 0; i < 6; i++)
            {
                btnHotBooks[i].PresentedBook = hotBooks[i];
                btnHotBooks[i].Button.BackgroundImage = Image.FromStream(new MemoryStream(hotBooks[i].BookCover));
            }
        }
    }
}
