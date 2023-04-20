using BusinessLogicLayer;
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
    public partial class FormAddChap : Form
    {
        private readonly ChapterManager _chapterManager;
        private readonly ChapterDTO _chapter;
        private readonly BookDTO _book;
        public FormAddChap(BookDTO book)
        {
            InitializeComponent();
            _chapterManager = new ChapterManager();
            _chapter = new ChapterDTO();
            _book = book;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filePath = fileDialog.FileName.Split('\\');
                labelFile.Text = filePath[filePath.Length - 1];
                labelFile.Visible = true;
                buttonDel.Visible = true;
                buttonDel.Enabled = true;
                buttonDel.Location = new Point(labelFile.Location.X + labelFile.Size.Width + 3, 92);
                buttonAdd.Visible = false;
                buttonAdd.Enabled = false;
                using (StreamReader streamReader = new StreamReader(fileDialog.FileName))
                {
                    _chapter.Content = streamReader.ReadToEnd();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            labelFile.Visible = false;
            buttonDel.Visible = false;
            buttonDel.Enabled = false;
            buttonAdd.Visible = true;
            buttonAdd.Enabled = true;
            _chapter.Content = null;
            labelFile.Text = null;
        }

        private void FormAddChap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                ValidateChildren(ValidationConstraints.Enabled);
                if(string.IsNullOrEmpty(errorProvider.GetError(maskedTextBoxNo)) == false
                   || string.IsNullOrEmpty(errorProvider.GetError(textBoxTitle)) == false
                   || string.IsNullOrEmpty(errorProvider.GetError(buttonAdd)) == false)
                {
                    MessageBox.Show("Không được bỏ trống những vùng bắt buộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    _chapter.No = int.Parse(maskedTextBoxNo.Text);
                    _chapter.Title = textBoxTitle.Text;
                    _chapter.BookId = _book.Id;
                    _chapterManager.AddChapter(_chapter);
                    MessageBox.Show("Thêm chương sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = false;
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Hủy thêm chương sách!", "Hủy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }

        private void maskedTextBoxNo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxNo.Text))
            {
                errorProvider.SetError(maskedTextBoxNo, "Vui lòng nhập số chương!");
            }
            else
            {
                errorProvider.SetError(maskedTextBoxNo, null);
            }
        }

        private void textBoxTitle_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                errorProvider.SetError(textBoxTitle, "Vui lòng nhập tiêu đề chương!");
            }
            else
            {
                errorProvider.SetError(textBoxTitle, null);
            }
        }

        private void labelFile_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(labelFile.Text))
            {
                errorProvider.SetError(buttonAdd, "Vui lòng chọn tệp chứa nội dung chương!");
            }
            else
            {
                errorProvider.SetError(buttonAdd, null);
            }
        }

        private void maskedTextBoxNo_RemoveText(object sender, EventArgs e)
        {
            int index = maskedTextBoxNo.MaskedTextProvider.FindUnassignedEditPositionFrom(0, true);
            if (index >= 0) maskedTextBoxNo.SelectionStart = index;
        }
    }
}
