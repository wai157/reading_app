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

namespace UserControls
{
    public partial class ButtonBookCover : UserControl
    {
        private BookDTO presentedBook;
        public BookDTO PresentedBook
        {
            get { return presentedBook; }
            set { presentedBook = value; }
        }

        public ButtonBookCover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            BookScreen bookScreen = parentForm.Controls.Find("bookScreen", true).First() as BookScreen;
            bookScreen.Load_Book(presentedBook);
            Utils.ShowScreen(bookScreen);
        }
    }
}
