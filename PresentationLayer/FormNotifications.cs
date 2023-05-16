using BusinessLogicLayer;
using DataTransferObjectLayer;
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
    public partial class FormNotifications : Form
    {
        private readonly NotificationManager _notificationManager;
        private readonly BookManager _bookManager;
        public FormNotifications(int logInAccountId)
        {
            InitializeComponent();
            _notificationManager = new NotificationManager();
            _bookManager = new BookManager();
            List<NotificationDTO> notifications = _notificationManager.GetNotiById(logInAccountId);
            foreach (NotificationDTO notification in notifications)
            {
                BookDTO book = _bookManager.GetBookById(notification.BookID);
                ButtonNotification notification1 = new ButtonNotification(book, notification.Content);
                this.flowLayoutPanel.Controls.Add(notification1);
            }
            if (notifications.Count == 0) label1.Text = "Hiện không có thông báo mới!";
            this.flowLayoutPanel.Controls.Add(this.label1);
        }
    }
}
