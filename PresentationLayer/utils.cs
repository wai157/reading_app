using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class utils
    {
        public static void StealFocus(object sender, EventArgs e)
        {
            //Panel stealPanel = (Panel)sender;
            //stealPanel.Focus();
            Control stealControl = (Control)sender;
            stealControl.Focus();
        }
        public static void ShowScreen(Control screen)
        {
            foreach (Control childControl in screen.Parent.Controls)
            {
                childControl.Hide();
            }
            screen.Show();
        }
    }
}
