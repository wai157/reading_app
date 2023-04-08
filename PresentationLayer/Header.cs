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
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }
        
        private void buttonHome_Click(object sender, EventArgs e)
        {
            Form parentForm = FindForm();
            MainScreen mainScreen = parentForm.Controls.Find("mainScreen", true).First() as MainScreen;
            mainScreen.BringToFront();
        }
    }
}
