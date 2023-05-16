using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class NotificationManager
    {
        private readonly NotificationRepository _notificationRepository;
        private readonly BookRepository _bookRepository;
        private readonly LibraryRepository _libraryRepository;
        public NotificationManager()
        {
            _notificationRepository = new NotificationRepository();
            _bookRepository = new BookRepository();
            _libraryRepository = new LibraryRepository();
        }
        public List<NotificationDTO> GetNotiById(int accountId)
        {
            _notificationRepository.DeleteNotification();
            return _notificationRepository.GetNotiById(accountId);
        }

        public void AddNotification(int type, int bookId)
        {
            _notificationRepository.DeleteNotification();
            string content;
            switch (type)
            {
                case 1:
                    int accountId = _bookRepository.GetBookById(bookId).UploadAccountId;
                    content = "Truyện của bạn đã được duyệt!";
                    _notificationRepository.AddNotification(accountId, bookId, content);
                    break;
                case 2:
                    string bookName = _bookRepository.GetBookById(bookId).Name;
                    List<int> accountIds = _libraryRepository.GetFollowedIds(bookId);
                    content = "Truyện " + bookName + " đã có chương mới!";
                    _notificationRepository.AddNotifications(accountIds, bookId, content);
                    break;
            }
        }
    }
}
