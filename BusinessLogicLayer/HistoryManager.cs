using DataAccessLayer;
using DataTransferObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class HistoryManager
    {
        private readonly HistoryRepository _repository;

        public HistoryManager()
        {
            _repository = new HistoryRepository();
        }

        public List<HistoryDTO> GetHistoryByAccountId(int accountId)
        {
            return _repository.GetHistoryByAccountId(accountId);
        }

        public HistoryDTO GetHistoryOfBook(int accountId, int bookId)
        {
            return _repository.GetHistoryByAccountId(accountId)
                              .FirstOrDefault(x => x.BookId == bookId);
        }

        public void AddHistory(int accountId, int bookId, int chapterId)
        {
            HistoryDTO historyDTO = new HistoryDTO
            {
                AccountId = accountId,
                BookId = bookId,
                ReadChapterIds = new List<int>() { chapterId }
            };
            _repository.AddHistory(historyDTO);
        }

        public void UpdateHistory(HistoryDTO history, int chapterId)
        {
            if (history.ReadChapterIds.Contains(chapterId))
            {
                history.ReadChapterIds.Remove(chapterId);
            }
            history.ReadChapterIds.Add(chapterId);
            _repository.UpdateHistory(history);
        }

        public void DeleteFromHistory(int bookId, int chapterId)
        {
            List<HistoryDTO> historyDTOs = _repository.GetHistoryByBookId(bookId);
            foreach (HistoryDTO history in historyDTOs)
            {
                if (history.ReadChapterIds.Contains(chapterId))
                {
                    history.ReadChapterIds.Remove(chapterId);
                    _repository.UpdateHistory(history);
                }
            }
        }
    }
}
