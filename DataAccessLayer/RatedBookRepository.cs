using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RatedBookRepository
    {
        private readonly PBL3DbContext _context;

        public RatedBookRepository()
        {
            _context = new PBL3DbContext();
        }

        public List<RatedBookDTO> GetRatedBookByAccountId(int accountId)
        {
            List<RatedBook> ratedBooks = _context.RatedBooks.Where(x => x.AccountId == accountId).ToList();
            List<RatedBookDTO> ratedBookDTOs = new List<RatedBookDTO>();
            foreach (RatedBook ratedBook in ratedBooks)
            {
                ratedBookDTOs.Add(Mapper.ToRatedBookDTO(ratedBook));
            }
            return ratedBookDTOs;
        }

        public List<int> GetRatingListByBookId(int bookId)
        {
            return _context.RatedBooks.Where(x => x.BookId == bookId).Select(x => x.Rating).ToList();
        }

        public void AddRatedBook(RatedBookDTO ratedBookDTO)
        {
            _context.RatedBooks.Add(new RatedBook
            {
                AccountId = ratedBookDTO.AccountId,
                BookId = ratedBookDTO.BookId,
                Rating = ratedBookDTO.Rating
            });
            _context.SaveChanges();
        }

        public void UpdateRatedBook(RatedBookDTO ratedBookDTO)
        {
            RatedBook ratedBook = _context.RatedBooks.First(x => x.Id == ratedBookDTO.Id);
            ratedBook.Rating = ratedBookDTO.Rating;
            _context.SaveChanges();
        }
    }
}
