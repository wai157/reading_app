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
        public BookDTO PresentedBook { get; set; }

        public ButtonBookCover(BookDTO book)
        {
            InitializeComponent();
            PresentedBook = book;
            button1.BackgroundImage = Image.FromStream(new MemoryStream(book.BookCover));
            toolTip.SetToolTip(this.button1, PresentedBook.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReadingApp parentForm = ParentForm as FormReadingApp;
            BookScreen bookScreen = new BookScreen(parentForm.LogInAccountDTO.RoleID, PresentedBook);
            Utils.ShowScreen(ParentForm, bookScreen);
        }
    }
}
