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
            Size textSize = TextRenderer.MeasureText(content, button1.Font);
            this.Height = Math.Max(60, 30 * (int)Math.Ceiling((double)textSize.Width / (this.Width - 10)) + 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_presentedBook == null || _presentedBook.IsVerified == false)
            {
                MessageBox.Show("Truyện đang được kiểm duyệt hoặc đã bị xóa!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
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
