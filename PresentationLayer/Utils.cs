using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PresentationLayer
{
    public class Utils
    {
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
        public static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
                return false;

            if (!Regex.IsMatch(password, @"\d"))
                return false;

            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;

            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;

            if (!Regex.IsMatch(password, @"[^\w]"))
                return false;

            return true;
        }
    }
}
