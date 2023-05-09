using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class RatedBookManager
    {
        private readonly RatedBookRepository _ratedBookRepository;

        public RatedBookManager()
        {
            _ratedBookRepository = new RatedBookRepository();
        }

        public List<RatedBookDTO> GetRatedBookByAccountId(int accountId)
        {
            return _ratedBookRepository.GetRatedBookByAccountId(accountId);
        }

        public double GetRatingListByBookId(int bookId, out int num)
        {
            List<int> ratings = _ratedBookRepository.GetRatingListByBookId(bookId);
            num = ratings.Count();
            if (num > 0)
                return ratings.Average();
            else
                return 0;
        }

        public void AddRatedBook(int accountId, int bookId, int rating)
        {
            List<RatedBookDTO> ratedBook = GetRatedBookByAccountId(accountId);
            if (ratedBook.Select(x => x.BookId).Contains(bookId))
            {
                UpdateRatedBook(ratedBook.First(x => x.BookId == bookId), rating);
            }
            else
            {
                _ratedBookRepository.AddRatedBook(new RatedBookDTO
                {
                    AccountId = accountId,
                    BookId = bookId,
                    Rating = rating
                });
            }
        }

        public void UpdateRatedBook(RatedBookDTO ratedBookDTO, int newRating)
        {
            ratedBookDTO.Rating = newRating;
            _ratedBookRepository.UpdateRatedBook(ratedBookDTO);
        }
    }
}
