using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NotificationRepository
    {
        private readonly PBL3DbContext _context;

        public NotificationRepository()
        {
            _context = new PBL3DbContext();
        }

        public List<NotificationDTO> GetNotiById(int accountId)
        {
            List<Notification> notifications = _context.Notifications.Where(x => x.AccountId == accountId)
                .OrderByDescending(x => x.Date)
                .ToList();
            List<NotificationDTO> notificationDTOs = new List<NotificationDTO>();
            foreach (Notification notification in notifications)
            {
                NotificationDTO notificationDTO = Mapper.ToNotificationDTO(notification);
                notificationDTOs.Add(notificationDTO);
            }
            return notificationDTOs;
        }

        public void AddNotification(int accountId, int bookId, string content)
        {
            _context.Notifications.Add(new Notification
            {
                AccountId = accountId,
                BookId = bookId,
                Content = content,
                Date = DateTime.Now
            });
            _context.SaveChanges();
        }

        public void AddNotifications(List<int> accountIds, int bookId, string content)
        {
            List<Notification> notifications = new List<Notification>();
            foreach (int accountId in accountIds)
            {
                notifications.Add(new Notification
                {
                    AccountId = accountId,
                    BookId = bookId,
                    Content = content,
                    Date = DateTime.Now
                });
            }
            _context.Notifications.AddRange(notifications);
            _context.SaveChanges();
        }

        public void DeleteNotification()
        {
            DateTime expirationDate = DateTime.Now.AddDays(-7);
            List<Notification> notifications = _context.Notifications
                                                       .Where(x => x.Date < expirationDate)
                                                       .ToList();

            _context.Notifications.RemoveRange(notifications);
            _context.SaveChanges();
        }
    }
}
