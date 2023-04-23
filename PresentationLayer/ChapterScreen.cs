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
    public partial class ChapterScreen : UserControl
    {
        private readonly AccountDTO _logInAccount;
        private readonly BookDTO _book;
        private readonly ChapterDTO _chapter;

        public ChapterScreen(AccountDTO logInAccount, BookDTO book, ChapterDTO chapter)
        {
            InitializeComponent();
            _logInAccount = logInAccount;
            _book = book;
            _chapter = chapter;
            labelTitle.Text = book.Name + " - Chương " + chapter.No.ToString();
            labelContent.Text = chapter.Content;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BookScreen bookScreen = new BookScreen(_logInAccount, _book);
            Utils.ShowScreen(ParentForm, bookScreen);
        }
    }
}
