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
    public partial class FormRating : Form
    {
        private readonly RatedBookManager _ratedBookManager;
        private readonly int _accountId;
        private readonly int _bookId;
        private int _rating;

        public FormRating(int logInAccountId, int bookId)
        {
            InitializeComponent();
            _ratedBookManager = new RatedBookManager();
            _accountId = logInAccountId;
            _bookId = bookId;
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            _rating = (int)pictureBox.Tag;

            for (int i = 0; i < _rating; i++)
            {
                ((PictureBox)flowLayoutPanel1.Controls[i]).BackgroundImage = Properties.Resources.star_fill;
            }
            for (int i = _rating; i < 5; i++)
            {
                ((PictureBox)flowLayoutPanel1.Controls[i]).BackgroundImage = Properties.Resources.star_empty;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            _ratedBookManager.AddRatedBook(_accountId, _bookId, _rating);
            this.Close();
        }
    }
}
