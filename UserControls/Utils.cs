using System;
using System.Windows.Forms;

namespace UserControls
{
    public class Utils
    {
        public static void StealFocus(object sender, EventArgs e)
        {
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
