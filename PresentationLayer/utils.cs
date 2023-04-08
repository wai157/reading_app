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
            if (sender.GetType() == typeof(Panel))
            {
                Panel stealPanel = (Panel)sender;
                stealPanel.Focus();
            }
        }
    }
}
