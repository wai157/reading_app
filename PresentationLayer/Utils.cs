using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class Utils
    {
        public static void StealFocus(object sender, EventArgs e)
        {
            Control stealControl = (Control)sender;
            stealControl.Focus();
        }
        public static void ShowScreen(Form parentForm, Control screen)
        {
            foreach (Control childControl in parentForm.Controls)
            {
                childControl.Dispose();
            }
            parentForm.Controls.Clear();
            parentForm.Controls.Add(screen);
            screen.Dock = DockStyle.Fill;
            screen.Show();
        }
    }
}
