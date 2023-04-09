﻿using DataAccessLayer;
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
    public partial class BookScreen : UserControl
    {
        public BookScreen()
        {
            InitializeComponent();
        }

        public void load(Book book)
        {
            if (book != null)
            {
                pictureBoxCover.Image = Image.FromStream(new MemoryStream(book.BookCover));
                pictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                labelViews.Text = $"Lượt đọc: {book.Views}";
                labelRating.Text = $"Đánh giá: {book.Rating}";
                labelName.Text = book.Name;
                labelAuthor.Text = "Tác giả: " + book.Author;
            }
        }
    }
}
