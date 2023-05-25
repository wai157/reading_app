using BusinessLogicLayer;
using Common;
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
    public partial class FormChapterVerification : Form
    {
        public string Reason { get; set; }

        public FormChapterVerification(ChapterDTO chapter)
        {
            InitializeComponent();
            labelNo.Text = "Chương số: " + chapter.No.ToString();
            labelTitle.Text = "Tiêu đề: " + chapter.Title;
            textBoxContent.Text = chapter.Content;
        }

        private void FormChapterVerification_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.No)
            {
                e.Cancel = false;
                return;
            }
            FormReason formReason = new FormReason();
            DialogResult confirm = formReason.ShowDialog();
            if (confirm != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                Reason = formReason.Reason;
                e.Cancel = false;
            }
        }
    }
}
