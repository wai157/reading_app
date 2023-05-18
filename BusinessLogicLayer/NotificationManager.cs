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
            BookDTO book = _bookRepository.GetBookById(bookId);
            switch (type)
            {
                case -1:
                    content = "Truyện " + book.Name + " của bạn đã không được duyệt!";
                    _notificationRepository.AddNotification(book.UploadAccountId, bookId, content);
                    break;
                case 1:
                    content = "Truyện " + book.Name + " của bạn đã được duyệt!";
                    _notificationRepository.AddNotification(book.UploadAccountId, bookId, content);
                    break;
                case 2:
                    List<int> accountIds = _libraryRepository.GetFollowedIds(bookId);
                    content = "Truyện " + book.Name + " đã có chương mới!";
                    _notificationRepository.AddNotifications(accountIds, bookId, content);
                    break;
            }
        }
    }
}
