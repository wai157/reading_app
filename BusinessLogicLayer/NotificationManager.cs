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
        private readonly ChapterRepository _chapterRepository;
        private readonly LibraryRepository _libraryRepository;
        public NotificationManager()
        {
            _notificationRepository = new NotificationRepository();
            _bookRepository = new BookRepository();
            _chapterRepository = new ChapterRepository();
            _libraryRepository = new LibraryRepository();
        }
        public List<NotificationDTO> GetNotiById(int accountId)
        {
            _notificationRepository.DeleteNotification();
            return _notificationRepository.GetNotiById(accountId);
        }

        public void AddNotification(int type, int bookId, string reason="", int chapterId = -1)
        {
            _notificationRepository.DeleteNotification();
            string content;
            BookDTO book = _bookRepository.GetBookById(bookId);
            ChapterDTO chapter;
            switch (type)
            {
                case -1:
                    content = "Truyện " + book.Name + " của bạn đã không được duyệt! Lí do: " + reason;
                    _notificationRepository.AddNotification(book.UploadAccountId, bookId, content);
                    break;
                case 1:
                    content = "Truyện " + book.Name + " của bạn đã được duyệt! Bây giờ bạn có thể thêm các chương vào truyện.";
                    _notificationRepository.AddNotification(book.UploadAccountId, bookId, content);
                    break;
                case 2:
                    List<int> accountIds = _libraryRepository.GetFollowedIds(bookId);
                    content = "Truyện " + book.Name + " đã có chương mới! Bấm vào để đọc ngay!";
                    _notificationRepository.AddNotifications(accountIds, bookId, content);
                    break;
                case -3:
                    chapter = _chapterRepository.GetChapterById(chapterId);
                    content = "Chương số " + chapter.No.ToString() + ": " + chapter.Title + " của truyện " + book.Name + " của bạn đã không được duyệt! Lí do: " + reason;
                    _notificationRepository.AddNotification(book.UploadAccountId, bookId, content);
                    break;
                case 3:
                    chapter = _chapterRepository.GetChapterById(chapterId);
                    content = "Chương số " + chapter.No.ToString() + ": " + chapter.Title + " của truyện " + book.Name + " của bạn đã được duyệt!";
                    _notificationRepository.AddNotification(book.UploadAccountId, bookId, content);
                    break;
            }
        }
    }
}
