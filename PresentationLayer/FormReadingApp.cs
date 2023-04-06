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
    public partial class FormReadingApp : Form
    {
        public FormReadingApp()
        {
            InitializeComponent();
            Form formLogIn = new FormLogInScreen();
            formLogIn.TopLevel = false;
            this.Controls.Add(formLogIn);
            formLogIn.FormBorderStyle = FormBorderStyle.None;
            formLogIn.Dock = DockStyle.Fill;
            formLogIn.Show();
        }
    }
}
