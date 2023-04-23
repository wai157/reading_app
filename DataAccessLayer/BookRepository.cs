using DataTransferObjectLayer;
using EntityLayer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookRepository
    {
        private readonly PBL3DbContext _context;

        public BookRepository()
        {
            _context = new PBL3DbContext();
        }

        public List<BookDTO> GetHotBooks()
        {
            List<Book> books = _context.Books.OrderByDescending(x => x.Views)
                                             .ThenByDescending(x => x.Likes)
                                             .ThenByDescending(x => x.Rating)
                                             .Take(6)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach(Book book in books)
            {
                BookDTO bookDTO = new BookDTO
                {
                    Id = book.Id,
                    Name = book.Name,
                    BookCover = book.Cover,
                    Author = _context.Authors.First(x => x.Id == book.AuthorId).Name,
                    UploadAccountId = book.AccountId,
                    Description = book.Description,
                    GenreId = book.GenreId,
                    Follows = _context.Libraries.Where(x => x.BookId == book.Id).Count()
                };
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetAllBooks()
        {
            List<Book> books = _context.Books.ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = new BookDTO
                {
                    Id = book.Id,
                    Name = book.Name,
                    BookCover = book.Cover,
                    Author = _context.Authors.First(x => x.Id == book.AuthorId).Name,
                    UploadAccountId = book.AccountId,
                    Description = book.Description,
                    GenreId = book.GenreId,
                    Follows = _context.Libraries.Where(x => x.BookId == book.Id).Count()
                };
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public void AddBook(BookDTO book)
        {
            Author author = _context.Authors.First(x => x.Name == book.Author);
            _context.Books.Add(new Book
            {
                Name = book.Name,
                Description = book.Description,
                Cover = book.BookCover,
                GenreId = book.GenreId,
                AuthorId = author.Id,
                AccountId = book.UploadAccountId
            });
            _context.SaveChanges();
        }

        public void UpdateBook(BookDTO updatedBook)
        {
            Author author = _context.Authors.First(x => x.Name == updatedBook.Author);
            Book book = _context.Books.First(x => x.Id == updatedBook.Id);
            book.Cover = updatedBook.BookCover;
            book.Name = updatedBook.Name;
            book.AuthorId = author.Id;
            book.Description = updatedBook.Description;
            book.GenreId = updatedBook.GenreId;
            _context.SaveChanges();
        }

        public void DeleteBook(int Id)
        {
            Book bookToDelete = _context.Books.FirstOrDefault(x => x.Id == Id);
            if (bookToDelete != null)
            {
                _context.Books.Remove(bookToDelete);
                _context.SaveChanges();
            }
        }

        public List<BookDTO> SearchBooks(string search)
        {
            List<Book> books = _context.Books.Where(x => x.Name.ToLower().Contains(search)).ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = new BookDTO
                {
                    Id = book.Id,
                    Name = book.Name,
                    BookCover = book.Cover,
                    Author = _context.Authors.First(x => x.Id == book.AuthorId).Name,
                    UploadAccountId = book.AccountId,
                    Description = book.Description,
                    GenreId = book.GenreId,
                    Follows = _context.Libraries.Where(x => x.BookId == book.Id).Count()
                };
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }
    }
}
