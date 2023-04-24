using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Mapper
    {
        private static readonly PBL3DbContext _context = new PBL3DbContext();

        public static AccountDTO ToAccountDTO(Account account)
        {
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
            return new UserInfoDTO()
            {
                Id = userInfo.Id,
                Name = userInfo.Name,
                Avatar = userInfo.Avatar,
                Sex = userInfo.Sex,
                DOB = userInfo.DOB
            };
        }

        public static BookDTO ToBookDTO(Book book)
        {
            return new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                BookCover = book.Cover,
                Author = _context.Authors.First(x => x.Id == book.AuthorId).Name,
                UploadAccountId = book.AccountId,
                Description = book.Description,
                GenreId = book.GenreId,
                Views = book.Views,
                Follows = _context.Libraries.Where(x => x.BookId == book.Id).Count()
            };
        }

        public static ChapterDTO ToChapterDTO(Chapter chapter)
        {
            return new ChapterDTO
            {
                Id = chapter.Id,
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
            return new GenreDTO
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }

        public static AuthorDTO ToAuthorDTO(Author author)
        {
            return new AuthorDTO
            {
                Id = author.Id,
                Name = author.Name
            };
        }

        public static HistoryDTO ToHistoryDTO(History history)
        {
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
            return new LibraryDTO
            {
                Id = library.Id,
                AccountId = library.AccountId,
                BookId = library.BookId
            };
        }
    }
}
