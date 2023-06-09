using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ButtonBookCover : UserControl
    {
        private BookDTO _presentedBook;

        public ButtonBookCover(BookDTO book)
        {
            InitializeComponent();
            _presentedBook = book;
            button1.BackgroundImage = Image.FromStream(new MemoryStream(book.BookCover));
            toolTip.SetToolTip(this.button1, _presentedBook.Name);
            label1.Text = book.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReadingApp parentForm = ParentForm as FormReadingApp;
            BookScreen bookScreen = new BookScreen(parentForm.LogInAccountDTO, _presentedBook);
            Utils.ShowScreen(ParentForm, bookScreen);
        }
    }
}
