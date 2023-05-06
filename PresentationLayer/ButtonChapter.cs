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
    public partial class ButtonChapter : UserControl
    {
        private readonly BookDTO _book;
        private readonly ChapterDTO _chapter;
        public ButtonChapter(int logInAccountId, BookDTO book, ChapterDTO chapter)
        {
            InitializeComponent();
            if (logInAccountId != book.UploadAccountId)
            {
                buttonEdit.Visible = false;
                button1.Dock = DockStyle.Fill;
            }
            _book = book;
            _chapter = chapter;
            button1.Text = "Chương " + chapter.No.ToString() + ": " + chapter.Title;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReadingApp parentForm = ParentForm as FormReadingApp;
            ChapterScreen chapterScreen = new ChapterScreen(parentForm.LogInAccountDTO, _book, _chapter);
            Utils.ShowScreen(ParentForm, chapterScreen);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (FormEditChap formEditChap = new FormEditChap(_chapter))
            {
                formEditChap.ShowDialog();
                FormReadingApp formReadingApp = ParentForm as FormReadingApp;
                if (_chapter.Id == -1 || formEditChap.DialogResult == DialogResult.OK)
                {
                    BookScreen bookScreen = new BookScreen(formReadingApp.LogInAccountDTO, _book);
                    Utils.ShowScreen(ParentForm, bookScreen);
                }
            }
        }
    }
}
