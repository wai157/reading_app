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
    public partial class ChapterScreen : UserControl
    {
        private readonly AccountDTO _logInAccount;
        private readonly BookDTO _book;
        private readonly ChapterDTO _chapter;
        private HistoryDTO _history;
        private readonly HistoryManager _historyManager;
        private readonly BookManager _bookManager;
        private readonly ChapterManager _chapterManager;
        public ChapterScreen(AccountDTO logInAccount, BookDTO book, ChapterDTO chapter)
        {
            InitializeComponent();
            _historyManager = new HistoryManager();
            _bookManager = new BookManager();
            _chapterManager = new ChapterManager();
            _logInAccount = logInAccount;
            _book = book;
            _chapter = chapter;
            labelTitle.Text = book.Name + " - Chương " + chapter.No.ToString();
            labelContent.Text = chapter.Content;
            _book.Views += 1;
            _bookManager.IncreaseView(_book.Id);
            _chapterManager.IncreaseView(_chapter.Id);
            _history = _historyManager.GetHistoryOfBook(_logInAccount.Id, _book.Id);
            if (_history != null)
            {
                _historyManager.UpdateHistory(_history, _chapter.Id);
            }
            else
            {
                _historyManager.AddHistory(_logInAccount.Id, _book.Id, _chapter.Id);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BookScreen bookScreen = new BookScreen(_logInAccount, _book);
            Utils.ShowScreen(ParentForm, bookScreen);
        }
    }
}
