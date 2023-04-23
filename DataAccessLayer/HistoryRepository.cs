using DataTransferObjectLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class HistoryRepository
    {
        private readonly PBL3DbContext _context;

        public HistoryRepository()
        {
            _context = new PBL3DbContext();
        }

        public List<HistoryDTO> GetHistoryByAccountId (int accountId)
        {
            List<History> histories = _context.Histories.Where(x => x.AccountId == accountId).ToList();
            List<HistoryDTO> historyDTOs = new List<HistoryDTO>();
            foreach (History history in histories)
            {
                historyDTOs.Add(new HistoryDTO
                {
                    Id = history.Id,
                    AccountId = history.AccountId,
                    BookId = history.BookId,
                    ReadChapterIds = history.ReadChapterIds.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                           .ToList()
                                                           .Select(int.Parse)
                                                           .ToList()
                });
            }
            return historyDTOs;
        }

        public void AddHistory(HistoryDTO historyDTO)
        {
            _context.Histories.Add(new History
            {
                AccountId = historyDTO.AccountId,
                BookId = historyDTO.BookId,
                ReadChapterIds = string.Join(",", historyDTO.ReadChapterIds)
            });
            _context.SaveChanges();
        }

        public void UpdateHistory(HistoryDTO historyDTO)
        {
            History history = _context.Histories.First(x => x.Id == historyDTO.Id);
            history.ReadChapterIds = string.Join(",", historyDTO.ReadChapterIds);
            _context.SaveChanges();
        }
    }
}
