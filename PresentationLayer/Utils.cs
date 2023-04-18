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
            parentForm.SuspendLayout();
            foreach (Control childControl in parentForm.Controls)
            {
                childControl.Dispose();
            }
            parentForm.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            parentForm.Controls.Add(screen);
            parentForm.ResumeLayout(false);
            screen.Show();
        }
    }
}
