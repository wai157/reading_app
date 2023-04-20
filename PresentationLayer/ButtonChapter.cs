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
        public ButtonChapter(BookDTO book, ChapterDTO chapter)
        {
            InitializeComponent();
            _book = book;
            _chapter = chapter;
            button1.Text = "Chương " + chapter.No.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReadingApp parentForm = ParentForm as FormReadingApp;
            ChapterScreen chapterScreen = new ChapterScreen(parentForm.LogInAccountDTO.RoleID, _book, _chapter);
            Utils.ShowScreen(ParentForm, chapterScreen);
        }
    }
}
