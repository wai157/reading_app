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
    public partial class FormBookReportView : Form
    {
        private readonly BookReportManager _bookReportManager;
        public FormBookReportView(int id)
        {
            InitializeComponent();
            _bookReportManager = new BookReportManager();
            BookReportDTO bookReport = _bookReportManager.GetBookReportById(id);
            labelCreateAccountId.Text = "Id người tạo: " + bookReport.CreateAccountID;
            labelReportedBookId.Text = "Id sách: " + bookReport.ReportedBookID;
            textBoxContent.Text = bookReport.Content;
        }
    }
}
