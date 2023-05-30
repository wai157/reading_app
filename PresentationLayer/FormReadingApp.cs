using BusinessLogicLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        public AccountDTO LogInAccountDTO { get; set; }

        public FormReadingApp()
        {
            InitializeComponent();
            MainScreen mainScreen = new MainScreen(null);
            Utils.ShowScreen(this, mainScreen);
        }
    }
}
