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
        private readonly ChapterDTO _chapter, _prev, _next;
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
            labelTitle.Text = book.Name + " - Chương " + chapter.No.ToString() + ": " + chapter.Title;
            labelContent.Text = chapter.Content;
            _book.Views += 1;
            _bookManager.IncreaseView(_book.Id);
            _chapterManager.IncreaseView(_chapter.Id);
            if (_logInAccount != null) {
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
            List<ChapterDTO> chapters = _chapterManager.GetAllVerifiedChaptersOf(book);
            int index = chapters.FindIndex(x => x.No == chapter.No);
            if (index == 0)
            {
                _next = null;
                buttonNext.Enabled = false;
                buttonNext.Visible = false;
            }
            else
            {
                _next = chapters[index - 1];
            }
            if (index == chapters.Count-1)
            {
                _prev = null;
                buttonPrev.Enabled = false;
                buttonPrev.Visible = false;
            }
            else
            {
                _prev = chapters[index + 1];
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BookScreen bookScreen = new BookScreen(_logInAccount, _book);
            Utils.ShowScreen(ParentForm, bookScreen);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (_prev != null)
            {
                ChapterScreen chapterScreen = new ChapterScreen(_logInAccount, _book, _prev);
                Utils.ShowScreen(ParentForm, chapterScreen);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_next != null)
            {
                ChapterScreen chapterScreen = new ChapterScreen(_logInAccount, _book, _next);
                Utils.ShowScreen(ParentForm, chapterScreen);
            }
        }
    }
}
