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

        public BookDTO GetBookById(int Id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == Id);
            return Mapper.ToBookDTO(book);
        }

        public List<BookDTO> GetBooksUploadById(int accountId)
        {
            List<Book> books = _context.Books.Where(x => x.AccountId == accountId && x.IsVerified == true)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetHotBooks()
        {
            List<Book> books = _context.Books.Where(x => x.IsVerified == true)
                                             .OrderByDescending(x => x.Views)
                                             .ThenByDescending(x => _context.Libraries.Where(s => s.BookId == x.Id).Count())
                                             .ThenByDescending(x => _context.RatedBooks.Where(s => s.BookId == x.Id).Select(s => s.Rating).DefaultIfEmpty(0).Average())
                                             .Take(6)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach(Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetVerifiedBooksByGenreId(int genreId)
        {
            List<Book> books = _context.Books.Where(x => x.GenreId == genreId && x.IsVerified == true)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetVerifiedBooksByAuthorId(int authorId)
        {
            List<Book> books = _context.Books.Where(x => x.AuthorId == authorId && x.IsVerified == true)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetAllVerifiedBooks()
        {
            List<Book> books = _context.Books.Where(x => x.IsVerified == true).ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public List<BookDTO> GetAllUnverifiedBooks()
        {
            List<Book> books = _context.Books.Where(x => x.IsVerified == false).ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public void AddBook(BookDTO book)
        {
            Author author = _context.Authors.FirstOrDefault(x => x.Name == book.Author)
                            ?? _context.Authors.First(x => x.Id == 1); ;
            _context.Books.Add(new Book
            {
                IsVerified = false,
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
            Author author = _context.Authors.FirstOrDefault(x => x.Name == updatedBook.Author) 
                            ?? _context.Authors.First(x => x.Id == 1);
            Book book = _context.Books.First(x => x.Id == updatedBook.Id);
            book.IsVerified = false;
            book.Cover = updatedBook.BookCover;
            book.Name = updatedBook.Name;
            book.AuthorId = author.Id;
            book.Description = updatedBook.Description;
            book.GenreId = updatedBook.GenreId;
            _context.SaveChanges();
        }

        public void VerifyBook(int bookId)
        {
            Book book = _context.Books.First(x => x.Id == bookId);
            book.IsVerified = true;
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

        public List<BookDTO> GetSearchBooks(string search)
        {
            List<Book> books = _context.Books.Where(x => x.Name.ToLower().Contains(search) && x.IsVerified == true)
                                             .ToList();
            List<BookDTO> bookDTOs = new List<BookDTO>();
            foreach (Book book in books)
            {
                BookDTO bookDTO = Mapper.ToBookDTO(book);
                bookDTOs.Add(bookDTO);
            }
            return bookDTOs;
        }

        public void IncreaseView(int Id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == Id);
            book.Views += 1;
            _context.SaveChanges();
        }
    }
}
