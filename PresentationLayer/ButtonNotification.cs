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
    public partial class ButtonNotification : UserControl
    {
        private BookDTO _presentedBook;

        public ButtonNotification(BookDTO book, string content)
        {
            InitializeComponent();
            _presentedBook = book;
            button1.Text = content;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormReadingApp parentForm)
                {
                    BookScreen bookScreen = new BookScreen(parentForm.LogInAccountDTO, _presentedBook);
                    Utils.ShowScreen(parentForm, bookScreen);
                    break;
                }
            }
        }
    }
}
