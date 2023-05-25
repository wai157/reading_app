using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Mapper
    {
        public static AccountDTO ToAccountDTO(Account account)
        {
            if (account == null) return null;
            return new AccountDTO
            {
                Id = account.Id,
                Username = account.Username,
                Email = account.Email,
                Password = account.Password,
                RoleID = account.RoleId
            };
        }

        public static UserInfoDTO ToUserInfoDTO(UserInfo userInfo)
        {
            if (userInfo == null) return null;
            return new UserInfoDTO()
            {
                Id = userInfo.Id,
                Name = userInfo.Name,
                Avatar = userInfo.Avatar,
                Sex = userInfo.Sex,
                DOB = userInfo.DOB
            };
        }

        public static VerificationDTO ToVerificationDTO(Verification verification)
        {
            if (verification == null) return null;
            return new VerificationDTO
            {
                Id = verification.Id,
                Code = verification.Code,
                RequestedDateTime = verification.RequestedDateTime
            };
        }

        public static BookDTO ToBookDTO(Book book)
        {
            if (book == null) return null;
            using (var context = new PBL3DbContext())
            {
                return new BookDTO
                {
                    Id = book.Id,
                    IsVerified = book.IsVerified,
                    Name = book.Name,
                    BookCover = book.Cover,
                    Author = context.Authors.First(x => x.Id == book.AuthorId).Name,
                    UploadAccountId = book.AccountId,
                    Description = book.Description,
                    GenreId = book.GenreId,
                    Views = book.Views,
                    Follows = context.Libraries.Where(x => x.BookId == book.Id).Count()
                };
            };
        }

        public static ChapterDTO ToChapterDTO(Chapter chapter)
        {
            if (chapter == null) return null;
            return new ChapterDTO
            {
                Id = chapter.Id,
                IsVerified = chapter.IsVerified,
                No = chapter.No,
                Title = chapter.Title,
                Content = chapter.Content,
                BookId = chapter.BookId,
                Views = chapter.Views,
                Likes = chapter.Likes
            };
        }

        public static GenreDTO ToGenreDTO(Genre genre)
        {
            if (genre == null) return null;
            return new GenreDTO
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }

        public static AuthorDTO ToAuthorDTO(Author author)
        {
            if (author == null) return null;
            return new AuthorDTO
            {
                Id = author.Id,
                Name = author.Name
            };
        }

        public static HistoryDTO ToHistoryDTO(History history)
        {
            if (history == null) return null;
            return new HistoryDTO
            {
                Id = history.Id,
                AccountId = history.AccountId,
                BookId = history.BookId,
                ReadChapterIds = history.ReadChapterIds.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                       .ToList()
                                                       .Select(int.Parse)
                                                       .ToList()
            };
        }

        public static LibraryDTO ToLibraryDTO(Library library)
        {
            if (library == null) return null;
            return new LibraryDTO
            {
                Id = library.Id,
                AccountId = library.AccountId,
                BookId = library.BookId
            };
        }

        public static BookReportDTO ToBookReportDTO(BookReport bookReport)
        {
            if (bookReport == null) return null;
            return new BookReportDTO
            {
                Id = bookReport.Id,
                CreateAccountID = bookReport.AccountID,
                ReportedBookID = bookReport.BookID,
                Content = bookReport.Content
            };
        }

        public static RatedBookDTO ToRatedBookDTO(RatedBook ratedBook)
        {
            if (ratedBook == null) return null;
            return new RatedBookDTO
            {
                Id = ratedBook.Id,
                AccountId = ratedBook.AccountId,
                BookId = ratedBook.BookId,
                Rating = ratedBook.Rating
            };
        }

        public static NotificationDTO ToNotificationDTO(Notification notification)
        {
            if (notification == null) return null;
            return new NotificationDTO
            {
                Id = notification.Id,
                AccountID = notification.AccountId,
                BookID = notification.BookId,
                Content = notification.Content
            };
        }
    }
}
