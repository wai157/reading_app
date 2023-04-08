using DataAccessLayer;
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
    public partial class btnBookCover : UserControl
    {
        public btnBookCover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            BookScreen bookScreen = parentForm.Controls.Find("bookScreen", true).First() as BookScreen;
            //MainScreen mainScreen = parentForm.Controls.Find("mainScreen", true).First() as MainScreen;
            //mainScreen.Hide();
            bookScreen.BringToFront();
        }
    }
}
