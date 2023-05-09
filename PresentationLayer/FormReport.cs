using BusinessLogicLayer;
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
    public partial class FormReport : Form
    {
        private readonly BookReportManager _bookReportManager;
        private readonly int _logInAccountId;
        private readonly int _bookId;
        public FormReport(int logInAccountId, int bookId)
        {
            InitializeComponent();
            _bookReportManager = new BookReportManager();
            _logInAccountId = logInAccountId;
            _bookId = bookId;
        }

        private void FormReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(textBoxContent.Text))
                {
                    errorProvider.SetError(textBoxContent, "Không được bỏ trống!");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(textBoxContent, null);
                    _bookReportManager.AddBookReport(_logInAccountId, _bookId, textBoxContent.Text);
                    e.Cancel = false;
                    MessageBox.Show("Báo cáo thành công!");
                }
            }
        }
    }
}
