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
    public partial class FormReason : Form
    {
        public string Reason { get; set; }
        public FormReason()
        {
            InitializeComponent();
        }

        private void FormReason_FormClosing(object sender, FormClosingEventArgs e)
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
                    Reason = textBoxContent.Text.Trim();
                    e.Cancel = false;
                }
            }
        }
    }
}
